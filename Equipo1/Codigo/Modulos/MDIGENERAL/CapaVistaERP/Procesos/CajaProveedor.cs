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
    public partial class CajaProveedor : Form
    {
        private MovimientoProveedores MovimientoProveedorescaja;

        public CajaProveedor(MovimientoProveedores movimientoProveedores )
        {
            InitializeComponent();
            MovimientoProveedorescaja = movimientoProveedores;
        }

        private void CajaProveedor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
