using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterTest2
{
    internal class CBook:CItem
    {
        private int iPages;

        public int Pages
        {
            get { return iPages; }
            set
            {
                if (value <= 0)
                {
                    MessageBox.Show("Number of pages must be greater than 0", "Invalid Page number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new ArgumentOutOfRangeException(nameof(value), "Number of pages must be greater than 0");
                }
                else
                {
                    iPages = value;
                }
            }
        }

        public ItemType Type { get; set; }

        public CBook(ItemType types, string sTitle, string sAuthor, int iYear, int iPages) : base(sTitle, sAuthor, iYear)
        {
            Type = types;
            Pages = iPages;
        }
        public override string Describe()
        {
            return string.Format("{0} by {1} Year: {2} — Book, {3} Pages", base.Title, base.Author, base.Year, Pages);
        }
    }
}
