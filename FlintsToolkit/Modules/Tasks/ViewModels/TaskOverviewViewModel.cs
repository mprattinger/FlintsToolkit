using FlintsToolkit.Contracts;
using FlintsToolkit.Models;
using FlintsToolkit.Modules.Tasks.Models;
using FlintsToolkit.ViewModel;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlintsToolkit.Modules.Tasks.ViewModels
{
    public class TaskOverviewViewModel : FTViewModelBase
    {
        private IDataService _dataService;

        public ObservableCollection<DropdownEntry> TaskState { get; set; }
        public ObservableCollection<TaskItem> Tasks { get; set; }

        private TaskItem _currentTask;
        public TaskItem CurrentTask
        {
            get { return _currentTask; }
            set
            {
                if (_currentTask == value) return;
                var old = _currentTask;
                _currentTask = value;
                RaisePropertyChanged("CurrentTask");
            }
        }

        public RelayCommand NewTask { get; set; }
        public RelayCommand DeleteTask { get; set; }

        public TaskOverviewViewModel(IDataService dataService) : base()
        {
            _dataService = dataService;

            NewTask = new RelayCommand(() => {
                
            });

            IsBusy = true;
            loadTasks().Wait();
            IsBusy = false;
        }

        private async Task loadTasks()
        {
            Tasks = new ObservableCollection<TaskItem>(await _dataService.LoadTasksFromDb());
        }
    }
}
