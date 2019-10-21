namespace ChuckNorris_WinForms
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
            this.btn_GetJoke = new System.Windows.Forms.Button();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_GetJoke
            // 
            this.btn_GetJoke.Location = new System.Drawing.Point(309, 319);
            this.btn_GetJoke.Name = "btn_GetJoke";
            this.btn_GetJoke.Size = new System.Drawing.Size(119, 49);
            this.btn_GetJoke.TabIndex = 0;
            this.btn_GetJoke.Text = "Random Joke";
            this.btn_GetJoke.UseVisualStyleBackColor = true;
            this.btn_GetJoke.Click += new System.EventHandler(this.BtnGetJoke_Click);
            // 
            // cboCategories
            // 
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(179, 101);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(121, 24);
            this.cboCategories.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.btn_GetJoke);
            this.Name = "Form1";
            this.Text = "ChuckNorrisJokeGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_GetJoke;
        private System.Windows.Forms.ComboBox cboCategories;
    }
}

