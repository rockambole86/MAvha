using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MAvha.DAL
{
    public class DB
    {
        #region Variables

        private static readonly DB            _intance = null;
        private                 SqlConnection _connection;
        private readonly        string        _connString;
        private                 SqlCommand    _command;
        private                 string        _paramPrefix = "@";

        #endregion

        #region Properties

        public int ScopeIdentity { get; set; }

        #endregion

        #region Constructor

        protected DB()
        {
            _connString = ConfigurationManager.ConnectionStrings["MAvha"].ConnectionString;
        }

        #endregion

        #region Singleton

        public static DB Instance()
        {
            return _intance ?? new DB();
        }

        #endregion

        #region Methods

        public void Connect()
        {
            try
            {
                if (_connection == null)
                    _connection = new SqlConnection(_connString);

                if (_connection.State != ConnectionState.Open)
                    _connection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (_connection != null)
                {
                    if (_connection.State != ConnectionState.Closed)
                        _connection.Close();

                    _connection.Dispose();
                }

                _connection = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public void ExecuteNonQuery(string nombreStoredProcedure, Hashtable parameters)
        {
            try
            {
                _command = new SqlCommand(nombreStoredProcedure, _connection)
                {
                    CommandText = nombreStoredProcedure,
                    CommandTimeout = 0,
                    CommandType = CommandType.StoredProcedure
                };

                AddParameters(parameters);

                _command.ExecuteNonQuery();

                try
                {
                    _command = new SqlCommand("SELECT @@IDENTITY", _connection);

                    ScopeIdentity = Convert.ToInt32(_command.ExecuteScalar());
                }
                catch
                {
                    ScopeIdentity = -1;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                _command = null;
            }
        }

        public DataTable ExecuteDataTable(string nombreStoredProcedure, Hashtable parameters)
        {
            try
            {
                _command = new SqlCommand(nombreStoredProcedure, _connection)
                {
                    CommandText = nombreStoredProcedure,
                    CommandTimeout = 0,
                    CommandType = CommandType.StoredProcedure
                };

                AddParameters(parameters);

                var adapter = new SqlDataAdapter(_command);
                var table   = new DataTable();

                adapter.Fill(table);

                return table;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                _command = null;
            }
        }

        public DataSet ExecuteDataSet(string nombreStoredProcedure, Hashtable parameters)
        {
            try
            {
                _command = new SqlCommand(nombreStoredProcedure, _connection)
                {
                    CommandText = nombreStoredProcedure,
                    CommandTimeout = 0,
                    CommandType = CommandType.StoredProcedure
                };

                AddParameters(parameters);

                var adapter = new SqlDataAdapter(_command);
                var set     = new DataSet();

                adapter.Fill(set);

                return set;
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public object ExecuteScalar(string nombreStoredProcedure, Hashtable parameters)
        {
            try
            {
                _command = new SqlCommand(nombreStoredProcedure, _connection)
                {
                    CommandText = nombreStoredProcedure,
                    CommandTimeout = 0,
                    CommandType = CommandType.StoredProcedure
                };

                AddParameters(parameters);

                return _command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                _command = null;
            }
        }

        private void AddParameters(Hashtable parameters)
        {
            if (parameters == null || parameters.Count <= 0)
                return;

            _command.Parameters.Clear();

            foreach (DictionaryEntry param in parameters)
            {
                _command.Parameters.AddWithValue($"{_paramPrefix}{param.Key}", param.Value ?? DBNull.Value);
            }
        }

        #endregion
    }
}