using System;

using System.Data;
using System.Data.SqlClient;

namespace Acuario.Managers
{
    public class ManagerDB
    {
        // |==============================ATRIBUTOS==============================|

        private String PC_NAME = System.Environment.MachineName;
        private String dbName = "Acuario";
        private static String DB_INSTANCE = "SQLEXPRESS";
        private static ManagerDB instance;
        public static ManagerDB Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerDB();

                return instance;
            }
        }
        private SqlConnection sqlConnection;
        //FileName del script de creación de bdd
        private String createDBScriptFileName;
        //Path del script de creación de bdd
        private String createDBScriptFilePath;

        // |==============================CONSTRUCTORES==============================|

        private ManagerDB()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        /* Requerido
         * */
        public Boolean Init()
        {
            InitSqlCon();
            this.createDBScriptFileName = "SistemaBase 1.0.0.sql";//TODO: Set scriptFileName
            this.createDBScriptFilePath = @"C:\Program Files\Me\Work\LUDEBE Sistemas\SistemaBase\SistemaBase 1.0.0\Base de datos\1.0.0";//TODO: Set scriptPath
            return true;
        }

        public Boolean Execute(String query)
        {
            //Si se abrió correctamente la conexión
            if (TryOpenConnection() && !query.Equals(String.Empty))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException e)
                {
                    ManagerExceptions.Instance.CatchException(e);
                    return false;
                }
                finally { CloseConnection(); }
            }

            else
                return false;
        }

        public DataTable ExecuteQuery(String query)
        {
            DataTable dataTable = null;

            //Si se abrió correctamente la conexión
            if (TryOpenConnection() && !query.Equals(String.Empty))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                }
                catch (SqlException)
                {
                }
                finally { CloseConnection(); }
            }

            return dataTable;
        }

        public Boolean GenerateBackup()
        {
            if (TryOpenConnection())
            {
                try
                {
                    String fileName = dbName + " " + DateTime.Today.ToShortDateString().Replace("/", "-");
                    String query = "BACKUP DATABASE SistemaBase "//TODO: Nombre BDD
                                   + @"TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\Backup\" + fileName + ".bak' WITH FORMAT";
                    SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                    sqlcmd.ExecuteNonQuery();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
                finally { CloseConnection(); }
            }

            else
                return false;
        }

        public Boolean DBExists()
        {
            Boolean exists = false;

            ChangeDbName("master");
            try
            {
                DataTable dt = ExecuteQuery("IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = 'SistemaBase' OR "
                + "name = 'SistemaBase'))) SELECT 1 ELSE SELECT 0");//TODO: Nombre BDD 2 veces

                if (dt.Rows[0][0].ToString().Equals("1"))
                    exists = true;
            }

            catch (Exception)
            {
            }

            finally
            {
                ChangeDbName("SistemaBase");//TODO: Nombre BDD
            }

            return exists;
        }

        public Boolean CreateDB()
        {
            ChangeDbName("master");

            //Crea la BDD
            //Todo: Remover para iniciar normalmente
            Environment.Exit(0);
            String query = System.IO.File.ReadAllText(createDBScriptFilePath + @"\" + createDBScriptFileName).Replace("�", "ñ");

            String[] querys = query.Split(new string[] { "GO" }, StringSplitOptions.None);

            if (Execute("CREATE DATABASE SistemaBase"))//TODO: Nombre BDD
            {
                ChangeDbName("SistemaBase");//TODO: Nombre BDD

                for (int i = 1; i < querys.Length; i++)
                {
                    if (!querys[i].Equals(String.Empty))
                        if (!Execute(querys[i]))
                        {
                            return false;
                        }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|

        private void InitSqlCon()
        {
            String sqlConnectionUrl = "Server=" + System.Environment.MachineName + "\\" + DB_INSTANCE + ";Database=" + dbName + ";Trusted_Connection=true;";
            sqlConnection = new SqlConnection(sqlConnectionUrl);
        }

        private Boolean TryOpenConnection()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch (Exception e)
            {
                ManagerExceptions.Instance.CatchException(e, "Error al generar la conexión con la base de datos.");
                return false;
            }
        }

        private void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception)
            {
            }
        }

        private void ChangeDbName(String dbName)
        {
            this.dbName = dbName;
            InitSqlCon();
        }

        private Boolean DropDB()
        {
            ChangeDbName("master");
            if (System.IO.File.Exists(createDBScriptFilePath + @"\" + createDBScriptFileName))
            {
                //Borra la BDD
                String query = "ALTER DATABASE [SistemaBase] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE SistemaBase;";//TODO: Nombre BDD 2 

                if (Execute(query))
                    return true;

                else
                {
                    return false;
                }
            }

            else
            {
                return false;
            }
        }
    }
}