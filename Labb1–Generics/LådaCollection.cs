using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    public class LådaCollection : ICollection<Låda>
    {


        
        public IEnumerator<Låda> GetEnumerator()
        {
            return new LådaEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LådaEnumerator(this);
        }


        
        private List<Låda> innerCol;
        public LådaCollection()
        {
            innerCol = new List<Låda>();
        }


      
        public Låda this[int index]
        {
            get { return (Låda)innerCol[index]; }
            set { innerCol[index] = value; }
        }


        
        public bool Contains(Låda låda)
        {
            bool found = false;

            foreach (Låda L in innerCol)
            {

                if (L.Equals(låda))
                {
                    found = true;
                }
            }
            return found;
        }

        
        public bool Contains(Låda låda, EqualityComparer<Låda> comp)
        {
            bool found = false;

            foreach (Låda L in innerCol)
            {
                if (comp.Equals(L, låda))
                {
                    found = true;
                }
            }

            return found;
        }


        
        public void Add(Låda låda)
        {
            if (!Contains(låda))
            {
                innerCol.Add(låda);
                Console.WriteLine("Box added to list");
            }
            else
            {
                Console.WriteLine($"A box with the dimensions height:{låda.höjd} length:{låda.längd} width:{låda.bredd} Allready exsits in the list");
            }

        }

        
        public void Clear()
        {
            innerCol.Clear();
        }
        public int Count
        {
            get
            {
                return innerCol.Count;
            }
        }

        
        public void CopyTo(Låda[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentException("The array cannot be null.");

            }
            if (arrayIndex < 0)
            {
                throw new ArgumentException("The starting array index cannot be negative.");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                throw new ArgumentException("The destination array has fewer elements than the collection.");
            }

            for (int i = 0; i < innerCol.Count; i++)
            {
                array[i + arrayIndex] = innerCol[i];
            }
        }



        
        public bool Remove(Låda item)
        {
            bool result = false;

            for (int i = 0; i < innerCol.Count; i++)
            {

                Låda curLåda = (Låda)innerCol[i];

                if (new LådaSameDimensions().Equals(curLåda, item))
                {
                    innerCol.RemoveAt(i);

                    Console.WriteLine($"object with the dimensions height:{item.höjd}  length:{item.längd}  width:{item.bredd} {item.GetHashCode()} was removed!");
                    result = true;
                    break;
                }
            }
            return result;
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
    }
}
