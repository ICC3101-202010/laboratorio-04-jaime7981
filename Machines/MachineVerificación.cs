using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POOMachines
{
    class MachineVerificación : MainPC, IControl
    {
        private string name;
        int count;

        private List<int> Memory;

        public MachineVerificación()
        {
            this.name = "Verificación";
            this.Memory = new List<int> { };
        }

        public void Encendido()
        {
            Console.WriteLine(name + ": " + "Máquina encendida \n");
        }

        public void Reinicio()
        {
            Console.WriteLine(name + ": " + "Machine malfunction");
            Console.WriteLine(name + ": " + "Reset \n");
            ResetMemory();
        }

        public void Apagado()
        {
            Console.WriteLine(name + ": " + "Shutdown \n");
        }

        public void AddToMemory(int value1, int value2, int value3, int value4)
        {
            if (value3 < 19 && Memory.Count < 200)
            {
                Memory.Add(value1);
                Memory.Add(value4);
            }
            if (value2 > 3 && Memory.Count < 200)
            {
                Memory.Add(value3);
                Memory.Add(value1);
            }
        }

        public void CheckMemory()
        {
            count = Memory.Count;

            if (count >= 200)
            {
                Console.WriteLine(name + ": " + "Memory full");
                Thread.Sleep(1000);
                ResetMemory();
                Console.WriteLine(name + ": " + "Memory clear \n");
            }
        }

        public void ResetMemory()
        {
            Memory.Clear();
        }
    }
}
