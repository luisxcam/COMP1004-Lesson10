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

            Font PrintFont = new Font("Arial", 12);
            float LineHeightFloat = PrintFont.Height + 2;
            float HorizontalPrintLocationFloat = e.MarginBounds.Left;
            float VerticalPrintLocationFloat = e.MarginBounds.Top;
            string PrintLineString;

            //Print the heading
            Font HeadingFont = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString("Flavours", HeadingFont,
                Brushes.Black, HorizontalPrintLocationFloat,
                VerticalPrintLocationFloat);

            // Loop through the entire list.
            //for (int ListIndexInteger = 0; ListIndexInteger < CoffeeComboBox.Items.Count - 1; ListIndexInteger++)
            foreach (Object flavor in coffeeComboBox.Items)
            {
                //increment the  Y position for the next line.
                VerticalPrintLocationFloat += LineHeightFloat;

                //Set up a line
                //PrintLineString = CoffeeComboBox.Items[ListIndexInteger].ToString();
                PrintLineString = flavor.ToString();
                //Send the line to the graphics page object.
                e.Graphics.DrawString(PrintLineString, PrintFont,
                    Brushes.Black, HorizontalPrintLocationFloat,
                    VerticalPrintLocationFloat);
            } // end for

        }

        private void printSelectedDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Handle printing and print previews when printing selected items.

            Font PrintFont = new Font("Arial", 12);
            Font HeadingFont = new Font("Arial", 14, FontStyle.Bold);
            float LineHeightFloat = PrintFont.Height + 2;
            float HorizontalPrintLocationFloat = e.MarginBounds.Left;
            float VerticalPrintLocationFloat = e.MarginBounds.Top;
            string PrintLineString;

            //Set up and display heading lines
            PrintLineString = "Print Selected Item";
            e.Graphics.DrawString(PrintLineString, HeadingFont,
                Brushes.Black, HorizontalPrintLocationFloat,
                VerticalPrintLocationFloat);
            PrintLineString = "by Tom Tsiliopoulos";
            VerticalPrintLocationFloat += LineHeightFloat;
            e.Graphics.DrawString(PrintLineString, HeadingFont,
                Brushes.Black, HorizontalPrintLocationFloat,
                VerticalPrintLocationFloat);

            // Leave a blank line between the heading and detail line.
            VerticalPrintLocationFloat += LineHeightFloat * 2;
            // Set up the selected line.
            PrintLineString = "Coffee: " + coffeeComboBox.Text +
                "     Syrup: " + syrupListBox.Text;
            // Send the line to the graphics page object.
            e.Graphics.DrawString(PrintLineString, PrintFont,
                Brushes.Black, HorizontalPrintLocationFloat,
                VerticalPrintLocationFloat);
        } // end PrintSelectedPrintDocument_PrintPage

      
    }
}
