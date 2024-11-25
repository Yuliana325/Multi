namespace multi
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
            panel1 = new Panel();
            label3 = new Label();
            richTextBoxRes = new RichTextBox();
            textBoxN1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonCalcu = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(richTextBoxRes);
            panel1.Controls.Add(textBoxN1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonCalcu);
            panel1.Location = new Point(8, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 431);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 11.249999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(141, 65);
            label3.Name = "label3";
            label3.Size = new Size(515, 21);
            label3.TabIndex = 5;
            label3.Text = "------------------------------PAOLA YULIANA COLUNGA MERA---------------------------";
            // 
            // richTextBoxRes
            // 
            richTextBoxRes.Location = new Point(436, 100);
            richTextBoxRes.Name = "richTextBoxRes";
            richTextBoxRes.Size = new Size(199, 235);
            richTextBoxRes.TabIndex = 4;
            richTextBoxRes.Text = "";
            // 
            // textBoxN1
            // 
            textBoxN1.Location = new Point(279, 139);
            textBoxN1.Name = "textBoxN1";
            textBoxN1.Size = new Size(108, 23);
            textBoxN1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 132);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 2;
            label2.Text = "¿Cual tabla te muestro?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 30);
            label1.Name = "label1";
            label1.Size = new Size(315, 35);
            label1.TabIndex = 1;
            label1.Text = "TABLA DE MULTIPLICAR";
            // 
            // buttonCalcu
            // 
            buttonCalcu.BackColor = Color.Fuchsia;
            buttonCalcu.Font = new Font("Sitka Heading", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonCalcu.ForeColor = SystemColors.ControlText;
            buttonCalcu.Location = new Point(62, 194);
            buttonCalcu.Name = "buttonCalcu";
            buttonCalcu.Size = new Size(179, 33);
            buttonCalcu.TabIndex = 0;
            buttonCalcu.Text = "Calcular";
            buttonCalcu.UseVisualStyleBackColor = false;
            buttonCalcu.Click += buttonCalcu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonCalcu;
        private TextBox textBoxN1;
        private Label label2;
        private RichTextBox richTextBoxRes;
        private Label label3;
    }
}
