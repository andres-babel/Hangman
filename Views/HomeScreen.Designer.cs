namespace Ahorcado
{
    partial class HomeScreen
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 64);
            label1.Name = "label1";
            label1.Size = new Size(377, 45);
            label1.TabIndex = 0;
            label1.Text = "Escriba su Nombre: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(410, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(314, 45);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(614, 130);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "HomeScreen";
            Text = "Form1";
            Load += HomeScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
    }
}