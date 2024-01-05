namespace  Utility;
using System.IO;


public static class Helper{

    public static void Operation1(){
        int count=0;
        while(count<5){
            count ++;
            Console.WriteLine("First Thread");
            Thread.Sleep(1000);
        
            Thread th1=Thread.CurrentThread;


        }
    }



    public static void Operation2(){
        int count=0;
        while(count<5){
            count++;
            Console.WriteLine("second Thread");
            Thread.Sleep(2000);
         
            Thread th1=Thread.CurrentThread;
          
        }
    }
}