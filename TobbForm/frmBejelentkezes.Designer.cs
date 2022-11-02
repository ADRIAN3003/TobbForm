
namespace TobbForm
{
    partial class frmBejelentkezes
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
            this.tbFelhasznalonev = new System.Windows.Forms.TextBox();
            this.btnBejelentkezes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJelszo = new System.Windows.Forms.TextBox();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFelhasznalo = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Felhasználónév:";
            // 
            // tbFelhasznalonev
            // 
            this.tbFelhasznalonev.Location = new System.Drawing.Point(142, 32);
            this.tbFelhasznalonev.Name = "tbFelhasznalonev";
            this.tbFelhasznalonev.Size = new System.Drawing.Size(186, 26);
            this.tbFelhasznalonev.TabIndex = 0;
            // 
            // btnBejelentkezes
            // 
            this.btnBejelentkezes.Location = new System.Drawing.Point(102, 216);
            this.btnBejelentkezes.Name = "btnBejelentkezes";
            this.btnBejelentkezes.Size = new System.Drawing.Size(137, 42);
            this.btnBejelentkezes.TabIndex = 3;
            this.btnBejelentkezes.Text = "Bejelentkezés";
            this.btnBejelentkezes.UseVisualStyleBackColor = true;
            this.btnBejelentkezes.Click += new System.EventHandler(this.btnBejelentkezes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jelszó:";
            // 
            // tbJelszo
            // 
            this.tbJelszo.Location = new System.Drawing.Point(142, 78);
            this.tbJelszo.Name = "tbJelszo";
            this.tbJelszo.PasswordChar = '*';
            this.tbJelszo.Size = new System.Drawing.Size(186, 26);
            this.tbJelszo.TabIndex = 1;
            // 
            // btnKilepes
            // 
            this.btnKilepes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnKilepes.Location = new System.Drawing.Point(255, 272);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(73, 30);
            this.btnKilepes.TabIndex = 4;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdmin);
            this.groupBox1.Controls.Add(this.rbFelhasznalo);
            this.groupBox1.Location = new System.Drawing.Point(16, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rbFelhasznalo
            // 
            this.rbFelhasznalo.AutoSize = true;
            this.rbFelhasznalo.Checked = true;
            this.rbFelhasznalo.Location = new System.Drawing.Point(34, 25);
            this.rbFelhasznalo.Name = "rbFelhasznalo";
            this.rbFelhasznalo.Size = new System.Drawing.Size(113, 24);
            this.rbFelhasznalo.TabIndex = 0;
            this.rbFelhasznalo.TabStop = true;
            this.rbFelhasznalo.Text = "Felhasználó";
            this.rbFelhasznalo.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(200, 25);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(72, 24);
            this.rbAdmin.TabIndex = 1;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // frmBejelentkezes
            // 
            this.AcceptButton = this.btnBejelentkezes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnKilepes;
            this.ClientSize = new System.Drawing.Size(340, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnBejelentkezes);
            this.Controls.Add(this.tbJelszo);
            this.Controls.Add(this.tbFelhasznalonev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFelhasznalonev;
        private System.Windows.Forms.Button btnBejelentkezes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJelszo;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbFelhasznalo;
    }
}