using FlintsToolkit.ViewModel;
using System;
using System.Collections.Generic;
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

namespace FlintsToolkit.Modules.Tasks.Views
{
    /// <summary>
    /// Interaktionslogik für TaskOverview.xaml
    /// </summary>
    public partial class TaskOverviewView : UserControl
    {
        public TaskOverviewView()
        {
            InitializeComponent();

            this.Loaded += (s, e) => {
                var vm = (FTViewModelBase)this.DataContext;

                vm.Loaded.Execute(null);
            };

        }
    }
}
