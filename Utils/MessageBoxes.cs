﻿namespace Internet_Kafe_Proje.Utils
{
    class MessageBoxes
    {
        static internal void ErrorBox(string errorDesc)
        {
            MessageBox.Show(errorDesc, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static internal void SuccessBox(string successDesc)
        {
            MessageBox.Show(successDesc, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
