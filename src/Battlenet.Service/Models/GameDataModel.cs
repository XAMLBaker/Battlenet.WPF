namespace Battlenet.Service.Models
{
    public class GameDataModel
    {
        public string Name { get; set; }
        public string BackgroundUrl { get; set; }
        public string LogoUrl { get; set; }
        public bool IsMobile { get; set; } = false;
    }
}
