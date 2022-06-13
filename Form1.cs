using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plusMinus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<int> arr = new List<int>() { 1, 2, 3, -1, -2, -3, 0, 0};
            plusMinus(arr);
        }
        public static void plusMinus(List<int> arr)
        {
            double plus = 0, minus = 0, zeros = 0;

            for(int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0) zeros++;
                if (arr[i] < 0) minus++;
                if (arr[i] > 0) plus++;
            }

            Console.WriteLine(Math.Round(plus / arr.Count, 6));
            Console.WriteLine(Math.Round(minus / arr.Count, 6));
            Console.WriteLine(Math.Round(zeros / arr.Count, 6));
        }
    }
}
