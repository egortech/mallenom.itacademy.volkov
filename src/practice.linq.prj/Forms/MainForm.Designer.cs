namespace Practice.Linq.Forms
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._maximumNumBox = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this._processBtn = new System.Windows.Forms.Button();
			this._generateBtn = new System.Windows.Forms.Button();
			this._countNumBox = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this._ownImplRadioBtn = new System.Windows.Forms.RadioButton();
			this._linqImplRadioBtn = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this._generatedItemsListBox = new System.Windows.Forms.ListBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this._processedItemsListBox = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._maximumNumBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._countNumBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this._maximumNumBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this._processBtn);
			this.groupBox1.Controls.Add(this._generateBtn);
			this.groupBox1.Controls.Add(this._countNumBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(10, 120);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(793, 129);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Работа с элементами";
			// 
			// _maximumNumBox
			// 
			this._maximumNumBox.Location = new System.Drawing.Point(193, 48);
			this._maximumNumBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this._maximumNumBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._maximumNumBox.Name = "_maximumNumBox";
			this._maximumNumBox.Size = new System.Drawing.Size(120, 22);
			this._maximumNumBox.TabIndex = 5;
			this._maximumNumBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Максимум:";
			// 
			// _processBtn
			// 
			this._processBtn.Enabled = false;
			this._processBtn.Location = new System.Drawing.Point(172, 79);
			this._processBtn.Name = "_processBtn";
			this._processBtn.Size = new System.Drawing.Size(138, 29);
			this._processBtn.TabIndex = 3;
			this._processBtn.Text = "Обработать";
			this._processBtn.UseVisualStyleBackColor = true;
			// 
			// _generateBtn
			// 
			this._generateBtn.Location = new System.Drawing.Point(23, 79);
			this._generateBtn.Name = "_generateBtn";
			this._generateBtn.Size = new System.Drawing.Size(138, 29);
			this._generateBtn.TabIndex = 2;
			this._generateBtn.Text = "Генерировать";
			this._generateBtn.UseVisualStyleBackColor = true;
			// 
			// _countNumBox
			// 
			this._countNumBox.Location = new System.Drawing.Point(193, 21);
			this._countNumBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
			this._countNumBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this._countNumBox.Name = "_countNumBox";
			this._countNumBox.Size = new System.Drawing.Size(120, 22);
			this._countNumBox.TabIndex = 1;
			this._countNumBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Количество элементов:";
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.Controls.Add(this._ownImplRadioBtn);
			this.groupBox2.Controls.Add(this._linqImplRadioBtn);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(10, 10);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(793, 90);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Реализация";
			// 
			// _ownImplRadioBtn
			// 
			this._ownImplRadioBtn.AutoSize = true;
			this._ownImplRadioBtn.Location = new System.Drawing.Point(26, 48);
			this._ownImplRadioBtn.Name = "_ownImplRadioBtn";
			this._ownImplRadioBtn.Size = new System.Drawing.Size(268, 21);
			this._ownImplRadioBtn.TabIndex = 4;
			this._ownImplRadioBtn.TabStop = true;
			this._ownImplRadioBtn.Text = "На основе собственной реализации";
			this._ownImplRadioBtn.UseVisualStyleBackColor = true;
			// 
			// _linqImplRadioBtn
			// 
			this._linqImplRadioBtn.AutoSize = true;
			this._linqImplRadioBtn.Location = new System.Drawing.Point(26, 21);
			this._linqImplRadioBtn.Name = "_linqImplRadioBtn";
			this._linqImplRadioBtn.Size = new System.Drawing.Size(135, 21);
			this._linqImplRadioBtn.TabIndex = 3;
			this._linqImplRadioBtn.TabStop = true;
			this._linqImplRadioBtn.Text = "Используя LINQ";
			this._linqImplRadioBtn.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 262);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 185);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// groupBox3
			// 
			this.groupBox3.AutoSize = true;
			this.groupBox3.Controls.Add(this._generatedItemsListBox);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Padding = new System.Windows.Forms.Padding(10);
			this.groupBox3.Size = new System.Drawing.Size(397, 179);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Сгенерированные элементы";
			// 
			// _generatedItemsListBox
			// 
			this._generatedItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._generatedItemsListBox.FormattingEnabled = true;
			this._generatedItemsListBox.ItemHeight = 16;
			this._generatedItemsListBox.Location = new System.Drawing.Point(10, 25);
			this._generatedItemsListBox.Margin = new System.Windows.Forms.Padding(10);
			this._generatedItemsListBox.Name = "_generatedItemsListBox";
			this._generatedItemsListBox.Size = new System.Drawing.Size(377, 144);
			this._generatedItemsListBox.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.AutoSize = true;
			this.groupBox4.Controls.Add(this._processedItemsListBox);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(406, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
			this.groupBox4.Size = new System.Drawing.Size(398, 179);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Обработанные элементы";
			// 
			// _processedItemsListBox
			// 
			this._processedItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._processedItemsListBox.FormattingEnabled = true;
			this._processedItemsListBox.ItemHeight = 16;
			this._processedItemsListBox.Location = new System.Drawing.Point(10, 25);
			this._processedItemsListBox.Margin = new System.Windows.Forms.Padding(10);
			this._processedItemsListBox.Name = "_processedItemsListBox";
			this._processedItemsListBox.Size = new System.Drawing.Size(378, 144);
			this._processedItemsListBox.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 2);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(813, 450);
			this.tableLayoutPanel2.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(813, 450);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "MainForm";
			this.Text = "Задание на тему LINQ (Волков Е.О.)";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this._maximumNumBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._countNumBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown _countNumBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button _generateBtn;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton _ownImplRadioBtn;
		private System.Windows.Forms.RadioButton _linqImplRadioBtn;
		private System.Windows.Forms.Button _processBtn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ListBox _generatedItemsListBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListBox _processedItemsListBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.NumericUpDown _maximumNumBox;
		private System.Windows.Forms.Label label2;
	}
}

