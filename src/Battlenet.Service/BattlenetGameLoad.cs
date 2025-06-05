using Battlenet.Service.Models;
using HtmlAgilityPack;

namespace Battlenet.Service
{
    public class BattlenetGameLoad
    {
        public async Task<List<GameDataModel>> Load()
        {
            HtmlWeb web = new HtmlWeb();

            HtmlDocument document = web.Load ("https://www.blizzard.com/ko-kr/games");

            var desktopCards = document.DocumentNode.SelectNodes ("//div[@id='products-1']//blz-game-card[contains(@class, 'DesktopCard')]");
            var result = new List<GameDataModel> ();
            if (desktopCards != null)
            {
                foreach (var card in desktopCards)
                {
                    var name = card.SelectSingleNode (".//h3[@slot='heading']")?.InnerText?.Trim ();
                    var background = card.SelectSingleNode (".//blz-image[@slot='image']")?.GetAttributeValue ("src", "").Split ('?')[0];
                    var logo = card.SelectSingleNode (".//blz-image[@slot='logo']")?.GetAttributeValue ("src", "").Split ('?')[0];

                    result.Add (new GameDataModel()
                    {
                        Name = name,
                        BackgroundUrl = background,
                        LogoUrl = logo
                    });
                }

                var mobileDesktopCards = document.DocumentNode.SelectNodes ("//div[@id='products-3']//blz-game-card[contains(@class, 'DesktopCard')]");
                foreach (var card in mobileDesktopCards)
                {
                    var name = card.SelectSingleNode (".//h3[@slot='heading']")?.InnerText?.Trim ();
                    result.FirstOrDefault (x => x.Name == name).IsMobile = true;
                }
            }
            else
            {
                Console.WriteLine ("DesktopCard 클래스가 없습니다.");
            }

            return result;
        }
    }
}
