using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DifferentialEquations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxMethod.Items.Add("Euler");
            comboBoxMethod.Items.Add("Runge-Kutta");

            comboBoxMethod.SelectedIndex = 0;
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = Convert.ToDouble(textBoxX0.Text);
                double y0 = Convert.ToDouble(textBoxY0.Text);
                double h = Convert.ToDouble(textBoxH.Text);
                int steps = Convert.ToInt32(textBoxSteps.Text);

                // y' = x + y
                Func<double, double, double> f =
                    (x, y) => x + y;

                IOdeSolver solver;

                if (comboBoxMethod.SelectedItem.ToString() == "Euler")
                {
                    solver = new EulerSolver();
                }
                else
                {
                    solver = new RungeKuttaSolver();
                }

                List<PointD> result =
                    solver.Solve(f, x0, y0, h, steps);

                dataGridView1.Rows.Clear();

                foreach (PointD p in result)
                {
                    dataGridView1.Rows.Add(
                        p.X.ToString("F3"),
                        p.Y.ToString("F6"));
                }
            }
            catch
            {
                MessageBox.Show(
                    "Помилка введення даних!");
            }
        }
    }
}


