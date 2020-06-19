using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Line
        {
            private string textLine;
            public void textFill(string text)
            {
                if (text.Length > 10) textLine = "Слишком длинная строка";
                else textLine = text;
            }
            public void textFill()
            {
                textLine = "Пусто";
            }
        }
    }
}
