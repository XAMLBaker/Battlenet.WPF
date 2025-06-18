using Battlenet.Common.Components;
using Slate.WPF;
using Slate.WPF.Markup;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Battlenet.Main._Shared.Components
{
    public partial class Header : Slate.WPF.Markup.Component
    {
        private readonly ILayoutNavigator _layoutNavigator;

        public Header(ILayoutNavigator layoutNavigator)
        {
            _layoutNavigator = layoutNavigator;
        }
        protected override Visual Build()
            => new Grid ()
                   .Height(60)
                   .Columns("auto, auto, *")
                   .Background (Colors.Transparent)
                   .Children (
                       Menu ()
                            .OnTapped ((s, e) =>
                            {
                                var panel = (FrameworkElement)s;
                                panel.TransitionYAnimation (2.0, EasingMode.EaseIn, 150);
                            })
                            .OnTappedRelease ((s, e) =>
                            {
                                var panel = (FrameworkElement)s;
                                panel.TransitionYAnimation (0.0, EasingMode.EaseOut, 150);
                            }),
                       new HStack (30)
                            .Margin(left:20)
                            .Column(1)
                            .Children (
                                GroupButtonTemplate ("HOME")
                                    .IsChecked (true)
                                    .OnCheckedAsync (async () =>
                                    {
                                        await _layoutNavigator.NavigateToAsync (RouteNames.Home);
                                    }),
                                GroupButtonTemplate ("GAMES")
                                    .OnCheckedAsync (async () =>
                                    {
                                        await _layoutNavigator.NavigateToAsync ($"{RouteNames.Games}/MyGames");
                                    }),
                                GroupButtonTemplate ("SHOP")
                                    .OnChecked (() =>
                                    {
                                    })
                            ),
                       new Border()
                          .Column (2)
                          .Right()
                          .Child(
                              new Viewbox ()
                                  .Size(20, 20)
                                  .Margin (top: -2, left: -2)
                                  .Child (
                                     new Path ()
                                     {
                                         Data = PathExtensions.Data ("M10 21H14C14 22.1 13.1 23 12 23S10 22.1 10 21M21 19V20H3V19L5 17V11C5 7.9 7 5.2 10 4.3V4C10 2.9 10.9 2 12 2S14 2.9 14 4V4.3C17 5.2 19 7.9 19 11V17L21 19M17 11C17 8.2 14.8 6 12 6S7 8.2 7 11V18H17V11Z")
                                     }.Fill (Colors.White)
                                  )
                           )
                          .Background(Colors.Transparent)
                          .Size(42, 40)
                          .CornerRadius(5)
                          .OnHover ((el) =>
                          {
                              el.Background.WithAnimation ("#313239",100);
                          })
                          .OnRelease ((el) =>
                          {
                              el.Background.WithAnimation (Colors.Transparent,100);
                          })
                   );

        private HStack Menu()
            => new HStack ()
                    .Cursor (Cursors.Hand)
                    .Children (
                        new Grid ()
                            .Background (Colors.Transparent)
                            .Children (
                                new Viewbox ()
                                    .IsHitTestVisible(false)
                                    .Size (37, 42)
                                    .Child (
                                        new Path ()
                                        {
                                            Data = PathExtensions.Data ("M 52 4 L 51 5 L 49 5 L 48 6 L 47 6 L 46 7 L 45 7 L 42 10 L 42 11 L 40 13 L 40 14 L 39 15 L 39 16 L 38 17 L 38 19 L 37 20 L 37 22 L 36 23 L 36 27 L 35 28 L 35 34 L 34 35 L 34 42 L 32 44 L 29 44 L 28 45 L 25 45 L 24 46 L 22 46 L 21 47 L 20 47 L 19 48 L 18 48 L 17 49 L 16 49 L 15 50 L 14 50 L 13 51 L 12 51 L 11 52 L 10 52 L 7 55 L 6 55 L 3 58 L 3 59 L 4 59 L 6 57 L 7 57 L 8 56 L 9 56 L 10 55 L 11 55 L 12 54 L 14 54 L 15 53 L 17 53 L 18 52 L 20 52 L 21 51 L 24 51 L 25 50 L 29 50 L 30 49 L 34 49 L 35 50 L 35 53 L 36 54 L 36 59 L 37 60 L 37 64 L 38 65 L 38 68 L 39 69 L 39 72 L 40 73 L 40 75 L 41 76 L 41 79 L 42 80 L 42 82 L 43 83 L 43 84 L 44 85 L 44 87 L 45 88 L 45 90 L 46 91 L 46 92 L 47 93 L 47 94 L 48 95 L 48 96 L 49 97 L 49 98 L 50 99 L 50 101 L 52 103 L 52 104 L 53 105 L 53 106 L 54 107 L 54 108 L 56 110 L 56 111 L 58 113 L 58 114 L 60 116 L 60 117 L 59 118 L 57 118 L 56 119 L 53 119 L 52 120 L 47 120 L 46 119 L 44 119 L 39 114 L 39 113 L 38 112 L 38 110 L 37 109 L 37 100 L 38 99 L 38 96 L 39 95 L 39 93 L 40 92 L 40 91 L 39 90 L 39 88 L 38 87 L 38 86 L 37 85 L 37 83 L 36 82 L 36 80 L 35 79 L 35 78 L 35 79 L 34 80 L 34 81 L 32 83 L 32 84 L 31 85 L 31 86 L 30 87 L 30 88 L 29 89 L 29 90 L 28 91 L 28 93 L 27 94 L 27 95 L 26 96 L 26 98 L 25 99 L 25 101 L 24 102 L 24 105 L 23 106 L 23 110 L 22 111 L 22 123 L 23 124 L 23 126 L 24 127 L 24 128 L 25 129 L 25 130 L 28 133 L 28 134 L 29 134 L 30 135 L 31 135 L 32 136 L 34 136 L 35 137 L 47 137 L 48 136 L 52 136 L 53 135 L 55 135 L 56 134 L 57 134 L 58 133 L 59 133 L 60 132 L 61 132 L 62 131 L 63 131 L 64 130 L 65 130 L 66 129 L 67 129 L 68 128 L 69 128 L 79 138 L 80 138 L 83 141 L 84 141 L 85 142 L 86 142 L 87 143 L 88 143 L 90 145 L 92 145 L 93 146 L 95 146 L 96 147 L 99 147 L 98 146 L 97 146 L 96 145 L 95 145 L 94 144 L 93 144 L 90 141 L 89 141 L 78 130 L 78 129 L 74 125 L 74 124 L 76 122 L 77 122 L 80 119 L 81 119 L 86 114 L 87 114 L 93 108 L 93 107 L 100 100 L 100 99 L 104 95 L 104 94 L 106 92 L 106 91 L 109 88 L 109 87 L 111 85 L 111 84 L 113 82 L 113 81 L 114 80 L 114 79 L 116 77 L 116 76 L 117 75 L 117 74 L 118 73 L 118 72 L 119 71 L 119 70 L 120 69 L 121 69 L 128 76 L 128 77 L 129 78 L 129 80 L 130 81 L 130 84 L 129 85 L 129 87 L 122 94 L 121 94 L 120 95 L 119 95 L 118 96 L 116 96 L 115 97 L 113 97 L 112 98 L 110 98 L 109 99 L 108 99 L 105 102 L 105 103 L 99 109 L 115 109 L 116 108 L 121 108 L 122 107 L 127 107 L 128 106 L 130 106 L 131 105 L 133 105 L 134 104 L 135 104 L 136 103 L 137 103 L 138 102 L 139 102 L 140 101 L 141 101 L 148 94 L 148 93 L 149 92 L 149 90 L 150 89 L 150 80 L 149 79 L 149 78 L 148 77 L 148 75 L 146 73 L 146 72 L 136 62 L 135 62 L 133 60 L 132 60 L 130 58 L 129 58 L 128 57 L 127 57 L 125 55 L 125 54 L 126 53 L 126 51 L 127 50 L 127 47 L 128 46 L 128 41 L 129 40 L 129 27 L 128 26 L 128 22 L 127 21 L 127 20 L 126 21 L 127 22 L 127 29 L 126 30 L 126 35 L 125 36 L 125 39 L 124 40 L 124 42 L 123 43 L 123 45 L 122 46 L 122 48 L 121 49 L 121 51 L 119 53 L 118 52 L 116 52 L 115 51 L 114 51 L 113 50 L 111 50 L 110 49 L 108 49 L 107 48 L 105 48 L 104 47 L 102 47 L 101 46 L 99 46 L 98 45 L 95 45 L 94 44 L 90 44 L 89 43 L 84 43 L 83 42 L 78 42 L 77 41 L 49 41 L 48 40 L 48 37 L 49 36 L 49 34 L 50 33 L 50 32 L 51 31 L 51 30 L 53 28 L 53 27 L 54 26 L 55 26 L 56 25 L 57 25 L 58 24 L 63 24 L 64 25 L 67 25 L 68 26 L 69 26 L 72 29 L 73 29 L 80 36 L 84 36 L 85 37 L 90 37 L 91 38 L 94 38 L 93 37 L 93 36 L 91 34 L 91 33 L 90 32 L 90 31 L 88 29 L 88 28 L 85 25 L 85 24 L 80 19 L 80 18 L 74 12 L 73 12 L 70 9 L 69 9 L 68 8 L 67 8 L 66 7 L 65 7 L 64 6 L 63 6 L 62 5 L 59 5 L 58 4 Z M 47 49 L 48 48 L 66 48 L 67 49 L 74 49 L 75 50 L 79 50 L 80 51 L 83 51 L 84 52 L 87 52 L 88 53 L 90 53 L 91 54 L 93 54 L 94 55 L 96 55 L 97 56 L 98 56 L 99 57 L 101 57 L 102 58 L 103 58 L 104 59 L 105 59 L 106 60 L 107 60 L 108 61 L 109 61 L 110 62 L 111 62 L 112 63 L 113 63 L 114 64 L 114 66 L 112 68 L 112 69 L 111 70 L 111 71 L 109 73 L 109 74 L 107 76 L 107 77 L 104 80 L 104 81 L 101 84 L 101 85 L 82 104 L 81 104 L 78 107 L 77 107 L 74 110 L 73 110 L 71 112 L 70 112 L 69 113 L 68 113 L 67 114 L 65 112 L 65 111 L 63 109 L 63 108 L 62 107 L 62 106 L 61 105 L 61 104 L 60 103 L 60 102 L 59 101 L 59 100 L 58 99 L 58 98 L 57 97 L 57 95 L 56 94 L 56 93 L 55 92 L 55 90 L 54 89 L 54 87 L 53 86 L 53 84 L 52 83 L 52 81 L 51 80 L 51 77 L 50 76 L 50 73 L 49 72 L 49 67 L 48 66 L 48 59 L 47 58 Z")
                                        }
                                        .Fill ("#148eff")
                                    )
                            )
                            .OnHover ((el) =>
                            {
                                ((Path)((Viewbox)el.Children[0]).Child).Fill.WithAnimation ("#47a6ff");
                            })
                            .OnRelease ((el) =>
                            {
                                ((Path)((Viewbox)el.Children[0]).Child).Fill.WithAnimation ("#148eff");
                            }),

                        new Viewbox ().Size (10, 10)
                            .Child (
                                new Path ()
                                {
                                    Data = PathExtensions.Data ("M7.41,8.58L12,13.17L16.59,8.58L18,10L12,16L6,10L7.41,8.58Z")
                                }
                                .Fill ("#a8a9ab")
                            )
                            
                    );

        private GroupButton GroupButtonTemplate(object o)
            => new GroupButton ()
                    .Height(30)
                    .Content (o)
                    .Foreground ("#8c8e80")
                    .FontSize (15)
                    .FontWeight (FontWeights.DemiBold)
                    .OnChecked ((el) =>
                    {
                        el.Foreground.WithAnimation (Colors.White);
                    })
                    .OnUnchecked ((el) =>
                    {
                        el.Foreground.WithAnimation ("#8c8e80");
                    })
                    .OnHover ((el) =>
                    {
                        if (el.IsChecked.Value == true)
                            return;
                        el.Foreground.WithAnimation (Colors.White);
                    })
                    .OnRelease ((el) =>
                    {
                        if (el.IsChecked.Value == true)
                            return;
                        el.Foreground.WithAnimation ("#8c8e80");
                    });
    }
}
