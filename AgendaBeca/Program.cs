using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuAgenda menu = new MenuAgenda();
            menu.ConsoleConfig();
            menu.MenuPrincipal();
            Console.Read();
        }
    }
}
