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

namespace ArraySort
{
    public partial class Form1 : Form
    {
        //creating the array at class level allows for it to be referenced from all parts of the program
        string[] NameSortArray = new string[5000];
        int i = 0;
        StreamReader SR = File.OpenText("Names.Csv");

        public Form1()
        {
            InitializeComponent();
        }
        private void Swap (ref string a, ref string b)
        {

            string temp = a;
            a = b;
            b = temp;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                for (i = 0; i < 5000; i++)
                {
                    NameSortArray[i] = SR.ReadLine();
                    listBoxNames.Items.Add(NameSortArray[i]);
                }

            }
            catch
            {
                MessageBox.Show("E R R O R");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                



                StreamWriter OutputFile = new StreamWriter("SortedNames.CSV");
                foreach (string name in listBoxNames.Items)
                {
                    OutputFile.WriteLine(name.ToString());
                
                }
                MessageBox.Show("Output Complete!");
            }
            catch
            {
                MessageBox.Show("Output Not Completed");   
            }
        }

     

     

        private void SelectionSort(string[] NameSortArray)
        {
            int minIndex; //Subscript of smallest value in scanned area
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
            
                int counter = 0;
                DateTime Time1 = DateTime.Now;
                try
                {
                    // Array variables
                    const int SIZE = 5000;
                    string[] NameSortArray = new string[SIZE];
                    StreamReader inputFile = File.OpenText("Names.csv");


                    // Input names into Names Array while counter is less than the number of items
                    while (counter < NameSortArray.Length && !inputFile.EndOfStream)
                    {
                        NameSortArray[counter] = inputFile.ReadLine();
                        counter++;
                    }

                    // Sort Array alphabetically 
                    SelectionSort(NameSortArray);

                    listBoxNames.Items.Clear();

                    for (i = 0; i < 5000; i++)
                    {
                       
                        listBoxNames.Items.Add(NameSortArray[i]);
                    }

                    Double Time2 = (DateTime.Now - Time1).TotalSeconds;
                    labelOutputTimer.Text = ("Time elapsed: " + Time2 + " Seconds.");



                     

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private int BinarySearch(string[] NameSortArray, string value)
        {
            int first = 0;
            int last = NameSortArray.Length - 1;
            int middle;
            int position = -1;
            bool found = false;

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

        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
               string SearchBox = textBoxSearch.Text;
                int Position = BinarySearch(NameSortArray, textBoxSearch.Text);
bool SearchFound = NameSortArray.Contains(SearchBox);
                

                if (SearchFound == false)
                {
                    MessageBox.Show("The name you searched could not be found.");
                }
                else
                {
                    MessageBox.Show(Position.ToString());
                }
            }
            catch
            {
                MessageBox.Show("eeee");
            }
        }
    }
}
