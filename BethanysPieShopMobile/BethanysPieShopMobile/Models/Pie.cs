using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BethanysPieShopMobile.Models
{
    public class Pie : INotifyPropertyChanged
    {
        private int id;
        private string pieName;
        private string description;
        private double price;
        private string imageUrl;
        private bool inStock;
        private DateTime availableFromDate;

        public int Id
        {
            get { return id; }
            set 
            {
                id = value;
                OnPropertyChanged();
            }
        }

        public string PieName
        {
            get { return pieName; }
            set 
            {
                pieName = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get { return description; }
            set 
            {
                description = value;
                OnPropertyChanged();
            }
        }

        public double Price
        {
            get { return price; }
            set 
            { 
                price = value;
                OnPropertyChanged();
            }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set 
            {
                imageUrl = value;
                OnPropertyChanged();
            }
        }

        public bool InStock
        {
            get { return inStock; }
            set 
            { 
                inStock = value;
                OnPropertyChanged();
            }
        }

        public DateTime AvailableFromDate
        {
            get { return availableFromDate; }
            set 
            { 
                availableFromDate = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
