namespace MakeFoldersGUI
{
    public partial class Form1 : Form
    {
        //Luke S. 4/25/2022
        //GUI version of a CLI app I made to automate creation of folders for online college classes

        public Form1()
        {
            InitializeComponent();
        }

        void createFolders(string filePath, string fName, int numberFolders)
        {
            for (int i = 1; i < numberFolders + 1; i++)
            {
                Directory.CreateDirectory(Path.Combine(filePath, fName + i.ToString()));
            }
        }

        private void FolderMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RadioSafetyOn.Checked == true)
                FolderMaxTextBox.ReadOnly = true;
            else if (RadioSafetyOff.Checked == true)
                FolderMaxTextBox.ReadOnly= false; ;

            string alertmessage = "Creating many folders at once can be dangerous. Exercise caution when altering the safety limit.";
            string caption = "Warning";
            MessageBox.Show(alertmessage, caption, MessageBoxButtons.OK);
        }


        private void MakeFoldersButton_Click(object sender, EventArgs e)
        {
            string filePath = FilePathTextBox.Text;
            filePath.Trim();
            string folderName = FolderNameTextBox.Text;
            folderName.Trim();
            string folderNumberText = FolderNumberTextBox.Text;
            folderNumberText.Trim();

            int maxFolderNumber = 12;
            var maxParseSuccess = int.TryParse(FolderMaxTextBox.Text, out maxFolderNumber);
            
            int folderNumber = 0;
            var parseSuccess = int.TryParse(folderNumberText, out folderNumber);

            bool safetyConflict = folderNumber < maxFolderNumber;

            bool filePathIsReal = Directory.Exists(filePath);
            bool folderNameIsValid = !(String.IsNullOrWhiteSpace(folderName) || String.IsNullOrEmpty(folderName));

            if (!parseSuccess)
            {
                string intmessage = "Please Input an integer value number of folders.";
                string caption = "Incorrect Input";
                MessageBox.Show(intmessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!maxParseSuccess)
            {
                string maxmessage = "Please input an integer maximum folder number to create.";
                string caption = "Incorrect Input";
                MessageBox.Show(maxmessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (folderNumber > maxFolderNumber)
            {
                string conflictmessage = "Please input a number of folders less than the allowed maximum.";
                string caption = "Conflicting Input";
                MessageBox.Show(conflictmessage, caption, MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            if (parseSuccess && maxParseSuccess && safetyConflict && folderNameIsValid && filePathIsReal)
            {
                createFolders(filePath, folderName, folderNumber);
                string exemessage = "Folders created, please check the filepath for new directories.";
                string caption = "Folders Made";
                MessageBox.Show(exemessage, caption, MessageBoxButtons.OK);
            }
        }

        private void RadioSafetyOn_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RadioSafetyOn.Checked == true)
                FolderMaxTextBox.ReadOnly = true;
            else if (RadioSafetyOff.Checked == true)
                FolderMaxTextBox.ReadOnly = false;

        }

        private void RadioSafetyOff_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioSafetyOff.Checked == true)
                FolderMaxTextBox.ReadOnly = false;
            else if (RadioSafetyOn.Checked == true)
                FolderMaxTextBox.ReadOnly = true;
        }
    }
}