using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ImportarRecetas
{
    public class Datos : Conexion
    {
        public int InsertarLinea(string perfil, string aleacion, string p205, string p200, string p117, string p109,
            string p100, string p118, string p119, string p120, string p116, string p208, string p121, string p123)
        {
            SqlCommand command = new SqlCommand
            {
                Connection = this.Connection,
                CommandText = "dbo.CargarRecetas",
                CommandType = CommandType.StoredProcedure
            };
            //command.Parameters.Add(new SqlParameter("@perfil", SqlDbType.Int));
            command.Parameters.AddWithValue("@perfil", perfil);
            command.Parameters.AddWithValue("@aleacion", aleacion);
            command.Parameters.AddWithValue("@p205", p205);
            command.Parameters.AddWithValue("@p200", p200);
            command.Parameters.AddWithValue("@p117", p117);
            command.Parameters.AddWithValue("@p109", p109);
            command.Parameters.AddWithValue("@p100", p100);
            command.Parameters.AddWithValue("@p118", p118);
            command.Parameters.AddWithValue("@p119", p119);
            command.Parameters.AddWithValue("@p120", p120);
            command.Parameters.AddWithValue("@p116", p116);
            command.Parameters.AddWithValue("@p208", p208);
            command.Parameters.AddWithValue("@p121", p121);
            command.Parameters.AddWithValue("@p123", p123);

            return EjecutarComandoNonQuery(command);
        }

        private int EjecutarComandoNonQuery(SqlCommand command)
        {
            ConnectionState previousConnectionState = command.Connection.State;
            if (((command.Connection.State & ConnectionState.Open) != ConnectionState.Open))
            {
                command.Connection.Open();
            }
            int returnValue;
            try
            {
                returnValue = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if ((previousConnectionState == ConnectionState.Closed))
                {
                    command.Connection.Close();
                }
            }
            return returnValue;
        }
    }

    public class Conexion
    {
        #region Campos

        private SqlConnection _connection;

        #endregion

        #region Propiedades

        protected internal SqlConnection Connection
        {
            get
            {
                if (this._connection == null)
                {
                    this._connection = new SqlConnection
                    {
                        ConnectionString = @"Data Source=iru00-ms002sq\sql2016;Initial Catalog=Productividad;Persist Security Info=True;Integrated Security=true;Connect Timeout=60"
                    };
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
            }
        }

        #endregion
    }

}
