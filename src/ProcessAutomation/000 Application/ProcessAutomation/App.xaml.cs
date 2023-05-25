
using Microsoft.Extensions.DependencyInjection;
using PA.Share;
using PA.ICommon;
using PA.Views;
using PA.ViewModels;
using ReactiveUI;
using Splat;
using System;
using System.Windows;
using PA.Share.Stores;
using PA.Share.Mvvm;
using Zoranof.WorkFlow;
using PA.Service;
using ProcessAutomation.ViewModels;
using PA.Service.Interface;

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
            services.AddCustomWorkFlow();
            serviceProvider = services.BuildServiceProvider();
            Locator.CurrentMutable.RegisterConstant(serviceProvider);

            //Locator.CurrentMutable.RegisterConstant(new DbService(), typeof(DbService));
            Locator.CurrentMutable.RegisterConstant(new LoggerService(), typeof(LoggerService));
            Locator.CurrentMutable.RegisterConstant(new DbService(), typeof(IDbService));

            Locator.CurrentMutable.RegisterConstant(new GlobalStore(), typeof(GlobalStore));
            Locator.CurrentMutable.RegisterConstant(new RouterStore(), typeof(RouterStore));
            Locator.CurrentMutable.RegisterConstant(new TestingStore(), typeof(TestingStore));


            // views of main
            Locator.CurrentMutable.Register(() => new ShellView(), typeof(IViewFor<ShellViewModel>));
            Locator.CurrentMutable.Register(() => new EditorView(), typeof(IViewFor<EditorViewModel>));
            Locator.CurrentMutable.Register(() => new TestingView(), typeof(IViewFor<TestingViewModel>));
            Locator.CurrentMutable.Register(() => new ConsoleView(), typeof(IViewFor<ConsoleViewModel>));
            Locator.CurrentMutable.Register(() => new HistoryView(), typeof(IViewFor<HistoryViewModel>));
            Locator.CurrentMutable.Register(() => new NewTabView(), typeof(IViewFor<NewTabViewModel>));

            Locator.CurrentMutable.Register(() => new TestingItemEditor(), typeof(IViewFor<TestingItemEditorViewModel>));
            

            // viewmodels of main
            Locator.CurrentMutable.Register(() => new ShellViewModel(), typeof(IViewModel), Constants.ShellView);
            Locator.CurrentMutable.Register(() => new EditorViewModel(), typeof(IViewModel), Constants.EditorView);
            Locator.CurrentMutable.Register(() => new TestingViewModel(), typeof(IViewModel), Constants.TestingView);
            Locator.CurrentMutable.Register(() => new ConsoleViewModel(), typeof(IViewModel), Constants.ConsoleView);
            Locator.CurrentMutable.Register(() => new HistoryViewModel(), typeof(IViewModel), Constants.HistoryView);
            Locator.CurrentMutable.Register(() => new NewTabViewModel(), typeof(IViewModel), Constants.NewTabView);
            Locator.CurrentMutable.Register(() => new TestingItemEditorViewModel(), typeof(IViewModel), Constants.TestingItemEditorView);


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
