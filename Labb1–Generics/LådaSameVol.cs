using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    public class LådaSameVol : EqualityComparer<Låda>
    {
        
        public override bool Equals([AllowNull] Låda lådaX, [AllowNull] Låda lådaY)
        {
            if ((lådaX.höjd * lådaX.bredd * lådaX.längd) == (lådaY.höjd * lådaY.bredd * lådaY.längd))
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
            int hCode = låda.höjd ^ låda.längd ^ låda.bredd;
            return hCode.GetHashCode();
        }


    }
}
