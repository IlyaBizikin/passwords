using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string put;
        public Form1()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            //put = textBox1.Text;
            /*put = textBox1.Text;
            string path = @put;
            Cmd(path);*/
            /*try
            {
                textBox2.Text = put;
            }
            catch
            {
                textBox2.Focus();
            }*/
            //Read(path);
        }

        string Password = "dhfh";
        string Pswd = "dsfsdf";
        string psswrd ="dafdaf";
        string Parol = "dsfsdf";
        //string psswrd = "sdfdsf";
        //string password ="dsfdsf";
        /* Логин - …
        Пароль -… */


        /*private void Cmd(string line)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer",
                Arguments = $"/n,select,{line}"
            });
        }*/

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                put = textBox1.Text;
            read();
        }


        private async void read()
        {
            {
                //string path = put;
                string path = "C:/Users/Bazikin-i/students_performance.csv";
                using (StreamReader reader = new StreamReader(path))
                {
                    var people = new List<string>();

                    string line;
                    while ((line = await reader.ReadLineAsync())
                           != null)
                    {
                        people.Add(line);
                    }
                    //for (int i = 0; i < people.Count; i++)
                    //{
                    //  Console.WriteLine(people[i] + " ");
                    //}
                    /*try
                    {

                        StreamWriter sw = new StreamWriter("C:\\Users\\Bazikin-i\\Test1.txt", true);


                        for (int i = 0; i < people.Count; i++)
                        {
                            sw.Write(people[i]);
                        }


                        sw.Close();
                    }
                    finally { }
                    */
                    File.WriteAllText("out.json", String.Empty);
                    for (int i = 0; i < people.Count; i++)
                        File.AppendAllText("out.json", JsonConvert.SerializeObject(people[i]));
                }
            }
            
        }

    }
}



