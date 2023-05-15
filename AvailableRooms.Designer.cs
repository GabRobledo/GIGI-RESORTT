
namespace GIGI_RESORTT
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resortReservationSystemDataSet4 = new GIGI_RESORTT.ResortReservationSystemDataSet4();
            this.available_RoomsTableAdapter = new GIGI_RESORTT.ResortReservationSystemDataSet4TableAdapters.Available_RoomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Rooms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sort by";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Room Type"});
            this.comboBox1.Location = new System.Drawing.Point(95, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Availability"});
            this.comboBox2.Location = new System.Drawing.Point(185, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Proceed";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.paxDataGridViewTextBoxColumn,
            this.availabilityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.availableRoomsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 278);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "Room Name";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "Room Name";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // paxDataGridViewTextBoxColumn
            // 
            this.paxDataGridViewTextBoxColumn.DataPropertyName = "Pax";
            this.paxDataGridViewTextBoxColumn.HeaderText = "Pax";
            this.paxDataGridViewTextBoxColumn.Name = "paxDataGridViewTextBoxColumn";
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "Availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            // 
            // availableRoomsBindingSource
            // 
            this.availableRoomsBindingSource.DataMember = "Available Rooms";
            this.availableRoomsBindingSource.DataSource = this.resortReservationSystemDataSet4;
            // 
            // resortReservationSystemDataSet4
            // 
            this.resortReservationSystemDataSet4.DataSetName = "ResortReservationSystemDataSet4";
            this.resortReservationSystemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // available_RoomsTableAdapter
            // 
            this.available_RoomsTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resortReservationSystemDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ResortReservationSystemDataSet4 resortReservationSystemDataSet4;
        private System.Windows.Forms.BindingSource availableRoomsBindingSource;
        private ResortReservationSystemDataSet4TableAdapters.Available_RoomsTableAdapter available_RoomsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
    }
}