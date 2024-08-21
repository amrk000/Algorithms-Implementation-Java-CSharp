using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Max Rectangle Squares Algorithm Implementation | From Repo: https://github.com/amrk000/Algorithms-Implementation-Java-CSharp
//by Amrk000 - No license or attribution required

//Algorithm that calc number of squares of maximum area that fit into a rectangle with a given width and height
//>Runtime Complexity: O(log(n)) where n is the min of x or y
public static class MaxRectSquares
{
    //calculate greatest common factor
    private static int Gcd(int x, int y)
    {
        int gcd = Math.Min(x, y); //pick the minimum of width and height
        while (gcd > 0)
        {
            if (x % gcd == 0 && y % gcd == 0) break; //loop until we find the nearest factor that divides x and y
            gcd--;
        }
        return gcd;
    }

    //calculate squares
    public static int GetSquares(int width, int height)
    {
        int squareSide = Gcd(width, height); //get square side width by GCD
        int rectArea = width * height; //calculate given rectangle area
        int squareArea = squareSide * squareSide; //calculate square area

        return rectArea / squareArea; //divide areas to get number of squares in rectangle
    }
}