
namespace AlarmSystem
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
            this.components = new System.ComponentModel.Container();
            this.tbCurrentTime = new System.Windows.Forms.TextBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnUseCashbox = new System.Windows.Forms.Button();
            this.btnUseAlarm = new System.Windows.Forms.Button();
            this.btnPhone = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tbCurrentTime
            // 
            this.tbCurrentTime.Location = new System.Drawing.Point(25, 12);
            this.tbCurrentTime.Name = "tbCurrentTime";
            this.tbCurrentTime.Size = new System.Drawing.Size(562, 23);
            this.tbCurrentTime.TabIndex = 0;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(25, 52);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContent.Size = new System.Drawing.Size(562, 169);
            this.tbContent.TabIndex = 1;
            // 
            // btnUseCashbox
            // 
            this.btnUseCashbox.Location = new System.Drawing.Point(88, 275);
            this.btnUseCashbox.Name = "btnUseCashbox";
            this.btnUseCashbox.Size = new System.Drawing.Size(108, 23);
            this.btnUseCashbox.TabIndex = 2;
            this.btnUseCashbox.Text = "Use Cashbox";
            this.btnUseCashbox.UseVisualStyleBackColor = true;
            this.btnUseCashbox.Click += new System.EventHandler(this.btnUseCashbox_Click);
            // 
            // btnUseAlarm
            // 
            this.btnUseAlarm.Location = new System.Drawing.Point(219, 275);
            this.btnUseAlarm.Name = "btnUseAlarm";
            this.btnUseAlarm.Size = new System.Drawing.Size(108, 23);
            this.btnUseAlarm.TabIndex = 3;
            this.btnUseAlarm.Text = "Use Alarm";
            this.btnUseAlarm.UseVisualStyleBackColor = true;
            this.btnUseAlarm.Click += new System.EventHandler(this.btnUseAlarm_Click);
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(352, 275);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(108, 23);
            this.btnPhone.TabIndex = 4;
            this.btnPhone.Text = "Use Phone";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.btnUseAlarm);
            this.Controls.Add(this.btnUseCashbox);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.tbCurrentTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCurrentTime;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnUseCashbox;
        private System.Windows.Forms.Button btnUseAlarm;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Timer timer1;
    }
}

