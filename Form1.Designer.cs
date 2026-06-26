namespace PizzaProject
{
    partial class PizzaProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkGreenPerpers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbOrderSummry = new System.Windows.Forms.GroupBox();
            this.gbTotalPricr = new System.Windows.Forms.GroupBox();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbWhereToEatSummry = new System.Windows.Forms.GroupBox();
            this.lbWhereToEat = new System.Windows.Forms.Label();
            this.gbToppingsSummry = new System.Windows.Forms.GroupBox();
            this.lbToppingsInfo = new System.Windows.Forms.Label();
            this.lbCrustInfo = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbWhatIsSize = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummry.SuspendLayout();
            this.gbTotalPricr.SuspendLayout();
            this.gbWhereToEatSummry.SuspendLayout();
            this.gbToppingsSummry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Location = new System.Drawing.Point(25, 70);
            this.gbSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbSize.Size = new System.Drawing.Size(133, 174);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size:";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(24, 125);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(52, 17);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(24, 88);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(61, 17);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(24, 51);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(49, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(191, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGreenPerpers);
            this.groupBox1.Controls.Add(this.chkTomatoes);
            this.groupBox1.Controls.Add(this.chkOlives);
            this.groupBox1.Controls.Add(this.chkMushrooms);
            this.groupBox1.Controls.Add(this.chkOnion);
            this.groupBox1.Controls.Add(this.chkExtraChees);
            this.groupBox1.Location = new System.Drawing.Point(249, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(229, 174);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toppings";
            // 
            // chkGreenPerpers
            // 
            this.chkGreenPerpers.AutoSize = true;
            this.chkGreenPerpers.Location = new System.Drawing.Point(139, 125);
            this.chkGreenPerpers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkGreenPerpers.Name = "chkGreenPerpers";
            this.chkGreenPerpers.Size = new System.Drawing.Size(91, 17);
            this.chkGreenPerpers.TabIndex = 5;
            this.chkGreenPerpers.Tag = "5";
            this.chkGreenPerpers.Text = "Green Pepers";
            this.chkGreenPerpers.UseVisualStyleBackColor = true;
            this.chkGreenPerpers.CheckedChanged += new System.EventHandler(this.chkGreenPerpers_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(15, 125);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(73, 17);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(139, 88);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(15, 88);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(139, 51);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Location = new System.Drawing.Point(14, 51);
            this.chkExtraChees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(85, 17);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkExtraChees_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.Controls.Add(this.rbThickCrust);
            this.gbCrust.Controls.Add(this.rbThinCrust);
            this.gbCrust.Location = new System.Drawing.Point(25, 259);
            this.gbCrust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCrust.Size = new System.Drawing.Size(133, 103);
            this.gbCrust.TabIndex = 3;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(24, 69);
            this.rbThickCrust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(78, 17);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Location = new System.Drawing.Point(24, 27);
            this.rbThinCrust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(74, 17);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Location = new System.Drawing.Point(247, 294);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbWhereToEat.Size = new System.Drawing.Size(250, 62);
            this.gbWhereToEat.TabIndex = 4;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(113, 27);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(69, 17);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Tag = "0";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(24, 27);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(54, 17);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.Tag = "0";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbOrderSummry
            // 
            this.gbOrderSummry.Controls.Add(this.gbTotalPricr);
            this.gbOrderSummry.Controls.Add(this.gbWhereToEatSummry);
            this.gbOrderSummry.Controls.Add(this.gbToppingsSummry);
            this.gbOrderSummry.Controls.Add(this.lbCrustInfo);
            this.gbOrderSummry.Controls.Add(this.lbCrustType);
            this.gbOrderSummry.Controls.Add(this.lbWhatIsSize);
            this.gbOrderSummry.Controls.Add(this.lbSize);
            this.gbOrderSummry.Location = new System.Drawing.Point(541, 70);
            this.gbOrderSummry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOrderSummry.Name = "gbOrderSummry";
            this.gbOrderSummry.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbOrderSummry.Size = new System.Drawing.Size(279, 352);
            this.gbOrderSummry.TabIndex = 5;
            this.gbOrderSummry.TabStop = false;
            this.gbOrderSummry.Text = "Order Summry";
            // 
            // gbTotalPricr
            // 
            this.gbTotalPricr.Controls.Add(this.lbTotalPrice);
            this.gbTotalPricr.Controls.Add(this.label4);
            this.gbTotalPricr.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTotalPricr.Location = new System.Drawing.Point(21, 250);
            this.gbTotalPricr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTotalPricr.Name = "gbTotalPricr";
            this.gbTotalPricr.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTotalPricr.Size = new System.Drawing.Size(243, 89);
            this.gbTotalPricr.TabIndex = 8;
            this.gbTotalPricr.TabStop = false;
            this.gbTotalPricr.Text = "Total Price:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lbTotalPrice.Location = new System.Drawing.Point(93, 29);
            this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(57, 39);
            this.lbTotalPrice.TabIndex = 1;
            this.lbTotalPrice.Text = "$0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 0;
            // 
            // gbWhereToEatSummry
            // 
            this.gbWhereToEatSummry.Controls.Add(this.lbWhereToEat);
            this.gbWhereToEatSummry.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEatSummry.Location = new System.Drawing.Point(21, 185);
            this.gbWhereToEatSummry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbWhereToEatSummry.Name = "gbWhereToEatSummry";
            this.gbWhereToEatSummry.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbWhereToEatSummry.Size = new System.Drawing.Size(243, 51);
            this.gbWhereToEatSummry.TabIndex = 7;
            this.gbWhereToEatSummry.TabStop = false;
            this.gbWhereToEatSummry.Text = "Where to Eat:";
            // 
            // lbWhereToEat
            // 
            this.lbWhereToEat.AutoSize = true;
            this.lbWhereToEat.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereToEat.Location = new System.Drawing.Point(82, 29);
            this.lbWhereToEat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWhereToEat.Name = "lbWhereToEat";
            this.lbWhereToEat.Size = new System.Drawing.Size(0, 13);
            this.lbWhereToEat.TabIndex = 0;
            // 
            // gbToppingsSummry
            // 
            this.gbToppingsSummry.Controls.Add(this.lbToppingsInfo);
            this.gbToppingsSummry.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppingsSummry.Location = new System.Drawing.Point(26, 79);
            this.gbToppingsSummry.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbToppingsSummry.Name = "gbToppingsSummry";
            this.gbToppingsSummry.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbToppingsSummry.Size = new System.Drawing.Size(243, 62);
            this.gbToppingsSummry.TabIndex = 6;
            this.gbToppingsSummry.TabStop = false;
            this.gbToppingsSummry.Text = "Toppings:";
            // 
            // lbToppingsInfo
            // 
            this.lbToppingsInfo.AutoSize = true;
            this.lbToppingsInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppingsInfo.Location = new System.Drawing.Point(37, 25);
            this.lbToppingsInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbToppingsInfo.MaximumSize = new System.Drawing.Size(167, 0);
            this.lbToppingsInfo.Name = "lbToppingsInfo";
            this.lbToppingsInfo.Size = new System.Drawing.Size(66, 13);
            this.lbToppingsInfo.TabIndex = 0;
            this.lbToppingsInfo.Text = "No Toppings";
            // 
            // lbCrustInfo
            // 
            this.lbCrustInfo.AutoSize = true;
            this.lbCrustInfo.Location = new System.Drawing.Point(109, 153);
            this.lbCrustInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCrustInfo.Name = "lbCrustInfo";
            this.lbCrustInfo.Size = new System.Drawing.Size(0, 13);
            this.lbCrustInfo.TabIndex = 5;
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(23, 153);
            this.lbCrustType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(74, 13);
            this.lbCrustType.TabIndex = 4;
            this.lbCrustType.Text = "Crust Type: ";
            // 
            // lbWhatIsSize
            // 
            this.lbWhatIsSize.AutoSize = true;
            this.lbWhatIsSize.Location = new System.Drawing.Point(63, 34);
            this.lbWhatIsSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWhatIsSize.Name = "lbWhatIsSize";
            this.lbWhatIsSize.Size = new System.Drawing.Size(0, 13);
            this.lbWhatIsSize.TabIndex = 1;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(18, 34);
            this.lbSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(33, 13);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Size:";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Location = new System.Drawing.Point(247, 394);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(75, 31);
            this.btnOrderPizza.TabIndex = 6;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.Location = new System.Drawing.Point(423, 394);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 31);
            this.btnResetForm.TabIndex = 7;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(25, 402);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(21, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter the number of pizza";
            // 
            // PizzaProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 452);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummry);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSize);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PizzaProject";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummry.ResumeLayout(false);
            this.gbOrderSummry.PerformLayout();
            this.gbTotalPricr.ResumeLayout(false);
            this.gbTotalPricr.PerformLayout();
            this.gbWhereToEatSummry.ResumeLayout(false);
            this.gbWhereToEatSummry.PerformLayout();
            this.gbToppingsSummry.ResumeLayout(false);
            this.gbToppingsSummry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkGreenPerpers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbOrderSummry;
        private System.Windows.Forms.GroupBox gbToppingsSummry;
        private System.Windows.Forms.Label lbCrustInfo;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbWhatIsSize;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbToppingsInfo;
        private System.Windows.Forms.GroupBox gbWhereToEatSummry;
        private System.Windows.Forms.Label lbWhereToEat;
        private System.Windows.Forms.GroupBox gbTotalPricr;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
    }
}

