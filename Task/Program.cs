using System;
using Figures;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleGUI gui = new ConsoleGUI();
            gui.Input();
            gui.Output();
            gui.Area_Compare();
        }
    }
}
