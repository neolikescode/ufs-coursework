using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace UniversityFacultyPerformance
{
    public partial class frmUniFacultyPerformance : Form
    {
        // Class-level variable to store the selected faculty
        string faculty;

        // String array to store faculty names
        string[] faculties =
        {
            "NAS",
            "Commerce",
            "Humanities"
        };
        // String array to store programme levels
        string[] programmes =
        {
            "Undergraduate",
            "Honours",
            "Masters",
            "Doctoral"
        };
        // ... array to store enrolment numbers for each faculty across four programme levels
        // Row index corresponds to faculty (0=Science, 1=Commerce, 2=Humanities)
        // Column index corresponds to programme level (0=Undergraduate, 1=Honours, 2=Masters, 3=Doctoral)
        // Science
        // Commerce
        // Humanities
        int[,] enrolmentNumbers =
        {
            {10000, 1000, 100, 10},
            {20000, 2000, 200, 20},
            {30000, 3000, 300, 30},
        };

        // Jagged array to store research projects for each faculty
        // Each faculty has a different number of research projects
        // Science research projects
        // Commerce research projects
        // Humanities research projects
        string[][] researchProjects =
        {
            new string[] {"Electricity", "Calculator", "Diamond Cutter", "Sky Scrapper"},
            new string[] {"AI Trader", "Forex", "Inflation Guesser"},
            new string[] {"Covid Mask", "HIV Cure"}
        };
        public frmUniFacultyPerformance()
        {
            InitializeComponent();
            // Select Science faculty by default when the form loads
            radScience.Checked = true;
            radScience.CheckedChanged += SelectedFaculty_CheckedChanged;
            radCommerce.CheckedChanged += SelectedFaculty_CheckedChanged;
            radHumanities.CheckedChanged += SelectedFaculty_CheckedChanged;
        }

        /// <summary>
        /// Displays enrolment numbers for the selected faculty in the lstEnrolment ListBox.
        /// </summary>
        /// <param name="facultyIndex">Index of the selected faculty</param>

        // Clear the ListBox before adding new data

        // Iterate through programmes and build display string
        private void DisplayEnrolment(int facultyIndex)
        {
            lstEnrolment.Items.Clear();

            for (int i = 0; i < programmes.Length; i++)
            {
                string enrolmentDetails = $"{programmes[i]}: {enrolmentNumbers[facultyIndex, i]} students";
                lstEnrolment.Items.Add(enrolmentDetails);
            }
        }

        /// <summary>
        /// Displays research projects for the selected faculty in the lstProjects ListBox.
        /// </summary>
        /// <param name="facultyIndex">Index of the selected faculty</param>

        // Clear the ListBox before adding new data

        // Iterate through the selected faculty's research projects
        private void DisplayProjects(int facultyIndex)
        {
            lstEnrolment.Items.Clear();

            foreach (string numbers in researchProjects[facultyIndex])
            {
                string display = $"Research Projects\n{numbers}";
                lstProjects.Items.Add(display);
            }

        }

        /// <summary>
        /// Shared event handler for all three RadioButton controls.
        /// Determines which faculty is selected and updates the display.
        /// </summary>
        private void SelectedFaculty_CheckedChanged(object sender, EventArgs e)
        {
            // Check which RadioButton is currently checked and store its text
            

            if (radScience.Checked)
            {
                faculty = radScience.Text;
            }
            else if (radCommerce.Checked)
            {
                faculty = radCommerce.Text;
            }
            else
            {
                faculty = radHumanities.Text;
            }

            // Use Array.IndexOf to find the index of the selected faculty
            int index = Array.IndexOf(faculties, faculty);
            // Call custom methods to display enrolment and research project data

            DisplayEnrolment(index);
            DisplayProjects(index);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
