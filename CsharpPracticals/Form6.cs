using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsharpPracticals
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public class Car
        {
            private double Speed;
            private int NumberOfDoors;
            private int HPower;
            private int Gear;
            private string Color;
            const int EngineNumber = 1;

            public void setSpeed(double sp)
            {
                Speed=sp;
            }
            public void setDoors(int d)
            {
                NumberOfDoors = d;
            }
            public void setHpower(int hp)
            {
                HPower = hp;
            }
            public void setGear(int g)
            {
                Gear = g;
            }
            public void setColor(string c)
            {
                Color = c;
            }
            public Car()
            { }
            public Car(int d, int hp, int g)
            {
                NumberOfDoors = d;
                HPower = hp;
                Gear = g;    
            }
            public Car(int d, int hp, int g, double s, string c)
            {
                NumberOfDoors = d;
                HPower = hp;
                Gear = g;
                Speed = s;
                Color = c;
            }
            public void Accelerate()
            {
                Speed++;
            }
            public void Accelerate(double s)
            {
                Speed=Speed+s;
            }
            public bool isMoving()
            {
                if (Speed == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            public string showData()
            {
                string str1;
                if (isMoving())
                {
                    str1 = "The car is moving" + Environment.NewLine;
                }
                else
                {
                    str1 = "The car is not moving" + Environment.NewLine;
                }
                string str2 = "Number of doors in car= " + NumberOfDoors +
                    Environment.NewLine + "Power of Car is= " + HPower + 
                    Environment.NewLine + "Gear of car is= " + Gear + 
                    Environment.NewLine + "Color of Car is  " + Color + 
                    Environment.NewLine + "Speed of the car is " + Speed + 
                    Environment.NewLine;
                return str1 + str2;
            }
        };

        private void Form6_Load(object sender, EventArgs e)
        {
            Car c1 = new Car();
            Car c2 = new Car(4,15,2);
            Car c3 = new Car(2,10,3,13.4,"Golden");

            c1.setColor("Brown");
            c1.setSpeed(0);
            c1.setDoors(4);
            c1.setHpower(12);
            c1.setGear(3);

            c2.setColor("White");
            c2.setSpeed(18);
            c1.isMoving();

            c2.Accelerate(6);
            c2.isMoving();

            c3.Accelerate();
            c3.isMoving();

            textBox1.Text += Environment.NewLine + "Car 1:" + Environment.NewLine;
            textBox1.Text += c1.showData();
            textBox1.Text += Environment.NewLine + "Car 2:" + Environment.NewLine;
            textBox1.Text += c2.showData();
            textBox1.Text += Environment.NewLine + "Car 3:" + Environment.NewLine;
            textBox1.Text += c3.showData();

        }
    }
}
