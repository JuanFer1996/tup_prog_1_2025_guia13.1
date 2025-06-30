namespace Ejercicio4
{
    partial class fResumen
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
            button1 = new Button();
            listBoxPatentes = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(87, 388);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBoxPatentes
            // 
            listBoxPatentes.FormattingEnabled = true;
            listBoxPatentes.ItemHeight = 15;
            listBoxPatentes.Location = new Point(24, 12);
            listBoxPatentes.Name = "listBoxPatentes";
            listBoxPatentes.Size = new Size(225, 349);
            listBoxPatentes.TabIndex = 2;
            // 
            // fResumen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 438);
            Controls.Add(button1);
            Controls.Add(listBoxPatentes);
            Name = "fResumen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fResumen";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        public ListBox listBoxPatentes;
    }
}