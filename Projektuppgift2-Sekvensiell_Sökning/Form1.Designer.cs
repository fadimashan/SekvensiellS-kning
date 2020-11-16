namespace Projektuppgift2_Sekvensiell_Sökning
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
            this.txResultet = new System.Windows.Forms.TextBox();
            this.btnSekventiell = new System.Windows.Forms.Button();
            this.btnBlanda = new System.Windows.Forms.Button();
            this.tbxSöktValör = new System.Windows.Forms.TextBox();
            this.tbxIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txResultet
            // 
            this.txResultet.Enabled = false;
            this.txResultet.Location = new System.Drawing.Point(701, 12);
            this.txResultet.Multiline = true;
            this.txResultet.Name = "txResultet";
            this.txResultet.Size = new System.Drawing.Size(100, 178);
            this.txResultet.TabIndex = 0;
            this.txResultet.TextChanged += new System.EventHandler(this.txResultet_TextChanged);
            // 
            // btnSekventiell
            // 
            this.btnSekventiell.Location = new System.Drawing.Point(56, 532);
            this.btnSekventiell.Name = "btnSekventiell";
            this.btnSekventiell.Size = new System.Drawing.Size(151, 23);
            this.btnSekventiell.TabIndex = 1;
            this.btnSekventiell.Text = "Sekventiell sökning";
            this.btnSekventiell.UseVisualStyleBackColor = true;
            this.btnSekventiell.Click += new System.EventHandler(this.btnSekventiell_Click);
            // 
            // btnBlanda
            // 
            this.btnBlanda.Location = new System.Drawing.Point(260, 532);
            this.btnBlanda.Name = "btnBlanda";
            this.btnBlanda.Size = new System.Drawing.Size(75, 23);
            this.btnBlanda.TabIndex = 2;
            this.btnBlanda.Text = "Blanda";
            this.btnBlanda.UseVisualStyleBackColor = true;
            this.btnBlanda.Click += new System.EventHandler(this.btnBlanda_Click);
            // 
            // tbxSöktValör
            // 
            this.tbxSöktValör.Location = new System.Drawing.Point(154, 90);
            this.tbxSöktValör.Name = "tbxSöktValör";
            this.tbxSöktValör.Size = new System.Drawing.Size(100, 20);
            this.tbxSöktValör.TabIndex = 3;
            this.tbxSöktValör.TextChanged += new System.EventHandler(this.tbxSöktValör_TextChanged);
            // 
            // tbxIndex
            // 
            this.tbxIndex.Enabled = false;
            this.tbxIndex.Location = new System.Drawing.Point(154, 125);
            this.tbxIndex.Name = "tbxIndex";
            this.tbxIndex.Size = new System.Drawing.Size(100, 20);
            this.tbxIndex.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Index:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sökt valör:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(52, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(506, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kortens valörer är 2 till 10 Sök efter ett Kort och se dess index";
            // 
            // labNote
            // 
            this.labNote.AutoSize = true;
            this.labNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNote.ForeColor = System.Drawing.Color.Brown;
            this.labNote.Location = new System.Drawing.Point(272, 71);
            this.labNote.Name = "labNote";
            this.labNote.Size = new System.Drawing.Size(235, 17);
            this.labNote.TabIndex = 8;
            this.labNote.Text = "Måste ange ett nummer mellan 2-10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1598, 691);
            this.Controls.Add(this.labNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIndex);
            this.Controls.Add(this.tbxSöktValör);
            this.Controls.Add(this.btnBlanda);
            this.Controls.Add(this.btnSekventiell);
            this.Controls.Add(this.txResultet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txResultet;
        private System.Windows.Forms.Button btnSekventiell;
        private System.Windows.Forms.Button btnBlanda;
        private System.Windows.Forms.TextBox tbxSöktValör;
        private System.Windows.Forms.TextBox tbxIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labNote;
    }
}

