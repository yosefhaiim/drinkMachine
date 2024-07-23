namespace drinkMachine
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
            this.txtNewDrink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.cmbSugar = new System.Windows.Forms.ComboBox();
            this.cmbCofee = new System.Windows.Forms.ComboBox();
            this.cmbCocoa = new System.Windows.Forms.ComboBox();
            this.cmbMilk = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dgvDrinksTable = new System.Windows.Forms.DataGridView();
            this.coffee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cocoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.milk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewDrink
            // 
            this.txtNewDrink.Location = new System.Drawing.Point(506, 74);
            this.txtNewDrink.Name = "txtNewDrink";
            this.txtNewDrink.Size = new System.Drawing.Size(100, 22);
            this.txtNewDrink.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "חלב";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "סוג שתיה חדש";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(692, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "סוכר";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "קפה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "קקאו";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "מחיר";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(325, 73);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(68, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "יצירה ";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(223, 73);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(46, 152);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(27, 23);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(7, 152);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(24, 23);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // cmbSugar
            // 
            this.cmbSugar.FormattingEnabled = true;
            this.cmbSugar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbSugar.Location = new System.Drawing.Point(667, 151);
            this.cmbSugar.Name = "cmbSugar";
            this.cmbSugar.Size = new System.Drawing.Size(121, 24);
            this.cmbSugar.TabIndex = 12;
            this.cmbSugar.Text = "1";
            // 
            // cmbCofee
            // 
            this.cmbCofee.FormattingEnabled = true;
            this.cmbCofee.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbCofee.Location = new System.Drawing.Point(522, 151);
            this.cmbCofee.Name = "cmbCofee";
            this.cmbCofee.Size = new System.Drawing.Size(121, 24);
            this.cmbCofee.TabIndex = 13;
            this.cmbCofee.Text = "1";
            // 
            // cmbCocoa
            // 
            this.cmbCocoa.FormattingEnabled = true;
            this.cmbCocoa.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbCocoa.Location = new System.Drawing.Point(371, 151);
            this.cmbCocoa.Name = "cmbCocoa";
            this.cmbCocoa.Size = new System.Drawing.Size(121, 24);
            this.cmbCocoa.TabIndex = 14;
            this.cmbCocoa.Text = "1";
            // 
            // cmbMilk
            // 
            this.cmbMilk.FormattingEnabled = true;
            this.cmbMilk.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbMilk.Location = new System.Drawing.Point(233, 151);
            this.cmbMilk.Name = "cmbMilk";
            this.cmbMilk.Size = new System.Drawing.Size(121, 24);
            this.cmbMilk.TabIndex = 15;
            this.cmbMilk.Text = "1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(411, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "עדכון";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(108, 153);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 18;
            this.txtPrice.Text = "0";
            // 
            // dgvDrinksTable
            // 
            this.dgvDrinksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrinksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coffee,
            this.sugar,
            this.cocoa,
            this.milk,
            this.price,
            this.name});
            this.dgvDrinksTable.Location = new System.Drawing.Point(7, 230);
            this.dgvDrinksTable.Name = "dgvDrinksTable";
            this.dgvDrinksTable.RowHeadersWidth = 51;
            this.dgvDrinksTable.RowTemplate.Height = 24;
            this.dgvDrinksTable.Size = new System.Drawing.Size(787, 228);
            this.dgvDrinksTable.TabIndex = 19;
            // 
            // coffee
            // 
            this.coffee.HeaderText = "קפה";
            this.coffee.MinimumWidth = 6;
            this.coffee.Name = "coffee";
            this.coffee.Width = 125;
            // 
            // sugar
            // 
            this.sugar.HeaderText = "סוכר";
            this.sugar.MinimumWidth = 6;
            this.sugar.Name = "sugar";
            this.sugar.Width = 125;
            // 
            // cocoa
            // 
            this.cocoa.HeaderText = "קקאו";
            this.cocoa.MinimumWidth = 6;
            this.cocoa.Name = "cocoa";
            this.cocoa.Width = 125;
            // 
            // milk
            // 
            this.milk.HeaderText = "חלב";
            this.milk.MinimumWidth = 6;
            this.milk.Name = "milk";
            this.milk.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "מחיר";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // name
            // 
            this.name.HeaderText = "שם";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvDrinksTable);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbMilk);
            this.Controls.Add(this.cmbCocoa);
            this.Controls.Add(this.cmbCofee);
            this.Controls.Add(this.cmbSugar);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewDrink);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrinksTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.ComboBox cmbSugar;
        private System.Windows.Forms.ComboBox cmbCofee;
        private System.Windows.Forms.ComboBox cmbCocoa;
        private System.Windows.Forms.ComboBox cmbMilk;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvDrinksTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffee;
        private System.Windows.Forms.DataGridViewTextBoxColumn sugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cocoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn milk;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btnDelete;
    }
}

