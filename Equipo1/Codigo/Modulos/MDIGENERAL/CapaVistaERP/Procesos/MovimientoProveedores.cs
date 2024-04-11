using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaERP.Procesos
{
    public partial class MovimientoProveedores : Form
    {
        
        public MovimientoProveedores(string idprov,string nombreprov,string nitprov)
        {
            InitializeComponent();
            txt_Idprov.Text = idprov;
            txt_nombreprov.Text = nombreprov;
            txt_nitprov.Text = nitprov;


        }

        public void tabla()
        {
            //DataTable dt = cn.llenarTablas(tabla1);
            //dgv_proveedores.DataSource = dt;
        }
        private void btn_buscarprov_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_pagoproveedor_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_PagoProv_Click(object sender, EventArgs e)
        {
            CajaProveedor CajaProveedor = new CajaProveedor(this);
            CajaProveedor.Show();
        }
    }
}
