﻿namespace cisit
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
            this.components = new System.ComponentModel.Container();
            this.bcalculate = new System.Windows.Forms.Button();
            this.bAbout = new System.Windows.Forms.Button();
            this.cbDefaultParams = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.rTBResult = new System.Windows.Forms.RichTextBox();
            this.nUDPercentTransferedEnergy = new System.Windows.Forms.NumericUpDown();
            this.lTransferedEnergy = new System.Windows.Forms.Label();
            this.timerSetReady = new System.Windows.Forms.Timer(this.components);
            this.tB_lambda = new System.Windows.Forms.TextBox();
            this.tB_m = new System.Windows.Forms.TextBox();
            this.tB_q = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ssStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPercentTransferedEnergy)).BeginInit();
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
            this.bAbout.Click += new System.EventHandler(this.bAbout_Click);
            // 
            // cbDefaultParams
            // 
            this.cbDefaultParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDefaultParams.FormattingEnabled = true;
            this.cbDefaultParams.Items.AddRange(new object[] {
            "Ar-1000 [30keV]"});
            this.cbDefaultParams.Location = new System.Drawing.Point(96, 12);
            this.cbDefaultParams.Name = "cbDefaultParams";
            this.cbDefaultParams.Size = new System.Drawing.Size(138, 21);
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
            this.tStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tStripStatusLabel.Name = "tStripStatusLabel";
            this.tStripStatusLabel.Size = new System.Drawing.Size(17, 17);
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(39, 17);
            this.tsslStatus.Text = "Ready";
            // 
            // rTBResult
            // 
            this.rTBResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTBResult.Font = new System.Drawing.Font("Cordia New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rTBResult.Location = new System.Drawing.Point(12, 159);
            this.rTBResult.Name = "rTBResult";
            this.rTBResult.ReadOnly = true;
            this.rTBResult.Size = new System.Drawing.Size(480, 254);
            this.rTBResult.TabIndex = 5;
            this.rTBResult.Text = "Click \"Calculate\" for calculation...";
            // 
            // nUDPercentTransferedEnergy
            // 
            this.nUDPercentTransferedEnergy.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUDPercentTransferedEnergy.Location = new System.Drawing.Point(15, 49);
            this.nUDPercentTransferedEnergy.Name = "nUDPercentTransferedEnergy";
            this.nUDPercentTransferedEnergy.Size = new System.Drawing.Size(49, 23);
            this.nUDPercentTransferedEnergy.TabIndex = 7;
            this.nUDPercentTransferedEnergy.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lTransferedEnergy
            // 
            this.lTransferedEnergy.AutoSize = true;
            this.lTransferedEnergy.Font = new System.Drawing.Font("Cordia New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTransferedEnergy.Location = new System.Drawing.Point(70, 51);
            this.lTransferedEnergy.Name = "lTransferedEnergy";
            this.lTransferedEnergy.Size = new System.Drawing.Size(164, 18);
            this.lTransferedEnergy.TabIndex = 8;
            this.lTransferedEnergy.Text = "% of transfered energy";
            // 
            // timerSetReady
            // 
            this.timerSetReady.Interval = 3000;
            this.timerSetReady.Tick += new System.EventHandler(this.timerSetReady_Tick);
            // 
            // tB_lambda
            // 
            this.tB_lambda.Cursor = System.Windows.Forms.Cursors.Default;
            this.tB_lambda.Font = new System.Drawing.Font("David", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_lambda.Location = new System.Drawing.Point(50, 78);
            this.tB_lambda.Name = "tB_lambda";
            this.tB_lambda.Size = new System.Drawing.Size(40, 21);
            this.tB_lambda.TabIndex = 9;
            this.tB_lambda.Text = "2,54";
            // 
            // tB_m
            // 
            this.tB_m.Cursor = System.Windows.Forms.Cursors.Default;
            this.tB_m.Font = new System.Drawing.Font("David", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_m.Location = new System.Drawing.Point(50, 105);
            this.tB_m.Name = "tB_m";
            this.tB_m.Size = new System.Drawing.Size(40, 21);
            this.tB_m.TabIndex = 10;
            this.tB_m.Text = "0,25";
            // 
            // tB_q
            // 
            this.tB_q.Cursor = System.Windows.Forms.Cursors.Default;
            this.tB_q.Font = new System.Drawing.Font("David", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_q.Location = new System.Drawing.Point(50, 132);
            this.tB_q.Name = "tB_q";
            this.tB_q.Size = new System.Drawing.Size(40, 21);
            this.tB_q.TabIndex = 11;
            this.tB_q.Text = "0,475";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cordia New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "λ =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cordia New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "m =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cordia New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "q =";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_q);
            this.Controls.Add(this.tB_m);
            this.Controls.Add(this.tB_lambda);
            this.Controls.Add(this.lTransferedEnergy);
            this.Controls.Add(this.nUDPercentTransferedEnergy);
            this.Controls.Add(this.rTBResult);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDefaultParams);
            this.Controls.Add(this.bAbout);
            this.Controls.Add(this.bcalculate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMain";
            this.Text = "Cluster-Ion Surface Interaction Tool v0.1a";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPercentTransferedEnergy)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nUDPercentTransferedEnergy;
        private System.Windows.Forms.Label lTransferedEnergy;
        private System.Windows.Forms.Timer timerSetReady;
        private System.Windows.Forms.TextBox tB_lambda;
        private System.Windows.Forms.TextBox tB_m;
        private System.Windows.Forms.TextBox tB_q;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

