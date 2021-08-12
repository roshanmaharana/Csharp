

  class Circle
  {
  	double rad;
    public void setRadius(double r)
    {
    	this.rad=r;
    }
    
    public double getRadius()
    {
    	return rad;
    }
    
    public double calcDiameter()
    {
    	return 2*rad;
    }
    
    public double calcArea()
    {
    	return 3.14159*rad*rad;
    }
  }
  
  class driverCircle
  {
  	static void Main(string[] args)
    {
    	Console.Write("Enter Radius of Circe:");
        double r=double.Parse(Console.ReadLine());
        
        Circle c=new Circle();
        c.setRadius(r);
    
        
        
        Console.WriteLine("Radius: ",c.getRadius());
        Console.WriteLine("Diameter: ",c.calcDiameter());
        Console.WriteLine("Area: ",c.calcArea());
        
    }
  }
}


