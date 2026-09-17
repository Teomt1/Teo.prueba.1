namespace Teo.prueba._1.PedidosMaterial
{
    partial class SolicitudMaterialForm
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
            botonsalir = new Button();
            checkedListBox1 = new CheckedListBox();
            // 
            // botonsalir
            // 
            botonsalir.Location = new Point(333, 321);
            botonsalir.Name = "botonsalir";
            botonsalir.Size = new Size(88, 26);
            botonsalir.TabIndex = 0;
            botonsalir.Text = "Salir";
            botonsalir.UseVisualStyleBackColor = true;
            botonsalir.Click += botonsalir_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Opcion 1", "Opcion 2", "Opcion 3", "Opcion 4", "Opcion 5" });
            checkedListBox1.Location = new Point(295, 90);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(152, 130);
            checkedListBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(botonsalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button botonsalir;
        private CheckedListBox checkedListBox1;
    }
}