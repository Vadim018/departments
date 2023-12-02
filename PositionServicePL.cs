using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C2
{
    internal class PositionServicePL : IPositionServicePL
    {
        IPositionServiceBLL positionServiceBLL;
        public PositionServicePL(IPositionServiceBLL positionServiceBLL)
        {
            this.positionServiceBLL = positionServiceBLL;
        }
        public void FindByMaxSalaryPosition()
        {
            Position position = positionServiceBLL.FindByMaxSalaryPosition();

            if(position != default(Position)) 
            {
                Console.WriteLine(position);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}