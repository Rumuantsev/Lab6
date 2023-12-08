
using System.Windows.Forms;

namespace Lab6
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.RectangleCheck = new System.Windows.Forms.CheckBox();
            this.ParabolaCheck = new System.Windows.Forms.CheckBox();
            this.TrapezeCheck = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.InputFun = new System.Windows.Forms.TextBox();
            this.RectangleResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InputA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.InputB = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TrapezeResult = new System.Windows.Forms.Label();
            this.ParabolaResult = new System.Windows.Forms.Label();
            this.ParabolaTime = new System.Windows.Forms.Label();
            this.TrapezeTime = new System.Windows.Forms.Label();
            this.RectangleTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InputN = new System.Windows.Forms.TextBox();
            this.CheckE = new System.Windows.Forms.RadioButton();
            this.CheckN = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(11, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Результат:";
            // 
            // RectangleCheck
            // 
            this.RectangleCheck.AutoSize = true;
            this.RectangleCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RectangleCheck.Location = new System.Drawing.Point(159, 474);
            this.RectangleCheck.Name = "RectangleCheck";
            this.RectangleCheck.Size = new System.Drawing.Size(277, 28);
            this.RectangleCheck.TabIndex = 50;
            this.RectangleCheck.Text = "Методом прямоугольников\r\n";
            this.RectangleCheck.UseMnemonic = false;
            this.RectangleCheck.UseVisualStyleBackColor = true;
            this.RectangleCheck.CheckedChanged += new System.EventHandler(this.RectangleCheck_CheckedChanged);
            // 
            // ParabolaCheck
            // 
            this.ParabolaCheck.AutoSize = true;
            this.ParabolaCheck.Cursor = System.Windows.Forms.Cursors.Cross;
            this.ParabolaCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParabolaCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParabolaCheck.Location = new System.Drawing.Point(843, 474);
            this.ParabolaCheck.Name = "ParabolaCheck";
            this.ParabolaCheck.Size = new System.Drawing.Size(192, 28);
            this.ParabolaCheck.TabIndex = 48;
            this.ParabolaCheck.Text = "Методом парабол";
            this.ParabolaCheck.UseVisualStyleBackColor = true;
            this.ParabolaCheck.CheckedChanged += new System.EventHandler(this.ParabolaCheck_CheckedChanged);
            // 
            // TrapezeCheck
            // 
            this.TrapezeCheck.AutoSize = true;
            this.TrapezeCheck.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TrapezeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrapezeCheck.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TrapezeCheck.Location = new System.Drawing.Point(523, 474);
            this.TrapezeCheck.Name = "TrapezeCheck";
            this.TrapezeCheck.Size = new System.Drawing.Size(204, 28);
            this.TrapezeCheck.TabIndex = 46;
            this.TrapezeCheck.Text = "Методом трапеций";
            this.TrapezeCheck.UseVisualStyleBackColor = true;
            this.TrapezeCheck.CheckedChanged += new System.EventHandler(this.TrapezeCheck_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(896, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 95);
            this.button1.TabIndex = 45;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // InputFun
            // 
            this.InputFun.BackColor = System.Drawing.SystemColors.MenuText;
            this.InputFun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputFun.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputFun.Location = new System.Drawing.Point(221, 40);
            this.InputFun.Name = "InputFun";
            this.InputFun.Size = new System.Drawing.Size(380, 29);
            this.InputFun.TabIndex = 54;
            // 
            // RectangleResult
            // 
            this.RectangleResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleResult.ForeColor = System.Drawing.SystemColors.Control;
            this.RectangleResult.Location = new System.Drawing.Point(159, 516);
            this.RectangleResult.Name = "RectangleResult";
            this.RectangleResult.Size = new System.Drawing.Size(307, 27);
            this.RectangleResult.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 56;
            this.label1.Text = "Ввод данных:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(155, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 57;
            this.label3.Text = "f(x) = ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(937, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 28);
            this.label6.TabIndex = 63;
            this.label6.Text = "e = ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // InputE
            // 
            this.InputE.BackColor = System.Drawing.SystemColors.MenuText;
            this.InputE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputE.Location = new System.Drawing.Point(993, 36);
            this.InputE.Name = "InputE";
            this.InputE.Size = new System.Drawing.Size(99, 29);
            this.InputE.TabIndex = 62;
            this.InputE.Text = "0,001";
            this.InputE.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(628, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 28);
            this.label8.TabIndex = 65;
            this.label8.Text = "a = ";
            // 
            // InputA
            // 
            this.InputA.BackColor = System.Drawing.SystemColors.MenuText;
            this.InputA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputA.Location = new System.Drawing.Point(671, 40);
            this.InputA.Name = "InputA";
            this.InputA.Size = new System.Drawing.Size(74, 29);
            this.InputA.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(777, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 28);
            this.label9.TabIndex = 67;
            this.label9.Text = "b = ";
            // 
            // InputB
            // 
            this.InputB.BackColor = System.Drawing.SystemColors.MenuText;
            this.InputB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputB.Location = new System.Drawing.Point(826, 39);
            this.InputB.Name = "InputB";
            this.InputB.Size = new System.Drawing.Size(74, 29);
            this.InputB.TabIndex = 66;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(31, 88);
            this.chart1.Name = "chart1";
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkVertical;
            series1.BorderWidth = 0;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            series1.EmptyPointStyle.LabelForeColor = System.Drawing.Color.Transparent;
            series1.EmptyPointStyle.MarkerColor = System.Drawing.Color.White;
            series1.Name = "Area";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Navy;
            series2.Name = "Fun";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.EmptyPointStyle.BorderWidth = 5;
            series3.EmptyPointStyle.Color = System.Drawing.Color.Red;
            series3.Name = "IntervalA";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Name = "IntervalB";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Name = "IntervalX";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(843, 359);
            this.chart1.TabIndex = 68;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // TrapezeResult
            // 
            this.TrapezeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrapezeResult.ForeColor = System.Drawing.SystemColors.Control;
            this.TrapezeResult.Location = new System.Drawing.Point(519, 517);
            this.TrapezeResult.Name = "TrapezeResult";
            this.TrapezeResult.Size = new System.Drawing.Size(258, 27);
            this.TrapezeResult.TabIndex = 69;
            // 
            // ParabolaResult
            // 
            this.ParabolaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParabolaResult.ForeColor = System.Drawing.SystemColors.Control;
            this.ParabolaResult.Location = new System.Drawing.Point(843, 516);
            this.ParabolaResult.Name = "ParabolaResult";
            this.ParabolaResult.Size = new System.Drawing.Size(249, 27);
            this.ParabolaResult.TabIndex = 70;
            // 
            // ParabolaTime
            // 
            this.ParabolaTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParabolaTime.ForeColor = System.Drawing.SystemColors.Control;
            this.ParabolaTime.Location = new System.Drawing.Point(843, 592);
            this.ParabolaTime.Name = "ParabolaTime";
            this.ParabolaTime.Size = new System.Drawing.Size(249, 27);
            this.ParabolaTime.TabIndex = 73;
            // 
            // TrapezeTime
            // 
            this.TrapezeTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrapezeTime.ForeColor = System.Drawing.SystemColors.Control;
            this.TrapezeTime.Location = new System.Drawing.Point(519, 593);
            this.TrapezeTime.Name = "TrapezeTime";
            this.TrapezeTime.Size = new System.Drawing.Size(258, 27);
            this.TrapezeTime.TabIndex = 72;
            // 
            // RectangleTime
            // 
            this.RectangleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RectangleTime.ForeColor = System.Drawing.SystemColors.Control;
            this.RectangleTime.Location = new System.Drawing.Point(159, 592);
            this.RectangleTime.Name = "RectangleTime";
            this.RectangleTime.Size = new System.Drawing.Size(307, 27);
            this.RectangleTime.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label12.Location = new System.Drawing.Point(10, 593);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 28);
            this.label12.TabIndex = 74;
            this.label12.Text = "Разбиения:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(937, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 28);
            this.label4.TabIndex = 76;
            this.label4.Text = "n = ";
            // 
            // InputN
            // 
            this.InputN.BackColor = System.Drawing.SystemColors.MenuText;
            this.InputN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InputN.Location = new System.Drawing.Point(993, 74);
            this.InputN.Name = "InputN";
            this.InputN.Size = new System.Drawing.Size(99, 29);
            this.InputN.TabIndex = 75;
            // 
            // CheckE
            // 
            this.CheckE.AutoSize = true;
            this.CheckE.Location = new System.Drawing.Point(914, 43);
            this.CheckE.Name = "CheckE";
            this.CheckE.Size = new System.Drawing.Size(14, 13);
            this.CheckE.TabIndex = 77;
            this.CheckE.TabStop = true;
            this.CheckE.UseVisualStyleBackColor = true;
            // 
            // CheckN
            // 
            this.CheckN.AutoSize = true;
            this.CheckN.Location = new System.Drawing.Point(914, 82);
            this.CheckN.Name = "CheckN";
            this.CheckN.Size = new System.Drawing.Size(14, 13);
            this.CheckN.TabIndex = 78;
            this.CheckN.TabStop = true;
            this.CheckN.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(896, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 158);
            this.button2.TabIndex = 79;
            this.button2.Text = "Рассчитать кол-во разбиений для одинакового результата всех 3 методов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1114, 654);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CheckN);
            this.Controls.Add(this.CheckE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ParabolaTime);
            this.Controls.Add(this.TrapezeTime);
            this.Controls.Add(this.RectangleTime);
            this.Controls.Add(this.ParabolaResult);
            this.Controls.Add(this.TrapezeResult);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InputB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.InputA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InputE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RectangleResult);
            this.Controls.Add(this.InputFun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RectangleCheck);
            this.Controls.Add(this.ParabolaCheck);
            this.Controls.Add(this.TrapezeCheck);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Сортировки";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private Label label2;
        private CheckBox RectangleCheck;
        private CheckBox ParabolaCheck;
        private CheckBox TrapezeCheck;
        private Button button1;
        private ImageList imageList1;
        private TextBox InputFun;
        private Label RectangleResult;
        private Label label1;
        private Label label3;
        private Label label6;
        private TextBox InputE;
        private Label label8;
        private TextBox InputA;
        private Label label9;
        private TextBox InputB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label TrapezeResult;
        private Label ParabolaResult;
        private Label ParabolaTime;
        private Label TrapezeTime;
        private Label RectangleTime;
        private Label label12;
        private Label label4;
        private TextBox InputN;
        private RadioButton CheckE;
        private RadioButton CheckN;
        private Button button2;
    }
}

