namespace Ahorcado
{
    partial class HangMan
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 52);
            label1.Name = "label1";
            label1.Size = new Size(341, 42);
            label1.TabIndex = 0;
            label1.Text = "Numero de Intentos";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(456, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(69, 42);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(417, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(394, 309);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(50, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(369, 399);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 183);
            label2.Name = "label2";
            label2.Size = new Size(284, 39);
            label2.TabIndex = 7;
            label2.Text = "Palabra a Adivinar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(106, 297);
            label3.Name = "label3";
            label3.Size = new Size(268, 39);
            label3.TabIndex = 8;
            label3.Text = "Letra del Usuario";
            // 
            // HangMan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "HangMan";
            Text = "HangMan";
            Load += HangMan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label2;
        private Label label3;
    }
}