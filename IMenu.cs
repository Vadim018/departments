using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C2
{
    interface IMenu
    {
        bool Flag { get; set; }
        void Init();
        void Idle();
        void CleanUp();
    }
}