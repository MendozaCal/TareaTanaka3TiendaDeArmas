﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaDeArmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller Controller = new Controller();
            Controller.Execute();
            Console.ReadLine();
        }
    }
}
