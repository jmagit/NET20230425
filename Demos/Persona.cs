using Demos.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public abstract class Persona : IGrafico {
        private int id;
        private string name;
        private int age;
        private string desc;

        public void Pintate(string algo = "") {
            if(algo == null) throw new InvalidDataException("Algo es obligatorio");
            Console.WriteLine($"{algo.ToUpper()} Soy una persona {DameNombre()}");
        }
        public virtual string? DameNombre() {
            return this.name;
        }
        public abstract string dameEdad();

        //public void Pintate() {
        //    Pintate("");
        //}
    }

    public class Alumno: Persona {
        public override string dameEdad() {
            throw new NotImplementedException();
        }

        public override string? DameNombre() {
            return base.DameNombre().ToLower();
        }

    }
}
