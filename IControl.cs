using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOMachines
{
    interface IControl
    {
        void Encendido();
        void Reinicio();
        void Apagado();
        void CheckMemory();
        void ResetMemory();
    }
}
