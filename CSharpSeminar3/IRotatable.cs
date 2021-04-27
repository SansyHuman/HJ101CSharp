using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSeminar3
{
    public interface IRotatable
    {
        float Angle { get; }
        void Rotate(float dtheta);
    }
}
