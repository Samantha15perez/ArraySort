﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ArraySort
{
    public partial class Form1 : Form
    {
        //creating the array at class level allows for it to be referenced from all parts of the program
        string[] NameSortArray = new string[5000];
        int i = 0;
        bool Exact = false;
        bool Partial = false;
        bool StartsWith = false;
        //actually reads the specified file
        StreamReader SR = File.OpenText("Names.Csv");

        public Form1()
        {
            InitializeComponent();
        }
        private void Swap (ref string a, ref string b)
        {
            //this method is referenced in order to swap the names in the array properly
            string temp = a;
            a = b;
            b = temp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sets the search box, radio buttons and button as unusable until you sort the names. 
            buttonSearch.Visible = false;
            textBoxSearch.Visible = false;
            radioButtonExact.Visible = false;
            radioButtonPartial.Visible = false;
            radioButtonStartsWith.Visible = false;

            try
            {
                for (i = 0; i < 5000; i++)
                {
                    //reads every name within the array and inserts them into the listbox
                    NameSortArray[i] = SR.ReadLine();
                    listBoxNames.Items.Add(NameSortArray[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //grabs the current time
            DateTime Time1 = DateTime.Now;
            
            try
            {

                //outputs the names to a seperate file.
                StreamWriter OutputFile = new StreamWriter("SortedNames.CSV");
                foreach (string name in listBoxNames.Items)
                {
                    OutputFile.WriteLine(name.ToString());

                
                }
                //subtracts the time from the beginning of the action to get an accurate timestamp
                Double Time2 = (DateTime.Now - Time1).TotalSeconds;
                labelOutputTimer.Text = ("Time elapsed: " + Time2 + " Seconds.");
                MessageBox.Show("Output Complete!");
                
            }
            catch (Exception ex)
            {
                //subtracts the time from the beginning of the action to get an accurate timestamp
                Double Time2 = (DateTime.Now - Time1).TotalSeconds;
                labelOutputTimer.Text = ("Time elapsed: " + Time2 + " Seconds.");
                MessageBox.Show(ex.Message);

            }
        }

        private void SelectionSort(string[] NameSortArray)
        {
            //this is taken from the book, but tweaked to handle strings instead of ints

            int minIndex; //index of smallest value in scanned area
            string minValue; //smallest value in the scanned area

            //The outter loop steps through all the array elements, Except the last one
            // The startscan variable marks the position where the scan should begin
            for (int startScan = 0; startScan < NameSortArray.Length - 1; startScan++)
            {
                //Assume the first element in the scannable area 
                //Is the smallest value
                minIndex = startScan;
                minValue = NameSortArray[startScan];

                //Scan the array, starting at the 2nd element in the 
                //Scannable area, looking for the smallest value.
                for (int index = startScan + 1; index < NameSortArray.Length; index++)
                {
                    if (string.Compare(minValue, NameSortArray[index], true) == 1)
                    {
                        minValue = NameSortArray[index];
                        minIndex = index;
                    }
                }

                //Swap the element with the smallest value with the
                // first element in the scannable area
                Swap(ref NameSortArray[minIndex], ref NameSortArray[startScan]);

            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {

            //grabs the current time
            DateTime Time1 = DateTime.Now;
            try
                {

                    // Sorts the array alphabetically 
                    SelectionSort(NameSortArray);
                    //clears list box
                    listBoxNames.Items.Clear();

                    for (i = 0; i < 5000; i++)
                    {
                       //adds all the names back into the listbox in the sorted order
                        listBoxNames.Items.Add(NameSortArray[i]);
                    }
               

                //subtracts the time from the beginning of the action to get an accurate timestamp
                Double Time2 = (DateTime.Now - Time1).TotalSeconds;
                //outputs time taken
                labelOutputTimer.Text = ("Time elapsed: " + Time2 + " Seconds.");

                //once the names have been sorted, the search box, radio buttons, and button become available.
                buttonSearch.Visible = true;
                textBoxSearch.Visible = true;
                radioButtonExact.Visible = true;
                radioButtonExact.Select();
                radioButtonPartial.Visible = true;
                radioButtonStartsWith.Visible = true;



            }
                catch (Exception ex)
                {
                //subtracts the time from the beginning of the action to get an accurate timestamp
                Double Time2 = (DateTime.Now - Time1).TotalSeconds;
                //outputs time taken
                labelOutputTimer.Text = ("Time elapsed: " + Time2 + " Seconds.");
                //error handling
                MessageBox.Show(ex.Message);
                
            }

        }

        private int BinarySearch(string[] NameSortArray, string value, bool Exact, bool StartsWith, bool Partial)
        {
            //binary search method is for exact
            //i kept the sequential search (for partial and startswith) in the same method for ease of access


            int first = 0;
            int last = NameSortArray.Length - 1;
            int middle;
            int position = -1;
            bool found = false;

            if (Exact == true)
            {
                while (!found && first <= last)
                {
                    middle = (first + last) / 2;
                    if (NameSortArray[middle] == value)
                    {
                        found = true;
                        position = middle;
                    }
                    else if (string.Compare(NameSortArray[middle], value, false) > 0)
                    {
                        last = middle - 1;
                    }
                    else
                    {
                        first = middle + 1;

                    }

                }
                return position;

            }

            if (StartsWith == true)
            {
                int i = 0;

                while (i < last)
                {
                    if (NameSortArray[i].StartsWith(value))
                    {
                        position = i;
                        return position;

                    }
                    else
                    {
                        i++;
                    }
                }


            position = -1;
            return position;
            }
            if (Partial == true)
            {
                int i = 0;

                while (i < last)
                {
                    if (NameSortArray[i].Contains(value))
                    {
                        position = i;

                        break;
                    }
                    else
                    {
                        i++;
                    }
                }

                return position;


            }

            position = -1;
            return position;
        
        }

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            //grabs the current time
            DateTime Time1 = DateTime.Now;
            try
            {

                //puts the input text into a variable
                string SearchBox = textBoxSearch.Text;
                
                //if the input text is found, it sets the boolean to true
                bool SearchFound = NameSortArray.Contains(SearchBox);

                //uses binarysearch to search the array for the input text
                int Position = BinarySearch(NameSortArray, textBoxSearch.Text, Exact, StartsWith, Partial);

                if (Position >= 0)
                {
                    SearchFound = true;
                }
                else
                {
                    SearchFound = false;
                }

                //if the input text is not found, it notifies the user.
                if (SearchFound == false)
                {
                    //subtracts the time from the beginning of the action to get an accurate timestamp
                    Double Time2 = (DateTime.Now - Time1).TotalSeconds;
                    labelOutputTimer.Text = ("Time elapsed: " + Time2 + " Seconds.");
                    MessageBox.Show("The name you searched could not be found.");

                }
                else
                {

                    //subtracts the time from the beginning of the action to get an accurate timestamp
                    Double Time2 = (DateTime.Now - Time1).TotalSeconds;
                    labelOutputTimer.Text = ("Time elapsed: " + Time2 + " Seconds.");

                    //finds and highlights the correct listbox item corresponding to the name. 
                    listBoxNames.SetSelected(Position, true);

                }
            }
            catch (Exception ex)
            {
                //subtracts the time from the beginning of the action to get an accurate timestamp
                Double Time2 = (DateTime.Now - Time1).TotalSeconds;
                labelOutputTimer.Text = ("Time elapsed: " + Time2 + " Seconds.");
                MessageBox.Show(ex.Message);
            }

        }

        private void radioButtonExact_CheckedChanged(object sender, EventArgs e)
        {
            //sets the corresponding boolean to true
            Exact = true;
            Partial = false;
            StartsWith = false;
        }

        private void radioButtonPartial_CheckedChanged(object sender, EventArgs e)
        {
            //sets the corresponding boolean to true
            Partial = true;
            Exact = false;
            StartsWith = false;
        }

        private void radioButtonStartsWith_CheckedChanged(object sender, EventArgs e)
        {
            //sets the corresponding boolean to true
            StartsWith = true;
            Exact = false;
            Partial = false;
        }
    }
}
