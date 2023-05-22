namespace WindowsFormsApp1
{
    partial class login
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
            this.login_button = new System.Windows.Forms.Button();
            this.SSN_textbox = new System.Windows.Forms.TextBox();
            this.SSN_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.login_button.Location = new System.Drawing.Point(189, 273);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(134, 54);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Log In";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // SSN_textbox
            // 
            this.SSN_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SSN_textbox.Location = new System.Drawing.Point(216, 123);
            this.SSN_textbox.Name = "SSN_textbox";
            this.SSN_textbox.Size = new System.Drawing.Size(173, 35);
            this.SSN_textbox.TabIndex = 1;
            // 
            // SSN_label
            // 
            this.SSN_label.AutoSize = true;
            this.SSN_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SSN_label.Location = new System.Drawing.Point(90, 126);
            this.SSN_label.Name = "SSN_label";
            this.SSN_label.Size = new System.Drawing.Size(63, 29);
            this.SSN_label.TabIndex = 2;
            this.SSN_label.Text = "SSN";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.password_label.Location = new System.Drawing.Point(90, 188);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(120, 29);
            this.password_label.TabIndex = 4;
            this.password_label.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.password_textbox.Location = new System.Drawing.Point(216, 185);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(173, 35);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(175, 239);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log In";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 339);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.SSN_label);
            this.Controls.Add(this.SSN_textbox);
            this.Controls.Add(this.login_button);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox SSN_textbox;
        private System.Windows.Forms.Label SSN_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label label1;
    }
}