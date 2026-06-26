using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{ 
    public partial class PizzaProject : Form
    {

        public PizzaProject()
        {
            InitializeComponent();
        }

        float _TotalPrice = 0;

        float CalculateTotalSize()
        {
            if (rbSmall.Checked == true)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMedium.Checked == true)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
            
        }

        float CalculateTotalCrust()
        {
            if (rbThinCrust.Checked == true)
                return Convert.ToSingle(rbThinCrust.Tag);
            else
                return Convert.ToSingle(rbThickCrust.Tag);
        }

        float CalculateTotalToppings()
        {
            float total = 0;

            if(chkExtraChees.Checked == true)
            {
                total += Convert.ToSingle(chkExtraChees.Tag);
            }
            if(chkOnion.Checked == true)
            {
                total += Convert.ToSingle(chkOnion.Tag);
            }
            if(chkMushrooms.Checked == true)
            {
                total += Convert.ToSingle(chkMushrooms.Tag);
            }
            if(chkOlives.Checked == true)
            {
                total += Convert.ToSingle(chkOlives.Tag);
            }
            if(chkTomatoes.Checked == true)
            {
                total += Convert.ToSingle(chkTomatoes.Tag);
            }
            if(chkGreenPerpers.Checked == true)
            {
                total += Convert.ToSingle(chkGreenPerpers.Tag);
            }

            return total;
        }

        float CalculateTotalPrice()
        {
            return CalculateTotalSize() + CalculateTotalCrust() + CalculateTotalToppings();
        }

        void UpdateTotalPrice()
        {
            _TotalPrice = CalculateTotalPrice();
            lbTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked == true)
            {
                lbWhatIsSize.Text = "Small";
            }
            else if (rbMedium.Checked == true)
            {
                lbWhatIsSize.Text = "Medium";
            }
            else
            {
                lbWhatIsSize.Text = "Large";
            }

        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked == true)
            {
                lbCrustInfo.Text = "Thin";
            }
            else
            {
                lbCrustInfo.Text = "Thick";
            }
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked == true)
            {
                lbWhereToEat.Text = "Eat In";
            }
            else
            {
                lbWhereToEat.Text = "Take out";
            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked == true)
            {
                sToppings = "Extra Chees";
            }
            if (chkOnion.Checked == true)
            {
                sToppings += "," + "Onion";
            }
            if (chkOlives.Checked == true)
            {
                sToppings += "," + "Olives";
            }
            if (chkMushrooms.Checked == true)
            {
                sToppings += "," + "Mushrooms";
            }
            if (chkTomatoes.Checked == true)
            {
                sToppings += "," + "Tomatoes";
            }
            if (chkGreenPerpers.Checked == true)
            {
                sToppings += "," + "Green Pepers";
            }
            if (sToppings.Length == 0)
            {
                sToppings = "No Toppings";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1);
            }

            lbToppingsInfo.Text = sToppings;
        }

        void ResetOrder()
        {
            //group box
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            groupBox1.Enabled = true;
            gbWhereToEat.Enabled = true;

            //check box
            chkExtraChees.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            chkGreenPerpers.Checked = false;
            chkOlives.Checked = false;


            //radio button
            rbSmall.Checked = true;
            rbThickCrust.Checked = true;
            rbEatIn.Checked = true;

            numericUpDown1.Value = numericUpDown1.Minimum;
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPerpers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbSmall.Checked = true;
            rbThickCrust.Checked = true;
            rbEatIn.Checked = true;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            gbCrust.Enabled = false;
            gbSize.Enabled = false;
            gbWhereToEat.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        { 
            ResetOrder();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            float HowManyPizza = Convert.ToSingle(numericUpDown1.Value);
            string TotalPriceAsString = Convert.ToString(_TotalPrice * HowManyPizza);

            lbTotalPrice.Text = $"${TotalPriceAsString}";
        }
    }
}
