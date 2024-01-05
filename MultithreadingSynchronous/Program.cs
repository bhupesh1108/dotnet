using Utility;
using System.Threading;


ThreadStart  job1=new ThreadStart(Helper.Operation1);
Thread th1=new Thread(job1);
th1.Start();

ThreadStart  job2=new ThreadStart(Helper.Operation2);
Thread th2=new Thread(job2);
th2.Start();

