using FlexMVVM;
using FlexMVVM.Modularity;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SliceFolder.Sub
{
    public class Module : IModule
    {
        public void Initialize(IServiceProvider containerProvider)
        {

        }

        public void Register(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterLayout<Layout> ();
            containerRegistry.RegisterLayout<Region> ();
            containerRegistry.RegisterLayout<Test.Layout> ();
            containerRegistry.RegisterLayout<Test2.Region> ();
            containerRegistry.Services.AddSingleton<LayoutViewModel> ();
        }
    }
}
