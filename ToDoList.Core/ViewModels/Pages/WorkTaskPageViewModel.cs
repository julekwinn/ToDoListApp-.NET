using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using ToDoList.Core.Base;

namespace ToDoList.Core;

public class WorkTaskPageViewModel : BaseViewModel
{

    public ObservableCollection<WorkTaskViewModel> WorkTaskList { get; set; } = new ObservableCollection<WorkTaskViewModel>();

    public string NewWorkTaskTitle { get; set; }

    public string NewWorkTaskDescription { get; set; }

    public ICommand AddNewTaskCommand { get; set; }

    public WorkTaskPageViewModel()
    {
        AddNewTaskCommand = new RelayCommand(AddNewTask);
    }

    public void AddNewTask()
    {
        var newTask = new WorkTaskViewModel
        {
            Title = NewWorkTaskTitle,
            Description = NewWorkTaskDescription,
            CreatedDate = DateTime.Now
        };

        WorkTaskList.Add(newTask);

        NewWorkTaskTitle = string.Empty;
        NewWorkTaskDescription = string.Empty;

        OnPropertyChanged(nameof(NewWorkTaskTitle));
        OnPropertyChanged(nameof(NewWorkTaskDescription));
    }


}
