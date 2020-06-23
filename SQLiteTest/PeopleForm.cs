﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class PeopleForm : Form
    { 
      List<PersonModel> people = new List<PersonModel>();
    
        public PeopleForm()
        {
            InitializeComponent();

            LoadPeopleList();
        }

        private void LoadPeopleList()
        {
            people.Add(new PersonModel { FirstName = "Donald", LastName = "Duck" });
            people.Add(new PersonModel { FirstName = "Dolly", LastName = "Duck" });
            people.Add(new PersonModel { FirstName = "Mikke", LastName = "Mus" });

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
           
            listPeopleBox.DataSource = null;
            listPeopleBox.DataSource = people;
            listPeopleBox.DisplayMember = "FullName";

        }
        private void refreshListButton_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();

            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;

            people.Add(p);
            WireUpPeopleList();

            firstNameText.Text = "";
            lastNameText.Text = "";

        }



    }
}