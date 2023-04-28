using Demos.Utilidades;
using corto = System.Drawing;
using System.Linq;

namespace Demos {
    public enum Dias {
        LUNES = 1, MARTES = 11, MIERCOLES, JUEVES, VIERNES, SABADO, DOMINGO
    }
    public enum DiasLaborables {
        LUNES, MARTES, MIERCOLES, JUEVES, VIERNES
    }
    delegate decimal OperacionesDecimales(decimal op1, decimal op2);

    internal class Program {
        static void Main(string[] args) {
            List<Persona> lista = new List<Persona>();
            var query = lista.Where(ele => ele is Alumno && ele.Apellidos != null)
                .Select(ele => ele as Alumno)
                .Where(ele => ele.Edad > 33);
                //.Select(ele => ele.Edad)
                //.Average();
           if(true) {
                query = query.Skip(1 * 20)
                .Take(20);

            }
            var result = query.ToList();

            Elemento<int, string> item = new(28, "Madrid");
            item = new(8, "Barcelona");
            Elemento<int, string> item2 = new(28, "Madrid");
            Elemento<char, string> item3 = new((char)28, "Madrid");
            int id = item.conv<int>(1);
            String nombre = "Pepito";

            if(Validador.MaxLenght(nombre, 10)) { }
            if(nombre.MaxLenght(10)) { }
            corto.Color color;
            Dias dia = Dias.LUNES;
            int? xx = 0;
            var c = new Calculadora();
            c.Calculado += (o, arg) => Console.WriteLine($"Se ha calculado {arg.Resultado}");
            c.Calculado += (o, arg) => Console.WriteLine($"Segundo se ha calculado {arg.Resultado}");
            c.Suma(1d, 2d);
            c.Multiplica(2d, 2d);

            OperacionesDecimales opera = c.Suma;
            Func<decimal, decimal, decimal> gen = c.Suma;
           // ...
            opera = delegate(decimal a, decimal b) { return a * b; };
            opera = (a, b) => a * b;
            Func<int, bool> func = item => item > 0;

            // ...
            Console.WriteLine(opera(3m, 2m));
            IGrafico p = c;
            p.Pintate("Interfaz");
            var persona = new Alumno(44);
            var tupla = persona.Resumen;
            (id, nombre) = tupla;
            (_, nombre) = tupla;
            String? nom = null;

            persona.Pintate(nom!);
            Console.WriteLine(tupla.Item1);
            p = persona;
            //if(persona.)
            //p.Pintate(null);

            if(p is Calculadora calcula) {
                using(Persona persona1 = new Profesor()) {
                    calcula.Avg(1, 2);
                    calcula.Pintate();
                }
            }
            
            int? edad = null;
            Alumno a1 = new Alumno(55), a2 = new Alumno(55) { Apellidos ="Anonimo"};
            if(a1 == a2 || a1.Equals(a2)) { }
            if(a1.GetHashCode() == a2.GetHashCode()) { }
            //a1.edad = -1;
            if(a2.Edad == -1) { }
            Console.WriteLine(a1 > a2 ? "a1" : "a2");
            Console.WriteLine(a1 > 44 ? "a1" : "44");
            edad = a1;
            Console.WriteLine(edad);
            Profesor profesor = new Profesor() { Id = 1, Apellidos = "Grillo" };
            profesor.Apellidos = "";
            int nota = a1.dameNota(1);
            nota = a1[1];
            a1[0] = 0;
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

            //var nombre = "mundo";
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

        }

        private static void C_Calculado(object? sender, CalculadoEventAgs e) {
            throw new NotImplementedException();
        }
    }
}