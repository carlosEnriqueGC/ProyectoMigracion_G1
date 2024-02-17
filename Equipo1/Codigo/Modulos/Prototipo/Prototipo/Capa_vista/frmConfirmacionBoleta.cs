﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;


namespace Vista_PrototipoMenu
{
    public partial class frmConfirmacionBoleta : Form
    {
        Controlador cn = new Controlador();
        public frmConfirmacionBoleta()
        {
            InitializeComponent();
        }

        public void GuardarDatos()
        {
            string tabla = "tbl_boletaBanco";
            Dictionary<string, object> valores = new Dictionary<string, object>();

            // valores.Add("Detalle_valor", int.Parse(txt_conceptoValor.Text));
            valores.Add("boleta_concepto", txt_conceptoBoleta.Text);
            valores.Add("boleta_tipoPago", txt_tipoBoleta.Text);
            valores.Add("id_tipopasaporte", int.Parse(txt_IDPasaporte.Text));
            valores.Add("boleta_añosDuracion", int.Parse(txt_pagoAños.Text));
            valores.Add("id_persona", int.Parse(txt_IDPersona.Text));
            valores.Add("boleta_numeroDoc", int.Parse(txt_NoBoletaSelet.Text));
            valores.Add("boleta_numeroCGC", int.Parse(txt_NoCGCSelect.Text));

            cn.GuardarDatos(tabla, valores);

            MessageBox.Show("Datos guardados");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
    }
}