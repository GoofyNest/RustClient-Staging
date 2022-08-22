internal class BigInteger // TypeDefIndex: 80
{	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x163BB10 Offset: 0x163A110 VA: 0x18163BB10
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x163BA50 Offset: 0x163A050 VA: 0x18163BA50
	public void .ctor(BigInteger bi) { }

	// RVA: 0x163B560 Offset: 0x1639B60 VA: 0x18163B560
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x163B6D0 Offset: 0x1639CD0 VA: 0x18163B6D0
	public void .ctor(byte[] inData) { }

	// RVA: 0x163B640 Offset: 0x1639C40 VA: 0x18163B640
	public void .ctor(uint ui) { }

	// RVA: 0x163BE60 Offset: 0x163A460 VA: 0x18163BE60
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x163BEC0 Offset: 0x163A4C0 VA: 0x18163BEC0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x163C5D0 Offset: 0x163ABD0 VA: 0x18163C5D0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163C110 Offset: 0x163A710 VA: 0x18163C110
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x163C180 Offset: 0x163A780 VA: 0x18163C180
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BC70 Offset: 0x163A270 VA: 0x18163BC70
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163C1C0 Offset: 0x163A7C0 VA: 0x18163C1C0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163C4A0 Offset: 0x163AAA0 VA: 0x18163C4A0
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x163C0C0 Offset: 0x163A6C0 VA: 0x18163C0C0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x163C5C0 Offset: 0x163ABC0 VA: 0x18163C5C0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x163BB80 Offset: 0x163A180 VA: 0x18163BB80
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x163A1D0 Offset: 0x16387D0 VA: 0x18163A1D0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x163A400 Offset: 0x1638A00 VA: 0x18163A400
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x163AC50 Offset: 0x1639250 VA: 0x18163AC50
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x163AEE0 Offset: 0x16394E0 VA: 0x18163AEE0
	public void Randomize() { }

	// RVA: 0x1639CD0 Offset: 0x16382D0 VA: 0x181639CD0
	public int BitCount() { }

	// RVA: 0x163B010 Offset: 0x1639610 VA: 0x18163B010
	public bool TestBit(uint bitNum) { }

	// RVA: 0x163B060 Offset: 0x1639660 VA: 0x18163B060
	public bool TestBit(int bitNum) { }

	// RVA: 0x163AFC0 Offset: 0x16395C0 VA: 0x18163AFC0
	public void SetBit(uint bitNum) { }

	// RVA: 0x163AF40 Offset: 0x1639540 VA: 0x18163AF40
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x163AA20 Offset: 0x1639020 VA: 0x18163AA20
	public int LowestSetBit() { }

	// RVA: 0x163A460 Offset: 0x1638A60 VA: 0x18163A460
	public byte[] GetBytes() { }

	// RVA: 0x163BCB0 Offset: 0x163A2B0 VA: 0x18163BCB0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x163C020 Offset: 0x163A620 VA: 0x18163C020
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x163BD50 Offset: 0x163A350 VA: 0x18163BD50
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BF50 Offset: 0x163A550 VA: 0x18163BF50
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE40 Offset: 0x163A440 VA: 0x18163BE40
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163C0F0 Offset: 0x163A6F0 VA: 0x18163C0F0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE20 Offset: 0x163A420 VA: 0x18163BE20
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163C0D0 Offset: 0x163A6D0 VA: 0x18163C0D0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163B460 Offset: 0x1639A60 VA: 0x18163B460
	public string ToString(uint radix) { }

	// RVA: 0x163B110 Offset: 0x1639710 VA: 0x18163B110
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x163ABF0 Offset: 0x16391F0 VA: 0x18163ABF0
	private void Normalize() { }

	// RVA: 0x1639DA0 Offset: 0x16383A0 VA: 0x181639DA0
	public void Clear() { }

	// RVA: 0x163A630 Offset: 0x1638C30 VA: 0x18163A630 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x163B4B0 Offset: 0x1639AB0 VA: 0x18163B4B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1639E00 Offset: 0x1638400 VA: 0x181639E00 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x163AB50 Offset: 0x1639150 VA: 0x18163AB50
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x163AB60 Offset: 0x1639160 VA: 0x18163AB60
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x163A790 Offset: 0x1638D90 VA: 0x18163A790
	public bool IsProbablePrime() { }

	// RVA: 0x163A160 Offset: 0x1638760 VA: 0x18163A160
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x163A680 Offset: 0x1638C80 VA: 0x18163A680
	public void Incr2() { }

	// RVA: 0x163B4F0 Offset: 0x1639AF0 VA: 0x18163B4F0
	private static void .cctor() { }

}

public enum BigInteger.Sign // TypeDefIndex: 81
{	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;

}

internal sealed class BigInteger.ModulusRing // TypeDefIndex: 82
{	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1647410 Offset: 0x1645A10 VA: 0x181647410
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1646740 Offset: 0x1644D40 VA: 0x181646740
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1646EB0 Offset: 0x16454B0 VA: 0x181646EB0
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1646C60 Offset: 0x1645260 VA: 0x181646C60
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1647240 Offset: 0x1645840 VA: 0x181647240
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x16471C0 Offset: 0x16457C0 VA: 0x1816471C0
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 83
{	// Methods

	// RVA: 0x163E6A0 Offset: 0x163CCA0 VA: 0x18163E6A0
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x163DB90 Offset: 0x163C190 VA: 0x18163DB90
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x163E100 Offset: 0x163C700 VA: 0x18163E100
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163D3D0 Offset: 0x163B9D0 VA: 0x18163D3D0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163E5D0 Offset: 0x163CBD0 VA: 0x18163E5D0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x163C110 Offset: 0x163A710 VA: 0x18163C110
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x163D550 Offset: 0x163BB50 VA: 0x18163D550
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x163F550 Offset: 0x163DB50 VA: 0x18163F550
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163D870 Offset: 0x163BE70 VA: 0x18163D870
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x163E360 Offset: 0x163C960 VA: 0x18163E360
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x163DD20 Offset: 0x163C320 VA: 0x18163DD20
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x163DFF0 Offset: 0x163C5F0 VA: 0x18163DFF0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x163DED0 Offset: 0x163C4D0 VA: 0x18163DED0
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x163E960 Offset: 0x163CF60 VA: 0x18163E960
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x163EA90 Offset: 0x163D090 VA: 0x18163EA90
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

}

public class BigInteger // TypeDefIndex: 1763
{	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB04B0 Offset: 0x1AAEAB0 VA: 0x181AB04B0
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1AB0360 Offset: 0x1AAE960 VA: 0x181AB0360
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0280 Offset: 0x1AAE880 VA: 0x181AB0280
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1AAFF00 Offset: 0x1AAE500 VA: 0x181AAFF00
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0420 Offset: 0x1AAEA20 VA: 0x181AB0420
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0720 Offset: 0x1AAED20 VA: 0x181AB0720
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1AB0780 Offset: 0x1AAED80 VA: 0x181AB0780
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1AB0C20 Offset: 0x1AAF220 VA: 0x181AB0C20
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163C110 Offset: 0x163A710 VA: 0x18163C110
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1AB08F0 Offset: 0x1AAEEF0 VA: 0x181AB08F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0610 Offset: 0x1AAEC10 VA: 0x181AB0610
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0930 Offset: 0x1AAEF30 VA: 0x181AB0930
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB08E0 Offset: 0x1AAEEE0 VA: 0x181AB08E0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AB0C10 Offset: 0x1AAF210 VA: 0x181AB0C10
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AB0520 Offset: 0x1AAEB20 VA: 0x181AB0520
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1AAF4C0 Offset: 0x1AADAC0 VA: 0x181AAF4C0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1AAF390 Offset: 0x1AAD990 VA: 0x181AAF390
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1639CD0 Offset: 0x16382D0 VA: 0x181639CD0
	public int BitCount() { }

	// RVA: 0x1AAFA00 Offset: 0x1AAE000 VA: 0x181AAFA00
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163AFC0 Offset: 0x16395C0 VA: 0x18163AFC0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163AF40 Offset: 0x1639540 VA: 0x18163AF40
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1AAF8C0 Offset: 0x1AADEC0 VA: 0x181AAF8C0
	public int LowestSetBit() { }

	// RVA: 0x1AAF6F0 Offset: 0x1AADCF0 VA: 0x181AAF6F0
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163BCB0 Offset: 0x163A2B0 VA: 0x18163BCB0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163C020 Offset: 0x163A620 VA: 0x18163C020
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1AB0650 Offset: 0x1AAEC50 VA: 0x181AB0650
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0810 Offset: 0x1AAEE10 VA: 0x181AB0810
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE40 Offset: 0x163A440 VA: 0x18163BE40
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163C0F0 Offset: 0x163A6F0 VA: 0x18163C0F0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE20 Offset: 0x163A420 VA: 0x18163BE20
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163C0D0 Offset: 0x163A6D0 VA: 0x18163C0D0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AAFAB0 Offset: 0x1AAE0B0 VA: 0x181AAFAB0
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AAFB40 Offset: 0x1AAE140 VA: 0x181AAFB40
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x163ABF0 Offset: 0x16391F0 VA: 0x18163ABF0
	private void Normalize() { }

	// RVA: 0x163A630 Offset: 0x1638C30 VA: 0x18163A630 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AAFB00 Offset: 0x1AAE100 VA: 0x181AAFB00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AAEFC0 Offset: 0x1AAD5C0 VA: 0x181AAEFC0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1AAF9F0 Offset: 0x1AADFF0 VA: 0x181AAF9F0
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1AAF320 Offset: 0x1AAD920 VA: 0x181AAF320
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x163A680 Offset: 0x1638C80 VA: 0x18163A680
	public void Incr2() { }

	// RVA: 0x1AAFE90 Offset: 0x1AAE490 VA: 0x181AAFE90
	private static void .cctor() { }

}

public enum BigInteger.Sign // TypeDefIndex: 1764
{	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;

}

public sealed class BigInteger.ModulusRing // TypeDefIndex: 1765
{	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1AB9420 Offset: 0x1AB7A20 VA: 0x181AB9420
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1AB8750 Offset: 0x1AB6D50 VA: 0x181AB8750
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1AB8EC0 Offset: 0x1AB74C0 VA: 0x181AB8EC0
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB8C70 Offset: 0x1AB7270 VA: 0x181AB8C70
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB91D0 Offset: 0x1AB77D0 VA: 0x181AB91D0
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB93A0 Offset: 0x1AB79A0 VA: 0x181AB93A0
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 1766
{	// Methods

	// RVA: 0x1AB5E50 Offset: 0x1AB4450 VA: 0x181AB5E50
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x163DB90 Offset: 0x163C190 VA: 0x18163DB90
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x163E100 Offset: 0x163C700 VA: 0x18163E100
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163D3D0 Offset: 0x163B9D0 VA: 0x18163D3D0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163E5D0 Offset: 0x163CBD0 VA: 0x18163E5D0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x163C110 Offset: 0x163A710 VA: 0x18163C110
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x1AB55A0 Offset: 0x1AB3BA0 VA: 0x181AB55A0
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1AB6D00 Offset: 0x1AB5300 VA: 0x181AB6D00
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB58C0 Offset: 0x1AB3EC0 VA: 0x181AB58C0
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1AB5BE0 Offset: 0x1AB41E0 VA: 0x181AB5BE0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x163DFF0 Offset: 0x163C5F0 VA: 0x18163DFF0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x163DED0 Offset: 0x163C4D0 VA: 0x18163DED0
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1AB6110 Offset: 0x1AB4710 VA: 0x181AB6110
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1AB6240 Offset: 0x1AB4840 VA: 0x181AB6240
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }

}

public struct BigInteger : IFormattable, IComparable, IComparable<BigInteger>, IEquatable<BigInteger> // TypeDefIndex: 3963
{	// Fields
	internal readonly int _sign; // 0x0
	internal readonly uint[] _bits; // 0x8
	private static readonly BigInteger s_bnMinInt; // 0x0
	private static readonly BigInteger s_bnOneInt; // 0x10
	private static readonly BigInteger s_bnZeroInt; // 0x20
	private static readonly BigInteger s_bnMinusOneInt; // 0x30
	private static readonly byte[] s_success; // 0x40

	// Properties
	public static BigInteger Zero { get; }
	public bool IsZero { get; }

	// Methods

	// RVA: 0x237BE0 Offset: 0x236FE0 VA: 0x180237BE0
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x237BF0 Offset: 0x236FF0 VA: 0x180237BF0
	public void .ctor(uint value) { }

	// RVA: 0x237BC0 Offset: 0x236FC0 VA: 0x180237BC0
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x237BD0 Offset: 0x236FD0 VA: 0x180237BD0
	public void .ctor(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x237B00 Offset: 0x236F00 VA: 0x180237B00
	public void .ctor(byte[] value) { }

	// RVA: 0x237C10 Offset: 0x237010 VA: 0x180237C10
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0xFCAE0 Offset: 0xFBEE0 VA: 0x1800FCAE0
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x237C00 Offset: 0x237000 VA: 0x180237C00
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x2230470 Offset: 0x222EA70 VA: 0x182230470
	public static BigInteger get_Zero() { }

	// RVA: 0x237C40 Offset: 0x237040 VA: 0x180237C40
	public bool get_IsZero() { }

	// RVA: 0x222ED90 Offset: 0x222D390 VA: 0x18222ED90
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x222EE30 Offset: 0x222D430 VA: 0x18222EE30
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x237990 Offset: 0x236D90 VA: 0x180237990 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2378F0 Offset: 0x236CF0 VA: 0x1802378F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2378E0 Offset: 0x236CE0 VA: 0x1802378E0
	public bool Equals(long other) { }

	// RVA: 0x2378C0 Offset: 0x236CC0 VA: 0x1802378C0 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x2378B0 Offset: 0x236CB0 VA: 0x1802378B0
	public int CompareTo(long other) { }

	// RVA: 0x237890 Offset: 0x236C90 VA: 0x180237890 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x2377C0 Offset: 0x236BC0 VA: 0x1802377C0 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x2379F0 Offset: 0x236DF0 VA: 0x1802379F0
	public byte[] ToByteArray() { }

	// RVA: 0x237AC0 Offset: 0x236EC0 VA: 0x180237AC0
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x237A40 Offset: 0x236E40 VA: 0x180237A40 Slot: 3
	public override string ToString() { }

	// RVA: 0x237A80 Offset: 0x236E80 VA: 0x180237A80 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x222E600 Offset: 0x222CC00 VA: 0x18222E600
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x2231900 Offset: 0x222FF00 VA: 0x182231900
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x222EE90 Offset: 0x222D490 VA: 0x18222EE90
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x2231410 Offset: 0x222FA10 VA: 0x182231410
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231340 Offset: 0x222F940 VA: 0x182231340
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x2231390 Offset: 0x222F990 VA: 0x182231390
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x22313C0 Offset: 0x222F9C0 VA: 0x1822313C0
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x2231440 Offset: 0x222FA40 VA: 0x182231440
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231320 Offset: 0x222F920 VA: 0x182231320
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x2231370 Offset: 0x222F970 VA: 0x182231370
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x22313F0 Offset: 0x222F9F0 VA: 0x1822313F0
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x2231150 Offset: 0x222F750 VA: 0x182231150
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2230C40 Offset: 0x222F240 VA: 0x182230C40
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x2230E40 Offset: 0x222F440 VA: 0x182230E40
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2230BC0 Offset: 0x222F1C0 VA: 0x182230BC0
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x2230A40 Offset: 0x222F040 VA: 0x182230A40
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2230EC0 Offset: 0x222F4C0 VA: 0x182230EC0
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x2230770 Offset: 0x222ED70 VA: 0x182230770
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2230900 Offset: 0x222EF00 VA: 0x182230900
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x2230CC0 Offset: 0x222F2C0 VA: 0x182230CC0
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x22311D0 Offset: 0x222F7D0 VA: 0x1822311D0
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x2230F90 Offset: 0x222F590 VA: 0x182230F90
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x2231B70 Offset: 0x2230170 VA: 0x182231B70
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x22304E0 Offset: 0x222EAE0 VA: 0x1822304E0
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x2231560 Offset: 0x222FB60 VA: 0x182231560
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x22314B0 Offset: 0x222FAB0 VA: 0x1822314B0
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x2231480 Offset: 0x222FA80 VA: 0x182231480
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x2231520 Offset: 0x222FB20 VA: 0x182231520
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x22314E0 Offset: 0x222FAE0 VA: 0x1822314E0
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x2230750 Offset: 0x222ED50 VA: 0x182230750
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x2231460 Offset: 0x222FA60 VA: 0x182231460
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x2231540 Offset: 0x222FB40 VA: 0x182231540
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x2231500 Offset: 0x222FB00 VA: 0x182231500
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x222ED20 Offset: 0x222D320 VA: 0x18222ED20
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x222F640 Offset: 0x222DC40 VA: 0x18222F640
	private static void .cctor() { }

}

private enum BigInteger.GetBytesMode // TypeDefIndex: 3964
{	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;

}

