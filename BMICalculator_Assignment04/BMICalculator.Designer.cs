namespace BMICalculator_Assignment04
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.MetricRadio = new System.Windows.Forms.RadioButton();
            this.ImperialRadio = new System.Windows.Forms.RadioButton();
            this.MyHeight = new System.Windows.Forms.Label();
            this.MyWeight = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ResultText = new System.Windows.Forms.TextBox();
            this.BMIRatingText = new System.Windows.Forms.TextBox();
            this.YourRating = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.49833F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.50167F));
            this.tableLayoutPanel1.Controls.Add(this.WeightInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyHeight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MyWeight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightInput, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 156);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // WeightInput
            // 
            this.WeightInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WeightInput.Location = new System.Drawing.Point(173, 111);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(100, 38);
            this.WeightInput.TabIndex = 5;
            this.WeightInput.Enter += new System.EventHandler(this.WeightInput_Enter);
            // 
            // MetricRadio
            // 
            this.MetricRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MetricRadio.AutoSize = true;
            this.MetricRadio.Location = new System.Drawing.Point(3, 8);
            this.MetricRadio.Name = "MetricRadio";
            this.MetricRadio.Size = new System.Drawing.Size(106, 35);
            this.MetricRadio.TabIndex = 0;
            this.MetricRadio.Text = "Metric";
            this.MetricRadio.UseVisualStyleBackColor = true;
            this.MetricRadio.CheckedChanged += new System.EventHandler(this.MetricRadio_CheckedChanged);
            // 
            // ImperialRadio
            // 
            this.ImperialRadio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImperialRadio.AutoSize = true;
            this.ImperialRadio.Checked = true;
            this.ImperialRadio.Location = new System.Drawing.Point(151, 8);
            this.ImperialRadio.Name = "ImperialRadio";
            this.ImperialRadio.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadio.TabIndex = 1;
            this.ImperialRadio.TabStop = true;
            this.ImperialRadio.Text = "Imperial";
            this.ImperialRadio.UseVisualStyleBackColor = true;
            this.ImperialRadio.CheckedChanged += new System.EventHandler(this.ImperialRadio_CheckedChanged);
            // 
            // MyHeight
            // 
            this.MyHeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MyHeight.AutoSize = true;
            this.MyHeight.Location = new System.Drawing.Point(3, 62);
            this.MyHeight.Name = "MyHeight";
            this.MyHeight.Size = new System.Drawing.Size(136, 31);
            this.MyHeight.TabIndex = 2;
            this.MyHeight.Text = "My Height";
            this.MyHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MyWeight
            // 
            this.MyWeight.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MyWeight.AutoSize = true;
            this.MyWeight.Location = new System.Drawing.Point(3, 114);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(141, 31);
            this.MyWeight.TabIndex = 3;
            this.MyWeight.Text = "My Weight";
            // 
            // HeightInput
            // 
            this.HeightInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeightInput.Location = new System.Drawing.Point(173, 59);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(100, 38);
            this.HeightInput.TabIndex = 4;
            this.HeightInput.Enter += new System.EventHandler(this.HeightInput_Enter);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(14, 184);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(270, 47);
            this.BtnCalculate.TabIndex = 6;
            this.BtnCalculate.Text = "Calculate BMI";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.btnCalculate_click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.ResultText, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.BMIRatingText, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.YourRating, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Result, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 239);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(299, 100);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // ResultText
            // 
            this.ResultText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResultText.BackColor = System.Drawing.Color.DarkGray;
            this.ResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ResultText.Location = new System.Drawing.Point(161, 56);
            this.ResultText.Multiline = true;
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(125, 38);
            this.ResultText.TabIndex = 8;
            // 
            // BMIRatingText
            // 
            this.BMIRatingText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BMIRatingText.BackColor = System.Drawing.Color.DarkGray;
            this.BMIRatingText.Location = new System.Drawing.Point(163, 6);
            this.BMIRatingText.Name = "BMIRatingText";
            this.BMIRatingText.ReadOnly = true;
            this.BMIRatingText.Size = new System.Drawing.Size(121, 38);
            this.BMIRatingText.TabIndex = 6;
            this.BMIRatingText.TextChanged += new System.EventHandler(this.BMIRatingText_TextChanged);
            // 
            // YourRating
            // 
            this.YourRating.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.YourRating.AutoSize = true;
            this.YourRating.Location = new System.Drawing.Point(3, 9);
            this.YourRating.Name = "YourRating";
            this.YourRating.Size = new System.Drawing.Size(93, 31);
            this.YourRating.TabIndex = 0;
            this.YourRating.Text = "Rating";
            // 
            // Result
            // 
            this.Result.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(3, 59);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(92, 31);
            this.Result.TabIndex = 7;
            this.Result.Text = "Result";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(81, 353);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(131, 43);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 424);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BtnCalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton MetricRadio;
        private System.Windows.Forms.RadioButton ImperialRadio;
        private System.Windows.Forms.Label MyHeight;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label YourRating;
        private System.Windows.Forms.TextBox BMIRatingText;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox ResultText;
        private System.Windows.Forms.Button BtnReset;
    }
}

