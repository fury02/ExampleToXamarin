using System;
using System.Collections.Generic;
using System.Text;

using ExampleToXamarin.Infrastructure.Interface;

namespace ExampleToXamarin.Infrastructure.Implementation
{
    public class RandomAddresses : IRandomAddresses
    {
        private static int GetRandom() => new Random().Next(0, int.MaxValue);

        public void NewRandom(Action<string> action) => action?.Invoke(GetRandom().ToString());
         
    }
}
