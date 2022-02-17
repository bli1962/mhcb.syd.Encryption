// Decompiled with JetBrains decompiler
// Type: LS_Krypting.Encryption
// Assembly: LS_Krypting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=607ae834e67b5c9f
// MVID: 5609D702-AABB-4E7A-B54F-7633A9B66664
// Assembly location: D:\Temp\LS_Krypting.dll

// Decode by Ben Li via dotPeek tools

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace mhcb.syd.Encryption
{
	public class Krypting
	{
		public static string Encrypt(string sPassword)
		{

			string str1 = (string)null;
			VBMath.Randomize();
			string str2 = Strings.Format((object)checked((int)Math.Round((double)Conversion.Int((float)unchecked(100000000.0 * (double)VBMath.Rnd() + 1.0)))), "0000");
			string str3 = Strings.Format((object)checked((int)Math.Round((double)Conversion.Int((float)unchecked(100000000.0 * (double)VBMath.Rnd() + 1.0)))), "0000");
			string str4 = Strings.Format((object)checked((int)Math.Round((double)Conversion.Int((float)unchecked(100000000.0 * (double)VBMath.Rnd() + 1.0)))), "0000");
			string str5 = Strings.Format((object)checked((int)Math.Round((double)Conversion.Int((float)unchecked(100000000.0 * (double)VBMath.Rnd() + 1.0)))), "0000");
			string str6 = Strings.Mid(str2, 4, 4) + Strings.Mid(str3, 4, 4) + Strings.Mid(str4, 4, 4) + Strings.Mid(str5, 4, 4);
			int num = Strings.Len(sPassword);

			int Start = 1;
			while (Start <= num)
			{
				str1 = str1 + Strings.Format((object)Strings.Asc(Strings.Mid(sPassword, Start, 1)), "000") + Strings.Mid(str6, Start, 1);
				checked { ++Start; }
			}

			return Strings.Format((object)Conversions.ToInteger(Strings.Mid(Strings.Format((object)checked((int)Math.Round((double)Conversion.Int((float)unchecked(100000000.0 * (double)VBMath.Rnd() + 1.0)))), "0000"), 4, 4)), "0000") + str1;
		}

		public static string Decrypt(string sEncPassword)
		{
			string str1 = (string)null;
			string str2 = (string)null;
			int num1 = 0;
			num1 = 1;

			sEncPassword = Strings.Mid(sEncPassword, 5);
			int num2 = Strings.Len(sEncPassword);
			for (int Start = 1; Start <= num2; Start = checked(Start + 1 + 3))
				str2 += Strings.Mid(sEncPassword, Start, 3);

			int num3 = Strings.Len(str2);
			int Start1 = 1;
			while (Start1 <= num3)
			{
				str1 += Conversions.ToString(Strings.Chr(Conversions.ToInteger(Strings.Mid(str2, Start1, 3))));
				checked { Start1 += 3; }
			}
			return str1;
		}
	}
}
