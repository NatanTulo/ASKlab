using System.Diagnostics;

namespace _2_Reaktometr
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Optyczne oknOptynczne;
        public Akustyczne oknAkustyczne;

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
            this.opto = new System.Windows.Forms.Button();
            this.akus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // opto
            // 
            this.opto.Location = new System.Drawing.Point(160, 138);
            this.opto.Name = "opto";
            this.opto.Size = new System.Drawing.Size(135, 140);
            this.opto.TabIndex = 0;
            this.opto.Text = "Testy optyczne";
            this.opto.UseVisualStyleBackColor = true;
            this.opto.Click += new System.EventHandler(this.opto_Click);
            // 
            // akus
            // 
            this.akus.Location = new System.Drawing.Point(523, 138);
            this.akus.Name = "akus";
            this.akus.Size = new System.Drawing.Size(144, 140);
            this.akus.TabIndex = 1;
            this.akus.Text = "Testy akustyczne";
            this.akus.UseVisualStyleBackColor = true;
            this.akus.Click += new System.EventHandler(this.akus_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.akus);
            this.Controls.Add(this.opto);
            this.Name = "Main";
            this.Text = "Reaktometr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button opto;
        private System.Windows.Forms.Button akus;
        private System.Windows.Forms.Label label1;
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

