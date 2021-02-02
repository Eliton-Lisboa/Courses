namespace SegundoProjetoSQL___Controle_de_alunos
{
    partial class frmControleDeAlunos
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
            System.Windows.Forms.Label iD_ALUNOLabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label eMAILLabel;
            System.Windows.Forms.Label cURSOLabel;
            System.Windows.Forms.Label nASCIMENTOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDeAlunos));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.alunosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.alunosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_ALUNOTextBox = new System.Windows.Forms.TextBox();
            this.nOMETextBox = new System.Windows.Forms.TextBox();
            this.tELEFONEMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.eMAILTextBox = new System.Windows.Forms.TextBox();
            this.cURSOTextBox = new System.Windows.Forms.TextBox();
            this.nASCIMENTODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.alunosDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.rbCurso = new System.Windows.Forms.RadioButton();
            this.dtgPesquisas = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NASCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escolaDataSet = new SegundoProjetoSQL___Controle_de_alunos.EscolaDataSet();
            this.alunosTableAdapter = new SegundoProjetoSQL___Controle_de_alunos.EscolaDataSetTableAdapters.AlunosTableAdapter();
            this.tableAdapterManager = new SegundoProjetoSQL___Controle_de_alunos.EscolaDataSetTableAdapters.TableAdapterManager();
            iD_ALUNOLabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            eMAILLabel = new System.Windows.Forms.Label();
            cURSOLabel = new System.Windows.Forms.Label();
            nASCIMENTOLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).BeginInit();
            this.alunosBindingNavigator.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_ALUNOLabel
            // 
            iD_ALUNOLabel.AutoSize = true;
            iD_ALUNOLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iD_ALUNOLabel.Location = new System.Drawing.Point(14, 53);
            iD_ALUNOLabel.Name = "iD_ALUNOLabel";
            iD_ALUNOLabel.Size = new System.Drawing.Size(65, 19);
            iD_ALUNOLabel.TabIndex = 0;
            iD_ALUNOLabel.Text = "Código:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOMELabel.Location = new System.Drawing.Point(14, 89);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(57, 19);
            nOMELabel.TabIndex = 2;
            nOMELabel.Text = "Nome:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tELEFONELabel.Location = new System.Drawing.Point(14, 125);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(76, 19);
            tELEFONELabel.TabIndex = 4;
            tELEFONELabel.Text = "Telefone:";
            // 
            // eMAILLabel
            // 
            eMAILLabel.AutoSize = true;
            eMAILLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMAILLabel.Location = new System.Drawing.Point(14, 161);
            eMAILLabel.Name = "eMAILLabel";
            eMAILLabel.Size = new System.Drawing.Size(54, 19);
            eMAILLabel.TabIndex = 6;
            eMAILLabel.Text = "Email:";
            // 
            // cURSOLabel
            // 
            cURSOLabel.AutoSize = true;
            cURSOLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cURSOLabel.Location = new System.Drawing.Point(14, 197);
            cURSOLabel.Name = "cURSOLabel";
            cURSOLabel.Size = new System.Drawing.Size(56, 19);
            cURSOLabel.TabIndex = 8;
            cURSOLabel.Text = "Curso:";
            // 
            // nASCIMENTOLabel
            // 
            nASCIMENTOLabel.AutoSize = true;
            nASCIMENTOLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nASCIMENTOLabel.Location = new System.Drawing.Point(14, 234);
            nASCIMENTOLabel.Name = "nASCIMENTOLabel";
            nASCIMENTOLabel.Size = new System.Drawing.Size(97, 19);
            nASCIMENTOLabel.TabIndex = 10;
            nASCIMENTOLabel.Text = "Nascimento:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(476, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.alunosDataGridView);
            this.tabPage1.Controls.Add(this.alunosBindingNavigator);
            this.tabPage1.Controls.Add(iD_ALUNOLabel);
            this.tabPage1.Controls.Add(this.iD_ALUNOTextBox);
            this.tabPage1.Controls.Add(nOMELabel);
            this.tabPage1.Controls.Add(this.nOMETextBox);
            this.tabPage1.Controls.Add(tELEFONELabel);
            this.tabPage1.Controls.Add(this.tELEFONEMaskedTextBox);
            this.tabPage1.Controls.Add(eMAILLabel);
            this.tabPage1.Controls.Add(this.eMAILTextBox);
            this.tabPage1.Controls.Add(cURSOLabel);
            this.tabPage1.Controls.Add(this.cURSOTextBox);
            this.tabPage1.Controls.Add(nASCIMENTOLabel);
            this.tabPage1.Controls.Add(this.nASCIMENTODateTimePicker);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(468, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // alunosBindingNavigator
            // 
            this.alunosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunosBindingNavigator.BindingSource = this.alunosBindingSource;
            this.alunosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alunosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.alunosBindingNavigatorSaveItem});
            this.alunosBindingNavigator.Location = new System.Drawing.Point(3, 3);
            this.alunosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alunosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alunosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunosBindingNavigator.Name = "alunosBindingNavigator";
            this.alunosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alunosBindingNavigator.Size = new System.Drawing.Size(462, 25);
            this.alunosBindingNavigator.TabIndex = 1;
            this.alunosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Text = "0";
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
            // alunosBindingNavigatorSaveItem
            // 
            this.alunosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosBindingNavigatorSaveItem.Image")));
            this.alunosBindingNavigatorSaveItem.Name = "alunosBindingNavigatorSaveItem";
            this.alunosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.alunosBindingNavigatorSaveItem.Text = "Save Data";
            this.alunosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunosBindingNavigatorSaveItem_Click);
            // 
            // iD_ALUNOTextBox
            // 
            this.iD_ALUNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "ID_ALUNO", true));
            this.iD_ALUNOTextBox.Enabled = false;
            this.iD_ALUNOTextBox.Location = new System.Drawing.Point(127, 50);
            this.iD_ALUNOTextBox.Name = "iD_ALUNOTextBox";
            this.iD_ALUNOTextBox.Size = new System.Drawing.Size(72, 30);
            this.iD_ALUNOTextBox.TabIndex = 1;
            // 
            // nOMETextBox
            // 
            this.nOMETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "NOME", true));
            this.nOMETextBox.Location = new System.Drawing.Point(127, 86);
            this.nOMETextBox.Name = "nOMETextBox";
            this.nOMETextBox.Size = new System.Drawing.Size(335, 30);
            this.nOMETextBox.TabIndex = 3;
            // 
            // tELEFONEMaskedTextBox
            // 
            this.tELEFONEMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "TELEFONE", true));
            this.tELEFONEMaskedTextBox.Location = new System.Drawing.Point(127, 122);
            this.tELEFONEMaskedTextBox.Name = "tELEFONEMaskedTextBox";
            this.tELEFONEMaskedTextBox.Size = new System.Drawing.Size(133, 30);
            this.tELEFONEMaskedTextBox.TabIndex = 5;
            // 
            // eMAILTextBox
            // 
            this.eMAILTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "EMAIL", true));
            this.eMAILTextBox.Location = new System.Drawing.Point(127, 158);
            this.eMAILTextBox.Name = "eMAILTextBox";
            this.eMAILTextBox.Size = new System.Drawing.Size(335, 30);
            this.eMAILTextBox.TabIndex = 7;
            // 
            // cURSOTextBox
            // 
            this.cURSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "CURSO", true));
            this.cURSOTextBox.Location = new System.Drawing.Point(127, 194);
            this.cURSOTextBox.Name = "cURSOTextBox";
            this.cURSOTextBox.Size = new System.Drawing.Size(335, 30);
            this.cURSOTextBox.TabIndex = 9;
            // 
            // nASCIMENTODateTimePicker
            // 
            this.nASCIMENTODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alunosBindingSource, "NASCIMENTO", true));
            this.nASCIMENTODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nASCIMENTODateTimePicker.Location = new System.Drawing.Point(127, 230);
            this.nASCIMENTODateTimePicker.Name = "nASCIMENTODateTimePicker";
            this.nASCIMENTODateTimePicker.Size = new System.Drawing.Size(133, 30);
            this.nASCIMENTODateTimePicker.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgPesquisas);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(468, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesquisas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // alunosDataGridView
            // 
            this.alunosDataGridView.AllowUserToAddRows = false;
            this.alunosDataGridView.AllowUserToDeleteRows = false;
            this.alunosDataGridView.AutoGenerateColumns = false;
            this.alunosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alunosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.alunosDataGridView.DataSource = this.alunosBindingSource;
            this.alunosDataGridView.Location = new System.Drawing.Point(3, 264);
            this.alunosDataGridView.Name = "alunosDataGridView";
            this.alunosDataGridView.ReadOnly = true;
            this.alunosDataGridView.RowHeadersVisible = false;
            this.alunosDataGridView.Size = new System.Drawing.Size(460, 314);
            this.alunosDataGridView.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCurso);
            this.panel1.Controls.Add(this.rbAluno);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txbPesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 53);
            this.panel1.TabIndex = 0;
            // 
            // txbPesquisa
            // 
            this.txbPesquisa.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPesquisa.Location = new System.Drawing.Point(17, 3);
            this.txbPesquisa.Name = "txbPesquisa";
            this.txbPesquisa.Size = new System.Drawing.Size(331, 21);
            this.txbPesquisa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(365, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbAluno
            // 
            this.rbAluno.AutoSize = true;
            this.rbAluno.Checked = true;
            this.rbAluno.Location = new System.Drawing.Point(17, 29);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(52, 17);
            this.rbAluno.TabIndex = 2;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = true;
            // 
            // rbCurso
            // 
            this.rbCurso.AutoSize = true;
            this.rbCurso.Location = new System.Drawing.Point(75, 29);
            this.rbCurso.Name = "rbCurso";
            this.rbCurso.Size = new System.Drawing.Size(52, 17);
            this.rbCurso.TabIndex = 2;
            this.rbCurso.TabStop = true;
            this.rbCurso.Text = "Curso";
            this.rbCurso.UseVisualStyleBackColor = true;
            // 
            // dtgPesquisas
            // 
            this.dtgPesquisas.AllowUserToAddRows = false;
            this.dtgPesquisas.AllowUserToDeleteRows = false;
            this.dtgPesquisas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.ALUNO,
            this.TELEFONE,
            this.EMAIL,
            this.CURSO,
            this.NASCIMENTO});
            this.dtgPesquisas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPesquisas.Location = new System.Drawing.Point(3, 56);
            this.dtgPesquisas.Name = "dtgPesquisas";
            this.dtgPesquisas.ReadOnly = true;
            this.dtgPesquisas.RowHeadersVisible = false;
            this.dtgPesquisas.Size = new System.Drawing.Size(462, 527);
            this.dtgPesquisas.TabIndex = 1;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "ID_ALUNO";
            this.CODIGO.HeaderText = "Código";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // ALUNO
            // 
            this.ALUNO.DataPropertyName = "NOME";
            this.ALUNO.HeaderText = "Aluno";
            this.ALUNO.Name = "ALUNO";
            this.ALUNO.ReadOnly = true;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "TELEFONE";
            this.TELEFONE.HeaderText = "Telefone";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "E-mail";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Visible = false;
            // 
            // CURSO
            // 
            this.CURSO.DataPropertyName = "CURSO";
            this.CURSO.HeaderText = "Curso";
            this.CURSO.Name = "CURSO";
            this.CURSO.ReadOnly = true;
            // 
            // NASCIMENTO
            // 
            this.NASCIMENTO.DataPropertyName = "NASCIMENTO";
            this.NASCIMENTO.HeaderText = "Nascimento";
            this.NASCIMENTO.Name = "NASCIMENTO";
            this.NASCIMENTO.ReadOnly = true;
            this.NASCIMENTO.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ALUNO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TELEFONE";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 140;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EMAIL";
            this.dataGridViewTextBoxColumn4.HeaderText = "EMAIL";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CURSO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Curso";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 97;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NASCIMENTO";
            this.dataGridViewTextBoxColumn6.HeaderText = "NASCIMENTO";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.escolaDataSet;
            // 
            // escolaDataSet
            // 
            this.escolaDataSet.DataSetName = "EscolaDataSet";
            this.escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = SegundoProjetoSQL___Controle_de_alunos.EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmControleDeAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 612);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControleDeAlunos";
            this.Text = "Controle de Alunos";
            this.Load += new System.EventHandler(this.frmControleDeAlunos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).EndInit();
            this.alunosBindingNavigator.ResumeLayout(false);
            this.alunosBindingNavigator.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alunosDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private EscolaDataSet escolaDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private EscolaDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private EscolaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alunosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton alunosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_ALUNOTextBox;
        private System.Windows.Forms.TextBox nOMETextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONEMaskedTextBox;
        private System.Windows.Forms.TextBox eMAILTextBox;
        private System.Windows.Forms.TextBox cURSOTextBox;
        private System.Windows.Forms.DateTimePicker nASCIMENTODateTimePicker;
        private System.Windows.Forms.DataGridView alunosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridView dtgPesquisas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALUNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NASCIMENTO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCurso;
        private System.Windows.Forms.RadioButton rbAluno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbPesquisa;
    }
}

