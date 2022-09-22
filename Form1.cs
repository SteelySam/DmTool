using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DmTool
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            cmbLocation.SelectedIndex = 10;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if(radWeather.Checked)
            {
                GenerateTemperature();
                GenerateWind();
                GeneratePrecipitation();
            }

            if(radEncounter.Checked)
            {
                GenerateEncounter();
            }

            if(radLoot.Checked)
            {
                GenerateLoot();
            }

            if(radNpc.Checked)
            {
                GenerateNpc();
            }
        }

        public void GenerateTemperature()
        {
            int randTemp = rnd.Next(20) + 1;
            int randDegree = rnd.Next(4) + 1;
            int randFahrenheit = randDegree * 10;
            int randCelcius = randDegree * 5;

            string normTemp = "Normal for the season.";
            string hotTemp = randFahrenheit.ToString() + "F/" + randCelcius + "C" + " degrees hotter than normal.";
            string coldTemp = randFahrenheit.ToString() + "F/" + randCelcius + "C" + " degrees colder than normal.";

            if(randTemp > 14 && randTemp < 18)
            {
                txtResult.Text = "Temperature: " + coldTemp + Environment.NewLine;
            }
            else if(randTemp >= 18)
            {
                txtResult.Text = "Temperature: " + hotTemp + Environment.NewLine;
            }
            else
            {
                txtResult.Text = "Temperature: " + normTemp + Environment.NewLine;
            }
        }

        public void GenerateWind()
        {
            int randWind = rnd.Next(20) + 1;
            string normWind = "no wind";
            string strongWind = "strong wind";
            string lightWind = "light wind";

            if (randWind > 12 && randWind < 18)
            {
                txtResult.AppendText("Wind: " + lightWind + Environment.NewLine);
            }
            else if (randWind >= 18)
            {
                txtResult.AppendText("Wind: " + strongWind + Environment.NewLine);
            }
            else
            {
                txtResult.AppendText("Wind: " + normWind + Environment.NewLine);
            }
        }

        public void GeneratePrecipitation()
        {
            int randPrecip = rnd.Next(20) + 1;
            string normPrecip = "no rain or snowfall";
            string lightPrecip = "light rain or snowfall";
            string heavyPrecip = "heavy rain or snowfall";

            if (randPrecip > 12 && randPrecip < 18)
            {
                txtResult.AppendText("Precipitation: " + lightPrecip + Environment.NewLine);
            }
            else if (randPrecip >= 18)
            {
                txtResult.AppendText("Precipitation: " + heavyPrecip + Environment.NewLine);
            }
            else
            {
                txtResult.AppendText("Precipitation: " + normPrecip + Environment.NewLine);
            }
        }

        public void GenerateEncounter()
        {
            // lol nope...
            txtResult.Text = "here is an encounter...";
        }

        public void GenerateLoot()
        {
            // generate some loot...
            txtResult.Text = "here is some loot...";
        }

        public void GenerateNpc()
        {
            // generate an npc...
            txtResult.Text = "here is an NPC...";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}