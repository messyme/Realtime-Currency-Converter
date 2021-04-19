
namespace Currency_Conversion_App {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.inputMoney = new System.Windows.Forms.NumericUpDown();
            this.inputCurrency = new System.Windows.Forms.ComboBox();
            this.outputCurrency = new System.Windows.Forms.ComboBox();
            this.outputMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(69, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Real-time Currency Conversion";
            // 
            // inputMoney
            // 
            this.inputMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMoney.Location = new System.Drawing.Point(355, 99);
            this.inputMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputMoney.Name = "inputMoney";
            this.inputMoney.Size = new System.Drawing.Size(180, 35);
            this.inputMoney.TabIndex = 1;
            // 
            // inputCurrency
            // 
            this.inputCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCurrency.FormattingEnabled = true;
            this.inputCurrency.Location = new System.Drawing.Point(204, 99);
            this.inputCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCurrency.Name = "inputCurrency";
            this.inputCurrency.Size = new System.Drawing.Size(88, 37);
            this.inputCurrency.TabIndex = 2;
            // 
            // outputCurrency
            // 
            this.outputCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputCurrency.FormattingEnabled = true;
            this.outputCurrency.Location = new System.Drawing.Point(204, 165);
            this.outputCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputCurrency.Name = "outputCurrency";
            this.outputCurrency.Size = new System.Drawing.Size(88, 37);
            this.outputCurrency.TabIndex = 4;
            // 
            // outputMoney
            // 
            this.outputMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMoney.Location = new System.Drawing.Point(355, 167);
            this.outputMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.outputMoney.Name = "outputMoney";
            this.outputMoney.ReadOnly = true;
            this.outputMoney.Size = new System.Drawing.Size(180, 35);
            this.outputMoney.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "From this currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "To this currency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 271);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.outputMoney);
            this.Controls.Add(this.outputCurrency);
            this.Controls.Add(this.inputCurrency);
            this.Controls.Add(this.inputMoney);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown inputMoney;
		private System.Windows.Forms.ComboBox inputCurrency;
		private System.Windows.Forms.ComboBox outputCurrency;
		private System.Windows.Forms.TextBox outputMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

