namespace Buoi1
{
    partial class Bai2
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lsbNumberList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteFinallyEle = new System.Windows.Forms.Button();
            this.btnIncrease2 = new System.Windows.Forms.Button();
            this.btnFirstOdd = new System.Windows.Forms.Button();
            this.btnFinallEven = new System.Windows.Forms.Button();
            this.btnDeleteSelect = new System.Windows.Forms.Button();
            this.btnDeleteFirstEle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(76, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtInput.Location = new System.Drawing.Point(181, 41);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(152, 32);
            this.txtInput.TabIndex = 1;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = true;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpdate.Location = new System.Drawing.Point(353, 39);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lsbNumberList
            // 
            this.lsbNumberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lsbNumberList.FormattingEnabled = true;
            this.lsbNumberList.ItemHeight = 26;
            this.lsbNumberList.Location = new System.Drawing.Point(96, 120);
            this.lsbNumberList.Name = "lsbNumberList";
            this.lsbNumberList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsbNumberList.Size = new System.Drawing.Size(290, 264);
            this.lsbNumberList.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnDeleteFinallyEle);
            this.groupBox1.Controls.Add(this.btnIncrease2);
            this.groupBox1.Controls.Add(this.btnFirstOdd);
            this.groupBox1.Controls.Add(this.btnFinallEven);
            this.groupBox1.Controls.Add(this.btnDeleteSelect);
            this.groupBox1.Controls.Add(this.btnDeleteFirstEle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(461, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnDeleteFinallyEle
            // 
            this.btnDeleteFinallyEle.AutoSize = true;
            this.btnDeleteFinallyEle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteFinallyEle.Location = new System.Drawing.Point(15, 233);
            this.btnDeleteFinallyEle.Name = "btnDeleteFinallyEle";
            this.btnDeleteFinallyEle.Size = new System.Drawing.Size(243, 36);
            this.btnDeleteFinallyEle.TabIndex = 10;
            this.btnDeleteFinallyEle.Text = "Xóa phần tử cuối";
            this.btnDeleteFinallyEle.UseVisualStyleBackColor = true;
            this.btnDeleteFinallyEle.Click += new System.EventHandler(this.btnFirstOdd_Click);
            // 
            // btnIncrease2
            // 
            this.btnIncrease2.AutoSize = true;
            this.btnIncrease2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIncrease2.Location = new System.Drawing.Point(15, 31);
            this.btnIncrease2.Name = "btnIncrease2";
            this.btnIncrease2.Size = new System.Drawing.Size(243, 36);
            this.btnIncrease2.TabIndex = 5;
            this.btnIncrease2.Text = "Tăng mỗi phần tử lên 2";
            this.btnIncrease2.UseVisualStyleBackColor = true;
            this.btnIncrease2.Click += new System.EventHandler(this.btnIncrease2_Click);
            // 
            // btnFirstOdd
            // 
            this.btnFirstOdd.AutoSize = true;
            this.btnFirstOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFirstOdd.Location = new System.Drawing.Point(15, 74);
            this.btnFirstOdd.Name = "btnFirstOdd";
            this.btnFirstOdd.Size = new System.Drawing.Size(243, 36);
            this.btnFirstOdd.TabIndex = 6;
            this.btnFirstOdd.Text = "Chọn số chẵn đầu tiên";
            this.btnFirstOdd.UseVisualStyleBackColor = true;
            this.btnFirstOdd.Click += new System.EventHandler(this.btnFirstOdd_Click);
            // 
            // btnFinallEven
            // 
            this.btnFinallEven.AutoSize = true;
            this.btnFinallEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFinallEven.Location = new System.Drawing.Point(15, 112);
            this.btnFinallEven.Name = "btnFinallEven";
            this.btnFinallEven.Size = new System.Drawing.Size(243, 36);
            this.btnFinallEven.TabIndex = 7;
            this.btnFinallEven.Text = "Chọn số lẻ cuối";
            this.btnFinallEven.UseVisualStyleBackColor = true;
            this.btnFinallEven.Click += new System.EventHandler(this.btnFirstOdd_Click);
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.AutoSize = true;
            this.btnDeleteSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteSelect.Location = new System.Drawing.Point(15, 153);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(246, 36);
            this.btnDeleteSelect.TabIndex = 8;
            this.btnDeleteSelect.Text = "Xóa phần tử đang chọn";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnFirstOdd_Click);
            // 
            // btnDeleteFirstEle
            // 
            this.btnDeleteFirstEle.AutoSize = true;
            this.btnDeleteFirstEle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDeleteFirstEle.Location = new System.Drawing.Point(15, 194);
            this.btnDeleteFirstEle.Name = "btnDeleteFirstEle";
            this.btnDeleteFirstEle.Size = new System.Drawing.Size(243, 36);
            this.btnDeleteFirstEle.TabIndex = 9;
            this.btnDeleteFirstEle.Text = "Xóa phần tử đầu";
            this.btnDeleteFirstEle.UseVisualStyleBackColor = true;
            this.btnDeleteFirstEle.Click += new System.EventHandler(this.btnFirstOdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnExit.Location = new System.Drawing.Point(182, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(446, 36);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 472);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lsbNumberList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListBox lsbNumberList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteFinallyEle;
        private System.Windows.Forms.Button btnIncrease2;
        private System.Windows.Forms.Button btnFirstOdd;
        private System.Windows.Forms.Button btnFinallEven;
        private System.Windows.Forms.Button btnDeleteSelect;
        private System.Windows.Forms.Button btnDeleteFirstEle;
        private System.Windows.Forms.Button btnExit;
    }
}