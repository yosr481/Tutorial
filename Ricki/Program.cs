using System;

namespace Ricki
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			top:

			Console.WriteLine ("Please enter max amount for the bucket: ");
			int maxAmount = Convert.ToInt32(Console.ReadLine ());
			Console.WriteLine ("Please enter name for the bucket: ");
			string name = Console.ReadLine ();
			Bucket ricki = new Bucket (maxAmount, name);
			Console.WriteLine ("Please enter fill amount for the bucket: ");
			int currentAmount = Convert.ToInt32(Console.ReadLine ());

			ricki.Fill (currentAmount);

			Console.WriteLine ("Would you like to continue? (y/n)");
			if(Console.ReadLine() == "y")
				goto top;
		}
	}

	class Bucket{
		public int maxAmount;
		public string name;

		private int currentAmount = 0;

		public Bucket(){
			maxAmount = 0;
			name = "No Name";
		}

		public Bucket(int ma, string n){
			this.maxAmount = ma;
			this.name = n;
		}

		public void Fill(int amount){
			if(currentAmount + amount > maxAmount){
				Console.WriteLine("The amount you just input is greater then the max amount of the Bucket");
			}
			else{
				currentAmount += amount;
				Console.WriteLine("The current amount of {0} is {1} out of {2}", name, currentAmount.ToString(), maxAmount.ToString());
			}
		}
	}
}
