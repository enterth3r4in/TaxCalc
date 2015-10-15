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
            this.SuspendLayout();
            // 
            // createProfile
            // 
            this.createProfile.AutoEllipsis = true;
            this.createProfile.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createProfile.ForeColor = System.Drawing.Color.Maroon;
            this.createProfile.Location = new System.Drawing.Point(12, 275);
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
            this.loadProfile.Location = new System.Drawing.Point(143, 275);
            this.loadProfile.Name = "loadProfile";
            this.loadProfile.Size = new System.Drawing.Size(125, 35);
            this.loadProfile.TabIndex = 1;
            this.loadProfile.Text = "Load Profile";
            this.loadProfile.UseVisualStyleBackColor = true;
            // 
            // options
            // 
            this.options.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.options.ForeColor = System.Drawing.Color.Maroon;
            this.options.Location = new System.Drawing.Point(274, 275);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(125, 35);
            this.options.TabIndex = 2;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = true;
            // 
            // exitProgram
            // 
            this.exitProgram.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.exitProgram.ForeColor = System.Drawing.Color.Maroon;
            this.exitProgram.Location = new System.Drawing.Point(405, 275);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(125, 35);
            this.exitProgram.TabIndex = 3;
            this.exitProgram.Text = "Exit Program";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 362);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.options);
            this.Controls.Add(this.loadProfile);
            this.Controls.Add(this.createProfile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createProfile;
        private System.Windows.Forms.Button loadProfile;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button exitProgram;
    }
}

