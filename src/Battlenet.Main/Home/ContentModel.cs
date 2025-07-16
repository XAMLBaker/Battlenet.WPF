using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Media.Imaging;

namespace Battlenet.Main.Home
{
    public class SlideAdModel
    {
        public string GameName { get; set; }
        public string GameComment { get; set; }
        public string AdTitle { get; set; }
        public string AdSubTitle { get; set; }
        public string ButtonName { get; set; }
        public string Logo { get; set; }
        public string BackgroundImage { get; set; }
        public string Thumnail { get; set; }
    }

    public partial class ContentModel : ObservableObject
    {
        [ObservableProperty] List<SlideAdModel> _slideAdModels;

        public ContentModel()
        {
            SlideAdModels = new List<SlideAdModel>()
            {
                new SlideAdModel ()
                {
                    GameName = "월드 오브 워크래프트",
                    GameComment = "탈것과 애완동물을 획득하세요",
                    AdTitle = "사바크의 전령 탈것과 사바크의 총애 애완동물을 손에 넣으세요",
                    AdSubTitle = "180일 게임 시간을 구매하고 탈것과 애완동물을 모두 받으세요.",
                    ButtonName ="게임 시간 구매하기",
                    Logo = "/Battlenet.Main;component/Home/Resources/Warcraft_Logo.png",
                    BackgroundImage = "/Battlenet.Main;component/Home/Resources/Warcraft_Background.jpg",
                    Thumnail = "/Battlenet.Main;component/Home/Resources/Warcraft_thumnail.jpg",
                },
                new SlideAdModel ()
                {
                    GameName = "디아블로",
                    GameComment = "",
                    AdTitle = "새 시즌 시작",
                    AdSubTitle = "",
                    ButtonName ="배틀 패스 시작하기",
                    Logo = "/Battlenet.Main;component/Home/Resources/Diablo_Logo.png",
                    BackgroundImage = "/Battlenet.Main;component/Home/Resources/Diablo_Background.jpg",
                    Thumnail = "/Battlenet.Main;component/Home/Resources/Diablo_thumnail.jpg",
                },
                new SlideAdModel ()
                {
                    GameName = "콜오브듀티",
                    GameComment = "",
                    AdTitle = "스탠다드 에디션 45% 할인",
                    AdSubTitle = "",
                    ButtonName ="구매하기",
                    Logo = "/Battlenet.Main;component/Home/Resources/callofduty_Logo.png",
                    BackgroundImage = "/Battlenet.Main;component/Home/Resources/callofduty_Background.jpg",
                    Thumnail = "/Battlenet.Main;component/Home/Resources/callofduty_thumnail.jpg",
                },
                new SlideAdModel ()
                {
                    GameName = "하스스톤",
                    GameComment = "",
                    AdTitle = "선술집 패스로 새로운 여정을 시작하세요",
                    AdSubTitle = "",
                    ButtonName ="구매하기",
                    Logo = "/Battlenet.Main;component/Home/Resources/HearthStone_Logo.png",
                    BackgroundImage = "/Battlenet.Main;component/Home/Resources/HearthStone_Background.jpg",
                    Thumnail = "/Battlenet.Main;component/Home/Resources/HearthStone_thumnail.jpg",
                },
            };
        }
    }
}
