using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ActividadesUT2_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int Sumar(int n1, int n2)
        {
            int res = n1 + n2;
            return res;
        }

        public int Restar(int n1, int n2)
        {
            int res = n1 - n2;
            return res;
        }

        public int Multiplicar(int n1, int n2)
        {
            int res = n1 * n2;
            return res;
        }

        public int Dividir(int n1, int n2)
        {
            int res = n1 / n2;
            return res;
        }

        private void Calcular_Click(object sender, RoutedEventArgs e)
        {

            int num;
            if (!int.TryParse(txtbOperando1.Text, out _) || !int.TryParse(txtbOperando2.Text, out _))
            {
                MessageBox.Show("Ha ocurrido un error, revise los operando");
            }
            else
            {
                int num1 = int.Parse(txtbOperando1.Text);
                int num2 = int.Parse(txtbOperando2.Text);
                string operador = txtbOperador.Text;

                if (operador == "+")
                {
                    txtbResultado.Text = Sumar(num1, num2).ToString();
                }
                else if (operador == "-")
                {
                    txtbResultado.Text = Restar(num1, num2).ToString();
                }
                else if (operador == "*")
                {
                    txtbResultado.Text = Multiplicar(num1, num2).ToString();
                }
                else if (operador == "/")
                {
                    txtbResultado.Text = Dividir(num1, num2).ToString();
                }

            }

           
        }

        private void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            txtbOperando1.Clear();
            txtbOperando2.Clear();
            txtbOperador.Clear();
            txtbResultado.Clear();
        }

        private void Comprobar_TextChanged(object sender, TextChangedEventArgs e)
        {
            string operador = txtbOperador.Text;

            if (operador == "+" || operador == "-" || operador == "*")
            {
                btnCalcular.IsEnabled = true;
            }
            else
            {
                btnCalcular.IsEnabled = false;
            }
        }


    }
}
