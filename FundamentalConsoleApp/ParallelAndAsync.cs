using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalConsoleApp;


//Thread pool assign task to thread and the thread holds the task until the task is completed is called blocking.
//thread pool assign task to thread and initiate the task in background and release the thread is called unblocking. it waits responce from task for completion.
//thread pool release and hold the thread according to async/parallel class or sequencial class.

internal class ParallelAndAsync
{
    //Parallel Programming
    //Ability to compute our tasks simultaniously in multiple CPU Cores.
    //not possible before 2003/2004. started duel core. real implimentation started after multicore. more benefits than uni-processor
    //pipelining scheduling time.
    //.net - TPL - Task Parallel libarary
    //Task, Task<> class
    //can only be performed if one data is not dependend to another. like in ComputeParallel and int[] 
    int[] numbers = [123, 234, 345, 456, 567, 678, 789, 890, 123, 234, 345, 456, 567, 678, 789, 890];
    public void ComputeSequencial()
    {
        Console.WriteLine("Computing in Sequence:");
        foreach (var number in numbers)
        {
            ComputeIfPrime(number);
        }
    }

    public void ComputeParallel()
    {
        Console.WriteLine("Computing in Parallel:");
        Parallel.ForEach(numbers, x => ComputeIfPrime(x));
    }
    private void ComputeIfPrime(int num)
    {
        Thread.Sleep(1000);
        Console.WriteLine($"Computing {num}... Done");
    }

    //Asynchronous Programming
    //doing things in background in non-blocking way(i/o).
    //proper candidate database and network request.
    //side effect is parallelism.
    //doesnt wait for request. behind the scene using parallel.
    //program working behind the scene.
    //browser can send 100 request.
    //async and await

    public async Task DoTask1()
    {
        await Task.Delay(1000);
    }
    public async Task<string> NetWorkCall()
    {
        HttpClient client = new HttpClient();
        var homePageContent= await client.GetStringAsync("https://www.youtube.com");
        return homePageContent;
    }
}
