
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.monthCalendar = new ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar();
            this.gridToDo = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.grpAddTask = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAddTask = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnEnterTask = new System.Windows.Forms.Button();
            this.datePickerEnd = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.datePickerStart = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.txtAddTask = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuHeading2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuHeading3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.comboCategory = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnCompleted = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.columnDone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.columnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridToDo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAddTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAddTask.Panel)).BeginInit();
            this.grpAddTask.Panel.SuspendLayout();
            this.grpAddTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboAddTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // formPalette
            // 
            this.formPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
            this.formPalette.ButtonStyles.ButtonCommon.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.formPalette.ButtonStyles.ButtonCommon.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
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
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(29, 32);
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
            this.gridToDo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridToDo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridToDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDone,
            this.columnDescription,
            this.columnCategory,
            this.columnStartDate,
            this.columnEndDate,
            this.columnStatus,
            this.columnID});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridToDo.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridToDo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.gridToDo.Location = new System.Drawing.Point(428, 158);
            this.gridToDo.Name = "gridToDo";
            this.gridToDo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridToDo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridToDo.RowHeadersVisible = false;
            this.gridToDo.RowHeadersWidth = 62;
            this.gridToDo.RowTemplate.Height = 28;
            this.gridToDo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridToDo.Size = new System.Drawing.Size(1249, 504);
            this.gridToDo.TabIndex = 1;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1119, 89);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Palette = this.formPalette;
            this.btnAddNew.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAddNew.Size = new System.Drawing.Size(191, 43);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.TabStop = false;
            this.btnAddNew.Values.Text = "Add Task";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // grpAddTask
            // 
            this.grpAddTask.CaptionVisible = false;
            this.grpAddTask.Location = new System.Drawing.Point(393, 788);
            this.grpAddTask.Name = "grpAddTask";
            this.grpAddTask.Palette = this.formPalette;
            this.grpAddTask.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            // 
            // grpAddTask.Panel
            // 
            this.grpAddTask.Panel.Controls.Add(this.label4);
            this.grpAddTask.Panel.Controls.Add(this.label3);
            this.grpAddTask.Panel.Controls.Add(this.label2);
            this.grpAddTask.Panel.Controls.Add(this.label1);
            this.grpAddTask.Panel.Controls.Add(this.comboAddTask);
            this.grpAddTask.Panel.Controls.Add(this.btnEnterTask);
            this.grpAddTask.Panel.Controls.Add(this.datePickerEnd);
            this.grpAddTask.Panel.Controls.Add(this.datePickerStart);
            this.grpAddTask.Panel.Controls.Add(this.txtAddTask);
            this.grpAddTask.Size = new System.Drawing.Size(1136, 119);
            this.grpAddTask.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(733, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(471, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start Date";
            // 
            // comboAddTask
            // 
            this.comboAddTask.DropDownWidth = 158;
            this.comboAddTask.Location = new System.Drawing.Point(301, 59);
            this.comboAddTask.Name = "comboAddTask";
            this.comboAddTask.Palette = this.formPalette;
            this.comboAddTask.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.comboAddTask.Size = new System.Drawing.Size(158, 29);
            this.comboAddTask.TabIndex = 5;
            // 
            // btnEnterTask
            // 
            this.btnEnterTask.Location = new System.Drawing.Point(1019, 47);
            this.btnEnterTask.Name = "btnEnterTask";
            this.btnEnterTask.Size = new System.Drawing.Size(98, 42);
            this.btnEnterTask.TabIndex = 5;
            this.btnEnterTask.Text = "Add";
            this.btnEnterTask.UseVisualStyleBackColor = true;
            this.btnEnterTask.Click += new System.EventHandler(this.btnEnterTask_Click);
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Location = new System.Drawing.Point(738, 59);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Palette = this.formPalette;
            this.datePickerEnd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.datePickerEnd.Size = new System.Drawing.Size(264, 30);
            this.datePickerEnd.TabIndex = 3;
            // 
            // datePickerStart
            // 
            this.datePickerStart.Location = new System.Drawing.Point(476, 59);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Palette = this.formPalette;
            this.datePickerStart.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.datePickerStart.Size = new System.Drawing.Size(256, 30);
            this.datePickerStart.TabIndex = 2;
            // 
            // txtAddTask
            // 
            this.txtAddTask.Location = new System.Drawing.Point(16, 59);
            this.txtAddTask.Name = "txtAddTask";
            this.txtAddTask.Palette = this.formPalette;
            this.txtAddTask.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.txtAddTask.Size = new System.Drawing.Size(269, 31);
            this.txtAddTask.TabIndex = 0;
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
            this.comboCategory.Location = new System.Drawing.Point(428, 89);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(244, 29);
            this.comboCategory.TabIndex = 5;
            this.comboCategory.Text = "Choose Category";
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(1338, 89);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Palette = this.formPalette;
            this.btnCompleted.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnCompleted.Size = new System.Drawing.Size(191, 43);
            this.btnCompleted.TabIndex = 6;
            this.btnCompleted.TabStop = false;
            this.btnCompleted.Values.Text = "Mark As Complete";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // columnDone
            // 
            this.columnDone.FalseValue = "";
            this.columnDone.HeaderText = "";
            this.columnDone.MinimumWidth = 8;
            this.columnDone.Name = "columnDone";
            this.columnDone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnDone.TrueValue = "";
            this.columnDone.Width = 150;
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
            this.columnCategory.Width = 150;
            // 
            // columnStartDate
            // 
            this.columnStartDate.HeaderText = "Start Date";
            this.columnStartDate.MinimumWidth = 8;
            this.columnStartDate.Name = "columnStartDate";
            this.columnStartDate.Width = 150;
            // 
            // columnEndDate
            // 
            this.columnEndDate.HeaderText = "End Date";
            this.columnEndDate.MinimumWidth = 8;
            this.columnEndDate.Name = "columnEndDate";
            this.columnEndDate.Width = 150;
            // 
            // columnStatus
            // 
            this.columnStatus.HeaderText = "Status";
            this.columnStatus.MinimumWidth = 8;
            this.columnStatus.Name = "columnStatus";
            this.columnStatus.ReadOnly = true;
            this.columnStatus.Width = 150;
            // 
            // columnID
            // 
            this.columnID.HeaderText = "ID";
            this.columnID.MinimumWidth = 8;
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.Visible = false;
            this.columnID.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1815, 1003);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.grpAddTask);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.gridToDo);
            this.Controls.Add(this.monthCalendar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Palette = this.formPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridToDo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpAddTask.Panel)).EndInit();
            this.grpAddTask.Panel.ResumeLayout(false);
            this.grpAddTask.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpAddTask)).EndInit();
            this.grpAddTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboAddTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette formPalette;
        private ComponentFactory.Krypton.Toolkit.KryptonMonthCalendar monthCalendar;
        private System.Windows.Forms.DataGridView gridToDo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAddNew;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grpAddTask;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datePickerEnd;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker datePickerStart;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddTask;
        private System.Windows.Forms.Button btnEnterTask;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboAddTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox comboCategory;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCompleted;
        private System.Windows.Forms.DataGridViewCheckBoxColumn columnDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
    }
}

