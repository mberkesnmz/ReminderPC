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
            this.changesoundpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanelThemes = new System.Windows.Forms.FlowLayoutPanel();
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
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // settingslbl
            // 
            this.settingslbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingslbl.Font = new System.Drawing.Font("Ballega", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.settingslbl.Location = new System.Drawing.Point(147, 9);
            this.settingslbl.Name = "settingslbl";
            this.settingslbl.Size = new System.Drawing.Size(90, 20);
            this.settingslbl.TabIndex = 8;
            this.settingslbl.Text = "Settings";
            // 
            // changesoundpanel
            // 
            this.changesoundpanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.changesoundpanel.BorderThickness = 2;
            this.changesoundpanel.Location = new System.Drawing.Point(12, 380);
            this.changesoundpanel.Name = "changesoundpanel";
            this.changesoundpanel.Size = new System.Drawing.Size(360, 150);
            this.changesoundpanel.TabIndex = 9;
            // 
            // flowLayoutPanelThemes
            // 
            this.flowLayoutPanelThemes.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutPanelThemes.Name = "flowLayoutPanelThemes";
            this.flowLayoutPanelThemes.Size = new System.Drawing.Size(360, 230);
            this.flowLayoutPanelThemes.TabIndex = 10;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.flowLayoutPanelThemes);
            this.Controls.Add(this.changesoundpanel);
            this.Controls.Add(this.settingslbl);
            this.Controls.Add(this.closebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton closebutton;
        private System.Windows.Forms.Label settingslbl;
        private Guna.UI2.WinForms.Guna2Panel changesoundpanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelThemes;
    }
}

