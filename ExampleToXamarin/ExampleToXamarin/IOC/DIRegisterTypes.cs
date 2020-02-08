using System;
using System.Collections.Generic;
using System.Text;

using Unity;
using ExampleToXamarin.Infrastructure.Implementation;
using ExampleToXamarin.Infrastructure.Interface;

namespace ExampleToXamarin.IOC
{
    public class DIRegisterTypes
    {
        public UnityContainer unity;
        public DIRegisterTypes()
        {
            unity = new UnityContainer();

            unity.RegisterType<IRandomAddresses, RandomAddresses>();          
        }
    }
}
