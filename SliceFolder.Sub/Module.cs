using FlexMVVM;
using FlexMVVM.WPF;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SliceFolder.Sub
{
    public class Module : IModule
    {
        public void Initialize(IServiceProvider serviceProvider)
        {
        }

        public void Register(IServiceCollection services)
        {
            services.RegisterLayout<Layout> ();
            services.AddSingleton<LayoutViewModel> ();
        }
    }
}
