using System.Diagnostics;

namespace _2_Reaktometr
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public SimpleOptic SimOpt;
        public SimpleAcous SimAco;
        public ComplexOptic ComOpt;
        public ComplexAcous ComAco;

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
            this.simOpto = new System.Windows.Forms.Button();
            this.simAcous = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comOpto = new System.Windows.Forms.Button();
            this.comAcous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // simOpto
            // 
            this.simOpto.Location = new System.Drawing.Point(166, 115);
            this.simOpto.Name = "simOpto";
            this.simOpto.Size = new System.Drawing.Size(140, 140);
            this.simOpto.TabIndex = 0;
            this.simOpto.Text = "Prosty test optyczny";
            this.simOpto.UseVisualStyleBackColor = true;
            this.simOpto.Click += new System.EventHandler(this.simOpto_Click);
            // 
            // simAcous
            // 
            this.simAcous.Location = new System.Drawing.Point(521, 115);
            this.simAcous.Name = "simAcous";
            this.simAcous.Size = new System.Drawing.Size(140, 140);
            this.simAcous.TabIndex = 1;
            this.simAcous.Text = "Prosty test akustyczny";
            this.simAcous.UseVisualStyleBackColor = true;
            this.simAcous.Click += new System.EventHandler(this.simAcous_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(349, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reaktometr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Testy optyczne";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Testy akustyczne";
            // 
            // comOpto
            // 
            this.comOpto.Location = new System.Drawing.Point(166, 278);
            this.comOpto.Name = "comOpto";
            this.comOpto.Size = new System.Drawing.Size(140, 140);
            this.comOpto.TabIndex = 4;
            this.comOpto.Text = "Złożony test optyczny";
            this.comOpto.UseVisualStyleBackColor = true;
            this.comOpto.Click += new System.EventHandler(this.comOpto_Click);
            // 
            // comAcous
            // 
            this.comAcous.Location = new System.Drawing.Point(521, 278);
            this.comAcous.Name = "comAcous";
            this.comAcous.Size = new System.Drawing.Size(140, 140);
            this.comAcous.TabIndex = 5;
            this.comAcous.Text = "Złożony test akustyczny";
            this.comAcous.UseVisualStyleBackColor = true;
            this.comAcous.Click += new System.EventHandler(this.comAcous_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comAcous);
            this.Controls.Add(this.comOpto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simAcous);
            this.Controls.Add(this.simOpto);
            this.Name = "Main";
            this.Text = "Reaktometr";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button simOpto;
        private System.Windows.Forms.Button simAcous;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button comOpto;
        private System.Windows.Forms.Button comAcous;
    }
    public class ReactionTimer
    {
        private Stopwatch _sw = new Stopwatch();

        public void StartTest()
        {
            _sw.Reset();
            _sw.Start();
        }
        public long StopTest()
        {
            _sw.Stop();
            return _sw.ElapsedMilliseconds;
        }
    }
}

