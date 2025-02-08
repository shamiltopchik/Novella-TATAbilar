namespace Новелла
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            Play = new Button();
            Setings = new Button();
            button1 = new Button();
            text = new Label();
            button2 = new Button();
            text2 = new Label();
            text3 = new Label();
            text4 = new Label();
            SuspendLayout();
            // 
            // Play
            // 
            Play.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Play.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Play.Cursor = Cursors.Hand;
            Play.Location = new Point(345, 256);
            Play.Name = "Play";
            Play.Size = new Size(120, 27);
            Play.TabIndex = 0;
            Play.Text = "Играть";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Setings
            // 
            Setings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Setings.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Setings.Cursor = Cursors.Hand;
            Setings.Location = new Point(345, 292);
            Setings.Name = "Setings";
            Setings.Size = new Size(120, 27);
            Setings.TabIndex = 0;
            Setings.Text = "Настройки";
            Setings.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(713, 23);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Дальше";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // text
            // 
            text.Location = new Point(314, 165);
            text.Name = "text";
            text.Size = new Size(0, 15);
            text.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(713, 52);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Дальше";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // text2
            // 
            text2.AutoSize = true;
            text2.Location = new Point(593, 152);
            text2.Name = "text2";
            text2.Size = new Size(0, 15);
            text2.TabIndex = 4;
            // 
            // text3
            // 
            text3.AutoSize = true;
            text3.Location = new Point(719, 124);
            text3.Name = "text3";
            text3.Size = new Size(0, 15);
            text3.TabIndex = 5;
            // 
            // text4
            // 
            text4.AutoSize = true;
            text4.Location = new Point(713, 87);
            text4.Name = "text4";
            text4.Size = new Size(0, 15);
            text4.TabIndex = 6;
            // 
            // Mainmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 447);
            Controls.Add(text4);
            Controls.Add(text3);
            Controls.Add(text2);
            Controls.Add(button2);
            Controls.Add(text);
            Controls.Add(button1);
            Controls.Add(Setings);
            Controls.Add(Play);
            DoubleBuffered = true;
            Name = "Mainmenu";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play;
        private Button Setings;
        private Button button1;
        private Label text;
        private Button button2;
        private Label text2;
        private Label text3;
        private Label text4;
    }
}
