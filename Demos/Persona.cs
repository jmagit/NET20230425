using Demos.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos {
    public abstract class Persona : IGrafico, IDisposable {
        public const int EDAD_MINIMA = 16;
        public readonly int EDAD_JUBILACION;
        [Required]
        private int id = 0;
        private string name;
        [Range(EDAD_MINIMA, 67)]
        private int edad;
        private string desc;

        public int Edad {
            get { return edad; }
            protected set {
                if(value == edad) return;
                if(value < EDAD_MINIMA || value > EDAD_JUBILACION)
                    throw new Exception("Edad fuera de rango");
                //var x = OnPropertyChange(nameof(Edad));
                //if(x is PropertyChangeEventArgs ev && ev.Cancel) return;
                edad = value;
            }
        }
        public bool MayorDeEdad { get => edad >= EDAD_MINIMA; }
        public string Dispositivo { get; set; }
        public int Id { get => id; set => id = value; }
        public string Apellidos { get; set; } = "";

        public Persona(int edadJubilacion = 67) {
            EDAD_JUBILACION = edadJubilacion;
        }
        public Persona(int edad, int edadJubilacion = 67) {
            EDAD_JUBILACION = edadJubilacion;
            this.Edad = edad;
        }
        public Persona(int edad, string name, int edadJubilacion = 67) : this(edad, edadJubilacion) {
            this.name = name;
        }

        public void Pintate(string algo = "") {
            if(algo == null) throw new InvalidDataException("Algo es obligatorio");
            Console.WriteLine($"{algo.ToUpper()} Soy una persona {DameNombre()}");
        }
        public virtual string? DameNombre() => this.name;
        public abstract string dameEdad();

        public virtual void Dispose() {
            // cerrar ...
            Console.WriteLine("Limpio persona");
        }

        //public void Pintate() {
        //    Pintate("");
        //}
        #region Sobrecarga de operadores
        public static bool operator >(Persona p1, Persona p2) {
            return p1.Edad > p2.Edad;
        }
        public static bool operator >(Persona p1, int edad) {
            return p1.Edad < edad;
        }
        public static bool operator >(int edad, Persona p1) {
            return p1.Edad < edad;
        }
        public static bool operator <(Persona p1, Persona p2) {
            return p1.Edad < p2.Edad;
        }
        public static bool operator <(Persona p1, int edad) {
            return p1.Edad > edad;
        }
        public static bool operator <(int edad, Persona p1) {
            return p1.Edad > edad;
        }

        public static implicit operator int(Persona p1) {
            return p1.Edad;
        }

        // override object.Equals
        public override bool Equals(object obj) {
            if(this == obj) return true;
            if(!(obj is Persona)) {
                return false;
            }

            return this.Id == (obj as Persona).Id;
        }

        // override object.GetHashCode
        public override int GetHashCode() {
            return Id.GetHashCode();
        }
        #endregion
        public (int, string) Resumen { get => (id, name); }
    }

    public class Alumno : Persona {
        private List<int> notas = new() {1,2,3,4};
        public Alumno(int edad) : base(edad, 67) {
        }

        public override string dameEdad() {
            throw new NotImplementedException();
        }

        public override string? DameNombre() {
            return base.DameNombre().ToLower();
        }

        public int dameNota(int indice) {
            return notas[indice];
        }
        public void ponNota(int indice, int nota) {
            notas[indice] = nota;
        }
        public int this[int indice] {
            get {
                return notas[indice];
            }
            set {
                notas[indice] = value;
            }
        }

    }
    public class Profesor : Persona {
        public override string dameEdad() {
            throw new NotImplementedException();
        }

        public override string? DameNombre() {
            return base.DameNombre().ToLower();
        }


        public override void Dispose() {
            // cerrar ...
            Console.WriteLine("Limpio persona");
        }
    }
}
