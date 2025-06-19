using System.IO;
using System.Net.Http;
using System.Windows.Media.Imaging;

namespace Battlenet.Main.Games._Shared.Components
{
    public partial class WebImageComponent : Component
    {
        private Image MainPost;
        private Image TextPost;
        public WebImageComponent()
        {
            MainPost = new Image ();
            TextPost = new Image ();
            Task.Run (() =>
            {
                Application.Current.Dispatcher.Invoke (async() =>
                {
                    MainPost.Source = await GetImage ("https://blz-contentstack-images.akamaized.net/v3/assets/blta8f9a8e092360c6c/bltef23deacbfc70dd3/671fd0f27c61fd5321468778/blizzard_game_card_background_wr.jpg?format=webply&quality=80&auto=webp");
                    TextPost.Source = await GetImage ("https://blz-contentstack-images.akamaized.net/v3/assets/blta8f9a8e092360c6c/blt3fa8aaa0ba66f978/671fcc4bd3be08e5eb8e0ea9/blizzard_game_card_logo_wr.png");
                });
            });
        }
        protected override Visual Build()
            => new Viewbox ()
                    .Child (
                        new Grid ()
                            .Children (
                                MainPost,
                                TextPost
                            )
                    ).Size(187, 247);

        public async Task<BitmapImage> GetImage(string url)
        {
            using var httpClient = new HttpClient ();
            var bytes = await httpClient.GetByteArrayAsync (url);
            using var ms = new MemoryStream (bytes);

            var bitmap = new BitmapImage ();
            bitmap.BeginInit ();
            bitmap.StreamSource = ms;
            bitmap.CacheOption = BitmapCacheOption.OnLoad; // 전체 읽기
            bitmap.CreateOptions = BitmapCreateOptions.None; // 알파 무시 방지
            bitmap.EndInit ();
            bitmap.Freeze (); // UI 스레드 외에서도 사용 가능


            return bitmap;
        }
    }
}
