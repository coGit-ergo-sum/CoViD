using System;
using System.Collections.Generic;
using System.Text;

namespace CL.Extensions.Random
{
	public static class Methods
	{
		public static int Next(this System.Random rnd, int min, int max, SByte iterations)
		{
			int tot = 0;
			for (sbyte i = 0; i < iterations; i++)
			{
				tot += rnd.Next(min, max);
			}
			return tot / iterations;
		}

	}
}
