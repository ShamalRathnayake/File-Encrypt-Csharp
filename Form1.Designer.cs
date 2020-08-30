namespace FileLocker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dropField = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.ListBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar = new FileLocker.NewProgressBar();
            this.tojpgButton = new System.Windows.Forms.Button();
            this.dropField.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropField
            // 
            this.dropField.AllowDrop = true;
            this.dropField.BackColor = System.Drawing.Color.Transparent;
            this.dropField.Controls.Add(this.label2);
            this.dropField.Location = new System.Drawing.Point(12, 39);
            this.dropField.Name = "dropField";
            this.dropField.Size = new System.Drawing.Size(535, 344);
            this.dropField.TabIndex = 0;
            this.dropField.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropField_DragDrop);
            this.dropField.DragEnter += new System.Windows.Forms.DragEventHandler(this.DropField_DragEnter);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drag and Drop Files Here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameField
            // 
            this.nameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(64)))));
            this.nameField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameField.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.ForeColor = System.Drawing.Color.White;
            this.nameField.FormattingEnabled = true;
            this.nameField.ItemHeight = 19;
            this.nameField.Location = new System.Drawing.Point(553, 41);
            this.nameField.Name = "nameField";
            this.nameField.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.nameField.Size = new System.Drawing.Size(361, 342);
            this.nameField.Sorted = true;
            this.nameField.TabIndex = 2;
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(64)))));
            this.encryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.encryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encryptButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptButton.ForeColor = System.Drawing.Color.White;
            this.encryptButton.Location = new System.Drawing.Point(12, 443);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(136, 40);
            this.encryptButton.TabIndex = 3;
            this.encryptButton.Text = "To FRK";
            this.encryptButton.UseVisualStyleBackColor = false;
            this.encryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            this.encryptButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EncryptButton_MouseClick);
            this.encryptButton.MouseEnter += new System.EventHandler(this.EncryptButton_MouseEnter);
            this.encryptButton.MouseLeave += new System.EventHandler(this.EncryptButton_MouseLeave);
            this.encryptButton.MouseHover += new System.EventHandler(this.EncryptButton_MouseHover);
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.decryptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(64)))));
            this.decryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptButton.ForeColor = System.Drawing.Color.White;
            this.decryptButton.Location = new System.Drawing.Point(238, 443);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(136, 40);
            this.decryptButton.TabIndex = 4;
            this.decryptButton.Text = "To MP4";
            this.decryptButton.UseVisualStyleBackColor = false;
            this.decryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            this.decryptButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DecryptButton_MouseClick);
            this.decryptButton.MouseEnter += new System.EventHandler(this.DecryptButton_MouseEnter);
            this.decryptButton.MouseLeave += new System.EventHandler(this.DecryptButton_MouseLeave);
            this.decryptButton.MouseHover += new System.EventHandler(this.DecryptButton_MouseHover);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(64)))));
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(680, 443);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(136, 40);
            this.removeButton.TabIndex = 5;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.removeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoveButton_MouseClick);
            this.removeButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.removeButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            this.removeButton.MouseHover += new System.EventHandler(this.RemoveButton_MouseHover);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(914, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "File Hider";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(874, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 395);
            this.progressBar.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(890, 10);
            this.progressBar.TabIndex = 6;
            // 
            // tojpgButton
            // 
            this.tojpgButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tojpgButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(5)))), ((int)(((byte)(64)))));
            this.tojpgButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tojpgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tojpgButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tojpgButton.ForeColor = System.Drawing.Color.White;
            this.tojpgButton.Location = new System.Drawing.Point(452, 443);
            this.tojpgButton.Name = "tojpgButton";
            this.tojpgButton.Size = new System.Drawing.Size(136, 40);
            this.tojpgButton.TabIndex = 7;
            this.tojpgButton.Text = "To JPG";
            this.tojpgButton.UseVisualStyleBackColor = false;
            this.tojpgButton.Click += new System.EventHandler(this.TojpgButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(914, 515);
            this.Controls.Add(this.tojpgButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.dropField);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.96D;
            this.Text = "Form1";
            this.dropField.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dropField;
        private System.Windows.Forms.ListBox nameField;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private NewProgressBar progressBar;
        private System.Windows.Forms.Button tojpgButton;
    }
}

