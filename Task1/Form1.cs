using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinkedListLib;

namespace Task1
{
    public partial class Form1 : Form
    {
        private LinkedList _linkedList;

        public Form1()
        {
            InitializeComponent();
            textBox1.Validating += TextBox1_Validating;
            StartSettings();
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Ничего не введено");
            }
            else if (!double.TryParse(textBox1.Text, out double D))
            {
                errorProvider1.SetError(textBox1, "Не удалось считать число. Нужно ставить \",\"");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void StartSettings()
        {
            _linkedList = new LinkedList();
            listBox1.Items.Clear();
        }

        private void FillListBox(double[] mas)
        {
            listBox1.Items.Add($">>>{string.Join("; ", mas)}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (double.TryParse(textBox1.Text, out double Data))
            {
                _linkedList.Add(Data);
                FillListBox(_linkedList.GetElements());
            }
            else
            {
                listBox1.Items.Add($"Неверно введено значение.\nТекущий результат: {Data}");
            }
        }

        private void FillRandomNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                _linkedList.Add(random.NextDouble()*100 - 50);
            }

            FillListBox(_linkedList.GetElements());
        }

        private void CountElGreaterSeven_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(_linkedList.CountElementsGreaterThanSeven());
        }

        private void ClearItems_Click(object sender, EventArgs e)
        {
            _linkedList.Clear();
            listBox1.Items.Clear();
        }
    }
}
