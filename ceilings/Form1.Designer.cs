﻿namespace ceilings
{
    partial class Ceil_Calc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSquareCount = new System.Windows.Forms.TabPage();
            this.btnCount = new System.Windows.Forms.Button();
            this.tbSquare = new System.Windows.Forms.TextBox();
            this.tbPerimeter = new System.Windows.Forms.TextBox();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_S = new System.Windows.Forms.TextBox();
            this.tpProductFinder = new System.Windows.Forms.TabPage();
            this.radioButtonSize600 = new System.Windows.Forms.RadioButton();
            this.radioButton1200 = new System.Windows.Forms.RadioButton();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpSquareCount.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(108, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSquareCount);
            this.tabControl1.Controls.Add(this.tpProductFinder);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 400);
            this.tabControl1.TabIndex = 1;
            // 
            // tpSquareCount
            // 
            this.tpSquareCount.Controls.Add(this.tbSize);
            this.tpSquareCount.Controls.Add(this.radioButton1200);
            this.tpSquareCount.Controls.Add(this.radioButtonSize600);
            this.tpSquareCount.Controls.Add(this.btnCount);
            this.tpSquareCount.Controls.Add(this.tbSquare);
            this.tpSquareCount.Controls.Add(this.tbPerimeter);
            this.tpSquareCount.Controls.Add(this.textBox_P);
            this.tpSquareCount.Controls.Add(this.textBox_S);
            this.tpSquareCount.Location = new System.Drawing.Point(4, 22);
            this.tpSquareCount.Name = "tpSquareCount";
            this.tpSquareCount.Padding = new System.Windows.Forms.Padding(3);
            this.tpSquareCount.Size = new System.Drawing.Size(692, 374);
            this.tpSquareCount.TabIndex = 0;
            this.tpSquareCount.Text = "Расчет по площади";
            this.tpSquareCount.UseVisualStyleBackColor = true;
            this.tpSquareCount.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(560, 52);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 36);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Рассчитать";
            this.btnCount.UseVisualStyleBackColor = true;
            // 
            // tbSquare
            // 
            this.tbSquare.Location = new System.Drawing.Point(163, 56);
            this.tbSquare.Multiline = true;
            this.tbSquare.Name = "tbSquare";
            this.tbSquare.Size = new System.Drawing.Size(100, 27);
            this.tbSquare.TabIndex = 4;
            this.tbSquare.Text = "0";
            this.tbSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPerimeter
            // 
            this.tbPerimeter.Location = new System.Drawing.Point(443, 52);
            this.tbPerimeter.Multiline = true;
            this.tbPerimeter.Name = "tbPerimeter";
            this.tbPerimeter.Size = new System.Drawing.Size(87, 27);
            this.tbPerimeter.TabIndex = 3;
            this.tbPerimeter.Text = "0";
            this.tbPerimeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_P
            // 
            this.textBox_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_P.Location = new System.Drawing.Point(294, 52);
            this.textBox_P.Multiline = true;
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.ReadOnly = true;
            this.textBox_P.Size = new System.Drawing.Size(106, 38);
            this.textBox_P.TabIndex = 1;
            this.textBox_P.Text = "Введите периметр";
            this.textBox_P.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_S
            // 
            this.textBox_S.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_S.Location = new System.Drawing.Point(24, 54);
            this.textBox_S.Multiline = true;
            this.textBox_S.Name = "textBox_S";
            this.textBox_S.ReadOnly = true;
            this.textBox_S.Size = new System.Drawing.Size(106, 38);
            this.textBox_S.TabIndex = 0;
            this.textBox_S.Text = "Введите площадь";
            this.textBox_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpProductFinder
            // 
            this.tpProductFinder.Location = new System.Drawing.Point(4, 22);
            this.tpProductFinder.Name = "tpProductFinder";
            this.tpProductFinder.Padding = new System.Windows.Forms.Padding(3);
            this.tpProductFinder.Size = new System.Drawing.Size(848, 444);
            this.tpProductFinder.TabIndex = 1;
            this.tpProductFinder.Text = "Подбор продукта";
            this.tpProductFinder.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize600
            // 
            this.radioButtonSize600.AutoSize = true;
            this.radioButtonSize600.Location = new System.Drawing.Point(188, 17);
            this.radioButtonSize600.Name = "radioButtonSize600";
            this.radioButtonSize600.Size = new System.Drawing.Size(65, 17);
            this.radioButtonSize600.TabIndex = 6;
            this.radioButtonSize600.TabStop = true;
            this.radioButtonSize600.Text = "600*600";
            this.radioButtonSize600.UseVisualStyleBackColor = true;
            // 
            // radioButton1200
            // 
            this.radioButton1200.AutoSize = true;
            this.radioButton1200.Location = new System.Drawing.Point(371, 17);
            this.radioButton1200.Name = "radioButton1200";
            this.radioButton1200.Size = new System.Drawing.Size(71, 17);
            this.radioButton1200.TabIndex = 7;
            this.radioButton1200.TabStop = true;
            this.radioButton1200.Text = "1200*600";
            this.radioButton1200.UseVisualStyleBackColor = true;
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(24, 17);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(146, 20);
            this.tbSize.TabIndex = 8;
            this.tbSize.Text = "Размер плиты";
            // 
            // Ceil_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 424);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Ceil_Calc";
            this.Text = "Калькулятор потолка ver 0.1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpSquareCount.ResumeLayout(false);
            this.tpSquareCount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSquareCount;
        private System.Windows.Forms.TabPage tpProductFinder;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_S;
        private System.Windows.Forms.TextBox tbSquare;
        private System.Windows.Forms.TextBox tbPerimeter;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.RadioButton radioButton1200;
        private System.Windows.Forms.RadioButton radioButtonSize600;
    }
}

