namespace reminder
{
    partial class AddReminderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddReminderForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenAddForm = new Guna.UI2.WinForms.Guna2GradientButton();
            this.reminderTimer = new System.Windows.Forms.Timer(this.components);
            this.completedsbutton = new Guna.UI2.WinForms.Guna2Button();
            this.settingsbutton = new Guna.UI2.WinForms.Guna2Button();
            this.closebutton = new Guna.UI2.WinForms.Guna2ImageButton();
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 498);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnOpenAddForm
            // 
            this.btnOpenAddForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenAddForm.BorderRadius = 20;
            this.btnOpenAddForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenAddForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOpenAddForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenAddForm.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOpenAddForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenAddForm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(235)))), ((int)(((byte)(157)))));
            this.btnOpenAddForm.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btnOpenAddForm.Font = new System.Drawing.Font("Ballega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAddForm.ForeColor = System.Drawing.Color.White;
            this.btnOpenAddForm.Location = new System.Drawing.Point(12, 586);
            this.btnOpenAddForm.Name = "btnOpenAddForm";
            this.btnOpenAddForm.Size = new System.Drawing.Size(360, 52);
            this.btnOpenAddForm.TabIndex = 0;
            this.btnOpenAddForm.Text = "+ Add Reminder";
            this.btnOpenAddForm.Click += new System.EventHandler(this.btnOpenAddForm_Click);
            // 
            // completedsbutton
            // 
            this.completedsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.completedsbutton.BackColor = System.Drawing.Color.Transparent;
            this.completedsbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.completedsbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.completedsbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.completedsbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.completedsbutton.FillColor = System.Drawing.Color.Transparent;
            this.completedsbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.completedsbutton.ForeColor = System.Drawing.Color.Transparent;
            this.completedsbutton.Image = global::reminder.Properties.Resources.checkmark;
            this.completedsbutton.ImageSize = new System.Drawing.Size(32, 32);
            this.completedsbutton.Location = new System.Drawing.Point(177, 21);
            this.completedsbutton.Name = "completedsbutton";
            this.completedsbutton.Size = new System.Drawing.Size(30, 40);
            this.completedsbutton.TabIndex = 8;
            this.completedsbutton.UseTransparentBackground = true;
            this.completedsbutton.Click += new System.EventHandler(this.completedsbutton_Click);
            // 
            // settingsbutton
            // 
            this.settingsbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsbutton.FillColor = System.Drawing.Color.Transparent;
            this.settingsbutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsbutton.ForeColor = System.Drawing.Color.White;
            this.settingsbutton.Image = global::reminder.Properties.Resources.settings;
            this.settingsbutton.Location = new System.Drawing.Point(0, 0);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.Size = new System.Drawing.Size(33, 31);
            this.settingsbutton.TabIndex = 7;
            this.settingsbutton.Click += new System.EventHandler(this.settingsbutton_Click);
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
            // AddReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.completedsbutton);
            this.Controls.Add(this.settingsbutton);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnOpenAddForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddReminderForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddReminderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2GradientButton btnOpenAddForm;
        private System.Windows.Forms.Timer reminderTimer;
        private Guna.UI2.WinForms.Guna2ImageButton closebutton;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button settingsbutton;
        private Guna.UI2.WinForms.Guna2Button completedsbutton;
    }
}

