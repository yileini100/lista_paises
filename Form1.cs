using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_País
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbo_lista_países_SelectedIndexChanged(object sender, EventArgs e)
        {

            string pais = cbo_lista_países.SelectedItem.ToString();

            // Mostrar la información del país en los TextBox
            switch (pais)
            {
                case "Estados Unidos":
                    txt_capital.Text = "Washington D.C.";
                    txt_población.Text = "331,002,651";
                    txt_idioma.Text = "Inglés";
                    txt_religión.Text = "Cristianismo";
                    break;
                case "China":
                    txt_capital.Text = "Pekín";
                    txt_población.Text = "1,439,323,776";
                    txt_idioma.Text = "Chino Mandarín";
                    txt_religión.Text = "Ateísmo ";
                    break;
                case "República Dominicana":
                    txt_capital.Text = "Santo Domingo";
                    txt_población.Text = "10.9 millones de habitantes";
                    txt_idioma.Text = "Español";
                    txt_religión.Text = "Cristianismo";
                    break;
                case "Haití":
                    txt_capital.Text = "Pueto Príncipe";
                    txt_población.Text = "11 millones de habitantes";
                    txt_idioma.Text = "Francés";
                    txt_religión.Text = "Cristianismo";
                    break;
                case "España":
                    txt_capital.Text = "Madrid";
                    txt_población.Text = " 46.9 millones de habitantes";
                    txt_idioma.Text = " Español";
                    txt_religión.Text = "El catolicismo";
                    break;
                case "Corea del Sur":
                    txt_capital.Text = "Seúl.";
                    txt_población.Text = "51 millones de habitantes.";
                    txt_idioma.Text = " Es el coreano";
                    txt_religión.Text = "Budismo y el cristianismo";
                    break;
                case "Corea del Norte":
                    txt_capital.Text = "Pyongyang. ";
                    txt_población.Text = "25 millones de habitantes.";
                    txt_idioma.Text = "El idioma oficial es el coreano";
                    txt_religión.Text = "Ateísmo de estado.";
                    break;
                case "Venezuela":
                    txt_capital.Text = "Caracas";
                    txt_población.Text = "28,5 millones de habitantes.5";
                    txt_idioma.Text = "Hindi, Inglés";
                    txt_religión.Text = "Español.";
                    break;
                case "México":
                    txt_capital.Text = "Ciudad de México";
                    txt_población.Text = "1,380,004,385";
                    txt_idioma.Text = "Español";
                    txt_religión.Text = "Catolicismo romano";
                    break;
                case "Canadá":
                    txt_capital.Text = "Ottawa";
                    txt_población.Text = "38 millones de habitantes";
                    txt_idioma.Text = " Inglés y el francés";
                    txt_religión.Text = "Cristianismo, el islam, el judaísmo, el hinduismo y el sijismo";
                    break;
                
              
                default:
                    MessageBox.Show("Seleccione un país válido.");
                    break;

            }

       
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_capital.Clear();
            txt_población.Clear();
            txt_idioma.Clear();
            txt_religión.Clear();
            cbo_lista_países.Items.Clear();
        }

      
    }
}