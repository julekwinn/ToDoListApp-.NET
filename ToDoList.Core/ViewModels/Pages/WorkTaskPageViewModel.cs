using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ToDoList.Core;

public class WorkTaskPageViewModel
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
    }


}
