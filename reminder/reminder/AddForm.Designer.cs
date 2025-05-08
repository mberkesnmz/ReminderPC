namespace reminder
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.timePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.closebutton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
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
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.BackColor = System.Drawing.Color.Transparent;
            this.datePicker.BorderRadius = 5;
            this.datePicker.BorderThickness = 1;
            this.datePicker.FillColor = System.Drawing.Color.Gainsboro;
            this.datePicker.Font = new System.Drawing.Font("LEMON MILK Medium", 7.25F, System.Drawing.FontStyle.Bold);
            this.datePicker.ForeColor = System.Drawing.Color.Black;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.Location = new System.Drawing.Point(34, 224);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShadowDecoration.BorderRadius = 0;
            this.datePicker.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.datePicker.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.datePicker.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.datePicker.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.datePicker.ShadowDecoration.Depth = 0;
            this.datePicker.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.datePicker.Size = new System.Drawing.Size(199, 45);
            this.datePicker.TabIndex = 1;
            this.datePicker.UseTransparentBackground = true;
            this.datePicker.Value = new System.DateTime(2025, 4, 30, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Black;
            this.btnAdd.FillColor2 = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Ballega", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(34, 496);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(304, 53);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+ Create Reminder";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.Location = new System.Drawing.Point(34, 131);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Title...";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(304, 48);
            this.txtTitle.TabIndex = 3;
            // 
            // timePicker
            // 
            this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePicker.BackColor = System.Drawing.Color.Transparent;
            this.timePicker.BorderRadius = 5;
            this.timePicker.BorderThickness = 1;
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.FillColor = System.Drawing.Color.Gainsboro;
            this.timePicker.FocusedColor = System.Drawing.Color.Transparent;
            this.timePicker.Font = new System.Drawing.Font("LEMON MILK Medium", 7.25F, System.Drawing.FontStyle.Bold);
            this.timePicker.ForeColor = System.Drawing.Color.Black;
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(251, 224);
            this.timePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShadowDecoration.BorderRadius = 0;
            this.timePicker.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.timePicker.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.timePicker.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.timePicker.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.timePicker.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.timePicker.ShadowDecoration.Depth = 0;
            this.timePicker.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(87, 45);
            this.timePicker.TabIndex = 4;
            this.timePicker.UseTransparentBackground = true;
            this.timePicker.Value = new System.DateTime(2025, 4, 30, 0, 0, 0, 0);
            // 
            // txtDescription
            // 
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescription.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(34, 316);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Description...";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(304, 85);
            this.txtDescription.TabIndex = 5;
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
            this.closebutton.Location = new System.Drawing.Point(351, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closebutton.Size = new System.Drawing.Size(34, 30);
            this.closebutton.TabIndex = 6;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ballega", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "New Reminder";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(384, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2DateTimePicker timePicker;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2ImageButton closebutton;
        private System.Windows.Forms.Label label1;
    }
}

