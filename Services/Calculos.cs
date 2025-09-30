using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using quadratic_solver.Utils;

namespace quadratic_solver.Services
{
    internal class Calculos
    {
        public static void CalcularRaices(TextBox txtA, TextBox txtB, TextBox txtC, Label lblx1, Label lblx2, Label lblResultado, Label funcion)
        {
            if (string.IsNullOrEmpty(txtA.Text)) txtA.Text = "0";
            if (string.IsNullOrEmpty(txtB.Text)) txtB.Text = "0";
            if (string.IsNullOrEmpty(txtC.Text)) txtC.Text = "0";
            try
            {
                Validaciones.ValidarFormatoTextbox(txtA, txtB, txtC);
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);

                Validaciones.MostrarFuncion(a, b, c, funcion);
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
                    lblResultado.Text = " Función con raices diferentes";
                }
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error de validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
