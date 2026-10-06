using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterTest2
{
	public abstract class CItem
	{
		private string sTitle;

		public string Title
		{
			get { return sTitle; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					MessageBox.Show("Title is invalid", "Wrong Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					sTitle = value;
				}
			}
		}
		private string sAuthor;

		public string Author
		{
			get { return sAuthor; }
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					MessageBox.Show("Please enter the Author's name", "Invalid Author name", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					sAuthor = value;
				}
			}
		}
		private int iYear;

		public int Year
		{
			get { return iYear; }
			set
			{
				int iCurrentYear = DateTime.Now.Year;
				if (value < 1900 || value > iCurrentYear)
				{
					MessageBox.Show("Please enter the correct Year of release", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					iYear = value;
				}
			}
		}
        public static List<CItem> items;

        public static int Count { get; set; }

		public CItem(string sTitle, string sAuthor, int iYear)
		{
			Count++;
			Title = sTitle;
			Author = sAuthor;
			Year = iYear;
		}
		public abstract string Describe();
    }
}
