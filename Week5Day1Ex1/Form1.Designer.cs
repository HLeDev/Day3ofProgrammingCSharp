
namespace Week5Day1Ex1
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.stuGrid = new System.Windows.Forms.DataGridView();
            this.grpStu = new System.Windows.Forms.GroupBox();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stuGrid)).BeginInit();
            this.grpStu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeader.Font = new System.Drawing.Font("Ravie", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(262, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(706, 47);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Student Management System";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDisplay.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.Green;
            this.btnDisplay.Location = new System.Drawing.Point(12, 119);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(276, 55);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Student Information";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Ravie", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(779, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(276, 55);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New Student";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDel.Font = new System.Drawing.Font("Ravie", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDel.Location = new System.Drawing.Point(12, 461);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(276, 55);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete Student Information";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // stuGrid
            // 
            this.stuGrid.BackgroundColor = System.Drawing.Color.MistyRose;
            this.stuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stuGrid.Location = new System.Drawing.Point(12, 180);
            this.stuGrid.Name = "stuGrid";
            this.stuGrid.Size = new System.Drawing.Size(643, 275);
            this.stuGrid.TabIndex = 4;
            // 
            // grpStu
            // 
            this.grpStu.BackColor = System.Drawing.Color.MediumPurple;
            this.grpStu.Controls.Add(this.comboGrade);
            this.grpStu.Controls.Add(this.comboMonth);
            this.grpStu.Controls.Add(this.txtAddress);
            this.grpStu.Controls.Add(this.txtLName);
            this.grpStu.Controls.Add(this.txtFName);
            this.grpStu.Controls.Add(this.txtID);
            this.grpStu.Controls.Add(this.lblGrades);
            this.grpStu.Controls.Add(this.lblMonth);
            this.grpStu.Controls.Add(this.lblAddress);
            this.grpStu.Controls.Add(this.lblLName);
            this.grpStu.Controls.Add(this.lblFName);
            this.grpStu.Controls.Add(this.lblID);
            this.grpStu.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStu.Location = new System.Drawing.Point(779, 180);
            this.grpStu.Name = "grpStu";
            this.grpStu.Size = new System.Drawing.Size(492, 275);
            this.grpStu.TabIndex = 5;
            this.grpStu.TabStop = false;
            this.grpStu.Text = "Student Information";
            // 
            // comboGrade
            // 
            this.comboGrade.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Location = new System.Drawing.Point(241, 218);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(245, 26);
            this.comboGrade.TabIndex = 11;
            // 
            // comboMonth
            // 
            this.comboMonth.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Location = new System.Drawing.Point(241, 186);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(245, 26);
            this.comboMonth.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(241, 151);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 29);
            this.txtAddress.TabIndex = 9;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(241, 116);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(245, 29);
            this.txtLName.TabIndex = 8;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(241, 80);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(245, 29);
            this.txtFName.TabIndex = 7;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(241, 45);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(245, 29);
            this.txtID.TabIndex = 6;
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrades.ForeColor = System.Drawing.Color.Lime;
            this.lblGrades.Location = new System.Drawing.Point(6, 228);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(136, 16);
            this.lblGrades.TabIndex = 5;
            this.lblGrades.Text = "Student Grade";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.ForeColor = System.Drawing.Color.Lime;
            this.lblMonth.Location = new System.Drawing.Point(6, 196);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(223, 16);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Student Admission Month";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Lime;
            this.lblAddress.Location = new System.Drawing.Point(6, 164);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(153, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Student Address";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.ForeColor = System.Drawing.Color.Lime;
            this.lblLName.Location = new System.Drawing.Point(6, 129);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(171, 16);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Student Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.Lime;
            this.lblFName.Location = new System.Drawing.Point(6, 93);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(176, 16);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "Student First Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Algerian", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Lime;
            this.lblID.Location = new System.Drawing.Point(6, 58);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(93, 16);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "StudentID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1272, 666);
            this.Controls.Add(this.grpStu);
            this.Controls.Add(this.stuGrid);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuGrid)).EndInit();
            this.grpStu.ResumeLayout(false);
            this.grpStu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView stuGrid;
        private System.Windows.Forms.GroupBox grpStu;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblID;
    }
}

