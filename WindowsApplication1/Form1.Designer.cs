namespace WindowsApplication1
{
    partial class Form1
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
            this.crystalButton1 = new MyControls.CrystalButton();
            this.crystalButton2 = new MyControls.CrystalButton();
            this.SuspendLayout();
            // 
            // crystalButton1
            // 
            this.crystalButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.crystalButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalButton1.Location = new System.Drawing.Point(78, 38);
            this.crystalButton1.Name = "crystalButton1";
            this.crystalButton1.Size = new System.Drawing.Size(133, 70);
            this.crystalButton1.TabIndex = 0;
            this.crystalButton1.Text = "crystalButton1";
            this.crystalButton1.UseVisualStyleBackColor = false;
            // 
            // crystalButton2
            // 
            this.crystalButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.crystalButton2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crystalButton2.Location = new System.Drawing.Point(78, 124);
            this.crystalButton2.Name = "crystalButton2";
            this.crystalButton2.Size = new System.Drawing.Size(133, 70);
            this.crystalButton2.TabIndex = 1;
            this.crystalButton2.Text = "crystalButton2";
            this.crystalButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.crystalButton2);
            this.Controls.Add(this.crystalButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.CrystalButton crystalButton1;
        private MyControls.CrystalButton crystalButton2;
    }
}

