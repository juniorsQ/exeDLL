using Microsoft.VisualBasic;
using nm_inter_printer_dll_v2;
using System.Reflection;
using System.Runtime.InteropServices;

using static nm_inter_printer_dll_v2.inter_printer_dll_v2;

namespace inteliMatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_pan.Text = "PAN";
            txt_pan.ReadOnly = true;
            txt_texto1.Text = "LIAM J QUINTANA ZAMBRANO";
            txt_texto2.Text = "LIAM J QUINTANA ZAMBRANO";
            txt_texto3.Text = "LIAM J QUINTANA ZAMBRANO";
            txt_texto4.Text = "LIAM J QUINTANA ZAMBRANO";


        }
        //   private const string dllPath = "C:\\Users\\Juniors\\Desktop\\POINTMAN - 100x100\\inter_printer_dll_v2\\bin\\Debug\\inter_printer_dll_v2.dll";


        //public static extern string Imprimir(
        //    string compare,
        //    string line1,
        //    string line2,
        //    string line3,
        //    string line4,
        //    string line1FontName,
        //    string line2FontName,
        //    string line3FontName,
        //    string line4FontName,
        //    string line1FontSize,
        //    string line1X,
        //    string line1Y,
        //    string line2FontSize,
        //    string line2X,
        //    string line2Y,
        //    string line3FontSize,
        //    string line3X,
        //    string line3Y,
        //    string line4FontSize,
        //    string line4X,
        //    string line4Y,
        //    string P21,
        //    string P22);

        private void button1_Click(object sender, EventArgs e)
        {

            // Define los parámetros de C#
            //string compare = "6036440000011113333";
            string TextoObj = "";
            string TextoPan = "";

            string line1 = txt_texto1.Text;
            string line1FontName = "Arial";
            string line1FontSize = "8";
            string line1X = "120";
            string line1Y = "130";

            string line2 = txt_texto2.Text;
            string line2FontName = "Consolas";
            string line2FontSize = "8";
            string line2X = "120";
            string line2Y = "170";

            string line3 = txt_texto3.Text;
            string line3FontName = "Times New Roman";
            string line3FontSize = "8";
            string line3X = "120";
            string line3Y = "480";

            string line4 = txt_texto4.Text;
            string line4FontName = "Tahoma";
            string line4FontSize = "8";
            string line4X = "120";
            string line4Y = "550";


            //if (CamposNoVacios())
            //{

            try
            {
                // Llama al método de la DLL

                string result = inter_printer_dll_v2.Imprimir(
                    TextoObj,
                    TextoPan,

                    line1,
                    line1FontName,
                    line1FontSize,
                    line1X,
                    line1Y,

                    line2,
                    line2FontName,
                    line2FontSize,
                    line2X,
                    line2Y,

                    line3,
                    line3FontName,
                    line3FontSize,
                    line3X,
                    line3Y,

                    line4,
                    line4FontName,
                    line4FontSize,
                    line4X,
                    line4Y);

                // int result = 0;
                if (result.Length == 16 || result.Length == 19)
                {
                    // Agrega un retraso de 3 segundos (3000 milisegundos)
                    this.textBox_result.Text = "Imprimiendo tarjeta... Por favor Espere!";
                    txt_pan.Text = result;
                    Thread.Sleep(2000);
                    this.textBox_result.Text = "Impresión Exitosa!";
                    //LimpiarCampos();
                }
                else if (result == "-2")
                {
                    this.textBox_result.Text = "Tarjeta invalida";
                    LimpiarCampos();

                }
                else if (result == "-4")
                {
                    this.textBox_result.Text = "No se consiguió la impresora";
                    LimpiarCampos();
                }
                else
                {
                    this.textBox_result.Text = "Error contacte al departamento de sistemas";
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                // Aquí manejas la excepción y muestras una ventana de error
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //}
            //else
            //{
            //    MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

        }

        private void LimpiarCampos()
        {
            // Establece los valores de los TextBox en cadenas vacías
            txt_texto1.Text = "";
        }

        //private bool CamposNoVacios()
        //{
        //    // Verifica si los campos TextBox están vacíos
        //    if (string.IsNullOrWhiteSpace(textBox_compare.Text) ||
        //        string.IsNullOrWhiteSpace(textBox_line2.Text) ||
        //        string.IsNullOrWhiteSpace(textBox_line4.Text))
        //    {
        //        // Al menos uno de los campos está vacío
        //        return false;
        //    }

        //    // Todos los campos contienen datos
        //    return true;
        //}


    }
}

