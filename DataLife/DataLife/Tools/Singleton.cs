using System;
using System.Collections.Generic;
using System.Text;

namespace DataLife
{
	public class Singleton<T> where T : new()
	{
		private static T singleton;

		private static Object sync = new Object();

		public static T GetInstance()
		{
			if (singleton == null)
			{
				lock (sync)
				{
					singleton = new T();
				}
			}

			return singleton;
		}

	}
}
