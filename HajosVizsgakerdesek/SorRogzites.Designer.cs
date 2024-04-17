namespace HajosVizsgakerdesek
{
    partial class SorRogzites
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(205, 307);
            button1.Name = "button1";
            button1.Size = new Size(95, 46);
            button1.TabIndex = 0;
            button1.Text = "&Mégsem";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AccessibleRole = AccessibleRole.None;
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(306, 307);
            button2.Name = "button2";
            button2.Size = new Size(95, 46);
            button2.TabIndex = 1;
            button2.Text = "&Ok";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Szam", true));
            textBox1.Location = new Point(15, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Kerdes", true));
            textBox2.Location = new Point(15, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(386, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Tag", bindingSource1, "V1", true));
            textBox3.Location = new Point(15, 136);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(386, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "V2", true));
            textBox4.Location = new Point(15, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(386, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "V3", true));
            textBox5.Location = new Point(15, 194);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(386, 23);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "Kep", true));
            textBox6.Location = new Point(15, 223);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(386, 23);
            textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "HelyesValasz", true));
            textBox7.Location = new Point(15, 252);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(386, 23);
            textBox7.TabIndex = 8;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Kviz);
            // 
            // SorRogzites
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 398);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "SorRogzites";
            Text = "SorRogzites";
            Load += SorRogzites_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private BindingSource bindingSource1;
    }
}