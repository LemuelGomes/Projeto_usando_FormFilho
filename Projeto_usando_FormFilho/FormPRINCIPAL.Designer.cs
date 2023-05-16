namespace Projeto_usando_FormFilho
{
    partial class FormPRINCIPAL
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
            this.labelUSUARIO_user = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUSUARIO_icon = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUSUARIO_user
            // 
            this.labelUSUARIO_user.AutoSize = true;
            this.labelUSUARIO_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUSUARIO_user.Location = new System.Drawing.Point(686, 3);
            this.labelUSUARIO_user.Name = "labelUSUARIO_user";
            this.labelUSUARIO_user.Size = new System.Drawing.Size(54, 16);
            this.labelUSUARIO_user.TabIndex = 1;
            this.labelUSUARIO_user.Text = "Usuário";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelUSUARIO_icon);
            this.panel1.Controls.Add(this.labelUSUARIO_user);
            this.panel1.Location = new System.Drawing.Point(0, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 2;
            // 
            // labelUSUARIO_icon
            // 
            this.labelUSUARIO_icon.AutoSize = true;
            this.labelUSUARIO_icon.Image = global::Projeto_usando_FormFilho.Properties.Resources.do_utilizador__1_;
            this.labelUSUARIO_icon.Location = new System.Drawing.Point(633, 5);
            this.labelUSUARIO_icon.Name = "labelUSUARIO_icon";
            this.labelUSUARIO_icon.Size = new System.Drawing.Size(35, 13);
            this.labelUSUARIO_icon.TabIndex = 0;
            this.labelUSUARIO_icon.Text = "label1";
            // 
            // FormPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FormPRINCIPAL";
            this.Text = "PRINCIPAL";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelUSUARIO_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUSUARIO_icon;
    }
}