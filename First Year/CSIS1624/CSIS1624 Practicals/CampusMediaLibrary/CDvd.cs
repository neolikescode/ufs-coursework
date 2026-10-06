/*Neo Kgatla
 *2029139488
 *2025 Semester Test 2 
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterTest2
{
    // Provided
    public class CDvd : CItem
    {
        private string sRegion;

        public string Region
        {
            get { return sRegion; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    MessageBox.Show("Region cannot be empty.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sRegion = value;
            }
        }
        public ItemType Type { get; set; }

        public CDvd(ItemType _ItemType, string title, string author, int year, string region)
            : base(title, author, year)
        {            
            Type = _ItemType;
            Region = region;
        }

        public override string Describe()
        {
            return string.Format("{0} by {1} Year: {2} — Dvd, {3} Region", base.Title, base.Author, base.Year, Region);
        }
    }
}
