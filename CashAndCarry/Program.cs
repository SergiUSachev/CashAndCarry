namespace CashAndCarry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int shopAccount = 0;
			int[] clientsData = new int[] { 1200, 5600, 2400, 5200, 12, 2, 10050 };
			Queue<int> clients = new Queue<int>();
			foreach (var item in clientsData)
			{
				clients.Enqueue(item);
			}

			for (int i = clients.Count - 1; i >= 0; i--)
			{
				shopAccount+= clients.Peek();
				Console.WriteLine(shopAccount);
				clients.Dequeue();
				Console.ReadKey();

			}


		}
	}
}