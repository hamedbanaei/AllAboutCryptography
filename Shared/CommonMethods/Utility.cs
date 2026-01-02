namespace CommonMethods;

public static class Utility
{
	public static void ShowData(byte[] data, string caption)
	{
		System.Console.WriteLine($"{caption} is:");

		System.Text.StringBuilder stringBuilder =
			new System.Text.StringBuilder();

		stringBuilder.Append("{");

		foreach (byte b in data)
		{
			stringBuilder.Append($" {b},");
		}
		stringBuilder.Remove(stringBuilder.Length - 1, 1);
		stringBuilder.Append(" }");

		System.Console.WriteLine(stringBuilder.ToString());

		System.Console.WriteLine(System.Environment.NewLine);
	}

	public static void ShowData(string data, string caption)
	{
		System.Console.WriteLine($"{caption} is:");

		System.Console.WriteLine(data);

		System.Console.WriteLine(System.Environment.NewLine);
	}
}
