using System;
using System.Collections.Generic;
using System.Text;

namespace LV_6
{
    interface IAbstractCollection
    {
        IAbstractCollection GetIterator();
    }
}
