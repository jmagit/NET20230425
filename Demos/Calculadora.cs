using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    /// <summary>
    /// Demo de la documentación
    /// </summary>
#if DEBUG
    public class Calculadora {
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
        #endregion
        #endregion
    }
}
