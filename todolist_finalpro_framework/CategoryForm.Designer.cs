
namespace todolist_finalpro_framework
{
    partial class CategoryForm
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
            this.gridCategory = new System.Windows.Forms.DataGridView();
            this.columnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBoxAdd = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).BeginInit();
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
            // gridCategory
            // 
            this.gridCategory.AllowUserToAddRows = false;
            this.gridCategory.AllowUserToDeleteRows = false;
            this.gridCategory.AllowUserToResizeColumns = false;
            this.gridCategory.AllowUserToResizeRows = false;
            this.gridCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.gridCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCategory,
            this.columnID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCategory.GridColor = System.Drawing.Color.White;
            this.gridCategory.Location = new System.Drawing.Point(12, 85);
            this.gridCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridCategory.Name = "gridCategory";
            this.gridCategory.ReadOnly = true;
            this.gridCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridCategory.RowHeadersVisible = false;
            this.gridCategory.RowHeadersWidth = 62;
            this.gridCategory.RowTemplate.Height = 28;
            this.gridCategory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridCategory.Size = new System.Drawing.Size(776, 451);
            this.gridCategory.TabIndex = 2;
            // 
            // columnCategory
            // 
            this.columnCategory.HeaderText = "Category";
            this.columnCategory.MinimumWidth = 8;
            this.columnCategory.Name = "columnCategory";
            this.columnCategory.ReadOnly = true;
            this.columnCategory.Width = 150;
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(421, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Palette = this.formPalette;
            this.btnAdd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnAdd.Size = new System.Drawing.Size(176, 51);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Values.Text = "Add Category";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(612, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Palette = this.formPalette;
            this.btnDelete.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btnDelete.Size = new System.Drawing.Size(176, 51);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Values.Text = "Delete Selected?";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(12, 31);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(386, 31);
            this.textBoxAdd.TabIndex = 5;
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(14)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.textBoxAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridCategory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CategoryForm";
            this.Palette = this.formPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.Text = "Manage Category";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette formPalette;
        private System.Windows.Forms.DataGridView gridCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxAdd;
    }
}