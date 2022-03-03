
namespace Atm
{
    partial class Deposite
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
            System.Windows.Forms.Button btnBack;
            System.Windows.Forms.Button btnDeposite;
            System.Windows.Forms.Label label1;
            this.txtDepositeAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            btnDeposite = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(347, 161);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(114, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeposite
            // 
            btnDeposite.Location = new System.Drawing.Point(229, 161);
            btnDeposite.Name = "btnDeposite";
            btnDeposite.Size = new System.Drawing.Size(112, 23);
            btnDeposite.TabIndex = 6;
            btnDeposite.Text = "Deposite";
            btnDeposite.UseVisualStyleBackColor = true;
            btnDeposite.Click += new System.EventHandler(this.btnDeposite_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(226, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 13);
            label1.TabIndex = 4;
            label1.Text = "Enter Amount";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDepositeAmount
            // 
            this.txtDepositeAmount.Location = new System.Drawing.Point(347, 92);
            this.txtDepositeAmount.Name = "txtDepositeAmount";
            this.txtDepositeAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDepositeAmount.TabIndex = 8;
            this.txtDepositeAmount.TextChanged += new System.EventHandler(this.txtDepositeAmount_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(223, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "Deposite Amount";
            // 
            // Deposite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepositeAmount);
            this.Controls.Add(btnBack);
            this.Controls.Add(btnDeposite);
            this.Controls.Add(label1);
            this.Name = "Deposite";
            this.Text = "Deposite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepositeAmount;
        private System.Windows.Forms.Label label3;
    }
}