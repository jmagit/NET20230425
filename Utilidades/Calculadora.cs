using Demos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Demos {
    /// <summary>
    /// Demo de la documentación
    /// </summary>
#if DEBUG
    public class Calculadora: IGrafico {
#else
    internal class Calculadora {
#endif
        #region Atributos
        #endregion
        #region Propiedades
        #endregion
        #region Métodos
        #region Inicializacion
        #endregion
        #region Métodos de calculo

        /// <summary>
        /// Suma dos valores
        /// <code>
        ///  c = suma(2, 3)
        /// </code>
        /// </summary>
        /// <param name="a">Primer operando</param>
        /// <param name="b">Segundo operando</param>
        /// <returns>Suma de los dos operandos</returns>
        public double Suma(double a, double b) {
#if DEBUG
            Console.WriteLine(a + b);
#endif
            return a + b;
        }
        public double Suma(int a, int b, int c) {
#if DEBUG
            Console.WriteLine($"int: {a + b}");
#endif
            return a + b;
        }
        public decimal Suma(decimal a, decimal b) {
#if DEBUG
            Console.WriteLine(a + b);
#endif
            return a + b;
        }
        public decimal Resta(decimal a, decimal b) {
            var result = a - b;
#if DEBUG
            Console.WriteLine(result);
#endif
            return result;
        }

        public decimal Delta(decimal a, decimal b) {
            var result = Abs(Resta(a, b));
#if DEBUG
            Console.WriteLine(result);
#endif
            return result;
        }


        public decimal Avg(decimal a, decimal b, params decimal[] resto) {
            var result = a + b;
            foreach(var val in resto)
                result += val;
            result /= resto.Length + 2;
#if DEBUG
            Console.WriteLine(result);
#endif
            return result;
        }

        public double Power(double a, double exponente = 2, double factor = 1) {
            var result = Math.Pow(a, exponente) * factor;
            if(result < 0) return 0;
#if DEBUG
            Console.WriteLine(result);
#endif
            return result;
        }

        public void Pintate(string algo) {
            Console.WriteLine($"{algo}: Soy una calculadora");
        }

        public void Pintate() {
            Console.WriteLine($"Soy una calculadora");
        }

        #endregion
        #endregion
    }
}
