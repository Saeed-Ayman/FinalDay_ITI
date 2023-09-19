using FontAwesome.Sharp;
using System.Drawing.Drawing2D;

namespace FinalDay_ITI.Views.Components;

public partial class CRoundButton : IconButton
{
    public CRoundButton()
    {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs pe)
    {
        base.OnPaint(pe);

        GraphicsPath p = new();
        p.AddEllipse(4, 4, Width - 10, Height - 10);
        Region = new Region(p);
    }
}
