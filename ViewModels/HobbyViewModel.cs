using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HobbyTracker.ViewModels;

public class HobbyViewModel
{
    public string Name { get; set; }
    public string ColorHex { get; set; }
    public string PracticeInfo { get; set; }

    public Color BgColor => Color.FromArgb($"#{ColorHex}");
    public Color TextColor => CalculateTextColor();

    private Color CalculateTextColor()
    {
        const float midColor = 115f;
        const float midDiff = 13f;

        Color blackLowContrast = Color.FromRgba(0, 0, 0, .87f);
        Color blackHighContrast = Color.FromRgb(0, 0, 0);
        Color whiteLowContrast = Color.FromRgba(1f, 1f, 1f, .87f);
        Color whiteHighContrast = Color.FromRgb(1f, 1f, 1f);

        float sum = 0;

        for (int i = 0; i <= 4; i += 2)
        {
            sum += Convert.ToInt32($"0x{ColorHex.Substring(i, 2)}", 16);
        }

        float avg = sum / 3f;

        bool isHighContrast = MathF.Abs(avg - midColor) < midDiff;
        bool isLightBg = avg >= midColor;

        if (isHighContrast)
        {
            if (isLightBg)
            {
                return blackHighContrast;
            }
            else
            {
                return whiteHighContrast;
            }
        }
        else
        {
            if (isLightBg)
            {
                return blackLowContrast;
            }
            else
            {
                return whiteLowContrast;
            }
        }
    }
}