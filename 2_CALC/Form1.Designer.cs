namespace _2_CALC
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.btEquals = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.btDot = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btMinus = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.btMultiply = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btC = new System.Windows.Forms.Button();
            this.btPlus = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btEquals
            // 
            this.btEquals.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btEquals.Location = new System.Drawing.Point(171, 204);
            this.btEquals.Name = "btEquals";
            this.btEquals.Size = new System.Drawing.Size(100, 44);
            this.btEquals.TabIndex = 36;
            this.btEquals.Text = "=";
            this.btEquals.UseVisualStyleBackColor = true;
            this.btEquals.Click += new System.EventHandler(this.bt_Equal);
            // 
            // bt0
            // 
            this.bt0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt0.Location = new System.Drawing.Point(65, 204);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(100, 44);
            this.bt0.TabIndex = 35;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt_Digit);
            // 
            // btDot
            // 
            this.btDot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btDot.Location = new System.Drawing.Point(12, 204);
            this.btDot.Name = "btDot";
            this.btDot.Size = new System.Drawing.Size(47, 44);
            this.btDot.TabIndex = 34;
            this.btDot.Text = ",";
            this.btDot.UseVisualStyleBackColor = true;
            this.btDot.Click += new System.EventHandler(this.bt_Dot);
            // 
            // btDiv
            // 
            this.btDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btDiv.Location = new System.Drawing.Point(225, 154);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(47, 44);
            this.btDiv.TabIndex = 33;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.bt_Sign);
            // 
            // btMinus
            // 
            this.btMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btMinus.Location = new System.Drawing.Point(171, 154);
            this.btMinus.Name = "btMinus";
            this.btMinus.Size = new System.Drawing.Size(47, 44);
            this.btMinus.TabIndex = 32;
            this.btMinus.Text = "-";
            this.btMinus.UseVisualStyleBackColor = true;
            this.btMinus.Click += new System.EventHandler(this.bt_Sign);
            // 
            // bt9
            // 
            this.bt9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt9.Location = new System.Drawing.Point(118, 154);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(47, 44);
            this.bt9.TabIndex = 31;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt_Digit);
            // 
            // bt8
            // 
            this.bt8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt8.Location = new System.Drawing.Point(65, 154);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(47, 44);
            this.bt8.TabIndex = 30;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt_Digit);
            // 
            // bt7
            // 
            this.bt7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt7.Location = new System.Drawing.Point(12, 154);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(47, 44);
            this.bt7.TabIndex = 29;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt_Digit);
            // 
            // btMultiply
            // 
            this.btMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btMultiply.Location = new System.Drawing.Point(224, 104);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(47, 44);
            this.btMultiply.TabIndex = 28;
            this.btMultiply.Text = "*";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.bt_Sign);
            // 
            // bt6
            // 
            this.bt6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt6.Location = new System.Drawing.Point(118, 104);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(47, 44);
            this.bt6.TabIndex = 27;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt_Digit);
            // 
            // bt5
            // 
            this.bt5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt5.Location = new System.Drawing.Point(65, 104);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(47, 44);
            this.bt5.TabIndex = 26;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt_Digit);
            // 
            // bt4
            // 
            this.bt4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt4.Location = new System.Drawing.Point(12, 104);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(47, 44);
            this.bt4.TabIndex = 25;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt_Digit);
            // 
            // btC
            // 
            this.btC.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btC.Location = new System.Drawing.Point(224, 54);
            this.btC.Name = "btC";
            this.btC.Size = new System.Drawing.Size(47, 44);
            this.btC.TabIndex = 24;
            this.btC.Text = "C";
            this.btC.UseVisualStyleBackColor = true;
            this.btC.Click += new System.EventHandler(this.bt_C);
            // 
            // btPlus
            // 
            this.btPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btPlus.Location = new System.Drawing.Point(171, 54);
            this.btPlus.Name = "btPlus";
            this.btPlus.Size = new System.Drawing.Size(47, 94);
            this.btPlus.TabIndex = 23;
            this.btPlus.Text = "+";
            this.btPlus.UseVisualStyleBackColor = true;
            this.btPlus.Click += new System.EventHandler(this.bt_Sign);
            // 
            // bt3
            // 
            this.bt3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt3.Location = new System.Drawing.Point(118, 54);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(47, 44);
            this.bt3.TabIndex = 22;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt_Digit);
            // 
            // bt2
            // 
            this.bt2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt2.Location = new System.Drawing.Point(65, 54);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(47, 44);
            this.bt2.TabIndex = 21;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt_Digit);
            // 
            // bt1
            // 
            this.bt1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt1.Location = new System.Drawing.Point(12, 54);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(47, 44);
            this.bt1.TabIndex = 20;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt_Digit);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 12);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(260, 20);
            this.txtResult.TabIndex = 19;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btEquals);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.btDot);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMinus);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.btC);
            this.Controls.Add(this.btPlus);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.txtResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculator";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEquals;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button btDot;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btMinus;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btC;
        private System.Windows.Forms.Button btPlus;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox txtResult;
    }
}

