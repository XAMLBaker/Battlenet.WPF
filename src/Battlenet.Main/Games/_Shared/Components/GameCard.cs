namespace Battlenet.Main.Games._Shared.Components
{
    public class GameCard : ListBox
    {
        static GameCard()
        {
            DefaultStyleKeyProperty.OverrideMetadata (typeof (GameCard), new FrameworkPropertyMetadata (typeof (GameCard)));
        }
    }
}
