using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using sample_7_7.ViewModels;
using System.Collections.ObjectModel;
using DevExpress.Utils.MVVM;
using DevExpress.XtraGrid.Views.Base;

namespace sample_7_7.Views {
  public partial class TasksView : DevExpress.XtraEditors.XtraUserControl {
    public TasksView() {
      InitializeComponent();
    }

    private void TasksView_Load(object sender, EventArgs e) {
      var fluent = mvvmContext1.OfType<TasksViewModel>();
      fluent.SetObjectDataSourceBinding(tasksViewModelBindingSource);

      mvvmContext1.AttachBehavior<GridDoubleClickEditBehavior>(gridView1);
    }

    private void mvvmContext1_ViewModelCreate(object sender, DevExpress.Utils.MVVM.ViewModelCreateEventArgs e) {
      var today = DateTime.Today;
      var tasks = new ObservableCollection<TaskViewModel> {
        TaskViewModel.Create("Do shopping", today),
        TaskViewModel.Create("Dinner with Joe", today + TimeSpan.FromDays(2)),
        TaskViewModel.Create("Car in shop", today + TimeSpan.FromDays(1)),
        TaskViewModel.Create("Clean patio", today + TimeSpan.FromDays(1)),
        TaskViewModel.Create("Take the garbage out", today + TimeSpan.FromDays(4)),
        TaskViewModel.Create("Complete MVVM project", today),
        TaskViewModel.Create("Vegas, baby!", today + TimeSpan.FromDays(10))
      };
      e.ViewModel = TasksViewModel.Create(tasks);
    }
  }

  public class GridDoubleClickEditBehavior : EventToCommandBehavior<TasksViewModel, EventArgs> {
    public GridDoubleClickEditBehavior() : base("DoubleClick", x => x.EditTask(null)) { }

    protected override object GetCommandParameter() => ((ColumnView)this.Source).GetFocusedRow();
  }
}
