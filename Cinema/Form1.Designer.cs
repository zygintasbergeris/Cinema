namespace Cinema
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
			this.signIn = new System.Windows.Forms.Button();
			this.signUp = new System.Windows.Forms.Button();
			this.username = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// signIn
			// 
			this.signIn.Location = new System.Drawing.Point(12, 131);
			this.signIn.Name = "signIn";
			this.signIn.Size = new System.Drawing.Size(75, 23);
			this.signIn.TabIndex = 0;
			this.signIn.Text = "Sign In";
			this.signIn.UseVisualStyleBackColor = true;
			this.signIn.Click += new System.EventHandler(this.signIn_Click);
			// 
			// signUp
			// 
			this.signUp.Location = new System.Drawing.Point(108, 131);
			this.signUp.Name = "signUp";
			this.signUp.Size = new System.Drawing.Size(75, 23);
			this.signUp.TabIndex = 1;
			this.signUp.Text = "Sign up";
			this.signUp.UseVisualStyleBackColor = true;
			this.signUp.Click += new System.EventHandler(this.signUp_Click);
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(12, 36);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(171, 20);
			this.username.TabIndex = 2;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(12, 88);
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(171, 20);
			this.password.TabIndex = 3;
			this.password.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Email:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Password:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(197, 168);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.signUp);
			this.Controls.Add(this.signIn);
			this.Name = "Form1";
			this.Text = "Sign in";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button signIn;
		private System.Windows.Forms.Button signUp;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

