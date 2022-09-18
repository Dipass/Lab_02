using System;

class GFG
{
	static int End(string X, string Y,int f, int s)
	{
		int result = 0;
		int[,] Arr = new int[f + 1, s + 1];
		for (int i = 0; i < f; i++)
		{
			for (int j = 0; j < s; j++)
			{
				if (i == 0 || j == 0)
				{
					Arr[i, j]=0;
				}
				else if (X[i - 1] == Y[j - 1])
				{
					Arr[i, j] = Arr[i - 1, j - 1] + 1;
					result = Math.Max(result, Arr[i, j]);
				}
				else
					Arr[i, j]=0;
			}
		}
		return result;
    }

        // Driver code
     public static void Main()
	{
		int f, s;
		String X = "hi php java csharp sql html css js";
		String Y = "hi php java js softuni nakov java learn";

		f = X.Length;
		s = Y.Length;

		Console.Write(End(X, Y, f, s));
	}
}

// This code is contributed by Rajput-JI
