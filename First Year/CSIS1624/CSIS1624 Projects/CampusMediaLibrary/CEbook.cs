/*Neo Kgatla
 *2029139488
 *2025 Semester Test 2 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterTest2
{
    // Provided
    public class CEbook : CItem
    {
        private string sFormat;

        public string Format
        {
            get { return sFormat; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Format cannot be empty.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sFormat = value; 
            }
        }

        public ItemType Type { get; set; }

        public CEbook(ItemType _ItemType, string title, string author, int year, string format)
            : base(title, author, year)
        {
            Type = _ItemType;
            Format = format;
        }

        public override string Describe()
        {
            return string.Format("{0} by {1} Year: {2} — EBook, {3} Format", base.Title, base.Author, base.Year, Format);
        }
    }
}
