using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Screens;

namespace Inflex_OSF.Game.Screens
{
    public class BeatmapSelectionScreen : Screen
    {
        public BeatmapSelectionScreen() =>
            this.InternalChildren = new Drawable[]
            {
                new SpriteText
                {
                    Y = 20,
                    Text = "Beatmap Selection",
                    Anchor = Anchor.TopCentre,
                    Origin = Anchor.TopCentre,
                    Font = FontUsage.Default.With(size: 40),
                },
            };
    }
}