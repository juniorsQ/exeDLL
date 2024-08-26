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
            txt_texto1.Text = "TEXTO 1 TEXTO 1";
            txt_texto2.Text = "TEXTO 2 TEXTO 2";
            txt_texto3.Text = "TEXTO 3 TEXTO 3";
            txt_texto4.Text = "TEXTO 4 TEXTO 4";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Define los parámetros de C#
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
                    this.textBox_result.Text = "Impresión Exitosa! " + result;
                    //LimpiarCampos();
                }
                else if (result == "-2")
                {
                    this.textBox_result.Text = "Tarjeta invalida " + result;
                    LimpiarCampos();

                }
                else if (result == "-4")
                {
                    this.textBox_result.Text = "No se consiguió la impresora " + result;
                    LimpiarCampos();
                }
                else
                {
                    this.textBox_result.Text = "Error contacte al departamento de sistemas " + result;
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                // Aquí manejas la excepción y muestras una ventana de error
                MessageBox.Show("Se ha producido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LimpiarCampos()
        {
            txt_pan.Text = string.Empty;
            //txt_texto1.Text = string.Empty;
            //txt_texto2.Text = string.Empty;
            //txt_texto3.Text = string.Empty;
            //txt_texto4.Text = string.Empty;


        }

        private void btn_statusprinter_Click(object sender, EventArgs e)
        {
            String result = "";
            result = inter_printer_dll_v2.getStatusPrint();
            this.textBox_result.Text = "Estatus impresora: " + result;


        }

        private void btn_eject_Click(object sender, EventArgs e)
        {
            String result = inter_printer_dll_v2.getEjectCard();
            this.textBox_result.Text = result;
        }

        private void btn_getPan_Click(object sender, EventArgs e)
        {
            String result = inter_printer_dll_v2.getPan();
            this.textBox_result.Text = result;

        }

        private void btn_limpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
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

