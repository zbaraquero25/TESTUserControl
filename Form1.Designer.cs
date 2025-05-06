namespace TEST
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
            btnBulletin = new Button();
            btnConsultation = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelActFeed = new Panel();
            label1 = new Label();
            button1 = new Button();
            panelActFeed.SuspendLayout();
            SuspendLayout();
            // 
            // btnBulletin
            // 
            btnBulletin.Location = new Point(152, 13);
            btnBulletin.Name = "btnBulletin";
            btnBulletin.Size = new Size(104, 23);
            btnBulletin.TabIndex = 0;
            btnBulletin.Text = "Bulletin";
            btnBulletin.UseVisualStyleBackColor = true;
            btnBulletin.Click += btnBulletin_Click;
            // 
            // btnConsultation
            // 
            btnConsultation.Location = new Point(273, 13);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(104, 23);
            btnConsultation.TabIndex = 1;
            btnConsultation.Text = "Consultation";
            btnConsultation.UseVisualStyleBackColor = true;
            btnConsultation.Click += btnConsultation_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(17, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(360, 480);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panelActFeed
            // 
            panelActFeed.BorderStyle = BorderStyle.FixedSingle;
            panelActFeed.Controls.Add(label1);
            panelActFeed.Controls.Add(btnBulletin);
            panelActFeed.Controls.Add(flowLayoutPanel1);
            panelActFeed.Controls.Add(btnConsultation);
            panelActFeed.Location = new Point(29, 24);
            panelActFeed.Name = "panelActFeed";
            panelActFeed.Size = new Size(398, 545);
            panelActFeed.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 13);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 3;
            label1.Text = "Activity Feed";
            // 
            // button1
            // 
            button1.Location = new Point(551, 230);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 598);
            Controls.Add(button1);
            Controls.Add(panelActFeed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panelActFeed.ResumeLayout(false);
            panelActFeed.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBulletin;
        private Button btnConsultation;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelActFeed;
        private Label label1;
        private Button button1;
    }
}
