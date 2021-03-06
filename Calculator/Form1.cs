﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int Operation; //1 add 2 sub 3 multiple 4 div
        double Num1;
        double Num2;
        double Result;
        double Num3;
        bool btnEqlClicked = false;
        bool othbtnClicked = false;
        string lastX;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "1";

            }
            else
            {
                textBox.Text = textBox.Text + "1";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "1";
                btnEqlClicked = false;

            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "2";

            }
            else
            {
                textBox.Text = textBox.Text + "2";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "2";
                btnEqlClicked = false;

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "3";
            }
            else
            {
                textBox.Text = textBox.Text + "3";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "3";
                btnEqlClicked = false;

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "4";
            }
            else
            {
                textBox.Text = textBox.Text + "4";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "4";
                btnEqlClicked = false;

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "5";
            }
            else
            {
                textBox.Text = textBox.Text + "5";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "5";
                btnEqlClicked = false;

            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "6";
            }
            else
            {
                textBox.Text = textBox.Text + "6";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "6";
                btnEqlClicked = false;

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "7";
            }
            else
            {
                textBox.Text = textBox.Text + "7";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "7";
                btnEqlClicked = false;

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "8";
            }
            else
            {
                textBox.Text = textBox.Text + "8";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "8";
                btnEqlClicked = false;

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "9";
            }
            else
            {
                textBox.Text = textBox.Text + "9";

            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "9";
                btnEqlClicked = false;

            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            //BasAdd();
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "0";
            }
            else
            {
                textBox.Text = textBox.Text + "0";
            }
            if (lastX == Result.ToString() && btnEqlClicked)
            {
                othbtnClicked = false;
                textBox.Text = "0";
                btnEqlClicked = false;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            lblFirstNumber.Text = "";
        }

        private void btnBSpace_Click(object sender, EventArgs e)
        {
            
            if (textBox.Text.Length == 0)
            {
                textBox.Text = "0";
            }
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);


        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            try
            {
                lblFirstNumber.Text = textBox.Text;
                Num1 = Convert.ToDouble(textBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a value.");
            }
            textBox.Text = "";
            Operation = 1;
            
            //if (btnClicked == true)
            //{
            //    Num2 = Convert.ToDouble(textBox.Text);
            //    Result = Num1 + Num2;
            //    return;
            //}
            //textBox.Text = Result.ToString();




            //string sonuc = (Rakam + Rakam2).ToString();
            //textBox.Text = sonuc;

        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            btnEqlClicked = true;

            try
            {
                if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "0";
                }

                else
                {


                    switch (Operation)
                    {
                        case 1:
                            Num3 = Convert.ToDouble(lblFirstNumber.Text);
                            Num2 = Convert.ToDouble(textBox.Text);
                            Result = Num2 + Num3;
                            lblFirstNumber.Text = "0";

                            textBox.Text = Result.ToString();
                            lastX = Result.ToString();



                            break;
                        case 2:
                            Num3 = Convert.ToDouble(lblFirstNumber.Text);
                            Num2 = Convert.ToDouble(textBox.Text);
                            Result = Num3 - Num2;
                            textBox.Text = Result.ToString();
                            lastX = Result.ToString();

                            break;
                        case 3:
                            Num3 = Convert.ToDouble(lblFirstNumber.Text);
                            Num2 = Convert.ToDouble(textBox.Text);
                            Result = Num3 * Num2;
                            textBox.Text = Result.ToString();
                            lastX = Result.ToString();

                            break;
                        case 4:
                            Num3 = Convert.ToDouble(lblFirstNumber.Text);
                            Num2 = Convert.ToDouble(textBox.Text);
                            if (Num2 == 0)
                            {
                                MessageBox.Show("Sıfıra bölünme hatası");
                                textBox.Text = "0";
                                break;
                            }
                            Result = Num3 / Num2;
                            textBox.Text = Result.ToString();
                            lastX = Result.ToString();

                            break;


                        default:
                            break;
                    }

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Eksik Değer.");
                textBox.Text = "";
                lblFirstNumber.Text = "";
                
            }
            //if (Operation == "+")
            //{
            //}
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                lblFirstNumber.Text = textBox.Text;
                Num1 = Convert.ToDouble(textBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a value.");
            }
            textBox.Text = "";
            //Operation = "-";
            Operation = 2;
            
        }

        private void btnMult_Click(object sender, EventArgs e)
        {

            try
            {
                lblFirstNumber.Text = textBox.Text;
                Num1 = Convert.ToDouble(textBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a value.");
            }               
            
           
            textBox.Text = "";
            Operation = 3;
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                lblFirstNumber.Text = textBox.Text;
                Num1 = Convert.ToDouble(textBox.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Please enter a value.");
            }
            textBox.Text = "";
            Operation = 4;
            if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = "0";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            othbtnClicked = true;
            while (textBox.Text.Contains(",") == false)
            {
                if (textBox.Text == "0" && string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = "0" + ",";
                }
                else
                {
                    textBox.Text = textBox.Text + ",";

                }

                if (lastX == Result.ToString() && btnEqlClicked)
                {
                    othbtnClicked = false;
                    textBox.Text = "0,";
                    btnEqlClicked = false;

                }
            }
            //BasAdd();
           
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LEBLEBİ");
        }

        private void lblFirstNumber_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            //MinimizeBox = false;
        }
        // incase you want to use dots
        //void BasAdd()
        //{
        //    if (textBox.Text != "0" && !string.IsNullOrEmpty(textBox.Text))
        //    {
        //        if (textBox.Text.Length % 3 == 0)
        //        {
        //            textBox.Text = textBox.Text + ".";
        //            return;
        //        }

        //    }


        //}
    }
}
