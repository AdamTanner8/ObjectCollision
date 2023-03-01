namespace SensorObjects
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Friction = new System.Windows.Forms.TextBox();
            this.cb_Friction = new System.Windows.Forms.CheckBox();
            this.l_Effects = new System.Windows.Forms.Label();
            this.l_addObject = new System.Windows.Forms.Label();
            this.b_addObject = new System.Windows.Forms.Button();
            this.rb_sensorObject = new System.Windows.Forms.RadioButton();
            this.rb_basicObject = new System.Windows.Forms.RadioButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_Apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel2.Controls.Add(this.b_Apply);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.tb_Friction);
            this.splitContainer1.Panel2.Controls.Add(this.cb_Friction);
            this.splitContainer1.Panel2.Controls.Add(this.l_Effects);
            this.splitContainer1.Panel2.Controls.Add(this.l_addObject);
            this.splitContainer1.Panel2.Controls.Add(this.b_addObject);
            this.splitContainer1.Panel2.Controls.Add(this.rb_sensorObject);
            this.splitContainer1.Panel2.Controls.Add(this.rb_basicObject);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 609;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_Friction
            // 
            this.tb_Friction.Location = new System.Drawing.Point(135, 272);
            this.tb_Friction.Name = "tb_Friction";
            this.tb_Friction.Size = new System.Drawing.Size(30, 23);
            this.tb_Friction.TabIndex = 7;
            // 
            // cb_Friction
            // 
            this.cb_Friction.AutoSize = true;
            this.cb_Friction.Location = new System.Drawing.Point(27, 274);
            this.cb_Friction.Name = "cb_Friction";
            this.cb_Friction.Size = new System.Drawing.Size(66, 19);
            this.cb_Friction.TabIndex = 6;
            this.cb_Friction.Text = "Friction";
            this.cb_Friction.UseVisualStyleBackColor = true;
            // 
            // l_Effects
            // 
            this.l_Effects.AutoSize = true;
            this.l_Effects.Location = new System.Drawing.Point(50, 233);
            this.l_Effects.Name = "l_Effects";
            this.l_Effects.Size = new System.Drawing.Size(45, 15);
            this.l_Effects.TabIndex = 5;
            this.l_Effects.Text = "Effects:";
            // 
            // l_addObject
            // 
            this.l_addObject.AutoSize = true;
            this.l_addObject.BackColor = System.Drawing.SystemColors.ControlLight;
            this.l_addObject.Location = new System.Drawing.Point(27, 58);
            this.l_addObject.Name = "l_addObject";
            this.l_addObject.Size = new System.Drawing.Size(97, 15);
            this.l_addObject.TabIndex = 4;
            this.l_addObject.Text = "Add New Object:";
            // 
            // b_addObject
            // 
            this.b_addObject.Location = new System.Drawing.Point(40, 165);
            this.b_addObject.Name = "b_addObject";
            this.b_addObject.Size = new System.Drawing.Size(75, 23);
            this.b_addObject.TabIndex = 3;
            this.b_addObject.Text = "Add";
            this.b_addObject.UseVisualStyleBackColor = true;
            this.b_addObject.Click += new System.EventHandler(this.b_addObject_Click);
            // 
            // rb_sensorObject
            // 
            this.rb_sensorObject.AutoSize = true;
            this.rb_sensorObject.Location = new System.Drawing.Point(27, 123);
            this.rb_sensorObject.Name = "rb_sensorObject";
            this.rb_sensorObject.Size = new System.Drawing.Size(96, 19);
            this.rb_sensorObject.TabIndex = 2;
            this.rb_sensorObject.TabStop = true;
            this.rb_sensorObject.Text = "Sensor object";
            this.rb_sensorObject.UseVisualStyleBackColor = true;
            // 
            // rb_basicObject
            // 
            this.rb_basicObject.AutoSize = true;
            this.rb_basicObject.Location = new System.Drawing.Point(27, 98);
            this.rb_basicObject.Name = "rb_basicObject";
            this.rb_basicObject.Size = new System.Drawing.Size(88, 19);
            this.rb_basicObject.TabIndex = 1;
            this.rb_basicObject.TabStop = true;
            this.rb_basicObject.Text = "Basic object";
            this.rb_basicObject.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // b_Apply
            // 
            this.b_Apply.Location = new System.Drawing.Point(40, 319);
            this.b_Apply.Name = "b_Apply";
            this.b_Apply.Size = new System.Drawing.Size(75, 23);
            this.b_Apply.TabIndex = 9;
            this.b_Apply.Text = "Apply";
            this.b_Apply.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button b_addObject;
        private RadioButton rb_sensorObject;
        private RadioButton rb_basicObject;
        private Label l_addObject;
        private Button button1;
        private TextBox tb_Friction;
        private CheckBox cb_Friction;
        private Label l_Effects;
        private Button b_Apply;
    }
}