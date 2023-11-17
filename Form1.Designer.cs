namespace StarCraft
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            btn_Zerg = new System.Windows.Forms.Button();
            btn_Protoss = new System.Windows.Forms.Button();
            btn_Terran = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("돋움체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(235, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 19);
            label1.TabIndex = 0;
            label1.Text = "종족 선택";
            // 
            // btn_Zerg
            // 
            btn_Zerg.Image = (System.Drawing.Image)resources.GetObject("btn_Zerg.Image");
            btn_Zerg.Location = new System.Drawing.Point(30, 70);
            btn_Zerg.Name = "btn_Zerg";
            btn_Zerg.Size = new System.Drawing.Size(150, 150);
            btn_Zerg.TabIndex = 1;
            btn_Zerg.UseVisualStyleBackColor = true;
            btn_Zerg.Click += btn_Zerg_Click;
            // 
            // btn_Protoss
            // 
            btn_Protoss.Image = (System.Drawing.Image)resources.GetObject("btn_Protoss.Image");
            btn_Protoss.Location = new System.Drawing.Point(210, 70);
            btn_Protoss.Name = "btn_Protoss";
            btn_Protoss.Size = new System.Drawing.Size(150, 150);
            btn_Protoss.TabIndex = 2;
            btn_Protoss.UseVisualStyleBackColor = true;
            btn_Protoss.Click += btn_Protoss_Click;
            // 
            // btn_Terran
            // 
            btn_Terran.Image = (System.Drawing.Image)resources.GetObject("btn_Terran.Image");
            btn_Terran.Location = new System.Drawing.Point(390, 70);
            btn_Terran.Name = "btn_Terran";
            btn_Terran.Size = new System.Drawing.Size(150, 150);
            btn_Terran.TabIndex = 3;
            btn_Terran.UseVisualStyleBackColor = true;
            btn_Terran.Click += btn_Terran_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Control;
            label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(77, 223);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 23);
            label2.TabIndex = 4;
            label2.Text = "Zerg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.SystemColors.Control;
            label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(244, 223);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 23);
            label3.TabIndex = 5;
            label3.Text = "Protoss";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.SystemColors.Control;
            label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(434, 223);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 23);
            label4.TabIndex = 6;
            label4.Text = "Terran";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(569, 263);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btn_Terran);
            Controls.Add(btn_Protoss);
            Controls.Add(btn_Zerg);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Zerg;
        private System.Windows.Forms.Button btn_Protoss;
        private System.Windows.Forms.Button btn_Terran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
