namespace ToastyLights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.nud_ColorR = new System.Windows.Forms.NumericUpDown();
            this.nud_ColorG = new System.Windows.Forms.NumericUpDown();
            this.nud_ColorB = new System.Windows.Forms.NumericUpDown();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btn_ColorDialog = new System.Windows.Forms.Button();
            this.btn_TestFlow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ColorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ColorB)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Status
            // 
            this.lbl_Status.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(12, 9);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(320, 172);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "No devices found... Toasty sad :(";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(12, 225);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(111, 39);
            this.btn_Refresh.TabIndex = 1;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Enabled = false;
            this.btn_Test.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test.ForeColor = System.Drawing.Color.Black;
            this.btn_Test.Location = new System.Drawing.Point(221, 225);
            this.btn_Test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(111, 39);
            this.btn_Test.TabIndex = 2;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.Btn_Test_Click);
            // 
            // nud_ColorR
            // 
            this.nud_ColorR.Enabled = false;
            this.nud_ColorR.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nud_ColorR.Location = new System.Drawing.Point(12, 184);
            this.nud_ColorR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_ColorR.Name = "nud_ColorR";
            this.nud_ColorR.Size = new System.Drawing.Size(63, 34);
            this.nud_ColorR.TabIndex = 3;
            this.nud_ColorR.Value = new decimal(new int[] {
            145,
            0,
            0,
            0});
            // 
            // nud_ColorG
            // 
            this.nud_ColorG.Enabled = false;
            this.nud_ColorG.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nud_ColorG.Location = new System.Drawing.Point(81, 184);
            this.nud_ColorG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_ColorG.Name = "nud_ColorG";
            this.nud_ColorG.Size = new System.Drawing.Size(63, 34);
            this.nud_ColorG.TabIndex = 4;
            this.nud_ColorG.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // nud_ColorB
            // 
            this.nud_ColorB.Enabled = false;
            this.nud_ColorB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nud_ColorB.Location = new System.Drawing.Point(150, 184);
            this.nud_ColorB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_ColorB.Name = "nud_ColorB";
            this.nud_ColorB.Size = new System.Drawing.Size(63, 34);
            this.nud_ColorB.TabIndex = 5;
            this.nud_ColorB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.colorDialog.FullOpen = true;
            // 
            // btn_ColorDialog
            // 
            this.btn_ColorDialog.Enabled = false;
            this.btn_ColorDialog.Location = new System.Drawing.Point(221, 184);
            this.btn_ColorDialog.Name = "btn_ColorDialog";
            this.btn_ColorDialog.Size = new System.Drawing.Size(111, 34);
            this.btn_ColorDialog.TabIndex = 6;
            this.btn_ColorDialog.Text = "Pick";
            this.btn_ColorDialog.UseVisualStyleBackColor = true;
            this.btn_ColorDialog.Click += new System.EventHandler(this.Btn_ColorDialog_Click);
            // 
            // btn_TestFlow
            // 
            this.btn_TestFlow.Enabled = false;
            this.btn_TestFlow.Location = new System.Drawing.Point(129, 225);
            this.btn_TestFlow.Name = "btn_TestFlow";
            this.btn_TestFlow.Size = new System.Drawing.Size(86, 40);
            this.btn_TestFlow.TabIndex = 7;
            this.btn_TestFlow.Text = "Test Flow";
            this.btn_TestFlow.UseVisualStyleBackColor = true;
            this.btn_TestFlow.Click += new System.EventHandler(this.Btn_TestFlow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 277);
            this.Controls.Add(this.btn_TestFlow);
            this.Controls.Add(this.btn_ColorDialog);
            this.Controls.Add(this.nud_ColorB);
            this.Controls.Add(this.nud_ColorG);
            this.Controls.Add(this.nud_ColorR);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lbl_Status);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Toast x YEETLight";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_ColorR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ColorB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.NumericUpDown nud_ColorR;
        private System.Windows.Forms.NumericUpDown nud_ColorG;
        private System.Windows.Forms.NumericUpDown nud_ColorB;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btn_ColorDialog;
        private System.Windows.Forms.Button btn_TestFlow;
    }
}

