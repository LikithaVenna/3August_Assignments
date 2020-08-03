using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface
{
    interface IVolume
    {
        double Volume { get; }
    }
    interface IArea
    {
        double SurfaceArea();
    }
    interface ISolid : IVolume, IArea
    { }
    abstract class Solid : ISolid
    {
        public double radius;
        public const double pi = 3.142;
        public abstract double Volume
        {
            get;
        }

        public abstract double SurfaceArea();
        
        public Solid(double _radius,double _pi)
        {
            radius = _radius;
        }
    }
    class Cylinder : Solid
    {
        public double height;
        public Cylinder(double _height, double _radius,double _pi) : base(_radius,_pi)
        {
            height = _height;
        }
        public override double Volume 
        {
            get { return pi * radius * radius * height; }
        }
        public override double SurfaceArea()
        {
            return  2 * pi * radius * (radius + height);
           
        }
    }
    class Sphere : Solid
    {
        public Sphere(double _radius,double _pi):base(_radius,_pi)
        {

        }
        public override double Volume
        {
            get { return 4 * pi * radius * radius; }
        }
        public override double SurfaceArea()
        {
            return (4 / 3) * pi * radius * radius * radius;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder cy = new Cylinder(2.9, 6.5,3.14);
            Console.WriteLine("Voulme       of    Cylinder : {0}",cy.Volume);
            Console.WriteLine("Surface Area of    Cylinder : {0}", cy.SurfaceArea());
            Console.WriteLine("---------------------------------------------------");
            Sphere sp = new Sphere(4.5,3.14);
            Console.WriteLine("Voulme       of    Sphere : {0}",sp.Volume);
            Console.WriteLine("Surface Area of    Sphere : {0}",sp.SurfaceArea());
            Console.WriteLine("---------------------------------------------------");
            Console.ReadLine();
        } 
    }
}
