using System.Windows.Forms;

namespace CustomWebSearch
{
	partial class OptionPageControl
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomWebBrowserPathFileDialog = new System.Windows.Forms.Button();
            this.txtboxCustomWebBrowserPath = new System.Windows.Forms.TextBox();
            this.dropdownWebBrowserType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuery10Test = new System.Windows.Forms.Button();
            this.btnQuery9Test = new System.Windows.Forms.Button();
            this.btnQuery8Test = new System.Windows.Forms.Button();
            this.btnQuery7Test = new System.Windows.Forms.Button();
            this.btnQuery6Test = new System.Windows.Forms.Button();
            this.btnQuery5Test = new System.Windows.Forms.Button();
            this.btnQuery4Test = new System.Windows.Forms.Button();
            this.btnQuery3Test = new System.Windows.Forms.Button();
            this.btnQuery2Test = new System.Windows.Forms.Button();
            this.btnQuery1Test = new System.Windows.Forms.Button();
            this.txtboxQuery10 = new System.Windows.Forms.TextBox();
            this.txtboxQuery9 = new System.Windows.Forms.TextBox();
            this.txtboxQuery8 = new System.Windows.Forms.TextBox();
            this.txtboxQuery7 = new System.Windows.Forms.TextBox();
            this.txtboxQuery6 = new System.Windows.Forms.TextBox();
            this.txtboxQuery5 = new System.Windows.Forms.TextBox();
            this.txtboxQuery4 = new System.Windows.Forms.TextBox();
            this.txtboxQuery3 = new System.Windows.Forms.TextBox();
            this.txtboxQuery2 = new System.Windows.Forms.TextBox();
            this.txtboxQuery1 = new System.Windows.Forms.TextBox();
            this.dropdownQuery2 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery3 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery4 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery5 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery6 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery7 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery8 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery9 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery10 = new System.Windows.Forms.ComboBox();
            this.dropdownQuery1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCustomWebBrowserPathFileDialog);
            this.groupBox1.Controls.Add(this.txtboxCustomWebBrowserPath);
            this.groupBox1.Controls.Add(this.dropdownWebBrowserType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Web Browser Setting";
            // 
            // btnCustomWebBrowserPathFileDialog
            // 
            this.btnCustomWebBrowserPathFileDialog.AutoSize = true;
            this.btnCustomWebBrowserPathFileDialog.Location = new System.Drawing.Point(483, 44);
            this.btnCustomWebBrowserPathFileDialog.Name = "btnCustomWebBrowserPathFileDialog";
            this.btnCustomWebBrowserPathFileDialog.Size = new System.Drawing.Size(40, 27);
            this.btnCustomWebBrowserPathFileDialog.TabIndex = 3;
            this.btnCustomWebBrowserPathFileDialog.Text = "...";
            this.btnCustomWebBrowserPathFileDialog.UseVisualStyleBackColor = true;
            this.btnCustomWebBrowserPathFileDialog.Click += new System.EventHandler(this.btnCustomWebBrowserPathFileDialog_Click);
            // 
            // txtboxCustomWebBrowserPath
            // 
            this.txtboxCustomWebBrowserPath.Location = new System.Drawing.Point(206, 45);
            this.txtboxCustomWebBrowserPath.Name = "txtboxCustomWebBrowserPath";
            this.txtboxCustomWebBrowserPath.ReadOnly = true;
            this.txtboxCustomWebBrowserPath.Size = new System.Drawing.Size(271, 22);
            this.txtboxCustomWebBrowserPath.TabIndex = 2;
            // 
            // dropdownWebBrowserType
            // 
            this.dropdownWebBrowserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownWebBrowserType.FormattingEnabled = true;
            this.dropdownWebBrowserType.Location = new System.Drawing.Point(206, 20);
            this.dropdownWebBrowserType.Name = "dropdownWebBrowserType";
            this.dropdownWebBrowserType.Size = new System.Drawing.Size(317, 24);
            this.dropdownWebBrowserType.TabIndex = 1;
            this.dropdownWebBrowserType.SelectedIndexChanged += new System.EventHandler(this.dropdownWebBrowserType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Custom Web Browser Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web Browser Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnQuery10Test);
            this.groupBox2.Controls.Add(this.btnQuery9Test);
            this.groupBox2.Controls.Add(this.btnQuery8Test);
            this.groupBox2.Controls.Add(this.btnQuery7Test);
            this.groupBox2.Controls.Add(this.btnQuery6Test);
            this.groupBox2.Controls.Add(this.btnQuery5Test);
            this.groupBox2.Controls.Add(this.btnQuery4Test);
            this.groupBox2.Controls.Add(this.btnQuery3Test);
            this.groupBox2.Controls.Add(this.btnQuery2Test);
            this.groupBox2.Controls.Add(this.btnQuery1Test);
            this.groupBox2.Controls.Add(this.txtboxQuery10);
            this.groupBox2.Controls.Add(this.txtboxQuery9);
            this.groupBox2.Controls.Add(this.txtboxQuery8);
            this.groupBox2.Controls.Add(this.txtboxQuery7);
            this.groupBox2.Controls.Add(this.txtboxQuery6);
            this.groupBox2.Controls.Add(this.txtboxQuery5);
            this.groupBox2.Controls.Add(this.txtboxQuery4);
            this.groupBox2.Controls.Add(this.txtboxQuery3);
            this.groupBox2.Controls.Add(this.txtboxQuery2);
            this.groupBox2.Controls.Add(this.txtboxQuery1);
            this.groupBox2.Controls.Add(this.dropdownQuery2);
            this.groupBox2.Controls.Add(this.dropdownQuery3);
            this.groupBox2.Controls.Add(this.dropdownQuery4);
            this.groupBox2.Controls.Add(this.dropdownQuery5);
            this.groupBox2.Controls.Add(this.dropdownQuery6);
            this.groupBox2.Controls.Add(this.dropdownQuery7);
            this.groupBox2.Controls.Add(this.dropdownQuery8);
            this.groupBox2.Controls.Add(this.dropdownQuery9);
            this.groupBox2.Controls.Add(this.dropdownQuery10);
            this.groupBox2.Controls.Add(this.dropdownQuery1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(843, 288);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Web Query";
            // 
            // btnQuery10Test
            // 
            this.btnQuery10Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery10Test.AutoSize = true;
            this.btnQuery10Test.Location = new System.Drawing.Point(791, 245);
            this.btnQuery10Test.Name = "btnQuery10Test";
            this.btnQuery10Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery10Test.TabIndex = 3;
            this.btnQuery10Test.Tag = "9";
            this.btnQuery10Test.Text = "Test";
            this.btnQuery10Test.UseVisualStyleBackColor = true;
            this.btnQuery10Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery9Test
            // 
            this.btnQuery9Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery9Test.AutoSize = true;
            this.btnQuery9Test.Location = new System.Drawing.Point(791, 220);
            this.btnQuery9Test.Name = "btnQuery9Test";
            this.btnQuery9Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery9Test.TabIndex = 3;
            this.btnQuery9Test.Tag = "8";
            this.btnQuery9Test.Text = "Test";
            this.btnQuery9Test.UseVisualStyleBackColor = true;
            this.btnQuery9Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery8Test
            // 
            this.btnQuery8Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery8Test.AutoSize = true;
            this.btnQuery8Test.Location = new System.Drawing.Point(791, 195);
            this.btnQuery8Test.Name = "btnQuery8Test";
            this.btnQuery8Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery8Test.TabIndex = 3;
            this.btnQuery8Test.Tag = "7";
            this.btnQuery8Test.Text = "Test";
            this.btnQuery8Test.UseVisualStyleBackColor = true;
            this.btnQuery8Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery7Test
            // 
            this.btnQuery7Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery7Test.AutoSize = true;
            this.btnQuery7Test.Location = new System.Drawing.Point(791, 170);
            this.btnQuery7Test.Name = "btnQuery7Test";
            this.btnQuery7Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery7Test.TabIndex = 3;
            this.btnQuery7Test.Tag = "6";
            this.btnQuery7Test.Text = "Test";
            this.btnQuery7Test.UseVisualStyleBackColor = true;
            this.btnQuery7Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery6Test
            // 
            this.btnQuery6Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery6Test.AutoSize = true;
            this.btnQuery6Test.Location = new System.Drawing.Point(791, 145);
            this.btnQuery6Test.Name = "btnQuery6Test";
            this.btnQuery6Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery6Test.TabIndex = 3;
            this.btnQuery6Test.Tag = "5";
            this.btnQuery6Test.Text = "Test";
            this.btnQuery6Test.UseVisualStyleBackColor = true;
            this.btnQuery6Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery5Test
            // 
            this.btnQuery5Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery5Test.AutoSize = true;
            this.btnQuery5Test.Location = new System.Drawing.Point(791, 120);
            this.btnQuery5Test.Name = "btnQuery5Test";
            this.btnQuery5Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery5Test.TabIndex = 3;
            this.btnQuery5Test.Tag = "4";
            this.btnQuery5Test.Text = "Test";
            this.btnQuery5Test.UseVisualStyleBackColor = true;
            this.btnQuery5Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery4Test
            // 
            this.btnQuery4Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery4Test.AutoSize = true;
            this.btnQuery4Test.Location = new System.Drawing.Point(791, 95);
            this.btnQuery4Test.Name = "btnQuery4Test";
            this.btnQuery4Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery4Test.TabIndex = 3;
            this.btnQuery4Test.Tag = "3";
            this.btnQuery4Test.Text = "Test";
            this.btnQuery4Test.UseVisualStyleBackColor = true;
            this.btnQuery4Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery3Test
            // 
            this.btnQuery3Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery3Test.AutoSize = true;
            this.btnQuery3Test.Location = new System.Drawing.Point(791, 70);
            this.btnQuery3Test.Name = "btnQuery3Test";
            this.btnQuery3Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery3Test.TabIndex = 3;
            this.btnQuery3Test.Tag = "2";
            this.btnQuery3Test.Text = "Test";
            this.btnQuery3Test.UseVisualStyleBackColor = true;
            this.btnQuery3Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery2Test
            // 
            this.btnQuery2Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery2Test.AutoSize = true;
            this.btnQuery2Test.Location = new System.Drawing.Point(791, 45);
            this.btnQuery2Test.Name = "btnQuery2Test";
            this.btnQuery2Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery2Test.TabIndex = 3;
            this.btnQuery2Test.Tag = "1";
            this.btnQuery2Test.Text = "Test";
            this.btnQuery2Test.UseVisualStyleBackColor = true;
            this.btnQuery2Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // btnQuery1Test
            // 
            this.btnQuery1Test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery1Test.AutoSize = true;
            this.btnQuery1Test.Location = new System.Drawing.Point(791, 20);
            this.btnQuery1Test.Name = "btnQuery1Test";
            this.btnQuery1Test.Size = new System.Drawing.Size(46, 27);
            this.btnQuery1Test.TabIndex = 3;
            this.btnQuery1Test.Tag = "0";
            this.btnQuery1Test.Text = "Test";
            this.btnQuery1Test.UseVisualStyleBackColor = true;
            this.btnQuery1Test.Click += new System.EventHandler(this.btnQueryTest_Click);
            // 
            // txtboxQuery10
            // 
            this.txtboxQuery10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery10.Location = new System.Drawing.Point(228, 246);
            this.txtboxQuery10.Name = "txtboxQuery10";
            this.txtboxQuery10.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery10.TabIndex = 3;
            this.txtboxQuery10.Tag = "9";
            this.txtboxQuery10.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery9
            // 
            this.txtboxQuery9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery9.Location = new System.Drawing.Point(228, 221);
            this.txtboxQuery9.Name = "txtboxQuery9";
            this.txtboxQuery9.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery9.TabIndex = 3;
            this.txtboxQuery9.Tag = "8";
            this.txtboxQuery9.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery8
            // 
            this.txtboxQuery8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery8.Location = new System.Drawing.Point(228, 196);
            this.txtboxQuery8.Name = "txtboxQuery8";
            this.txtboxQuery8.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery8.TabIndex = 3;
            this.txtboxQuery8.Tag = "7";
            this.txtboxQuery8.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery7
            // 
            this.txtboxQuery7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery7.Location = new System.Drawing.Point(228, 171);
            this.txtboxQuery7.Name = "txtboxQuery7";
            this.txtboxQuery7.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery7.TabIndex = 3;
            this.txtboxQuery7.Tag = "6";
            this.txtboxQuery7.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery6
            // 
            this.txtboxQuery6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery6.Location = new System.Drawing.Point(228, 146);
            this.txtboxQuery6.Name = "txtboxQuery6";
            this.txtboxQuery6.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery6.TabIndex = 3;
            this.txtboxQuery6.Tag = "5";
            this.txtboxQuery6.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery5
            // 
            this.txtboxQuery5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery5.Location = new System.Drawing.Point(228, 121);
            this.txtboxQuery5.Name = "txtboxQuery5";
            this.txtboxQuery5.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery5.TabIndex = 3;
            this.txtboxQuery5.Tag = "4";
            this.txtboxQuery5.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery4
            // 
            this.txtboxQuery4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery4.Location = new System.Drawing.Point(228, 96);
            this.txtboxQuery4.Name = "txtboxQuery4";
            this.txtboxQuery4.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery4.TabIndex = 3;
            this.txtboxQuery4.Tag = "3";
            this.txtboxQuery4.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery3
            // 
            this.txtboxQuery3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery3.Location = new System.Drawing.Point(228, 71);
            this.txtboxQuery3.Name = "txtboxQuery3";
            this.txtboxQuery3.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery3.TabIndex = 3;
            this.txtboxQuery3.Tag = "2";
            this.txtboxQuery3.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery2
            // 
            this.txtboxQuery2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery2.Location = new System.Drawing.Point(228, 46);
            this.txtboxQuery2.Name = "txtboxQuery2";
            this.txtboxQuery2.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery2.TabIndex = 3;
            this.txtboxQuery2.Tag = "1";
            this.txtboxQuery2.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // txtboxQuery1
            // 
            this.txtboxQuery1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtboxQuery1.Location = new System.Drawing.Point(228, 21);
            this.txtboxQuery1.Name = "txtboxQuery1";
            this.txtboxQuery1.Size = new System.Drawing.Size(557, 22);
            this.txtboxQuery1.TabIndex = 3;
            this.txtboxQuery1.Tag = "0";
            this.txtboxQuery1.TextChanged += new System.EventHandler(this.textboxQuery_TextChanged);
            // 
            // dropdownQuery2
            // 
            this.dropdownQuery2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery2.FormattingEnabled = true;
            this.dropdownQuery2.Location = new System.Drawing.Point(89, 47);
            this.dropdownQuery2.Name = "dropdownQuery2";
            this.dropdownQuery2.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery2.TabIndex = 2;
            this.dropdownQuery2.Tag = "1";
            this.dropdownQuery2.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery3
            // 
            this.dropdownQuery3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery3.FormattingEnabled = true;
            this.dropdownQuery3.Location = new System.Drawing.Point(89, 72);
            this.dropdownQuery3.Name = "dropdownQuery3";
            this.dropdownQuery3.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery3.TabIndex = 2;
            this.dropdownQuery3.Tag = "2";
            this.dropdownQuery3.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery4
            // 
            this.dropdownQuery4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery4.FormattingEnabled = true;
            this.dropdownQuery4.Location = new System.Drawing.Point(89, 97);
            this.dropdownQuery4.Name = "dropdownQuery4";
            this.dropdownQuery4.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery4.TabIndex = 2;
            this.dropdownQuery4.Tag = "3";
            this.dropdownQuery4.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery5
            // 
            this.dropdownQuery5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery5.FormattingEnabled = true;
            this.dropdownQuery5.Location = new System.Drawing.Point(89, 122);
            this.dropdownQuery5.Name = "dropdownQuery5";
            this.dropdownQuery5.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery5.TabIndex = 2;
            this.dropdownQuery5.Tag = "4";
            this.dropdownQuery5.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery6
            // 
            this.dropdownQuery6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery6.FormattingEnabled = true;
            this.dropdownQuery6.Location = new System.Drawing.Point(89, 147);
            this.dropdownQuery6.Name = "dropdownQuery6";
            this.dropdownQuery6.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery6.TabIndex = 2;
            this.dropdownQuery6.Tag = "5";
            this.dropdownQuery6.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery7
            // 
            this.dropdownQuery7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery7.FormattingEnabled = true;
            this.dropdownQuery7.Location = new System.Drawing.Point(89, 172);
            this.dropdownQuery7.Name = "dropdownQuery7";
            this.dropdownQuery7.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery7.TabIndex = 2;
            this.dropdownQuery7.Tag = "6";
            this.dropdownQuery7.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery8
            // 
            this.dropdownQuery8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery8.FormattingEnabled = true;
            this.dropdownQuery8.Location = new System.Drawing.Point(89, 197);
            this.dropdownQuery8.Name = "dropdownQuery8";
            this.dropdownQuery8.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery8.TabIndex = 2;
            this.dropdownQuery8.Tag = "7";
            this.dropdownQuery8.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery9
            // 
            this.dropdownQuery9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery9.FormattingEnabled = true;
            this.dropdownQuery9.Location = new System.Drawing.Point(89, 222);
            this.dropdownQuery9.Name = "dropdownQuery9";
            this.dropdownQuery9.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery9.TabIndex = 2;
            this.dropdownQuery9.Tag = "8";
            this.dropdownQuery9.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery10
            // 
            this.dropdownQuery10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery10.FormattingEnabled = true;
            this.dropdownQuery10.Location = new System.Drawing.Point(89, 247);
            this.dropdownQuery10.Name = "dropdownQuery10";
            this.dropdownQuery10.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery10.TabIndex = 2;
            this.dropdownQuery10.Tag = "9";
            this.dropdownQuery10.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // dropdownQuery1
            // 
            this.dropdownQuery1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownQuery1.FormattingEnabled = true;
            this.dropdownQuery1.Location = new System.Drawing.Point(89, 22);
            this.dropdownQuery1.Name = "dropdownQuery1";
            this.dropdownQuery1.Size = new System.Drawing.Size(131, 24);
            this.dropdownQuery1.TabIndex = 1;
            this.dropdownQuery1.Tag = "0";
            this.dropdownQuery1.SelectedIndexChanged += new System.EventHandler(this.dropdownQuery_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Query 10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Query 9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Query 8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Query 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Query 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Query 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Query 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Query 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Query 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Query 1";
            // 
            // OptionPageControl
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "OptionPageControl";
            this.Size = new System.Drawing.Size(851, 381);
            this.Resize += new System.EventHandler(this.OptionPageControl_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCustomWebBrowserPathFileDialog;
		private System.Windows.Forms.TextBox txtboxCustomWebBrowserPath;
		private System.Windows.Forms.ComboBox dropdownWebBrowserType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtboxQuery10;
		private System.Windows.Forms.TextBox txtboxQuery9;
		private System.Windows.Forms.TextBox txtboxQuery8;
		private System.Windows.Forms.TextBox txtboxQuery7;
		private System.Windows.Forms.TextBox txtboxQuery6;
		private System.Windows.Forms.TextBox txtboxQuery5;
		private System.Windows.Forms.TextBox txtboxQuery4;
		private System.Windows.Forms.TextBox txtboxQuery3;
		private System.Windows.Forms.TextBox txtboxQuery2;
		private System.Windows.Forms.TextBox txtboxQuery1;
		private System.Windows.Forms.ComboBox dropdownQuery2;
		private System.Windows.Forms.ComboBox dropdownQuery3;
		private System.Windows.Forms.ComboBox dropdownQuery4;
		private System.Windows.Forms.ComboBox dropdownQuery5;
		private System.Windows.Forms.ComboBox dropdownQuery6;
		private System.Windows.Forms.ComboBox dropdownQuery7;
		private System.Windows.Forms.ComboBox dropdownQuery8;
		private System.Windows.Forms.ComboBox dropdownQuery9;
		private System.Windows.Forms.ComboBox dropdownQuery10;
		private System.Windows.Forms.ComboBox dropdownQuery1;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private Button btnQuery1Test;
		private Button btnQuery10Test;
		private Button btnQuery9Test;
		private Button btnQuery8Test;
		private Button btnQuery7Test;
		private Button btnQuery6Test;
		private Button btnQuery5Test;
		private Button btnQuery4Test;
		private Button btnQuery3Test;
		private Button btnQuery2Test;
	}
}
