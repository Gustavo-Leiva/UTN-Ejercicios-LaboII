using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Drawing2D;

namespace Hola_Windows_Forms
{
    public partial class Principal : Form
    {
        private string _nombre;
        private string _apellido;
        private string _materia;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            _nombre= this.txt_nombre.Text;
            _apellido = this.txt_apellido.Text;
            _materia = this.cbo_materia.Text;

            if (_nombre != "" && _apellido != "" && _materia != "")
            {
                //instancio el formulario
                Vista mensaje = new Vista(_nombre, _apellido);

                //muestro el formulario
                

            }
            else
            {
                MessageBox.Show("faltan completar datos");
            }

        }
    }
}