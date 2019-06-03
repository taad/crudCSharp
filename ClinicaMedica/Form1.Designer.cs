namespace ClinicaMedica
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label rGLabel;
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label cRMLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label especialidadeLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label rGLabel1;
            System.Windows.Forms.Label cPFLabel1;
            System.Windows.Forms.Label endereçoLabel1;
            System.Windows.Forms.Label telefoneLabel1;
            System.Windows.Forms.Label emailLabel1;
            System.Windows.Forms.Label idLabel3;
            System.Windows.Forms.Label nomePacienteLabel1;
            System.Windows.Forms.Label nomeMedicoLabel1;
            System.Windows.Forms.Label dataConsultaLabel1;
            System.Windows.Forms.Label horarioConsultaLabel1;
            System.Windows.Forms.Label idLabel2;
            System.Windows.Forms.Label nomeLabel2;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label telefoneLabel2;
            System.Windows.Forms.Label emailLabel2;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Pacientes = new System.Windows.Forms.TabPage();
            this.Médicos = new System.Windows.Forms.TabPage();
            this.Convênios = new System.Windows.Forms.TabPage();
            this.Agenda = new System.Windows.Forms.TabPage();
            this.database1DataSet = new ClinicaMedica.Database1DataSet();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter = new ClinicaMedica.Database1DataSetTableAdapters.MedicosTableAdapter();
            this.tableAdapterManager = new ClinicaMedica.Database1DataSetTableAdapters.TableAdapterManager();
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
            this.medicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.medicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new ClinicaMedica.Database1DataSetTableAdapters.PacientesTableAdapter();
            this.database1DataSet1 = new ClinicaMedica.Database1DataSet1();
            this.medicosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.medicosTableAdapter1 = new ClinicaMedica.Database1DataSet1TableAdapters.MedicosTableAdapter();
            this.tableAdapterManager1 = new ClinicaMedica.Database1DataSet1TableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.cRMTextBox = new System.Windows.Forms.TextBox();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox = new System.Windows.Forms.TextBox();
            this.celularTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.especialidadeTextBox = new System.Windows.Forms.TextBox();
            this.pacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter1 = new ClinicaMedica.Database1DataSet1TableAdapters.PacientesTableAdapter();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.nomeTextBox1 = new System.Windows.Forms.TextBox();
            this.rGTextBox1 = new System.Windows.Forms.TextBox();
            this.cPFTextBox1 = new System.Windows.Forms.TextBox();
            this.endereçoTextBox1 = new System.Windows.Forms.TextBox();
            this.telefoneTextBox1 = new System.Windows.Forms.TextBox();
            this.emailTextBox1 = new System.Windows.Forms.TextBox();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter = new ClinicaMedica.Database1DataSet1TableAdapters.AgendaTableAdapter();
            this.idTextBox3 = new System.Windows.Forms.TextBox();
            this.nomePacienteTextBox1 = new System.Windows.Forms.TextBox();
            this.nomeMedicoTextBox1 = new System.Windows.Forms.TextBox();
            this.dataConsultaDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.horarioConsultaTextBox1 = new System.Windows.Forms.TextBox();
            this.conveniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conveniosTableAdapter = new ClinicaMedica.Database1DataSet1TableAdapters.ConveniosTableAdapter();
            this.idTextBox2 = new System.Windows.Forms.TextBox();
            this.nomeTextBox2 = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.cEPTextBox = new System.Windows.Forms.TextBox();
            this.telefoneTextBox2 = new System.Windows.Forms.TextBox();
            this.emailTextBox2 = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            cPFLabel = new System.Windows.Forms.Label();
            cRMLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            especialidadeLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            rGLabel1 = new System.Windows.Forms.Label();
            cPFLabel1 = new System.Windows.Forms.Label();
            endereçoLabel1 = new System.Windows.Forms.Label();
            telefoneLabel1 = new System.Windows.Forms.Label();
            emailLabel1 = new System.Windows.Forms.Label();
            idLabel3 = new System.Windows.Forms.Label();
            nomePacienteLabel1 = new System.Windows.Forms.Label();
            nomeMedicoLabel1 = new System.Windows.Forms.Label();
            dataConsultaLabel1 = new System.Windows.Forms.Label();
            horarioConsultaLabel1 = new System.Windows.Forms.Label();
            idLabel2 = new System.Windows.Forms.Label();
            nomeLabel2 = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            telefoneLabel2 = new System.Windows.Forms.Label();
            emailLabel2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Pacientes.SuspendLayout();
            this.Médicos.SuspendLayout();
            this.Convênios.SuspendLayout();
            this.Agenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).BeginInit();
            this.medicosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conveniosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Pacientes);
            this.tabControl1.Controls.Add(this.Médicos);
            this.tabControl1.Controls.Add(this.Convênios);
            this.tabControl1.Controls.Add(this.Agenda);
            this.tabControl1.Location = new System.Drawing.Point(29, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // Pacientes
            // 
            this.Pacientes.AutoScroll = true;
            this.Pacientes.Controls.Add(idLabel1);
            this.Pacientes.Controls.Add(this.idTextBox1);
            this.Pacientes.Controls.Add(nomeLabel1);
            this.Pacientes.Controls.Add(this.nomeTextBox1);
            this.Pacientes.Controls.Add(rGLabel1);
            this.Pacientes.Controls.Add(this.rGTextBox1);
            this.Pacientes.Controls.Add(cPFLabel1);
            this.Pacientes.Controls.Add(this.cPFTextBox1);
            this.Pacientes.Controls.Add(endereçoLabel1);
            this.Pacientes.Controls.Add(this.endereçoTextBox1);
            this.Pacientes.Controls.Add(telefoneLabel1);
            this.Pacientes.Controls.Add(this.telefoneTextBox1);
            this.Pacientes.Controls.Add(emailLabel1);
            this.Pacientes.Controls.Add(this.emailTextBox1);
            this.Pacientes.Location = new System.Drawing.Point(4, 22);
            this.Pacientes.Name = "Pacientes";
            this.Pacientes.Padding = new System.Windows.Forms.Padding(3);
            this.Pacientes.Size = new System.Drawing.Size(552, 390);
            this.Pacientes.TabIndex = 0;
            this.Pacientes.Text = "Pacientes";
            this.Pacientes.UseVisualStyleBackColor = true;
            // 
            // Médicos
            // 
            this.Médicos.Controls.Add(idLabel);
            this.Médicos.Controls.Add(this.idTextBox);
            this.Médicos.Controls.Add(nomeLabel);
            this.Médicos.Controls.Add(this.nomeTextBox);
            this.Médicos.Controls.Add(rGLabel);
            this.Médicos.Controls.Add(this.rGTextBox);
            this.Médicos.Controls.Add(cPFLabel);
            this.Médicos.Controls.Add(this.cPFTextBox);
            this.Médicos.Controls.Add(cRMLabel);
            this.Médicos.Controls.Add(this.cRMTextBox);
            this.Médicos.Controls.Add(endereçoLabel);
            this.Médicos.Controls.Add(this.endereçoTextBox);
            this.Médicos.Controls.Add(telefoneLabel);
            this.Médicos.Controls.Add(this.telefoneTextBox);
            this.Médicos.Controls.Add(celularLabel);
            this.Médicos.Controls.Add(this.celularTextBox);
            this.Médicos.Controls.Add(emailLabel);
            this.Médicos.Controls.Add(this.emailTextBox);
            this.Médicos.Controls.Add(especialidadeLabel);
            this.Médicos.Controls.Add(this.especialidadeTextBox);
            this.Médicos.Location = new System.Drawing.Point(4, 22);
            this.Médicos.Name = "Médicos";
            this.Médicos.Padding = new System.Windows.Forms.Padding(3);
            this.Médicos.Size = new System.Drawing.Size(552, 390);
            this.Médicos.TabIndex = 1;
            this.Médicos.Text = "Médicos";
            this.Médicos.UseVisualStyleBackColor = true;
            // 
            // Convênios
            // 
            this.Convênios.Controls.Add(idLabel2);
            this.Convênios.Controls.Add(this.idTextBox2);
            this.Convênios.Controls.Add(nomeLabel2);
            this.Convênios.Controls.Add(this.nomeTextBox2);
            this.Convênios.Controls.Add(enderecoLabel);
            this.Convênios.Controls.Add(this.enderecoTextBox);
            this.Convênios.Controls.Add(cidadeLabel);
            this.Convênios.Controls.Add(this.cidadeTextBox);
            this.Convênios.Controls.Add(estadoLabel);
            this.Convênios.Controls.Add(this.estadoTextBox);
            this.Convênios.Controls.Add(cEPLabel);
            this.Convênios.Controls.Add(this.cEPTextBox);
            this.Convênios.Controls.Add(telefoneLabel2);
            this.Convênios.Controls.Add(this.telefoneTextBox2);
            this.Convênios.Controls.Add(emailLabel2);
            this.Convênios.Controls.Add(this.emailTextBox2);
            this.Convênios.Location = new System.Drawing.Point(4, 22);
            this.Convênios.Name = "Convênios";
            this.Convênios.Padding = new System.Windows.Forms.Padding(3);
            this.Convênios.Size = new System.Drawing.Size(552, 390);
            this.Convênios.TabIndex = 2;
            this.Convênios.Text = "Convênios";
            this.Convênios.UseVisualStyleBackColor = true;
            this.Convênios.Click += new System.EventHandler(this.Convênios_Click);
            // 
            // Agenda
            // 
            this.Agenda.Controls.Add(idLabel3);
            this.Agenda.Controls.Add(this.idTextBox3);
            this.Agenda.Controls.Add(nomePacienteLabel1);
            this.Agenda.Controls.Add(this.nomePacienteTextBox1);
            this.Agenda.Controls.Add(nomeMedicoLabel1);
            this.Agenda.Controls.Add(this.nomeMedicoTextBox1);
            this.Agenda.Controls.Add(dataConsultaLabel1);
            this.Agenda.Controls.Add(this.dataConsultaDateTimePicker1);
            this.Agenda.Controls.Add(horarioConsultaLabel1);
            this.Agenda.Controls.Add(this.horarioConsultaTextBox1);
            this.Agenda.Location = new System.Drawing.Point(4, 22);
            this.Agenda.Name = "Agenda";
            this.Agenda.Padding = new System.Windows.Forms.Padding(3);
            this.Agenda.Size = new System.Drawing.Size(552, 390);
            this.Agenda.TabIndex = 3;
            this.Agenda.Text = "Agenda";
            this.Agenda.UseVisualStyleBackColor = true;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataMember = "Medicos";
            this.medicosBindingSource.DataSource = this.database1DataSet;
            // 
            // medicosTableAdapter
            // 
            this.medicosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MedicosTableAdapter = this.medicosTableAdapter;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = ClinicaMedica.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // medicosBindingNavigatorSaveItem
            // 
            this.medicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicosBindingNavigatorSaveItem.Image")));
            this.medicosBindingNavigatorSaveItem.Name = "medicosBindingNavigatorSaveItem";
            this.medicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicosBindingNavigatorSaveItem.Text = "Save Data";
            this.medicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicosBindingNavigatorSaveItem_Click);
            // 
            // medicosBindingNavigator
            // 
            this.medicosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicosBindingNavigator.BindingSource = this.medicosBindingSource;
            this.medicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medicosBindingNavigatorSaveItem});
            this.medicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicosBindingNavigator.Name = "medicosBindingNavigator";
            this.medicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicosBindingNavigator.Size = new System.Drawing.Size(633, 25);
            this.medicosBindingNavigator.TabIndex = 1;
            this.medicosBindingNavigator.Text = "bindingNavigator1";
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.database1DataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicosBindingSource1
            // 
            this.medicosBindingSource1.DataMember = "Medicos";
            this.medicosBindingSource1.DataSource = this.database1DataSet1;
            // 
            // medicosTableAdapter1
            // 
            this.medicosTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AgendaTableAdapter = this.agendaTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ConveniosTableAdapter = this.conveniosTableAdapter;
            this.tableAdapterManager1.MedicosTableAdapter = this.medicosTableAdapter1;
            this.tableAdapterManager1.PacientesTableAdapter = this.pacientesTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = ClinicaMedica.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(42, 38);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(124, 35);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(42, 64);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(124, 61);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(42, 90);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(26, 13);
            rGLabel.TabIndex = 4;
            rGLabel.Text = "RG:";
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(124, 87);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(100, 20);
            this.rGTextBox.TabIndex = 5;
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(42, 116);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(30, 13);
            cPFLabel.TabIndex = 6;
            cPFLabel.Text = "CPF:";
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(124, 113);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(100, 20);
            this.cPFTextBox.TabIndex = 7;
            // 
            // cRMLabel
            // 
            cRMLabel.AutoSize = true;
            cRMLabel.Location = new System.Drawing.Point(42, 142);
            cRMLabel.Name = "cRMLabel";
            cRMLabel.Size = new System.Drawing.Size(34, 13);
            cRMLabel.TabIndex = 8;
            cRMLabel.Text = "CRM:";
            // 
            // cRMTextBox
            // 
            this.cRMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "CRM", true));
            this.cRMTextBox.Location = new System.Drawing.Point(124, 139);
            this.cRMTextBox.Name = "cRMTextBox";
            this.cRMTextBox.Size = new System.Drawing.Size(100, 20);
            this.cRMTextBox.TabIndex = 9;
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Location = new System.Drawing.Point(42, 168);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(56, 13);
            endereçoLabel.TabIndex = 10;
            endereçoLabel.Text = "Endereço:";
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "Endereço", true));
            this.endereçoTextBox.Location = new System.Drawing.Point(124, 165);
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(100, 20);
            this.endereçoTextBox.TabIndex = 11;
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(42, 194);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 12;
            telefoneLabel.Text = "Telefone:";
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "Telefone", true));
            this.telefoneTextBox.Location = new System.Drawing.Point(124, 191);
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox.TabIndex = 13;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(42, 220);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 14;
            celularLabel.Text = "Celular:";
            // 
            // celularTextBox
            // 
            this.celularTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "Celular", true));
            this.celularTextBox.Location = new System.Drawing.Point(124, 217);
            this.celularTextBox.Name = "celularTextBox";
            this.celularTextBox.Size = new System.Drawing.Size(100, 20);
            this.celularTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(42, 246);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(124, 243);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 17;
            // 
            // especialidadeLabel
            // 
            especialidadeLabel.AutoSize = true;
            especialidadeLabel.Location = new System.Drawing.Point(42, 272);
            especialidadeLabel.Name = "especialidadeLabel";
            especialidadeLabel.Size = new System.Drawing.Size(76, 13);
            especialidadeLabel.TabIndex = 18;
            especialidadeLabel.Text = "Especialidade:";
            // 
            // especialidadeTextBox
            // 
            this.especialidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource1, "Especialidade", true));
            this.especialidadeTextBox.Location = new System.Drawing.Point(124, 269);
            this.especialidadeTextBox.Name = "especialidadeTextBox";
            this.especialidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.especialidadeTextBox.TabIndex = 19;
            // 
            // pacientesBindingSource1
            // 
            this.pacientesBindingSource1.DataMember = "Pacientes";
            this.pacientesBindingSource1.DataSource = this.database1DataSet1;
            // 
            // pacientesTableAdapter1
            // 
            this.pacientesTableAdapter1.ClearBeforeFill = true;
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(37, 32);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 0;
            idLabel1.Text = "Id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource1, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(99, 29);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 1;
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Location = new System.Drawing.Point(37, 58);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(38, 13);
            nomeLabel1.TabIndex = 2;
            nomeLabel1.Text = "Nome:";
            // 
            // nomeTextBox1
            // 
            this.nomeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource1, "Nome", true));
            this.nomeTextBox1.Location = new System.Drawing.Point(99, 55);
            this.nomeTextBox1.Name = "nomeTextBox1";
            this.nomeTextBox1.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox1.TabIndex = 3;
            // 
            // rGLabel1
            // 
            rGLabel1.AutoSize = true;
            rGLabel1.Location = new System.Drawing.Point(37, 84);
            rGLabel1.Name = "rGLabel1";
            rGLabel1.Size = new System.Drawing.Size(26, 13);
            rGLabel1.TabIndex = 4;
            rGLabel1.Text = "RG:";
            // 
            // rGTextBox1
            // 
            this.rGTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource1, "RG", true));
            this.rGTextBox1.Location = new System.Drawing.Point(99, 81);
            this.rGTextBox1.Name = "rGTextBox1";
            this.rGTextBox1.Size = new System.Drawing.Size(100, 20);
            this.rGTextBox1.TabIndex = 5;
            // 
            // cPFLabel1
            // 
            cPFLabel1.AutoSize = true;
            cPFLabel1.Location = new System.Drawing.Point(37, 110);
            cPFLabel1.Name = "cPFLabel1";
            cPFLabel1.Size = new System.Drawing.Size(30, 13);
            cPFLabel1.TabIndex = 6;
            cPFLabel1.Text = "CPF:";
            // 
            // cPFTextBox1
            // 
            this.cPFTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource1, "CPF", true));
            this.cPFTextBox1.Location = new System.Drawing.Point(99, 107);
            this.cPFTextBox1.Name = "cPFTextBox1";
            this.cPFTextBox1.Size = new System.Drawing.Size(100, 20);
            this.cPFTextBox1.TabIndex = 7;
            // 
            // endereçoLabel1
            // 
            endereçoLabel1.AutoSize = true;
            endereçoLabel1.Location = new System.Drawing.Point(37, 136);
            endereçoLabel1.Name = "endereçoLabel1";
            endereçoLabel1.Size = new System.Drawing.Size(56, 13);
            endereçoLabel1.TabIndex = 8;
            endereçoLabel1.Text = "Endereço:";
            // 
            // endereçoTextBox1
            // 
            this.endereçoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource1, "Endereço", true));
            this.endereçoTextBox1.Location = new System.Drawing.Point(99, 133);
            this.endereçoTextBox1.Name = "endereçoTextBox1";
            this.endereçoTextBox1.Size = new System.Drawing.Size(100, 20);
            this.endereçoTextBox1.TabIndex = 9;
            // 
            // telefoneLabel1
            // 
            telefoneLabel1.AutoSize = true;
            telefoneLabel1.Location = new System.Drawing.Point(37, 162);
            telefoneLabel1.Name = "telefoneLabel1";
            telefoneLabel1.Size = new System.Drawing.Size(52, 13);
            telefoneLabel1.TabIndex = 10;
            telefoneLabel1.Text = "Telefone:";
            // 
            // telefoneTextBox1
            // 
            this.telefoneTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource1, "Telefone", true));
            this.telefoneTextBox1.Location = new System.Drawing.Point(99, 159);
            this.telefoneTextBox1.Name = "telefoneTextBox1";
            this.telefoneTextBox1.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox1.TabIndex = 11;
            // 
            // emailLabel1
            // 
            emailLabel1.AutoSize = true;
            emailLabel1.Location = new System.Drawing.Point(37, 188);
            emailLabel1.Name = "emailLabel1";
            emailLabel1.Size = new System.Drawing.Size(35, 13);
            emailLabel1.TabIndex = 12;
            emailLabel1.Text = "Email:";
            // 
            // emailTextBox1
            // 
            this.emailTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource1, "Email", true));
            this.emailTextBox1.Location = new System.Drawing.Point(99, 185);
            this.emailTextBox1.Name = "emailTextBox1";
            this.emailTextBox1.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox1.TabIndex = 13;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.database1DataSet1;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // idLabel3
            // 
            idLabel3.AutoSize = true;
            idLabel3.Location = new System.Drawing.Point(20, 30);
            idLabel3.Name = "idLabel3";
            idLabel3.Size = new System.Drawing.Size(19, 13);
            idLabel3.TabIndex = 0;
            idLabel3.Text = "Id:";
            // 
            // idTextBox3
            // 
            this.idTextBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Id", true));
            this.idTextBox3.Location = new System.Drawing.Point(114, 27);
            this.idTextBox3.Name = "idTextBox3";
            this.idTextBox3.Size = new System.Drawing.Size(200, 20);
            this.idTextBox3.TabIndex = 1;
            // 
            // nomePacienteLabel1
            // 
            nomePacienteLabel1.AutoSize = true;
            nomePacienteLabel1.Location = new System.Drawing.Point(20, 56);
            nomePacienteLabel1.Name = "nomePacienteLabel1";
            nomePacienteLabel1.Size = new System.Drawing.Size(83, 13);
            nomePacienteLabel1.TabIndex = 2;
            nomePacienteLabel1.Text = "Nome Paciente:";
            // 
            // nomePacienteTextBox1
            // 
            this.nomePacienteTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "NomePaciente", true));
            this.nomePacienteTextBox1.Location = new System.Drawing.Point(114, 53);
            this.nomePacienteTextBox1.Name = "nomePacienteTextBox1";
            this.nomePacienteTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nomePacienteTextBox1.TabIndex = 3;
            // 
            // nomeMedicoLabel1
            // 
            nomeMedicoLabel1.AutoSize = true;
            nomeMedicoLabel1.Location = new System.Drawing.Point(20, 82);
            nomeMedicoLabel1.Name = "nomeMedicoLabel1";
            nomeMedicoLabel1.Size = new System.Drawing.Size(76, 13);
            nomeMedicoLabel1.TabIndex = 4;
            nomeMedicoLabel1.Text = "Nome Medico:";
            // 
            // nomeMedicoTextBox1
            // 
            this.nomeMedicoTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "NomeMedico", true));
            this.nomeMedicoTextBox1.Location = new System.Drawing.Point(114, 79);
            this.nomeMedicoTextBox1.Name = "nomeMedicoTextBox1";
            this.nomeMedicoTextBox1.Size = new System.Drawing.Size(200, 20);
            this.nomeMedicoTextBox1.TabIndex = 5;
            // 
            // dataConsultaLabel1
            // 
            dataConsultaLabel1.AutoSize = true;
            dataConsultaLabel1.Location = new System.Drawing.Point(20, 109);
            dataConsultaLabel1.Name = "dataConsultaLabel1";
            dataConsultaLabel1.Size = new System.Drawing.Size(77, 13);
            dataConsultaLabel1.TabIndex = 6;
            dataConsultaLabel1.Text = "Data Consulta:";
            // 
            // dataConsultaDateTimePicker1
            // 
            this.dataConsultaDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendaBindingSource, "DataConsulta", true));
            this.dataConsultaDateTimePicker1.Location = new System.Drawing.Point(114, 105);
            this.dataConsultaDateTimePicker1.Name = "dataConsultaDateTimePicker1";
            this.dataConsultaDateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dataConsultaDateTimePicker1.TabIndex = 7;
            // 
            // horarioConsultaLabel1
            // 
            horarioConsultaLabel1.AutoSize = true;
            horarioConsultaLabel1.Location = new System.Drawing.Point(20, 134);
            horarioConsultaLabel1.Name = "horarioConsultaLabel1";
            horarioConsultaLabel1.Size = new System.Drawing.Size(88, 13);
            horarioConsultaLabel1.TabIndex = 8;
            horarioConsultaLabel1.Text = "Horario Consulta:";
            // 
            // horarioConsultaTextBox1
            // 
            this.horarioConsultaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "HorarioConsulta", true));
            this.horarioConsultaTextBox1.Location = new System.Drawing.Point(114, 131);
            this.horarioConsultaTextBox1.Name = "horarioConsultaTextBox1";
            this.horarioConsultaTextBox1.Size = new System.Drawing.Size(200, 20);
            this.horarioConsultaTextBox1.TabIndex = 9;
            // 
            // conveniosBindingSource
            // 
            this.conveniosBindingSource.DataMember = "Convenios";
            this.conveniosBindingSource.DataSource = this.database1DataSet1;
            // 
            // conveniosTableAdapter
            // 
            this.conveniosTableAdapter.ClearBeforeFill = true;
            // 
            // idLabel2
            // 
            idLabel2.AutoSize = true;
            idLabel2.Location = new System.Drawing.Point(40, 36);
            idLabel2.Name = "idLabel2";
            idLabel2.Size = new System.Drawing.Size(19, 13);
            idLabel2.TabIndex = 0;
            idLabel2.Text = "Id:";
            // 
            // idTextBox2
            // 
            this.idTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conveniosBindingSource, "Id", true));
            this.idTextBox2.Location = new System.Drawing.Point(102, 33);
            this.idTextBox2.Name = "idTextBox2";
            this.idTextBox2.Size = new System.Drawing.Size(100, 20);
            this.idTextBox2.TabIndex = 1;
            // 
            // nomeLabel2
            // 
            nomeLabel2.AutoSize = true;
            nomeLabel2.Location = new System.Drawing.Point(40, 62);
            nomeLabel2.Name = "nomeLabel2";
            nomeLabel2.Size = new System.Drawing.Size(38, 13);
            nomeLabel2.TabIndex = 2;
            nomeLabel2.Text = "Nome:";
            // 
            // nomeTextBox2
            // 
            this.nomeTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conveniosBindingSource, "Nome", true));
            this.nomeTextBox2.Location = new System.Drawing.Point(102, 59);
            this.nomeTextBox2.Name = "nomeTextBox2";
            this.nomeTextBox2.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox2.TabIndex = 3;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(40, 88);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 4;
            enderecoLabel.Text = "Endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conveniosBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(102, 85);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(100, 20);
            this.enderecoTextBox.TabIndex = 5;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(40, 114);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 6;
            cidadeLabel.Text = "Cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conveniosBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(102, 111);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 7;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(40, 140);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "Estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conveniosBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(102, 137);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 9;
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(40, 166);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 10;
            cEPLabel.Text = "CEP:";
            // 
            // cEPTextBox
            // 
            this.cEPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conveniosBindingSource, "CEP", true));
            this.cEPTextBox.Location = new System.Drawing.Point(102, 163);
            this.cEPTextBox.Name = "cEPTextBox";
            this.cEPTextBox.Size = new System.Drawing.Size(100, 20);
            this.cEPTextBox.TabIndex = 11;
            // 
            // telefoneLabel2
            // 
            telefoneLabel2.AutoSize = true;
            telefoneLabel2.Location = new System.Drawing.Point(40, 192);
            telefoneLabel2.Name = "telefoneLabel2";
            telefoneLabel2.Size = new System.Drawing.Size(52, 13);
            telefoneLabel2.TabIndex = 12;
            telefoneLabel2.Text = "Telefone:";
            // 
            // telefoneTextBox2
            // 
            this.telefoneTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conveniosBindingSource, "Telefone", true));
            this.telefoneTextBox2.Location = new System.Drawing.Point(102, 189);
            this.telefoneTextBox2.Name = "telefoneTextBox2";
            this.telefoneTextBox2.Size = new System.Drawing.Size(100, 20);
            this.telefoneTextBox2.TabIndex = 13;
            // 
            // emailLabel2
            // 
            emailLabel2.AutoSize = true;
            emailLabel2.Location = new System.Drawing.Point(40, 218);
            emailLabel2.Name = "emailLabel2";
            emailLabel2.Size = new System.Drawing.Size(35, 13);
            emailLabel2.TabIndex = 14;
            emailLabel2.Text = "Email:";
            // 
            // emailTextBox2
            // 
            this.emailTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.conveniosBindingSource, "Email", true));
            this.emailTextBox2.Location = new System.Drawing.Point(102, 215);
            this.emailTextBox2.Name = "emailTextBox2";
            this.emailTextBox2.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 490);
            this.Controls.Add(this.medicosBindingNavigator);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Pacientes.ResumeLayout(false);
            this.Pacientes.PerformLayout();
            this.Médicos.ResumeLayout(false);
            this.Médicos.PerformLayout();
            this.Convênios.ResumeLayout(false);
            this.Convênios.PerformLayout();
            this.Agenda.ResumeLayout(false);
            this.Agenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingNavigator)).EndInit();
            this.medicosBindingNavigator.ResumeLayout(false);
            this.medicosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conveniosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Pacientes;
        private System.Windows.Forms.TabPage Médicos;
        private System.Windows.Forms.TabPage Convênios;
        private System.Windows.Forms.TabPage Agenda;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private Database1DataSetTableAdapters.MedicosTableAdapter medicosTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton medicosBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator medicosBindingNavigator;
        private Database1DataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource medicosBindingSource1;
        private Database1DataSet1TableAdapters.MedicosTableAdapter medicosTableAdapter1;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox cRMTextBox;
        private System.Windows.Forms.TextBox endereçoTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox;
        private System.Windows.Forms.TextBox celularTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox especialidadeTextBox;
        private Database1DataSet1TableAdapters.PacientesTableAdapter pacientesTableAdapter1;
        private System.Windows.Forms.BindingSource pacientesBindingSource1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox nomeTextBox1;
        private System.Windows.Forms.TextBox rGTextBox1;
        private System.Windows.Forms.TextBox cPFTextBox1;
        private System.Windows.Forms.TextBox endereçoTextBox1;
        private System.Windows.Forms.TextBox telefoneTextBox1;
        private System.Windows.Forms.TextBox emailTextBox1;
        private Database1DataSet1TableAdapters.AgendaTableAdapter agendaTableAdapter;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private System.Windows.Forms.TextBox idTextBox3;
        private System.Windows.Forms.TextBox nomePacienteTextBox1;
        private System.Windows.Forms.TextBox nomeMedicoTextBox1;
        private System.Windows.Forms.DateTimePicker dataConsultaDateTimePicker1;
        private System.Windows.Forms.TextBox horarioConsultaTextBox1;
        private Database1DataSet1TableAdapters.ConveniosTableAdapter conveniosTableAdapter;
        private System.Windows.Forms.BindingSource conveniosBindingSource;
        private System.Windows.Forms.TextBox idTextBox2;
        private System.Windows.Forms.TextBox nomeTextBox2;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox cEPTextBox;
        private System.Windows.Forms.TextBox telefoneTextBox2;
        private System.Windows.Forms.TextBox emailTextBox2;
    }
}

