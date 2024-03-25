namespace zhelotti
{
	internal class Program
	{
		enum Napok {Hétfő,Kedd,Szerda,Csütörtök,Péntek,Szombat,Vasárnap };
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			string s = Console.ReadLine();
			string[] d = s.Split();
			//foreach(var item in d)
			//cw(item)
			//replace-fullosan
			//trim
			/*
			for(int i=0; i<d.Length; i++)
			{
				if (d[i].Length > 0)
				{
					Console.WriteLine($"{i}:{d[i]}###");
				}
			}
			Napok n;

			n = Napok.Szerda;

			if(n==Napok.Szombat || n== Napok.Vasárnap)
			{
				Console.WriteLine("Ez hétvége...");
			}
			else
			{
				Console.WriteLine("Ez hétköznap");
			}
			*/
			StreamReader sr=new StreamReader("c://Munka//VS//zhelotti//teszt.txt");
			while(!sr.EndOfStream)
			{
				string sor=sr.ReadLine();
				Console.WriteLine(sor);
			}
		}
	}
}
