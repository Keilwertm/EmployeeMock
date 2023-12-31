﻿using EmployeeManager.Common.DataProvider;
using EmployeeManager.Common.Model;
using EmployeeManager.ViewModel;
using System;
using System.ComponentModel;

namespace EmployeeManager
{
    public partial class EmployeeViewModel : ViewModelbase
    {
        private readonly Employee _employee;
        private readonly IEmployeeDataProvider _employeeDataProvider;
        public EmployeeViewModel(Employee employee, IEmployeeDataProvider employeeDataProvider)
        {
            _employee = employee;
            _employeeDataProvider = employeeDataProvider;
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
                    RaisePropertyChanged(nameof(CanSave));
                }
            }
        }

        public DateTimeOffset EntryDate
        {
            get => _employee.EntryDate;
            set
            {
                if (_employee.EntryDate != value)
                {
                    _employee.EntryDate = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int JobRoleId
        {
            get => _employee.JobRoleId;
            set
            {
                if (_employee.JobRoleId != value)
                {
                    _employee.JobRoleId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool IsCoffeeDrinker
        {
            get => _employee.IsCoffeeDrinker;
            set
            {
                if (_employee.IsCoffeeDrinker != value)
                {
                    _employee.IsCoffeeDrinker = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool CanSave => !string.IsNullOrEmpty(FirstName);

        public void Save()
        {
            _employeeDataProvider.SaveEmployee(_employee);
        }
    }
}
