namespace ISAPro
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelPk = new System.Windows.Forms.Label();
            this.labelPm = new System.Windows.Forms.Label();
            this.textBoxPk = new System.Windows.Forms.TextBox();
            this.textBoxPm = new System.Windows.Forms.TextBox();
            this.Lab5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.generateTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generateTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xreal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(12, 22);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 17);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Podaj a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(180, 22);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(56, 17);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Podaj b";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(348, 22);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(56, 17);
            this.labelD.TabIndex = 2;
            this.labelD.Text = "Podaj d";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(516, 22);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(56, 17);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "Podaj n";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(74, 19);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 4;
            this.textBoxA.Text = "-4";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(242, 19);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.Text = "12";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(410, 19);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 22);
            this.textBoxD.TabIndex = 6;
            this.textBoxD.Text = "0,001";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(578, 19);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 7;
            this.textBoxN.Text = "10";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lpDataGridViewTextBoxColumn,
            this.xreal,
            this.fx,
            this.amount});
            this.dataGridView1.DataSource = this.generateTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(119, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(640, 340);
            this.dataGridView1.TabIndex = 9;
            // 
            // labelPk
            // 
            this.labelPk.AutoSize = true;
            this.labelPk.Location = new System.Drawing.Point(684, 22);
            this.labelPk.Name = "labelPk";
            this.labelPk.Size = new System.Drawing.Size(64, 17);
            this.labelPk.TabIndex = 11;
            this.labelPk.Text = "Podaj Pk";
            // 
            // labelPm
            // 
            this.labelPm.AutoSize = true;
            this.labelPm.Location = new System.Drawing.Point(860, 22);
            this.labelPm.Name = "labelPm";
            this.labelPm.Size = new System.Drawing.Size(68, 17);
            this.labelPm.TabIndex = 12;
            this.labelPm.Text = "Podaj Pm";
            // 
            // textBoxPk
            // 
            this.textBoxPk.Location = new System.Drawing.Point(754, 19);
            this.textBoxPk.Name = "textBoxPk";
            this.textBoxPk.Size = new System.Drawing.Size(100, 22);
            this.textBoxPk.TabIndex = 13;
            this.textBoxPk.Text = "0,85";
            // 
            // textBoxPm
            // 
            this.textBoxPm.Location = new System.Drawing.Point(934, 19);
            this.textBoxPm.Name = "textBoxPm";
            this.textBoxPm.Size = new System.Drawing.Size(100, 22);
            this.textBoxPm.TabIndex = 14;
            this.textBoxPm.Text = "0,002";
            // 
            // Lab5
            // 
            this.Lab5.Location = new System.Drawing.Point(1293, 19);
            this.Lab5.Name = "Lab5";
            this.Lab5.Size = new System.Drawing.Size(75, 23);
            this.Lab5.TabIndex = 15;
            this.Lab5.Text = "Start";
            this.Lab5.UseVisualStyleBackColor = true;
            this.Lab5.Click += new System.EventHandler(this.Lab5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1040, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Podaj T";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(1103, 19);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 22);
            this.textBoxT.TabIndex = 17;
            this.textBoxT.Text = "100";
            // 
            // generateTableBindingSource1
            // 
            this.generateTableBindingSource1.DataSource = typeof(ISAPro.GenerateTable);
            // 
            // generateTableBindingSource
            // 
            this.generateTableBindingSource.DataSource = typeof(ISAPro.GenerateTable);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(ISAPro.Form1);
            // 
            // lpDataGridViewTextBoxColumn
            // 
            this.lpDataGridViewTextBoxColumn.DataPropertyName = "Lp";
            this.lpDataGridViewTextBoxColumn.HeaderText = "Lp";
            this.lpDataGridViewTextBoxColumn.Name = "lpDataGridViewTextBoxColumn";
            // 
            // xreal
            // 
            this.xreal.DataPropertyName = "xreal";
            this.xreal.HeaderText = "xreal";
            this.xreal.Name = "xreal";
            // 
            // fx
            // 
            this.fx.DataPropertyName = "fx";
            this.fx.HeaderText = "fx";
            this.fx.Name = "fx";
            // 
            // amount
            // 
            this.amount.DataPropertyName = "amount";
            this.amount.HeaderText = "amount(%)";
            this.amount.Name = "amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1751, 509);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lab5);
            this.Controls.Add(this.textBoxPm);
            this.Controls.Add(this.textBoxPk);
            this.Controls.Add(this.labelPm);
            this.Controls.Add(this.labelPk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource generateTableBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource generateTableBindingSource1;
        private System.Windows.Forms.Label labelPk;
        private System.Windows.Forms.Label labelPm;
        private System.Windows.Forms.TextBox textBoxPk;
        private System.Windows.Forms.TextBox textBoxPm;
        private System.Windows.Forms.Button Lab5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xreal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fx;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
    }
}

