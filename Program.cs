using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POOMachines
{
    class Program
    {
        static void Main(string[] args)
        {

            MainPC mastercontrol = new MainPC();
            MachineRecepción recepcion = new MachineRecepción();
            MachineAlmacenamiento almacenamiento = new MachineAlmacenamiento();
            MachineEnsamblaje ensamblaje = new MachineEnsamblaje();
            MachineVerificación verificacion = new MachineVerificación();
            MachineEmpaque empaque = new MachineEmpaque();

            bool on_off = false; 

            while (true)
            {
                DateTime now = DateTime.Now;
                int h = now.Hour;

                if (on_off == true)
                {
                    Random rnd = new Random();
                    int rand1 = rnd.Next(1, 10);
                    int rand2 = rnd.Next(1, 20);
                    int rand3 = rnd.Next(1, 20);
                    int rand4 = rnd.Next(1, 20);
                    int rand5 = rnd.Next(1, 20);
                    int rand6 = rnd.Next(1, 20);

                    recepcion.AddToMemory(rand1, rand2, rand3, rand4);
                    almacenamiento.AddToMemory(rand1, rand2, rand3, rand4);
                    ensamblaje.AddToMemory(rand1, rand2, rand3, rand4);
                    verificacion.AddToMemory(rand1, rand2, rand3, rand4);
                    empaque.AddToMemory(rand1, rand2, rand3, rand4);

                    recepcion.CheckMemory();
                    almacenamiento.CheckMemory();
                    ensamblaje.CheckMemory();
                    verificacion.CheckMemory();
                    empaque.CheckMemory();

                    if (rand1 == 1) // 1 va a hacer que la máquina tenga algun error
                    {
                        if (rand2 == 1)
                        {
                            recepcion.Reinicio();
                        }
                        if (rand3 == 1)
                        {
                            almacenamiento.Reinicio();
                        }
                        if (rand4 == 1)
                        {
                            ensamblaje.Reinicio();
                        }
                        if (rand5 == 1)
                        {
                            verificacion.Reinicio();
                        }
                        if (rand6 == 1)
                        {
                            empaque.Reinicio();
                        }
                    }
                }

                if (h > 9 && h < 20 && on_off == false)
                {
                    recepcion.Encendido();
                    almacenamiento.Encendido();
                    ensamblaje.Encendido();
                    verificacion.Encendido();
                    empaque.Encendido();
                    on_off = true;
                }

                if (h < 9 && h > 20 && on_off == true)
                {
                    recepcion.Apagado();
                    almacenamiento.Apagado();
                    ensamblaje.Apagado();
                    verificacion.Apagado();
                    empaque.Apagado();
                    on_off = false;
                }

                Thread.Sleep(800);
            }
        }
    }
}
