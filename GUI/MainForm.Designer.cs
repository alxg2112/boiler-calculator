namespace GUI
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.waterConsumedBox = new System.Windows.Forms.TextBox();
            this.hotWaterPriceBox = new System.Windows.Forms.TextBox();
            this.periodBox = new System.Windows.Forms.TextBox();
            this.electricityPriceBox = new System.Windows.Forms.TextBox();
            this.boilerOutputBox = new System.Windows.Forms.TextBox();
            this.boilerHeatUpTimeBox = new System.Windows.Forms.TextBox();
            this.boilerPriceBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.resultBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.profitBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.boilerCapacityBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.paybackBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.coldWaterPriceBox = new System.Windows.Forms.TextBox();
            this.inputBox.SuspendLayout();
            this.resultBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boiler price ($):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Electricity price ($ per kiloWatt):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hot water price ($ per cublic meter):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Water consumed (cublic meters per month):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Boiler heat up time (hours):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Boiler output (kiloWatts):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Period (months):";
            // 
            // waterConsumedBox
            // 
            this.waterConsumedBox.Location = new System.Drawing.Point(290, 231);
            this.waterConsumedBox.Name = "waterConsumedBox";
            this.waterConsumedBox.Size = new System.Drawing.Size(100, 22);
            this.waterConsumedBox.TabIndex = 7;
            // 
            // hotWaterPriceBox
            // 
            this.hotWaterPriceBox.Location = new System.Drawing.Point(290, 171);
            this.hotWaterPriceBox.Name = "hotWaterPriceBox";
            this.hotWaterPriceBox.Size = new System.Drawing.Size(100, 22);
            this.hotWaterPriceBox.TabIndex = 8;
            // 
            // periodBox
            // 
            this.periodBox.Location = new System.Drawing.Point(290, 263);
            this.periodBox.Name = "periodBox";
            this.periodBox.Size = new System.Drawing.Size(100, 22);
            this.periodBox.TabIndex = 9;
            // 
            // electricityPriceBox
            // 
            this.electricityPriceBox.Location = new System.Drawing.Point(290, 141);
            this.electricityPriceBox.Name = "electricityPriceBox";
            this.electricityPriceBox.Size = new System.Drawing.Size(100, 22);
            this.electricityPriceBox.TabIndex = 10;
            // 
            // boilerOutputBox
            // 
            this.boilerOutputBox.Location = new System.Drawing.Point(290, 81);
            this.boilerOutputBox.Name = "boilerOutputBox";
            this.boilerOutputBox.Size = new System.Drawing.Size(100, 22);
            this.boilerOutputBox.TabIndex = 11;
            // 
            // boilerHeatUpTimeBox
            // 
            this.boilerHeatUpTimeBox.Location = new System.Drawing.Point(290, 51);
            this.boilerHeatUpTimeBox.Name = "boilerHeatUpTimeBox";
            this.boilerHeatUpTimeBox.Size = new System.Drawing.Size(100, 22);
            this.boilerHeatUpTimeBox.TabIndex = 12;
            // 
            // boilerPriceBox
            // 
            this.boilerPriceBox.Location = new System.Drawing.Point(290, 21);
            this.boilerPriceBox.Name = "boilerPriceBox";
            this.boilerPriceBox.Size = new System.Drawing.Size(100, 22);
            this.boilerPriceBox.TabIndex = 13;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(6, 286);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(130, 28);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate profit!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.coldWaterPriceBox);
            this.inputBox.Controls.Add(this.label11);
            this.inputBox.Controls.Add(this.boilerCapacityBox);
            this.inputBox.Controls.Add(this.label9);
            this.inputBox.Controls.Add(this.boilerPriceBox);
            this.inputBox.Controls.Add(this.calculateButton);
            this.inputBox.Controls.Add(this.boilerHeatUpTimeBox);
            this.inputBox.Controls.Add(this.label7);
            this.inputBox.Controls.Add(this.boilerOutputBox);
            this.inputBox.Controls.Add(this.label4);
            this.inputBox.Controls.Add(this.electricityPriceBox);
            this.inputBox.Controls.Add(this.label3);
            this.inputBox.Controls.Add(this.hotWaterPriceBox);
            this.inputBox.Controls.Add(this.periodBox);
            this.inputBox.Controls.Add(this.waterConsumedBox);
            this.inputBox.Controls.Add(this.label2);
            this.inputBox.Controls.Add(this.label6);
            this.inputBox.Controls.Add(this.label5);
            this.inputBox.Controls.Add(this.label1);
            this.inputBox.Location = new System.Drawing.Point(12, 12);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(404, 320);
            this.inputBox.TabIndex = 15;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Input";
            // 
            // resultBox
            // 
            this.resultBox.Controls.Add(this.paybackBox);
            this.resultBox.Controls.Add(this.label10);
            this.resultBox.Controls.Add(this.profitBox);
            this.resultBox.Controls.Add(this.label8);
            this.resultBox.Location = new System.Drawing.Point(12, 338);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(400, 96);
            this.resultBox.TabIndex = 16;
            this.resultBox.TabStop = false;
            this.resultBox.Text = "Result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Profit of using boiler ($):";
            // 
            // profitBox
            // 
            this.profitBox.Location = new System.Drawing.Point(290, 28);
            this.profitBox.Name = "profitBox";
            this.profitBox.Size = new System.Drawing.Size(100, 22);
            this.profitBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Boiler capacity (liters):";
            // 
            // boilerCapacityBox
            // 
            this.boilerCapacityBox.Location = new System.Drawing.Point(290, 111);
            this.boilerCapacityBox.Name = "boilerCapacityBox";
            this.boilerCapacityBox.Size = new System.Drawing.Size(100, 22);
            this.boilerCapacityBox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Payback time (months):";
            // 
            // paybackBox
            // 
            this.paybackBox.Location = new System.Drawing.Point(290, 58);
            this.paybackBox.Name = "paybackBox";
            this.paybackBox.Size = new System.Drawing.Size(100, 22);
            this.paybackBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 17);
            this.label11.TabIndex = 17;
            this.label11.Text = "Cold water price ($ per cubic meter):";
            // 
            // coldWaterPriceBox
            // 
            this.coldWaterPriceBox.Location = new System.Drawing.Point(290, 201);
            this.coldWaterPriceBox.Name = "coldWaterPriceBox";
            this.coldWaterPriceBox.Size = new System.Drawing.Size(100, 22);
            this.coldWaterPriceBox.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 446);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.inputBox);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.resultBox.ResumeLayout(false);
            this.resultBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox waterConsumedBox;
        private System.Windows.Forms.TextBox hotWaterPriceBox;
        private System.Windows.Forms.TextBox periodBox;
        private System.Windows.Forms.TextBox electricityPriceBox;
        private System.Windows.Forms.TextBox boilerOutputBox;
        private System.Windows.Forms.TextBox boilerHeatUpTimeBox;
        private System.Windows.Forms.TextBox boilerPriceBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.GroupBox resultBox;
        private System.Windows.Forms.TextBox profitBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boilerCapacityBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox paybackBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox coldWaterPriceBox;
        private System.Windows.Forms.Label label11;
    }
}

