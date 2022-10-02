using System; 

public class Program {
  static double var_ten(){
    float x = float.Parse(Console.ReadLine());
    float y = float.Parse(Console.ReadLine());
    if(x<=4 && y <=5){
      if(x*x+y*y>=16){
        return 1 - Math.Abs(1-x*y);
      }
    }
    return x*x-5;
  }
  public static void Main() {
    Console.WriteLine(var_ten());
  }
}
