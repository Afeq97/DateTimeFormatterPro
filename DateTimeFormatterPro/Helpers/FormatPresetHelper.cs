using System.Windows.Forms;

namespace DateTimeFormatterPro.Helpers
{
    public static class FormatPresetHelper
    {
        public static void Load(ComboBox comboBox)
        {
            comboBox.Items.Clear();

            comboBox.Items.Add("Date Only");
            comboBox.Items.Add("Time Only");
            comboBox.Items.Add("Full Date Time");
            comboBox.Items.Add("European Date");
            comboBox.Items.Add("US Date");

            comboBox.SelectedIndex = 2;
        }

        public static string GetFormat(string preset)
        {
            switch (preset)
            {
                case "Date Only":
                    return "yyyy-MM-dd";

                case "Time Only":
                    return "HH:mm:ss";

                case "Full Date Time":
                    return "yyyy-MM-dd HH:mm:ss";

                case "European Date":
                    return "dd/MM/yyyy";

                case "US Date":
                    return "MM/dd/yyyy";

                default:
                    return "";
            }
        }
    }
}