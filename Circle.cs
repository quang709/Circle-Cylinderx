using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Cylinder
{
    public class Circle
    {
        private double radius;
        private string color;
        public Circle()
        {
            this.radius = 1.0;
            this.color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
            this.color = "red";
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return this.radius;
        }
        public string getColor()
        {
            return this.color;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string toString()
        {
            return "Circle[radius=" + radius + ",color=" + color + "]";
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
    }
}