﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace CapaModeloERP
{
    public class Sentencias
    {
        Conexion con = new Conexion();
       
        public OdbcDataAdapter CargarDatosProv(string tabla)
        {
            string query = "SELECT * FROM " + tabla + ";";
            OdbcDataAdapter data = new OdbcDataAdapter(query, con.conexion());
            return data;
        }




    }




}
