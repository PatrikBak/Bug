using Ninject;

namespace RandomProjectWithoutProgram
{
    public static class KernelExtensions
    {
        public static IKernel ExtensionMethod(this IKernel kernel)
        {
            return kernel;
        }
    }
}
