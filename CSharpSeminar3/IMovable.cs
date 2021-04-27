using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar3
{
    public interface IMovable
    {
        int X { get; }
        int Y { get; }
        void Move(int dx, int dy);
    }
}
