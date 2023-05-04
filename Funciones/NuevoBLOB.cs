using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Funciones
{
    public class NuevoBLOB
    {
        [FunctionName("NuevoBLOB")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "")]Stream myBlob, string name, ILogger log)
        {
            Console.WriteLine($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }

        [FunctionName("TimerTrigger")]
        [return: Queue("myqueue-items")]
        public static string RunTimerTrigger([TimerTrigger("*/15 * * * * *")] TimerInfo myTimer, ILogger log) {
            if(myTimer.IsPastDue) {
                log.LogInformation("Timer is running late!");
            }
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            return $"C# Timer trigger function executed at: {DateTime.Now}";
        }

        [FunctionName("QueueTrigger")]
        public static void QueueTrigger([QueueTrigger("myqueue-items")] string myQueueItem, ILogger log) {
            log.LogInformation($"C# function processed: {myQueueItem}");
            Console.WriteLine(myQueueItem);
        }

    }
}
