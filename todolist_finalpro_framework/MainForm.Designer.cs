
namespace todolist_finalpro_framework
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.monthCalendar = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.gridToDo = new System.Windows.Forms.DataGridView();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuHeading2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuHeading3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.comboCategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnAll = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnPending = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInProgress = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnCompleted = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.datePickerEnd = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnEnterTask = new System.Windows.Forms.Button();
            this.comboAddTask = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.txtAddTask = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.groupBoxNewTask = new System.Windows.Forms.GroupBox();
            this.comboProfile = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.buttonCategory = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.buttonPomodoro = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.columnPriority = new System.Windows.Forms.DataGridViewButtonColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDayLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboAddTask)).BeginInit();
            this.groupBoxNewTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // formPalette
            // 
            this.formPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.formPalette.ButtonStyles.ButtonCommon.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.ButtonStyles.ButtonCommon.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.ButtonStyles.ButtonCommon.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonCommon.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonCommon.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.Color1 = System.Drawing.Color.Black;
            this.formPalette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.Color2 = System.Drawing.Color.Black;
            this.formPalette.ButtonStyles.ButtonCommon.StateCheckedTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formPalette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formPalette.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.formPalette.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formPalette.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.formPalette.ButtonStyles.ButtonForm.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formPalette.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.formPalette.ButtonStyles.ButtonForm.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.ButtonStyles.ButtonForm.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.CalendarDay.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.CalendarDay.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.CalendarDay.OverrideToday.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.CalendarDay.OverrideToday.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.CalendarDay.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.CalendarDay.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.CalendarDay.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.CalendarDay.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.CalendarDay.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.CalendarDay.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.CalendarDay.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.CalendarDay.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.CalendarDay.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.CalendarDay.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.CalendarDay.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.CalendarDay.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.Common.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.Common.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.Common.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.Common.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.Common.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.Common.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.Common.StateDisabled.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.formPalette.Common.StateDisabled.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.formPalette.FormStyles.FormCommon.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.FormStyles.FormCommon.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.formPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.formPalette.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.formPalette.GridStyles.GridCommon.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.formPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.formPalette.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.GridStyles.GridCommon.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.GridStyles.GridCommon.StateSelected.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.formPalette.GridStyles.GridCommon.StateSelected.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.formPalette.GridStyles.GridCommon.StateSelected.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.GridStyles.GridCommon.StateSelected.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.HeaderStyles.HeaderCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.HeaderStyles.HeaderCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.HeaderStyles.HeaderCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.formPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            this.formPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.formPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.formPalette.Images.RadioButton.CheckedPressed = global::todolist_finalpro_framework.Properties.Resources.Screenshot_2021_12_21_000557;
            this.formPalette.Images.RadioButton.Common = global::todolist_finalpro_framework.Properties.Resources.Screenshot_2021_12_21_000355;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(24, 26);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.Palette = this.formPalette;
            this.monthCalendar.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.monthCalendar.SelectionEnd = new System.DateTime(2021, 12, 19, 0, 0, 0, 0);
            this.monthCalendar.SelectionStart = new System.DateTime(2021, 12, 19, 0, 0, 0, 0);
            this.monthCalendar.Size = new System.Drawing.Size(349, 265);
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.TodayDate = new System.DateTime(2021, 12, 19, 0, 0, 0, 0);
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // gridToDo
            // 
            this.gridToDo.AllowUserToAddRows = false;
            this.gridToDo.AllowUserToDeleteRows = false;
            this.gridToDo.AllowUserToResizeColumns = false;
            this.gridToDo.AllowUserToResizeRows = false;
            this.gridToDo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.gridToDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridToDo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridToDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnPriority,
            this.columnDescription,
            this.columnCategory,
            this.columnEndDate,
            this.columnDayLeft,
            this.columnStatus,
            this.columnID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridToDo.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridToDo.GridColor = System.Drawing.Color.White;
            this.gridToDo.Location = new System.Drawing.Point(403, 70);
            this.gridToDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridToDo.Name = "gridToDo";
            this.gridToDo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridToDo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridToDo.RowHeadersVisible = false;
            this.gridToDo.RowHeadersWidth = 62;
            this.gridToDo.RowTemplate.Height = 28;
            this.gridToDo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridToDo.Size = new System.Drawing.Size(1131, 624);
            this.gridToDo.TabIndex = 1;
            this.gridToDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridToDo_CellClick);
            this.gridToDo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridToDo_CellEndEdit);
            // 
            // kryptonContextMenuHeading1
            // 
            this.kryptonContextMenuHeading1.ExtraText = "";
            // 
            // kryptonContextMenuHeading2
            // 
            this.kryptonContextMenuHeading2.ExtraText = "";
            // 
            // kryptonContextMenuHeading3
            // 
            this.kryptonContextMenuHeading3.ExtraText = "";
            // 
            // comboCategory
            // 
            this.comboCategory.DropDownWidth = 244;
            this.comboCategory.Location = new System.Drawing.Point(664, 26);
            this.comboCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Palette = this.formPalette;
            this.comboCategory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.comboCategory.Size = new System.Drawing.Size(244, 29);
            this.comboCategory.TabIndex = 5;
            this.comboCategory.Text = "Select Category";
            this.comboCategory.SelectedValueChanged += new System.EventHandler(this.comboCategory_SelectedValueChanged);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(24, 318);
            this.btnAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAll.Name = "btnAll";
            this.btnAll.Palette = this.formPalette;
            this.btnAll.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAll.Size = new System.Drawing.Size(346, 42);
            this.btnAll.TabIndex = 9;
            this.btnAll.TabStop = false;
            this.btnAll.Values.Text = "All Tasks";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnPending
            // 
            this.btnPending.Location = new System.Drawing.Point(24, 364);
            this.btnPending.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPending.Name = "btnPending";
            this.btnPending.Palette = this.formPalette;
            this.btnPending.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnPending.Size = new System.Drawing.Size(346, 42);
            this.btnPending.TabIndex = 10;
            this.btnPending.TabStop = false;
            this.btnPending.Values.Text = "Pending";
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnInProgress
            // 
            this.btnInProgress.Location = new System.Drawing.Point(24, 410);
            this.btnInProgress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInProgress.Name = "btnInProgress";
            this.btnInProgress.Palette = this.formPalette;
            this.btnInProgress.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnInProgress.Size = new System.Drawing.Size(346, 42);
            this.btnInProgress.TabIndex = 11;
            this.btnInProgress.TabStop = false;
            this.btnInProgress.Values.Text = "In Progress";
            this.btnInProgress.Click += new System.EventHandler(this.btnInProgress_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(24, 456);
            this.btnCompleted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Palette = this.formPalette;
            this.btnCompleted.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnCompleted.Size = new System.Drawing.Size(346, 42);
            this.btnCompleted.TabIndex = 12;
            this.btnCompleted.TabStop = false;
            this.btnCompleted.Values.Text = "Completed";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.CalendarTodayDate = new System.DateTime(2021, 12, 20, 0, 0, 0, 0);
            this.datePickerEnd.Location = new System.Drawing.Point(958, 59);
            this.datePickerEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Palette = this.formPalette;
            this.datePickerEnd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.datePickerEnd.Size = new System.Drawing.Size(302, 30);
            this.datePickerEnd.TabIndex = 3;
            // 
            // btnEnterTask
            // 
            this.btnEnterTask.Location = new System.Drawing.Point(1380, 48);
            this.btnEnterTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnterTask.Name = "btnEnterTask";
            this.btnEnterTask.Size = new System.Drawing.Size(98, 42);
            this.btnEnterTask.TabIndex = 5;
            this.btnEnterTask.Text = "Add";
            this.btnEnterTask.UseVisualStyleBackColor = true;
            this.btnEnterTask.Click += new System.EventHandler(this.btnEnterTask_Click);
            // 
            // comboAddTask
            // 
            this.comboAddTask.DropDownWidth = 158;
            this.comboAddTask.Location = new System.Drawing.Point(594, 60);
            this.comboAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboAddTask.Name = "comboAddTask";
            this.comboAddTask.Palette = this.formPalette;
            this.comboAddTask.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.comboAddTask.Size = new System.Drawing.Size(307, 29);
            this.comboAddTask.TabIndex = 5;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEndDate.ForeColor = System.Drawing.Color.White;
            this.labelEndDate.Location = new System.Drawing.Point(954, 21);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(93, 25);
            this.labelEndDate.TabIndex = 7;
            this.labelEndDate.Text = "End Date";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCat.ForeColor = System.Drawing.Color.White;
            this.labelCat.Location = new System.Drawing.Point(590, 22);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(92, 25);
            this.labelCat.TabIndex = 8;
            this.labelCat.Text = "Category";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDesc.ForeColor = System.Drawing.Color.White;
            this.labelDesc.Location = new System.Drawing.Point(9, 22);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(109, 25);
            this.labelDesc.TabIndex = 9;
            this.labelDesc.Text = "Description";
            // 
            // txtAddTask
            // 
            this.txtAddTask.Location = new System.Drawing.Point(14, 59);
            this.txtAddTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddTask.Name = "txtAddTask";
            this.txtAddTask.Palette = this.formPalette;
            this.txtAddTask.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtAddTask.Size = new System.Drawing.Size(504, 31);
            this.txtAddTask.TabIndex = 0;
            // 
            // groupBoxNewTask
            // 
            this.groupBoxNewTask.Controls.Add(this.labelDesc);
            this.groupBoxNewTask.Controls.Add(this.comboAddTask);
            this.groupBoxNewTask.Controls.Add(this.labelCat);
            this.groupBoxNewTask.Controls.Add(this.txtAddTask);
            this.groupBoxNewTask.Controls.Add(this.labelEndDate);
            this.groupBoxNewTask.Controls.Add(this.datePickerEnd);
            this.groupBoxNewTask.Controls.Add(this.btnEnterTask);
            this.groupBoxNewTask.Location = new System.Drawing.Point(24, 709);
            this.groupBoxNewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxNewTask.Name = "groupBoxNewTask";
            this.groupBoxNewTask.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxNewTask.Size = new System.Drawing.Size(1510, 110);
            this.groupBoxNewTask.TabIndex = 14;
            this.groupBoxNewTask.TabStop = false;
            // 
            // comboProfile
            // 
            this.comboProfile.DropDownWidth = 244;
            this.comboProfile.Location = new System.Drawing.Point(403, 26);
            this.comboProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProfile.Name = "comboProfile";
            this.comboProfile.Palette = this.formPalette;
            this.comboProfile.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.comboProfile.Size = new System.Drawing.Size(244, 29);
            this.comboProfile.TabIndex = 15;
            this.comboProfile.Text = "Select Profile";
            this.comboProfile.SelectedValueChanged += new System.EventHandler(this.comboProfile_SelectedValueChanged);
            // 
            // buttonCategory
            // 
            this.buttonCategory.Location = new System.Drawing.Point(1204, 15);
            this.buttonCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Palette = this.formPalette;
            this.buttonCategory.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonCategory.Size = new System.Drawing.Size(167, 44);
            this.buttonCategory.TabIndex = 16;
            this.buttonCategory.TabStop = false;
            this.buttonCategory.Values.Text = "Manage Category";
            this.buttonCategory.Click += new System.EventHandler(this.buttonCategory_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1377, 15);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Palette = this.formPalette;
            this.buttonDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonDelete.Size = new System.Drawing.Size(167, 44);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Values.Text = "Delete Selected?";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPomodoro
            // 
            this.buttonPomodoro.Location = new System.Drawing.Point(1031, 15);
            this.buttonPomodoro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPomodoro.Name = "buttonPomodoro";
            this.buttonPomodoro.Palette = this.formPalette;
            this.buttonPomodoro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.buttonPomodoro.Size = new System.Drawing.Size(167, 44);
            this.buttonPomodoro.TabIndex = 18;
            this.buttonPomodoro.TabStop = false;
            this.buttonPomodoro.Values.Text = "Pomodoro Timer";
            this.buttonPomodoro.Click += new System.EventHandler(this.buttonPomodoro_Click);
            // 
            // columnPriority
            // 
            this.columnPriority.HeaderText = "Priority";
            this.columnPriority.MinimumWidth = 8;
            this.columnPriority.Name = "columnPriority";
            this.columnPriority.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnPriority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnPriority.Width = 50;
            // 
            // columnDescription
            // 
            this.columnDescription.HeaderText = "Description";
            this.columnDescription.MinimumWidth = 8;
            this.columnDescription.Name = "columnDescription";
            this.columnDescription.Width = 150;
            // 
            // columnCategory
            // 
            this.columnCategory.HeaderText = "Category";
            this.columnCategory.MinimumWidth = 8;
            this.columnCategory.Name = "columnCategory";
            this.columnCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnCategory.Width = 150;
            // 
            // columnEndDate
            // 
            this.columnEndDate.HeaderText = "End Date";
            this.columnEndDate.MinimumWidth = 8;
            this.columnEndDate.Name = "columnEndDate";
            this.columnEndDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnEndDate.Width = 150;
            // 
            // columnDayLeft
            // 
            this.columnDayLeft.HeaderText = "Day(s) Left";
            this.columnDayLeft.MinimumWidth = 8;
            this.columnDayLeft.Name = "columnDayLeft";
            this.columnDayLeft.ReadOnly = true;
            this.columnDayLeft.Width = 150;
            // 
            // columnStatus
            // 
            this.columnStatus.HeaderText = "Status";
            this.columnStatus.MinimumWidth = 8;
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnStatus.Width = 150;
            // 
            // columnID
            // 
            this.columnID.HeaderText = "ID";
            this.columnID.MinimumWidth = 8;
            this.columnID.Name = "columnID";
            this.columnID.Visible = false;
            this.columnID.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1593, 830);
            this.Controls.Add(this.buttonPomodoro);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCategory);
            this.Controls.Add(this.comboProfile);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.groupBoxNewTask);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.btnPending);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.btnInProgress);
            this.Controls.Add(this.gridToDo);
            this.Controls.Add(this.monthCalendar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Palette = this.formPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "To-do list";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboAddTask)).EndInit();
            this.groupBoxNewTask.ResumeLayout(false);
            this.groupBoxNewTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette formPalette;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView gridToDo;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAll;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPending;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnInProgress;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCompleted;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datePickerEnd;
        private System.Windows.Forms.Button btnEnterTask;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboAddTask;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelCat;
        private System.Windows.Forms.Label labelDesc;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddTask;
        private System.Windows.Forms.GroupBox groupBoxNewTask;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboProfile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonPomodoro;
        private System.Windows.Forms.DataGridViewButtonColumn columnPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDayLeft;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
    }
}

