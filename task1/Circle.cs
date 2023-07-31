namespace AppCircle;
public class Circle{
    double _radius =0.1;
    string _color;
    public Circle(double radius,string color)
    {
        _radius = radius;
        _color = color;
    }
    public double GetRadius(){
        return _radius;
    }
    public void SetRadius(double r){
_radius=r;
    }
    public  string GetColor(){
        return _color;
    }

    public void SetRadius(string d){
_color=d;
    }
    public virtual string toString(){
     return $"radius -> {_radius} color -> {_color}";
    }
    public double  Area(){
        return 3.14*_radius*_radius;

    }
     }
