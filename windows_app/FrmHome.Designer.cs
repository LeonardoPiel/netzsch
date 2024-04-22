namespace netzch_test
{
    partial class FrmHome
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
            txtInput = new TextBox();
            txtOutput = new TextBox();
            lblInputField = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(146, 55);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(316, 23);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // txtOutput
            // 
            txtOutput.Enabled = false;
            txtOutput.Location = new Point(146, 114);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(316, 23);
            txtOutput.TabIndex = 1;
            // 
            // lblInputField
            // 
            lblInputField.AutoSize = true;
            lblInputField.Location = new Point(30, 58);
            lblInputField.Name = "lblInputField";
            lblInputField.Size = new Size(83, 15);
            lblInputField.TabIndex = 2;
            lblInputField.Text = "Type text here:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 117);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 3;
            label1.Text = "Output text here:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtOutput);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtInput);
            panel1.Controls.Add(lblInputField);
            panel1.Location = new Point(102, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 245);
            panel1.TabIndex = 4;
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += FrmHome_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtOutput;
        private Label lblInputField;
        private Label label1;
        private Panel panel1;
    }
}