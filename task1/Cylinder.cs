



namespace ACylinder;
using AppCircle;

public class Cylinder:Circle{
        double _height ;
  

    public Cylinder(double height,double radius,
           string color):base(radius,color)
           {   
                _height=height;
                
           }
           public double GetHeight(){
                return _height;
           }

           public void SetHeight(double r){
                r=_height;
                 }
    public override string ToString()
    {
        return $"height-{_height} color-{GetColor()}   radius-{GetRadius()}";
    }
    public double GetVolume(){
        return 3.14*_height*_height;
    }

}