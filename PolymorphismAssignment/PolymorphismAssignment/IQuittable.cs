using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Per naming convention, "IQuittable" begins with "I" for easy interface type recognition for future developers.  This passes a method on to any classes that inherit this interface
    interface IQuittable
    {
        void Quit();
    }
}
