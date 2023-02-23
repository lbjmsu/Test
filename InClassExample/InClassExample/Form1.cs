using InClassExample.BooksDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookTableTableAdapter.Fill(booksDataSet.BookTable);
            this.moreDataTableAdapter.Fill(this.booksDataSet.MoreData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookTableTableAdapter.FillByCopyrightDate(booksDataSet.BookTable, searchTextBox.Text);
            searchTextBox.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moreDataTableAdapter.Fill(booksDataSet.MoreData);
        }
    }
}
