using CommunityToolkit.Mvvm.ComponentModel;
using System.IO;
using System.Net.Http;
using System.Windows.Media.Imaging;

namespace Battlenet.Main.Games.Models;

[INotifyPropertyChanged]
public partial class GameDataModel : Battlenet.Service.Models.GameDataModel
{
    [ObservableProperty] BitmapImage mainPostImage;
    [ObservableProperty] BitmapImage logoPostImage;

    public GameDataModel(Battlenet.Service.Models.GameDataModel gameDataModel)
    {
        this.LogoUrl = gameDataModel.LogoUrl;
        this.BackgroundUrl = gameDataModel.BackgroundUrl;
        this.Name = gameDataModel.Name;
        this.IsMobile = gameDataModel.IsMobile;

        Task.Run (async () =>
        {
            this.MainPostImage = await GetImage (this.BackgroundUrl);
            this.LogoPostImage = await GetImage (this.LogoUrl);
        });
    }

    private async Task<BitmapImage> GetImage(string url)
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
