using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.Utilidades {
    public interface IGrafico {
        void Pintate(string algo);
        string Dispositivo { get; set; }
    }
}
