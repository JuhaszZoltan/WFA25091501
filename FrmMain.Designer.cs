namespace WFA25091501
{
    partial class FrmMain
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblSzoveg = new Label();
            btnKekBetu = new Button();
            btnFeherHatter = new Button();
            btnTorol = new Button();
            btnJobbKozep = new Button();
            btnKozepKozep = new Button();
            btnBalKozep = new Button();
            btnNagybetus = new Button();
            btnNagyit = new Button();
            btnKicsinyit = new Button();
            btnKilepes = new Button();
            btnAlaphelyzet = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(lblSzoveg, 0, 0);
            tableLayoutPanel1.Controls.Add(btnKekBetu, 0, 1);
            tableLayoutPanel1.Controls.Add(btnFeherHatter, 1, 1);
            tableLayoutPanel1.Controls.Add(btnTorol, 2, 1);
            tableLayoutPanel1.Controls.Add(btnJobbKozep, 2, 2);
            tableLayoutPanel1.Controls.Add(btnKozepKozep, 1, 2);
            tableLayoutPanel1.Controls.Add(btnBalKozep, 0, 2);
            tableLayoutPanel1.Controls.Add(btnNagybetus, 0, 3);
            tableLayoutPanel1.Controls.Add(btnNagyit, 1, 3);
            tableLayoutPanel1.Controls.Add(btnKicsinyit, 2, 3);
            tableLayoutPanel1.Controls.Add(btnKilepes, 2, 4);
            tableLayoutPanel1.Controls.Add(btnAlaphelyzet, 0, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(410, 367);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSzoveg
            // 
            lblSzoveg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblSzoveg.BackColor = Color.Gray;
            tableLayoutPanel1.SetColumnSpan(lblSzoveg, 3);
            lblSzoveg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSzoveg.Location = new Point(5, 5);
            lblSzoveg.Margin = new Padding(5);
            lblSzoveg.Name = "lblSzoveg";
            lblSzoveg.Size = new Size(400, 210);
            lblSzoveg.TabIndex = 0;
            lblSzoveg.Text = "Hello, World!";
            // 
            // btnKekBetu
            // 
            btnKekBetu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKekBetu.Location = new Point(3, 223);
            btnKekBetu.Name = "btnKekBetu";
            btnKekBetu.Size = new Size(130, 30);
            btnKekBetu.TabIndex = 1;
            btnKekBetu.Text = "kék betű";
            btnKekBetu.UseVisualStyleBackColor = true;
            // 
            // btnFeherHatter
            // 
            btnFeherHatter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFeherHatter.Location = new Point(139, 223);
            btnFeherHatter.Name = "btnFeherHatter";
            btnFeherHatter.Size = new Size(130, 30);
            btnFeherHatter.TabIndex = 1;
            btnFeherHatter.Text = "fehér háttér";
            btnFeherHatter.UseVisualStyleBackColor = true;
            // 
            // btnTorol
            // 
            btnTorol.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTorol.Location = new Point(275, 223);
            btnTorol.Name = "btnTorol";
            btnTorol.Size = new Size(132, 30);
            btnTorol.TabIndex = 1;
            btnTorol.Text = "töröl";
            btnTorol.UseVisualStyleBackColor = true;
            // 
            // btnJobbKozep
            // 
            btnJobbKozep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnJobbKozep.Location = new Point(275, 259);
            btnJobbKozep.Name = "btnJobbKozep";
            btnJobbKozep.Size = new Size(132, 30);
            btnJobbKozep.TabIndex = 1;
            btnJobbKozep.Text = "jobb-közép";
            btnJobbKozep.UseVisualStyleBackColor = true;
            // 
            // btnKozepKozep
            // 
            btnKozepKozep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKozepKozep.Location = new Point(139, 259);
            btnKozepKozep.Name = "btnKozepKozep";
            btnKozepKozep.Size = new Size(130, 30);
            btnKozepKozep.TabIndex = 1;
            btnKozepKozep.Text = "közép-közép";
            btnKozepKozep.UseVisualStyleBackColor = true;
            // 
            // btnBalKozep
            // 
            btnBalKozep.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBalKozep.Location = new Point(3, 259);
            btnBalKozep.Name = "btnBalKozep";
            btnBalKozep.Size = new Size(130, 30);
            btnBalKozep.TabIndex = 1;
            btnBalKozep.Text = "bal-közép";
            btnBalKozep.UseVisualStyleBackColor = true;
            // 
            // btnNagybetus
            // 
            btnNagybetus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNagybetus.Location = new Point(3, 295);
            btnNagybetus.Name = "btnNagybetus";
            btnNagybetus.Size = new Size(130, 30);
            btnNagybetus.TabIndex = 1;
            btnNagybetus.Text = "nagybetűs";
            btnNagybetus.UseVisualStyleBackColor = true;
            // 
            // btnNagyit
            // 
            btnNagyit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNagyit.Location = new Point(139, 295);
            btnNagyit.Name = "btnNagyit";
            btnNagyit.Size = new Size(130, 30);
            btnNagyit.TabIndex = 1;
            btnNagyit.Text = "nagyít";
            btnNagyit.UseVisualStyleBackColor = true;
            // 
            // btnKicsinyit
            // 
            btnKicsinyit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKicsinyit.Location = new Point(275, 295);
            btnKicsinyit.Name = "btnKicsinyit";
            btnKicsinyit.Size = new Size(132, 30);
            btnKicsinyit.TabIndex = 1;
            btnKicsinyit.Text = "kicsinyít";
            btnKicsinyit.UseVisualStyleBackColor = true;
            // 
            // btnKilepes
            // 
            btnKilepes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnKilepes.Location = new Point(275, 331);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(132, 33);
            btnKilepes.TabIndex = 1;
            btnKilepes.Text = "kilépés";
            btnKilepes.UseVisualStyleBackColor = true;
            // 
            // btnAlaphelyzet
            // 
            btnAlaphelyzet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAlaphelyzet.Location = new Point(3, 331);
            btnAlaphelyzet.Name = "btnAlaphelyzet";
            btnAlaphelyzet.Size = new Size(130, 33);
            btnAlaphelyzet.TabIndex = 1;
            btnAlaphelyzet.Text = "alaphelyzet";
            btnAlaphelyzet.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 391);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(450, 430);
            Name = "FrmMain";
            Text = "Szöveg formázás";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblSzoveg;
        private Button btnKekBetu;
        private Button btnFeherHatter;
        private Button btnTorol;
        private Button btnJobbKozep;
        private Button btnKozepKozep;
        private Button btnBalKozep;
        private Button btnNagybetus;
        private Button btnNagyit;
        private Button btnKicsinyit;
        private Button btnKilepes;
        private Button btnAlaphelyzet;
    }
}
