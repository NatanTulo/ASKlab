namespace _1_Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.one = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.equals = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.negate = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.clear_entry = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.digital_clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.analog = new System.Windows.Forms.Button();
            this.digital = new System.Windows.Forms.Button();
            this.analog_clock = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.skórkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oragneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zegarAnalogowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.różowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomarańczowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niebieskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zielonyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.analog_clock)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.one.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.one.Location = new System.Drawing.Point(3, 578);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(130, 80);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plus.Location = new System.Drawing.Point(405, 578);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(130, 80);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.button2_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.six.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.six.Location = new System.Drawing.Point(271, 494);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(130, 80);
            this.six.TabIndex = 2;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.equals.Cursor = System.Windows.Forms.Cursors.Default;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equals.Location = new System.Drawing.Point(405, 662);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(130, 80);
            this.equals.TabIndex = 3;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.button4_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.five.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.five.Location = new System.Drawing.Point(137, 494);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(130, 80);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.three.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.three.Location = new System.Drawing.Point(271, 578);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(130, 80);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eight.Location = new System.Drawing.Point(137, 410);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(130, 80);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nine.Location = new System.Drawing.Point(271, 410);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(130, 80);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minus.Location = new System.Drawing.Point(405, 494);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(130, 80);
            this.minus.TabIndex = 8;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.percent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.percent.Location = new System.Drawing.Point(3, 326);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(130, 80);
            this.percent.TabIndex = 9;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.button10_Click);
            // 
            // negate
            // 
            this.negate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.negate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.negate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.negate.Location = new System.Drawing.Point(3, 662);
            this.negate.Name = "negate";
            this.negate.Size = new System.Drawing.Size(130, 80);
            this.negate.TabIndex = 10;
            this.negate.Text = "+/-";
            this.negate.UseVisualStyleBackColor = false;
            this.negate.Click += new System.EventHandler(this.negate_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zero.Location = new System.Drawing.Point(137, 662);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(130, 80);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.four.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.four.Location = new System.Drawing.Point(3, 494);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(130, 80);
            this.four.TabIndex = 12;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(271, 326);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(130, 80);
            this.clear.TabIndex = 14;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.division.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.division.Location = new System.Drawing.Point(405, 326);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(130, 80);
            this.division.TabIndex = 15;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.two.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.two.Location = new System.Drawing.Point(137, 578);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(130, 80);
            this.two.TabIndex = 16;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // clear_entry
            // 
            this.clear_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.clear_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear_entry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear_entry.Location = new System.Drawing.Point(137, 326);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(130, 80);
            this.clear_entry.TabIndex = 17;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = false;
            this.clear_entry.Click += new System.EventHandler(this.clear_entry_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seven.Location = new System.Drawing.Point(3, 410);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(130, 80);
            this.seven.TabIndex = 18;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiply.Location = new System.Drawing.Point(405, 410);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(130, 80);
            this.multiply.TabIndex = 19;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comma.Location = new System.Drawing.Point(271, 662);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(130, 80);
            this.comma.TabIndex = 20;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(9, 220);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 100);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // digital_clock
            // 
            this.digital_clock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.digital_clock.AutoSize = true;
            this.digital_clock.Font = new System.Drawing.Font("Digital-7 Italic", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digital_clock.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.digital_clock.Location = new System.Drawing.Point(163, 56);
            this.digital_clock.Name = "digital_clock";
            this.digital_clock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.digital_clock.Size = new System.Drawing.Size(358, 103);
            this.digital_clock.TabIndex = 22;
            this.digital_clock.Text = "00:00:00";
            this.digital_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.digital_clock.Click += new System.EventHandler(this.digital_clock_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // analog
            // 
            this.analog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.analog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.analog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.analog.Location = new System.Drawing.Point(36, 110);
            this.analog.Name = "analog";
            this.analog.Size = new System.Drawing.Size(90, 35);
            this.analog.TabIndex = 23;
            this.analog.Text = "ANALOG";
            this.analog.UseVisualStyleBackColor = false;
            this.analog.Click += new System.EventHandler(this.analog_Click);
            // 
            // digital
            // 
            this.digital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.digital.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.digital.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.digital.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.digital.Location = new System.Drawing.Point(36, 71);
            this.digital.Name = "digital";
            this.digital.Size = new System.Drawing.Size(90, 35);
            this.digital.TabIndex = 24;
            this.digital.Text = "DIGITAL";
            this.digital.UseVisualStyleBackColor = false;
            this.digital.Click += new System.EventHandler(this.digital_Click);
            // 
            // analog_clock
            // 
            this.analog_clock.Image = ((System.Drawing.Image)(resources.GetObject("analog_clock.Image")));
            this.analog_clock.Location = new System.Drawing.Point(146, 21);
            this.analog_clock.Name = "analog_clock";
            this.analog_clock.Size = new System.Drawing.Size(265, 209);
            this.analog_clock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.analog_clock.TabIndex = 25;
            this.analog_clock.TabStop = false;
            this.analog_clock.Visible = false;
            this.analog_clock.Click += new System.EventHandler(this.pictureBox1_Click);
            this.analog_clock.Paint += new System.Windows.Forms.PaintEventHandler(this.analog_clock_paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skórkaToolStripMenuItem,
            this.zegarAnalogowyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // skórkaToolStripMenuItem
            // 
            this.skórkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pinkToolStripMenuItem,
            this.oragneToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.skórkaToolStripMenuItem.Name = "skórkaToolStripMenuItem";
            this.skórkaToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.skórkaToolStripMenuItem.Text = "Skórka";
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.pinkToolStripMenuItem.Text = "Różowa";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // oragneToolStripMenuItem
            // 
            this.oragneToolStripMenuItem.Name = "oragneToolStripMenuItem";
            this.oragneToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.oragneToolStripMenuItem.Text = "Pomarańczowa";
            this.oragneToolStripMenuItem.Click += new System.EventHandler(this.oragneToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.blueToolStripMenuItem.Text = "Niebieska";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.greenToolStripMenuItem.Text = "Zielona";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // zegarAnalogowyToolStripMenuItem
            // 
            this.zegarAnalogowyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.różowyToolStripMenuItem,
            this.pomarańczowyToolStripMenuItem,
            this.niebieskiToolStripMenuItem,
            this.zielonyToolStripMenuItem});
            this.zegarAnalogowyToolStripMenuItem.Name = "zegarAnalogowyToolStripMenuItem";
            this.zegarAnalogowyToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.zegarAnalogowyToolStripMenuItem.Text = "Zegar analogowy";
            // 
            // różowyToolStripMenuItem
            // 
            this.różowyToolStripMenuItem.Name = "różowyToolStripMenuItem";
            this.różowyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.różowyToolStripMenuItem.Text = "Różowy";
            // 
            // pomarańczowyToolStripMenuItem
            // 
            this.pomarańczowyToolStripMenuItem.Name = "pomarańczowyToolStripMenuItem";
            this.pomarańczowyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pomarańczowyToolStripMenuItem.Text = "Pomarańczowy";
            this.pomarańczowyToolStripMenuItem.Click += new System.EventHandler(this.pomarańczowyToolStripMenuItem_Click);
            // 
            // niebieskiToolStripMenuItem
            // 
            this.niebieskiToolStripMenuItem.Name = "niebieskiToolStripMenuItem";
            this.niebieskiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.niebieskiToolStripMenuItem.Text = "Niebieski";
            // 
            // zielonyToolStripMenuItem
            // 
            this.zielonyToolStripMenuItem.Name = "zielonyToolStripMenuItem";
            this.zielonyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.zielonyToolStripMenuItem.Text = "Zielony";
            this.zielonyToolStripMenuItem.Click += new System.EventHandler(this.zielonyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(537, 753);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.digital);
            this.Controls.Add(this.analog);
            this.Controls.Add(this.digital_clock);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.clear_entry);
            this.Controls.Add(this.two);
            this.Controls.Add(this.division);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.four);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.negate);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.three);
            this.Controls.Add(this.five);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.six);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.one);
            this.Controls.Add(this.analog_clock);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calculator with clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.analog_clock)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button negate;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button clear_entry;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button comma;
        public System.Windows.Forms.Button equals;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label digital_clock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button analog;
        private System.Windows.Forms.Button digital;
        private System.Windows.Forms.PictureBox analog_clock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem skórkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oragneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zegarAnalogowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem różowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomarańczowyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niebieskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zielonyToolStripMenuItem;
    }
}

