namespace ArraySort
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
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.labelOutputTimer = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonOutput = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.radioButtonExact = new System.Windows.Forms.RadioButton();
            this.radioButtonPartial = new System.Windows.Forms.RadioButton();
            this.radioButtonStartsWith = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(11, 11);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(150, 225);
            this.listBoxNames.TabIndex = 0;
            // 
            // labelOutputTimer
            // 
            this.labelOutputTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOutputTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelOutputTimer.Location = new System.Drawing.Point(188, 151);
            this.labelOutputTimer.Name = "labelOutputTimer";
            this.labelOutputTimer.Size = new System.Drawing.Size(108, 85);
            this.labelOutputTimer.TabIndex = 1;
            this.labelOutputTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(174, 41);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(137, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(249, 12);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(62, 23);
            this.buttonOutput.TabIndex = 4;
            this.buttonOutput.Text = "Output";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.button2_Click);
            this.buttonOutput.MouseLeave += new System.EventHandler(this.buttonOutput_MouseLeave);
            this.buttonOutput.MouseHover += new System.EventHandler(this.buttonOutput_MouseHover);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(211, 67);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(62, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click_1);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.buttonSearch_MouseLeave);
            this.buttonSearch.MouseHover += new System.EventHandler(this.buttonSearch_MouseHover);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(174, 12);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(62, 23);
            this.buttonSort.TabIndex = 6;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            this.buttonSort.MouseLeave += new System.EventHandler(this.buttonSort_MouseLeave);
            this.buttonSort.MouseHover += new System.EventHandler(this.buttonSort_MouseHover);
            // 
            // radioButtonExact
            // 
            this.radioButtonExact.AutoSize = true;
            this.radioButtonExact.Location = new System.Drawing.Point(191, 91);
            this.radioButtonExact.Name = "radioButtonExact";
            this.radioButtonExact.Size = new System.Drawing.Size(89, 17);
            this.radioButtonExact.TabIndex = 7;
            this.radioButtonExact.TabStop = true;
            this.radioButtonExact.Text = "Exact Search";
            this.radioButtonExact.UseVisualStyleBackColor = true;
            this.radioButtonExact.CheckedChanged += new System.EventHandler(this.radioButtonExact_CheckedChanged);
            this.radioButtonExact.MouseLeave += new System.EventHandler(this.radioButtonExact_MouseLeave);
            this.radioButtonExact.MouseHover += new System.EventHandler(this.radioButtonExact_MouseHover);
            // 
            // radioButtonPartial
            // 
            this.radioButtonPartial.AutoSize = true;
            this.radioButtonPartial.Location = new System.Drawing.Point(191, 105);
            this.radioButtonPartial.Name = "radioButtonPartial";
            this.radioButtonPartial.Size = new System.Drawing.Size(91, 17);
            this.radioButtonPartial.TabIndex = 7;
            this.radioButtonPartial.TabStop = true;
            this.radioButtonPartial.Text = "Partial Search";
            this.radioButtonPartial.UseVisualStyleBackColor = true;
            this.radioButtonPartial.CheckedChanged += new System.EventHandler(this.radioButtonPartial_CheckedChanged);
            this.radioButtonPartial.MouseLeave += new System.EventHandler(this.radioButtonPartial_MouseLeave);
            this.radioButtonPartial.MouseHover += new System.EventHandler(this.radioButtonPartial_MouseHover);
            // 
            // radioButtonStartsWith
            // 
            this.radioButtonStartsWith.AutoSize = true;
            this.radioButtonStartsWith.Location = new System.Drawing.Point(191, 119);
            this.radioButtonStartsWith.Name = "radioButtonStartsWith";
            this.radioButtonStartsWith.Size = new System.Drawing.Size(82, 17);
            this.radioButtonStartsWith.TabIndex = 7;
            this.radioButtonStartsWith.TabStop = true;
            this.radioButtonStartsWith.Text = "Begins With";
            this.radioButtonStartsWith.UseVisualStyleBackColor = true;
            this.radioButtonStartsWith.CheckedChanged += new System.EventHandler(this.radioButtonStartsWith_CheckedChanged);
            this.radioButtonStartsWith.MouseLeave += new System.EventHandler(this.radioButtonStartsWith_MouseLeave);
            this.radioButtonStartsWith.MouseHover += new System.EventHandler(this.radioButtonStartsWith_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 252);
            this.Controls.Add(this.radioButtonStartsWith);
            this.Controls.Add(this.radioButtonPartial);
            this.Controls.Add(this.radioButtonExact);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonOutput);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelOutputTimer);
            this.Controls.Add(this.listBoxNames);
            this.Name = "Form1";
            this.Text = "NameSort";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Label labelOutputTimer;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RadioButton radioButtonExact;
        private System.Windows.Forms.RadioButton radioButtonPartial;
        private System.Windows.Forms.RadioButton radioButtonStartsWith;
    }
}

