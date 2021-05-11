namespace bellugg_encrypt
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
            this.tb_privatekey = new System.Windows.Forms.TextBox();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_decode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_data_run = new System.Windows.Forms.TextBox();
            this.tb_code_run = new System.Windows.Forms.TextBox();
            this.tb_datetime = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_privatekey
            // 
            this.tb_privatekey.Location = new System.Drawing.Point(138, 56);
            this.tb_privatekey.Name = "tb_privatekey";
            this.tb_privatekey.Size = new System.Drawing.Size(237, 20);
            this.tb_privatekey.TabIndex = 0;
            this.tb_privatekey.Text = "590361612154751658";
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(138, 104);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(237, 20);
            this.tb_data.TabIndex = 1;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(138, 147);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(237, 20);
            this.tb_result.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Encrpty";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_decode
            // 
            this.tb_decode.Location = new System.Drawing.Point(475, 104);
            this.tb_decode.Name = "tb_decode";
            this.tb_decode.Size = new System.Drawing.Size(237, 20);
            this.tb_decode.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "Decode";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(138, 195);
            this.tb_code.Name = "tb_code";
            this.tb_code.Size = new System.Drawing.Size(237, 20);
            this.tb_code.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 57);
            this.button3.TabIndex = 5;
            this.button3.Text = "Check Dulicate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_data_run
            // 
            this.tb_data_run.Location = new System.Drawing.Point(138, 397);
            this.tb_data_run.Name = "tb_data_run";
            this.tb_data_run.Size = new System.Drawing.Size(237, 20);
            this.tb_data_run.TabIndex = 4;
            // 
            // tb_code_run
            // 
            this.tb_code_run.Location = new System.Drawing.Point(475, 397);
            this.tb_code_run.Name = "tb_code_run";
            this.tb_code_run.Size = new System.Drawing.Size(237, 20);
            this.tb_code_run.TabIndex = 4;
            // 
            // tb_datetime
            // 
            this.tb_datetime.Location = new System.Drawing.Point(784, 104);
            this.tb_datetime.Name = "tb_datetime";
            this.tb_datetime.Size = new System.Drawing.Size(237, 20);
            this.tb_datetime.TabIndex = 4;
            this.tb_datetime.Text = "tb_datetime";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(784, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 57);
            this.button4.TabIndex = 5;
            this.button4.Text = "Convert To DateTime";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 533);
            this.Controls.Add(this.tb_code);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_datetime);
            this.Controls.Add(this.tb_code_run);
            this.Controls.Add(this.tb_data_run);
            this.Controls.Add(this.tb_decode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_privatekey);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_privatekey;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_decode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_data_run;
        private System.Windows.Forms.TextBox tb_code_run;
        private System.Windows.Forms.TextBox tb_datetime;
        private System.Windows.Forms.Button button4;
    }
}

