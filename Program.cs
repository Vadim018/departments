/*
|--------------------------------------------------------------------------------|
| Завдання С2                                                                    |
|--------------------------------------------------------------------------------|
| Створити трирівневу інформаційну систему з підтримки діяльності відділу кадрів |
| Є перелік посад підприємства. Кожна посада має оклад.                          |
| Наприклад:                                                                     |
| 1 посада1 10000                                                                |
| 2 посада2 15000                                                                |
| ...                                                                            |
| 5 посада5 5000                                                                 |
| Інформаційна система повинна:                                                  |
| знайти посаду з максимальним окладом.                                          |
|--------------------------------------------------------------------------------|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDBItemDAL<Position> dbPosition = new DBItemDAL<Position>();

            Position position1 = new Position("MANAGER", 1500);
            dbPosition.Add(position1);

            Position position2 = new Position("CEO", 15000);
            dbPosition.Add(position2);

            Position position3 = new Position("COOKER", 10000);
            dbPosition.Add(position3);

            Position position4 = new Position("DEVELOPER", 50000);
            dbPosition.Add(position4);

            Position position5 = new Position("DOCTOR", 25000);
            dbPosition.Add(position5);

            IPositionServiceBLL positionServiceBLL = new PositionServiceBLL(dbPosition);

            IPositionServicePL positionServicePL = new PositionServicePL(positionServiceBLL);

            IMenu departmentMenu = new DepartmentMenu(positionServicePL);

            StrategyMenu departmentStrategy = new StrategyMenu(departmentMenu);

            IMenu mainMenu = new MainMenu(departmentStrategy);

            StrategyMenu mainMenuStrategy = new StrategyMenu(mainMenu);

            mainMenuStrategy.Run();

            Console.ReadKey();
        }
    }
}