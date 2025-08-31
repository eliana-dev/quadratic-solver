using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic_solver.Services
{
    internal class Calculos
    {
        public static void CalcularRaices(double a, double b, double c, Label lblx1, Label lblx2, Label lblResultado)
        {
            double discriminante = Math.Pow(b, 2) - (4 * a * c);
            
            if(discriminante < 0)
            {
                lblResultado.Text = "Función sin resultados reales";
            }
            else if(discriminante == 0)
            {
                double raizDuplicada = (-b / (2.0 * a));
                lblx1.Text = raizDuplicada.ToString("0.00");
                lblx2.Text = raizDuplicada.ToString("0.00");
                lblResultado.Text = " Función con raices duplicadas";
            }
            else
            {
                double raizPositiva = ((-b + Math.Sqrt(discriminante)) / (2.0 * a));
                double raizNegativa = ((-b - Math.Sqrt(discriminante)) / (2.0 * a));
                lblx1.Text = raizPositiva.ToString("0.00");
                lblx2.Text = raizNegativa.ToString("0.00");
            }
        }
    }
}
