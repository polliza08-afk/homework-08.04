namespace Pasxa
{
    partial class MainForm
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
            lvPasxy = new ListView();
            label1 = new Label();
            SuspendLayout();
            // 
            // lvPasxy
            // 
            lvPasxy.Alignment = ListViewAlignment.Default;
            lvPasxy.Location = new Point(12, 78);
            lvPasxy.Name = "lvPasxy";
            lvPasxy.Size = new Size(683, 360);
            lvPasxy.TabIndex = 0;
            lvPasxy.UseCompatibleStateImageBehavior = false;
            lvPasxy.MouseDoubleClick += lvPasxy_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(222, 25);
            label1.Name = "label1";
            label1.Size = new Size(225, 30);
            label1.TabIndex = 1;
            label1.Text = "Підготовка до пасхи";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 450);
            Controls.Add(label1);
            Controls.Add(lvPasxy);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvPasxy;
        private Label label1;
    }
}
