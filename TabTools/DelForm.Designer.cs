namespace TabTools
{
    partial class DelForm
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.confirm_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeBtn = new Custom_Button.FlatBtn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.topPanel.Controls.Add(this.confirm_Btn);
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(325, 42);
            this.topPanel.TabIndex = 0;
            // 
            // confirm_Btn
            // 
            this.confirm_Btn.Active = false;
            this.confirm_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.confirm_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.confirm_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirm_Btn.BorderRadius = 0;
            this.confirm_Btn.ButtonText = " Confirm";
            this.confirm_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.confirm_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.confirm_Btn.Iconimage = null;
            this.confirm_Btn.Iconimage_right = null;
            this.confirm_Btn.Iconimage_right_Selected = null;
            this.confirm_Btn.Iconimage_Selected = null;
            this.confirm_Btn.IconMarginLeft = 0;
            this.confirm_Btn.IconMarginRight = 0;
            this.confirm_Btn.IconRightVisible = true;
            this.confirm_Btn.IconRightZoom = 0D;
            this.confirm_Btn.IconVisible = true;
            this.confirm_Btn.IconZoom = 90D;
            this.confirm_Btn.IsTab = false;
            this.confirm_Btn.Location = new System.Drawing.Point(223, 10);
            this.confirm_Btn.Name = "confirm_Btn";
            this.confirm_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.confirm_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.confirm_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.confirm_Btn.selected = false;
            this.confirm_Btn.Size = new System.Drawing.Size(61, 25);
            this.confirm_Btn.TabIndex = 1;
            this.confirm_Btn.Text = " Confirm";
            this.confirm_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirm_Btn.Textcolor = System.Drawing.Color.White;
            this.confirm_Btn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_Btn.Click += new System.EventHandler(this.confirm_Btn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(12, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(103, 21);
            this.title.TabIndex = 10;
            this.title.Text = "Select items";
            // 
            // closeBtn
            // 
            this.closeBtn.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBtn.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBtn.Location = new System.Drawing.Point(293, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 21);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "close";
            this.closeBtn.TextButton = "x";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.topPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(325, 71);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DelForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private Custom_Button.FlatBtn closeBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.Framework.UI.BunifuFlatButton confirm_Btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}