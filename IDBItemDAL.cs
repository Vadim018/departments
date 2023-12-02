using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C2
{
    interface IDBItemDAL<T> where T : IID
    {
        List<T> Items { get; set; }
        void Add(T item);
    }
}