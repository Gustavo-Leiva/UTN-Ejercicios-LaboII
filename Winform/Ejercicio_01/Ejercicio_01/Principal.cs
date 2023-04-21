using System.Text;

namespace Ejercicio_01
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_saludo_Click(object sender, EventArgs e)
        {
            string nombre= this.txt_nombre.Text;
            string apellido = this.txt_apellido.Text;
            string materia = this.cbo_materia.Text;


            if(validarCarga())
            {
                frm_Vista saludo = new frm_Vista(nombre, apellido, materia);
                saludo.ShowDialog();
            }

           
        }

        private void Saludar_Load(object sender, EventArgs e)
        {
            cbo_materia.Items.Add("Programacion I");
            cbo_materia.Items.Add("Laboratorio de Computacion I");
            cbo_materia.Items.Add("Ingles I");
            cbo_materia.Items.Add("Matematica ");
            cbo_materia.Items.Add("Sistema de Procesamientos de Datos");
            cbo_materia.Items.Add("Arquitectura y Sistemas Operativos");
            cbo_materia.Items.Add("Estadisticas");
            cbo_materia.Items.Add("Ingles II ");
            cbo_materia.Items.Add("Programacion II");
            cbo_materia.Items.Add("Laboratorio de Computacion II");
            cbo_materia.Items.Add("Metodologia de la Investigacion");
            cbo_materia.SelectedIndex = 0;//esto es para que muestre por defecto una opcion visible

        }



        private bool validarCarga()
        {
            bool valido = true;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes campos");

            if (string.IsNullOrEmpty(txt_nombre.Text))
            {
                valido = false;
                sb.AppendLine("nombre:");
            }

            if (string.IsNullOrEmpty(txt_apellido.Text))
            {
                valido = false;
                sb.AppendLine("apellido");
            }


            if (!valido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return valido;
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 97 || e.KeyChar > 122) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}