namespace TriviaJatek
{
    partial class KérdésUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(32, 49);
            button1.Name = "button1";
            button1.Size = new Size(350, 22);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 100);
            button3.Name = "button3";
            button3.Size = new Size(350, 22);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += this.button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(449, 49);
            button2.Name = "button2";
            button2.Size = new Size(350, 22);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += this.button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(449, 100);
            button4.Name = "button4";
            button4.Size = new Size(350, 22);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += this.button4_Click;
            // 
            // KérdésUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "KérdésUserControl";
            Size = new Size(935, 170);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Button button1;
        public Button button3;
        public Button button2;
        public Button button4;
    }
}
