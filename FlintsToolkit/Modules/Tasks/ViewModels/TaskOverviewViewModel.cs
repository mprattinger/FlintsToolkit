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

        private ObservableCollection<TaskItem> _tasks;
        public ObservableCollection<TaskItem> Tasks
        {
            get { return _tasks; }
            set
            {
                if (_tasks == value) return;
                _tasks = value;
                RaisePropertyChanged("Tasks");
            }
        }

        private TaskItem _currentTask;
        public TaskItem CurrentTask
        {
            get { return _currentTask; }
            set
            {
                if (_currentTask == value) return;
                _currentTask = value;
                RaisePropertyChanged("CurrentTask");
            }
        }

        public RelayCommand NewTask { get; set; }
        public RelayCommand DeleteTask { get; set; }

        public TaskOverviewViewModel(IDataService dataService) : base()
        {
            _dataService = dataService;
            Tasks = new ObservableCollection<TaskItem>();

            Loaded = new RelayCommand(async () =>
            {
                await loadTasks();
            });

            NewTask = new RelayCommand(() =>
            {

            });

        }

        private async Task loadTasks()
        {
            IsBusy = true;
            Tasks = new ObservableCollection<TaskItem>(await _dataService.LoadTasksFromDb());
            IsBusy = false;
        }
    }
}
