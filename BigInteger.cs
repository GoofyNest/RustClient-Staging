internal class BigInteger // TypeDefIndex: 80
{	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x163B850 Offset: 0x1639E50 VA: 0x18163B850
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x163B790 Offset: 0x1639D90 VA: 0x18163B790
	public void .ctor(BigInteger bi) { }

	// RVA: 0x163B2A0 Offset: 0x16398A0 VA: 0x18163B2A0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x163B410 Offset: 0x1639A10 VA: 0x18163B410
	public void .ctor(byte[] inData) { }

	// RVA: 0x163B380 Offset: 0x1639980 VA: 0x18163B380
	public void .ctor(uint ui) { }

	// RVA: 0x163BBA0 Offset: 0x163A1A0 VA: 0x18163BBA0
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x163BC00 Offset: 0x163A200 VA: 0x18163BC00
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x163C310 Offset: 0x163A910 VA: 0x18163C310
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE50 Offset: 0x163A450 VA: 0x18163BE50
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x163BEC0 Offset: 0x163A4C0 VA: 0x18163BEC0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163B9B0 Offset: 0x1639FB0 VA: 0x18163B9B0
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BF00 Offset: 0x163A500 VA: 0x18163BF00
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163C1E0 Offset: 0x163A7E0 VA: 0x18163C1E0
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x163BE00 Offset: 0x163A400 VA: 0x18163BE00
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x163C300 Offset: 0x163A900 VA: 0x18163C300
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x163B8C0 Offset: 0x1639EC0 VA: 0x18163B8C0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1639F10 Offset: 0x1638510 VA: 0x181639F10
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x163A140 Offset: 0x1638740 VA: 0x18163A140
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x163A990 Offset: 0x1638F90 VA: 0x18163A990
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x163AC20 Offset: 0x1639220 VA: 0x18163AC20
	public void Randomize() { }

	// RVA: 0x1639A10 Offset: 0x1638010 VA: 0x181639A10
	public int BitCount() { }

	// RVA: 0x163AD50 Offset: 0x1639350 VA: 0x18163AD50
	public bool TestBit(uint bitNum) { }

	// RVA: 0x163ADA0 Offset: 0x16393A0 VA: 0x18163ADA0
	public bool TestBit(int bitNum) { }

	// RVA: 0x163AD00 Offset: 0x1639300 VA: 0x18163AD00
	public void SetBit(uint bitNum) { }

	// RVA: 0x163AC80 Offset: 0x1639280 VA: 0x18163AC80
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x163A760 Offset: 0x1638D60 VA: 0x18163A760
	public int LowestSetBit() { }

	// RVA: 0x163A1A0 Offset: 0x16387A0 VA: 0x18163A1A0
	public byte[] GetBytes() { }

	// RVA: 0x163B9F0 Offset: 0x1639FF0 VA: 0x18163B9F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x163BD60 Offset: 0x163A360 VA: 0x18163BD60
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x163BA90 Offset: 0x163A090 VA: 0x18163BA90
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BC90 Offset: 0x163A290 VA: 0x18163BC90
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BB80 Offset: 0x163A180 VA: 0x18163BB80
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE30 Offset: 0x163A430 VA: 0x18163BE30
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BB60 Offset: 0x163A160 VA: 0x18163BB60
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE10 Offset: 0x163A410 VA: 0x18163BE10
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163B1A0 Offset: 0x16397A0 VA: 0x18163B1A0
	public string ToString(uint radix) { }

	// RVA: 0x163AE50 Offset: 0x1639450 VA: 0x18163AE50
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x163A930 Offset: 0x1638F30 VA: 0x18163A930
	private void Normalize() { }

	// RVA: 0x1639AE0 Offset: 0x16380E0 VA: 0x181639AE0
	public void Clear() { }

	// RVA: 0x163A370 Offset: 0x1638970 VA: 0x18163A370 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x163B1F0 Offset: 0x16397F0 VA: 0x18163B1F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1639B40 Offset: 0x1638140 VA: 0x181639B40 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x163A890 Offset: 0x1638E90 VA: 0x18163A890
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x163A8A0 Offset: 0x1638EA0 VA: 0x18163A8A0
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x163A4D0 Offset: 0x1638AD0 VA: 0x18163A4D0
	public bool IsProbablePrime() { }

	// RVA: 0x1639EA0 Offset: 0x16384A0 VA: 0x181639EA0
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x163A3C0 Offset: 0x16389C0 VA: 0x18163A3C0
	public void Incr2() { }

	// RVA: 0x163B230 Offset: 0x1639830 VA: 0x18163B230
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

	// RVA: 0x1647150 Offset: 0x1645750 VA: 0x181647150
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1646480 Offset: 0x1644A80 VA: 0x181646480
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1646BF0 Offset: 0x16451F0 VA: 0x181646BF0
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x16469A0 Offset: 0x1644FA0 VA: 0x1816469A0
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1646F80 Offset: 0x1645580 VA: 0x181646F80
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x1646F00 Offset: 0x1645500 VA: 0x181646F00
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 83
{	// Methods

	// RVA: 0x163E3E0 Offset: 0x163C9E0 VA: 0x18163E3E0
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x163D8D0 Offset: 0x163BED0 VA: 0x18163D8D0
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x163DE40 Offset: 0x163C440 VA: 0x18163DE40
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163D110 Offset: 0x163B710 VA: 0x18163D110
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163E310 Offset: 0x163C910 VA: 0x18163E310
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x163BE50 Offset: 0x163A450 VA: 0x18163BE50
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x163D290 Offset: 0x163B890 VA: 0x18163D290
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x163F290 Offset: 0x163D890 VA: 0x18163F290
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163D5B0 Offset: 0x163BBB0 VA: 0x18163D5B0
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x163E0A0 Offset: 0x163C6A0 VA: 0x18163E0A0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x163DA60 Offset: 0x163C060 VA: 0x18163DA60
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x163DD30 Offset: 0x163C330 VA: 0x18163DD30
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x163DC10 Offset: 0x163C210 VA: 0x18163DC10
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x163E6A0 Offset: 0x163CCA0 VA: 0x18163E6A0
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x163E7D0 Offset: 0x163CDD0 VA: 0x18163E7D0
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
	// RVA: 0x1AB01F0 Offset: 0x1AAE7F0 VA: 0x181AB01F0
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1AB00A0 Offset: 0x1AAE6A0 VA: 0x181AB00A0
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AAFFC0 Offset: 0x1AAE5C0 VA: 0x181AAFFC0
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1AAFC40 Offset: 0x1AAE240 VA: 0x181AAFC40
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0160 Offset: 0x1AAE760 VA: 0x181AB0160
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0460 Offset: 0x1AAEA60 VA: 0x181AB0460
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1AB04C0 Offset: 0x1AAEAC0 VA: 0x181AB04C0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1AB0960 Offset: 0x1AAEF60 VA: 0x181AB0960
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163BE50 Offset: 0x163A450 VA: 0x18163BE50
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1AB0630 Offset: 0x1AAEC30 VA: 0x181AB0630
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0350 Offset: 0x1AAE950 VA: 0x181AB0350
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0670 Offset: 0x1AAEC70 VA: 0x181AB0670
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0620 Offset: 0x1AAEC20 VA: 0x181AB0620
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AB0950 Offset: 0x1AAEF50 VA: 0x181AB0950
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AB0260 Offset: 0x1AAE860 VA: 0x181AB0260
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1AAF200 Offset: 0x1AAD800 VA: 0x181AAF200
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1AAF0D0 Offset: 0x1AAD6D0 VA: 0x181AAF0D0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1639A10 Offset: 0x1638010 VA: 0x181639A10
	public int BitCount() { }

	// RVA: 0x1AAF740 Offset: 0x1AADD40 VA: 0x181AAF740
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163AD00 Offset: 0x1639300 VA: 0x18163AD00
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163AC80 Offset: 0x1639280 VA: 0x18163AC80
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1AAF600 Offset: 0x1AADC00 VA: 0x181AAF600
	public int LowestSetBit() { }

	// RVA: 0x1AAF430 Offset: 0x1AADA30 VA: 0x181AAF430
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163B9F0 Offset: 0x1639FF0 VA: 0x18163B9F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x163BD60 Offset: 0x163A360 VA: 0x18163BD60
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1AB0390 Offset: 0x1AAE990 VA: 0x181AB0390
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0550 Offset: 0x1AAEB50 VA: 0x181AB0550
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BB80 Offset: 0x163A180 VA: 0x18163BB80
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE30 Offset: 0x163A430 VA: 0x18163BE30
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BB60 Offset: 0x163A160 VA: 0x18163BB60
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE10 Offset: 0x163A410 VA: 0x18163BE10
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AAF7F0 Offset: 0x1AADDF0 VA: 0x181AAF7F0
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AAF880 Offset: 0x1AADE80 VA: 0x181AAF880
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x163A930 Offset: 0x1638F30 VA: 0x18163A930
	private void Normalize() { }

	// RVA: 0x163A370 Offset: 0x1638970 VA: 0x18163A370 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AAF840 Offset: 0x1AADE40 VA: 0x181AAF840 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AAED00 Offset: 0x1AAD300 VA: 0x181AAED00 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1AAF730 Offset: 0x1AADD30 VA: 0x181AAF730
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1AAF060 Offset: 0x1AAD660 VA: 0x181AAF060
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x163A3C0 Offset: 0x16389C0 VA: 0x18163A3C0
	public void Incr2() { }

	// RVA: 0x1AAFBD0 Offset: 0x1AAE1D0 VA: 0x181AAFBD0
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

	// RVA: 0x1AB9160 Offset: 0x1AB7760 VA: 0x181AB9160
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1AB8490 Offset: 0x1AB6A90 VA: 0x181AB8490
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1AB8C00 Offset: 0x1AB7200 VA: 0x181AB8C00
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB89B0 Offset: 0x1AB6FB0 VA: 0x181AB89B0
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB8F10 Offset: 0x1AB7510 VA: 0x181AB8F10
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB90E0 Offset: 0x1AB76E0 VA: 0x181AB90E0
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 1766
{	// Methods

	// RVA: 0x1AB5B90 Offset: 0x1AB4190 VA: 0x181AB5B90
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x163D8D0 Offset: 0x163BED0 VA: 0x18163D8D0
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x163DE40 Offset: 0x163C440 VA: 0x18163DE40
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163D110 Offset: 0x163B710 VA: 0x18163D110
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163E310 Offset: 0x163C910 VA: 0x18163E310
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x163BE50 Offset: 0x163A450 VA: 0x18163BE50
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x1AB52E0 Offset: 0x1AB38E0 VA: 0x181AB52E0
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1AB6A40 Offset: 0x1AB5040 VA: 0x181AB6A40
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB5600 Offset: 0x1AB3C00 VA: 0x181AB5600
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1AB5920 Offset: 0x1AB3F20 VA: 0x181AB5920
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x163DD30 Offset: 0x163C330 VA: 0x18163DD30
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x163DC10 Offset: 0x163C210 VA: 0x18163DC10
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1AB5E50 Offset: 0x1AB4450 VA: 0x181AB5E50
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1AB5F80 Offset: 0x1AB4580 VA: 0x181AB5F80
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

	// RVA: 0x22301B0 Offset: 0x222E7B0 VA: 0x1822301B0
	public static BigInteger get_Zero() { }

	// RVA: 0x237C40 Offset: 0x237040 VA: 0x180237C40
	public bool get_IsZero() { }

	// RVA: 0x222EAD0 Offset: 0x222D0D0 VA: 0x18222EAD0
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x222EB70 Offset: 0x222D170 VA: 0x18222EB70
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

	// RVA: 0x222E340 Offset: 0x222C940 VA: 0x18222E340
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x2231640 Offset: 0x222FC40 VA: 0x182231640
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x222EBD0 Offset: 0x222D1D0 VA: 0x18222EBD0
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x2231150 Offset: 0x222F750 VA: 0x182231150
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231080 Offset: 0x222F680 VA: 0x182231080
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x22310D0 Offset: 0x222F6D0 VA: 0x1822310D0
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231100 Offset: 0x222F700 VA: 0x182231100
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x2231180 Offset: 0x222F780 VA: 0x182231180
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231060 Offset: 0x222F660 VA: 0x182231060
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x22310B0 Offset: 0x222F6B0 VA: 0x1822310B0
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231130 Offset: 0x222F730 VA: 0x182231130
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x2230E90 Offset: 0x222F490 VA: 0x182230E90
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2230980 Offset: 0x222EF80 VA: 0x182230980
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x2230B80 Offset: 0x222F180 VA: 0x182230B80
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2230900 Offset: 0x222EF00 VA: 0x182230900
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x2230780 Offset: 0x222ED80 VA: 0x182230780
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2230C00 Offset: 0x222F200 VA: 0x182230C00
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x22304B0 Offset: 0x222EAB0 VA: 0x1822304B0
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2230640 Offset: 0x222EC40 VA: 0x182230640
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x2230A00 Offset: 0x222F000 VA: 0x182230A00
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x2230F10 Offset: 0x222F510 VA: 0x182230F10
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x2230CD0 Offset: 0x222F2D0 VA: 0x182230CD0
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x22318B0 Offset: 0x222FEB0 VA: 0x1822318B0
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x2230220 Offset: 0x222E820 VA: 0x182230220
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x22312A0 Offset: 0x222F8A0 VA: 0x1822312A0
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x22311F0 Offset: 0x222F7F0 VA: 0x1822311F0
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x22311C0 Offset: 0x222F7C0 VA: 0x1822311C0
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x2231260 Offset: 0x222F860 VA: 0x182231260
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x2231220 Offset: 0x222F820 VA: 0x182231220
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x2230490 Offset: 0x222EA90 VA: 0x182230490
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x22311A0 Offset: 0x222F7A0 VA: 0x1822311A0
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x2231280 Offset: 0x222F880 VA: 0x182231280
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x2231240 Offset: 0x222F840 VA: 0x182231240
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x222EA60 Offset: 0x222D060 VA: 0x18222EA60
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x222F380 Offset: 0x222D980 VA: 0x18222F380
	private static void .cctor() { }

}

private enum BigInteger.GetBytesMode // TypeDefIndex: 3964
{	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;

}

