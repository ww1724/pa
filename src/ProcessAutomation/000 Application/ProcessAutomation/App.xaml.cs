using Microsoft.Extensions.DependencyInjection;
using PA.Common;
using PA.ICommon;
using PA.Views;
using PA.ViewModels;
using ReactiveUI;
using Splat;
using System;
using System.Windows;

namespace ProcessAutomation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// 插件管理器
        /// </summary>
        IPluginManager pluginManager;

        /// <summary>
        /// 
        /// </summary>
        IServiceProvider serviceProvider;

        public App()
        {
            InitializeComponent();
            Configure();
        }

        public void Configure()
        {
            // services
            pluginManager = new PluginManager();
            Locator.CurrentMutable.RegisterLazySingleton<IPluginManager>(() => pluginManager);

            ServiceCollection services = new ServiceCollection();
            serviceProvider = services.BuildServiceProvider();
            Locator.CurrentMutable.RegisterLazySingleton<IServiceProvider>(() => serviceProvider);

            // main views
            Locator.CurrentMutable.Register(() => new ShellView(), typeof(IViewFor<ShellViewModel>));

            // plugins
            pluginManager.AddPluginPaths(new string[]{ "./plugins"});
            pluginManager.LoadPlugins();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
    }

    
}
