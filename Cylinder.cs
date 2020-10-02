using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Cylinder
{
    public class Cylinder : Circle
    {

        private double height;


        public Cylinder()
        {
            this.height = 1.0;
        }
        public Cylinder(double height)
        {

            this.height = height;
        }
        public Cylinder(double height, double radius)
        {
            this.height = height;
        }
        public Cylinder(double height, double radius, string color)
        {
            this.height = height;
        }

        public double getHeight()
        {
            return this.height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }


        public double getVolume()
        {
            return getArea() * height;
        }


        public string _toString()
        {
            return "This is a Cylinder";
        }
    }
}