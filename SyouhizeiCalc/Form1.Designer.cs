namespace SyouhizeiCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            zeinuki = new TextBox();
            CalcButton = new Button();
            ClearButton = new Button();
            syouhizei = new TextBox();
            zeikomi = new TextBox();
            zeiritu = new ComboBox();
            hasuu = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "税抜金額";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "税率";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 81);
            label3.Name = "label3";
            label3.Size = new Size(144, 20);
            label3.TabIndex = 2;
            label3.Text = "小数点以下端数処理";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "消費税";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 147);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "税込金額";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 15);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 5;
            label6.Text = "円";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(302, 114);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 6;
            label7.Text = "円";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(302, 147);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 7;
            label8.Text = "円";
            // 
            // zeinuki
            // 
            zeinuki.Location = new Point(171, 12);
            zeinuki.Name = "zeinuki";
            zeinuki.Size = new Size(125, 27);
            zeinuki.TabIndex = 8;
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(21, 194);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(125, 29);
            CalcButton.TabIndex = 9;
            CalcButton.Text = "計算する";
            CalcButton.UseVisualStyleBackColor = true;
            CalcButton.Click += CalcButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(195, 194);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(131, 29);
            ClearButton.TabIndex = 10;
            ClearButton.Text = "クリア";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // syouhizei
            // 
            syouhizei.Location = new Point(171, 111);
            syouhizei.Name = "syouhizei";
            syouhizei.Size = new Size(125, 27);
            syouhizei.TabIndex = 11;
            // 
            // zeikomi
            // 
            zeikomi.Location = new Point(171, 144);
            zeikomi.Name = "zeikomi";
            zeikomi.Size = new Size(125, 27);
            zeikomi.TabIndex = 12;
            // 
            // zeiritu
            // 
            zeiritu.DropDownStyle = ComboBoxStyle.DropDownList;
            zeiritu.FormattingEnabled = true;
            zeiritu.Items.AddRange(new object[] { "8%", "10%" });
            zeiritu.Location = new Point(171, 45);
            zeiritu.Name = "zeiritu";
            zeiritu.Size = new Size(84, 28);
            zeiritu.TabIndex = 13;
            // 
            // hasuu
            // 
            hasuu.DropDownStyle = ComboBoxStyle.DropDownList;
            hasuu.FormattingEnabled = true;
            hasuu.Items.AddRange(new object[] { "切り捨て", "切り上げ", "四捨五入" });
            hasuu.Location = new Point(171, 78);
            hasuu.Name = "hasuu";
            hasuu.Size = new Size(108, 28);
            hasuu.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 249);
            Controls.Add(hasuu);
            Controls.Add(zeiritu);
            Controls.Add(zeikomi);
            Controls.Add(syouhizei);
            Controls.Add(ClearButton);
            Controls.Add(CalcButton);
            Controls.Add(zeinuki);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "消費税計算プログラム";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox zeinuki;
        private Button CalcButton;
        private Button ClearButton;
        private TextBox syouhizei;
        private TextBox zeikomi;
        private ComboBox zeiritu;
        private ComboBox hasuu;
    }
}
