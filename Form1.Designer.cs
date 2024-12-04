namespace Taschenrechner
{
    partial class Taschenrechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Anzeigefeld = new System.Windows.Forms.TextBox();
            this.Sieben = new System.Windows.Forms.Button();
            this.Acht = new System.Windows.Forms.Button();
            this.Neun = new System.Windows.Forms.Button();
            this.Modulo = new System.Windows.Forms.Button();
            this.Vier = new System.Windows.Forms.Button();
            this.Fünf = new System.Windows.Forms.Button();
            this.Sechs = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Eins = new System.Windows.Forms.Button();
            this.Zwei = new System.Windows.Forms.Button();
            this.Drei = new System.Windows.Forms.Button();
            this.Mulitplikation = new System.Windows.Forms.Button();
            this.Null = new System.Windows.Forms.Button();
            this.Punkt = new System.Windows.Forms.Button();
            this.Subtraktion = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Gleich = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Anzeigefeld
            // 
            this.Anzeigefeld.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Anzeigefeld.Location = new System.Drawing.Point(47, 30);
            this.Anzeigefeld.MaximumSize = new System.Drawing.Size(600, 50);
            this.Anzeigefeld.MinimumSize = new System.Drawing.Size(600, 50);
            this.Anzeigefeld.Name = "Anzeigefeld";
            this.Anzeigefeld.ReadOnly = true;
            this.Anzeigefeld.Size = new System.Drawing.Size(600, 50);
            this.Anzeigefeld.TabIndex = 0;
            // 
            // Sieben
            // 
            this.Sieben.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Sieben.Location = new System.Drawing.Point(47, 113);
            this.Sieben.Name = "Sieben";
            this.Sieben.Size = new System.Drawing.Size(117, 87);
            this.Sieben.TabIndex = 1;
            this.Sieben.Text = "7";
            this.Sieben.UseVisualStyleBackColor = true;
            this.Sieben.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Acht
            // 
            this.Acht.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Acht.Location = new System.Drawing.Point(201, 113);
            this.Acht.Name = "Acht";
            this.Acht.Size = new System.Drawing.Size(117, 87);
            this.Acht.TabIndex = 2;
            this.Acht.Text = "8";
            this.Acht.UseVisualStyleBackColor = true;
            this.Acht.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Neun
            // 
            this.Neun.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Neun.Location = new System.Drawing.Point(364, 113);
            this.Neun.Name = "Neun";
            this.Neun.Size = new System.Drawing.Size(117, 87);
            this.Neun.TabIndex = 3;
            this.Neun.Text = "9";
            this.Neun.UseVisualStyleBackColor = true;
            this.Neun.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Modulo
            // 
            this.Modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Modulo.Location = new System.Drawing.Point(530, 113);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(117, 87);
            this.Modulo.TabIndex = 4;
            this.Modulo.Text = "%";
            this.Modulo.UseVisualStyleBackColor = true;
            this.Modulo.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Vier
            // 
            this.Vier.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Vier.Location = new System.Drawing.Point(47, 221);
            this.Vier.Name = "Vier";
            this.Vier.Size = new System.Drawing.Size(117, 87);
            this.Vier.TabIndex = 5;
            this.Vier.Text = "4";
            this.Vier.UseVisualStyleBackColor = true;
            this.Vier.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Fünf
            // 
            this.Fünf.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Fünf.Location = new System.Drawing.Point(201, 221);
            this.Fünf.Name = "Fünf";
            this.Fünf.Size = new System.Drawing.Size(117, 87);
            this.Fünf.TabIndex = 6;
            this.Fünf.Text = "5";
            this.Fünf.UseVisualStyleBackColor = true;
            this.Fünf.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Sechs
            // 
            this.Sechs.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Sechs.Location = new System.Drawing.Point(364, 221);
            this.Sechs.Name = "Sechs";
            this.Sechs.Size = new System.Drawing.Size(117, 87);
            this.Sechs.TabIndex = 7;
            this.Sechs.Text = "6";
            this.Sechs.UseVisualStyleBackColor = true;
            this.Sechs.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Division.Location = new System.Drawing.Point(530, 221);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(117, 87);
            this.Division.TabIndex = 8;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Eins
            // 
            this.Eins.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Eins.Location = new System.Drawing.Point(47, 330);
            this.Eins.Name = "Eins";
            this.Eins.Size = new System.Drawing.Size(117, 87);
            this.Eins.TabIndex = 9;
            this.Eins.Text = "1";
            this.Eins.UseVisualStyleBackColor = true;
            this.Eins.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Zwei
            // 
            this.Zwei.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Zwei.Location = new System.Drawing.Point(201, 330);
            this.Zwei.Name = "Zwei";
            this.Zwei.Size = new System.Drawing.Size(117, 87);
            this.Zwei.TabIndex = 10;
            this.Zwei.Text = "2";
            this.Zwei.UseVisualStyleBackColor = true;
            this.Zwei.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Drei
            // 
            this.Drei.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Drei.Location = new System.Drawing.Point(364, 330);
            this.Drei.Name = "Drei";
            this.Drei.Size = new System.Drawing.Size(117, 87);
            this.Drei.TabIndex = 11;
            this.Drei.Text = "3";
            this.Drei.UseVisualStyleBackColor = true;
            this.Drei.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Mulitplikation
            // 
            this.Mulitplikation.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mulitplikation.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Mulitplikation.Location = new System.Drawing.Point(530, 330);
            this.Mulitplikation.Name = "Mulitplikation";
            this.Mulitplikation.Size = new System.Drawing.Size(117, 87);
            this.Mulitplikation.TabIndex = 12;
            this.Mulitplikation.Text = "*";
            this.Mulitplikation.UseVisualStyleBackColor = true;
            this.Mulitplikation.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Null
            // 
            this.Null.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Null.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Null.Location = new System.Drawing.Point(47, 434);
            this.Null.Name = "Null";
            this.Null.Size = new System.Drawing.Size(117, 87);
            this.Null.TabIndex = 13;
            this.Null.Text = "0";
            this.Null.UseVisualStyleBackColor = false;
            this.Null.Click += new System.EventHandler(this.Zahl_Click);
            // 
            // Punkt
            // 
            this.Punkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Punkt.Location = new System.Drawing.Point(201, 434);
            this.Punkt.Name = "Punkt";
            this.Punkt.Size = new System.Drawing.Size(117, 87);
            this.Punkt.TabIndex = 14;
            this.Punkt.Text = ".";
            this.Punkt.UseVisualStyleBackColor = true;
            this.Punkt.Click += new System.EventHandler(this.Punkt_Click);
            // 
            // Subtraktion
            // 
            this.Subtraktion.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Subtraktion.Location = new System.Drawing.Point(364, 434);
            this.Subtraktion.Name = "Subtraktion";
            this.Subtraktion.Size = new System.Drawing.Size(117, 87);
            this.Subtraktion.TabIndex = 15;
            this.Subtraktion.Text = "-";
            this.Subtraktion.UseVisualStyleBackColor = true;
            this.Subtraktion.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Addition.Location = new System.Drawing.Point(530, 434);
            this.Addition.Name = "Addition";
            this.Addition.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Addition.Size = new System.Drawing.Size(117, 87);
            this.Addition.TabIndex = 16;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Operation_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Clear.Location = new System.Drawing.Point(664, 30);
            this.Clear.Name = "Clear";
            this.Clear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Clear.Size = new System.Drawing.Size(72, 50);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Gleich
            // 
            this.Gleich.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.Gleich.Location = new System.Drawing.Point(664, 434);
            this.Gleich.Name = "Gleich";
            this.Gleich.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Gleich.Size = new System.Drawing.Size(103, 87);
            this.Gleich.TabIndex = 18;
            this.Gleich.Text = "=";
            this.Gleich.UseVisualStyleBackColor = true;
            this.Gleich.Click += new System.EventHandler(this.Gleich_Click);
            // 
            // Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 550);
            this.Controls.Add(this.Gleich);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Subtraktion);
            this.Controls.Add(this.Punkt);
            this.Controls.Add(this.Null);
            this.Controls.Add(this.Mulitplikation);
            this.Controls.Add(this.Drei);
            this.Controls.Add(this.Zwei);
            this.Controls.Add(this.Eins);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Sechs);
            this.Controls.Add(this.Fünf);
            this.Controls.Add(this.Vier);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.Neun);
            this.Controls.Add(this.Acht);
            this.Controls.Add(this.Sieben);
            this.Controls.Add(this.Anzeigefeld);
            this.Name = "Taschenrechner";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Anzeigefeld;
        private System.Windows.Forms.Button Sieben;
        private System.Windows.Forms.Button Acht;
        private System.Windows.Forms.Button Neun;
        private System.Windows.Forms.Button Modulo;
        private System.Windows.Forms.Button Vier;
        private System.Windows.Forms.Button Fünf;
        private System.Windows.Forms.Button Sechs;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Eins;
        private System.Windows.Forms.Button Zwei;
        private System.Windows.Forms.Button Drei;
        private System.Windows.Forms.Button Mulitplikation;
        private System.Windows.Forms.Button Null;
        private System.Windows.Forms.Button Punkt;
        private System.Windows.Forms.Button Subtraktion;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Gleich;
    }
}

