using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic_solver.Utils
{
    internal class Validaciones
    {
        public static void MostrarFuncion(TextBox txtA, TextBox txtB, TextBox txtC, Label lblFuncion)
        {
            if (string.IsNullOrWhiteSpace(txtA.Text) || string.IsNullOrWhiteSpace(txtB.Text) || string.IsNullOrWhiteSpace(txtC.Text))
            {
                MessageBox.Show("Todos los campos de valores deben ser llenados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double a;
            double b;
            double c;

            if(!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("El valor ingresado en A no es valido!", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("El valor ingresado en B no es valido!", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtC.Text, out c))
            {
                MessageBox.Show("El valor ingresado en C no es valido!", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string funcion = "";

            if (a == 0)
            {
                MessageBox.Show("A no puede ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                funcion += "A" + "";
            }

            if(a == -1)
            {
                funcion += "-x²";
            }
            else if(a == 1)
            {
                funcion += "x²";
            }

            if(a !=0 && a!=1 && a!= -1) funcion += a + "x²";
             //B
             if (b == 0)
            {
                funcion += "";
            }
            else if(b == 1)
            {
                funcion += "+ " + "x";
            }

            else if (b == -1)
            {
                funcion += "-x";
            }

            if (b > 0 && b != 1)
            {
                funcion += "+" + b + "x";
            }
            if (b < 0 && b != -1)
            {
                funcion += b + "x";
            }

            if (c == 0)
            {
                funcion += "";
            }
            else if (c < 0)
            {
                funcion += c;
            }
            else
            {
                funcion += "+" + c;
            }
            lblFuncion.Text = funcion;
        }

        public static void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            if ((e.KeyChar) == 45)
            {
                e.Handled = false;
            }
        }

        public static void Borrar (Label lblx1, Label lblx2, Label lblResultado,Label lblFuncion, params TextBox[] textBoxes)
        {
            foreach(var textbox in textBoxes)
            {
                textbox.Clear();
            }
            lblx1.Text = "   ";
            lblx2.Text = "   ";
            lblResultado.Text = "";
            lblFuncion.Text = "Ax²+Bx+ C ";
        }
    }
    }