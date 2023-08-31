using Azure.Storage.Queues;
using System.Threading.Tasks.Dataflow;
//https://vc0316.queue.core.windows.net/?sv=2022-11-02&ss=qt&srt=sco&sp=rwdlacup&se=2023-09-03T04:11:59Z&st=2023-08-30T20:11:59Z&spr=https&sig=LzTFUkCm%2BsjOiF7gwcjFGswM%2FbnWMyHK4BTe3PrHk%2Bg%3D
//This app sends messages to Victors azure queue
//Replace "i < XXX" to dictate number of messages sent

string connectionString = @"DefaultEndpointsProtocol=https;AccountName=vc0316;AccountKey=EtncGrpA7RkLfhOz5WuaA57bZ7jR4Gx/TgYfmGidUxfJL1qNdiTxnoca6GPK24Qi4NWUmFk5Mib2+AStC/IjOA==;EndpointSuffix=core.windows.net";

QueueClient queue = new QueueClient(connectionString, "barbie");
for (int i = 0; i < 100; i++)
{
    queue.SendMessageAsync($"Hello from Chris! {i}");
    Console.WriteLine($"Message #{i} has been sent.");
}
await Task.Delay(1000);
Console.WriteLine("Final message has been sent, press enter to end the program");
Console.ReadLine();


while (true)
{
    var batch = await queue.ReceiveMessagesAsync();
    foreach (var message in batch.Value)
    {
        Console.WriteLine(message);
        await queue.DeleteMessageAsync(message.MessageId, message.PopReceipt);
    }
    await Task.Delay(2000);

}