using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //「表示」ボタンを押すことでForm2が起動
        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string str;
            str = "";
            if (e.ColumnIndex == this.dataGridView1.Columns["title1"].Index)
            {
                if (string.IsNullOrEmpty(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value)))
                {
                    str = DateTime.Now.Ticks.ToString();
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = str;

                    if (!File.Exists(str + ".csv"))
                    {
                        StreamWriter sw = new StreamWriter(str + ".csv");
                        sw.Close();
                    }
                   // else
                    //{
                     //   File.Open(@"C:\intern\" + str + ".csv", FileMode.Open);
                       // this.Close();
                   // }
                }
                /*else
                {
                    str = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    File.Open(@"C:\intern\" + str + ".csv", FileMode.Open);
                    this.Close();

                }
               // str = (string)dataGridView1[5, 2].Value; */
                Form2 f = new Form2();
                f.Show();
                str = (string)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
                f.ID = str;
            }

        }



        //フォーム起動と同時にインターン一覧のCSVファイルを表示
        private void Form1_Shown(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"intern_man.csv", Encoding.GetEncoding("UTF-8"));

            int row = 0;
            while (true)
            {

                string text = sr.ReadLine();
                if (string.IsNullOrEmpty(text))
                {
                    break;
                }
                string[] data = text.Split(',');
                dataGridView1.Rows.Add();
                dataGridView1[1, row].Value = data[0];
                dataGridView1[2, row].Value = data[1];
                dataGridView1[3, row].Value = data[2];
                dataGridView1[4, row].Value = data[3];
                dataGridView1[5, row].Value = data[4];
                row++;
            }
            sr.Close();

        }




        //「保存」ボタンを押すことでCSVファイルが更新される
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"intern_man.csv", false, Encoding.UTF8);

            for (int i = 0; i < dataGridView1.RowCount -1; i++)
            {
                //列数だけループを回す
                for (int j = 1; j < dataGridView1.ColumnCount; j++)
                {
                    if (j == 5)
                    {
                        //エクセルで表示させるために、,　で分割する
                        file.Write(dataGridView1[j, i].Value + "\r\n");
                    }
                    else
                    {
                        file.Write(dataGridView1[j, i].Value + ",");
                    }


                }

            }

            //書き込みを終了する
            file.Close();

            MessageBox.Show("書き込み完了");
        }
    }
}
