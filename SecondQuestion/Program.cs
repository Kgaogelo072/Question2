using System;

class Program
{
    static void Main()
    {
        int[] points = {1,2,3,1,2,3,1,2,3};
        //int[] points = {0,1,3,-2,0,1,0,-3,2,3};
        int deepestPitDepth = FindDeepestPitDepth(points);
        Console.WriteLine("Depth of the deepest pit: " + deepestPitDepth);
    }

    static int FindDeepestPitDepth(int[] points)
    {
        int deepestPitDepth = 0;
        int count = 0;
        while (count < points.Length - 2)
        {   
            if (points[count] > points[count+1] && points[count] >= 0)
            {  
                int top = count;
                int counter = 0;
                while (top+counter < points.Length - 2){
                    if (points[count+counter] < points[count+counter+1])
                    {
                        int bottom = count+counter;
                        counter = points.Length;
                        int counterer = 0;
                        while (bottom+counterer  <= points.Length - 2)
                        {
                            if (points[bottom+counterer] > points[bottom+counterer+1])
                            {
                                int end = bottom+counterer;
                                int pitDepth = Math.Min(points[top] - points[bottom], points[end] - points[bottom]);
                                deepestPitDepth = Math.Max(deepestPitDepth, pitDepth);
                                counterer = points.Length;
                            }
                            else if (bottom+counterer == points.Length-2){
                                int end = bottom+counterer;
                                int pitDepth = Math.Min(points[top] - points[bottom], points[end] - points[bottom]);
                                deepestPitDepth = Math.Max(deepestPitDepth, pitDepth);
                                counterer = points.Length;
                                Console.WriteLine(end);
                            }
                            counterer++;
                        }
                    }
                    counter++;
                }
            }
            count++;
        }
        if(deepestPitDepth==0)
        {
            return deepestPitDepth-1;
        }
        else{
            return deepestPitDepth;
        }
    }
}   


