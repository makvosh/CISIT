namespace cisit
{
    partial class fMain
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
            this.bcalculate = new System.Windows.Forms.Button();
            this.bAbout = new System.Windows.Forms.Button();
            this.cbDefaultParams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.rTBResult = new System.Windows.Forms.RichTextBox();
            this.ssStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bcalculate
            // 
            this.bcalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcalculate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.bcalculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.bcalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bcalculate.Font = new System.Drawing.Font("Cordia New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bcalculate.Location = new System.Drawing.Point(499, 326);
            this.bcalculate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bcalculate.Name = "bcalculate";
            this.bcalculate.Size = new System.Drawing.Size(112, 87);
            this.bcalculate.TabIndex = 0;
            this.bcalculate.Text = "Calculate";
            this.bcalculate.UseVisualStyleBackColor = true;
            this.bcalculate.Click += new System.EventHandler(this.bcalculate_Click);
            // 
            // bAbout
            // 
            this.bAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAbout.Font = new System.Drawing.Font("Cordia New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAbout.Location = new System.Drawing.Point(560, 12);
            this.bAbout.Name = "bAbout";
            this.bAbout.Size = new System.Drawing.Size(52, 38);
            this.bAbout.TabIndex = 1;
            this.bAbout.Text = "About";
            this.bAbout.UseVisualStyleBackColor = true;
            // 
            // cbDefaultParams
            // 
            this.cbDefaultParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDefaultParams.FormattingEnabled = true;
            this.cbDefaultParams.Items.AddRange(new object[] {
            "Ar-1000 [30keV]"});
            this.cbDefaultParams.Location = new System.Drawing.Point(96, 12);
            this.cbDefaultParams.Name = "cbDefaultParams";
            this.cbDefaultParams.Size = new System.Drawing.Size(244, 21);
            this.cbDefaultParams.TabIndex = 2;
            this.cbDefaultParams.SelectedIndexChanged += new System.EventHandler(this.cbDefaultParams_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cordia New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Use config:";
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.AutoSize = false;
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripStatusLabel,
            this.tsslStatus});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 419);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(624, 22);
            this.ssStatusStrip.SizingGrip = false;
            this.ssStatusStrip.TabIndex = 4;
            this.ssStatusStrip.Text = "statusStrip1";
            // 
            // tStripStatusLabel
            // 
            this.tStripStatusLabel.AutoSize = false;
            this.tStripStatusLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.tStripStatusLabel.Name = "tStripStatusLabel";
            this.tStripStatusLabel.Size = new System.Drawing.Size(17, 17);
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(48, 17);
            this.tsslStatus.Text = "Ready...";
            // 
            // rTBResult
            // 
            this.rTBResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTBResult.Font = new System.Drawing.Font("Cordia New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTBResult.Location = new System.Drawing.Point(12, 326);
            this.rTBResult.Name = "rTBResult";
            this.rTBResult.ReadOnly = true;
            this.rTBResult.Size = new System.Drawing.Size(480, 87);
            this.rTBResult.TabIndex = 5;
            this.rTBResult.Text = "Click \"Calculate\" for calculation...";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.rTBResult);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDefaultParams);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.bcalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMain";
            this.Text = "Cluster-Ion Surface Interaction Tool v0.1a";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bcalculate;
        private System.Windows.Forms.Button bAbout;
        private System.Windows.Forms.ComboBox cbDefaultParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripStatusLabel tStripStatusLabel;
        private System.Windows.Forms.RichTextBox rTBResult;
    }
}

