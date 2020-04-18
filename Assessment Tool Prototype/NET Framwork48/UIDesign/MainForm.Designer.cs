namespace NET_Framwork48
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
修改了            this.textBox_inputdata = new System.Windows.Forms.TextBox();
            this.label_input_data_info = new System.Windows.Forms.Label();
            this.button_input_data = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_assessment_result = new System.Windows.Forms.TextBox();
            this.button_assess_start = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_inputdata);
            this.groupBox1.Controls.Add(this.label_input_data_info);
            this.groupBox1.Controls.Add(this.button_input_data);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DataInput";
            // 
            // textBox_inputdata
            // 
            this.textBox_inputdata.AcceptsReturn = true;
            this.textBox_inputdata.Location = new System.Drawing.Point(7, 58);
            this.textBox_inputdata.Multiline = true;
            this.textBox_inputdata.Name = "textBox_inputdata";
            this.textBox_inputdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_inputdata.Size = new System.Drawing.Size(697, 157);
            this.textBox_inputdata.TabIndex = 2;
            // 
            // label_input_data_info
            // 
            this.label_input_data_info.AutoSize = true;
            this.label_input_data_info.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_input_data_info.Location = new System.Drawing.Point(101, 27);
            this.label_input_data_info.Name = "label_input_data_info";
            this.label_input_data_info.Size = new System.Drawing.Size(136, 16);
            this.label_input_data_info.TabIndex = 1;
            this.label_input_data_info.Text = "还未打开json文件";
            // 
            // button_input_data
            // 
            this.button_input_data.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_input_data.Location = new System.Drawing.Point(7, 21);
            this.button_input_data.Name = "button_input_data";
            this.button_input_data.Size = new System.Drawing.Size(88, 30);
            this.button_input_data.TabIndex = 0;
            this.button_input_data.Text = "Input Data";
            this.button_input_data.UseVisualStyleBackColor = true;
            this.button_input_data.Click += new System.EventHandler(this.button_input_data_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_assessment_result);
            this.groupBox2.Location = new System.Drawing.Point(13, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 262);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Assessment Result";
            // 
            // textBox_assessment_result
            // 
            this.textBox_assessment_result.AcceptsReturn = true;
            this.textBox_assessment_result.Location = new System.Drawing.Point(7, 21);
            this.textBox_assessment_result.Multiline = true;
            this.textBox_assessment_result.Name = "textBox_assessment_result";
            this.textBox_assessment_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_assessment_result.Size = new System.Drawing.Size(697, 235);
            this.textBox_assessment_result.TabIndex = 0;
            // 
            // button_assess_start
            // 
            this.button_assess_start.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_assess_start.Location = new System.Drawing.Point(632, 510);
            this.button_assess_start.Name = "button_assess_start";
            this.button_assess_start.Size = new System.Drawing.Size(90, 38);
            this.button_assess_start.TabIndex = 2;
            this.button_assess_start.Text = "Assess";
            this.button_assess_start.UseVisualStyleBackColor = true;
            this.button_assess_start.Click += new System.EventHandler(this.button_assess_start_Click);
            // 
            // button_reset
            // 
            this.button_reset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_reset.Location = new System.Drawing.Point(542, 510);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(84, 38);
            this.button_reset.TabIndex = 3;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 560);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_assess_start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_assess_start;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TextBox textBox_inputdata;
        private System.Windows.Forms.Label label_input_data_info;
        private System.Windows.Forms.Button button_input_data;
        private System.Windows.Forms.TextBox textBox_assessment_result;
    }
}

