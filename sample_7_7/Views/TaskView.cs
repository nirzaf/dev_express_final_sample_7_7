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
using DevExpress.Utils.MVVM.Services;

namespace sample_7_7.Views {
  public partial class TaskView : DevExpress.XtraEditors.XtraUserControl {
    public TaskView() {
      InitializeComponent();
    }

    private void TaskView_Load(object sender, EventArgs e) {

    }

    private void mvvmContext1_ViewModelSet(object sender, DevExpress.Utils.MVVM.ViewModelSetEventArgs e) {
      var fluent = mvvmContext1.OfType<TaskViewModel>();
      fluent.SetObjectDataSourceBinding(taskViewModelBindingSource);

      fluent.BindCommand(bbiMarkDone, x => x.MarkDone);
      fluent.BindCommand(bbiPostpone, x => x.Postpone);

      mvvmContext1.RegisterService(MessageBoxService.CreateXtraMessageBoxService(owner: this));
    }
  }
}
