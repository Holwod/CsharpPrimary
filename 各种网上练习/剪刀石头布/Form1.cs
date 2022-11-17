using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 剪刀石头布
{
    public partial class Form1 : Form
    {
        
        Player player = new Player();
        CaiPan CaiPan = new CaiPan();
        Computer computer = new Computer(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "石头";
            NewMethod(str);
        }

        private void NewMethod(string str)
        {
            txtBoxPlay.Text = str;
            int playerNumber = player.ShowFist(str);
            textBox3.Text = Convert.ToString(CaiPan.Judge(playerNumber, computer.ShowFirst()));
            txtBoxC.Text = computer.Fist;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            NewMethod(str);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "布";
            NewMethod(str);
        }
    }

    public class Player
    {
        public int ShowFist(string first)
        { 
            int num = 0;
            switch (first)
            {
                case "石头":
                    num = 1;
                    break;

                case "剪刀":
                    num = 2;
                    break;
                
                case "布":
                    num = 3;
                    break;

            }
            return num;
            
        }

    }

    public class Computer

    { 
        
        public string Fist
        { get; set; }
       
        public int ShowFirst()
        {

        
            string[] s = { "   石头", "   剪刀", "   布" };
            Random rand = new Random();
            int r =rand.Next(1,4);
        switch (r)
            {
                case 1:
                    this.Fist= "石头";
                    break;

                case 2:
                    this.Fist = "剪刀";
                    break;
                
                case 3:
                    this.Fist = "布";
                    break;
            }
            return r;  
        }
    }

    public enum Result
    { 
        玩家赢,
        电脑赢,
        平手
    }

    public class CaiPan
    {
        public static Result Judge(int playNumber, int cpuNumber)
        {
            if (playNumber - cpuNumber == -1 || playNumber - cpuNumber == 2)
            {
                return Result.玩家赢;
            }
            else if (playNumber - cpuNumber == 0)
            {
                return Result.平手;
            }
            else
            {
                return Result.电脑赢;
            }
            
        }  
    }

}
