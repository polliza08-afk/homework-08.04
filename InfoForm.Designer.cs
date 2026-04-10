namespace Pasxa
{
    partial class InfoForm
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
            panel1 = new Panel();
            pbImage = new PictureBox();
            trbZoom = new TrackBar();
            lblName = new Label();
            lblWeight = new Label();
            lblProducer = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbZoom).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pbImage);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 273);
            panel1.TabIndex = 0;
            // 
            // pbImage
            // 
            pbImage.Location = new Point(52, 67);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(183, 126);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // trbZoom
            // 
            trbZoom.Location = new Point(12, 304);
            trbZoom.Name = "trbZoom";
            trbZoom.Size = new Size(180, 45);
            trbZoom.TabIndex = 1;
            trbZoom.Scroll += trbZoom_Scroll;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblName.Location = new Point(402, 68);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 25);
            lblName.TabIndex = 2;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblWeight.Location = new Point(402, 148);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(0, 25);
            lblWeight.TabIndex = 2;
            // 
            // lblProducer
            // 
            lblProducer.AutoSize = true;
            lblProducer.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblProducer.Location = new Point(402, 231);
            lblProducer.Name = "lblProducer";
            lblProducer.Size = new Size(0, 25);
            lblProducer.TabIndex = 2;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 359);
            Controls.Add(lblProducer);
            Controls.Add(lblWeight);
            Controls.Add(lblName);
            Controls.Add(trbZoom);
            Controls.Add(panel1);
            Name = "InfoForm";
            Text = "InfoForm";
            Load += InfoForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbZoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pbImage;
        private TrackBar trbZoom;
        private Label lblName;
        private Label lblWeight;
        private Label lblProducer;
    }
}