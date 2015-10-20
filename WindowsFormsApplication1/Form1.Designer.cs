namespace WindowsFormsApplication1
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
            this.createProfile = new System.Windows.Forms.Button();
            this.loadProfile = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.exitProgram = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createProfile
            // 
            this.createProfile.AutoEllipsis = true;
            this.createProfile.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProfile.ForeColor = System.Drawing.Color.Maroon;
            this.createProfile.Location = new System.Drawing.Point(12, 233);
            this.createProfile.Name = "createProfile";
            this.createProfile.Size = new System.Drawing.Size(125, 35);
            this.createProfile.TabIndex = 0;
            this.createProfile.Text = "Create Profile";
            this.createProfile.UseVisualStyleBackColor = true;
            this.createProfile.Click += new System.EventHandler(this.createProfileClick);
            // 
            // loadProfile
            // 
            this.loadProfile.Cursor = System.Windows.Forms.Cursors.No;
            this.loadProfile.Enabled = false;
            this.loadProfile.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.loadProfile.ForeColor = System.Drawing.Color.Maroon;
            this.loadProfile.Location = new System.Drawing.Point(12, 274);
            this.loadProfile.Name = "loadProfile";
            this.loadProfile.Size = new System.Drawing.Size(125, 35);
            this.loadProfile.TabIndex = 1;
            this.loadProfile.Text = "Load Profile";
            this.loadProfile.UseVisualStyleBackColor = true;
            // 
            // options
            // 
            this.options.Enabled = false;
            this.options.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.options.ForeColor = System.Drawing.Color.Maroon;
            this.options.Location = new System.Drawing.Point(407, 233);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(125, 35);
            this.options.TabIndex = 2;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            this.options.Click += new System.EventHandler(this.openOptionsMenu);
            // 
            // exitProgram
            // 
            this.exitProgram.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.exitProgram.ForeColor = System.Drawing.Color.Maroon;
            this.exitProgram.Location = new System.Drawing.Point(12, 315);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(125, 35);
            this.exitProgram.TabIndex = 3;
            this.exitProgram.Text = "Exit Program";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitClick);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(407, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.openAboutMenu);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(448, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version 0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLACEHOLDER (LOGO)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "PLACEHOLDER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PLACEHOLDER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PLACEHOLDER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.options);
            this.Controls.Add(this.loadProfile);
            this.Controls.Add(this.createProfile);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createProfile;
        private System.Windows.Forms.Button loadProfile;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button exitProgram;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

