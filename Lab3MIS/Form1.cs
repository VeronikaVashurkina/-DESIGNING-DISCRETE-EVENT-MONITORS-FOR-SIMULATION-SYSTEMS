using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Lab3MIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //DataGridView dataGridView1 = new DataGridView();
        private int clock = 1;
        private bool stop = false;
        Random rnd = new Random();
        Random rand = new Random();
        Random rnd1 = new Random();
        
        private int следующее_прибытие3;
        private int num3;
        private int следующее_прибытие4;
        private int num4;
        private int следующее_прибытие5;
        private int num5;
        private int следующее_прибытие6;
        private int num6;
        private int следующее_прибытие7;
        private int num7;

        public void Sobitie()
        {
            if (stop == false)
            {
                int number = rnd.Next(8);
                int number1 = rnd1.Next(4);
                switch (number1)
                {
                    case 0:
                        {
                            richTextBox1.Text = "Приехавший поезд, перегоняется на " + (number + 1) + " путь.";
                            pictureBox1.Image = Image.FromFile("C:\\Users\\Вероника\\Downloads\\421.png");
                            break;

                        }
                    case 1:
                        {
                            richTextBox1.Text = "Из поезда вышло " + number + " пассажиров";
                            pictureBox1.Image = Image.FromFile("C:\\Users\\Вероника\\Downloads\\mov.png");
                            break;

                        }

                    case 2:
                        {
                            richTextBox1.Text = "К товарному поезду прицепили еще " + (number + 1) + " вагонов";
                            pictureBox1.Image = Image.FromFile("C:\\Users\\Вероника\\Downloads\\woo.png");
                            break;

                        }

                }
            }
        }
        public void creatingEntry() {
            stop = false;
            double a =0.1 ;

            
            int T=100;

            int n = 150;


            int[] mass = new int[n];
            double y = 0;
            double xi = 0;


            bool flag = false;
        
            
            for (int j = 0; j < n; j++)
            {
                while ((flag != true) && (y <= T))
                {

                    xi = (-1.0 / a) * Math.Log(rand.NextDouble());

                    if ((y + xi) > T)
                    {
                        flag = true;
                    }

                    else
                    {
                        mass[j]++;
                        y += xi;
                    }

                    xi = 0;
                }
                flag = false;
                y = 0;
            }
            var ilist = new List<int>();
            ilist.AddRange(mass);
            ilist.Sort();

            

            
              int number=rnd.Next(8);

            int sobitie = ilist[number];

            int num = rnd.Next(10000);
            //if (clock < 5)



            if (sobitie == 3)
            {
                dataGridView1.Rows.Add(num, "Магнитогорск", "Сызрань", clock, clock + 1);
                label2.Text = Convert.ToString(clock);
                num3 = num;
                следующее_прибытие3 = Convert.ToInt32(Math.Round(1 * (2 * rand.NextDouble() - 1) + 8, 6));
                clock++;
                Sobitie();


            }
                if (sobitie == 4)
                {
                            dataGridView1.Rows.Add(num, "Самара", "Москва", clock, clock + 1);
                            label2.Text = Convert.ToString(clock);
                            num4 = num;
                            следующее_прибытие4 = Convert.ToInt32(Math.Round(1 * (2 * rand.NextDouble() - 1) + 8, 6));
                            clock++;
                    Sobitie();

                }

                if (sobitie == 5)
                {
                            dataGridView1.Rows.Add(num, "Тобольск", "Новокуйбышевск", clock, clock);
                            label2.Text = Convert.ToString(clock);
                            richTextBox1.Text = "Поезд, состоящий из " + (number + 1) + " вагонов, проехал без остановки т.к. был военный.";
                            stop = true;
                            pictureBox1.Image = Image.FromFile("C:\\Users\\Вероника\\Downloads\\war.jpg");
                            num5 = num;
                            следующее_прибытие5 = Convert.ToInt32(Math.Round(1 * (2 * rand.NextDouble() - 1) + 8, 6));
                            clock++;
                    Sobitie();

                }

                if (sobitie == 6)
                {
                            dataGridView1.Rows.Add(num, "Томск", "Калининград", clock, clock + 1);
                            label2.Text = Convert.ToString(clock);
                            num6 = num;
                            следующее_прибытие6 = Convert.ToInt32(Math.Round(1 * (2 * rand.NextDouble() - 1) + 8, 6));
                            clock++;
                    Sobitie();

                }

                if (sobitie == 7)
                {

                            label2.Text = Convert.ToString(clock);
                            richTextBox1.Text = "Ремонтные работы на вокзале, в этот час все поезда отменены";
                            stop = true;
                            pictureBox1.Image = Image.FromFile("C:\\Users\\Вероника\\Downloads\\401.png");
                            num7 = num;
                    Sobitie();
                    clock++;

                           
                        }



                
               
            
            if (clock > 0)
            {
                if ((clock - 1) == следующее_прибытие3)
                {
                    dataGridView1.Rows.Add(num3, "Магнитогорск", "Сызрань", clock - 1, clock);
                    label2.Text = Convert.ToString(clock);
                    num3 = num;
                    следующее_прибытие3 = Convert.ToInt32(Math.Round(1 * (2 * rand.NextDouble() - 1) + 8, 6));
                    Sobitie();
                }
                if ((clock - 1) == следующее_прибытие4)
                {
                    dataGridView1.Rows.Add(num4, "Самара", "Москва", clock - 1, clock);
                    label2.Text = Convert.ToString(clock);
                    num4 = num;
                    следующее_прибытие4 = Convert.ToInt32(Math.Round(1 * (2 * rand.NextDouble() - 1) + 8, 6));

                    Sobitie();
                }
                if ((clock - 1) == следующее_прибытие5)
                {
                    dataGridView1.Rows.Add(num5, "Тобольск", "Новокуйбышевск", clock - 1, clock);
                    label2.Text = Convert.ToString(clock);
                    richTextBox1.Text = "Поезд, состоящий из " + (number + 1) + " вагонов, проехал без остановки т.к. был военный.";
                    stop = true;
                    pictureBox1.Image = Image.FromFile("C:\\Users\\Вероника\\Downloads\\war.jpg");
                    num5 = num;
                    следующее_прибытие5 = Convert.ToInt32(Math.Round(1 * (2 * rand.NextDouble() - 1) + 8, 6));
                    Sobitie();

                }
                if ((clock - 1) == следующее_прибытие6)
                {
                    dataGridView1.Rows.Add(num6, "Томск", "Калининград", clock - 1, clock);
                    label2.Text = Convert.ToString(clock);
                    num6 = num;
                    следующее_прибытие6 = Convert.ToInt32(Math.Round(1 * (2 * rand.NextDouble() - 1) + 8, 6));

                    Sobitie();
                }
                clock++;

              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            for (int i = 0; i <100; i++)
            {
                
                creatingEntry();
                _pause(2000);


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void _pause(int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();
        }

    }
}
