using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace quadratic_solver.Services
{
    internal class Calculos
    {
        public static void CalcularRaices(TextBox txtA, TextBox txtB, TextBox txtC, Label lblx1, Label lblx2, Label lblResultado)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);

                double discriminante = Math.Pow(b, 2) - (4 * a * c);

                if (discriminante < 0)
                {
                    lblResultado.Text = "Función sin resultados reales";
                    lblx1.Text = "   ";
                    lblx2.Text = "   ";
                }
                else if (discriminante == 0)
                {
                    double raizDuplicada = (-b / (2.0 * a));
                    lblx1.Text = raizDuplicada.ToString("0.00");
                    lblx2.Text = raizDuplicada.ToString("0.00");
                    lblResultado.Text = "";
                    lblResultado.Text = " Función con raices duplicadas";
                }
                else
                {
                    lblResultado.Text = "";
                    double raizPositiva = (-b + Math.Sqrt(discriminante)) / (2.0 * a);
                    double raizNegativa = (-b - Math.Sqrt(discriminante)) / (2.0 * a);
                    lblx1.Text = raizPositiva.ToString("0.00");
                    lblx2.Text = raizNegativa.ToString("0.00");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores numericos validos.");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("El valor 'A' no puede ser 0");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Valores demaciado Grandes!!");

            }
        }
    }
}
