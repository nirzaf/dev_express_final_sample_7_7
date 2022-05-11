namespace sample_7_7.Views {
  partial class TasksView {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.tasksViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDone = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksViewModelBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // mvvmContext1
      // 
      this.mvvmContext1.ContainerControl = this;
      this.mvvmContext1.ViewModelType = typeof(sample_7_7.ViewModels.TasksViewModel);
      this.mvvmContext1.ViewModelCreate += new DevExpress.Utils.MVVM.ViewModelCreateEventHandler(this.mvvmContext1_ViewModelCreate);
      // 
      // gridControl1
      // 
      this.gridControl1.DataMember = "Tasks";
      this.gridControl1.DataSource = this.tasksViewModelBindingSource;
      this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridControl1.Location = new System.Drawing.Point(0, 0);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new System.Drawing.Size(515, 321);
      this.gridControl1.TabIndex = 0;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // tasksViewModelBindingSource
      // 
      this.tasksViewModelBindingSource.DataSource = typeof(sample_7_7.ViewModels.TasksViewModel);
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSubject,
            this.colDueDate,
            this.colDone});
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      // 
      // colSubject
      // 
      this.colSubject.FieldName = "Subject";
      this.colSubject.Name = "colSubject";
      this.colSubject.Visible = true;
      this.colSubject.VisibleIndex = 0;
      // 
      // colDueDate
      // 
      this.colDueDate.FieldName = "DueDate";
      this.colDueDate.Name = "colDueDate";
      this.colDueDate.Visible = true;
      this.colDueDate.VisibleIndex = 1;
      // 
      // colDone
      // 
      this.colDone.FieldName = "Done";
      this.colDone.Name = "colDone";
      this.colDone.Visible = true;
      this.colDone.VisibleIndex = 2;
      // 
      // TasksView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridControl1);
      this.Name = "TasksView";
      this.Size = new System.Drawing.Size(515, 321);
      this.Load += new System.EventHandler(this.TasksView_Load);
      ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tasksViewModelBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      this.ResumeLayout(false);

    }
    #endregion

    private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private System.Windows.Forms.BindingSource tasksViewModelBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colSubject;
    private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
    private DevExpress.XtraGrid.Columns.GridColumn colDone;
  }
}
