﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_SisB;
using System.Data;
namespace CapaControlador_SisB
{
    public class Controlador
    {
        private Sentencias sentencias;

        public void InsertarMovimiento(string valorMovimiento, string descripcionMovimiento, string numCuentaDeb, string numCuentaCred, string tipoTransaccion, string estado, string valorTrans, string estadoConciliacion)
        {
            sentencias.InsertarMovimiento(valorMovimiento, descripcionMovimiento, numCuentaDeb, numCuentaCred, tipoTransaccion, estado, valorTrans, estadoConciliacion);
        }
        public DataTable llenarTbl(string tabla)
        {
            return sentencias.llenarTblMov(tabla);
        }
        public Controlador()
        {
            sentencias = new Sentencias();

        }

        public DataTable ObtenerTipoDeTransacciones()
        {
            return sentencias.TipoTransaccionBancaria();

        }

        public DataTable valorTrans()
        {
            return sentencias.valorTransaccion();

        }

        public int ObtenerValorTransaccion(string tipoTransaccion)
        {
            return sentencias.ObtenerValorTransaccion(tipoTransaccion);
        }


    }
}
