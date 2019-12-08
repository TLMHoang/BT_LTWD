namespace bai28
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picOff = new System.Windows.Forms.PictureBox();
            this.picOn = new System.Windows.Forms.PictureBox();
            this.btnTurnOrOff = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(49, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // picOff
            // 
            this.picOff.Image = global::bai28.Properties.Resources.light_off;
            this.picOff.Location = new System.Drawing.Point(49, 48);
            this.picOff.Name = "picOff";
            this.picOff.Size = new System.Drawing.Size(143, 140);
            this.picOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOff.TabIndex = 2;
            this.picOff.TabStop = false;
            // 
            // picOn
            // 
            this.picOn.Image = global::bai28.Properties.Resources.light_on;
            this.picOn.Location = new System.Drawing.Point(49, 48);
            this.picOn.Name = "picOn";
            this.picOn.Size = new System.Drawing.Size(143, 140);
            this.picOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOn.TabIndex = 2;
            this.picOn.TabStop = false;
            this.picOn.Visible = false;
            // 
            // btnTurnOrOff
            // 
            this.btnTurnOrOff.Location = new System.Drawing.Point(24, 207);
            this.btnTurnOrOff.Name = "btnTurnOrOff";
            this.btnTurnOrOff.Size = new System.Drawing.Size(198, 22);
            this.btnTurnOrOff.TabIndex = 3;
            this.btnTurnOrOff.UseVisualStyleBackColor = true;
            this.btnTurnOrOff.Click += new System.EventHandler(this.btnTurnOrOff_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dsigned by:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NCT";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(162, 242);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(60, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát.";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 274);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTurnOrOff);
            this.Controls.Add(this.picOff);
            this.Controls.Add(this.picOn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tắt mở đèn:";
            ((System.ComponentModel.ISupportInitialize)(this.picOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picOn;
        private System.Windows.Forms.PictureBox picOff;
        private System.Windows.Forms.Button btnTurnOrOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
    }
}

