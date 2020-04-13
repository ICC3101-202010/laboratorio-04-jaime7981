using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POOMachines
{
    class MachineEnsamblaje : MainPC, IControl
    {
        private string name;
        int count;

        private List<int> Memory;


        public MachineEnsamblaje()
        {
            this.name = "Ensablaje";
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
            if (value3 < 12 && Memory.Count < 100)
            {
                Memory.Add(value1);
                Memory.Add(value2);
            }
            if (value2 > 2 && Memory.Count < 100)
            {
                Memory.Add(value3);
                Memory.Add(value4);
            }
        }
        public void CheckMemory()
        {
            count = Memory.Count;

            if (count >= 100)
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
