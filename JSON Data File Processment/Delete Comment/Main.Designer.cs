﻿namespace Delete_Comment
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_inputdata = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_inputdata
            // 
            this.button_inputdata.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_inputdata.Location = new System.Drawing.Point(13, 13);
            this.button_inputdata.Name = "button_inputdata";
            this.button_inputdata.Size = new System.Drawing.Size(109, 37);
            this.button_inputdata.TabIndex = 0;
            this.button_inputdata.Text = "Input Data";
            this.button_inputdata.UseVisualStyleBackColor = true;
            this.button_inputdata.Click += new System.EventHandler(this.button_inputdata_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 57);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(775, 381);
            this.textBox.TabIndex = 1;
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_reset.Location = new System.Drawing.Point(129, 13);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(109, 37);
            this.button_reset.TabIndex = 2;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_inputdata);
            this.Name = "Main";
            this.Text = "Delete Comment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_inputdata;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_reset;
    }
}

