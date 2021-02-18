using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        
        private String veri,veri1,veri2;
        
        private int secim1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(new ThreadStart(serialPort1_DataReceived));
            //thread.Start();
            serialPort1.Open();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Thread thread = new Thread(new ThreadStart(work1));
            //thread.Start();

            //void work1()
            //{
            veri = serialPort1.ReadLine();
            veri1 = veri.Split('=').First();
            veri2 = veri.Split('=').Last();
            secim1 = int.Parse(veri2);

            Console.WriteLine(veri);

            Console.WriteLine(veri1);
            Console.WriteLine(veri2);

            if (veri1 == "$0")
            {
                if (secim1 == 1)
                {
                    Console.WriteLine("asdadsada");
                    label1.BackColor = Color.Lime;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;

                }
                else if (secim1 == 2)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Lime;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 3)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Lime;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 4)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Lime;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 5)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Lime;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 6)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Lime;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 7)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Lime;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 8)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Lime;
                }


            

        }

                if (veri1 == "$1")
                {
                    Console.WriteLine("sadsada");
                    if (label28.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                        label28.Invoke(new Action(delegate ()
                        {
                            //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                            label28.Text = veri2;
                        }));


                }
                if (veri1 == "$2")
                {
                    Console.WriteLine(veri2);
                    if(label34.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                        label34.Invoke(new Action(delegate ()
                        {
                            //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                            label34.Text = veri2;
                        }));
                }
                if (veri1 == "$3")
                {
                    Console.WriteLine(veri2);
                    if(label35.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                        label35.Invoke(new Action(delegate ()
                        {
                            //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                            label35.Text = veri2;
                        }));
                }
                if (veri1 == "$4")
                {
                    Console.WriteLine(veri2);
                    if (label36.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                        label36.Invoke(new Action(delegate ()
                        {
                            //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                            label36.Text = veri2;
                        }));
                }
                if (veri1 == "$5")
                {
                    Console.WriteLine(veri2);
                    if (label37.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                        label37.Invoke(new Action(delegate ()
                        {
                            //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                            label37.Text = veri2;
                        }));
                }
                if (veri1 == "$6")
                {
                    Console.WriteLine(veri2);
                    if (label38.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                        label38.Invoke(new Action(delegate ()
                        {
                            //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                            label38.Text = veri2;
                        }));
                }
            if (veri1 == "$7")
            {
                Console.WriteLine(veri2);
                if (label39.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label39.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label39.Text = veri2;
                    }));
            }
            if (veri1 == "$8")
            {
                Console.WriteLine(veri2);
                if (label40.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label40.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label40.Text = veri2;
                    }));
            }
            if (veri1 == "$9")
            {
                Console.WriteLine(veri2);
                if (label41.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label41.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label41.Text = veri2;
                    }));
            }
            if (veri1 == "$10")
            {
                Console.WriteLine(veri2);
                if (label42.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label42.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label42.Text = veri2;
                    }));
            }
            if (veri1 == "$11")
            {
                Console.WriteLine(veri2);
                if (label43.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label43.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label43.Text = veri2;
                    }));
            }
            if (veri1 == "$12")
            {
                Console.WriteLine(veri2);
                if (label44.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label44.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label44.Text = veri2;
                    }));
            }
            if (veri1 == "$13")
            {
                Console.WriteLine(veri2);
                if (label45.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label45.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label45.Text = veri2;
                    }));
            }
            if (veri1 == "$14")
            {
                Console.WriteLine(veri2);
                if (label46.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label46.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label46.Text = veri2;
                    }));
            }
            if (veri1 == "$15")
            {
                Console.WriteLine(veri2);
                if (label47.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label47.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label47.Text = veri2;
                    }));
            }
            if (veri1 == "$16")
            {
                Console.WriteLine(veri2);
                if (label48.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label48.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label48.Text = veri2;
                    }));

            }
            if (veri1 == "$17")
            {
                Console.WriteLine(veri2);
                if (label49.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label49.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label49.Text = veri2;
                    }));

            }
            if (veri1 == "$18")
            {

                Console.WriteLine(veri2);
                if (label50.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label50.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label50.Text = veri2;
                    }));
            }




            //}
            /*veri = serialPort1.ReadLine();

            Console.WriteLine(veri);
            veri1 = (veri.Substring(0, 2));
            Console.WriteLine(veri1);
            veri2 = veri.Substring(2, veri.Length - 2);
            Console.WriteLine(veri2);
            veri3 = veri2.Substring(1, veri.Length - 3);
            Console.WriteLine(veri3);

            secim1 = int.Parse(veri3);

            if (veri1 == "$0")
            {
                if (secim1 == 1)
                {
                    label1.BackColor = Color.Lime;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;

                }
                else if (secim1 == 2)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Lime;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 3)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Lime;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 4)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Lime;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 5)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Lime;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 6)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Lime;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 7)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Lime;
                    label8.BackColor = Color.Transparent;
                }
                else if (secim1 == 8)
                {
                    label1.BackColor = Color.Transparent;
                    label2.BackColor = Color.Transparent;
                    label3.BackColor = Color.Transparent;
                    label4.BackColor = Color.Transparent;
                    label5.BackColor = Color.Transparent;
                    label6.BackColor = Color.Transparent;
                    label7.BackColor = Color.Transparent;
                    label8.BackColor = Color.Lime;
                }


            }





            Console.WriteLine(veri.Substring(veri.IndexOf('=') + 1, 1));









        
            
            if (veri1 == "$1")
            {


                if (label1.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label1.Invoke(new Action(delegate ()
                    {
                    //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                    label9.Text = veri3 ;
                    }));

            }
            if (veri1 == "$2")
            {


                if (label1.InvokeRequired)//Label'a gelen talebin farklı bir iş parçacığından gelip gelmediği kontrol ediliyor.
                    label1.Invoke(new Action(delegate ()
                    {
                        //Eğer Label'a başka bir iş parçacığından talep gelmişse Invoke metodu ile gerekli işlem gerçekleştiriliyor.
                        label10.Text = veri3;
                    }));

            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
