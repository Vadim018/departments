using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C2
{
    internal class DepartmentMenu : IMenu
    {
        public bool Flag { get; set; }
        IPositionServicePL positionServicePL;
        ConsoleColor defaultColor;
        public DepartmentMenu(IPositionServicePL positionServicePL)
        {
            this.positionServicePL = positionServicePL;
        }
        public void Init()
        {
            Flag = true;
            defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("INIT");
        }
        public void Idle()
        {
            Console.WriteLine("1 - FIND");
            Console.WriteLine("2 - EXIT");

            int menuChoose = int.Parse(Console.ReadLine());

            switch (menuChoose)
            {
                case 1:
                    positionServicePL.FindByMaxSalaryPosition();
                    break;
                case 2:
                    Flag = false;
                    break;
                default:
                    Console.WriteLine("ERROR! PLEASE, TRY AGAIN...");
                    break;
            }
        }
        public void CleanUp()
        {
            Console.ForegroundColor = defaultColor;
            Console.WriteLine("CLEANUP");
        }
    }
}