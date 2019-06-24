using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson7B
{
    public partial class HelloWorldForm : Form
    {
        /// <summary>
        /// This is the HelloWorldForm Constructor
        /// </summary>
        public HelloWorldForm()
        {
            InitializeComponent();
            Start();
        }

        /// <summary>
        /// The start method is used for property initialization
        /// </summary>
        public void Start()
        {
            this.HelloWorldLabel.BackColor = Color.Black;
            this.HelloWorldLabel.ForeColor = Color.White;
            this.HelloWorldLabel.Text = "Hello, Harbin!";

        }

        /// <summary>
        /// This method is the event handler for the ClickMeButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = (HelloWorldLabel.Text == "Clicked!") ? "Unclicked!" : "Clicked!";

            GenerateRandomNunber();
        }

        /// <summary>
        /// This method generates a random integer from 1 to 49;
        /// </summary>
        private void GenerateRandomNunber()
        {
            Random _rand = new Random();
            int randomNo = _rand.Next(0, 49);
            //RandomNumberLabel.Text = (randomNo.ToString().Length == 1) ? "0" + randomNo.ToString() : randomNo.ToString();
            RandomNumberLabel.Text = (new Random().Next(1, 49) + 1).ToString();
        }

        private void HelloWorldForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
