using quadratic_solver.Services;
using quadratic_solver.Utils;
using System.Diagnostics;
namespace quadratic_solver
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validaciones.MostrarFuncion(txtA, txtB, txtC, lblFuncion);
            Calculos.CalcularRaices(txtA, txtB, txtC, lblx1, lblx2, lblResultado, lblFuncion);

        }

        private void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            Validaciones.ValidarSoloNumeros(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Validaciones.Borrar(lblx1, lblx2, lblResultado, lblFuncion, txtA, txtB, txtC);
        }
    }
}
