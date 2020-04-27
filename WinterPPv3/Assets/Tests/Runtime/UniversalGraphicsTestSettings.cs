using UnityEngine.TestTools.Graphics;

public class UniversalGraphicsTestSettings : GraphicsTestSettings
{
    public int WaitFrames = 0;

    public UniversalGraphicsTestSettings()
    {
        ImageComparisonSettings.TargetWidth = 1334;
        ImageComparisonSettings.TargetHeight = 750;
        ImageComparisonSettings.AverageCorrectnessThreshold = 0.0005f;
        ImageComparisonSettings.PerPixelCorrectnessThreshold = 0.00001f;
    }
}
