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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xreal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPk = new System.Windows.Forms.Label();
            this.labelPm = new System.Windows.Forms.Label();
            this.textBoxPk = new System.Windows.Forms.TextBox();
            this.textBoxPm = new System.Windows.Forms.TextBox();
            this.AlgorytmGenetyczny = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxEilte = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTau = new System.Windows.Forms.TextBox();
            this.GEO = new System.Windows.Forms.Button();
            this.richTextBoxGEO = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generateTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generateTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(23, 20);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(56, 17);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "Podaj a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(23, 64);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(56, 17);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "Podaj b";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(191, 20);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(56, 17);
            this.labelD.TabIndex = 2;
            this.labelD.Text = "Podaj d";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(191, 64);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(56, 17);
            this.labelN.TabIndex = 3;
            this.labelN.Text = "Podaj n";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(85, 17);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 4;
            this.textBoxA.Text = "-4";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(85, 64);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.Text = "12";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(253, 18);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 22);
            this.textBoxD.TabIndex = 6;
            this.textBoxD.Text = "0,001";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(253, 61);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 22);
            this.textBoxN.TabIndex = 7;
            this.textBoxN.Text = "35";
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
            this.dataGridView1.Location = new System.Drawing.Point(201, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 409);
            this.dataGridView1.TabIndex = 9;
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
            // labelPk
            // 
            this.labelPk.AutoSize = true;
            this.labelPk.Location = new System.Drawing.Point(359, 20);
            this.labelPk.Name = "labelPk";
            this.labelPk.Size = new System.Drawing.Size(64, 17);
            this.labelPk.TabIndex = 11;
            this.labelPk.Text = "Podaj Pk";
            // 
            // labelPm
            // 
            this.labelPm.AutoSize = true;
            this.labelPm.Location = new System.Drawing.Point(359, 61);
            this.labelPm.Name = "labelPm";
            this.labelPm.Size = new System.Drawing.Size(68, 17);
            this.labelPm.TabIndex = 12;
            this.labelPm.Text = "Podaj Pm";
            // 
            // textBoxPk
            // 
            this.textBoxPk.Location = new System.Drawing.Point(429, 17);
            this.textBoxPk.Name = "textBoxPk";
            this.textBoxPk.Size = new System.Drawing.Size(100, 22);
            this.textBoxPk.TabIndex = 13;
            this.textBoxPk.Text = "0,6";
            // 
            // textBoxPm
            // 
            this.textBoxPm.Location = new System.Drawing.Point(433, 59);
            this.textBoxPm.Name = "textBoxPm";
            this.textBoxPm.Size = new System.Drawing.Size(100, 22);
            this.textBoxPm.TabIndex = 14;
            this.textBoxPm.Text = "0,0005";
            // 
            // AlgorytmGenetyczny
            // 
            this.AlgorytmGenetyczny.Location = new System.Drawing.Point(26, 103);
            this.AlgorytmGenetyczny.Name = "AlgorytmGenetyczny";
            this.AlgorytmGenetyczny.Size = new System.Drawing.Size(737, 44);
            this.AlgorytmGenetyczny.TabIndex = 15;
            this.AlgorytmGenetyczny.Text = "Start Algorytm Genetyczny";
            this.AlgorytmGenetyczny.UseVisualStyleBackColor = true;
            this.AlgorytmGenetyczny.Click += new System.EventHandler(this.AlgorytmGenetyczny_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(535, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Podaj T";
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(598, 17);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(100, 22);
            this.textBoxT.TabIndex = 17;
            this.textBoxT.Text = "130";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(26, 165);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 438);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wyniki AG";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(987, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Wykres AG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-3, 0);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "FxMAX";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "FxAVG";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "FxMIN";
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(990, 406);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // checkBoxEilte
            // 
            this.checkBoxEilte.AutoSize = true;
            this.checkBoxEilte.Location = new System.Drawing.Point(745, 22);
            this.checkBoxEilte.Name = "checkBoxEilte";
            this.checkBoxEilte.Size = new System.Drawing.Size(18, 17);
            this.checkBoxEilte.TabIndex = 20;
            this.checkBoxEilte.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(704, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Elita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(540, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Podaj Tau";
            // 
            // textBoxTau
            // 
            this.textBoxTau.Location = new System.Drawing.Point(620, 60);
            this.textBoxTau.Name = "textBoxTau";
            this.textBoxTau.Size = new System.Drawing.Size(100, 22);
            this.textBoxTau.TabIndex = 23;
            this.textBoxTau.Text = "1,7";
            // 
            // GEO
            // 
            this.GEO.Location = new System.Drawing.Point(780, 103);
            this.GEO.Name = "GEO";
            this.GEO.Size = new System.Drawing.Size(241, 44);
            this.GEO.TabIndex = 24;
            this.GEO.Text = "Start GEO";
            this.GEO.UseVisualStyleBackColor = true;
            this.GEO.Click += new System.EventHandler(this.GEO_Click);
            // 
            // richTextBoxGEO
            // 
            this.richTextBoxGEO.Location = new System.Drawing.Point(780, 15);
            this.richTextBoxGEO.Name = "richTextBoxGEO";
            this.richTextBoxGEO.Size = new System.Drawing.Size(241, 71);
            this.richTextBoxGEO.TabIndex = 25;
            this.richTextBoxGEO.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(987, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Wykres GEO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lpDataGridViewTextBoxColumn
            // 
            this.lpDataGridViewTextBoxColumn.DataPropertyName = "Lp";
            this.lpDataGridViewTextBoxColumn.HeaderText = "Lp";
            this.lpDataGridViewTextBoxColumn.Name = "lpDataGridViewTextBoxColumn";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 620);
            this.Controls.Add(this.richTextBoxGEO);
            this.Controls.Add(this.GEO);
            this.Controls.Add(this.textBoxTau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxEilte);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AlgorytmGenetyczny);
            this.Controls.Add(this.textBoxPm);
            this.Controls.Add(this.textBoxPk);
            this.Controls.Add(this.labelPm);
            this.Controls.Add(this.labelPk);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.Button AlgorytmGenetyczny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.DataGridViewTextBoxColumn lpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xreal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fx;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBoxEilte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTau;
        private System.Windows.Forms.Button GEO;
        private System.Windows.Forms.RichTextBox richTextBoxGEO;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

