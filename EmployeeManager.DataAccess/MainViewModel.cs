using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using System.Collections.ObjectModel;

namespace EmployeeManager.ViewModel
{
    public class MainViewModel : ViewModelbase
    {
        private EmployeeViewModel _selectedEmployee;
        public MainViewModel(IEmployeeDataProvider employeeDataProvider)
        {
            EmployeeDataProvider = employeeDataProvider;
        }
        public ObservableCollection<EmployeeViewModel> Employees { get; } = new();
        public ObservableCollection<JobRole> JobRoles { get; } = new();
        public EmployeeViewModel SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (_selectedEmployee != value)
                {
                    _selectedEmployee = value;
                //   RaisePropertyChanged();
              //   RaisePropertyChanged(nameof(IsEmployeeSelected));
                }
            }
        }
      

        public bool IsEmployeeSelected => SelectedEmployee != null;

        public IEmployeeDataProvider EmployeeDataProvider { get; }

       /* public void Load()
        {
            var employees = _employeeDataProvider.LoadEmployees();
                var jobRoles = _employeeDataProvider.LoadJobRoles();

            Employees.Clear();
            foreach (var employee in employees) 
            {
                Employees.Add(new EmployeeViewModel(employee, _employeeDataProvider));
            }

            jobRoles.Clear();
            foreach (var jobRole in jobRoles)
            {
                JobRoles.Add(jobRole);
            }
        } */
    }
}
