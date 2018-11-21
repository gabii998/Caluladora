using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operacion
    {
        public static double obtenerResultado(double primero, double segundo, string signo) {
            double resultado = 0;
            switch (signo) {
                case "+":
                   resultado= Operacion.sumar(primero, segundo);
                    break;
                case "-":
                    resultado = Operacion.restar(primero, segundo);
                    break;
                case "/":
                    resultado = Operacion.dividir(primero, segundo);
                    break;
                case "*":
                    resultado = Operacion.multiplicar(primero, segundo);
                    break;
            }
            return resultado;
        }
        public static double sumar(double primero,double segundo) {
            return primero + segundo;
        }
        public static double restar(double primero, double segundo)
        {
            return primero - segundo;
        }
        public static double multiplicar(double primero, double segundo)
        {
            return primero * segundo;
        }
        public static double dividir(double primero, double segundo)
        {
            return primero / segundo;
        }
    }
}
