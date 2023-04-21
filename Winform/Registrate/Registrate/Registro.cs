using Biblioteca;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Registrate
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }


        private void Registro_Load(object sender, EventArgs e)
        {
            lst_pais.Items.Add("Argentina");
            lst_pais.Items.Add("Chile");
            lst_pais.Items.Add("Uruguay");
        }



        //aplicarlo  con el nombre RecorrerChecBox
        public string RecorrerCheckBox(string[] elementos)
        {
            string[] cursos = elementos;

            foreach (Control item in grp_cursos.Controls)
            {
                if(item is CheckBox && ((CheckBox)item).CheckState == CheckState.Checked)
                {
                    Array.Resize<string>(ref elementos, elementos.Length + 1);
                    elementos[elementos.Length - 1] = ((CheckBox)item).Text; 
                }
            }

            return elementos[elementos.Length-1];
        }
        

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
                //string[] elementosCheckBox = new string[0];

                string name = txt_nombre.Text; 
                string address = txt_address.Text;
                int age = (int)nud_edad.Value;
                string? gender = grp_genero.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text;
                string country = lst_pais.Text;
                string[] courses = grp_cursos.Controls.OfType<CheckBox>().Where(cb => cb.Checked).Select(cb => cb.Text).ToArray();
                                


                if (Validacion.ValidarCarga(name, address, gender, country, courses, age))
                {
                
                   MessageBox.Show("Faltan completar datos. Relleno todos!");                                   
            
                }


         

                else
                {
                   Ingresante Ingresante1 = new Ingresante(name, address, age, gender, country, courses);
                   MessageBox.Show(Ingresante1.MostrarDatos());
                }
                

            
        }
               
    }
}

        
    