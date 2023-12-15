using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EmployeeManager.ViewModel

{
    public class ViewModelbase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

}

