
namespace AdvancedData
{
    partial class Form1
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
            this.lblTypeA = new System.Windows.Forms.Label();
            this.txtAuser = new System.Windows.Forms.TextBox();
            this.txtBuser = new System.Windows.Forms.TextBox();
            this.lblTypeB = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumDeadlocksOfA = new System.Windows.Forms.TextBox();
            this.txtNumDeadlocksOfB = new System.Windows.Forms.TextBox();
            this.AvgTimeOfA = new System.Windows.Forms.TextBox();
            this.AvgTimeOfB = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtIsolationLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTypeA
            // 
            this.lblTypeA.AutoSize = true;
            this.lblTypeA.Location = new System.Drawing.Point(80, 328);
            this.lblTypeA.Name = "lblTypeA";
            this.lblTypeA.Size = new System.Drawing.Size(68, 15);
            this.lblTypeA.TabIndex = 8;
            this.lblTypeA.Text = "Type A User";
            // 
            // txtAuser
            // 
            this.txtAuser.Location = new System.Drawing.Point(193, 325);
            this.txtAuser.Name = "txtAuser";
            this.txtAuser.PlaceholderText = "Enter user value";
            this.txtAuser.Size = new System.Drawing.Size(99, 23);
            this.txtAuser.TabIndex = 9;            
            // 
            // txtBuser
            // 
            this.txtBuser.Location = new System.Drawing.Point(452, 328);
            this.txtBuser.Name = "txtBuser";
            this.txtBuser.PlaceholderText = "Enter user value";
            this.txtBuser.Size = new System.Drawing.Size(99, 23);
            this.txtBuser.TabIndex = 10;
            // 
            // lblTypeB
            // 
            this.lblTypeB.AutoSize = true;
            this.lblTypeB.Location = new System.Drawing.Point(349, 331);
            this.lblTypeB.Name = "lblTypeB";
            this.lblTypeB.Size = new System.Drawing.Size(67, 15);
            this.lblTypeB.TabIndex = 11;
            this.lblTypeB.Text = "Type B User";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Gill Sans MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(603, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(78, 35);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Number Of Deadlocks Type A User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Average Time Of Type B Users";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Average Time Of Type A Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Number Of Deadlocks Type B User";
            // 
            // txtNumDeadlocksOfA
            // 
            this.txtNumDeadlocksOfA.Location = new System.Drawing.Point(318, 58);
            this.txtNumDeadlocksOfA.Name = "txtNumDeadlocksOfA";
            this.txtNumDeadlocksOfA.ReadOnly = true;
            this.txtNumDeadlocksOfA.Size = new System.Drawing.Size(100, 23);
            this.txtNumDeadlocksOfA.TabIndex = 22;            
            // 
            // txtNumDeadlocksOfB
            // 
            this.txtNumDeadlocksOfB.Location = new System.Drawing.Point(318, 100);
            this.txtNumDeadlocksOfB.Name = "txtNumDeadlocksOfB";
            this.txtNumDeadlocksOfB.ReadOnly = true;
            this.txtNumDeadlocksOfB.Size = new System.Drawing.Size(100, 23);
            this.txtNumDeadlocksOfB.TabIndex = 23;
            // 
            // AvgTimeOfA
            // 
            this.AvgTimeOfA.Location = new System.Drawing.Point(643, 58);
            this.AvgTimeOfA.Name = "AvgTimeOfA";
            this.AvgTimeOfA.ReadOnly = true;
            this.AvgTimeOfA.Size = new System.Drawing.Size(100, 23);
            this.AvgTimeOfA.TabIndex = 24;
            // 
            // AvgTimeOfB
            // 
            this.AvgTimeOfB.Location = new System.Drawing.Point(643, 100);
            this.AvgTimeOfB.Name = "AvgTimeOfB";
            this.AvgTimeOfB.ReadOnly = true;
            this.AvgTimeOfB.Size = new System.Drawing.Size(100, 23);
            this.AvgTimeOfB.TabIndex = 25;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(193, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(488, 154);
            this.listBox1.TabIndex = 26;
            // 
            // txtIsolationLevel
            // 
            this.txtIsolationLevel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtIsolationLevel.Location = new System.Drawing.Point(318, 9);
            this.txtIsolationLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsolationLevel.Name = "txtIsolationLevel";
            this.txtIsolationLevel.ReadOnly = true;
            this.txtIsolationLevel.Size = new System.Drawing.Size(250, 25);
            this.txtIsolationLevel.TabIndex = 27;
            this.txtIsolationLevel.Text = "Isolation Level READ UNCOMMITTED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 406);
            this.Controls.Add(this.txtIsolationLevel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.AvgTimeOfB);
            this.Controls.Add(this.AvgTimeOfA);
            this.Controls.Add(this.txtNumDeadlocksOfB);
            this.Controls.Add(this.txtNumDeadlocksOfA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTypeB);
            this.Controls.Add(this.txtBuser);
            this.Controls.Add(this.txtAuser);
            this.Controls.Add(this.lblTypeA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTypeA;
        private System.Windows.Forms.TextBox txtAuser;
        private System.Windows.Forms.TextBox txtBuser;
        private System.Windows.Forms.Label lblTypeB;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumDeadlocksOfA;
        private System.Windows.Forms.TextBox txtNumDeadlocksOfB;
        private System.Windows.Forms.TextBox AvgTimeOfA;
        private System.Windows.Forms.TextBox AvgTimeOfB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtIsolationLevel;
    }
}

