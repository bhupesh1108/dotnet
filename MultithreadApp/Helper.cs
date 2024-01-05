namespace Util;
using System.Threading;
public static class Helper{
 
        public static  async  Task  StoreData(){
         
              await Task.Run(()=>{
                for(int i=0;i<5;i++){
                         Console.WriteLine("thread 1");
                         
                }
                   
                    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });
        }

        public static  async  Task  GetRemoteData(){
             await Task.Run(()=>{
                Console.WriteLine("thread 2");
                 Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            });
        }


}