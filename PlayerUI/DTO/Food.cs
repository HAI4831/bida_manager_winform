﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanBida.DTO
{
    public class Food
    {
        private int id;
        private string name;
        private string idcategory;
        private int count;
        private double price;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Idcategory { get => idcategory; set => idcategory = value; }
        public int Count { get => count; set => count = value; }
        public double Price { get => price; set => price = value; }
        public string NameAndCount { get => $"{name} ({this.count})"; set => name = value; }

        public Food(DataRow row)
        {

            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Idcategory = row["idCategory"].ToString();
            this.Price = (double)Convert.ToDouble(row["price"].ToString());
            this.Count = (int)row["count"]; // Setting the 'Count' property
        }
    }
}
