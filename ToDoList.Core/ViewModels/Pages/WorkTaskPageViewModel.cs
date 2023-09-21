namespace ToDoList.Core;

public class WorkTaskPageViewModel
{

    public List<WorkTaskViewModel> WorkTaskList { get; set; } = new List<WorkTaskViewModel>();

    public string NewWorkTaskTitle { get; set; }

    public string NewWorkTaskDescription { get; set; }

    private void AddNewTask()
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
