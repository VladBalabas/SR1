using System;
using System.Collections.Generic;
using System.ComponentModel;
using SR1.Models;
using SR1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SR1.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}