using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Windows_Forms
{
    public partial class Vista : Form
    {
        private string _nombre;
        private string _apellido;
        public Vista(string nombre, string apellido)
        {
            InitializeComponent();
            this._nombre= nombre;
            this._apellido= apellido;
        }

        private void Vista_Load(object sender, EventArgs e)
        {

        }
    }
}
