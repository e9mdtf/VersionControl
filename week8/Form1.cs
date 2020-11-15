using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week8.Abstractions;
using week8.Entities;

namespace week8
{
    public partial class Form1 : Form
    {
        private Toy _nextToy;
        private List<Toy> _toys = new List<Toy>();
        private IToyFactory _factory;
        public IToyFactory Factory
        {
            get { return _factory; }
            set { 
                _factory = value;
                DisplayNext();
            }
        }
        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            toy.Top = mainPanel.Height / 3;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (toy.Left > maxPosition)
                    maxPosition = toy.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestToy = _toys[0];
                mainPanel.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);
            }
        }

        private void carBtn_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void ballBtn_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory { 
                BallColor = colorBtn.BackColor
            };
        }
        private void DisplayNext()
        {
            if (_nextToy != null)
                mainPanel.Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = comingNextLabel.Top + comingNextLabel.Height + 20;
            _nextToy.Left = comingNextLabel.Left;
            mainPanel.Controls.Add(_nextToy);
        }

        private void colorBtn_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var colorPicker = new ColorDialog();

            colorPicker.Color = button.BackColor;
            if (colorPicker.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = colorPicker.Color;
        }

        private void presentBtn_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory
            {
                BoxColor = boxColorBtn.BackColor,
                RibbonColor = ribbonColorBtn.BackColor
            };
        }
    }
}
