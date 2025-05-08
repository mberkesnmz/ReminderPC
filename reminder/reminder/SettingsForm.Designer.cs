namespace reminder
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.closebutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.settingslbl = new System.Windows.Forms.Label();
            this.flowLayoutPanelThemes = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeNotificationSound = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnUseDefaultSound = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblNotificationSound = new System.Windows.Forms.Label();
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
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click_1);
            // 
            // settingslbl
            // 
            this.settingslbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingslbl.Font = new System.Drawing.Font("Ballega", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.settingslbl.Location = new System.Drawing.Point(117, 9);
            this.settingslbl.Name = "settingslbl";
            this.settingslbl.Size = new System.Drawing.Size(141, 38);
            this.settingslbl.TabIndex = 8;
            this.settingslbl.Text = "Settings";
            // 
            // flowLayoutPanelThemes
            // 
            this.flowLayoutPanelThemes.Location = new System.Drawing.Point(36, 129);
            this.flowLayoutPanelThemes.Name = "flowLayoutPanelThemes";
            this.flowLayoutPanelThemes.Size = new System.Drawing.Size(317, 190);
            this.flowLayoutPanelThemes.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ballega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Change Theme";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ballega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Change Notification Sound";
            // 
            // btnChangeNotificationSound
            // 
            this.btnChangeNotificationSound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeNotificationSound.BorderRadius = 15;
            this.btnChangeNotificationSound.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeNotificationSound.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeNotificationSound.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeNotificationSound.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeNotificationSound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeNotificationSound.FillColor = System.Drawing.Color.Black;
            this.btnChangeNotificationSound.FillColor2 = System.Drawing.Color.Black;
            this.btnChangeNotificationSound.Font = new System.Drawing.Font("Ballega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeNotificationSound.ForeColor = System.Drawing.Color.White;
            this.btnChangeNotificationSound.Location = new System.Drawing.Point(35, 436);
            this.btnChangeNotificationSound.Name = "btnChangeNotificationSound";
            this.btnChangeNotificationSound.Size = new System.Drawing.Size(164, 39);
            this.btnChangeNotificationSound.TabIndex = 13;
            this.btnChangeNotificationSound.Text = "Change Sound";
            this.btnChangeNotificationSound.Click += new System.EventHandler(this.btnChangeNotificationSound_Click);
            // 
            // btnUseDefaultSound
            // 
            this.btnUseDefaultSound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUseDefaultSound.BorderRadius = 15;
            this.btnUseDefaultSound.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUseDefaultSound.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUseDefaultSound.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUseDefaultSound.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUseDefaultSound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUseDefaultSound.FillColor = System.Drawing.Color.Black;
            this.btnUseDefaultSound.FillColor2 = System.Drawing.Color.Black;
            this.btnUseDefaultSound.Font = new System.Drawing.Font("Ballega", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUseDefaultSound.ForeColor = System.Drawing.Color.White;
            this.btnUseDefaultSound.Location = new System.Drawing.Point(36, 481);
            this.btnUseDefaultSound.Name = "btnUseDefaultSound";
            this.btnUseDefaultSound.Size = new System.Drawing.Size(105, 30);
            this.btnUseDefaultSound.TabIndex = 14;
            this.btnUseDefaultSound.Text = "Use Default";
            this.btnUseDefaultSound.Click += new System.EventHandler(this.btnUseDefaultSound_Click);
            // 
            // lblNotificationSound
            // 
            this.lblNotificationSound.AutoSize = true;
            this.lblNotificationSound.BackColor = System.Drawing.Color.Transparent;
            this.lblNotificationSound.Font = new System.Drawing.Font("Ballega", 8F);
            this.lblNotificationSound.Location = new System.Drawing.Point(32, 410);
            this.lblNotificationSound.Name = "lblNotificationSound";
            this.lblNotificationSound.Size = new System.Drawing.Size(44, 14);
            this.lblNotificationSound.TabIndex = 15;
            this.lblNotificationSound.Text = "label3";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.lblNotificationSound);
            this.Controls.Add(this.btnUseDefaultSound);
            this.Controls.Add(this.btnChangeNotificationSound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelThemes);
            this.Controls.Add(this.settingslbl);
            this.Controls.Add(this.closebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton closebutton;
        private System.Windows.Forms.Label settingslbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelThemes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnUseDefaultSound;
        private Guna.UI2.WinForms.Guna2GradientButton btnChangeNotificationSound;
        private System.Windows.Forms.Label lblNotificationSound;
    }
}

