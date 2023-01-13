using System.Runtime.InteropServices;

namespace Akatsuki.PP;

[Serializable]
[StructLayout(LayoutKind.Sequential)]
public struct CalculateResult
{
    public double PP;
    public double Stars;
}