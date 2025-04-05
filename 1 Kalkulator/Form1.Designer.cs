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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.analog_clock)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.one.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.one.Location = new System.Drawing.Point(2, 470);
            this.one.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(98, 65);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.calc_Click);
            this.one.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.plus.Location = new System.Drawing.Point(304, 470);
            this.plus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(98, 65);
            this.plus.TabIndex = 1;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.calc_Click);
            this.plus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.six.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.six.Location = new System.Drawing.Point(203, 401);
            this.six.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(98, 65);
            this.six.TabIndex = 2;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.calc_Click);
            this.six.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.equals.Cursor = System.Windows.Forms.Cursors.Default;
            this.equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.equals.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.equals.Location = new System.Drawing.Point(304, 538);
            this.equals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(98, 65);
            this.equals.TabIndex = 3;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = false;
            this.equals.Click += new System.EventHandler(this.calc_Click);
            this.equals.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.five.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.five.Location = new System.Drawing.Point(103, 401);
            this.five.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(98, 65);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.calc_Click);
            this.five.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.three.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.three.Location = new System.Drawing.Point(203, 470);
            this.three.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(98, 65);
            this.three.TabIndex = 5;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.calc_Click);
            this.three.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.eight.Location = new System.Drawing.Point(103, 333);
            this.eight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(98, 65);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.calc_Click);
            this.eight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nine.Location = new System.Drawing.Point(203, 333);
            this.nine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(98, 65);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.calc_Click);
            this.nine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minus.Location = new System.Drawing.Point(304, 401);
            this.minus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(98, 65);
            this.minus.TabIndex = 8;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.calc_Click);
            this.minus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // percent
            // 
            this.percent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.percent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.percent.Location = new System.Drawing.Point(2, 265);
            this.percent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(98, 65);
            this.percent.TabIndex = 9;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.calc_Click);
            this.percent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // negate
            // 
            this.negate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.negate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.negate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.negate.Location = new System.Drawing.Point(2, 538);
            this.negate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.negate.Name = "negate";
            this.negate.Size = new System.Drawing.Size(98, 65);
            this.negate.TabIndex = 10;
            this.negate.Text = "+/-";
            this.negate.UseVisualStyleBackColor = false;
            this.negate.Click += new System.EventHandler(this.calc_Click);
            this.negate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zero.Location = new System.Drawing.Point(103, 538);
            this.zero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(98, 65);
            this.zero.TabIndex = 11;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.calc_Click);
            this.zero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.four.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.four.Location = new System.Drawing.Point(2, 401);
            this.four.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(98, 65);
            this.four.TabIndex = 12;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.calc_Click);
            this.four.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear.Location = new System.Drawing.Point(203, 265);
            this.clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(98, 65);
            this.clear.TabIndex = 14;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.calc_Click);
            this.clear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.division.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.division.Location = new System.Drawing.Point(304, 265);
            this.division.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(98, 65);
            this.division.TabIndex = 15;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.calc_Click);
            this.division.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.two.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.two.Location = new System.Drawing.Point(103, 470);
            this.two.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(98, 65);
            this.two.TabIndex = 16;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.calc_Click);
            this.two.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // clear_entry
            // 
            this.clear_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.clear_entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clear_entry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear_entry.Location = new System.Drawing.Point(103, 265);
            this.clear_entry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clear_entry.Name = "clear_entry";
            this.clear_entry.Size = new System.Drawing.Size(98, 65);
            this.clear_entry.TabIndex = 17;
            this.clear_entry.Text = "CE";
            this.clear_entry.UseVisualStyleBackColor = false;
            this.clear_entry.Click += new System.EventHandler(this.calc_Click);
            this.clear_entry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.seven.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seven.Location = new System.Drawing.Point(2, 333);
            this.seven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(98, 65);
            this.seven.TabIndex = 18;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.calc_Click);
            this.seven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiply.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.multiply.Location = new System.Drawing.Point(304, 333);
            this.multiply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(98, 65);
            this.multiply.TabIndex = 19;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.calc_Click);
            this.multiply.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(189)))), ((int)(((byte)(188)))));
            this.comma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comma.Location = new System.Drawing.Point(203, 538);
            this.comma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(98, 65);
            this.comma.TabIndex = 20;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.calc_Click);
            this.comma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calc_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(7, 179);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 82);
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
            this.digital_clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digital_clock.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.digital_clock.Location = new System.Drawing.Point(122, 46);
            this.digital_clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.digital_clock.Name = "digital_clock";
            this.digital_clock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.digital_clock.Size = new System.Drawing.Size(347, 91);
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
            this.analog.Location = new System.Drawing.Point(27, 89);
            this.analog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.analog.Name = "analog";
            this.analog.Size = new System.Drawing.Size(68, 28);
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
            this.digital.Location = new System.Drawing.Point(27, 58);
            this.digital.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.digital.Name = "digital";
            this.digital.Size = new System.Drawing.Size(68, 28);
            this.digital.TabIndex = 24;
            this.digital.Text = "DIGITAL";
            this.digital.UseVisualStyleBackColor = false;
            this.digital.Click += new System.EventHandler(this.digital_Click);
            // 
            // analog_clock
            // 
            this.analog_clock.Image = ((System.Drawing.Image)(resources.GetObject("analog_clock.Image")));
            this.analog_clock.Location = new System.Drawing.Point(110, 17);
            this.analog_clock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.analog_clock.Name = "analog_clock";
            this.analog_clock.Size = new System.Drawing.Size(199, 170);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(403, 24);
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
            this.skórkaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.skórkaToolStripMenuItem.Text = "Skórka";
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pinkToolStripMenuItem.Text = "Różowa";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // oragneToolStripMenuItem
            // 
            this.oragneToolStripMenuItem.Name = "oragneToolStripMenuItem";
            this.oragneToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.oragneToolStripMenuItem.Text = "Pomarańczowa";
            this.oragneToolStripMenuItem.Click += new System.EventHandler(this.oragneToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.blueToolStripMenuItem.Text = "Niebieska";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
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
            this.zegarAnalogowyToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.zegarAnalogowyToolStripMenuItem.Text = "Zegar analogowy";
            // 
            // różowyToolStripMenuItem
            // 
            this.różowyToolStripMenuItem.Name = "różowyToolStripMenuItem";
            this.różowyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.różowyToolStripMenuItem.Text = "Różowy";
            this.różowyToolStripMenuItem.Click += new System.EventHandler(this.różowyToolStripMenuItem_Click);
            // 
            // pomarańczowyToolStripMenuItem
            // 
            this.pomarańczowyToolStripMenuItem.Name = "pomarańczowyToolStripMenuItem";
            this.pomarańczowyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pomarańczowyToolStripMenuItem.Text = "Pomarańczowy";
            this.pomarańczowyToolStripMenuItem.Click += new System.EventHandler(this.pomarańczowyToolStripMenuItem_Click);
            // 
            // niebieskiToolStripMenuItem
            // 
            this.niebieskiToolStripMenuItem.Name = "niebieskiToolStripMenuItem";
            this.niebieskiToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.niebieskiToolStripMenuItem.Text = "Niebieski";
            this.niebieskiToolStripMenuItem.Click += new System.EventHandler(this.niebieskiToolStripMenuItem_Click);
            // 
            // zielonyToolStripMenuItem
            // 
            this.zielonyToolStripMenuItem.Name = "zielonyToolStripMenuItem";
            this.zielonyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zielonyToolStripMenuItem.Text = "Zielony";
            this.zielonyToolStripMenuItem.Click += new System.EventHandler(this.zielonyToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(223)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(403, 612);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Timer timer2;
    }
}

