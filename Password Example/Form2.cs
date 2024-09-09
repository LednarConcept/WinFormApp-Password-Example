using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Example
{
    public partial class Form2 : Form
    {

        System.Windows.Forms.Timer gameTimer = new System.Windows.Forms.Timer(); // Create a Timer that will be used to loop the game

        public Form2()
        {
            InitializeComponent();

            gameTimer.Interval = 1000; // 1000ms ~ 1 Update Per Second
            gameTimer.Tick += new EventHandler(GameLoop);  // Attach the game loop to the timer
            gameTimer.Start();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            Update(); // This function is fired every 1 second
        }

        // Create integer values
        int cookies = 0; // This will be the ingame currency
        int clickLevel = 1; // This will be the level of click
        int clickUpcost = 100; // This will be the upgrade cost
        int clickPower = 1; // This is the power of the click
        int grandmaLevel = 0; // Others will start as level 0 as to not earn when unbought
        int grandmaUpcost = 15;
        int grandmaPower = 1;
        int cookLevel = 0;
        int cookUpcost = 500;
        int cookPower = 25;
        int vendorLevel = 0;
        int vendorUpcost = 5000;
        int vendorPower = 500;
        int restaurantLevel = 0;
        int restaurantUpcost = 30000;
        int restaurantPower = 7500;
        int factoryLevel = 0;
        int factoryUpcost = 200000;
        int factoryPower = 80000;

        void Update()
        {
            cookies += grandmaLevel * grandmaPower; // level times power equals income
            cookies += cookLevel * cookPower;
            cookies += vendorLevel * vendorPower;
            cookies += restaurantLevel * restaurantPower;
            cookies += factoryLevel * factoryPower;
            lbl_cookieCount.Text = "Cookies: " + cookies.ToString(); // Update the cookie text
        }

        private void btn_bake_click(object sender, EventArgs e)
        {
            cookies += clickLevel; // Add cookies amount to the level of click
            lbl_cookieCount.Text = "Cookies: " + cookies.ToString();
        }

        private void btn_ClickUpgrade_Click(object sender, EventArgs e)
        {
            if (cookies >= clickUpcost) // Is cookies equal or more than the upgrade cost?
            {
                cookies -= clickUpcost; // Subtract the cookies with upgrade cost
                clickUpcost += (int)(clickUpcost * 1.2f); // Increase the price of upgrade
                clickLevel += 1; // Increase the level of upgrade
                // Update the text values to match the current state of each value
                lbl_ClickUpgrade.Text = "Click Level: " + clickLevel;
                lbl_ClickPower.Text = "Power: " + (clickLevel * clickPower) + "/click";
                btn_ClickUpgrade.Text = "" + clickUpcost + " Cookies";
                lbl_cookieCount.Text = "Cookies: " + cookies.ToString();
            }
        }

        private void btn_GrandmaUpgrade_Click(object sender, EventArgs e)
        {
            if (cookies >= grandmaUpcost)
            {
                cookies -= grandmaUpcost;
                grandmaUpcost += (int)(grandmaUpcost * 0.3f);
                grandmaLevel += 1;
                lbl_GrandmaUpgrade.Text = "Grandma Level: " + grandmaLevel;
                lbl_GrandmaPower.Text = "Power: " + (grandmaLevel * grandmaPower) + "/s";
                btn_GrandmaUpgrade.Text = "" + grandmaUpcost + " Cookies";
                lbl_cookieCount.Text = "Cookies: " + cookies.ToString();
            }
        }

        private void btn_CookUpgrade_Click(object sender, EventArgs e)
        {
            if (cookies >= cookUpcost)
            {
                cookies -= cookUpcost;
                cookUpcost += (int)(cookUpcost * 0.3f);
                cookLevel += 1;
                lbl_CookUpgrade.Text = "Cook Level: " + cookLevel;
                lbl_CookPower.Text = "Power: " + (cookLevel * cookPower) + "/s";
                btn_CookUpgrade.Text = "" + cookUpcost + " Cookies";
                lbl_cookieCount.Text = "Cookies: " + cookies.ToString();
            }
        }

        private void btn_VendorUpgrade_Click(object sender, EventArgs e)
        {
            if (cookies >= vendorUpcost)
            {
                cookies -= vendorUpcost;
                vendorUpcost += (int)(vendorUpcost * 0.3f);
                vendorLevel += 1;
                lbl_VendorUpgrade.Text = "Vendor Level: " + vendorLevel;
                lbl_VendorPower.Text = "Power: " + (vendorLevel * vendorPower) + "/s";
                btn_VendorUpgrade.Text = "" + vendorUpcost + " Cookies";
                lbl_cookieCount.Text = "Cookies: " + cookies.ToString();
            }
        }

        private void btn_RestaurantUpgrade_Click(object sender, EventArgs e)
        {
            if (cookies >= restaurantUpcost)
            {
                cookies -= restaurantUpcost;
                restaurantUpcost += (int)(restaurantUpcost * 0.3f);
                restaurantLevel += 1;
                lbl_RestaurantUpgrade.Text = "Restaurant Level: " + restaurantLevel;
                lbl_RestaurantPower.Text = "Power: " + (restaurantLevel * restaurantPower) + "/s";
                btn_RestaurantUpgrade.Text = "" + restaurantUpcost + " Cookies";
                lbl_cookieCount.Text = "Cookies: " + cookies.ToString();
            }
        }

        private void btn_FactoryUpgrade_Click(object sender, EventArgs e)
        {
            if (cookies >= factoryUpcost)
            {
                cookies -= factoryUpcost;
                factoryUpcost += (int)(factoryUpcost * 0.3f);
                factoryLevel += 1;
                lbl_FactoryUpgrade.Text = "Factory Level: " + factoryLevel;
                lbl_FactoryPower.Text = "Power: " + (factoryLevel * factoryPower) + "/s";
                btn_FactoryUpgrade.Text = "" + factoryUpcost + " Cookies";
                lbl_cookieCount.Text = "Cookies: " + cookies.ToString();
            }
        }
    }
}
