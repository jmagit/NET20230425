using Demos.Utilidades;
using corto = System.Drawing;

namespace Demos {
    public enum Dias {
        LUNES = 1, MARTES = 11, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO
    }
    public enum DiasLaborables {
        LUNES, MARTES, MIERCOLES, JUEVES, VIERNES
    }
    internal class Program {
        static void Main(string[] args) {
            corto.Color color;
            Dias dia = Dias.LUNES;
            int? xx = 0;
            var c = new Calculadora();
            IGrafico p = c;
            p.Pintate("Interfaz");
            var persona = new Alumno();
            p = persona;
            //if(persona.)
            p.Pintate(null);

            if(p is Calculadora calcula) {
                calcula.Avg(1, 2);
                calcula.Pintate();
            }
            return;
            c.Avg(1, 2, 3, 4, 5);
            c.Power(2);
            c.Power(2, 2);
            c.Power(2, factor: 2);
            if(dia == Dias.LUNES) return;
            var i = c.Suma((decimal)0.1, (decimal)0.2);
            var k = c.Suma(0.1M, 0.2m);
            var j = c.Suma(1, 3, 3);
            char letra = '0';
            Object o = i; // new Decimal(i)
            //o = c;
            if(o is Calculadora calc) {
                // var calc = o as Calculadora;
                calc.Suma(1, 2, 3);
                (o as Calculadora).Suma(1, 2, 3);
                ((Calculadora)o).Suma(1, 2, 3);
            }
            if(c != null && c.Suma(2m, 2m) > 3) {

            }
            int? edad = null;
            Nullable<int> n = null;
            edad = 5;
            int años = (int)i;
            if(edad.HasValue) {
                años = años + edad.Value;
            }
            i = (Decimal)o + 1; // o.value
            letra++;
            j = letra;
            años = 2;
            int div = años = 2;
            double o1, o2;
            if((o1 = c.Suma(1, 2, 3)) > 2 & (o2 = c.Suma(1, 2, 3)) < 2) { }
            Console.WriteLine($"Divide: {(decimal)div / años}\n");
            Console.WriteLine($"char: {letra} {j} {'A' + 1}\n");
            Console.WriteLine($"Tiene {años} {años switch { 0 => "ninguno", 1 => "año", _ => "años" }}\n");

            var nombre = "mundo";
            Console.WriteLine("Adios \"" + nombre + "\"\n");
            Console.WriteLine($"Adios {nombre}\n");
            Console.WriteLine(@"c:\demo\curso\nada");
            if((años += 2) == 2) { }
            bool b = false;
            if(!b) { }
            //o.p.m();
            //if(o != null && o.p != null && o.p.m() > 0) { }
            //if(o?.p?.m() > 0) { }
            //var rslt = c?.Suma(1, 2, 3) ?? 0; //o?.p?.m();
            //string cad;
            //cad = (cad??"").ToLower();
            switch(años) {
                case 0 or 1:
                    Console.WriteLine("Pocos");
                    break;
                case 2 or 3:
                    Console.WriteLine("Varios");
                    break;
                default:
                    Console.WriteLine("Muchos");
                    break;
            }
            Validador v;

        }
    }
}