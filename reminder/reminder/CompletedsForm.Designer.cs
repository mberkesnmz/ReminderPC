namespace reminder
{
    partial class CompletedsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletedsForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closebutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.completedlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Gray;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.HasFormShadow = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 592);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // closebutton
            // 
            this.closebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closebutton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closebutton.HoverState.ImageSize = new System.Drawing.Size(34, 30);
            this.closebutton.Image = ((System.Drawing.Image)(resources.GetObject("closebutton.Image")));
            this.closebutton.ImageOffset = new System.Drawing.Point(0, 0);
            this.closebutton.ImageRotate = 0F;
            this.closebutton.ImageSize = new System.Drawing.Size(20, 20);
            this.closebutton.Location = new System.Drawing.Point(350, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closebutton.Size = new System.Drawing.Size(34, 30);
            this.closebutton.TabIndex = 4;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // completedlbl
            // 
            this.completedlbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.completedlbl.Font = new System.Drawing.Font("Ballega", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.completedlbl.Location = new System.Drawing.Point(111, 9);
            this.completedlbl.Name = "completedlbl";
            this.completedlbl.Size = new System.Drawing.Size(155, 19);
            this.completedlbl.TabIndex = 8;
            this.completedlbl.Text = "Completed Tasks";
            // 
            // CompletedsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.completedlbl);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompletedsForm";
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.AddReminderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton closebutton;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label completedlbl;
    }
}

