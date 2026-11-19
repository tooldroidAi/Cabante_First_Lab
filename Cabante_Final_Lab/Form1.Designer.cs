namespace Cabante_Final_Lab
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Initial = new System.Windows.Forms.TextBox();
            this.textBox_AmountOfSale = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label_Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "D - Danielle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E - Edward";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "F - Fatima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Sales Person Initial: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount of Sales:";
            // 
            // textBox_Initial
            // 
            this.textBox_Initial.Location = new System.Drawing.Point(242, 116);
            this.textBox_Initial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Initial.Name = "textBox_Initial";
            this.textBox_Initial.Size = new System.Drawing.Size(150, 20);
            this.textBox_Initial.TabIndex = 5;
            // 
            // textBox_AmountOfSale
            // 
            this.textBox_AmountOfSale.Location = new System.Drawing.Point(242, 149);
            this.textBox_AmountOfSale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_AmountOfSale.Name = "textBox_AmountOfSale";
            this.textBox_AmountOfSale.Size = new System.Drawing.Size(150, 20);
            this.textBox_AmountOfSale.TabIndex = 6;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSubmit.Location = new System.Drawing.Point(103, 198);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(82, 40);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.Btn_Submit_Click_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.IndianRed;
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClear.Location = new System.Drawing.Point(204, 198);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(82, 40);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.Btn_Clear_Click_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrint.Location = new System.Drawing.Point(308, 198);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(82, 40);
            this.buttonPrint.TabIndex = 9;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.Btn_Print_Click_Click);
            // 
            // label_Output
            // 
            this.label_Output.AutoSize = true;
            this.label_Output.Location = new System.Drawing.Point(100, 276);
            this.label_Output.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(0, 13);
            this.label_Output.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 366);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBox_AmountOfSale);
            this.Controls.Add(this.textBox_Initial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "HOMESALE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Initial;
        private System.Windows.Forms.TextBox textBox_AmountOfSale;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label label_Output;
    }
}

