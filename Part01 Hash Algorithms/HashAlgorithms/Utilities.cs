namespace HashAlgorithms
{
    public static class Utilities
    {
        public static void ShowByteArray(byte[] bytOriginalData, string caption)
        {
            System.Console.WriteLine($"{caption} is:");

            System.Text.StringBuilder stringBuilder =
                new System.Text.StringBuilder();
            
            stringBuilder.Append("{");

            foreach (byte b in bytOriginalData)
            {
                stringBuilder.Append($" {b},");
            }
            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            stringBuilder.Append(" }");
            
            System.Console.WriteLine(stringBuilder.ToString());

            System.Console.WriteLine(System.Environment.NewLine);
        }
    }
}
