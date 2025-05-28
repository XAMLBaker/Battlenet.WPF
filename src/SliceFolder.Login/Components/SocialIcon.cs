using FlexMVVM.WPF;
using FlexMVVM.WPF.Markup;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SliceFolder.Login.Components
{
    internal enum SocialButtonType
    {
        GOOGLE,
        FACEBOOK,
        APPLE,
        XBOX,
        PLAYSTATION,
        NINTENDO,
        STEAM
    }

    public static partial class IconPathSupport
    {
        public static Viewbox Google
            => new Viewbox ()
                    .Child (
                        new Grid ()
                            .Children (
                            new Path ()
                            {
                                Data = PathExtentions.Data ("M43.611,20.083H42V20H24v8h11.303c-1.649,4.657-6.08,8-11.303,8c-6.627,0-12-5.373-12-12c0-6.627,5.373-12,12-12c3.059,0,5.842,1.154,7.961,3.039l5.657-5.657C34.046,6.053,29.268,4,24,4C12.955,4,4,12.955,4,24c0,11.045,8.955,20,20,20c11.045,0,20-8.955,20-20C44,22.659,43.862,21.35,43.611,20.083z")
                            }
                            .Fill ("#FFC107"),

                            new Path ()
                            {
                                Data = PathExtentions.Data ("M6.306,14.691l6.571,4.819C14.655,15.108,18.961,12,24,12c3.059,0,5.842,1.154,7.961,3.039l5.657-5.657C34.046,6.053,29.268,4,24,4C16.318,4,9.656,8.337,6.306,14.691z")
                            }
                            .Fill ("#FF3D00"),

                            new Path ()
                            {
                                Data = PathExtentions.Data ("M24,44c5.166,0,9.86-1.977,13.409-5.192l-6.19-5.238C29.211,35.091,26.715,36,24,36c-5.202,0-9.619-3.317-11.283-7.946l-6.522,5.025C9.505,39.556,16.227,44,24,44z")
                            }
                            .Fill ("#4CAF50"),

                            new Path ()
                            {
                                Data = PathExtentions.Data ("M43.611,20.083H42V20H24v8h11.303c-0.792,2.237-2.231,4.166-4.087,5.571c0.001-0.001,0.002-0.001,0.003-0.002l6.19,5.238C36.971,39.205,44,34,44,24C44,22.659,43.862,21.35,43.611,20.083z")
                            }
                            .Fill ("#1976D2")
                            )
                     );
        public static Viewbox Facebook
            => new Viewbox ()
                    .Child (
                        new Path ()
                        {
                            Data = PathExtentions.Data ("M12 2.04C6.5 2.04 2 6.53 2 12.06C2 17.06 5.66 21.21 10.44 21.96V14.96H7.9V12.06H10.44V9.85C10.44 7.34 11.93 5.96 14.22 5.96C15.31 5.96 16.45 6.15 16.45 6.15V8.62H15.19C13.95 8.62 13.56 9.39 13.56 10.18V12.06H16.34L15.89 14.96H13.56V21.96A10 10 0 0 0 22 12.06C22 6.53 17.5 2.04 12 2.04Z")
                        }
                        .Fill (Colors.White)
                    );
}
