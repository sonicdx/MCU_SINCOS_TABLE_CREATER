namespace MCU_SINCOS_TABLE_CREATER
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOut = new System.Windows.Forms.TextBox();
            this.lnkCopyClipBoard = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.numLen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUp = new System.Windows.Forms.TextBox();
            this.txtDown = new System.Windows.Forms.TextBox();
            this.btGen = new System.Windows.Forms.Button();
            this.outImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "图示";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "输出";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(186, 24);
            this.txtOut.Multiline = true;
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOut.Size = new System.Drawing.Size(985, 273);
            this.txtOut.TabIndex = 3;
            // 
            // lnkCopyClipBoard
            // 
            this.lnkCopyClipBoard.AutoSize = true;
            this.lnkCopyClipBoard.Location = new System.Drawing.Point(1094, 9);
            this.lnkCopyClipBoard.Name = "lnkCopyClipBoard";
            this.lnkCopyClipBoard.Size = new System.Drawing.Size(77, 12);
            this.lnkCopyClipBoard.TabIndex = 4;
            this.lnkCopyClipBoard.TabStop = true;
            this.lnkCopyClipBoard.Text = "复制到剪贴板";
            this.lnkCopyClipBoard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCopyClipBoard_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "输出位数:";
            // 
            // numLen
            // 
            this.numLen.Location = new System.Drawing.Point(76, 24);
            this.numLen.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numLen.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numLen.Name = "numLen";
            this.numLen.Size = new System.Drawing.Size(84, 21);
            this.numLen.TabIndex = 6;
            this.numLen.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "输出上限:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "输出下限:";
            // 
            // txtUp
            // 
            this.txtUp.Location = new System.Drawing.Point(76, 77);
            this.txtUp.Name = "txtUp";
            this.txtUp.Size = new System.Drawing.Size(84, 21);
            this.txtUp.TabIndex = 10;
            this.txtUp.Text = "255";
            // 
            // txtDown
            // 
            this.txtDown.Location = new System.Drawing.Point(76, 104);
            this.txtDown.Name = "txtDown";
            this.txtDown.Size = new System.Drawing.Size(84, 21);
            this.txtDown.TabIndex = 11;
            this.txtDown.Text = "0";
            // 
            // btGen
            // 
            this.btGen.Location = new System.Drawing.Point(28, 157);
            this.btGen.Name = "btGen";
            this.btGen.Size = new System.Drawing.Size(119, 53);
            this.btGen.TabIndex = 12;
            this.btGen.Text = "生成";
            this.btGen.UseVisualStyleBackColor = true;
            this.btGen.Click += new System.EventHandler(this.btGen_Click);
            // 
            // outImg
            // 
            this.outImg.Image = global::MCU_SINCOS_TABLE_CREATER.Properties.Resources.sincos_img;
            this.outImg.Location = new System.Drawing.Point(12, 303);
            this.outImg.Name = "outImg";
            this.outImg.Size = new System.Drawing.Size(1159, 348);
            this.outImg.TabIndex = 0;
            this.outImg.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 663);
            this.Controls.Add(this.btGen);
            this.Controls.Add(this.txtDown);
            this.Controls.Add(this.txtUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numLen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkCopyClipBoard);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "单片机整数正弦表格生成工具(上海电子信息职业技术学院 电子工程系 提供)";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox outImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOut;
        private System.Windows.Forms.LinkLabel lnkCopyClipBoard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numLen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUp;
        private System.Windows.Forms.TextBox txtDown;
        private System.Windows.Forms.Button btGen;
    }
}

