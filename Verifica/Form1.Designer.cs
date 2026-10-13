namespace Verifica
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
            lettura = new Button();
            label1 = new Label();
            label2 = new Label();
            inizio = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // lettura
            // 
            lettura.Font = new Font("Segoe UI", 12F);
            lettura.Location = new Point(244, 257);
            lettura.Name = "lettura";
            lettura.Size = new Size(202, 63);
            lettura.TabIndex = 0;
            lettura.Text = "Leggere File";
            lettura.UseVisualStyleBackColor = true;
            lettura.Click += lettura_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(229, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 54);
            label1.TabIndex = 1;
            label1.Text = "Cifrario Cesare ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 63);
            label2.Name = "label2";
            label2.Size = new Size(301, 15);
            label2.TabIndex = 2;
            label2.Text = "Leggero solo le parole che sono in posizione pari nel file";
            // 
            // inizio
            // 
            inizio.Font = new Font("Segoe UI", 12F);
            inizio.Location = new Point(244, 257);
            inizio.Name = "inizio";
            inizio.Size = new Size(202, 63);
            inizio.TabIndex = 3;
            inizio.Text = "iniziamo";
            inizio.UseVisualStyleBackColor = true;
            inizio.Click += inizio_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(50, 153);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(188, 229);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(475, 153);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(160, 229);
            listBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(inizio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lettura);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button lettura;
        private Label label1;
        private Label label2;
        private Button inizio;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}
