namespace TabTools
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeBtn = new Custom_Button.FlatBtn();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.add_Btn = new Custom_Button.FlatBtn();
            this.name_Box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.path_Box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.topPanel.Controls.Add(this.title);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(396, 42);
            this.topPanel.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(13, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(90, 21);
            this.title.TabIndex = 8;
            this.title.Text = "Add items";
            // 
            // closeBtn
            // 
            this.closeBtn.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBtn.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.closeBtn.Location = new System.Drawing.Point(363, 10);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(20, 21);
            this.closeBtn.TabIndex = 8;
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
            // add_Btn
            // 
            this.add_Btn.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.add_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.add_Btn.IdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.add_Btn.Location = new System.Drawing.Point(136, 155);
            this.add_Btn.Name = "add_Btn";
            this.add_Btn.Size = new System.Drawing.Size(131, 35);
            this.add_Btn.TabIndex = 1;
            this.add_Btn.Text = "Add";
            this.add_Btn.TextButton = "Add";
            this.add_Btn.UseVisualStyleBackColor = false;
            this.add_Btn.Click += new System.EventHandler(this.add_Btn_Click);
            // 
            // name_Box
            // 
            this.name_Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.name_Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.name_Box.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.name_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_Box.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name_Box.ForeColor = System.Drawing.Color.White;
            this.name_Box.HintForeColor = System.Drawing.Color.Empty;
            this.name_Box.HintText = "";
            this.name_Box.isPassword = false;
            this.name_Box.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.name_Box.LineIdleColor = System.Drawing.Color.Gray;
            this.name_Box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.name_Box.LineThickness = 3;
            this.name_Box.Location = new System.Drawing.Point(64, 60);
            this.name_Box.Margin = new System.Windows.Forms.Padding(4);
            this.name_Box.MaxLength = 32767;
            this.name_Box.Name = "name_Box";
            this.name_Box.Size = new System.Drawing.Size(276, 33);
            this.name_Box.TabIndex = 2;
            this.name_Box.Text = "Name";
            this.name_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name_Box.Enter += new System.EventHandler(this.name_Box_Enter);
            // 
            // path_Box
            // 
            this.path_Box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.path_Box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.path_Box.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.path_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.path_Box.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.path_Box.ForeColor = System.Drawing.Color.White;
            this.path_Box.HintForeColor = System.Drawing.Color.Empty;
            this.path_Box.HintText = "";
            this.path_Box.isPassword = false;
            this.path_Box.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.path_Box.LineIdleColor = System.Drawing.Color.Gray;
            this.path_Box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.path_Box.LineThickness = 3;
            this.path_Box.Location = new System.Drawing.Point(64, 109);
            this.path_Box.Margin = new System.Windows.Forms.Padding(4);
            this.path_Box.MaxLength = 32767;
            this.path_Box.Name = "path_Box";
            this.path_Box.Size = new System.Drawing.Size(276, 33);
            this.path_Box.TabIndex = 3;
            this.path_Box.Text = "Location";
            this.path_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.path_Box.Enter += new System.EventHandler(this.path_Box_Enter);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(396, 202);
            this.Controls.Add(this.path_Box);
            this.Controls.Add(this.name_Box);
            this.Controls.Add(this.add_Btn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel topPanel;
        private Custom_Button.FlatBtn closeBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel title;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox path_Box;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name_Box;
        private Custom_Button.FlatBtn add_Btn;
    }
}