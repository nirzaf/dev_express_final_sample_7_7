using System;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm;
using System.Collections.ObjectModel;
using DevExpress.Mvvm.POCO;

namespace sample_7_7.ViewModels {
  [POCOViewModel]
  public class TasksViewModel {
    protected TasksViewModel() { }

    public static TasksViewModel Create() =>
        ViewModelSource.Create(() => new TasksViewModel());

    public static TasksViewModel Create(ObservableCollection<TaskViewModel> tasks) =>
        ViewModelSource.Create(() => new TasksViewModel { Tasks = tasks });

    public virtual ObservableCollection<TaskViewModel> Tasks { get; set; }

    [ServiceProperty]
    protected virtual IDialogService DialogService { get { return null; } }

    public void EditTask(TaskViewModel task) {
      var taskClone = TaskViewModel.CreateFrom(task);

      if (DialogService.ShowDialog(
        MessageButton.OKCancel, "Edit Task", "TaskView", taskClone) == MessageResult.OK) {
        task.LoadFrom(taskClone);
      }
    }
  }
}