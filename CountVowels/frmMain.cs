//Author: Thomas Lee
// Count Vowels

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //Converts text box entry into string and converts all letters to lowercase

            string myStr = txtEntry.Text.ToLower();

            int vowels = 0;

           // Console.WriteLine(myStr);
           //for loop that runs through the length of my string and 
            for (int i = 0; i < myStr.Length; i++)
            {
               //if statement that compares the char at location i and if the letter matches and increments the total of vowels by 1
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u')
                {
                    vowels++;
                }
            }
            txtVowels.Text = Convert.ToString(vowels);
        }
        //Changes the vowel count to blank when the text in the box is changed until it is counted again
        private void txtEntry_TextChanged(object sender, EventArgs e)
        {
            txtVowels.Text = "";
        }
    }
}
