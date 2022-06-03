﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelConsumtion;
        private double fuelQuantity;

        public Car()
        {

        }
        public double FuelConsumtion
        {
            get { return fuelConsumtion; }
            set { fuelConsumtion = value; }
        }
        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string WhoAmI()
        {
            string carInfo =
                $"Make: {this.Make}\r\n" +
                $"Model: {this.Model}\r\n" +
                $"Year: {this.Year}\r\n" +
                $"Fuel: {this.FuelQuantity:F2}L";
            return carInfo;
        }
        public void Drive(double distance)
        {
            if (this.FuelQuantity >= distance * this.FuelConsumtion)
            {
                this.FuelQuantity -= distance * this.FuelConsumtion;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
    }
}
