﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_Program_LMP_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "도서 관리";

            //데이터 그리드 설정
            dataGridView1.DataSource = DataManager.Books;

            //버튼 설정
            button1.Click += (sender, e) =>
            {
                //추가 버튼
                try
                {
                    if (DataManager.Books.Exists((x) => x.Isbn == textBox1.Text))
                    {
                        MessageBox.Show("이미 존재하는 도서입니다.");
                    }
                    else
                    {
                        Book book = new Book()
                        {
                            Isbn = textBox1.Text,
                            Name = textBox2.Text,
                            Publisher = textBox3.Text,
                            Page = int.Parse(textBox4.Text)
                        };
                        DataManager.Books.Add(book);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();
                    }
                }
                catch (Exception exception)
                {
                }
            };

            button2.Click += (sender, e) =>
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    book.Name = textBox2.Text;
                    book.Publisher = textBox3.Text;
                    book.Page = int.Parse(textBox4.Text);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Books;
                    DataManager.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서입니다.");
                }
            };

            button3.Click += (sender, e) =>
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    DataManager.Books.Remove(book);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Books;
                    DataManager.Save();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서입니다.");
                }
            };
        }private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.Isbn;
                textBox2.Text = book.Name;
                textBox3.Text = book.Publisher;
                textBox4.Text = book.Page.ToString();
            }
            catch (Exception exception)
            {

            }
        }
        

    }
}
