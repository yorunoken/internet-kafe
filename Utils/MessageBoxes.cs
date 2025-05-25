namespace Internet_Kafe_Proje.Utils
{
    class MessageBoxes
    {
        // Hata kutucuğu çıkart
        static internal void Error(string errorDesc)
        {
            MessageBox.Show(errorDesc, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Success kutucuğu çıkart
        static internal void Success(string successDesc)
        {
            MessageBox.Show(successDesc, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
