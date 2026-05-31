using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace DifferentialEquations
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
 
4.7. Код дизайну Form1.Designer.cs

namespace DifferentialEquations
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.TextBox textBoxSteps;

        private System.Windows.Forms.ComboBox comboBoxMethod;

        private System.Windows.Forms.Button buttonSolve;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.textBoxSteps = new System.Windows.Forms.TextBox();

            this.comboBoxMethod = new System.Windows.Forms.ComboBox();

            this.buttonSolve = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.ColumnX =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.ColumnY =
                new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridView1)).BeginInit();

            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Text = "x0";

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Text = "y0";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Text = "h";

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Text = "steps";

            // textBoxX0
            this.textBoxX0.Location =
                new System.Drawing.Point(80, 20);
            this.textBoxX0.Size =
                new System.Drawing.Size(100, 22);

            // textBoxY0
            this.textBoxY0.Location =
                new System.Drawing.Point(80, 60);
            this.textBoxY0.Size =
                new System.Drawing.Size(100, 22);

            // textBoxH
            this.textBoxH.Location =
                new System.Drawing.Point(80, 100);
            this.textBoxH.Size =
                new System.Drawing.Size(100, 22);

            // textBoxSteps
            this.textBoxSteps.Location =
                new System.Drawing.Point(80, 140);
            this.textBoxSteps.Size =
                new System.Drawing.Size(100, 22);

            // comboBoxMethod
            this.comboBoxMethod.Location =
                new System.Drawing.Point(220, 20);

            this.comboBoxMethod.Size =
                new System.Drawing.Size(150, 24);

            // buttonSolve
            this.buttonSolve.Location =
                new System.Drawing.Point(220, 70);

            this.buttonSolve.Size =
                new System.Drawing.Size(150, 40);

            this.buttonSolve.Text = "Розв'язати";

            this.buttonSolve.Click +=
                new System.EventHandler(
                    this.buttonSolve_Click);

            // dataGridView1
            this.dataGridView1.Location =
                new System.Drawing.Point(20, 200);

            this.dataGridView1.Size =
                new System.Drawing.Size(350, 250);

            this.dataGridView1.Columns.AddRange(
                new System.Windows.Forms.DataGridViewColumn[]
                {
                    this.ColumnX,
                    this.ColumnY
                });

            // ColumnX
            this.ColumnX.HeaderText = "X";
            this.ColumnX.Width = 150;

            // ColumnY
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Width = 150;

            // Form1
            this.ClientSize =
                new System.Drawing.Size(420, 480);

            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);

            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.textBoxY0);
            this.Controls.Add(this.textBoxH);
            this.Controls.Add(this.textBoxSteps);

            this.Controls.Add(this.comboBoxMethod);

            this.Controls.Add(this.buttonSolve);

            this.Controls.Add(this.dataGridView1);

            this.Text =
                "Розв'язання ОДУ";

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridView1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
