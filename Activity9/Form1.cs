using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This code runs when the CalculateIntegerSum button is clicked
        private void CalculateIntegerSum_Click(object sender, EventArgs e)
        {
            try
            {
                int integerSumTerm1 = int.Parse(IntegerSumTerm1.Text); // Parses data from the IntegerSumTerm1 textbox into an integer variable
                int integerSumTerm2 = int.Parse(IntegerSumTerm2.Text); // Parses data from the IntegerSumTerm2 textbox into an integer variable

                IntegerSumResult.Text = Activity9Methods.IntegerSum(integerSumTerm1, integerSumTerm2).ToString(); // Applies the IntegerSum method to the above variables and sets the text of the IntegerSumResult textbox to the result
            } 
            catch (Exception ex) // If the data entered in the textboxes cannot be parsed into integer variables, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the CalculateAverage button is clicked
        private void CalculateAverage_Click(object sender, EventArgs e)
        {
            try
            {
                double averageTerm1 = double.Parse(AverageTerm1.Text); // Parses data from the AverageTerm1 textbox into a double variable
                double averageTerm2 = double.Parse(AverageTerm2.Text); // Parses data from the AverageTerm2 textbox into a double variable
                double averageTerm3 = double.Parse(AverageTerm3.Text); // Parses data from the AverageTerm3 textbox into a double variable
                double averageTerm4 = double.Parse(AverageTerm4.Text); // Parses data from the AverageTerm4 textbox into a double variable
                double averageTerm5 = double.Parse(AverageTerm5.Text); // Parses data from the AverageTerm5 textbox into a double variable

                AverageResult.Text = Activity9Methods.Average(averageTerm1, averageTerm2, averageTerm3, averageTerm4, averageTerm5).ToString(); // Applies the Average method to the above variables and sets the text of the AverageResult textbox to the result
            }
            catch(Exception ex) // If the data entered in the textboxes cannot be parsed into double variables, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the CalculateRandomSum button is clicked
        private void CalculateRandomSum_Click(object sender, EventArgs e)
        {
            RandomSumResult.Text = Activity9Methods.RandomSum().ToString(); // Calls the RandomSum method and sets the text of the RandomSumResult textbox to the result
        }

        // This code runs wen the CalculateDivisibleBy3 button is clicked
        private void CalculateDivisibleBy3_Click(object sender, EventArgs e)
        {
            try
            {
                int divisibleby3Term1 = int.Parse(DivisibleBy3Term1.Text); // Parses data from the DivisibleBy3Term1 textbox into an integer variable
                int divisibleby3Term2 = int.Parse(DivisibleBy3Term2.Text); // Parses data from the DivisibleBy3Term2 textbox into an integer variable
                int divisibleby3Term3 = int.Parse(DivisibleBy3Term3.Text); // Parses data from the DivisibleBy3Term3 textbox into an integer variable

                DivisibleBy3Result.Text = Activity9Methods.DivisibleBy3(divisibleby3Term1, divisibleby3Term2, divisibleby3Term3).ToString(); // Applies the DivisibleBy3 method to the above variables and sets the text of the DivisibleBy3Result textbox to the result
            }
            catch (Exception ex) // If the data entered in the textboxes cannot be parsed into integer variables, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the CalculateFewerCharacters button is clicked
        private void CalculateFewerCharacters_Click(object sender, EventArgs e)
        {
            try
            {
                FewerCharactersResult.Text = Activity9Methods.FewerCharacters(String1.Text, String2.Text); // Applies the FewerCharacters method to the data entered in the String textboxes and sets the text of the FewerCharactersResult textbox to the result
            }
            catch (Exception ex) // If there is an error while retrieving the data from the textboxes, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the CalculateGreatestInArray button is clicked
        private void CalculateGreatestInArray_Click(object sender, EventArgs e)
        {
            try
            {
                double[] array = { double.Parse(GreatestInArrayTerm1.Text), double.Parse(GreatestInArrayTerm2.Text), double.Parse(GreatestInArrayTerm3.Text), double.Parse(GreatestInArrayTerm4.Text), double.Parse(GreatestInArrayTerm5.Text) }; // Parses data from the GreatestInArrayTerm textboxes into double variables and stores then in an array
                
                GreatestInArrayResult.Text = Activity9Methods.GreatestInArray(array).ToString(); // Applies the GreatestInArrayMethod to the above array and sets the text of the GreatestInArrayResult textbox to the result

            }
            catch (Exception ex) // If the data entered in the textboxes cannot be parsed into double variables, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the CalculateIfTwoBooleansAreTheSame button is clicked
        private void CalculateIfTwoBooleansAreTheSame_Click(object sender, EventArgs e)
        {
            try
            {
                bool boolean1 = bool.Parse(Boolean1.Text); // Parses data from the Boolean1 textbox into a boolean variable
                bool boolean2 = bool.Parse(Boolean2.Text); // Parses data from the Boolean2 textbox into a boolean variable

                CompareBooleanResult.Text = Activity9Methods.SameValue(boolean1, boolean2).ToString(); // Applies the SameValue method to the above variables and sets the text of the CompareBooleanResult textbox to the result
            }
            catch (Exception ex) // If the data entered in the textboxes cannot be parsed into boolean variables, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the CalculateIntegerProduct button is clicked
        private void CalculateIntegerProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int integerProductTerm = int.Parse(IntegerProductTerm.Text); // Parses data from the IntegerProductTerm textbox into an integer variable
                double doubleProductTerm = double.Parse(DoubleProductTerm.Text); // Parses data from the DoubleProductTerm textbox into a double variable

                IntegerProductResult.Text = Activity9Methods.Product(integerProductTerm, doubleProductTerm).ToString(); // Applies the Product method to the above variables and sets the text of the IntegerProductResult textbox to the result
            }
            catch (Exception ex) // If the data entered in the textboxes cannot be parsed into integer variable or double variables, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the CalculateArrayAverage button is clicked
        private void CalculateArrayAverage_Click(object sender, EventArgs e)
        {
            try
            {
                int[][] array = // Parses data from the ArrayTerm textboxes into integer variables and stores them in a two dimensional array
                {
                    new int[] { int.Parse(ArrayTermRow0Column0.Text),  int.Parse(ArrayTermRow0Column1.Text), int.Parse(ArrayTermRow0Column2.Text) },
                    new int[] { int.Parse(ArrayTermRow1Column0.Text), int.Parse(ArrayTermRow1Column1.Text), int.Parse(ArrayTermRow1Column2.Text) },
                    new int[] { int.Parse(ArrayTermRow2Column0.Text), int.Parse(ArrayTermRow2Column1.Text), int.Parse(ArrayTermRow2Column2.Text) },
                };

                ArrayAverageResult.Text = Activity9Methods.AverageOf2DArray(array).ToString(); // Applies the AverageOf2DArray method to the above array and sets the text of the ArrayAverageResult to the result
            } 
            catch(Exception ex) // If the data entered in the textboxes cannot be parsed into integer variables, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
