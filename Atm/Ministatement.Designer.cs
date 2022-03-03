
namespace Atm
{
    partial class Ministatement
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
            this.dataGridMinistmt = new System.Windows.Forms.DataGridView();
            this.btnMiniStmt = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMinistmt)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mini-Statement";
            // 
            // dataGridMinistmt
            // 
            this.dataGridMinistmt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMinistmt.Location = new System.Drawing.Point(88, 150);
            this.dataGridMinistmt.Name = "dataGridMinistmt";
            this.dataGridMinistmt.Size = new System.Drawing.Size(623, 288);
            this.dataGridMinistmt.TabIndex = 1;
            // 
            // btnMiniStmt
            // 
            this.btnMiniStmt.Location = new System.Drawing.Point(220, 98);
            this.btnMiniStmt.Name = "btnMiniStmt";
            this.btnMiniStmt.Size = new System.Drawing.Size(75, 23);
            this.btnMiniStmt.TabIndex = 2;
            this.btnMiniStmt.Text = "Mini Statement";
            this.btnMiniStmt.UseVisualStyleBackColor = true;
            this.btnMiniStmt.Click += new System.EventHandler(this.btnMiniStmt_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(636, 98);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mini-Statement";
            // 
            // Ministatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMiniStmt);
            this.Controls.Add(this.dataGridMinistmt);
            this.Controls.Add(this.label1);
            this.Name = "Ministatement";
            this.Text = "Ministatement";
            this.Load += new System.EventHandler(this.Ministatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMinistmt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMinistmt;
        private System.Windows.Forms.Button btnMiniStmt;
        public System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
    }
}