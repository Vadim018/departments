using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C2
{
    internal class PositionServiceBLL : IPositionServiceBLL
    {
        IDBItemDAL<Position> dbPosition;
        public PositionServiceBLL(IDBItemDAL<Position> dbPosition)
        {
            this.dbPosition = dbPosition;
        }
        public Position FindByMaxSalaryPosition()
        {
            Position result = default(Position);

            int maxSalary = int.MinValue;

            foreach(Position p in dbPosition.Items)
            {
                if(p.Salary > maxSalary)
                {
                    maxSalary = p.Salary;
                    result = p;
                }
            }
            return result;
        }
    }
}