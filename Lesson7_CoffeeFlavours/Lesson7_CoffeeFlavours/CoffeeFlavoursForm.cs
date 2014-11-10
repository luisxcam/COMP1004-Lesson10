using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7_CoffeeFlavours
{
    public partial class CoffeeFlavoursForm : Form
    {
        public CoffeeFlavoursForm()
        {
            InitializeComponent();
        }

        private void printAllDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Handle printing and print previews when printing all.

            Font printFont = new Font("Arial", 12);
            float lineHeightFloat = printFont.Height + 2;
            float horizontalPrintLocationFloat = e.MarginBounds.Left;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            string printLineString;

            //Print the heading
            Font HeadingFont = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString("Flavours", HeadingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);

            // Loop through the entire list.
            //for (int ListIndexInteger = 0; ListIndexInteger < CoffeeComboBox.Items.Count; ListIndexInteger++)
            foreach (Object flavor in coffeeComboBox.Items)
            {
                //increment the  Y position for the next line.
                verticalPrintLocationFloat += lineHeightFloat;

                //Set up a line
                //PrintLineString = CoffeeComboBox.Items[ListIndexInteger].ToString();
                printLineString = flavor.ToString();
                //Send the line to the graphics page object.
                e.Graphics.DrawString(printLineString, printFont,
                    Brushes.Black, horizontalPrintLocationFloat,
                    verticalPrintLocationFloat);
            } // end for

        }

        private void printSelectedDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Handle printing and print previews when printing selected items.

            Font printFont = new Font("Arial", 12);
            Font headingFont = new Font("Arial", 14, FontStyle.Bold);
            float lineHeightFloat = printFont.Height + 2;
            float horizontalPrintLocationFloat = e.MarginBounds.Left;
            float verticalPrintLocationFloat = e.MarginBounds.Top;
            string printLineString;

            //Set up and display heading lines
            printLineString = "Print Selected Item";
            e.Graphics.DrawString(printLineString, headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);
            printLineString = "by Tom Tsiliopoulos";
            verticalPrintLocationFloat += lineHeightFloat;
            e.Graphics.DrawString(printLineString, headingFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);

            // Leave a blank line between the heading and detail line.
            verticalPrintLocationFloat += lineHeightFloat * 2;
            // Set up the selected line.
            printLineString = "Coffee: " + coffeeComboBox.Text +
                "     Syrup: " + syrupListBox.Text;
            // Send the line to the graphics page object.
            e.Graphics.DrawString(printLineString, printFont,
                Brushes.Black, horizontalPrintLocationFloat,
                verticalPrintLocationFloat);
        }

        private void printSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print selected coffee and syrup flavours
            if (syrupListBox.SelectedIndex == -1)
            {
                //Position 0 is none
                syrupListBox.SelectedIndex = 0;
            }
            
            if(coffeeComboBox.SelectedIndex != -1){
                printSelectedDocument.Print();
            }
            else
            {
                MessageBox.Show("Please select a coffee flavour", "Print Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void previewSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print selected coffee and syrup flavours
            if (syrupListBox.SelectedIndex == -1)
            {
                //Position 0 is none
                syrupListBox.SelectedIndex = 0;
            }

            if (coffeeComboBox.SelectedIndex != -1)
            {
                //print preview all flavours
                printPreviewDialog1.Document = printSelectedDocument;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a coffee flavour", "Print Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void printAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print all the coffee flavours
            printAllDocument.Print();
        }


        private void previewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //print preview all flavours
            printPreviewDialog1.Document = printAllDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void addCoffeeFlavourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (coffeeComboBox.Items.Count > 0)
            {
                //Add a new flavour provided by the user and if it does not exists
                if (coffeeComboBox.Text.Trim() != "" && coffeeComboBox.Text != String.Empty)
                {
                    //make sure not in the list
                    Boolean itemFoundBoolean = true;
                    int itemIndexInteger = 0;

                    do
                    {
                        if (coffeeComboBox.Text.ToUpper() == coffeeComboBox.Items[itemIndexInteger].ToString().ToUpper())
                        {
                            itemFoundBoolean = false;
                        }//if
                        else
                        {
                            itemIndexInteger++;
                        }//else

                    } while (itemFoundBoolean && !(itemIndexInteger >= coffeeComboBox.Items.Count));

                    //if found
                    if (!itemFoundBoolean)
                    {
                        MessageBox.Show("Duplicate Coffee Flavour found", "Add failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }//if
                    else
                    {
                        //if it is not in the list, add it
                        coffeeComboBox.Items.Add(coffeeComboBox.Text);
                        coffeeComboBox.Text = "";
                    }//else
                }//if
                else
                {
                    MessageBox.Show("Enter a coffee flavour to add", "No new entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//else
            }
            else
            {
                //if it is not in the list, add it
                coffeeComboBox.Items.Add(coffeeComboBox.Text);
                coffeeComboBox.Text = "";
            }
            
        }

        private void removeCoffeeFlavourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //remove flavour if it exists
            if (coffeeComboBox.SelectedIndex != -1)
            {
                coffeeComboBox.Items.Remove(coffeeComboBox.Text);
            }//if
            else
            {
                MessageBox.Show("Enter a coffee flavour to remove", "No selection done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//else
        }

        private void clearCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult responseDialogResult = MessageBox.Show("Are you sure you want to clear the list?", "Delete Coffees", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);

            if (responseDialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                coffeeComboBox.Items.Clear();
            }

        }

        private void countCoffeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //count the number of flavours
            String message = "There's "+coffeeComboBox.Items.Count+" different types of coffee flavours";

            MessageBox.Show(message, "Amount of selections", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } // end PrintSelectedPrintDocument_PrintPage

      
    }
}
