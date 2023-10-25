using System.Runtime.InteropServices;


namespace inteliMatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox_compare.Text = "6036440000011113333";
            textBox_line2.Text = "018";
            textBox_line2.ReadOnly = true;
       

        }
        private const string dllPath = @"C:\Users\Juniors\Desktop\DataCardS-Dev\Release\DataCardS.dll";

        [DllImport(dllPath)]
        public static extern int nativeMakeCard(string compare, string line1, string line2, string line3, string line4, string line1FontName, string line2FontName, string line3FontName, string line4FontName, int line1FontSize, int line1X, int line1Y, int line2FontSize, int line2X, int line2Y, int line3FontSize, int line3X, int line3Y, int line4FontSize, int line4X, int line4Y);

        private void button1_Click(object sender, EventArgs e)
        {

            // Define los parámetros de C#
            //string compare = "6036440000011113333";
            //string line1 = "Line 1";
            //string line2 = "075";
            //string line3 = "line3";
            //string line4 = "JUNIORS JOSE QUINTANA C";

            string compare = textBox_compare.Text;
            string line1 = "";
            string line2 = textBox_line2.Text;
            string line3 = "";
            string line4 = textBox_line4.Text;

            string line1FontName = "Arial";
            string line2FontName = "Arial";
            string line3FontName = "Arial";
            string line4FontName = "Arial";
            int line1FontSize = 12;
            int line1X = 10;
            int line1Y = 10;
            int line2FontSize = 12;
            int line2X = 10;
            int line2Y = 30;
            int line3FontSize = 12;
            int line3X = 10;
            int line3Y = 50;
            int line4FontSize = 12;
            int line4X = 10;
            int line4Y = 70;

            if (CamposNoVacios())
            {

                try
                {
                    // Llama al método de la DLL
                    int result = nativeMakeCard(compare, line1, line2, line3, line4, line1FontName, line2FontName, line3FontName, line4FontName, line1FontSize, line1X, line1Y, line2FontSize, line2X, line2Y, line3FontSize, line3X, line3Y, line4FontSize, line4X, line4Y);

                        if (result == 0)
                        {
                            // Agrega un retraso de 3 segundos (3000 milisegundos)
                            this.textBox_result.Text = "Imprimiendo tarjeta... Por favor Espere!";

                            Thread.Sleep(5000);
                            this.textBox_result.Text = "Impresión Exitosa!";
                            LimpiarCampos();
                        }
                        else if (result == -2)
                        {
                            this.textBox_result.Text = "Tarjeta invalida";
                            LimpiarCampos();

                        }
                        else if (result == -4)
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

            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LimpiarCampos()
        {
            // Establece los valores de los TextBox en cadenas vacías
            textBox_line4.Text = "";
        }

        private bool CamposNoVacios()
        {
            // Verifica si los campos TextBox están vacíos
            if (string.IsNullOrWhiteSpace(textBox_compare.Text) ||
                string.IsNullOrWhiteSpace(textBox_line2.Text) ||
                string.IsNullOrWhiteSpace(textBox_line4.Text))
            {
                // Al menos uno de los campos está vacío
                return false;
            }

            // Todos los campos contienen datos
            return true;
        }

    }
}