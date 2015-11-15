using Autofac;
using Dungeon_World_Manager.Infrastructure.Modules;
using Dungeon_World_Manager.Models;
using Dungeon_World_Manager.Properties;
using Dungeon_World_Manager.ViewModels;
using Dungeon_World_Manager.ViewModels.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dungeon_World_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private IContainer container;
        private IViewModel viewmodel;

        public MainWindow()
        {
            InitializeComponent();
            this.Closing += MainWindow_Closing;
            this.Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new DefaultWiringModule());
            container = builder.Build();

            viewmodel = container.Resolve<IViewModel>();

            try
            {
                var content = await App.ReadFileAsync(App.GetDataFilePath());
                var loadedViewModel = JsonConvert.DeserializeObject<ViewModel>(content);
                viewmodel.SetData(loadedViewModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine("WTF");
                Console.WriteLine(ex.StackTrace);
            }
        }

        private async void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var data = JsonConvert.SerializeObject(viewmodel, Formatting.Indented);
            await App.WriteTextAsync(App.GetDataFilePath(), data);
        }

        
    }
}
