using RandomProjectWithoutProgram;
using Ninject;
using System;
using System.Globalization;

namespace RandomProjectWithProgram
{
    internal class Program
    {
        private static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            var kernel = new StandardKernel().ExtensionMethod();

            Environment.Exit(0);
        }
    }
}