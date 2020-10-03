namespace Aspiradora
{
    partial class Datos
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
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(193, 281);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige la zona en que quieres que inicie la Aspiradora:";
            // 
            // radioCarga
            // 
            this.radioCarga.AutoSize = true;
            this.radioCarga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioCarga.Checked = true;
            this.radioCarga.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioCarga.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCarga.Location = new System.Drawing.Point(119, 114);
            this.radioCarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioCarga.Name = "radioCarga";
            this.radioCarga.Size = new System.Drawing.Size(141, 23);
            this.radioCarga.TabIndex = 2;
            this.radioCarga.TabStop = true;
            this.radioCarga.Text = "Sector de carga";
            this.radioCarga.UseVisualStyleBackColor = true;
            // 
            // radioA
            // 
            this.radioA.AutoSize = true;
            this.radioA.Enabled = false;
            this.radioA.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioA.Location = new System.Drawing.Point(273, 114);
            this.radioA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioA.Name = "radioA";
            this.radioA.Size = new System.Drawing.Size(92, 23);
            this.radioA.TabIndex = 3;
            this.radioA.Text = "Sector A";
            this.radioA.UseVisualStyleBackColor = true;
            // 
            // radioB
            // 
            this.radioB.AutoSize = true;
            this.radioB.Enabled = false;
            this.radioB.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioB.Location = new System.Drawing.Point(396, 114);
            this.radioB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioB.Name = "radioB";
            this.radioB.Size = new System.Drawing.Size(91, 23);
            this.radioB.TabIndex = 4;
            this.radioB.Text = "Sector B";
            this.radioB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marque las zonas que quieren que esten sucias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingrese el numero de movimientos que tendrá la Aspiradora:";
            // 
            // numMov
            // 
            this.numMov.BackColor = System.Drawing.Color.DarkCyan;
            this.numMov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numMov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMov.Location = new System.Drawing.Point(243, 37);
            this.numMov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMov.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMov.Name = "numMov";
            this.numMov.Size = new System.Drawing.Size(120, 26);
            this.numMov.TabIndex = 8;
            this.numMov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.chA.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chA.Location = new System.Drawing.Point(175, 222);
            this.chA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chA.Name = "chA";
            this.chA.Size = new System.Drawing.Size(93, 23);
            this.chA.TabIndex = 9;
            this.chA.Text = "Sector A";
            this.chA.UseVisualStyleBackColor = true;
            // 
            // chB
            // 
            this.chB.AutoSize = true;
            this.chB.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chB.Location = new System.Drawing.Point(316, 222);
            this.chB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chB.Name = "chB";
            this.chB.Size = new System.Drawing.Size(92, 23);
            this.chB.TabIndex = 10;
            this.chB.Text = "Sector B";
            this.chB.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(663, 367);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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