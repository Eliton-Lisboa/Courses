namespace QuartoProjetoSQL___ControleConsultorio
{
    partial class frmPacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            System.Windows.Forms.Label iD_PACIENTELabel;
            System.Windows.Forms.Label nOME_PACIENTELabel;
            System.Windows.Forms.Label eNDERECOLabel;
            System.Windows.Forms.Label nUMEROLabel;
            System.Windows.Forms.Label bAIRROLabel;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label sEXOLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label cELULARLabel;
            this.consultorioDataSet = new QuartoProjetoSQL___ControleConsultorio.ConsultorioDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.eNDERECOTextBox = new System.Windows.Forms.TextBox();
            this.nUMEROTextBox = new System.Windows.Forms.TextBox();
            this.bAIRROTextBox = new System.Windows.Forms.TextBox();
            this.cIDADETextBox = new System.Windows.Forms.TextBox();
            this.cEPMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.sEXOComboBox = new System.Windows.Forms.ComboBox();
            this.tELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cELULARMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nOME_PACIENTETextBox = new System.Windows.Forms.TextBox();
            this.pacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_PACIENTELabel = new System.Windows.Forms.Label();
            nOME_PACIENTELabel = new System.Windows.Forms.Label();
            eNDERECOLabel = new System.Windows.Forms.Label();
            nUMEROLabel = new System.Windows.Forms.Label();
            bAIRROLabel = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            sEXOLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            cELULARLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // consultorioDataSet
            // 
            this.consultorioDataSet.DataSetName = "ConsultorioDataSet1";
            this.consultorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.consultorioDataSet;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacienteBindingNavigatorSaveItem});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(450, 25);
            this.pacienteBindingNavigator.TabIndex = 0;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacienteBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // iD_PACIENTELabel
            // 
            iD_PACIENTELabel.AutoSize = true;
            iD_PACIENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_PACIENTELabel.Location = new System.Drawing.Point(12, 64);
            iD_PACIENTELabel.Name = "iD_PACIENTELabel";
            iD_PACIENTELabel.Size = new System.Drawing.Size(67, 18);
            iD_PACIENTELabel.TabIndex = 1;
            iD_PACIENTELabel.Text = "Código:";
            // 
            // iD_PACIENTETextBox
            // 
            this.iD_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "ID_PACIENTE", true));
            this.iD_PACIENTETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iD_PACIENTETextBox.Location = new System.Drawing.Point(85, 58);
            this.iD_PACIENTETextBox.Name = "iD_PACIENTETextBox";
            this.iD_PACIENTETextBox.ReadOnly = true;
            this.iD_PACIENTETextBox.Size = new System.Drawing.Size(121, 24);
            this.iD_PACIENTETextBox.TabIndex = 2;
            // 
            // nOME_PACIENTELabel
            // 
            nOME_PACIENTELabel.AutoSize = true;
            nOME_PACIENTELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_PACIENTELabel.Location = new System.Drawing.Point(21, 94);
            nOME_PACIENTELabel.Name = "nOME_PACIENTELabel";
            nOME_PACIENTELabel.Size = new System.Drawing.Size(58, 18);
            nOME_PACIENTELabel.TabIndex = 3;
            nOME_PACIENTELabel.Text = "Nome:";
            // 
            // eNDERECOLabel
            // 
            eNDERECOLabel.AutoSize = true;
            eNDERECOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eNDERECOLabel.Location = new System.Drawing.Point(-6, 124);
            eNDERECOLabel.Name = "eNDERECOLabel";
            eNDERECOLabel.Size = new System.Drawing.Size(85, 18);
            eNDERECOLabel.TabIndex = 5;
            eNDERECOLabel.Text = "Endereço:";
            // 
            // eNDERECOTextBox
            // 
            this.eNDERECOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "ENDERECO", true));
            this.eNDERECOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNDERECOTextBox.Location = new System.Drawing.Point(85, 118);
            this.eNDERECOTextBox.Name = "eNDERECOTextBox";
            this.eNDERECOTextBox.Size = new System.Drawing.Size(353, 24);
            this.eNDERECOTextBox.TabIndex = 6;
            // 
            // nUMEROLabel
            // 
            nUMEROLabel.AutoSize = true;
            nUMEROLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nUMEROLabel.Location = new System.Drawing.Point(6, 154);
            nUMEROLabel.Name = "nUMEROLabel";
            nUMEROLabel.Size = new System.Drawing.Size(73, 18);
            nUMEROLabel.TabIndex = 7;
            nUMEROLabel.Text = "Número:";
            // 
            // nUMEROTextBox
            // 
            this.nUMEROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NUMERO", true));
            this.nUMEROTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUMEROTextBox.Location = new System.Drawing.Point(85, 148);
            this.nUMEROTextBox.Name = "nUMEROTextBox";
            this.nUMEROTextBox.Size = new System.Drawing.Size(121, 24);
            this.nUMEROTextBox.TabIndex = 8;
            // 
            // bAIRROLabel
            // 
            bAIRROLabel.AutoSize = true;
            bAIRROLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bAIRROLabel.Location = new System.Drawing.Point(227, 154);
            bAIRROLabel.Name = "bAIRROLabel";
            bAIRROLabel.Size = new System.Drawing.Size(59, 18);
            bAIRROLabel.TabIndex = 9;
            bAIRROLabel.Text = "Bairro:";
            // 
            // bAIRROTextBox
            // 
            this.bAIRROTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "BAIRRO", true));
            this.bAIRROTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAIRROTextBox.Location = new System.Drawing.Point(292, 148);
            this.bAIRROTextBox.Name = "bAIRROTextBox";
            this.bAIRROTextBox.Size = new System.Drawing.Size(146, 24);
            this.bAIRROTextBox.TabIndex = 10;
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cIDADELabel.Location = new System.Drawing.Point(14, 184);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(65, 18);
            cIDADELabel.TabIndex = 11;
            cIDADELabel.Text = "Cidade:";
            // 
            // cIDADETextBox
            // 
            this.cIDADETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CIDADE", true));
            this.cIDADETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cIDADETextBox.Location = new System.Drawing.Point(85, 178);
            this.cIDADETextBox.Name = "cIDADETextBox";
            this.cIDADETextBox.Size = new System.Drawing.Size(217, 24);
            this.cIDADETextBox.TabIndex = 12;
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cEPLabel.Location = new System.Drawing.Point(316, 184);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(47, 18);
            cEPLabel.TabIndex = 13;
            cEPLabel.Text = "CEP:";
            // 
            // cEPMaskedTextBox
            // 
            this.cEPMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CEP", true));
            this.cEPMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cEPMaskedTextBox.Location = new System.Drawing.Point(369, 178);
            this.cEPMaskedTextBox.Mask = "00000-999";
            this.cEPMaskedTextBox.Name = "cEPMaskedTextBox";
            this.cEPMaskedTextBox.Size = new System.Drawing.Size(69, 24);
            this.cEPMaskedTextBox.TabIndex = 14;
            // 
            // sEXOLabel
            // 
            sEXOLabel.AutoSize = true;
            sEXOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sEXOLabel.Location = new System.Drawing.Point(308, 61);
            sEXOLabel.Name = "sEXOLabel";
            sEXOLabel.Size = new System.Drawing.Size(51, 18);
            sEXOLabel.TabIndex = 15;
            sEXOLabel.Text = "Sexo:";
            // 
            // sEXOComboBox
            // 
            this.sEXOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "SEXO", true));
            this.sEXOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sEXOComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sEXOComboBox.FormattingEnabled = true;
            this.sEXOComboBox.Items.AddRange(new object[] {
            "",
            "F",
            "M"});
            this.sEXOComboBox.Location = new System.Drawing.Point(365, 56);
            this.sEXOComboBox.Name = "sEXOComboBox";
            this.sEXOComboBox.Size = new System.Drawing.Size(73, 26);
            this.sEXOComboBox.TabIndex = 16;
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONELabel.Location = new System.Drawing.Point(1, 214);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(78, 18);
            tELEFONELabel.TabIndex = 17;
            tELEFONELabel.Text = "Telefone:";
            // 
            // tELEFONEMaskedTextBox
            // 
            this.tELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "TELEFONE", true));
            this.tELEFONEMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tELEFONEMaskedTextBox.Location = new System.Drawing.Point(85, 208);
            this.tELEFONEMaskedTextBox.Mask = "(99) 0000-0000";
            this.tELEFONEMaskedTextBox.Name = "tELEFONEMaskedTextBox";
            this.tELEFONEMaskedTextBox.Size = new System.Drawing.Size(164, 24);
            this.tELEFONEMaskedTextBox.TabIndex = 18;
            // 
            // cELULARLabel
            // 
            cELULARLabel.AutoSize = true;
            cELULARLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cELULARLabel.Location = new System.Drawing.Point(259, 214);
            cELULARLabel.Name = "cELULARLabel";
            cELULARLabel.Size = new System.Drawing.Size(66, 18);
            cELULARLabel.TabIndex = 19;
            cELULARLabel.Text = "Celular:";
            // 
            // cELULARMaskedTextBox
            // 
            this.cELULARMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CELULAR", true));
            this.cELULARMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cELULARMaskedTextBox.Location = new System.Drawing.Point(331, 208);
            this.cELULARMaskedTextBox.Mask = "(99) 0000-0000";
            this.cELULARMaskedTextBox.Name = "cELULARMaskedTextBox";
            this.cELULARMaskedTextBox.Size = new System.Drawing.Size(107, 24);
            this.cELULARMaskedTextBox.TabIndex = 20;
            // 
            // nOME_PACIENTETextBox
            // 
            this.nOME_PACIENTETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NOME_PACIENTE", true));
            this.nOME_PACIENTETextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_PACIENTETextBox.Location = new System.Drawing.Point(85, 88);
            this.nOME_PACIENTETextBox.Name = "nOME_PACIENTETextBox";
            this.nOME_PACIENTETextBox.Size = new System.Drawing.Size(353, 24);
            this.nOME_PACIENTETextBox.TabIndex = 21;
            // 
            // pacienteDataGridView
            // 
            this.pacienteDataGridView.AllowUserToAddRows = false;
            this.pacienteDataGridView.AllowUserToDeleteRows = false;
            this.pacienteDataGridView.AllowUserToResizeColumns = false;
            this.pacienteDataGridView.AllowUserToResizeRows = false;
            this.pacienteDataGridView.AutoGenerateColumns = false;
            this.pacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.pacienteDataGridView.DataSource = this.pacienteBindingSource;
            this.pacienteDataGridView.Location = new System.Drawing.Point(12, 238);
            this.pacienteDataGridView.Name = "pacienteDataGridView";
            this.pacienteDataGridView.ReadOnly = true;
            this.pacienteDataGridView.RowHeadersVisible = false;
            this.pacienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pacienteDataGridView.Size = new System.Drawing.Size(426, 319);
            this.pacienteDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PACIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PACIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 190;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ENDERECO";
            this.dataGridViewTextBoxColumn3.HeaderText = "ENDERECO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NUMERO";
            this.dataGridViewTextBoxColumn4.HeaderText = "NUMERO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BAIRRO";
            this.dataGridViewTextBoxColumn5.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CIDADE";
            this.dataGridViewTextBoxColumn6.HeaderText = "CIDADE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn7.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SEXO";
            this.dataGridViewTextBoxColumn8.HeaderText = "SEXO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn9.HeaderText = "Fone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 92;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CELULAR";
            this.dataGridViewTextBoxColumn10.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 90;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 571);
            this.Controls.Add(this.pacienteDataGridView);
            this.Controls.Add(this.nOME_PACIENTETextBox);
            this.Controls.Add(iD_PACIENTELabel);
            this.Controls.Add(this.iD_PACIENTETextBox);
            this.Controls.Add(nOME_PACIENTELabel);
            this.Controls.Add(eNDERECOLabel);
            this.Controls.Add(this.eNDERECOTextBox);
            this.Controls.Add(nUMEROLabel);
            this.Controls.Add(this.nUMEROTextBox);
            this.Controls.Add(bAIRROLabel);
            this.Controls.Add(this.bAIRROTextBox);
            this.Controls.Add(cIDADELabel);
            this.Controls.Add(this.cIDADETextBox);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.cEPMaskedTextBox);
            this.Controls.Add(sEXOLabel);
            this.Controls.Add(this.sEXOComboBox);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.tELEFONEMaskedTextBox);
            this.Controls.Add(cELULARLabel);
            this.Controls.Add(this.cELULARMaskedTextBox);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            ((System.ComponentModel.ISupportInitialize)(this.consultorioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ConsultorioDataSet consultorioDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_PACIENTETextBox;
        private System.Windows.Forms.TextBox eNDERECOTextBox;
        private System.Windows.Forms.TextBox nUMEROTextBox;
        private System.Windows.Forms.TextBox bAIRROTextBox;
        private System.Windows.Forms.TextBox cIDADETextBox;
        private System.Windows.Forms.MaskedTextBox cEPMaskedTextBox;
        private System.Windows.Forms.ComboBox sEXOComboBox;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cELULARMaskedTextBox;
        private System.Windows.Forms.TextBox nOME_PACIENTETextBox;
        private System.Windows.Forms.DataGridView pacienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}