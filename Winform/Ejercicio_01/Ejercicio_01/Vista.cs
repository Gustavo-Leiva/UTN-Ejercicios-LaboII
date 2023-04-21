using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_01
{
    public partial class frm_Vista : Form
    {
        private string _nombre;
        private string _apellido;
        private string _materia;


        public frm_Vista(string nombre, string apellido, string materia)
        {
            InitializeComponent();
            this._nombre = nombre;
            this._apellido = apellido;
            this._materia = materia;
        }

        private void frm_Vista_Load(object sender, EventArgs e)
        {

            //this.lbl_mensaje.Text = "Soy" + _nombre + " " + _apellido + " " + _materia;
            this.lbl_mensaje.Text = $"Soy {_nombre} {_apellido} y mi materia favorita es {_materia}.";
          

        }




    }
}
