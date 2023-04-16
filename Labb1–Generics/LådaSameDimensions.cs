using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    public class LådaSameDimensions : EqualityComparer<Låda>
    {
        public override bool Equals(Låda lådaX, Låda lådaY)
        {
            if (lådaX.höjd == lådaY.höjd && lådaX.längd == lådaY.längd && lådaX.bredd == lådaY.bredd)
            {
                
                return true;
            }

            else
            {
                return false;
            }

        }

        public override int GetHashCode([DisallowNull] Låda låda)
        {
            var hCode = låda.höjd ^ låda.längd ^ låda.bredd;
            Console.WriteLine($"Hashcode: {hCode.GetHashCode()}");
            return hCode.GetHashCode();

        }
    }
}
