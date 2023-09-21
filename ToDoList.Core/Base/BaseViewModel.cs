using System.Collections.Specialized;
using System.ComponentModel;

namespace ToDoList.Core.Base;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;
}
