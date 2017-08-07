namespace BreakTime
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Bttn_Start = new System.Windows.Forms.Button();
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu_NotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IconMenu_Pause = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenu_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.IconMenu_AddFive = new System.Windows.Forms.ToolStripMenuItem();
            this.Box_WorkInterval = new System.Windows.Forms.TextBox();
            this.Bttn_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Box_BreakInterval = new System.Windows.Forms.TextBox();
            this.Label_Timer = new System.Windows.Forms.Label();
            this.Label_Status = new System.Windows.Forms.Label();
            this.Bttn_Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IconMenu_Hide = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_NotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bttn_Start
            // 
            this.Bttn_Start.BackColor = System.Drawing.Color.LimeGreen;
            this.Bttn_Start.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.Bttn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bttn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Start.ForeColor = System.Drawing.Color.White;
            this.Bttn_Start.Location = new System.Drawing.Point(12, 168);
            this.Bttn_Start.Name = "Bttn_Start";
            this.Bttn_Start.Size = new System.Drawing.Size(124, 39);
            this.Bttn_Start.TabIndex = 0;
            this.Bttn_Start.Text = "START";
            this.Bttn_Start.UseVisualStyleBackColor = false;
            this.Bttn_Start.Click += new System.EventHandler(this.Bttn_Start_Click);
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 1000;
            this.breakTimer.Tick += new System.EventHandler(this.breakTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "App to remind you to getup and move around.";
            this.notifyIcon1.BalloonTipTitle = "Break Time";
            this.notifyIcon1.ContextMenuStrip = this.ContextMenu_NotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Break Time";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // ContextMenu_NotifyIcon
            // 
            this.ContextMenu_NotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IconMenu_Pause,
            this.IconMenu_Start,
            this.IconMenu_AddFive,
            this.IconMenu_Hide});
            this.ContextMenu_NotifyIcon.Name = "ContextMenu_NotifyIcon";
            this.ContextMenu_NotifyIcon.Size = new System.Drawing.Size(180, 178);
            // 
            // IconMenu_Pause
            // 
            this.IconMenu_Pause.Image = ((System.Drawing.Image)(resources.GetObject("IconMenu_Pause.Image")));
            this.IconMenu_Pause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconMenu_Pause.Name = "IconMenu_Pause";
            this.IconMenu_Pause.Size = new System.Drawing.Size(179, 38);
            this.IconMenu_Pause.Text = "Pause Timer";
            this.IconMenu_Pause.Click += new System.EventHandler(this.IconMenu_Pause_Click);
            // 
            // IconMenu_Start
            // 
            this.IconMenu_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.IconMenu_Start.Image = ((System.Drawing.Image)(resources.GetObject("IconMenu_Start.Image")));
            this.IconMenu_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconMenu_Start.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconMenu_Start.Name = "IconMenu_Start";
            this.IconMenu_Start.Size = new System.Drawing.Size(179, 38);
            this.IconMenu_Start.Text = "Start / Resume";
            this.IconMenu_Start.Click += new System.EventHandler(this.IconMenu_Start_Click);
            // 
            // IconMenu_AddFive
            // 
            this.IconMenu_AddFive.Image = ((System.Drawing.Image)(resources.GetObject("IconMenu_AddFive.Image")));
            this.IconMenu_AddFive.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconMenu_AddFive.Name = "IconMenu_AddFive";
            this.IconMenu_AddFive.Size = new System.Drawing.Size(179, 38);
            this.IconMenu_AddFive.Text = "Add 5 Minutes";
            this.IconMenu_AddFive.Click += new System.EventHandler(this.IconMenu_AddFive_Click);
            // 
            // Box_WorkInterval
            // 
            this.Box_WorkInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_WorkInterval.Location = new System.Drawing.Point(94, 96);
            this.Box_WorkInterval.Name = "Box_WorkInterval";
            this.Box_WorkInterval.Size = new System.Drawing.Size(54, 22);
            this.Box_WorkInterval.TabIndex = 3;
            this.Box_WorkInterval.Text = "50";
            this.Box_WorkInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bttn_Stop
            // 
            this.Bttn_Stop.BackColor = System.Drawing.Color.Crimson;
            this.Bttn_Stop.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.Bttn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bttn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Stop.ForeColor = System.Drawing.Color.White;
            this.Bttn_Stop.Location = new System.Drawing.Point(165, 168);
            this.Bttn_Stop.Name = "Bttn_Stop";
            this.Bttn_Stop.Size = new System.Drawing.Size(124, 39);
            this.Bttn_Stop.TabIndex = 4;
            this.Bttn_Stop.Text = "STOP";
            this.Bttn_Stop.UseVisualStyleBackColor = false;
            this.Bttn_Stop.Click += new System.EventHandler(this.Bttn_Stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Work Intervals";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Break Intervals";
            // 
            // Box_BreakInterval
            // 
            this.Box_BreakInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_BreakInterval.Location = new System.Drawing.Point(94, 127);
            this.Box_BreakInterval.Name = "Box_BreakInterval";
            this.Box_BreakInterval.Size = new System.Drawing.Size(54, 22);
            this.Box_BreakInterval.TabIndex = 6;
            this.Box_BreakInterval.Text = "10";
            this.Box_BreakInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label_Timer
            // 
            this.Label_Timer.AutoSize = true;
            this.Label_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Timer.Location = new System.Drawing.Point(141, 9);
            this.Label_Timer.Name = "Label_Timer";
            this.Label_Timer.Size = new System.Drawing.Size(172, 42);
            this.Label_Timer.TabIndex = 8;
            this.Label_Timer.Text = "00:00:00";
            // 
            // Label_Status
            // 
            this.Label_Status.AutoSize = true;
            this.Label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Status.Location = new System.Drawing.Point(186, 61);
            this.Label_Status.Name = "Label_Status";
            this.Label_Status.Size = new System.Drawing.Size(69, 20);
            this.Label_Status.TabIndex = 9;
            this.Label_Status.Text = "BREAK";
            // 
            // Bttn_Reset
            // 
            this.Bttn_Reset.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Bttn_Reset.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.Bttn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bttn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bttn_Reset.ForeColor = System.Drawing.Color.White;
            this.Bttn_Reset.Location = new System.Drawing.Point(321, 168);
            this.Bttn_Reset.Name = "Bttn_Reset";
            this.Bttn_Reset.Size = new System.Drawing.Size(124, 39);
            this.Bttn_Reset.TabIndex = 10;
            this.Bttn_Reset.Text = "RESET";
            this.Bttn_Reset.UseVisualStyleBackColor = false;
            this.Bttn_Reset.Click += new System.EventHandler(this.Bttn_Reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "( how long a work session should last in minutes )";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "( how long a break session should last in minutes)";
            // 
            // IconMenu_Hide
            // 
            this.IconMenu_Hide.Image = ((System.Drawing.Image)(resources.GetObject("IconMenu_Hide.Image")));
            this.IconMenu_Hide.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.IconMenu_Hide.Name = "IconMenu_Hide";
            this.IconMenu_Hide.Size = new System.Drawing.Size(179, 38);
            this.IconMenu_Hide.Text = "Minimize to Tray";
            this.IconMenu_Hide.Click += new System.EventHandler(this.IconMenu_Hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 219);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bttn_Reset);
            this.Controls.Add(this.Label_Status);
            this.Controls.Add(this.Label_Timer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Box_BreakInterval);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bttn_Stop);
            this.Controls.Add(this.Box_WorkInterval);
            this.Controls.Add(this.Bttn_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Break Time";
            this.ContextMenu_NotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bttn_Start;
        private System.Windows.Forms.Timer breakTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_NotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem IconMenu_Pause;
        private System.Windows.Forms.ToolStripMenuItem IconMenu_Start;
        private System.Windows.Forms.ToolStripMenuItem IconMenu_AddFive;
        private System.Windows.Forms.TextBox Box_WorkInterval;
        private System.Windows.Forms.Button Bttn_Stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Box_BreakInterval;
        private System.Windows.Forms.Label Label_Timer;
        private System.Windows.Forms.Label Label_Status;
        private System.Windows.Forms.Button Bttn_Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem IconMenu_Hide;
    }
}

