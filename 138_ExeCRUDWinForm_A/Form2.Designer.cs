﻿
using System;

namespace _138_ExeCRUDWinForm_A
{
    partial class Form2
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textAlamat = new System.Windows.Forms.TextBox();
            this.textSiswa = new System.Windows.Forms.TextBox();
            this.textNIM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tampilSiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.exe3_PABDDataSet = new _138_ExeCRUDWinForm_A.Exe3_PABDDataSet();
            this.tampilAmbilMapelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tampilAmbilMapelTableAdapter = new _138_ExeCRUDWinForm_A.Exe3_PABDDataSetTableAdapters.TampilAmbilMapelTableAdapter();
            this.tampilSiswaTableAdapter = new _138_ExeCRUDWinForm_A.Exe3_PABDDataSetTableAdapters.TampilSiswaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tampilSiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exe3_PABDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampilAmbilMapelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(471, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // textAlamat
            // 
            this.textAlamat.Location = new System.Drawing.Point(322, 142);
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Size = new System.Drawing.Size(224, 22);
            this.textAlamat.TabIndex = 15;
            // 
            // textSiswa
            // 
            this.textSiswa.Location = new System.Drawing.Point(322, 88);
            this.textSiswa.Name = "textSiswa";
            this.textSiswa.Size = new System.Drawing.Size(224, 22);
            this.textSiswa.TabIndex = 14;
            // 
            // textNIM
            // 
            this.textNIM.Location = new System.Drawing.Point(322, 41);
            this.textNIM.Name = "textNIM";
            this.textNIM.Size = new System.Drawing.Size(224, 22);
            this.textNIM.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama Siswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "NIM";
            // 
            // tampilSiswaBindingSource
            // 
            this.tampilSiswaBindingSource.DataMember = "TampilSiswa";
            this.tampilSiswaBindingSource.DataSource = this.exe3_PABDDataSet;
            // 
            // exe3_PABDDataSet
            // 
            this.exe3_PABDDataSet.DataSetName = "Exe3_PABDDataSet";
            this.exe3_PABDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tampilAmbilMapelBindingSource
            // 
            this.tampilAmbilMapelBindingSource.DataMember = "TampilAmbilMapel";
            this.tampilAmbilMapelBindingSource.DataSource = this.exe3_PABDDataSet;
            // 
            // tampilAmbilMapelTableAdapter
            // 
            this.tampilAmbilMapelTableAdapter.ClearBeforeFill = true;
            // 
            // tampilSiswaTableAdapter
            // 
            this.tampilSiswaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(357, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textAlamat);
            this.Controls.Add(this.textSiswa);
            this.Controls.Add(this.textNIM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tampilSiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exe3_PABDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tampilAmbilMapelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textAlamat;
        private System.Windows.Forms.TextBox textSiswa;
        private System.Windows.Forms.TextBox textNIM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Exe3_PABDDataSet exe3_PABDDataSet;
        private System.Windows.Forms.BindingSource tampilAmbilMapelBindingSource;
        private Exe3_PABDDataSetTableAdapters.TampilAmbilMapelTableAdapter tampilAmbilMapelTableAdapter;
        private System.Windows.Forms.BindingSource tampilSiswaBindingSource;
        private Exe3_PABDDataSetTableAdapters.TampilSiswaTableAdapter tampilSiswaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}