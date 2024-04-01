namespace FunkoLottery
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
            components = new System.ComponentModel.Container();
            lblScreen = new Label();
            tablePictureContainer = new TableLayoutPanel();
            pbxNumberTwo = new PictureBox();
            pbxNumberOne = new PictureBox();
            pbxNumberThree = new PictureBox();
            btnDraw = new Button();
            lblWinMessage = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tablePictureContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxNumberTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxNumberOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxNumberThree).BeginInit();
            SuspendLayout();
            // 
            // lblScreen
            // 
            lblScreen.Dock = DockStyle.Top;
            lblScreen.Font = new Font("Showcard Gothic", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScreen.Location = new Point(0, 0);
            lblScreen.Name = "lblScreen";
            lblScreen.Size = new Size(682, 66);
            lblScreen.TabIndex = 0;
            lblScreen.Text = "Marvel Lottery";
            lblScreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tablePictureContainer
            // 
            tablePictureContainer.ColumnCount = 3;
            tablePictureContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.5117836F));
            tablePictureContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.976429F));
            tablePictureContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.5117836F));
            tablePictureContainer.Controls.Add(pbxNumberTwo, 1, 0);
            tablePictureContainer.Controls.Add(pbxNumberOne, 0, 0);
            tablePictureContainer.Controls.Add(pbxNumberThree, 2, 0);
            tablePictureContainer.Location = new Point(12, 89);
            tablePictureContainer.Name = "tablePictureContainer";
            tablePictureContainer.RowCount = 1;
            tablePictureContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablePictureContainer.Size = new Size(658, 199);
            tablePictureContainer.TabIndex = 1;
            // 
            // pbxNumberTwo
            // 
            pbxNumberTwo.BackColor = Color.Gold;
            pbxNumberTwo.Dock = DockStyle.Fill;
            pbxNumberTwo.Location = new Point(230, 3);
            pbxNumberTwo.Name = "pbxNumberTwo";
            pbxNumberTwo.Size = new Size(197, 193);
            pbxNumberTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxNumberTwo.TabIndex = 2;
            pbxNumberTwo.TabStop = false;
            // 
            // pbxNumberOne
            // 
            pbxNumberOne.BackColor = Color.Gold;
            pbxNumberOne.Dock = DockStyle.Fill;
            pbxNumberOne.Location = new Point(3, 3);
            pbxNumberOne.Name = "pbxNumberOne";
            pbxNumberOne.Size = new Size(221, 193);
            pbxNumberOne.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxNumberOne.TabIndex = 1;
            pbxNumberOne.TabStop = false;
            // 
            // pbxNumberThree
            // 
            pbxNumberThree.BackColor = Color.Gold;
            pbxNumberThree.Dock = DockStyle.Fill;
            pbxNumberThree.Location = new Point(433, 3);
            pbxNumberThree.Name = "pbxNumberThree";
            pbxNumberThree.Size = new Size(222, 193);
            pbxNumberThree.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxNumberThree.TabIndex = 0;
            pbxNumberThree.TabStop = false;
            // 
            // btnDraw
            // 
            btnDraw.BackColor = Color.Silver;
            btnDraw.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDraw.ForeColor = Color.DarkRed;
            btnDraw.Location = new Point(264, 317);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(148, 60);
            btnDraw.TabIndex = 2;
            btnDraw.Text = "Lets ROLL!";
            btnDraw.UseVisualStyleBackColor = false;
            btnDraw.Click += btnDraw_Click;
            // 
            // lblWinMessage
            // 
            lblWinMessage.Dock = DockStyle.Bottom;
            lblWinMessage.Font = new Font("Showcard Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWinMessage.ImageAlign = ContentAlignment.TopCenter;
            lblWinMessage.Location = new Point(0, 405);
            lblWinMessage.Name = "lblWinMessage";
            lblWinMessage.Size = new Size(682, 48);
            lblWinMessage.TabIndex = 3;
            lblWinMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(682, 453);
            Controls.Add(lblWinMessage);
            Controls.Add(btnDraw);
            Controls.Add(tablePictureContainer);
            Controls.Add(lblScreen);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tablePictureContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxNumberTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxNumberOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxNumberThree).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblScreen;
        private TableLayoutPanel tablePictureContainer;
        private PictureBox pbxNumberTwo;
        private PictureBox pbxNumberOne;
        private PictureBox pbxNumberThree;
        private Button btnDraw;
        private Label lblWinMessage;
        private System.Windows.Forms.Timer timer1;
    }
}
