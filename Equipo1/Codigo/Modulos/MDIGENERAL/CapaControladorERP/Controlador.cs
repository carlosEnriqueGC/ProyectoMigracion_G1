using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloERP;

public class Controlador
{
    Sentencias sn = new Sentencias();

    public DataTable llenarTablas(String tabla)
    {
        OdbcDataAdapter dt = sn.CargarDatosProv(tabla);
        DataTable table = new DataTable();
        dt.Fill(table);
        return table;
    }
}
