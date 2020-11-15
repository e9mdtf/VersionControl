namespace week8
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.carBtn = new System.Windows.Forms.Button();
            this.ballBtn = new System.Windows.Forms.Button();
            this.comingNextLabel = new System.Windows.Forms.Label();
            this.colorBtn = new System.Windows.Forms.Button();
            this.presentBtn = new System.Windows.Forms.Button();
            this.boxColorBtn = new System.Windows.Forms.Button();
            this.ribbonColorBtn = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.ribbonColorBtn);
            this.mainPanel.Controls.Add(this.boxColorBtn);
            this.mainPanel.Controls.Add(this.presentBtn);
            this.mainPanel.Controls.Add(this.colorBtn);
            this.mainPanel.Controls.Add(this.comingNextLabel);
            this.mainPanel.Controls.Add(this.ballBtn);
            this.mainPanel.Controls.Add(this.carBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(895, 541);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // carBtn
            // 
            this.carBtn.Location = new System.Drawing.Point(12, 12);
            this.carBtn.Name = "carBtn";
            this.carBtn.Size = new System.Drawing.Size(75, 54);
            this.carBtn.TabIndex = 0;
            this.carBtn.Text = "Car";
            this.carBtn.UseVisualStyleBackColor = true;
            this.carBtn.Click += new System.EventHandler(this.carBtn_Click);
            // 
            // ballBtn
            // 
            this.ballBtn.Location = new System.Drawing.Point(105, 12);
            this.ballBtn.Name = "ballBtn";
            this.ballBtn.Size = new System.Drawing.Size(75, 54);
            this.ballBtn.TabIndex = 1;
            this.ballBtn.Text = "Ball";
            this.ballBtn.UseVisualStyleBackColor = true;
            this.ballBtn.Click += new System.EventHandler(this.ballBtn_Click);
            // 
            // comingNextLabel
            // 
            this.comingNextLabel.AutoSize = true;
            this.comingNextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comingNextLabel.Location = new System.Drawing.Point(350, 12);
            this.comingNextLabel.Name = "comingNextLabel";
            this.comingNextLabel.Size = new System.Drawing.Size(115, 20);
            this.comingNextLabel.TabIndex = 2;
            this.comingNextLabel.Text = "Coming Next:";
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.colorBtn.Location = new System.Drawing.Point(105, 90);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(75, 23);
            this.colorBtn.TabIndex = 3;
            this.colorBtn.UseVisualStyleBackColor = false;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // presentBtn
            // 
            this.presentBtn.Location = new System.Drawing.Point(201, 12);
            this.presentBtn.Name = "presentBtn";
            this.presentBtn.Size = new System.Drawing.Size(75, 54);
            this.presentBtn.TabIndex = 4;
            this.presentBtn.Text = "Present";
            this.presentBtn.UseVisualStyleBackColor = true;
            this.presentBtn.Click += new System.EventHandler(this.presentBtn_Click);
            // 
            // boxColorBtn
            // 
            this.boxColorBtn.BackColor = System.Drawing.Color.DarkRed;
            this.boxColorBtn.Location = new System.Drawing.Point(201, 90);
            this.boxColorBtn.Name = "boxColorBtn";
            this.boxColorBtn.Size = new System.Drawing.Size(75, 23);
            this.boxColorBtn.TabIndex = 5;
            this.boxColorBtn.UseVisualStyleBackColor = false;
            this.boxColorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // ribbonColorBtn
            // 
            this.ribbonColorBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.ribbonColorBtn.Location = new System.Drawing.Point(201, 131);
            this.ribbonColorBtn.Name = "ribbonColorBtn";
            this.ribbonColorBtn.Size = new System.Drawing.Size(75, 23);
            this.ribbonColorBtn.TabIndex = 6;
            this.ribbonColorBtn.UseVisualStyleBackColor = false;
            this.ribbonColorBtn.Click += new System.EventHandler(this.colorBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 541);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button carBtn;
        private System.Windows.Forms.Button ballBtn;
        private System.Windows.Forms.Label comingNextLabel;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.Button ribbonColorBtn;
        private System.Windows.Forms.Button boxColorBtn;
        private System.Windows.Forms.Button presentBtn;
    }
}

