namespace WindowsFormsApplication1
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.textBoxBeginningCalc = new System.Windows.Forms.TextBox();
            this.textBoxAccuracyCalc = new System.Windows.Forms.TextBox();
            this.textBoxEndCalc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFunctionCalc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plot1
            // 
            this.plot1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plot1.Location = new System.Drawing.Point(0, 134);
            this.plot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(689, 322);
            this.plot1.TabIndex = 0;
            this.plot1.Text = "plot1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // textBoxBeginningCalc
            // 
            this.textBoxBeginningCalc.Location = new System.Drawing.Point(209, 16);
            this.textBoxBeginningCalc.Name = "textBoxBeginningCalc";
            this.textBoxBeginningCalc.Size = new System.Drawing.Size(100, 23);
            this.textBoxBeginningCalc.TabIndex = 1;
            // 
            // textBoxAccuracyCalc
            // 
            this.textBoxAccuracyCalc.Location = new System.Drawing.Point(209, 58);
            this.textBoxAccuracyCalc.Name = "textBoxAccuracyCalc";
            this.textBoxAccuracyCalc.Size = new System.Drawing.Size(100, 23);
            this.textBoxAccuracyCalc.TabIndex = 2;
            // 
            // textBoxEndCalc
            // 
            this.textBoxEndCalc.Location = new System.Drawing.Point(577, 16);
            this.textBoxEndCalc.Name = "textBoxEndCalc";
            this.textBoxEndCalc.Size = new System.Drawing.Size(100, 23);
            this.textBoxEndCalc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Początek przedziału całkowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Koniec przedziału całkowania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dokładność całkowania";
            // 
            // textBoxFunctionCalc
            // 
            this.textBoxFunctionCalc.Location = new System.Drawing.Point(577, 58);
            this.textBoxFunctionCalc.Name = "textBoxFunctionCalc";
            this.textBoxFunctionCalc.Size = new System.Drawing.Size(100, 23);
            this.textBoxFunctionCalc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Funkcja całkowana";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(393, 105);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Oblicz";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(577, 105);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(100, 23);
            this.textBoxResult.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wynik";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 456);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFunctionCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEndCalc);
            this.Controls.Add(this.textBoxAccuracyCalc);
            this.Controls.Add(this.textBoxBeginningCalc);
            this.Controls.Add(this.plot1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "Całkowanie numeryczne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.TextBox textBoxBeginningCalc;
        private System.Windows.Forms.TextBox textBoxAccuracyCalc;
        private System.Windows.Forms.TextBox textBoxEndCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFunctionCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label5;
    }
}

