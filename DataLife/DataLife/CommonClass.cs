using System;
using System.Collections.Generic;
using System.Text;

namespace DataLife
{
	public class BaseItem
	{
		protected DateTime recordTime;

		public BaseItem()
		{
			this.recordTime = DateTime.Now;
		}

		public DateTime GetRecordTime()
		{
			return recordTime;
		}

		public void UpdateRecordTime(DateTime dateTime)
		{
			recordTime = dateTime;
		}
	}

}
