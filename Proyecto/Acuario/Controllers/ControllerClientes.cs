using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Acuario.Controllers;
using Acuario.Entities;
using Acuario.Managers;

namespace Acuario.Controllers
{
    public class ControllerClientes
    {
        // |==============================ATRIBUTOS==============================|

        private static ControllerClientes instance;
        public static ControllerClientes Instance
        {
            get
            {
                if (instance == null)
                    instance = new ControllerClientes();

                return instance;
            }
        }

        // |==============================CONSTRUCTORES==============================|

        private ControllerClientes()
        {

        }

        // |==============================METODOS Y FUNCIONES==============================|

        public List<EntitieCliente> GetClientes()
        {
            List<EntitieCliente> clientes = new List<EntitieCliente>();

            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM Clientes");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieCliente cliente = new EntitieCliente(
                    Convert.ToInt32(dt.Rows[i][0]),
                    dt.Rows[i][1].ToString(),
                    dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(),
                    dt.Rows[i][4].ToString(),
                    dt.Rows[i][5].ToString(),
                    dt.Rows[i][6].ToString());

                clientes.Add(cliente);
            }

            return clientes;
        }

        public List<EntitieCliente> GetClientes(String nombre)
        {
            List<EntitieCliente> clientes = new List<EntitieCliente>();

            String query = "SELECT * FROM Clientes ";

            if (!nombre.Equals(String.Empty))
                query += "WHERE Nombre LIKE '%" + nombre + "%' ";

            DataTable dt = ManagerDB.Instance.ExecuteQuery(query);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                EntitieCliente cliente = new EntitieCliente(
                    Convert.ToInt32(dt.Rows[i][0]),
                    dt.Rows[i][1].ToString(),
                    dt.Rows[i][2].ToString(),
                    dt.Rows[i][3].ToString(),
                    dt.Rows[i][4].ToString(),
                    dt.Rows[i][5].ToString(),
                    dt.Rows[i][6].ToString());

                clientes.Add(cliente);
            }

            return clientes;
        }

        public EntitieCliente GetClienteById(int idCliente)
        {
            EntitieCliente cliente = null;

            DataTable dt = ManagerDB.Instance.ExecuteQuery("SELECT * FROM Clientes WHERE ID_Cliente = " + idCliente);

            if (dt.Rows.Count > 0)
                cliente = new EntitieCliente(
                     Convert.ToInt32(dt.Rows[0][0]),
                    dt.Rows[0][1].ToString(),
                    dt.Rows[0][2].ToString(),
                    dt.Rows[0][3].ToString(),
                    dt.Rows[0][4].ToString(),
                    dt.Rows[0][5].ToString(),
                    dt.Rows[0][6].ToString());

            return cliente;
        }

        public void CrearCliente(EntitieCliente cliente)
        {
            ManagerDB.Instance.Execute("INSERT INTO Clientes(Nombre, Cuit, Mail, Telefono_1, Telefono_2, Telefono_3) " +
                "VALUES('" + cliente.GetNombre() + "', '" + cliente.GetCuit() + "', '" + cliente.GetMail() + "', " +
                "'" + cliente.GetTelefono1() + "', '" + cliente.GetTelefono2() + "', '" + cliente.GetTelefono3() + "')");
        }

        public void ModificarCliente(int idClienteAModificar, EntitieCliente nuevoCliente)
        {
            ManagerDB.Instance.Execute("UPDATE Clientes SET Nombre = '" + nuevoCliente.GetNombre() + "', " +
               "Cuit = '" + nuevoCliente.GetCuit() + "',  Mail = '" + nuevoCliente.GetMail() + "', " +
               "Telefono_1 = '" + nuevoCliente.GetTelefono1() + "', Telefono_2 = '" + nuevoCliente.GetTelefono2() + "', " +
               "Telefono_3 = '" + nuevoCliente.GetTelefono3() + "' " + 
               "WHERE ID_Cliente = " + idClienteAModificar);
        }

        public void EliminarCliente(int idCliente)
        {
            ManagerDB.Instance.Execute("DELETE FROM Clientes WHERE ID_Cliente = " + idCliente);
        }

        // |==============================METODOS Y FUNCIONES PRIVADOS==============================|
    }
}
