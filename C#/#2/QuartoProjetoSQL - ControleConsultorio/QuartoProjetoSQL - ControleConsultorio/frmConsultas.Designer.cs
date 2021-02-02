namespace QuartoProjetoSQL___ControleConsultorio
{
    partial class frmConsultas
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
            System.Windows.Forms.Label iD_CONSULTALabel;
            System.Windows.Forms.Label iD_MEDICOLabel;
            System.Windows.Forms.Label iD_PACIENTELabel;
            System.Windows.Forms.Label dATALabel;
            System.Windows.Forms.Label hORARIOLabel;
            System.Windows.Forms.Label rOTORNOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.consultorioDataSet = new QuartoProjetoSQL___ControleConsultorio.ConsultorioDataSet();
            this.consultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_CONSULTATextBox = new System.Windows.Forms.TextBox();
            this.consultaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iD_MEDICOComboBox = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iD_PACIENTEComboBox = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hORARIODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rOTORNOCheckBox = new System.Windows.Forms.CheckBox();
            iD_CONSULTALabel = new System.Windows.Forms.Label();
            iD_MEDICOLabel = new System.Windows.Forms.Label();
            iD_PACIENTELabel = new System.Windows.Forms.Label();
            dATALabel = new System.Windows.Forms.Label();
            hORARIOLabel = new System.Windows.Forms.Label();
            rOTORNOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).BeginInit();
            this.consultaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CONSULTALabel
            // 
            iD_CONSULTALabel.AutoSize = true;
            iD_CONSULTALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_CONSULTALabel.Location = new System.Drawing.Point(12, 51);
            iD_CONSULTALabel.Name = "iD_CONSULTALabel";
            iD_CONSULTALabel.Size = new System.Drawing.Size(67, 18);
            iD_CONSULTALabel.TabIndex = 1;
            iD_CONSULTALabel.Text = "Código:";
            // 
            // iD_MEDICOLabel
            // 
            iD_MEDICOLabel.AutoSize = true;
            iD_MEDICOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_MEDICOLabel.Location = new System.Drawing.Point(11, 83);
            iD_MEDICOLabel.Name = "iD_MEDICOLabel";
            iD_MEDICOLabel.Size = new System.Drawing.Size(68, 18);
            iD_MEDICOLabel.TabIndex = 3;
            iD_MEDICOLabel.Text = "Médico:";
            // 
            // iD_PACIENTELabel
            // 
            iD_PACIENTELabel.AutoSize = true;
            iD_PACIENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PACIENTELabel.Location = new System.Drawing.Point(1, 112);
            iD_PACIENTELabel.Name = "iD_PACIENTELabel";
            iD_PACIENTELabel.Size = new System.Drawing.Size(78, 18);
            iD_PACIENTELabel.TabIndex = 5;
            iD_PACIENTELabel.Text = "Paciente:";
            // 
            // dATALabel
            // 
            dATALabel.AutoSize = true;
            dATALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dATALabel.Location = new System.Drawing.Point(31, 142);
            dATALabel.Name = "dATALabel";
            dATALabel.Size = new System.Drawing.Size(48, 18);
            dATALabel.TabIndex = 7;
            dATALabel.Text = "Data:";
            // 
            // hORARIOLabel
            // 
            hORARIOLabel.AutoSize = true;
            hORARIOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hORARIOLabel.Location = new System.Drawing.Point(244, 142);
            hORARIOLabel.Name = "hORARIOLabel";
            hORARIOLabel.Size = new System.Drawing.Size(70, 18);
            hORARIOLabel.TabIndex = 9;
            hORARIOLabel.Text = "Horario:";
            // 
            // rOTORNOLabel
            // 
            rOTORNOLabel.AutoSize = true;
            rOTORNOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rOTORNOLabel.Location = new System.Drawing.Point(5, 168);
            rOTORNOLabel.Name = "rOTORNOLabel";
            rOTORNOLabel.Size = new System.Drawing.Size(74, 18);
            rOTORNOLabel.TabIndex = 11;
            rOTORNOLabel.Text = "Retorno:";
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultaBindingSource
            // 
            this.consultaBindingSource.DataSource = this.consultorioDataSet;
            this.consultaBindingSource.Position = 0;
            // 
            // consultaBindingNavigator
            // 
            this.consultaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultaBindingNavigator.BindingSource = this.consultaBindingSource;
            this.consultaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.consultaBindingNavigatorSaveItem});
            this.consultaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultaBindingNavigator.Name = "consultaBindingNavigator";
            this.consultaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultaBindingNavigator.Size = new System.Drawing.Size(441, 25);
            this.consultaBindingNavigator.TabIndex = 0;
            this.consultaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "1";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // consultaBindingNavigatorSaveItem
            // 
            this.consultaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaBindingNavigatorSaveItem.Image")));
            this.consultaBindingNavigatorSaveItem.Name = "consultaBindingNavigatorSaveItem";
            this.consultaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultaBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // iD_CONSULTATextBox
            // 
            this.iD_CONSULTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultaBindingSource1, "ID_CONSULTA", true));
            this.iD_CONSULTATextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_CONSULTATextBox.Location = new System.Drawing.Point(83, 45);
            this.iD_CONSULTATextBox.Name = "iD_CONSULTATextBox";
            this.iD_CONSULTATextBox.ReadOnly = true;
            this.iD_CONSULTATextBox.Size = new System.Drawing.Size(77, 24);
            this.iD_CONSULTATextBox.TabIndex = 2;
            // 
            // consultaBindingSource1
            // 
            this.consultaBindingSource1.DataMember = "Consulta";
            this.consultaBindingSource1.DataSource = this.consultorioDataSet;
            // 
            // iD_MEDICOComboBox
            // 
            this.iD_MEDICOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "NOME_MEDICO", true));
            this.iD_MEDICOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_MEDICOComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_MEDICOComboBox.FormattingEnabled = true;
            this.iD_MEDICOComboBox.Location = new System.Drawing.Point(83, 75);
            this.iD_MEDICOComboBox.Name = "iD_MEDICOComboBox";
            this.iD_MEDICOComboBox.Size = new System.Drawing.Size(346, 26);
            this.iD_MEDICOComboBox.TabIndex = 4;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.consultorioDataSet;
            // 
            // iD_PACIENTEComboBox
            // 
            this.iD_PACIENTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NOME_PACIENTE", true));
            this.iD_PACIENTEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iD_PACIENTEComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_PACIENTEComboBox.FormattingEnabled = true;
            this.iD_PACIENTEComboBox.Location = new System.Drawing.Point(83, 104);
            this.iD_PACIENTEComboBox.Name = "iD_PACIENTEComboBox";
            this.iD_PACIENTEComboBox.Size = new System.Drawing.Size(346, 26);
            this.iD_PACIENTEComboBox.TabIndex = 6;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultorioDataSet;
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource1, "DATA", true));
            this.dATADateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dATADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATADateTimePicker.Location = new System.Drawing.Point(83, 136);
            this.dATADateTimePicker.Name = "dATADateTimePicker";
            this.dATADateTimePicker.Size = new System.Drawing.Size(155, 22);
            this.dATADateTimePicker.TabIndex = 8;
            // 
            // hORARIODateTimePicker
            // 
            this.hORARIODateTimePicker.CustomFormat = "HH:mm";
            this.hORARIODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultaBindingSource1, "HORARIO", true));
            this.hORARIODateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hORARIODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hORARIODateTimePicker.Location = new System.Drawing.Point(320, 136);
            this.hORARIODateTimePicker.Name = "hORARIODateTimePicker";
            this.hORARIODateTimePicker.ShowUpDown = true;
            this.hORARIODateTimePicker.Size = new System.Drawing.Size(109, 22);
            this.hORARIODateTimePicker.TabIndex = 10;
            // 
            // rOTORNOCheckBox
            // 
            this.rOTORNOCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.consultaBindingSource1, "ROTORNO", true));
            this.rOTORNOCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rOTORNOCheckBox.Location = new System.Drawing.Point(83, 166);
            this.rOTORNOCheckBox.Name = "rOTORNOCheckBox";
            this.rOTORNOCheckBox.Size = new System.Drawing.Size(200, 24);
            this.rOTORNOCheckBox.TabIndex = 12;
            this.rOTORNOCheckBox.Text = "Sim";
            this.rOTORNOCheckBox.UseVisualStyleBackColor = true;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 227);
            this.Controls.Add(iD_CONSULTALabel);
            this.Controls.Add(this.iD_CONSULTATextBox);
            this.Controls.Add(iD_MEDICOLabel);
            this.Controls.Add(this.iD_MEDICOComboBox);
            this.Controls.Add(iD_PACIENTELabel);
            this.Controls.Add(this.iD_PACIENTEComboBox);
            this.Controls.Add(dATALabel);
            this.Controls.Add(this.dATADateTimePicker);
            this.Controls.Add(hORARIOLabel);
            this.Controls.Add(this.hORARIODateTimePicker);
            this.Controls.Add(rOTORNOLabel);
            this.Controls.Add(this.rOTORNOCheckBox);
            this.Controls.Add(this.consultaBindingNavigator);
            this.Name = "frmConsultas";
            this.Text = "frmConsultas";
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingNavigator)).EndInit();
            this.consultaBindingNavigator.ResumeLayout(false);
            this.consultaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource consultaBindingSource;
        private System.Windows.Forms.BindingNavigator consultaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton consultaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_CONSULTATextBox;
        private System.Windows.Forms.ComboBox iD_MEDICOComboBox;
        private System.Windows.Forms.ComboBox iD_PACIENTEComboBox;
        private System.Windows.Forms.DateTimePicker dATADateTimePicker;
        private System.Windows.Forms.DateTimePicker hORARIODateTimePicker;
        private System.Windows.Forms.CheckBox rOTORNOCheckBox;
        private System.Windows.Forms.BindingSource consultaBindingSource1;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
    }
}