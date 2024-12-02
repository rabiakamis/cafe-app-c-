namespace Supertramp_Cafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            listBox1 = new ListBox();
            cartLabel = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            pancakePictureBox = new PictureBox();
            hotdogPictureBox = new PictureBox();
            pizzaPictureBox = new PictureBox();
            HamburgerpictureBox = new PictureBox();
            cupcakepictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pancakePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotdogPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pizzaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HamburgerpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cupcakepictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(150, 450);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.IndianRed;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 390);
            label2.Name = "label2";
            label2.Size = new Size(150, 60);
            label2.TabIndex = 1;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 120);
            label1.Name = "label1";
            label1.Size = new Size(139, 17);
            label1.TabIndex = 0;
            label1.Text = "Supertramp Cafe";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(cartLabel);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(650, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(150, 450);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Lucida Sans", 9F, FontStyle.Bold);
            button1.Location = new Point(0, 390);
            button1.Name = "button1";
            button1.Size = new Size(150, 60);
            button1.TabIndex = 2;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 284);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Font = new Font("Lucida Sans", 9F, FontStyle.Bold);
            cartLabel.Location = new Point(52, 31);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(42, 17);
            cartLabel.TabIndex = 0;
            cartLabel.Text = "Cart";
            cartLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pancakePictureBox);
            panel3.Controls.Add(hotdogPictureBox);
            panel3.Controls.Add(pizzaPictureBox);
            panel3.Controls.Add(HamburgerpictureBox);
            panel3.Controls.Add(cupcakepictureBox);
            panel3.Cursor = Cursors.Hand;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(150, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 450);
            panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(326, 225);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(174, 225);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pancakePictureBox
            // 
            pancakePictureBox.Image = Properties.Resources.pancake;
            pancakePictureBox.Location = new Point(166, 225);
            pancakePictureBox.Name = "pancakePictureBox";
            pancakePictureBox.Size = new Size(159, 225);
            pancakePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pancakePictureBox.TabIndex = 4;
            pancakePictureBox.TabStop = false;
            pancakePictureBox.Click += PancakepictureBox_Click;
            // 
            // hotdogPictureBox
            // 
            hotdogPictureBox.Image = Properties.Resources.hotdog;
            hotdogPictureBox.Location = new Point(0, 225);
            hotdogPictureBox.Name = "hotdogPictureBox";
            hotdogPictureBox.Size = new Size(169, 225);
            hotdogPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            hotdogPictureBox.TabIndex = 3;
            hotdogPictureBox.TabStop = false;
            hotdogPictureBox.Click += HotdogpictureBox_Click;
            // 
            // pizzaPictureBox
            // 
            pizzaPictureBox.Image = Properties.Resources.pizza;
            pizzaPictureBox.Location = new Point(326, 0);
            pizzaPictureBox.Name = "pizzaPictureBox";
            pizzaPictureBox.Size = new Size(174, 225);
            pizzaPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pizzaPictureBox.TabIndex = 2;
            pizzaPictureBox.TabStop = false;
            pizzaPictureBox.Click += PizzapictureBox_Click;
            // 
            // HamburgerpictureBox
            // 
            HamburgerpictureBox.Image = Properties.Resources.hamburger;
            HamburgerpictureBox.Location = new Point(166, 0);
            HamburgerpictureBox.Name = "HamburgerpictureBox";
            HamburgerpictureBox.Size = new Size(159, 225);
            HamburgerpictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            HamburgerpictureBox.TabIndex = 1;
            HamburgerpictureBox.TabStop = false;
            HamburgerpictureBox.Click += HamburgerpictureBox_Click;
            // 
            // cupcakepictureBox
            // 
            cupcakepictureBox.Image = Properties.Resources.cupcake;
            cupcakepictureBox.Location = new Point(0, 0);
            cupcakepictureBox.Name = "cupcakepictureBox";
            cupcakepictureBox.Size = new Size(169, 225);
            cupcakepictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            cupcakepictureBox.TabIndex = 0;
            cupcakepictureBox.TabStop = false;
            cupcakepictureBox.Click += CupcakepictureBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Supertramp Cafe";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pancakePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotdogPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pizzaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)HamburgerpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cupcakepictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label cartLabel;
        private Button button1;
        private ListBox listBox1;
        private Label label2;
        private PictureBox cupcakepictureBox;
        private PictureBox HamburgerpictureBox;
        private PictureBox cheseepictureBox;
        private PictureBox pancakePictureBox;
        private PictureBox hotdogPictureBox;
        private PictureBox pizzaPictureBox;
        private PictureBox cheesePictureBox;
        private PictureBox pictureBox2;
    }
}
