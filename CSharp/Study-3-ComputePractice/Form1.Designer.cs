namespace MathGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.rbtnMultiplication = new System.Windows.Forms.RadioButton();
            this.rbtnTwenty = new System.Windows.Forms.RadioButton();
            this.rbtnTen = new System.Windows.Forms.RadioButton();
            this.speedBox = new System.Windows.Forms.GroupBox();
            this.btnSlow = new System.Windows.Forms.Button();
            this.btnFast = new System.Windows.Forms.Button();
            this.checkAutoSubject = new System.Windows.Forms.CheckBox();
            this.checkAutoShowAnswer = new System.Windows.Forms.CheckBox();
            this.labScore = new System.Windows.Forms.Label();
            this.labSubject = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.lab = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.timerTip = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.typeBox.SuspendLayout();
            this.speedBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.rbtnMultiplication);
            this.typeBox.Controls.Add(this.rbtnTwenty);
            this.typeBox.Controls.Add(this.rbtnTen);
            this.typeBox.Font = new System.Drawing.Font("宋体", 15F);
            this.typeBox.Location = new System.Drawing.Point(12, 35);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(250, 137);
            this.typeBox.TabIndex = 0;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "类型";
            // 
            // rbtnMultiplication
            // 
            this.rbtnMultiplication.AutoSize = true;
            this.rbtnMultiplication.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.rbtnMultiplication.Location = new System.Drawing.Point(56, 89);
            this.rbtnMultiplication.Name = "rbtnMultiplication";
            this.rbtnMultiplication.Size = new System.Drawing.Size(133, 24);
            this.rbtnMultiplication.TabIndex = 2;
            this.rbtnMultiplication.Text = "10以内乘法";
            this.rbtnMultiplication.UseVisualStyleBackColor = true;
            this.rbtnMultiplication.CheckedChanged += new System.EventHandler(this.rbtnTen_CheckedChanged);
            // 
            // rbtnTwenty
            // 
            this.rbtnTwenty.AutoSize = true;
            this.rbtnTwenty.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.rbtnTwenty.Location = new System.Drawing.Point(56, 59);
            this.rbtnTwenty.Name = "rbtnTwenty";
            this.rbtnTwenty.Size = new System.Drawing.Size(133, 24);
            this.rbtnTwenty.TabIndex = 1;
            this.rbtnTwenty.Text = "20以内加法";
            this.rbtnTwenty.UseVisualStyleBackColor = true;
            this.rbtnTwenty.CheckedChanged += new System.EventHandler(this.rbtnTen_CheckedChanged);
            // 
            // rbtnTen
            // 
            this.rbtnTen.AutoSize = true;
            this.rbtnTen.Checked = true;
            this.rbtnTen.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.rbtnTen.Location = new System.Drawing.Point(56, 29);
            this.rbtnTen.Name = "rbtnTen";
            this.rbtnTen.Size = new System.Drawing.Size(133, 24);
            this.rbtnTen.TabIndex = 0;
            this.rbtnTen.TabStop = true;
            this.rbtnTen.Text = "10以内加法";
            this.rbtnTen.UseVisualStyleBackColor = true;
            this.rbtnTen.CheckedChanged += new System.EventHandler(this.rbtnTen_CheckedChanged);
            // 
            // speedBox
            // 
            this.speedBox.Controls.Add(this.btnSlow);
            this.speedBox.Controls.Add(this.btnFast);
            this.speedBox.Font = new System.Drawing.Font("宋体", 15F);
            this.speedBox.Location = new System.Drawing.Point(12, 178);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(250, 118);
            this.speedBox.TabIndex = 1;
            this.speedBox.TabStop = false;
            this.speedBox.Text = "速度";
            // 
            // btnSlow
            // 
            this.btnSlow.Location = new System.Drawing.Point(56, 66);
            this.btnSlow.Name = "btnSlow";
            this.btnSlow.Size = new System.Drawing.Size(133, 31);
            this.btnSlow.TabIndex = 1;
            this.btnSlow.Text = "慢速";
            this.btnSlow.UseVisualStyleBackColor = true;
            this.btnSlow.Click += new System.EventHandler(this.btnSlow_Click);
            // 
            // btnFast
            // 
            this.btnFast.Location = new System.Drawing.Point(56, 29);
            this.btnFast.Name = "btnFast";
            this.btnFast.Size = new System.Drawing.Size(133, 31);
            this.btnFast.TabIndex = 0;
            this.btnFast.Text = "快速";
            this.btnFast.UseVisualStyleBackColor = true;
            this.btnFast.Click += new System.EventHandler(this.btnFast_Click);
            // 
            // checkAutoSubject
            // 
            this.checkAutoSubject.AutoSize = true;
            this.checkAutoSubject.Checked = true;
            this.checkAutoSubject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoSubject.Font = new System.Drawing.Font("宋体", 15F);
            this.checkAutoSubject.Location = new System.Drawing.Point(68, 355);
            this.checkAutoSubject.Name = "checkAutoSubject";
            this.checkAutoSubject.Size = new System.Drawing.Size(148, 24);
            this.checkAutoSubject.TabIndex = 2;
            this.checkAutoSubject.Text = "自动更新题目";
            this.checkAutoSubject.UseVisualStyleBackColor = true;
            this.checkAutoSubject.CheckedChanged += new System.EventHandler(this.checkAutoSubject_CheckedChanged);
            // 
            // checkAutoShowAnswer
            // 
            this.checkAutoShowAnswer.AutoSize = true;
            this.checkAutoShowAnswer.Checked = true;
            this.checkAutoShowAnswer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkAutoShowAnswer.Font = new System.Drawing.Font("宋体", 15F);
            this.checkAutoShowAnswer.Location = new System.Drawing.Point(68, 413);
            this.checkAutoShowAnswer.Name = "checkAutoShowAnswer";
            this.checkAutoShowAnswer.Size = new System.Drawing.Size(148, 24);
            this.checkAutoShowAnswer.TabIndex = 3;
            this.checkAutoShowAnswer.Text = "自动显示答案";
            this.checkAutoShowAnswer.UseVisualStyleBackColor = true;
            this.checkAutoShowAnswer.CheckedChanged += new System.EventHandler(this.checkAutoShowAnswer_CheckedChanged);
            // 
            // labScore
            // 
            this.labScore.AutoSize = true;
            this.labScore.Font = new System.Drawing.Font("宋体", 15F);
            this.labScore.Location = new System.Drawing.Point(310, 35);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(179, 20);
            this.labScore.TabIndex = 4;
            this.labScore.Text = "Score: 游戏未开始";
            // 
            // labSubject
            // 
            this.labSubject.AutoSize = true;
            this.labSubject.Font = new System.Drawing.Font("宋体", 60F, System.Drawing.FontStyle.Bold);
            this.labSubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labSubject.Location = new System.Drawing.Point(351, 124);
            this.labSubject.Name = "labSubject";
            this.labSubject.Size = new System.Drawing.Size(403, 80);
            this.labSubject.TabIndex = 5;
            this.labSubject.Text = "1 + 1 = ?";
            // 
            // answerBox
            // 
            this.answerBox.Font = new System.Drawing.Font("宋体", 50F);
            this.answerBox.Location = new System.Drawing.Point(658, 280);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(200, 84);
            this.answerBox.TabIndex = 6;
            this.answerBox.TextChanged += new System.EventHandler(this.answerBox_TextChanged);
            this.answerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerBox_KeyPressDown);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("宋体", 40F);
            this.lab.Location = new System.Drawing.Point(305, 295);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(347, 54);
            this.lab.TabIndex = 7;
            this.lab.Text = "Your Answer:";
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Font = new System.Drawing.Font("宋体", 11F);
            this.labelRight.Location = new System.Drawing.Point(606, 382);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(119, 15);
            this.labelRight.TabIndex = 8;
            this.labelRight.Text = "Right answer: ";
            this.labelRight.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("宋体", 12F);
            this.btnNext.Location = new System.Drawing.Point(490, 439);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(146, 42);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "游戏开始";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timerShow
            // 
            this.timerShow.Interval = 1000;
            this.timerShow.Tick += new System.EventHandler(this.backView);
            // 
            // timerTip
            // 
            this.timerTip.Interval = 5000;
            this.timerTip.Tick += new System.EventHandler(this.tipChanges);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(802, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            // 
            // timerSec
            // 
            this.timerSec.Interval = 1000;
            this.timerSec.Tick += new System.EventHandler(this.timerSec_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "From:罗庆宏";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.labSubject);
            this.Controls.Add(this.labScore);
            this.Controls.Add(this.checkAutoShowAnswer);
            this.Controls.Add(this.checkAutoSubject);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.typeBox);
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Form1";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerBox_KeyPressDown);
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.speedBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.RadioButton rbtnMultiplication;
        private System.Windows.Forms.RadioButton rbtnTwenty;
        private System.Windows.Forms.RadioButton rbtnTen;
        private System.Windows.Forms.GroupBox speedBox;
        private System.Windows.Forms.Button btnSlow;
        private System.Windows.Forms.Button btnFast;
        private System.Windows.Forms.CheckBox checkAutoSubject;
        private System.Windows.Forms.CheckBox checkAutoShowAnswer;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labSubject;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timerShow;
        private System.Windows.Forms.Timer timerTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSec;
        private System.Windows.Forms.Label label2;
    }
}

