namespace Aspiradora
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.radioCarga = new System.Windows.Forms.RadioButton();
            this.radioA = new System.Windows.Forms.RadioButton();
            this.radioB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMov = new System.Windows.Forms.NumericUpDown();
            this.chA = new System.Windows.Forms.CheckBox();
            this.chB = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMov)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(193, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige la zona en que quieres que inicie la Aspiradora:";
            // 
            // radioCarga
            // 
            this.radioCarga.AutoSize = true;
            this.radioCarga.Checked = true;
            this.radioCarga.Location = new System.Drawing.Point(119, 114);
            this.radioCarga.Name = "radioCarga";
            this.radioCarga.Size = new System.Drawing.Size(122, 21);
            this.radioCarga.TabIndex = 2;
            this.radioCarga.TabStop = true;
            this.radioCarga.Text = "Zona de carga";
            this.radioCarga.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Enabled = false;
            this.radioA.Location = new System.Drawing.Point(273, 114);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(75, 21);
            this.radioA.TabIndex = 3;
            this.radioA.TabStop = true;
            this.radioA.Text = "Zona A";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Enabled = false;
            this.radioB.Location = new System.Drawing.Point(396, 114);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(75, 21);
            this.radioB.TabIndex = 4;
            this.radioB.TabStop = true;
            this.radioB.Text = "Zona B";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marque las zonas que quieren que esten sucias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese el numero de movimientos que tendrá la Aspiradora:";
            // 
            // numMov
            // 
            this.numMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMov.Location = new System.Drawing.Point(242, 37);
            this.numMov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMov.Name = "numMov";
            this.numMov.Size = new System.Drawing.Size(120, 30);
            this.numMov.TabIndex = 8;
            this.numMov.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMov.Click += new System.EventHandler(this.numMov_Click);
            // 
            // chA
            // 
            this.chA.AutoSize = true;
            this.chA.Location = new System.Drawing.Point(175, 221);
            this.chA.Name = "chA";
            this.chA.Size = new System.Drawing.Size(76, 21);
            this.chA.TabIndex = 9;
            this.chA.Text = "Zona A";
            this.chA.UseVisualStyleBackColor = true;
            // 
            // chB
            // 
            this.chB.AutoSize = true;
            this.chB.Location = new System.Drawing.Point(316, 221);
            this.chB.Name = "chB";
            this.chB.Size = new System.Drawing.Size(76, 21);
            this.chB.TabIndex = 10;
            this.chB.Text = "Zona B";
            this.chB.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 367);
            this.Controls.Add(this.chB);
            this.Controls.Add(this.chA);
            this.Controls.Add(this.numMov);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioB);
            this.Controls.Add(this.radioA);
            this.Controls.Add(this.radioCarga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Datos";
            ((System.ComponentModel.ISupportInitialize)(this.numMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioCarga;
        private System.Windows.Forms.RadioButton radioA;
        private System.Windows.Forms.RadioButton radioB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMov;
        private System.Windows.Forms.CheckBox chA;
        private System.Windows.Forms.CheckBox chB;
    }
}