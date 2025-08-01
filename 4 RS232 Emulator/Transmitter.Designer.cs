﻿namespace _4_RS232_Emulator
{
    partial class Transmitter
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Receiver receiver;

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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.encodedTextBox = new System.Windows.Forms.TextBox();
            this.input_label = new System.Windows.Forms.Label();
            this.encoded_label = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputTextBox.Location = new System.Drawing.Point(18, 39);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(458, 236);
            this.inputTextBox.TabIndex = 1;
            // 
            // encodedTextBox
            // 
            this.encodedTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.encodedTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encodedTextBox.Location = new System.Drawing.Point(18, 421);
            this.encodedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.encodedTextBox.Multiline = true;
            this.encodedTextBox.Name = "encodedTextBox";
            this.encodedTextBox.ReadOnly = true;
            this.encodedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encodedTextBox.Size = new System.Drawing.Size(458, 236);
            this.encodedTextBox.TabIndex = 2;
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(18, 21);
            this.input_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(131, 13);
            this.input_label.TabIndex = 3;
            this.input_label.Text = "Wejściowe pole tekstowe:";
            // 
            // encoded_label
            // 
            this.encoded_label.AutoSize = true;
            this.encoded_label.Location = new System.Drawing.Point(20, 403);
            this.encoded_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.encoded_label.Name = "encoded_label";
            this.encoded_label.Size = new System.Drawing.Size(122, 13);
            this.encoded_label.TabIndex = 4;
            this.encoded_label.Text = "Zakodowana transmisja:";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.Location = new System.Drawing.Point(138, 297);
            this.sendButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(214, 77);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Wyślij wiadomość";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Transmitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 729);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.encoded_label);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.encodedTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Transmitter";
            this.Text = "Transmitter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox encodedTextBox;
        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.Label encoded_label;
        private System.Windows.Forms.Button sendButton;
    }
}

