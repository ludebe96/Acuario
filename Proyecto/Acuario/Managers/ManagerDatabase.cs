using System;

using System.Data;
using System.Data.SqlClient;

namespace Acuario.Managers
{
    public class ManagerDatabase
    {
        // |==============================ATRIBUTOS==============================|

        private String PC_NAME = System.Environment.MachineName;
        private String dbName = "Acuario";
        private static String DB_INSTANCE = "SQLEXPRESS";
        private static ManagerDatabase instance;
        public static ManagerDatabase Instance
        {
            get
            {
                if (instance == null)
                    instance = new ManagerDatabase();

                return instance;
            }
        }
        private SqlConnection sqlConnection;
        //FileName del script de creación de bdd
        private String createDBScriptFileName;
        //Path del script de creación de bdd
        private String createDBScriptFilePath;

        // |==============================CONSTRUCTORES==============================|

        private ManagerDatabase()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        /* Requerido
         * */
        public Boolean Init()
        {
            InitSQLCon();
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
                    String query = "BACKUP DATABASE Acuario "
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

            ChangeDBName("master");
            try
            {
                DataTable dt = ExecuteQuery("IF (EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE ('[' + name + ']' = 'Acuario' OR "
                + "name = 'Acuario'))) SELECT 1 ELSE SELECT 0");

                if (dt.Rows[0][0].ToString().Equals("1"))
                    exists = true;
            }

            catch (Exception)
            {
            }

            finally
            {
                ChangeDBName("Acuario");
            }

            return exists;
        }

        public Boolean CreateDB()
        {
            ChangeDBName("master");

            //Crea la BDD
            String query = ManagerFiles.Instance.LeerArchivo(createDBScriptFilePath + @"\" + createDBScriptFileName).Replace("�", "ñ");

            String[] querys = query.Split(new string[] { "GO" }, StringSplitOptions.None);

            if (Execute("CREATE DATABASE Acuario"))
            {
                ChangeDBName("Acuario");

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

        private void InitSQLCon()
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
                ManagerExceptions.Instance.CatchException(e, "Error al generar la conexión con la base de datos");
                return false;
            }
        }

        private void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                ManagerExceptions.Instance.CatchException(e, "Falló al cerrar la conexión de la Base de Datos");
            }
        }

        private void ChangeDBName(String dbName)
        {
            this.dbName = dbName;
            InitSQLCon();
        }

        /* Deshabilitado por seguridad
         * 
         * Preservar por código
         * 
         * 
         * private Boolean DropDB()
        {
            ChangeDBName("master");
            if (ManagerFiles.Instance.ArchivoExistente(createDBScriptFilePath + @"\" + createDBScriptFileName))
            {
                String query = "ALTER DATABASE [Acuario] SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE Acuario;";

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
        }*/
    }
}