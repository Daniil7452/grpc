using Client.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Client.Services.Commands;
using Client.Model.Repository.Interfaces;
using System.Windows;
using System.Windows.Threading;
using System.Threading;

namespace Client.ViewModel
{
    internal class ApplicationViewModel : INotifyPropertyChanged
    {
        private Worker? _selectedWorker;
        private int _selectedWorkerIndex;

        private Dispatcher _dispather;

        private RelayCommand? _addCommand;
        private RelayCommand? _removeCommand;
        private RelayCommand? _saveCommand;
        public ObservableCollection<Worker> Workers { get; set; } = new();

        private IRepository _repository;

        public RelayCommand AddCommand
        {
            get => _addCommand ?? (_addCommand = new RelayCommand(obj => Task.Run(AddWorkerAsync)));
        }

        public RelayCommand RemoveCommand
        {
            get => _removeCommand ?? (_removeCommand = new(obj => Task.Run(RemoveWorkerAsync)));
        }

        public RelayCommand SaveCommand
        {
            get => _saveCommand ?? (_saveCommand = new(obj => Task.Run(UpdateWorkerAsync)));
        }

        public Worker? SelectedWorker
        {
            get => _selectedWorker;
            set
            {
                if ((_selectedWorker = value) == null)
                    _selectedWorker = new();

                OnPropertyChanged("SelectedWorker");
            }
        }

        public int SelectedWorkerIndex
        {
            get => _selectedWorkerIndex;
            set => _selectedWorkerIndex = value;
        }

        public ApplicationViewModel(IRepository repository)
        {
            _repository = repository;
            Task.Run(LoadWorkers);
            _dispather = Dispatcher.CurrentDispatcher;
        }

        async Task AddWorkerAsync()
        {
            var newWorker = new Worker();

            if(await _repository.CreateWorkerAsync(newWorker))
            { 
                _dispather.Invoke(() => Workers.Insert(0, newWorker)); 
                SelectedWorker = newWorker;
                SelectedWorkerIndex = 0;
            }
            else
            {
                MessageBox.Show("Failed to create new worker", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        async Task RemoveWorkerAsync()
        {
            if (SelectedWorker == null)
                return;

            if (MessageBox.Show("Are you sure you want to delete the worker?", "", 
                MessageBoxButton.YesNo, 
                MessageBoxImage.Question) == MessageBoxResult.No)
                return;

            if (await _repository.DeleteWorkerAsync(SelectedWorker))
            {
                _dispather.Invoke(() => Workers.Remove(SelectedWorker));
            }
            else
            {
                MessageBox.Show("Failed to delete worker", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            UpdateWorkersListSelection(Workers.Count, SelectedWorkerIndex);
        }

        async Task UpdateWorkerAsync()
        {
            if (SelectedWorker == null)
                return;

            if (!await _repository.UpdateWorkerAsync(SelectedWorker))
            {
                MessageBox.Show("Failed to update employee information", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async void LoadWorkers()
        {
            var workers = await _repository.GetWorkersAsync();
            if(workers != null)
            {
                Workers = new(workers);
            }
        }

        private void UpdateWorkersListSelection(int workersCount, int selectedIndex)
        {
            if (workersCount == 0)
            {
                SelectedWorker = null;
            }
            else if (workersCount <= selectedIndex)
            {
                SelectedWorker = Workers[workersCount - 1];
            }
            else
            {
                SelectedWorker = Workers[selectedIndex];
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
