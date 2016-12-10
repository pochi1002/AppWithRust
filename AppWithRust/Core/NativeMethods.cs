using System;
using System.Runtime.InteropServices;

namespace AppWithRust
{
    public static class NativeMethods
    {
        [DllImport("rustlib", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int rust_sum(int x, int y);

    }
}
