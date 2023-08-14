namespace CS2023
{
    static class Async1Test
    {
        public static async Task Test()
        {
            Async1 async1 = new Async1();
            Console.WriteLine(await async1.RetrieveDocsHomePage());
            Console.WriteLine("test2");
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
    }


}