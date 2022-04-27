
namespace WinFormsApp1
{
     partial class Login_GUI
     {
          /// <summary>
          ///  Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          ///  Clean up any resources being used.
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
          ///  Required method for Designer support - do not modify
          ///  the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox4 = new System.Windows.Forms.PictureBox();
               this.txtTK = new System.Windows.Forms.TextBox();
               this.txtMK = new System.Windows.Forms.TextBox();
               this.pictureBox5 = new System.Windows.Forms.PictureBox();
               this.btnLogin = new System.Windows.Forms.Button();
               this.btnExit = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
               this.SuspendLayout();
               // 
               // pictureBox1
               // 
               this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.photo_2022_04_19_08_07_15;
               this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(413, 541);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // pictureBox2
               // 
               this.pictureBox2.Location = new System.Drawing.Point(-28, -57);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(125, 62);
               this.pictureBox2.TabIndex = 1;
               this.pictureBox2.TabStop = false;
               // 
               // pictureBox3
               // 
               this.pictureBox3.Image = global::WinFormsApp1.Properties.Resources.username;
               this.pictureBox3.Location = new System.Drawing.Point(560, 234);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(51, 34);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox3.TabIndex = 2;
               this.pictureBox3.TabStop = false;
               // 
               // pictureBox4
               // 
               this.pictureBox4.Image = global::WinFormsApp1.Properties.Resources.password;
               this.pictureBox4.Location = new System.Drawing.Point(560, 306);
               this.pictureBox4.Name = "pictureBox4";
               this.pictureBox4.Size = new System.Drawing.Size(51, 34);
               this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox4.TabIndex = 3;
               this.pictureBox4.TabStop = false;
               // 
               // txtTK
               // 
               this.txtTK.Location = new System.Drawing.Point(632, 234);
               this.txtTK.Name = "txtTK";
               this.txtTK.Size = new System.Drawing.Size(239, 27);
               this.txtTK.TabIndex = 4;
               this.txtTK.TextChanged += new System.EventHandler(this.txtTK_TextChanged);
               // 
               // txtMK
               // 
               this.txtMK.Location = new System.Drawing.Point(632, 306);
               this.txtMK.Name = "txtMK";
               this.txtMK.Size = new System.Drawing.Size(239, 27);
               this.txtMK.TabIndex = 5;
               // 
               // pictureBox5
               // 
               this.pictureBox5.Image = global::WinFormsApp1.Properties.Resources.login;
               this.pictureBox5.Location = new System.Drawing.Point(662, 49);
               this.pictureBox5.Name = "pictureBox5";
               this.pictureBox5.Size = new System.Drawing.Size(127, 120);
               this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.pictureBox5.TabIndex = 6;
               this.pictureBox5.TabStop = false;
               // 
               // btnLogin
               // 
               this.btnLogin.Location = new System.Drawing.Point(632, 412);
               this.btnLogin.Name = "btnLogin";
               this.btnLogin.Size = new System.Drawing.Size(94, 29);
               this.btnLogin.TabIndex = 7;
               this.btnLogin.Text = "LOGIN";
               this.btnLogin.UseVisualStyleBackColor = true;
               this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
               // 
               // btnExit
               // 
               this.btnExit.Location = new System.Drawing.Point(763, 412);
               this.btnExit.Name = "btnExit";
               this.btnExit.Size = new System.Drawing.Size(94, 29);
               this.btnExit.TabIndex = 8;
               this.btnExit.Text = "Exit";
               this.btnExit.UseVisualStyleBackColor = true;
               // 
               // Login_GUI
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1011, 537);
               this.Controls.Add(this.btnExit);
               this.Controls.Add(this.btnLogin);
               this.Controls.Add(this.pictureBox5);
               this.Controls.Add(this.txtMK);
               this.Controls.Add(this.txtTK);
               this.Controls.Add(this.pictureBox4);
               this.Controls.Add(this.pictureBox3);
               this.Controls.Add(this.pictureBox2);
               this.Controls.Add(this.pictureBox1);
               this.ForeColor = System.Drawing.SystemColors.ControlText;
               this.Name = "Login_GUI";
               this.Text = "Form1";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.PictureBox pictureBox2;
          private System.Windows.Forms.PictureBox pictureBox3;
          private System.Windows.Forms.PictureBox pictureBox4;
          private System.Windows.Forms.TextBox txtTK;
          private System.Windows.Forms.TextBox txtMK;
          private System.Windows.Forms.PictureBox pictureBox5;
          private System.Windows.Forms.Button btnLogin;
          private System.Windows.Forms.Button btnExit;
     }
}

