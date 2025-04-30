using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum Food
{
    Pizza,
    Burger,
    Pasta,
    Kimchi = 100
}
enum Day
{
    Mon,
    Tue,
    Wed,
    Thu,
    Fri,
    Sat,
    Sun
}

namespace WindowsFormsApp4_enum
{
    public partial class Form1 : Form
    {
        string inputData = "";
        public Form1()
        {
            InitializeComponent();

            //string animal = "cat";
            //switch (animal)
            //{
            //    case "Dog":
            //        break;
            //    case "Cat":
            //        break;
            //    default: break;
            //}

            //Food food = Food.Kimchi;
            //switch (food) { 
            //    case Food.Pizza: break;
            //    case Food.Burger: break;
            //    case Food.Pasta: break;
            //    case Food.Kimchi:
            //        int price = (int)Food.Kimchi;
            //        break;
            //}




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            inputData = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inputData = textBox1.Text;

            if (inputData.Equals("월요일") || inputData.Equals("화요일") || inputData.Equals("수요일") || inputData.Equals("목요일") || inputData.Equals("금요일") || inputData.Equals("토요일") || inputData.Equals("일요일"))
            {
                switch (inputData)
                {
                    case "월요일":
                        textBox2.Text = "월요일은 주말 쉬고 하기 싫지만 해야 하는 날 😢";
                        break;
                    case "화요일":
                        textBox2.Text = "화요일은 그냥 해야 하는 날 😠";
                        break;
                    case "수요일":
                        textBox2.Text = "수요일은 중간은 왔으니까 해야 하는 날 🥴";
                        break;
                    case "목요일":
                        textBox2.Text = "목요일은 내일 금요일이니까 해야 하는 날 🤩";
                        break;
                    case "금요일":
                        textBox2.Text = "금요일은 내일 주말이니까 해야 하는 날 🔥";
                        break;
                    case "토요일":
                        textBox2.Text = "토요일은 마음 편하게 주말을 즐기는 날 🍀";
                        break;
                    case "일요일":
                        textBox2.Text = "일요일은 이제 끝이니까 마지막처럼 즐기는 날 😇";
                        break;
                    default: break;
                }
            }
            else
            {
                textBox2.Text = "요일을 입력해주시옹";
            }
        }

        Day InputCheck(string message)
        {
            switch (message)
            {
                case "월요일": return Day.Mon;
                case "화요일": return Day.Tue;
                case "수요일": return Day.Wed;
                case "목요일": return Day.Thu;
                case "금요일": return Day.Fri;
                case "토요일": return Day.Sat;
                case "일요일": return Day.Sun;
                default: return Day.Mon;

            }
        }
    }
}
