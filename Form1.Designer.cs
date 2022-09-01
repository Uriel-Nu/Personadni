namespace Personadni
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnombre = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.lblfechdenac = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnpersona = new System.Windows.Forms.Button();
            this.btndoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(150, 79);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(54, 13);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "NOMBRE";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(150, 122);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(26, 13);
            this.lbldni.TabIndex = 1;
            this.lbldni.Text = "DNI";
            // 
            // lblfechdenac
            // 
            this.lblfechdenac.AutoSize = true;
            this.lblfechdenac.Location = new System.Drawing.Point(122, 162);
            this.lblfechdenac.Name = "lblfechdenac";
            this.lblfechdenac.Size = new System.Drawing.Size(130, 13);
            this.lblfechdenac.TabIndex = 2;
            this.lblfechdenac.Text = "FECHA DE NACIMIENTO";
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(162, 223);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(37, 13);
            this.lbledad.TabIndex = 3;
            this.lbledad.Text = "EDAD";
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(282, 223);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(59, 13);
            this.lbl_edad.TabIndex = 4;
            this.lbl_edad.Text = "LBL-EDAD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(276, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(276, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(276, 155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // btnpersona
            // 
            this.btnpersona.Location = new System.Drawing.Point(437, 74);
            this.btnpersona.Name = "btnpersona";
            this.btnpersona.Size = new System.Drawing.Size(75, 23);
            this.btnpersona.TabIndex = 8;
            this.btnpersona.Text = "PERSONA";
            this.btnpersona.UseVisualStyleBackColor = true;
            this.btnpersona.Click += new System.EventHandler(this.btnpersona_Click);
            // 
            // btndoc
            // 
            this.btndoc.Location = new System.Drawing.Point(437, 122);
            this.btndoc.Name = "btndoc";
            this.btndoc.Size = new System.Drawing.Size(75, 23);
            this.btndoc.TabIndex = 9;
            this.btndoc.Text = "dato";
            this.btndoc.UseVisualStyleBackColor = true;
            this.btndoc.Click += new System.EventHandler(this.btndoc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndoc);
            this.Controls.Add(this.btnpersona);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_edad);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblfechdenac);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.Label lblfechdenac;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lbl_edad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnpersona;
        private System.Windows.Forms.Button btndoc;
    }
}

