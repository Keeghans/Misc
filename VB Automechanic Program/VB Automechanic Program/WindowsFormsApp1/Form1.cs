using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joe_s_Automotive
{
    public partial class Form1 : Form
    {
        // Designed by Keeghan Johnson
        private const decimal OIL_CHANGE = 26.00m;
        private const decimal LUBE_JOB = 18.00m;
        private const decimal RADIATOR_FLUSH = 30.00m;
        private const decimal TRANSMISSION_FLUSH = 80.00m;
        private const decimal INSPECTION = 15.00m;
        private const decimal MUFFLER_REPLACEMENT = 100.00m;
        private const decimal TIRE_ROTATION = 20.00m;
        private const decimal SALES_TAX = 0.06m;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal OilLubeCharges()
        {
            // Declare variables
            decimal total = 0m;

            // Add oil change price to total if checked.
            if (cbOilChange.Checked)
            {
                total += OIL_CHANGE;
            }

            // Add lube job price to total if checked.
            if (cbLubeJob.Checked)
            {
                total += LUBE_JOB;
            }

            return total;
        }

        private decimal FlushCharges()
        {
            // Declare variables
            decimal total = 0m;

            // Add radiator flush price to total if checked.
            if (cbRadiatorFlush.Checked)
            {
                total += RADIATOR_FLUSH;
            }

            // Add transmission flush price to total if checked.
            if (cbTransmissionFlush.Checked)
            {
                total += TRANSMISSION_FLUSH;
            }

            return total;
        }

        private decimal MiscCharges()
        {
            // Declare variables
            decimal total = 0m;

            // Add inspection price to total if checked.
            if (cbInspection.Checked)
            {
                total += INSPECTION;
            }

            // Add muffler price to total if checked.
            if (cbReplaceMuffler.Checked)
            {
                total += MUFFLER_REPLACEMENT;
            }

            // Add tire rotation price to total if checked.
            if (cbTireRotation.Checked)
            {
                total += TIRE_ROTATION;
            }

            return total;
        }

        private decimal OtherCharges(decimal parts, decimal labor)
        {
            // Calculate and return other charges.
            return parts + labor;
        }

        private decimal TaxCharges(decimal parts)
        {
            // Calculate and return tax charges.
            return parts * SALES_TAX;
        }

        private decimal TotalCharges(decimal parts, decimal labor)
        {
            // Calculate and return total charges.
            return OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges(parts, labor) + TaxCharges(parts);
        }

        private void ClearOilLube()
        {
            // Clear check boxes.
            cbOilChange.Checked = false;
            cbLubeJob.Checked = false;
        }

        private void ClearFlushes()
        {
            // Clear check boxes.
            cbRadiatorFlush.Checked = false;
            cbTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            // Clear check boxes.
            cbInspection.Checked = false;
            cbReplaceMuffler.Checked = false;
            cbTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            // Set text boxes back to zero.
            txtParts.Text = "0";
            txtLabor.Text = "0";

            // Reset focus.
            txtParts.Focus();
        }

        private void ClearFees()
        {
            // Clear labels.
            lblServices.Text = "";
            lblPartsSummary.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
        }

        private bool InputIsValid(ref decimal parts, ref decimal labor)
        {
            // Flag variable to indicate whether the input is good
            bool inputGood = false;

            // Test out both variables
            if (decimal.TryParse(txtParts.Text, out parts))
            {
                if (parts >= 0)
                {
                    if (decimal.TryParse(txtLabor.Text, out labor))
                    {
                        if (labor >= 0)
                        {
                            // Both inputs are good.
                            inputGood = true;
                        }
                        else
                        {
                            // Display an error message for labor.
                            MessageBox.Show("Please enter a positive number for labor.");
                        }
                    }
                    else
                    {
                        // Display an error message for labor.
                        MessageBox.Show("Please enter a valid number for labor.");
                    }
                }
                else
                {
                    // Display an error message for parts.
                    MessageBox.Show("Please enter a positive number for parts.");
                }
            }
            else
            {
                // Display an error message for parts.
                MessageBox.Show("Please enter a valid number for parts.");
            }

            return inputGood;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Declare variables
            decimal servicesTotal;
            decimal labor = 0m;
            decimal parts = 0m;
            decimal taxTotal;
            decimal total;

            if (InputIsValid(ref parts, ref labor))
            {
                // Get totals.
                servicesTotal = OilLubeCharges() + FlushCharges() + MiscCharges() + labor;
                taxTotal = TaxCharges(parts);
                total = TotalCharges(parts, labor);

                // Display results.
                lblServices.Text = servicesTotal.ToString("c");
                lblPartsSummary.Text = parts.ToString("c");
                lblTax.Text = taxTotal.ToString("c");
                lblTotal.Text = total.ToString("c");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear form.
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}