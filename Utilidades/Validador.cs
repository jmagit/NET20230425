namespace Demos {
    namespace Utilidades {
        public enum Color {
            Blanco, Negro
        }
        public static class Validador {
            public static bool MaxLenght(this string cad, int len) {
                return (cad??"").Length <= len;
            }
            public static bool Posive(this int valor) {
                return valor > 0;
            }
        }
    }
}