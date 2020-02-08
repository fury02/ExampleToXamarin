using System;
using System.Collections.Generic;
using System.Text;

using ExampleToXamarin.Infrastructure.Implementation;

namespace ExampleToXamarin.IOC
{
    class DIContainer
    {
        public static DIRegisterTypes container;

        public static void Init()
        {
            container = new DIRegisterTypes();
        }
    }
}
