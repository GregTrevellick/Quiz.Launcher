using System;
using System.Windows.Forms;

namespace Quiz.Core
{
    public class MessageBoxes
    {
        public static bool ConfirmCloseWithoutSubmitingAnswer(string optionsName)
        {
            var result = false;

            var box = MessageBox.Show(
                $"You clicked the 'Close' button without having submitted your answer - are you sure ?{Environment.NewLine}{Environment.NewLine}You can disable this warning in Tools | Options | {optionsName}",
                optionsName,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (box == DialogResult.OK)
            {
                result = true;
            }

            return result;
        }

        public static void DisplayInvalidIntegerError(string labelName, string caption)
        {
            MessageBox.Show(
                Constants.GetInvalidInteger(labelName),
                caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public static bool ConfirmProceedToSaveTimeOutInMilliSeconds(string caption)
        {
            var proceedToSave = false;

            var box = MessageBox.Show(
                Constants.TimeOutInMilliSecondsIsOutsideRecommendedTimeoutLimits,
                caption,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            if (box == DialogResult.OK)
            {
                proceedToSave = true;
            }

            return proceedToSave;
        }
    }
}
