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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox_DataInput = new System.Windows.Forms.GroupBox();
            this.button_DataInput_Reset = new System.Windows.Forms.Button();
            this.textBox_DataInput_FileInfo = new System.Windows.Forms.TextBox();
            this.label_DataInput_InfoText = new System.Windows.Forms.Label();
            this.button_DataInput_Input = new System.Windows.Forms.Button();
            this.groupBox_AssessmentResult = new System.Windows.Forms.GroupBox();
            this.label_AssessmentResult_Info = new System.Windows.Forms.Label();
            this.comboBox_AssessmentResult_LevelChoose = new System.Windows.Forms.ComboBox();
            this.listView_AssessmentResult_NodeList = new System.Windows.Forms.ListView();
            this.textBox_AssessmentResult_NodeDetail = new System.Windows.Forms.TextBox();
            this.groupBox_History = new System.Windows.Forms.GroupBox();
            this.listView_History_HistoryInfo = new System.Windows.Forms.ListView();
            this.button_History_Details = new System.Windows.Forms.Button();
            this.button_History_ClearAll = new System.Windows.Forms.Button();
            this.groupBox_ModelWeight = new System.Windows.Forms.GroupBox();
            this.button_ModelWeight_SaveChanges = new System.Windows.Forms.Button();
            this.button_ModelWeight_DefaultSettings = new System.Windows.Forms.Button();
            this.groupBox_ModelWeight_Level3 = new System.Windows.Forms.GroupBox();
            this.textBox_ModelWeight_Level3_Property5Weight = new System.Windows.Forms.TextBox();
            this.textBox_ModelWeight_Level3_Property4Weight = new System.Windows.Forms.TextBox();
            this.label_ModelWeight_Level3_Property5 = new System.Windows.Forms.Label();
            this.textBox_ModelWeight_Level3_Property3Weight = new System.Windows.Forms.TextBox();
            this.label_ModelWeight_Level3_Property4 = new System.Windows.Forms.Label();
            this.label_ModelWeight_Level3_Property3 = new System.Windows.Forms.Label();
            this.label_ModelWeight_Level3_Property2 = new System.Windows.Forms.Label();
            this.textBox_ModelWeight_Level3_Property2Weight = new System.Windows.Forms.TextBox();
            this.textBox_ModelWeight_Level3_Property1Weight = new System.Windows.Forms.TextBox();
            this.label_ModelWeight_Level3_AttributeInfoText = new System.Windows.Forms.Label();
            this.comboBox_ModelWeight_Level3_AttributeChoose = new System.Windows.Forms.ComboBox();
            this.label_ModelWeight_Level3_Property1 = new System.Windows.Forms.Label();
            this.groupBox_ModelWeight_Level2 = new System.Windows.Forms.GroupBox();
            this.label_ModelWeight_Level2_DesignAttributeInfoText = new System.Windows.Forms.Label();
            this.textBox_ModelWeight_Level2_ModularityWeight = new System.Windows.Forms.TextBox();
            this.textBox_ModelWeight_Level2_StabilityWeight = new System.Windows.Forms.TextBox();
            this.textBox_ModelWeight_Level2_ChangeabilityWeight = new System.Windows.Forms.TextBox();
            this.textBox_ModelWeight_Level2_AnalyzabilityWeight = new System.Windows.Forms.TextBox();
            this.label_ModelWeight_Level2_Modularity = new System.Windows.Forms.Label();
            this.label_ModelWeight_Level2_Stability = new System.Windows.Forms.Label();
            this.label_ModelWeight_Level2_Changeability = new System.Windows.Forms.Label();
            this.label_ModelWeight_Level2_Analyzability = new System.Windows.Forms.Label();
            this.groupBox_DataInput.SuspendLayout();
            this.groupBox_AssessmentResult.SuspendLayout();
            this.groupBox_History.SuspendLayout();
            this.groupBox_ModelWeight.SuspendLayout();
            this.groupBox_ModelWeight_Level3.SuspendLayout();
            this.groupBox_ModelWeight_Level2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_DataInput
            // 
            this.groupBox_DataInput.Controls.Add(this.button_DataInput_Reset);
            this.groupBox_DataInput.Controls.Add(this.textBox_DataInput_FileInfo);
            this.groupBox_DataInput.Controls.Add(this.label_DataInput_InfoText);
            this.groupBox_DataInput.Controls.Add(this.button_DataInput_Input);
            this.groupBox_DataInput.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_DataInput.Location = new System.Drawing.Point(12, 12);
            this.groupBox_DataInput.Name = "groupBox_DataInput";
            this.groupBox_DataInput.Size = new System.Drawing.Size(377, 175);
            this.groupBox_DataInput.TabIndex = 0;
            this.groupBox_DataInput.TabStop = false;
            this.groupBox_DataInput.Text = "Data Input";
            // 
            // button_DataInput_Reset
            // 
            this.button_DataInput_Reset.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_DataInput_Reset.Location = new System.Drawing.Point(108, 22);
            this.button_DataInput_Reset.Name = "button_DataInput_Reset";
            this.button_DataInput_Reset.Size = new System.Drawing.Size(96, 30);
            this.button_DataInput_Reset.TabIndex = 3;
            this.button_DataInput_Reset.Text = "Reset";
            this.button_DataInput_Reset.UseVisualStyleBackColor = true;
            // 
            // textBox_DataInput_FileInfo
            // 
            this.textBox_DataInput_FileInfo.AcceptsReturn = true;
            this.textBox_DataInput_FileInfo.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_DataInput_FileInfo.Location = new System.Drawing.Point(6, 58);
            this.textBox_DataInput_FileInfo.Multiline = true;
            this.textBox_DataInput_FileInfo.Name = "textBox_DataInput_FileInfo";
            this.textBox_DataInput_FileInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_DataInput_FileInfo.Size = new System.Drawing.Size(365, 111);
            this.textBox_DataInput_FileInfo.TabIndex = 2;
            // 
            // label_DataInput_InfoText
            // 
            this.label_DataInput_InfoText.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_DataInput_InfoText.Location = new System.Drawing.Point(207, 22);
            this.label_DataInput_InfoText.Name = "label_DataInput_InfoText";
            this.label_DataInput_InfoText.Size = new System.Drawing.Size(164, 30);
            this.label_DataInput_InfoText.TabIndex = 1;
            this.label_DataInput_InfoText.Text = "No JSON File Input";
            this.label_DataInput_InfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_DataInput_Input
            // 
            this.button_DataInput_Input.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_DataInput_Input.Location = new System.Drawing.Point(6, 22);
            this.button_DataInput_Input.Name = "button_DataInput_Input";
            this.button_DataInput_Input.Size = new System.Drawing.Size(96, 30);
            this.button_DataInput_Input.TabIndex = 0;
            this.button_DataInput_Input.Text = "Input";
            this.button_DataInput_Input.UseVisualStyleBackColor = true;
            // 
            // groupBox_AssessmentResult
            // 
            this.groupBox_AssessmentResult.Controls.Add(this.label_AssessmentResult_Info);
            this.groupBox_AssessmentResult.Controls.Add(this.comboBox_AssessmentResult_LevelChoose);
            this.groupBox_AssessmentResult.Controls.Add(this.listView_AssessmentResult_NodeList);
            this.groupBox_AssessmentResult.Controls.Add(this.textBox_AssessmentResult_NodeDetail);
            this.groupBox_AssessmentResult.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_AssessmentResult.Location = new System.Drawing.Point(12, 426);
            this.groupBox_AssessmentResult.Name = "groupBox_AssessmentResult";
            this.groupBox_AssessmentResult.Size = new System.Drawing.Size(760, 183);
            this.groupBox_AssessmentResult.TabIndex = 1;
            this.groupBox_AssessmentResult.TabStop = false;
            this.groupBox_AssessmentResult.Text = "Assessment Result";
            // 
            // label_AssessmentResult_Info
            // 
            this.label_AssessmentResult_Info.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_AssessmentResult_Info.Location = new System.Drawing.Point(7, 23);
            this.label_AssessmentResult_Info.Name = "label_AssessmentResult_Info";
            this.label_AssessmentResult_Info.Size = new System.Drawing.Size(110, 20);
            this.label_AssessmentResult_Info.TabIndex = 4;
            this.label_AssessmentResult_Info.Text = "Level Detail:";
            this.label_AssessmentResult_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox_AssessmentResult_LevelChoose
            // 
            this.comboBox_AssessmentResult_LevelChoose.FormattingEnabled = true;
            this.comboBox_AssessmentResult_LevelChoose.Items.AddRange(new object[] {
            "Level 1 - Design Attribute",
            "Level 2 - Attribute",
            "Level 3 - Property",
            "Level 4 - Metric"});
            this.comboBox_AssessmentResult_LevelChoose.Location = new System.Drawing.Point(123, 22);
            this.comboBox_AssessmentResult_LevelChoose.Name = "comboBox_AssessmentResult_LevelChoose";
            this.comboBox_AssessmentResult_LevelChoose.Size = new System.Drawing.Size(188, 25);
            this.comboBox_AssessmentResult_LevelChoose.TabIndex = 3;
            this.comboBox_AssessmentResult_LevelChoose.Text = "Choose One To See Details";
            // 
            // listView_AssessmentResult_NodeList
            // 
            this.listView_AssessmentResult_NodeList.HideSelection = false;
            this.listView_AssessmentResult_NodeList.Location = new System.Drawing.Point(7, 53);
            this.listView_AssessmentResult_NodeList.Name = "listView_AssessmentResult_NodeList";
            this.listView_AssessmentResult_NodeList.Size = new System.Drawing.Size(370, 124);
            this.listView_AssessmentResult_NodeList.TabIndex = 1;
            this.listView_AssessmentResult_NodeList.UseCompatibleStateImageBehavior = false;
            this.listView_AssessmentResult_NodeList.View = System.Windows.Forms.View.Details;
            // 
            // textBox_AssessmentResult_NodeDetail
            // 
            this.textBox_AssessmentResult_NodeDetail.AcceptsReturn = true;
            this.textBox_AssessmentResult_NodeDetail.Location = new System.Drawing.Point(383, 22);
            this.textBox_AssessmentResult_NodeDetail.Multiline = true;
            this.textBox_AssessmentResult_NodeDetail.Name = "textBox_AssessmentResult_NodeDetail";
            this.textBox_AssessmentResult_NodeDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_AssessmentResult_NodeDetail.Size = new System.Drawing.Size(371, 155);
            this.textBox_AssessmentResult_NodeDetail.TabIndex = 0;
            // 
            // groupBox_History
            // 
            this.groupBox_History.Controls.Add(this.listView_History_HistoryInfo);
            this.groupBox_History.Controls.Add(this.button_History_Details);
            this.groupBox_History.Controls.Add(this.button_History_ClearAll);
            this.groupBox_History.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_History.Location = new System.Drawing.Point(395, 12);
            this.groupBox_History.Name = "groupBox_History";
            this.groupBox_History.Size = new System.Drawing.Size(377, 175);
            this.groupBox_History.TabIndex = 5;
            this.groupBox_History.TabStop = false;
            this.groupBox_History.Text = "History";
            // 
            // listView_History_HistoryInfo
            // 
            this.listView_History_HistoryInfo.HideSelection = false;
            this.listView_History_HistoryInfo.Location = new System.Drawing.Point(7, 58);
            this.listView_History_HistoryInfo.Name = "listView_History_HistoryInfo";
            this.listView_History_HistoryInfo.Size = new System.Drawing.Size(364, 111);
            this.listView_History_HistoryInfo.TabIndex = 3;
            this.listView_History_HistoryInfo.UseCompatibleStateImageBehavior = false;
            this.listView_History_HistoryInfo.View = System.Windows.Forms.View.Details;
            // 
            // button_History_Details
            // 
            this.button_History_Details.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_History_Details.Location = new System.Drawing.Point(301, 22);
            this.button_History_Details.Name = "button_History_Details";
            this.button_History_Details.Size = new System.Drawing.Size(70, 30);
            this.button_History_Details.TabIndex = 2;
            this.button_History_Details.Text = "Details";
            this.button_History_Details.UseVisualStyleBackColor = true;
            // 
            // button_History_ClearAll
            // 
            this.button_History_ClearAll.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_History_ClearAll.Location = new System.Drawing.Point(218, 22);
            this.button_History_ClearAll.Name = "button_History_ClearAll";
            this.button_History_ClearAll.Size = new System.Drawing.Size(77, 30);
            this.button_History_ClearAll.TabIndex = 1;
            this.button_History_ClearAll.Text = "Clear All";
            this.button_History_ClearAll.UseVisualStyleBackColor = true;
            // 
            // groupBox_ModelWeight
            // 
            this.groupBox_ModelWeight.Controls.Add(this.button_ModelWeight_SaveChanges);
            this.groupBox_ModelWeight.Controls.Add(this.button_ModelWeight_DefaultSettings);
            this.groupBox_ModelWeight.Controls.Add(this.groupBox_ModelWeight_Level3);
            this.groupBox_ModelWeight.Controls.Add(this.groupBox_ModelWeight_Level2);
            this.groupBox_ModelWeight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox_ModelWeight.Location = new System.Drawing.Point(12, 193);
            this.groupBox_ModelWeight.Name = "groupBox_ModelWeight";
            this.groupBox_ModelWeight.Size = new System.Drawing.Size(760, 227);
            this.groupBox_ModelWeight.TabIndex = 6;
            this.groupBox_ModelWeight.TabStop = false;
            this.groupBox_ModelWeight.Text = "Model Weight";
            // 
            // button_ModelWeight_SaveChanges
            // 
            this.button_ModelWeight_SaveChanges.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ModelWeight_SaveChanges.Location = new System.Drawing.Point(195, 189);
            this.button_ModelWeight_SaveChanges.Name = "button_ModelWeight_SaveChanges";
            this.button_ModelWeight_SaveChanges.Size = new System.Drawing.Size(182, 32);
            this.button_ModelWeight_SaveChanges.TabIndex = 3;
            this.button_ModelWeight_SaveChanges.Text = "Save Changes";
            this.button_ModelWeight_SaveChanges.UseVisualStyleBackColor = true;
            // 
            // button_ModelWeight_DefaultSettings
            // 
            this.button_ModelWeight_DefaultSettings.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_ModelWeight_DefaultSettings.Location = new System.Drawing.Point(7, 189);
            this.button_ModelWeight_DefaultSettings.Name = "button_ModelWeight_DefaultSettings";
            this.button_ModelWeight_DefaultSettings.Size = new System.Drawing.Size(182, 32);
            this.button_ModelWeight_DefaultSettings.TabIndex = 2;
            this.button_ModelWeight_DefaultSettings.Text = "Default Settings";
            this.button_ModelWeight_DefaultSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox_ModelWeight_Level3
            // 
            this.groupBox_ModelWeight_Level3.Controls.Add(this.textBox_ModelWeight_Level3_Property5Weight);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.textBox_ModelWeight_Level3_Property4Weight);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.label_ModelWeight_Level3_Property5);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.textBox_ModelWeight_Level3_Property3Weight);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.label_ModelWeight_Level3_Property4);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.label_ModelWeight_Level3_Property3);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.label_ModelWeight_Level3_Property2);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.textBox_ModelWeight_Level3_Property2Weight);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.textBox_ModelWeight_Level3_Property1Weight);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.label_ModelWeight_Level3_AttributeInfoText);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.comboBox_ModelWeight_Level3_AttributeChoose);
            this.groupBox_ModelWeight_Level3.Controls.Add(this.label_ModelWeight_Level3_Property1);
            this.groupBox_ModelWeight_Level3.Location = new System.Drawing.Point(383, 23);
            this.groupBox_ModelWeight_Level3.Name = "groupBox_ModelWeight_Level3";
            this.groupBox_ModelWeight_Level3.Size = new System.Drawing.Size(371, 197);
            this.groupBox_ModelWeight_Level3.TabIndex = 1;
            this.groupBox_ModelWeight_Level3.TabStop = false;
            this.groupBox_ModelWeight_Level3.Text = "Level 3";
            // 
            // textBox_ModelWeight_Level3_Property5Weight
            // 
            this.textBox_ModelWeight_Level3_Property5Weight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level3_Property5Weight.Location = new System.Drawing.Point(172, 164);
            this.textBox_ModelWeight_Level3_Property5Weight.Name = "textBox_ModelWeight_Level3_Property5Weight";
            this.textBox_ModelWeight_Level3_Property5Weight.Size = new System.Drawing.Size(193, 25);
            this.textBox_ModelWeight_Level3_Property5Weight.TabIndex = 11;
            // 
            // textBox_ModelWeight_Level3_Property4Weight
            // 
            this.textBox_ModelWeight_Level3_Property4Weight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level3_Property4Weight.Location = new System.Drawing.Point(172, 136);
            this.textBox_ModelWeight_Level3_Property4Weight.Name = "textBox_ModelWeight_Level3_Property4Weight";
            this.textBox_ModelWeight_Level3_Property4Weight.Size = new System.Drawing.Size(193, 25);
            this.textBox_ModelWeight_Level3_Property4Weight.TabIndex = 10;
            // 
            // label_ModelWeight_Level3_Property5
            // 
            this.label_ModelWeight_Level3_Property5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level3_Property5.Location = new System.Drawing.Point(6, 166);
            this.label_ModelWeight_Level3_Property5.Name = "label_ModelWeight_Level3_Property5";
            this.label_ModelWeight_Level3_Property5.Size = new System.Drawing.Size(160, 20);
            this.label_ModelWeight_Level3_Property5.TabIndex = 7;
            this.label_ModelWeight_Level3_Property5.Text = "Property5";
            this.label_ModelWeight_Level3_Property5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_ModelWeight_Level3_Property3Weight
            // 
            this.textBox_ModelWeight_Level3_Property3Weight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level3_Property3Weight.Location = new System.Drawing.Point(172, 108);
            this.textBox_ModelWeight_Level3_Property3Weight.Name = "textBox_ModelWeight_Level3_Property3Weight";
            this.textBox_ModelWeight_Level3_Property3Weight.Size = new System.Drawing.Size(193, 25);
            this.textBox_ModelWeight_Level3_Property3Weight.TabIndex = 9;
            // 
            // label_ModelWeight_Level3_Property4
            // 
            this.label_ModelWeight_Level3_Property4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level3_Property4.Location = new System.Drawing.Point(6, 138);
            this.label_ModelWeight_Level3_Property4.Name = "label_ModelWeight_Level3_Property4";
            this.label_ModelWeight_Level3_Property4.Size = new System.Drawing.Size(160, 20);
            this.label_ModelWeight_Level3_Property4.TabIndex = 6;
            this.label_ModelWeight_Level3_Property4.Text = "Property4";
            this.label_ModelWeight_Level3_Property4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ModelWeight_Level3_Property3
            // 
            this.label_ModelWeight_Level3_Property3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level3_Property3.Location = new System.Drawing.Point(6, 110);
            this.label_ModelWeight_Level3_Property3.Name = "label_ModelWeight_Level3_Property3";
            this.label_ModelWeight_Level3_Property3.Size = new System.Drawing.Size(160, 20);
            this.label_ModelWeight_Level3_Property3.TabIndex = 5;
            this.label_ModelWeight_Level3_Property3.Text = "Property3";
            this.label_ModelWeight_Level3_Property3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ModelWeight_Level3_Property2
            // 
            this.label_ModelWeight_Level3_Property2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level3_Property2.Location = new System.Drawing.Point(6, 82);
            this.label_ModelWeight_Level3_Property2.Name = "label_ModelWeight_Level3_Property2";
            this.label_ModelWeight_Level3_Property2.Size = new System.Drawing.Size(160, 20);
            this.label_ModelWeight_Level3_Property2.TabIndex = 4;
            this.label_ModelWeight_Level3_Property2.Text = "Property2";
            this.label_ModelWeight_Level3_Property2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_ModelWeight_Level3_Property2Weight
            // 
            this.textBox_ModelWeight_Level3_Property2Weight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level3_Property2Weight.Location = new System.Drawing.Point(172, 80);
            this.textBox_ModelWeight_Level3_Property2Weight.Name = "textBox_ModelWeight_Level3_Property2Weight";
            this.textBox_ModelWeight_Level3_Property2Weight.Size = new System.Drawing.Size(193, 25);
            this.textBox_ModelWeight_Level3_Property2Weight.TabIndex = 8;
            // 
            // textBox_ModelWeight_Level3_Property1Weight
            // 
            this.textBox_ModelWeight_Level3_Property1Weight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level3_Property1Weight.Location = new System.Drawing.Point(172, 52);
            this.textBox_ModelWeight_Level3_Property1Weight.Name = "textBox_ModelWeight_Level3_Property1Weight";
            this.textBox_ModelWeight_Level3_Property1Weight.Size = new System.Drawing.Size(193, 25);
            this.textBox_ModelWeight_Level3_Property1Weight.TabIndex = 3;
            // 
            // label_ModelWeight_Level3_AttributeInfoText
            // 
            this.label_ModelWeight_Level3_AttributeInfoText.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level3_AttributeInfoText.Location = new System.Drawing.Point(6, 22);
            this.label_ModelWeight_Level3_AttributeInfoText.Name = "label_ModelWeight_Level3_AttributeInfoText";
            this.label_ModelWeight_Level3_AttributeInfoText.Size = new System.Drawing.Size(81, 20);
            this.label_ModelWeight_Level3_AttributeInfoText.TabIndex = 2;
            this.label_ModelWeight_Level3_AttributeInfoText.Text = "Attribute:";
            // 
            // comboBox_ModelWeight_Level3_AttributeChoose
            // 
            this.comboBox_ModelWeight_Level3_AttributeChoose.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox_ModelWeight_Level3_AttributeChoose.FormattingEnabled = true;
            this.comboBox_ModelWeight_Level3_AttributeChoose.Items.AddRange(new object[] {
            "Analyzability",
            "Changeability",
            "Stability",
            "Modularity"});
            this.comboBox_ModelWeight_Level3_AttributeChoose.Location = new System.Drawing.Point(172, 19);
            this.comboBox_ModelWeight_Level3_AttributeChoose.Name = "comboBox_ModelWeight_Level3_AttributeChoose";
            this.comboBox_ModelWeight_Level3_AttributeChoose.Size = new System.Drawing.Size(193, 27);
            this.comboBox_ModelWeight_Level3_AttributeChoose.TabIndex = 1;
            this.comboBox_ModelWeight_Level3_AttributeChoose.Text = "Choose One To Edit";
            // 
            // label_ModelWeight_Level3_Property1
            // 
            this.label_ModelWeight_Level3_Property1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level3_Property1.Location = new System.Drawing.Point(6, 54);
            this.label_ModelWeight_Level3_Property1.Name = "label_ModelWeight_Level3_Property1";
            this.label_ModelWeight_Level3_Property1.Size = new System.Drawing.Size(160, 20);
            this.label_ModelWeight_Level3_Property1.TabIndex = 0;
            this.label_ModelWeight_Level3_Property1.Text = "Property1";
            this.label_ModelWeight_Level3_Property1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox_ModelWeight_Level2
            // 
            this.groupBox_ModelWeight_Level2.Controls.Add(this.label_ModelWeight_Level2_DesignAttributeInfoText);
            this.groupBox_ModelWeight_Level2.Controls.Add(this.textBox_ModelWeight_Level2_ModularityWeight);
            this.groupBox_ModelWeight_Level2.Controls.Add(this.textBox_ModelWeight_Level2_StabilityWeight);
            this.groupBox_ModelWeight_Level2.Controls.Add(this.textBox_ModelWeight_Level2_ChangeabilityWeight);
            this.groupBox_ModelWeight_Level2.Controls.Add(this.textBox_ModelWeight_Level2_AnalyzabilityWeight);
            this.groupBox_ModelWeight_Level2.Controls.Add(this.label_ModelWeight_Level2_Modularity);
            this.groupBox_ModelWeight_Level2.Controls.Add(this.label_ModelWeight_Level2_Stability);
            this.groupBox_ModelWeight_Level2.Controls.Add(this.label_ModelWeight_Level2_Changeability);
            this.groupBox_ModelWeight_Level2.Controls.Add(this.label_ModelWeight_Level2_Analyzability);
            this.groupBox_ModelWeight_Level2.Location = new System.Drawing.Point(7, 23);
            this.groupBox_ModelWeight_Level2.Name = "groupBox_ModelWeight_Level2";
            this.groupBox_ModelWeight_Level2.Size = new System.Drawing.Size(370, 162);
            this.groupBox_ModelWeight_Level2.TabIndex = 0;
            this.groupBox_ModelWeight_Level2.TabStop = false;
            this.groupBox_ModelWeight_Level2.Text = "Level 2";
            // 
            // label_ModelWeight_Level2_DesignAttributeInfoText
            // 
            this.label_ModelWeight_Level2_DesignAttributeInfoText.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level2_DesignAttributeInfoText.Location = new System.Drawing.Point(6, 22);
            this.label_ModelWeight_Level2_DesignAttributeInfoText.Name = "label_ModelWeight_Level2_DesignAttributeInfoText";
            this.label_ModelWeight_Level2_DesignAttributeInfoText.Size = new System.Drawing.Size(281, 20);
            this.label_ModelWeight_Level2_DesignAttributeInfoText.TabIndex = 8;
            this.label_ModelWeight_Level2_DesignAttributeInfoText.Text = "Design Attribute:      Maintainability";
            // 
            // textBox_ModelWeight_Level2_ModularityWeight
            // 
            this.textBox_ModelWeight_Level2_ModularityWeight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level2_ModularityWeight.Location = new System.Drawing.Point(145, 130);
            this.textBox_ModelWeight_Level2_ModularityWeight.Name = "textBox_ModelWeight_Level2_ModularityWeight";
            this.textBox_ModelWeight_Level2_ModularityWeight.Size = new System.Drawing.Size(219, 25);
            this.textBox_ModelWeight_Level2_ModularityWeight.TabIndex = 7;
            // 
            // textBox_ModelWeight_Level2_StabilityWeight
            // 
            this.textBox_ModelWeight_Level2_StabilityWeight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level2_StabilityWeight.Location = new System.Drawing.Point(145, 104);
            this.textBox_ModelWeight_Level2_StabilityWeight.Name = "textBox_ModelWeight_Level2_StabilityWeight";
            this.textBox_ModelWeight_Level2_StabilityWeight.Size = new System.Drawing.Size(219, 25);
            this.textBox_ModelWeight_Level2_StabilityWeight.TabIndex = 6;
            // 
            // textBox_ModelWeight_Level2_ChangeabilityWeight
            // 
            this.textBox_ModelWeight_Level2_ChangeabilityWeight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level2_ChangeabilityWeight.Location = new System.Drawing.Point(145, 78);
            this.textBox_ModelWeight_Level2_ChangeabilityWeight.Name = "textBox_ModelWeight_Level2_ChangeabilityWeight";
            this.textBox_ModelWeight_Level2_ChangeabilityWeight.Size = new System.Drawing.Size(219, 25);
            this.textBox_ModelWeight_Level2_ChangeabilityWeight.TabIndex = 5;
            // 
            // textBox_ModelWeight_Level2_AnalyzabilityWeight
            // 
            this.textBox_ModelWeight_Level2_AnalyzabilityWeight.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_ModelWeight_Level2_AnalyzabilityWeight.Location = new System.Drawing.Point(145, 52);
            this.textBox_ModelWeight_Level2_AnalyzabilityWeight.Name = "textBox_ModelWeight_Level2_AnalyzabilityWeight";
            this.textBox_ModelWeight_Level2_AnalyzabilityWeight.Size = new System.Drawing.Size(219, 25);
            this.textBox_ModelWeight_Level2_AnalyzabilityWeight.TabIndex = 4;
            // 
            // label_ModelWeight_Level2_Modularity
            // 
            this.label_ModelWeight_Level2_Modularity.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level2_Modularity.Location = new System.Drawing.Point(6, 131);
            this.label_ModelWeight_Level2_Modularity.Name = "label_ModelWeight_Level2_Modularity";
            this.label_ModelWeight_Level2_Modularity.Size = new System.Drawing.Size(133, 22);
            this.label_ModelWeight_Level2_Modularity.TabIndex = 3;
            this.label_ModelWeight_Level2_Modularity.Text = "Modularity:";
            this.label_ModelWeight_Level2_Modularity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ModelWeight_Level2_Stability
            // 
            this.label_ModelWeight_Level2_Stability.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level2_Stability.Location = new System.Drawing.Point(6, 105);
            this.label_ModelWeight_Level2_Stability.Name = "label_ModelWeight_Level2_Stability";
            this.label_ModelWeight_Level2_Stability.Size = new System.Drawing.Size(133, 22);
            this.label_ModelWeight_Level2_Stability.TabIndex = 2;
            this.label_ModelWeight_Level2_Stability.Text = "Stability:";
            this.label_ModelWeight_Level2_Stability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ModelWeight_Level2_Changeability
            // 
            this.label_ModelWeight_Level2_Changeability.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level2_Changeability.Location = new System.Drawing.Point(6, 79);
            this.label_ModelWeight_Level2_Changeability.Name = "label_ModelWeight_Level2_Changeability";
            this.label_ModelWeight_Level2_Changeability.Size = new System.Drawing.Size(133, 22);
            this.label_ModelWeight_Level2_Changeability.TabIndex = 1;
            this.label_ModelWeight_Level2_Changeability.Text = "Changeability:";
            this.label_ModelWeight_Level2_Changeability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ModelWeight_Level2_Analyzability
            // 
            this.label_ModelWeight_Level2_Analyzability.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ModelWeight_Level2_Analyzability.Location = new System.Drawing.Point(6, 53);
            this.label_ModelWeight_Level2_Analyzability.Name = "label_ModelWeight_Level2_Analyzability";
            this.label_ModelWeight_Level2_Analyzability.Size = new System.Drawing.Size(133, 22);
            this.label_ModelWeight_Level2_Analyzability.TabIndex = 0;
            this.label_ModelWeight_Level2_Analyzability.Text = "Analyzability:";
            this.label_ModelWeight_Level2_Analyzability.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 613);
            this.Controls.Add(this.groupBox_ModelWeight);
            this.Controls.Add(this.groupBox_History);
            this.Controls.Add(this.groupBox_AssessmentResult);
            this.Controls.Add(this.groupBox_DataInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microservice Maintainability Assess Tool";
            this.groupBox_DataInput.ResumeLayout(false);
            this.groupBox_DataInput.PerformLayout();
            this.groupBox_AssessmentResult.ResumeLayout(false);
            this.groupBox_AssessmentResult.PerformLayout();
            this.groupBox_History.ResumeLayout(false);
            this.groupBox_ModelWeight.ResumeLayout(false);
            this.groupBox_ModelWeight_Level3.ResumeLayout(false);
            this.groupBox_ModelWeight_Level3.PerformLayout();
            this.groupBox_ModelWeight_Level2.ResumeLayout(false);
            this.groupBox_ModelWeight_Level2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_DataInput;
        private System.Windows.Forms.GroupBox groupBox_AssessmentResult;
        private System.Windows.Forms.TextBox textBox_DataInput_FileInfo;
        private System.Windows.Forms.Label label_DataInput_InfoText;
        private System.Windows.Forms.Button button_DataInput_Input;
        private System.Windows.Forms.TextBox textBox_AssessmentResult_NodeDetail;
        private System.Windows.Forms.GroupBox groupBox_History;
        private System.Windows.Forms.Button button_History_ClearAll;
        private System.Windows.Forms.Button button_History_Details;
        private System.Windows.Forms.GroupBox groupBox_ModelWeight;
        private System.Windows.Forms.GroupBox groupBox_ModelWeight_Level2;
        private System.Windows.Forms.GroupBox groupBox_ModelWeight_Level3;
        private System.Windows.Forms.Label label_ModelWeight_Level2_DesignAttributeInfoText;
        private System.Windows.Forms.ComboBox comboBox_ModelWeight_Level3_AttributeChoose;
        private System.Windows.Forms.Label label_ModelWeight_Level3_AttributeInfoText;
        private System.Windows.Forms.Button button_ModelWeight_SaveChanges;
        private System.Windows.Forms.Button button_ModelWeight_DefaultSettings;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level3_Property5Weight;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level3_Property4Weight;
        private System.Windows.Forms.Label label_ModelWeight_Level3_Property5;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level3_Property3Weight;
        private System.Windows.Forms.Label label_ModelWeight_Level3_Property4;
        private System.Windows.Forms.Label label_ModelWeight_Level3_Property3;
        private System.Windows.Forms.Label label_ModelWeight_Level3_Property2;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level3_Property2Weight;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level3_Property1Weight;
        private System.Windows.Forms.Label label_ModelWeight_Level3_Property1;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level2_ModularityWeight;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level2_StabilityWeight;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level2_ChangeabilityWeight;
        private System.Windows.Forms.TextBox textBox_ModelWeight_Level2_AnalyzabilityWeight;
        private System.Windows.Forms.Label label_ModelWeight_Level2_Modularity;
        private System.Windows.Forms.Label label_ModelWeight_Level2_Stability;
        private System.Windows.Forms.Label label_ModelWeight_Level2_Changeability;
        private System.Windows.Forms.Label label_ModelWeight_Level2_Analyzability;
        private System.Windows.Forms.Button button_DataInput_Reset;
        private System.Windows.Forms.ListView listView_History_HistoryInfo;
        private System.Windows.Forms.ListView listView_AssessmentResult_NodeList;
        private System.Windows.Forms.Label label_AssessmentResult_Info;
        private System.Windows.Forms.ComboBox comboBox_AssessmentResult_LevelChoose;
    }
}

