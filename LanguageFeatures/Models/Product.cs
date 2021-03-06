﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        private int productID;
        private string name;
        private string description;
        private decimal price;
        private string category;
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }
        public string Name
        {
            get
            {
                return ProductID + name;
            }
            set
            {
                name = value;
            }
        }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { set; get; }

    }
}