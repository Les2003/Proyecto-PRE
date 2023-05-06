namespace Proyecto_3
{
    partial class Agenda
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label telefónoLabel;
            System.Windows.Forms.Label lugar__de_destinoLabel;
            System.Windows.Forms.Label lugar_de_abordajeLabel;
            System.Windows.Forms.Label fecha_de_reservaLabel;
            System.Windows.Forms.Label fecha_del_vueloLabel;
            System.Windows.Forms.Label hora_de_reservaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.agendaDataSet = new Proyecto_3.AgendaDataSet();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter = new Proyecto_3.AgendaDataSetTableAdapters.AgendaTableAdapter();
            this.tableAdapterManager = new Proyecto_3.AgendaDataSetTableAdapters.TableAdapterManager();
            this.agendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.agendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.telefónoTextBox = new System.Windows.Forms.TextBox();
            this.lugar__de_destinoTextBox = new System.Windows.Forms.TextBox();
            this.lugar_de_abordajeTextBox = new System.Windows.Forms.TextBox();
            this.fecha_de_reservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_del_vueloDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hora_de_reservaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pdf = new System.Windows.Forms.Button();
            this.agendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            telefónoLabel = new System.Windows.Forms.Label();
            lugar__de_destinoLabel = new System.Windows.Forms.Label();
            lugar_de_abordajeLabel = new System.Windows.Forms.Label();
            fecha_de_reservaLabel = new System.Windows.Forms.Label();
            fecha_del_vueloLabel = new System.Windows.Forms.Label();
            hora_de_reservaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingNavigator)).BeginInit();
            this.agendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(69, 86);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(69, 112);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 3;
            apellidoLabel.Text = "Apellido:";
            // 
            // telefónoLabel
            // 
            telefónoLabel.AutoSize = true;
            telefónoLabel.Location = new System.Drawing.Point(69, 138);
            telefónoLabel.Name = "telefónoLabel";
            telefónoLabel.Size = new System.Drawing.Size(52, 13);
            telefónoLabel.TabIndex = 5;
            telefónoLabel.Text = "Telefóno:";
            // 
            // lugar__de_destinoLabel
            // 
            lugar__de_destinoLabel.AutoSize = true;
            lugar__de_destinoLabel.Location = new System.Drawing.Point(69, 164);
            lugar__de_destinoLabel.Name = "lugar__de_destinoLabel";
            lugar__de_destinoLabel.Size = new System.Drawing.Size(92, 13);
            lugar__de_destinoLabel.TabIndex = 7;
            lugar__de_destinoLabel.Text = "Lugar  de destino:";
            // 
            // lugar_de_abordajeLabel
            // 
            lugar_de_abordajeLabel.AutoSize = true;
            lugar_de_abordajeLabel.Location = new System.Drawing.Point(69, 190);
            lugar_de_abordajeLabel.Name = "lugar_de_abordajeLabel";
            lugar_de_abordajeLabel.Size = new System.Drawing.Size(96, 13);
            lugar_de_abordajeLabel.TabIndex = 9;
            lugar_de_abordajeLabel.Text = "Lugar de abordaje:";
            // 
            // fecha_de_reservaLabel
            // 
            fecha_de_reservaLabel.AutoSize = true;
            fecha_de_reservaLabel.Location = new System.Drawing.Point(69, 217);
            fecha_de_reservaLabel.Name = "fecha_de_reservaLabel";
            fecha_de_reservaLabel.Size = new System.Drawing.Size(93, 13);
            fecha_de_reservaLabel.TabIndex = 11;
            fecha_de_reservaLabel.Text = "Fecha de reserva:";
            // 
            // fecha_del_vueloLabel
            // 
            fecha_del_vueloLabel.AutoSize = true;
            fecha_del_vueloLabel.Location = new System.Drawing.Point(69, 243);
            fecha_del_vueloLabel.Name = "fecha_del_vueloLabel";
            fecha_del_vueloLabel.Size = new System.Drawing.Size(86, 13);
            fecha_del_vueloLabel.TabIndex = 13;
            fecha_del_vueloLabel.Text = "Fecha del vuelo:";
            // 
            // hora_de_reservaLabel
            // 
            hora_de_reservaLabel.AutoSize = true;
            hora_de_reservaLabel.Location = new System.Drawing.Point(69, 269);
            hora_de_reservaLabel.Name = "hora_de_reservaLabel";
            hora_de_reservaLabel.Size = new System.Drawing.Size(86, 13);
            hora_de_reservaLabel.TabIndex = 15;
            hora_de_reservaLabel.Text = "Hora de reserva:";
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "AgendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.agendaDataSet;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendaTableAdapter = this.agendaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Proyecto_3.AgendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agendaBindingNavigator
            // 
            this.agendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agendaBindingNavigator.BindingSource = this.agendaBindingSource;
            this.agendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.agendaBindingNavigatorSaveItem});
            this.agendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendaBindingNavigator.Name = "agendaBindingNavigator";
            this.agendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendaBindingNavigator.Size = new System.Drawing.Size(865, 25);
            this.agendaBindingNavigator.TabIndex = 0;
            this.agendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // agendaBindingNavigatorSaveItem
            // 
            this.agendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agendaBindingNavigatorSaveItem.Image")));
            this.agendaBindingNavigatorSaveItem.Name = "agendaBindingNavigatorSaveItem";
            this.agendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agendaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.agendaBindingNavigatorSaveItem.Click += new System.EventHandler(this.agendaBindingNavigatorSaveItem_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(171, 83);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 2;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(171, 109);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidoTextBox.TabIndex = 4;
            // 
            // telefónoTextBox
            // 
            this.telefónoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Telefóno", true));
            this.telefónoTextBox.Location = new System.Drawing.Point(171, 135);
            this.telefónoTextBox.Name = "telefónoTextBox";
            this.telefónoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefónoTextBox.TabIndex = 6;
            // 
            // lugar__de_destinoTextBox
            // 
            this.lugar__de_destinoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Lugar  de destino", true));
            this.lugar__de_destinoTextBox.Location = new System.Drawing.Point(171, 161);
            this.lugar__de_destinoTextBox.Name = "lugar__de_destinoTextBox";
            this.lugar__de_destinoTextBox.Size = new System.Drawing.Size(200, 20);
            this.lugar__de_destinoTextBox.TabIndex = 8;
            // 
            // lugar_de_abordajeTextBox
            // 
            this.lugar_de_abordajeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Lugar de abordaje", true));
            this.lugar_de_abordajeTextBox.Location = new System.Drawing.Point(171, 187);
            this.lugar_de_abordajeTextBox.Name = "lugar_de_abordajeTextBox";
            this.lugar_de_abordajeTextBox.Size = new System.Drawing.Size(200, 20);
            this.lugar_de_abordajeTextBox.TabIndex = 10;
            // 
            // fecha_de_reservaDateTimePicker
            // 
            this.fecha_de_reservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendaBindingSource, "Fecha de reserva", true));
            this.fecha_de_reservaDateTimePicker.Location = new System.Drawing.Point(171, 213);
            this.fecha_de_reservaDateTimePicker.Name = "fecha_de_reservaDateTimePicker";
            this.fecha_de_reservaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_de_reservaDateTimePicker.TabIndex = 12;
            // 
            // fecha_del_vueloDateTimePicker
            // 
            this.fecha_del_vueloDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendaBindingSource, "Fecha del vuelo", true));
            this.fecha_del_vueloDateTimePicker.Location = new System.Drawing.Point(171, 239);
            this.fecha_del_vueloDateTimePicker.Name = "fecha_del_vueloDateTimePicker";
            this.fecha_del_vueloDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_del_vueloDateTimePicker.TabIndex = 14;
            // 
            // hora_de_reservaDateTimePicker
            // 
            this.hora_de_reservaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendaBindingSource, "Hora de reserva", true));
            this.hora_de_reservaDateTimePicker.Location = new System.Drawing.Point(171, 265);
            this.hora_de_reservaDateTimePicker.Name = "hora_de_reservaDateTimePicker";
            this.hora_de_reservaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.hora_de_reservaDateTimePicker.TabIndex = 16;
            this.hora_de_reservaDateTimePicker.Value = new System.DateTime(2023, 5, 2, 15, 34, 0, 0);
            this.hora_de_reservaDateTimePicker.ValueChanged += new System.EventHandler(this.hora_de_reservaDateTimePicker_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Menú principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pdf
            // 
            this.pdf.Location = new System.Drawing.Point(353, 303);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(187, 29);
            this.pdf.TabIndex = 18;
            this.pdf.Text = "Crear PDF\r\n";
            this.pdf.UseVisualStyleBackColor = true;
            this.pdf.Click += new System.EventHandler(this.pdf_Click);
            // 
            // agendaDataGridView
            // 
            this.agendaDataGridView.AutoGenerateColumns = false;
            this.agendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.agendaDataGridView.DataSource = this.agendaBindingSource;
            this.agendaDataGridView.Location = new System.Drawing.Point(440, 52);
            this.agendaDataGridView.Name = "agendaDataGridView";
            this.agendaDataGridView.Size = new System.Drawing.Size(413, 129);
            this.agendaDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefóno";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefóno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Lugar  de destino";
            this.dataGridViewTextBoxColumn4.HeaderText = "Lugar  de destino";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Lugar de abordaje";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lugar de abordaje";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fecha de reserva";
            this.dataGridViewTextBoxColumn6.HeaderText = "Fecha de reserva";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Fecha del vuelo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Fecha del vuelo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Hora de reserva";
            this.dataGridViewTextBoxColumn8.HeaderText = "Hora de reserva";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "Siguiente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.agendaDataGridView);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.button1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(telefónoLabel);
            this.Controls.Add(this.telefónoTextBox);
            this.Controls.Add(lugar__de_destinoLabel);
            this.Controls.Add(this.lugar__de_destinoTextBox);
            this.Controls.Add(lugar_de_abordajeLabel);
            this.Controls.Add(this.lugar_de_abordajeTextBox);
            this.Controls.Add(fecha_de_reservaLabel);
            this.Controls.Add(this.fecha_de_reservaDateTimePicker);
            this.Controls.Add(fecha_del_vueloLabel);
            this.Controls.Add(this.fecha_del_vueloDateTimePicker);
            this.Controls.Add(hora_de_reservaLabel);
            this.Controls.Add(this.hora_de_reservaDateTimePicker);
            this.Controls.Add(this.agendaBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingNavigator)).EndInit();
            this.agendaBindingNavigator.ResumeLayout(false);
            this.agendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private AgendaDataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private AgendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agendaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton agendaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox telefónoTextBox;
        private System.Windows.Forms.TextBox lugar__de_destinoTextBox;
        private System.Windows.Forms.TextBox lugar_de_abordajeTextBox;
        private System.Windows.Forms.DateTimePicker fecha_de_reservaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_del_vueloDateTimePicker;
        private System.Windows.Forms.DateTimePicker hora_de_reservaDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pdf;
        private System.Windows.Forms.DataGridView agendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button button2;
    }
}