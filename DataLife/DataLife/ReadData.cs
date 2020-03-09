using System;
using System.Xml;
using System.Collections.Generic;
using System.Text;

namespace DataLife
{
	[Serializable]
	public enum BOOK_TYPE
	{
		Technology,                 
		Literature,
		Sociology,
		History,
		Economy
	}

	[Serializable]
	public enum READ_STATUS
	{
		Start,
		Finish
	}

	[Serializable]
	public class ReadData : Singleton<ReadData>
	{
		List<ReadDataItem> listReadItems = new List<ReadDataItem>();

		public void StartRead(string bookName, string author, BOOK_TYPE type)
		{
			ReadDataItem item = new ReadDataItem(bookName, author, type, READ_STATUS.Start, beginTime: DateTime.Now);
			listReadItems.Add(item);
		}

		public void FinishRead(string bookName, int score)
		{
			var book = listReadItems.Find(item => item.BookName == bookName);
			if (book == null)
			{
				Console.WriteLine("There is no this book!");
				return;
			}
			else
			{
				book.Score = score;
				book.FinishRead();
			}
		}

		public void ShowAllBooks()
		{
			for (int i = 0; i < listReadItems.Count; i++)
			{
				Console.WriteLine("{0}.{1}", i + 1, listReadItems[i].BookName);
			}
		}

		public void SaveReadDataToXML()
		{
			XmlDocument xd = new XmlDocument();

			XmlDeclaration xdt = xd.CreateXmlDeclaration("1.0", "utf-8", null);
			xd.AppendChild(xdt); 


		}

	}

	[Serializable]
	public class ReadDataItem : BaseItem
	{
		private readonly string bookName;
		private readonly string author;

		private readonly BOOK_TYPE type;
		private READ_STATUS status;

		private int score;
		//Time
		private readonly DateTime beginTime;
		private DateTime endTime;

		public ReadDataItem(string bookName, string author, BOOK_TYPE type, READ_STATUS status, int score = -1, DateTime beginTime = new DateTime(), DateTime endTime = new DateTime())
		{
			this.bookName = bookName;
			this.author = author;
			this.type = type;
			this.status = status;
			this.score = score;
			this.beginTime = beginTime;
			this.endTime = endTime;
		}

		public string BookName { get => bookName; }
		public string Author { get => author; }

		public BOOK_TYPE Type { get => type; }
		public READ_STATUS Status { get => status; }

		public int Score { get => score; set => score = value; }

		public DateTime BeginTime { get => beginTime; }
		public DateTime EndTime { get => endTime; }

		public void FinishRead()
		{
			endTime = DateTime.Now;
			status = READ_STATUS.Finish;
		}
	}
}
