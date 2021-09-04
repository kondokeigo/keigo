//大阪学院大学の近藤経伍です。
//大阪の企業のインターンシップに参加した時の最終成果物です。
//visual studioとc#を使用してインターン管理システムを作りました。
//詳細としては、ある年のインターンシップに参加した方達の情報が一覧にでて情報の管理がしやすいようになっております。

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

namespace WindowsFormsApp14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string ID { get; internal set; }
        
        
        
        //ボタンを押したらCSVファイルに書き込まれる
        private void button2_Click(object sender, EventArgs e)
        {
            {
                StreamWriter file = new StreamWriter(ID +".csv", false, Encoding.GetEncoding("UTF-8"));

                for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                {
                    //列数だけループを回す
                    for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    {
                        if(j == 8)
                        {
                            //エクセルで表示させるために、,　で分割する
                            file.Write(dataGridView2[j, i].Value + "\r\n");
                        }
                        else
                        {
                            //エクセルで表示させるために、,　で分割する
                            file.Write(dataGridView2[j, i].Value + ",");
                        }

                    }
                   
                }

                //書き込みを終了する
                file.Close();

                MessageBox.Show("書き込み完了");


            }
        }

        //Form2が開かれるとCSVファイルを呼び出して表示する
        public void Form2_Shown(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(ID + ".csv", Encoding.GetEncoding("UTF-8"));
          
            int row = 0;
            while (true)
            {

                string text2 = sr.ReadLine();
                if (string.IsNullOrEmpty(text2))
                {
                    break;
                }
                string[] data2 = text2.Split(',');
                dataGridView2.Rows.Add();
                dataGridView2[0, row].Value = data2[0];
                dataGridView2[1, row].Value = data2[1];
                dataGridView2[2, row].Value = data2[2];
                dataGridView2[3, row].Value = data2[3];
                dataGridView2[4, row].Value = data2[4];
                dataGridView2[5, row].Value = data2[5];
                dataGridView2[6, row].Value = data2[6];
                dataGridView2[7, row].Value = data2[7];
                dataGridView2[8, row].Value = data2[8];
                row++;
            }
            sr.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
