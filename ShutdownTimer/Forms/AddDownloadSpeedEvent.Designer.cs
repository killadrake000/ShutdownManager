﻿namespace ShutdownTimer.Forms
{
    partial class AddDownloadSpeedEvent
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAdapter = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReceived = new System.Windows.Forms.TextBox();
            this.comboBoxComparator = new System.Windows.Forms.ComboBox();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "DL Speed for";
            // 
            // comboBoxAdapter
            // 
            this.comboBoxAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdapter.FormattingEnabled = true;
            this.comboBoxAdapter.Location = new System.Drawing.Point(62, 6);
            this.comboBoxAdapter.Name = "comboBoxAdapter";
            this.comboBoxAdapter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdapter.TabIndex = 22;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(12, 33);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 21;
            this.buttonOK.Text = "Add Event";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "kB/s";
            // 
            // textBoxReceived
            // 
            this.textBoxReceived.Location = new System.Drawing.Point(439, 7);
            this.textBoxReceived.Name = "textBoxReceived";
            this.textBoxReceived.Size = new System.Drawing.Size(39, 20);
            this.textBoxReceived.TabIndex = 18;
            this.textBoxReceived.Text = "10";
            // 
            // comboBoxComparator
            // 
            this.comboBoxComparator.FormattingEnabled = true;
            this.comboBoxComparator.Items.AddRange(new object[] {
            "Above",
            "Precisely",
            "Under"});
            this.comboBoxComparator.Location = new System.Drawing.Point(364, 6);
            this.comboBoxComparator.Name = "comboBoxComparator";
            this.comboBoxComparator.Size = new System.Drawing.Size(69, 21);
            this.comboBoxComparator.TabIndex = 17;
            this.comboBoxComparator.Text = "Under";
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(265, 6);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(40, 20);
            this.textBoxSeconds.TabIndex = 16;
            this.textBoxSeconds.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Adapter";
            // 
            // AddDownloadSpeedEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 67);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxAdapter);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxReceived);
            this.Controls.Add(this.comboBoxComparator);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.label1);
            this.Name = "AddDownloadSpeedEvent";
            this.Text = "Download Speed Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAdapter;
        private System.Windows.Forms.TextBox textBoxReceived;
        private System.Windows.Forms.ComboBox comboBoxComparator;
        private System.Windows.Forms.TextBox textBoxSeconds;
    }
}