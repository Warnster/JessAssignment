
namespace JessAssignment
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.directorTB = new System.Windows.Forms.TextBox();
            this.certTB = new System.Windows.Forms.TextBox();
            this.formatTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.yorDTP = new System.Windows.Forms.DateTimePicker();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.jessAssignmentDataSet1 = new JessAssignment.JessAssignmentDataSet();
            this.itemsTableAdapter1 = new JessAssignment.JessAssignmentDataSetTableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.jessAssignmentDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item";
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(424, 157);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(526, 38);
            this.titleTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Year of Release";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Certificate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Director";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Title";
            // 
            // directorTB
            // 
            this.directorTB.Location = new System.Drawing.Point(424, 298);
            this.directorTB.Name = "directorTB";
            this.directorTB.Size = new System.Drawing.Size(526, 38);
            this.directorTB.TabIndex = 7;
            this.directorTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // certTB
            // 
            this.certTB.Location = new System.Drawing.Point(424, 425);
            this.certTB.Name = "certTB";
            this.certTB.Size = new System.Drawing.Size(526, 38);
            this.certTB.TabIndex = 10;
            // 
            // formatTB
            // 
            this.formatTB.Location = new System.Drawing.Point(424, 778);
            this.formatTB.Name = "formatTB";
            this.formatTB.Size = new System.Drawing.Size(526, 38);
            this.formatTB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 725);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Format";
            // 
            // yorDTP
            // 
            this.yorDTP.Location = new System.Drawing.Point(424, 542);
            this.yorDTP.Name = "yorDTP";
            this.yorDTP.Size = new System.Drawing.Size(200, 38);
            this.yorDTP.TabIndex = 13;
            this.yorDTP.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(424, 662);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(526, 38);
            this.priceTB.TabIndex = 14;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(610, 867);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(154, 64);
            this.submitBtn.TabIndex = 15;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // jessAssignmentDataSet1
            // 
            this.jessAssignmentDataSet1.DataSetName = "JessAssignmentDataSet";
            this.jessAssignmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter1
            // 
            this.itemsTableAdapter1.ClearBeforeFill = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 954);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.yorDTP);
            this.Controls.Add(this.formatTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.certTB);
            this.Controls.Add(this.directorTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleTB);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            ((System.ComponentModel.ISupportInitialize)(this.jessAssignmentDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox directorTB;
        private System.Windows.Forms.TextBox certTB;
        private System.Windows.Forms.TextBox formatTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker yorDTP;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Button submitBtn;
        private JessAssignmentDataSet jessAssignmentDataSet1;
        private JessAssignmentDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter1;
    }
}