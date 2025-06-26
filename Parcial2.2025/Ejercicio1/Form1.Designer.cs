namespace Ejercicio1
{
    partial class Form1
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
            btnRegistrar = new Button();
            btnRegistrarViaje = new Button();
            btnResumenFinal = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            labelCantViajes = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(12, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(98, 43);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += button1_Click;
            // 
            // btnRegistrarViaje
            // 
            btnRegistrarViaje.Location = new Point(12, 75);
            btnRegistrarViaje.Name = "btnRegistrarViaje";
            btnRegistrarViaje.Size = new Size(98, 57);
            btnRegistrarViaje.TabIndex = 1;
            btnRegistrarViaje.Text = "Cargar Viaje";
            btnRegistrarViaje.UseVisualStyleBackColor = true;
            btnRegistrarViaje.Click += btnRegistrarViaje_Click;
            // 
            // btnResumenFinal
            // 
            btnResumenFinal.Location = new Point(12, 150);
            btnResumenFinal.Name = "btnResumenFinal";
            btnResumenFinal.Size = new Size(98, 51);
            btnResumenFinal.TabIndex = 2;
            btnResumenFinal.Text = "Resumen Final";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(165, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 214);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 249);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Viajes :";
            // 
            // labelCantViajes
            // 
            labelCantViajes.AutoSize = true;
            labelCantViajes.Location = new Point(214, 249);
            labelCantViajes.Name = "labelCantViajes";
            labelCantViajes.Size = new Size(0, 15);
            labelCantViajes.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 298);
            Controls.Add(labelCantViajes);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(btnResumenFinal);
            Controls.Add(btnRegistrarViaje);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Button btnRegistrarViaje;
        private Button btnResumenFinal;
        private ListBox listBox1;
        private Label label1;
        public Label labelCantViajes;
    }
}
