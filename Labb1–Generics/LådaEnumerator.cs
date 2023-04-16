using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    public class LådaEnumerator : IEnumerator<Låda>
    {
        private LådaCollection _låda;
        private int currentIndex;
        private Låda currentLåda;


        public LådaEnumerator(LådaCollection låda)
        {
            this._låda = låda;
            this.currentIndex = -1;
            this.currentLåda = default(Låda);
        }

        public Låda Current
        {

            get { return currentLåda; } 
        }

        object IEnumerator.Current 

        { get { return Current; } 
        
        }

        public int Count { get { return _låda.Count; } }


        public bool MoveNext()
        {

            
            if (++currentIndex >= _låda.Count)
            {
                return false;
            }
            else
            {

               
                currentLåda = _låda[currentIndex];
            }
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }
        public void Dispose()
        {

        }
    }
}


