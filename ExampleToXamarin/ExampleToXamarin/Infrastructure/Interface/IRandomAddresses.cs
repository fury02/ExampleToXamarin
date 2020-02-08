using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleToXamarin.Infrastructure.Interface
{
    interface IRandomAddresses
    {
        void NewRandom(Action<string> action);
    }
}
