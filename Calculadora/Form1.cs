using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string auxiliar;//Va a tener los numeros que se ingresan
        double primero;
        double segundo;
        string signo = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            mostrar.Text = "";
            auxiliar = "";
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            mostrar.Text = mostrar.Text.Substring(0, mostrar.Text.Length - 1);
        }
        public void eliminarUltimo() {
            
            
        }
        private void igual_Click(object sender, EventArgs e)
        {
            segundo = Double.Parse(auxiliar);
            mostrar.Text=Operacion.obtenerResultado(primero, segundo, signo).ToString();
            auxiliar= Operacion.obtenerResultado(primero, segundo, signo).ToString();
            signo = "";
        }

        private void mostrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void uno_Click(object sender, EventArgs e)
        {
            mostrar.Text += "1";
            auxiliar += "1";
        }

        private void dos_Click(object sender, EventArgs e)
        {
            mostrar.Text += "2";
            auxiliar += "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            mostrar.Text += "3";
            auxiliar += "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            mostrar.Text += "4";
            auxiliar += "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            mostrar.Text += "5";
            auxiliar += "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            mostrar.Text += "6";
            auxiliar += "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            mostrar.Text += "7";
            auxiliar += "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            mostrar.Text += "8";
            auxiliar += "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            mostrar.Text += "9";
            auxiliar += "9";
        }

        private void cero_Click(object sender, EventArgs e)
        {
            mostrar.Text += "0";
            auxiliar += "0";
        }

        private void coma_Click(object sender, EventArgs e)
        {
            mostrar.Text += ",";
            auxiliar += ",";
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            agregarOperador("+");
        }

        private void restar_Click(object sender, EventArgs e)
        {
            agregarOperador("-");
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            agregarOperador("*");
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            agregarOperador("/");
        }
        public void agregarOperador(string operador) {

            
            if (!signo.Equals(""))
            {
                segundo = Double.Parse(auxiliar);
                primero = Operacion.obtenerResultado(primero, segundo, signo);
                
            }
            else {
                primero = Double.Parse(auxiliar);
            }
            auxiliar = "";
            signo = operador;
            mostrar.Text += operador;
        }
    }
}
