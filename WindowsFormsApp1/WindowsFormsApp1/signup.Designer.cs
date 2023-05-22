namespace WindowsFormsApp1
{
    partial class signup
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
            this.label1 = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.SSN_label = new System.Windows.Forms.Label();
            this.SSN_textbox = new System.Windows.Forms.TextBox();
            this.signup_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Register";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(318, 232);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 12;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.password_label.Location = new System.Drawing.Point(222, 181);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(120, 29);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.password_textbox.Location = new System.Drawing.Point(359, 178);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(173, 35);
            this.password_textbox.TabIndex = 10;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // SSN_label
            // 
            this.SSN_label.AutoSize = true;
            this.SSN_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SSN_label.Location = new System.Drawing.Point(233, 119);
            this.SSN_label.Name = "SSN_label";
            this.SSN_label.Size = new System.Drawing.Size(63, 29);
            this.SSN_label.TabIndex = 9;
            this.SSN_label.Text = "SSN";
            // 
            // SSN_textbox
            // 
            this.SSN_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SSN_textbox.Location = new System.Drawing.Point(359, 116);
            this.SSN_textbox.Name = "SSN_textbox";
            this.SSN_textbox.Size = new System.Drawing.Size(173, 35);
            this.SSN_textbox.TabIndex = 8;
            // 
            // signup_button
            // 
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.signup_button.Location = new System.Drawing.Point(320, 346);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(160, 54);
            this.signup_button.TabIndex = 7;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.SSN_label);
            this.Controls.Add(this.SSN_textbox);
            this.Controls.Add(this.signup_button);
            this.Name = "signup";
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label SSN_label;
        private System.Windows.Forms.TextBox SSN_textbox;
        private System.Windows.Forms.Button signup_button;
    }
}