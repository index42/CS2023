namespace CS2023
{
    static class Async1Test
    {
        public static void Test()
        {

            Async1 async1 = new Async1();
            Async1.AsyncConsoleWork().GetAwaiter().GetResult();
            //Console.WriteLine(await async1.RetrieveDocsHomePage());
        }

    }
    class Async1
    {
        public async Task<int> RetrieveDocsHomePage()
        {
            var client = new HttpClient();
            Console.WriteLine("test1");
            byte[] content = await client.GetByteArrayAsync("https://learn.microsoft.com/");
            Thread.Sleep(5000);
            Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished downloading.");
            return content.Length;
        }
        public static async Task<int> AsyncConsoleWork()
        {
            var client = new HttpClient();
            await client.GetByteArrayAsync("https://learn.microsoft.com/");
            // Main body here
            return 0;
        }
    }


}