using System.Runtime.InteropServices;

namespace Akatsuki.PP;

public class Calculator
{
    [DllImport("akatsuki_pp_ffi.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "calculate_score")]
    public static extern CalculateResult calculate_score(string beatmapPath, uint mode, uint mods, uint maxCombo, double accuracy, uint missCount, Optionu32 passedObjects);

    private readonly string _mapPath;
    public Calculator(string mapPath)
    {
        _mapPath = mapPath;
    }

    public CalculateResult Calculate(ScoreParams scoreParams)
    {
        var result = calculate_score(
            _mapPath,
            scoreParams.Mode,
            scoreParams.Mods,
            scoreParams.MaxCombo,
            scoreParams.Accuracy,
            scoreParams.MissCount,
            Optionu32.FromNullable(scoreParams.PassedObjects)
        );

        return result;
    }
}