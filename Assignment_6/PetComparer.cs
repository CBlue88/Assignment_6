using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class PetComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            //Can't get this damn thing to work
            return (new CaseInsensitiveComparer()).Compare(((newPet)x).petAge, ((newPet)y).petAge);
        }
    }
}
