using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        int operaciones = 0;
        string ultimoSigno = "";
        public Form1()
        {
            InitializeComponent();
            binding();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(teclas);

        }

        private void teclas(object sender, KeyEventArgs e)
        {
            string tecla = "";


            switch (e.KeyCode) {
                case Keys.Back:
                    eliminarUltimo();
                    break;
                case Keys.Multiply:
                    tecla = "*";
                    break;
                case Keys.Subtract:
                    tecla = "-";
                    break;
                case Keys.Add:
                    tecla = "+";
                    break;
                case Keys.Divide:
                    tecla = "/";
                    break;
                case Keys.D0:
                    tecla = "0";
                    break;
                case Keys.D1:
                    tecla = "1";
                    break;
                case Keys.D2:
                    tecla = "2";
                    break;
                case Keys.D3:
                    tecla = "3";
                    break;
                case Keys.D4:
                    tecla = "4";
                    break;
                case Keys.D5:
                    tecla = "5";
                    break;
                case Keys.D6:
                    tecla = "6";
                    break;
                case Keys.D7:
                    tecla = "7";
                    break;
                case Keys.D8:
                    tecla = "8";
                    break;
                case Keys.D9:
                    tecla = "9";
                    break;
                
            }
            //Esto es para evitar signos repetidos
            if(tecla != ultimoSigno)
            {
                mostrar.AppendText(tecla);
            }
            if (tecla.Equals("+") || tecla.Equals("-") || tecla.Equals("/") || tecla.Equals("*"))
            {
                ultimoSigno = tecla;
            }
            else {
                ultimoSigno = "";
            }
                
            
            
        }
        

            
        


        public void binding() {
            foreach(var boton in this.Controls.OfType<Button>())
            {
                if(boton != borrar && boton != limpiar && boton!=igual)
                {
                    boton.Click += botonPresionado;
                }
                if (boton == sumar) {
                    operaciones++;
                }
                
            }
        }
        
        public void botonPresionado(object sender, EventArgs e) {
            mostrar.AppendText((sender as Button).Text);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       



        private void limpiar_Click(object sender, EventArgs e)
        {
            mostrar.ResetText();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            eliminarUltimo();
        }
        public void eliminarUltimo() {
            if(mostrar.Text.Length >= 1)
            {
                mostrar.Text = mostrar.Text.Substring(0, mostrar.Text.Length - 1);
            }
            
        }

        private void igual_Click(object sender, EventArgs e)
        {//Hay que basarse en que la cantidad de 
            //elementos es 1+ a la cantidad de operadores
            string entrada = mostrar.Text;
            double suma = 0;
            List<Double> numeros = new List<Double>();
            
             for (int i = 0; i < entrada.Length; i++) {
                if (entrada[i].Equals('+')) {
                    int size = entrada.Length-(i+1);
                    numeros.Add(Double.Parse(entrada.Substring(0, i)));
                    entrada = entrada.Substring(i + 1, size);
                    i = 0;
                }
                
             }
            for (int i = 0; i < numeros.Count; i++) {
                if (i != 0) {
                    suma += numeros[i];
                }
            }
            mostrar.Text = suma.ToString();
            
        }

        private void mostrar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
