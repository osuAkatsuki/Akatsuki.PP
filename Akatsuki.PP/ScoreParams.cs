namespace Akatsuki.PP;

public class ScoreParams
{
    public uint Mode { get; set; }
    public uint Mods { get; set; }
    public uint MaxCombo { get; set; }
    public double Accuracy { get; set; }
    public uint MissCount { get; set; }
    public uint? PassedObjects { get; set; }
}