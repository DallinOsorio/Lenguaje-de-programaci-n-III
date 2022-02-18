namespace tarea
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreestudiantetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EdadtextBox = new System.Windows.Forms.TextBox();
            this.RegistrarEstudiantebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistradoslistBox = new System.Windows.Forms.ListBox();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el Nombre del Estudiante";
            // 
            // NombreestudiantetextBox
            // 
            this.NombreestudiantetextBox.Location = new System.Drawing.Point(262, 109);
            this.NombreestudiantetextBox.Name = "NombreestudiantetextBox";
            this.NombreestudiantetextBox.Size = new System.Drawing.Size(136, 20);
            this.NombreestudiantetextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese la edad";
            // 
            // EdadtextBox
            // 
            this.EdadtextBox.Location = new System.Drawing.Point(568, 109);
            this.EdadtextBox.Name = "EdadtextBox";
            this.EdadtextBox.Size = new System.Drawing.Size(49, 20);
            this.EdadtextBox.TabIndex = 3;
            // 
            // RegistrarEstudiantebutton
            // 
            this.RegistrarEstudiantebutton.Location = new System.Drawing.Point(338, 165);
            this.RegistrarEstudiantebutton.Name = "RegistrarEstudiantebutton";
            this.RegistrarEstudiantebutton.Size = new System.Drawing.Size(108, 23);
            this.RegistrarEstudiantebutton.TabIndex = 4;
            this.RegistrarEstudiantebutton.Text = "Guardar registro";
            this.RegistrarEstudiantebutton.UseVisualStyleBackColor = true;
            this.RegistrarEstudiantebutton.Click += new System.EventHandler(this.RegistrarEstudiantebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cuadro de estudiantes";
            this.label3.Visible = false;
            // 
            // RegistradoslistBox
            // 
            this.RegistradoslistBox.AllowDrop = true;
            this.RegistradoslistBox.FormattingEnabled = true;
            this.RegistradoslistBox.Location = new System.Drawing.Point(262, 285);
            this.RegistradoslistBox.Name = "RegistradoslistBox";
            this.RegistradoslistBox.Size = new System.Drawing.Size(277, 108);
            this.RegistradoslistBox.TabIndex = 7;
            this.RegistradoslistBox.Visible = false;
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Mostrarbutton.Location = new System.Drawing.Point(338, 285);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(108, 23);
            this.Mostrarbutton.TabIndex = 8;
            this.Mostrarbutton.Text = "Mostrar Lista";
            this.Mostrarbutton.UseVisualStyleBackColor = false;
            this.Mostrarbutton.Visible = false;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(288, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "REGISTRO DE ESTUDIANTES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.RegistradoslistBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegistrarEstudiantebutton);
            this.Controls.Add(this.EdadtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreestudiantetextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ingreso de estudiantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreestudiantetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdadtextBox;
        private System.Windows.Forms.Button RegistrarEstudiantebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox RegistradoslistBox;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.Label label4;
    }
}

