namespace StarCraft
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            btn_Starcraft = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_Starcraft
            // 
            btn_Starcraft.Image = (System.Drawing.Image)resources.GetObject("btn_Starcraft.Image");
            btn_Starcraft.Location = new System.Drawing.Point(10, 10);
            btn_Starcraft.Name = "btn_Starcraft";
            btn_Starcraft.Size = new System.Drawing.Size(150, 150);
            btn_Starcraft.TabIndex = 0;
            btn_Starcraft.UseVisualStyleBackColor = true;
            btn_Starcraft.Click += btn_Starcraft_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(169, 171);
            Controls.Add(btn_Starcraft);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_Starcraft;
    }
}