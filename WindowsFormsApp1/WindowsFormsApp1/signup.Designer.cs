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
            this.confirmpassword_label = new System.Windows.Forms.Label();
            this.confirmpassword_textbox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 55);
            this.label1.TabIndex = 13;
            this.label1.Text = "Register";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(325, 371);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 13);
            this.error_label.TabIndex = 12;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password_label.Location = new System.Drawing.Point(203, 138);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(92, 24);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.password_textbox.Location = new System.Drawing.Point(430, 133);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(173, 29);
            this.password_textbox.TabIndex = 10;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // SSN_label
            // 
            this.SSN_label.AutoSize = true;
            this.SSN_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SSN_label.Location = new System.Drawing.Point(203, 90);
            this.SSN_label.Name = "SSN_label";
            this.SSN_label.Size = new System.Drawing.Size(48, 24);
            this.SSN_label.TabIndex = 9;
            this.SSN_label.Text = "SSN";
            // 
            // SSN_textbox
            // 
            this.SSN_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SSN_textbox.Location = new System.Drawing.Point(430, 84);
            this.SSN_textbox.Name = "SSN_textbox";
            this.SSN_textbox.Size = new System.Drawing.Size(173, 29);
            this.SSN_textbox.TabIndex = 8;
            // 
            // signup_button
            // 
            this.signup_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.signup_button.Location = new System.Drawing.Point(309, 387);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(160, 51);
            this.signup_button.TabIndex = 7;
            this.signup_button.Text = "Sign Up";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // confirmpassword_label
            // 
            this.confirmpassword_label.AutoSize = true;
            this.confirmpassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.confirmpassword_label.Location = new System.Drawing.Point(204, 185);
            this.confirmpassword_label.Name = "confirmpassword_label";
            this.confirmpassword_label.Size = new System.Drawing.Size(162, 24);
            this.confirmpassword_label.TabIndex = 14;
            this.confirmpassword_label.Text = "Confirm Password";
            // 
            // confirmpassword_textbox
            // 
            this.confirmpassword_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.confirmpassword_textbox.Location = new System.Drawing.Point(430, 182);
            this.confirmpassword_textbox.Name = "confirmpassword_textbox";
            this.confirmpassword_textbox.Size = new System.Drawing.Size(173, 29);
            this.confirmpassword_textbox.TabIndex = 15;
            this.confirmpassword_textbox.UseSystemPasswordChar = true;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.name_label.Location = new System.Drawing.Point(203, 233);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(61, 24);
            this.name_label.TabIndex = 17;
            this.name_label.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.name_textbox.Location = new System.Drawing.Point(430, 230);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(173, 29);
            this.name_textbox.TabIndex = 16;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.phone_label.Location = new System.Drawing.Point(203, 284);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(137, 24);
            this.phone_label.TabIndex = 19;
            this.phone_label.Text = "Phone number";
            // 
            // phone_textbox
            // 
            this.phone_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.phone_textbox.Location = new System.Drawing.Point(430, 278);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(173, 29);
            this.phone_textbox.TabIndex = 18;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.address_label.Location = new System.Drawing.Point(203, 331);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(80, 24);
            this.address_label.TabIndex = 21;
            this.address_label.Text = "Address";
            // 
            // address_textbox
            // 
            this.address_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.address_textbox.Location = new System.Drawing.Point(430, 325);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(173, 29);
            this.address_textbox.TabIndex = 20;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.address_textbox);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.confirmpassword_textbox);
            this.Controls.Add(this.confirmpassword_label);
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
        private System.Windows.Forms.Label confirmpassword_label;
        private System.Windows.Forms.TextBox confirmpassword_textbox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox address_textbox;
    }
}