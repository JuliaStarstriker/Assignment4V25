namespace Assignment1VT25
{
    partial class MainForm
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
            txtName = new TextBox();
            label3 = new Label();
            txtAge = new TextBox();
            label4 = new Label();
            cmbGender = new ComboBox();
            label5 = new Label();
            checkBoxDomesticated = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            lbCategory = new ListBox();
            lblSpecies = new ListBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            lblSpeciesbox4 = new Label();
            lblSpeciesbox3 = new Label();
            lblSpeciesbox2 = new Label();
            lblSpeciesbox1 = new Label();
            lblDomesticeted = new Label();
            lblCategory = new Label();
            lblOutput4 = new Label();
            lblOutput3 = new Label();
            lblOutput2 = new Label();
            lblOutput1 = new Label();
            lblDomesticated = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblInpusInfo1 = new Label();
            lblInpusInfo2 = new Label();
            lblInpusInfo3 = new Label();
            lblInpusInfo4 = new Label();
            gbSpeciesInfo = new GroupBox();
            groupBox2 = new GroupBox();
            lstAnimals = new ListBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            lblAge = new Label();
            lblName = new Label();
            lblEaterType = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            lblID = new Label();
            lstFoodSchedule = new ListBox();
            label11 = new Label();
            lbIngredients = new ListBox();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            gbSpeciesInfo.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtG", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 45);
            label1.Name = "label1";
            label1.Size = new Size(262, 24);
            label1.TabIndex = 0;
            label1.Text = "Animal Specifications";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 27);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ControlLightLight;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(94, 31);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 78);
            label3.Name = "label3";
            label3.Size = new Size(33, 23);
            label3.TabIndex = 3;
            label3.Text = "Age";
            // 
            // txtAge
            // 
            txtAge.BackColor = SystemColors.ControlLightLight;
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(94, 78);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(175, 23);
            txtAge.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 133);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 5;
            label4.Text = "Gender";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(94, 136);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(175, 23);
            cmbGender.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 169);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 7;
            label5.Text = "Domesticated";
            // 
            // checkBoxDomesticated
            // 
            checkBoxDomesticated.AutoSize = true;
            checkBoxDomesticated.Location = new Point(254, 176);
            checkBoxDomesticated.Name = "checkBoxDomesticated";
            checkBoxDomesticated.Size = new Size(15, 14);
            checkBoxDomesticated.TabIndex = 8;
            checkBoxDomesticated.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 253);
            label6.Name = "label6";
            label6.Size = new Size(65, 23);
            label6.TabIndex = 9;
            label6.Text = "Category";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(168, 253);
            label7.Name = "label7";
            label7.Size = new Size(56, 23);
            label7.TabIndex = 10;
            label7.Text = "Species";
            label7.Click += label7_Click;
            // 
            // lbCategory
            // 
            lbCategory.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategory.FormattingEnabled = true;
            lbCategory.ItemHeight = 23;
            lbCategory.Location = new Point(18, 298);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(131, 142);
            lbCategory.TabIndex = 11;
            lbCategory.SelectedIndexChanged += lbCategory_SelectedIndexChanged;
            // 
            // lblSpecies
            // 
            lblSpecies.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpecies.FormattingEnabled = true;
            lblSpecies.ItemHeight = 23;
            lblSpecies.Location = new Point(168, 298);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(131, 142);
            lblSpecies.TabIndex = 12;
            lblSpecies.SelectedIndexChanged += lblSpecies_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Location = new Point(18, 473);
            button1.Name = "button1";
            button1.Size = new Size(281, 23);
            button1.TabIndex = 13;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSpeciesbox4);
            groupBox1.Controls.Add(lblSpeciesbox3);
            groupBox1.Controls.Add(lblSpeciesbox2);
            groupBox1.Controls.Add(lblSpeciesbox1);
            groupBox1.Controls.Add(lblDomesticeted);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(lblOutput4);
            groupBox1.Controls.Add(lblOutput3);
            groupBox1.Controls.Add(lblOutput2);
            groupBox1.Controls.Add(lblOutput1);
            groupBox1.Controls.Add(lblDomesticated);
            groupBox1.Location = new Point(18, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 214);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // lblSpeciesbox4
            // 
            lblSpeciesbox4.AutoSize = true;
            lblSpeciesbox4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpeciesbox4.Location = new Point(249, 160);
            lblSpeciesbox4.Name = "lblSpeciesbox4";
            lblSpeciesbox4.Size = new Size(22, 23);
            lblSpeciesbox4.TabIndex = 31;
            lblSpeciesbox4.Text = "...";
            // 
            // lblSpeciesbox3
            // 
            lblSpeciesbox3.AutoSize = true;
            lblSpeciesbox3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpeciesbox3.Location = new Point(249, 137);
            lblSpeciesbox3.Name = "lblSpeciesbox3";
            lblSpeciesbox3.Size = new Size(22, 23);
            lblSpeciesbox3.TabIndex = 30;
            lblSpeciesbox3.Text = "...";
            // 
            // lblSpeciesbox2
            // 
            lblSpeciesbox2.AutoSize = true;
            lblSpeciesbox2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpeciesbox2.Location = new Point(249, 111);
            lblSpeciesbox2.Name = "lblSpeciesbox2";
            lblSpeciesbox2.Size = new Size(22, 23);
            lblSpeciesbox2.TabIndex = 29;
            lblSpeciesbox2.Text = "...";
            // 
            // lblSpeciesbox1
            // 
            lblSpeciesbox1.AutoSize = true;
            lblSpeciesbox1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpeciesbox1.Location = new Point(249, 88);
            lblSpeciesbox1.Name = "lblSpeciesbox1";
            lblSpeciesbox1.Size = new Size(22, 23);
            lblSpeciesbox1.TabIndex = 28;
            lblSpeciesbox1.Text = "...";
            // 
            // lblDomesticeted
            // 
            lblDomesticeted.AutoSize = true;
            lblDomesticeted.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDomesticeted.Location = new Point(249, 65);
            lblDomesticeted.Name = "lblDomesticeted";
            lblDomesticeted.Size = new Size(22, 23);
            lblDomesticeted.TabIndex = 27;
            lblDomesticeted.Text = "...";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(14, 42);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(22, 23);
            lblCategory.TabIndex = 26;
            lblCategory.Text = "...";
            // 
            // lblOutput4
            // 
            lblOutput4.AutoSize = true;
            lblOutput4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput4.Location = new Point(14, 160);
            lblOutput4.Name = "lblOutput4";
            lblOutput4.Size = new Size(22, 23);
            lblOutput4.TabIndex = 21;
            lblOutput4.Text = "...";
            // 
            // lblOutput3
            // 
            lblOutput3.AutoSize = true;
            lblOutput3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput3.Location = new Point(14, 137);
            lblOutput3.Name = "lblOutput3";
            lblOutput3.Size = new Size(22, 23);
            lblOutput3.TabIndex = 20;
            lblOutput3.Text = "...";
            // 
            // lblOutput2
            // 
            lblOutput2.AutoSize = true;
            lblOutput2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput2.Location = new Point(14, 111);
            lblOutput2.Name = "lblOutput2";
            lblOutput2.Size = new Size(22, 23);
            lblOutput2.TabIndex = 19;
            lblOutput2.Text = "...";
            // 
            // lblOutput1
            // 
            lblOutput1.AutoSize = true;
            lblOutput1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOutput1.Location = new Point(14, 88);
            lblOutput1.Name = "lblOutput1";
            lblOutput1.Size = new Size(22, 23);
            lblOutput1.TabIndex = 18;
            lblOutput1.Text = "...";
            // 
            // lblDomesticated
            // 
            lblDomesticated.AutoSize = true;
            lblDomesticated.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDomesticated.Location = new Point(14, 65);
            lblDomesticated.Name = "lblDomesticated";
            lblDomesticated.Size = new Size(98, 23);
            lblDomesticated.TabIndex = 17;
            lblDomesticated.Text = "Domesticated:";
            lblDomesticated.Click += label12_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(157, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlLightLight;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(157, 78);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlLightLight;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(157, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(146, 23);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ControlLightLight;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(157, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(146, 23);
            textBox4.TabIndex = 18;
            // 
            // lblInpusInfo1
            // 
            lblInpusInfo1.AutoSize = true;
            lblInpusInfo1.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInpusInfo1.Location = new Point(11, 37);
            lblInpusInfo1.Name = "lblInpusInfo1";
            lblInpusInfo1.Size = new Size(22, 23);
            lblInpusInfo1.TabIndex = 19;
            lblInpusInfo1.Text = "...";
            lblInpusInfo1.Click += lblInpusInfo1_Click;
            // 
            // lblInpusInfo2
            // 
            lblInpusInfo2.AutoSize = true;
            lblInpusInfo2.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInpusInfo2.Location = new Point(11, 78);
            lblInpusInfo2.Name = "lblInpusInfo2";
            lblInpusInfo2.Size = new Size(22, 23);
            lblInpusInfo2.TabIndex = 20;
            lblInpusInfo2.Text = "...";
            // 
            // lblInpusInfo3
            // 
            lblInpusInfo3.AutoSize = true;
            lblInpusInfo3.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInpusInfo3.Location = new Point(11, 118);
            lblInpusInfo3.Name = "lblInpusInfo3";
            lblInpusInfo3.Size = new Size(22, 23);
            lblInpusInfo3.TabIndex = 21;
            lblInpusInfo3.Text = "...";
            // 
            // lblInpusInfo4
            // 
            lblInpusInfo4.AutoSize = true;
            lblInpusInfo4.Font = new Font("Sitka Banner", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInpusInfo4.Location = new Point(11, 161);
            lblInpusInfo4.Name = "lblInpusInfo4";
            lblInpusInfo4.Size = new Size(22, 23);
            lblInpusInfo4.TabIndex = 22;
            lblInpusInfo4.Text = "...";
            // 
            // gbSpeciesInfo
            // 
            gbSpeciesInfo.Controls.Add(textBox1);
            gbSpeciesInfo.Controls.Add(lblInpusInfo4);
            gbSpeciesInfo.Controls.Add(textBox2);
            gbSpeciesInfo.Controls.Add(lblInpusInfo3);
            gbSpeciesInfo.Controls.Add(textBox3);
            gbSpeciesInfo.Controls.Add(lblInpusInfo2);
            gbSpeciesInfo.Controls.Add(textBox4);
            gbSpeciesInfo.Controls.Add(lblInpusInfo1);
            gbSpeciesInfo.Location = new Point(326, 31);
            gbSpeciesInfo.Name = "gbSpeciesInfo";
            gbSpeciesInfo.Size = new Size(309, 204);
            gbSpeciesInfo.TabIndex = 23;
            gbSpeciesInfo.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtAge);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbGender);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(checkBoxDomesticated);
            groupBox2.Location = new Point(16, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(298, 204);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            // 
            // lstAnimals
            // 
            lstAnimals.FormattingEnabled = true;
            lstAnimals.ItemHeight = 15;
            lstAnimals.Location = new Point(356, 58);
            lstAnimals.Name = "lstAnimals";
            lstAnimals.Size = new Size(490, 214);
            lstAnimals.TabIndex = 25;
            lstAnimals.SelectedIndexChanged += lstAnimals_SelectedIndexChanged_1;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(gbSpeciesInfo);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(lbCategory);
            groupBox3.Controls.Add(lblSpecies);
            groupBox3.Controls.Add(button1);
            groupBox3.Location = new Point(36, 88);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(663, 520);
            groupBox3.TabIndex = 26;
            groupBox3.TabStop = false;
            groupBox3.Text = "Animal Specification";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblAge);
            groupBox4.Controls.Add(lblName);
            groupBox4.Controls.Add(lblEaterType);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(lblID);
            groupBox4.Controls.Add(lstFoodSchedule);
            groupBox4.Controls.Add(lstAnimals);
            groupBox4.Location = new Point(36, 614);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1405, 297);
            groupBox4.TabIndex = 27;
            groupBox4.TabStop = false;
            groupBox4.Text = "List of Registerd animals";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(601, 27);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 36;
            lblAge.Text = "Age";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(483, 27);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 35;
            lblName.Text = "Name";
            // 
            // lblEaterType
            // 
            lblEaterType.AutoSize = true;
            lblEaterType.Location = new Point(1079, 27);
            lblEaterType.Name = "lblEaterType";
            lblEaterType.Size = new Size(30, 15);
            lblEaterType.TabIndex = 32;
            lblEaterType.Text = "type";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(878, 27);
            label16.Name = "label16";
            label16.Size = new Size(64, 15);
            label16.TabIndex = 31;
            label16.Text = "Eater Type:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(710, 27);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 30;
            label15.Text = "Gender";
            label15.Click += label15_Click;
            // 
            // label14
            // 
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 33;
            // 
            // label13
            // 
            label13.Location = new Point(0, 0);
            label13.Name = "label13";
            label13.Size = new Size(100, 23);
            label13.TabIndex = 34;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(356, 27);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 27;
            lblID.Text = "ID";
            // 
            // lstFoodSchedule
            // 
            lstFoodSchedule.FormattingEnabled = true;
            lstFoodSchedule.ItemHeight = 15;
            lstFoodSchedule.Location = new Point(878, 58);
            lstFoodSchedule.Name = "lstFoodSchedule";
            lstFoodSchedule.Size = new Size(490, 214);
            lstFoodSchedule.TabIndex = 26;
            lstFoodSchedule.SelectedIndexChanged += lstFoodSchedule_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 40;
            // 
            // lbIngredients
            // 
            lbIngredients.FormattingEnabled = true;
            lbIngredients.ItemHeight = 15;
            lbIngredients.Location = new Point(733, 412);
            lbIngredients.Name = "lbIngredients";
            lbIngredients.Size = new Size(444, 139);
            lbIngredients.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(733, 394);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 37;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(833, 394);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 41;
            label9.Text = "Ingredients";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Location = new Point(733, 574);
            button2.Name = "button2";
            button2.Size = new Size(281, 23);
            button2.TabIndex = 25;
            button2.Text = "Food Items";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 945);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lbIngredients);
            Controls.Add(label11);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "EcoZoo - WTS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbSpeciesInfo.ResumeLayout(false);
            gbSpeciesInfo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtAge;
        private Label label4;
        private ComboBox cmbGender;
        private Label label5;
        private CheckBox checkBoxDomesticated;
        private Label label6;
        private Label label7;
        private ListBox lbCategory;
        private ListBox lblSpecies;
        private Button button1;
        private GroupBox groupBox1;
        private Label lblOutput4;
        private Label lblOutput3;
        private Label lblOutput2;
        private Label lblOutput1;
        private Label lblDomesticated;
        private Label lblDomesticeted;
        private Label lblCategory;
        private Label lblSpeciesbox4;
        private Label lblSpeciesbox3;
        private Label lblSpeciesbox2;
        private Label lblSpeciesbox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblInpusInfo1;
        private Label lblInpusInfo2;
        private Label lblInpusInfo3;
        private Label lblInpusInfo4;
        private GroupBox gbSpeciesInfo;
        private GroupBox groupBox2;
        private ListBox lstAnimals;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label lblEaterType;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label lblID;
        private ListBox lstFoodSchedule;
        private Label lblName;
        private Label lblAge;
        private Label label11;
        public ListBox lbIngredients;
        private Label label8;
        private Label label9;
        private Button button2;
    }
}
