namespace TestWinApp
{
    partial class Core_Entity
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyEditing_GroupBox = new System.Windows.Forms.GroupBox();
            this.cancelProperty_Button = new System.Windows.Forms.Button();
            this.saveProperty_Button = new System.Windows.Forms.Button();
            this.propertyName_TextBox = new System.Windows.Forms.TextBox();
            this.propertyValue_TextBox = new System.Windows.Forms.TextBox();
            this.propertyId_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupEditing_GroupBox = new System.Windows.Forms.GroupBox();
            this.cancelGroup_Button = new System.Windows.Forms.Button();
            this.saveGroup_Button = new System.Windows.Forms.Button();
            this.groupId_TextBox = new System.Windows.Forms.TextBox();
            this.groupName_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.propertyEditing_GroupBox.SuspendLayout();
            this.groupEditing_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupAddToolStripMenuItem,
            this.propertyAddToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // groupAddToolStripMenuItem
            // 
            this.groupAddToolStripMenuItem.Name = "groupAddToolStripMenuItem";
            this.groupAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.groupAddToolStripMenuItem.Text = "Группу";
            this.groupAddToolStripMenuItem.Click += new System.EventHandler(this.groupAddToolStripMenuItem_Click);
            // 
            // propertyAddToolStripMenuItem
            // 
            this.propertyAddToolStripMenuItem.Name = "propertyAddToolStripMenuItem";
            this.propertyAddToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.propertyAddToolStripMenuItem.Text = "Свойство";
            this.propertyAddToolStripMenuItem.Click += new System.EventHandler(this.propertyAddToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // propertyEditing_GroupBox
            // 
            this.propertyEditing_GroupBox.Controls.Add(this.cancelProperty_Button);
            this.propertyEditing_GroupBox.Controls.Add(this.saveProperty_Button);
            this.propertyEditing_GroupBox.Controls.Add(this.propertyName_TextBox);
            this.propertyEditing_GroupBox.Controls.Add(this.propertyValue_TextBox);
            this.propertyEditing_GroupBox.Controls.Add(this.propertyId_TextBox);
            this.propertyEditing_GroupBox.Controls.Add(this.label3);
            this.propertyEditing_GroupBox.Controls.Add(this.label4);
            this.propertyEditing_GroupBox.Controls.Add(this.label5);
            this.propertyEditing_GroupBox.Enabled = false;
            this.propertyEditing_GroupBox.Location = new System.Drawing.Point(383, 318);
            this.propertyEditing_GroupBox.Name = "propertyEditing_GroupBox";
            this.propertyEditing_GroupBox.Size = new System.Drawing.Size(406, 234);
            this.propertyEditing_GroupBox.TabIndex = 1;
            this.propertyEditing_GroupBox.TabStop = false;
            this.propertyEditing_GroupBox.Text = "Форма редатирования свойства";
            // 
            // cancelProperty_Button
            // 
            this.cancelProperty_Button.Location = new System.Drawing.Point(285, 189);
            this.cancelProperty_Button.Name = "cancelProperty_Button";
            this.cancelProperty_Button.Size = new System.Drawing.Size(75, 23);
            this.cancelProperty_Button.TabIndex = 6;
            this.cancelProperty_Button.Text = "Отмена";
            this.cancelProperty_Button.UseVisualStyleBackColor = true;
            this.cancelProperty_Button.Click += new System.EventHandler(this.cancelProperty_Button_Click);
            // 
            // saveProperty_Button
            // 
            this.saveProperty_Button.Location = new System.Drawing.Point(171, 189);
            this.saveProperty_Button.Name = "saveProperty_Button";
            this.saveProperty_Button.Size = new System.Drawing.Size(75, 23);
            this.saveProperty_Button.TabIndex = 7;
            this.saveProperty_Button.Text = "Сохранить";
            this.saveProperty_Button.UseVisualStyleBackColor = true;
            this.saveProperty_Button.Click += new System.EventHandler(this.saveProperty_Button_Click);
            // 
            // propertyName_TextBox
            // 
            this.propertyName_TextBox.Location = new System.Drawing.Point(171, 70);
            this.propertyName_TextBox.Name = "propertyName_TextBox";
            this.propertyName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.propertyName_TextBox.TabIndex = 4;
            // 
            // propertyValue_TextBox
            // 
            this.propertyValue_TextBox.Location = new System.Drawing.Point(171, 113);
            this.propertyValue_TextBox.Name = "propertyValue_TextBox";
            this.propertyValue_TextBox.Size = new System.Drawing.Size(100, 20);
            this.propertyValue_TextBox.TabIndex = 5;
            // 
            // propertyId_TextBox
            // 
            this.propertyId_TextBox.Location = new System.Drawing.Point(171, 156);
            this.propertyId_TextBox.Name = "propertyId_TextBox";
            this.propertyId_TextBox.Size = new System.Drawing.Size(100, 20);
            this.propertyId_TextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наименование";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Значение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Id группы";
            // 
            // groupEditing_GroupBox
            // 
            this.groupEditing_GroupBox.Controls.Add(this.cancelGroup_Button);
            this.groupEditing_GroupBox.Controls.Add(this.saveGroup_Button);
            this.groupEditing_GroupBox.Controls.Add(this.groupId_TextBox);
            this.groupEditing_GroupBox.Controls.Add(this.groupName_TextBox);
            this.groupEditing_GroupBox.Controls.Add(this.label2);
            this.groupEditing_GroupBox.Controls.Add(this.label1);
            this.groupEditing_GroupBox.Enabled = false;
            this.groupEditing_GroupBox.Location = new System.Drawing.Point(383, 54);
            this.groupEditing_GroupBox.Name = "groupEditing_GroupBox";
            this.groupEditing_GroupBox.Size = new System.Drawing.Size(406, 234);
            this.groupEditing_GroupBox.TabIndex = 2;
            this.groupEditing_GroupBox.TabStop = false;
            this.groupEditing_GroupBox.Text = "Форма редатирования группы";
            // 
            // cancelGroup_Button
            // 
            this.cancelGroup_Button.Location = new System.Drawing.Point(285, 182);
            this.cancelGroup_Button.Name = "cancelGroup_Button";
            this.cancelGroup_Button.Size = new System.Drawing.Size(75, 23);
            this.cancelGroup_Button.TabIndex = 5;
            this.cancelGroup_Button.Text = "Отмена";
            this.cancelGroup_Button.UseVisualStyleBackColor = true;
            this.cancelGroup_Button.Click += new System.EventHandler(this.cancelGroup_Button_Click);
            // 
            // saveGroup_Button
            // 
            this.saveGroup_Button.Location = new System.Drawing.Point(171, 182);
            this.saveGroup_Button.Name = "saveGroup_Button";
            this.saveGroup_Button.Size = new System.Drawing.Size(75, 23);
            this.saveGroup_Button.TabIndex = 4;
            this.saveGroup_Button.Text = "Сохранить";
            this.saveGroup_Button.UseVisualStyleBackColor = true;
            this.saveGroup_Button.Click += new System.EventHandler(this.saveGroup_Button_Click);
            // 
            // groupId_TextBox
            // 
            this.groupId_TextBox.Location = new System.Drawing.Point(171, 107);
            this.groupId_TextBox.Name = "groupId_TextBox";
            this.groupId_TextBox.Size = new System.Drawing.Size(100, 20);
            this.groupId_TextBox.TabIndex = 3;
            // 
            // groupName_TextBox
            // 
            this.groupName_TextBox.Location = new System.Drawing.Point(171, 57);
            this.groupName_TextBox.Name = "groupName_TextBox";
            this.groupName_TextBox.Size = new System.Drawing.Size(100, 20);
            this.groupName_TextBox.TabIndex = 2;
            this.groupName_TextBox.TextChanged += new System.EventHandler(this.groupName_TextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(64, 54);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(248, 498);
            this.treeView1.TabIndex = 3;
            this.treeView1.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(33, 598);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 4;
            // 
            // Core_Entity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 620);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.groupEditing_GroupBox);
            this.Controls.Add(this.propertyEditing_GroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Core_Entity";
            this.Text = "Core_Entity";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Core_Entity_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.propertyEditing_GroupBox.ResumeLayout(false);
            this.propertyEditing_GroupBox.PerformLayout();
            this.groupEditing_GroupBox.ResumeLayout(false);
            this.groupEditing_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.GroupBox propertyEditing_GroupBox;
        private System.Windows.Forms.GroupBox groupEditing_GroupBox;
        private System.Windows.Forms.TextBox propertyName_TextBox;
        private System.Windows.Forms.TextBox propertyValue_TextBox;
        private System.Windows.Forms.TextBox propertyId_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox groupId_TextBox;
        private System.Windows.Forms.TextBox groupName_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelProperty_Button;
        private System.Windows.Forms.Button saveProperty_Button;
        private System.Windows.Forms.Button cancelGroup_Button;
        private System.Windows.Forms.Button saveGroup_Button;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem groupAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyAddToolStripMenuItem;
        private System.Windows.Forms.Label statusLabel;
    }
}