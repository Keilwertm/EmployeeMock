using EmployeeManager.Common.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeManager.ViewModel
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        private Employee _employee;

        public EmployeeViewModel(Employee employee)
        {
            _employee = employee;
        }

        public string FirstName
        {
            get => _employee.FirstName;
            set
            {
                if (_employee.FirstName != value)
                {
                    _employee.FirstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        // The rest of your properties...

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}