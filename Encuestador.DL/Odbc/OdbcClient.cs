using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace Encuestador.DL
{
    public static class OdbcClient
    {
        private static string strConexion = ConfigurationManager.ConnectionStrings["encuestadorADO"].ToString();

        public static OleDbConnection Conectar()
        {
            OleDbConnection con = new OleDbConnection(strConexion);
            con.Open();
            return con;
        }

        public static OleDbCommand ArmaCommand(string strSQL, OleDbConnection con)
        {
            var com = new OleDbCommand(strSQL, con);
            com.CommandType = CommandType.Text;

            return com;
        }

        public static OleDbCommand ArmaCommand(string strSQL, List<OleDbParameter> param, OleDbConnection con)
        {
            var com = new OleDbCommand(strSQL, con);
            com.CommandType = CommandType.Text;

            foreach (var sp in param)
            {
                com.Parameters.Add(sp);
            }
            return com;
        }
        public static OleDbDataReader GenerarReader(string strSQL, List<OleDbParameter> param, OleDbConnection con)
        {
            var com = ArmaCommand(strSQL, param, con);
            return com.ExecuteReader();
        }
        public static OleDbDataReader GenerarReader(string strSQL, OleDbConnection con)
        {
            var com = ArmaCommand(strSQL, con);
            return com.ExecuteReader();
        }

        public static DataTable GenerarTable(String strSQL, List<OleDbParameter> lista, OleDbConnection con)
        {
            var dt = new DataTable();
            dt.Load(GenerarReader(strSQL, lista, con));
            return dt;
        }

        public static int EjecutarCommand(String strSQL, List<OleDbParameter> lista,
            OleDbConnection con)
        {
            var com = ArmaCommand(strSQL, lista, con);
            return com.ExecuteNonQuery();
        }
        public static int EjecutarCommand(String strSQL, List<OleDbParameter> lista,
            OleDbConnection con, OleDbTransaction tran)
        {
            var com = ArmaCommand(strSQL, lista, con);
            com.Transaction = tran;
            return com.ExecuteNonQuery();
        }

        public static string EjecutarScalar(String strSQL, List<OleDbParameter> lista, OleDbConnection con, OleDbTransaction tran)
        {
            var cmd = ArmaCommand(strSQL, lista, con);
            cmd.Transaction = tran;
            return cmd.ExecuteScalar().ToString();
        }

        public static OleDbDataReader GenerarReader(string comando, List<OleDbParameter> listp, OleDbConnection con, OleDbTransaction tran)
        {
            var com = ArmaCommand(comando, listp, con);
            com.Transaction = tran;
            return com.ExecuteReader();
        }
    }
}
