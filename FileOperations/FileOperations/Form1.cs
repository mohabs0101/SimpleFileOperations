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

namespace FileOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           if ( Directory.Exists("c:\\directory"))

            { MessageBox.Show("directory alrady exist"); }
           else
            {
                Directory.CreateDirectory("c:\\directory");

                //or
                //Directory.CreateDirectory(@"c:\mh3\moh4");

                MessageBox.Show("directory created");


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("c:\\directory"))

            {
                Directory.Delete("c:\\directory");


                MessageBox.Show("directory deleted");
            }
            else
            {
                MessageBox.Show("directory not fond");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("c:\\directory"))

                MessageBox.Show("directory exist");
            else
            {
                MessageBox.Show("directory not exist");
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("c:\\directory"))

            {
                // this not working the folder not aper in destenation
                Directory.Move("c:\\directory","c:\\directory2");


                MessageBox.Show("directory moved");
            }
            else
            {
                MessageBox.Show("directory not fond");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (File.Exists("e:\\file1.txt"))
            {
                MessageBox.Show("file exist");
            }
            else
            {
                MessageBox.Show("file not exist");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (File.Exists("e:\\file1.txt"))
            {
                MessageBox.Show("file alrady exist");
            }
            else
            {
                File.Create("e:\\file1.txt");
                MessageBox.Show("file created");
            }
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (File.Exists("e:\\file1.txt"))
            {
                File.Delete("e:\\file1.txt");
                MessageBox.Show("file deleted");
            }
            else
            {
                MessageBox.Show("file not exist");

            }


           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (File.Exists("e:\\file1.txt"))
            {
                File.Copy("e:\\file1.txt","e:\\copy.txt");
                MessageBox.Show("file copyed");
            }
            else
            {
                MessageBox.Show("file not exist");

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (File.Exists("e:\\file1.txt"))
            {
                File.Move("e:\\file1.txt", "e:\\cut.txt");
                MessageBox.Show("file moved");
            }
            else
            {
                MessageBox.Show("file not exist");

            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            //var hold any type of data
            var filename = "e:\\streamtest.txt";
            byte[] arrayofbytes= null; //arrayofbyte to contain data
            arrayofbytes = Encoding.ASCII.GetBytes("mohammedawdakwdlgfselfgsfgef;esf;esfsefesf"); //fill array with data



            var filestream = new FileStream(filename, FileMode.Append);//  if file not exist will create it else will add to existing text(append)
            //filestrOBJ = new FileStream("e:\\streamtest.txt", FileMode.Create);//will create new file but if file exist will write into it and deleted old text
            //filestrOBJ = new FileStream("e:\\streamtest.txt", FileMode.CreateNew);//will create new file if file alrady exist will throw exception
            //filestrOBJ = new FileStream("e:\\streamtest.txt", FileMode.Open);// will open existing file if we write will not append to old texxt
            filestream.Write(arrayofbytes, 0, arrayofbytes.Length);

          

            filestream.Close();

            MessageBox.Show("File opened or created and writen and closed");



        }

        private void button14_Click(object sender, EventArgs e)
        {
            var filename = "e:\\streamtest.txt";

            var read = File.ReadAllText(filename);
            //var read = File.ReadAllBytes (filename);

            if (read != null)
            {
                Console.WriteLine(read);

            }


        }
    }
}
