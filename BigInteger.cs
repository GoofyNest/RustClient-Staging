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

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1AB03B0 Offset: 0x1AAE9B0 VA: 0x181AB03B0
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1AB0260 Offset: 0x1AAE860 VA: 0x181AB0260
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1AB0180 Offset: 0x1AAE780 VA: 0x181AB0180
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1AAFE00 Offset: 0x1AAE400 VA: 0x181AAFE00
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1AB0320 Offset: 0x1AAE920 VA: 0x181AB0320
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1AB0620 Offset: 0x1AAEC20 VA: 0x181AB0620
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1AB0680 Offset: 0x1AAEC80 VA: 0x181AB0680
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1AB0B20 Offset: 0x1AAF120 VA: 0x181AB0B20
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x163BE50 Offset: 0x163A450 VA: 0x18163BE50
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1AB07F0 Offset: 0x1AAEDF0 VA: 0x181AB07F0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0510 Offset: 0x1AAEB10 VA: 0x181AB0510
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0830 Offset: 0x1AAEE30 VA: 0x181AB0830
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB07E0 Offset: 0x1AAEDE0 VA: 0x181AB07E0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AB0B10 Offset: 0x1AAF110 VA: 0x181AB0B10
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AB0420 Offset: 0x1AAEA20 VA: 0x181AB0420
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1AAF3C0 Offset: 0x1AAD9C0 VA: 0x181AAF3C0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1AAF290 Offset: 0x1AAD890 VA: 0x181AAF290
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1639A10 Offset: 0x1638010 VA: 0x181639A10
	public int BitCount() { }

	// RVA: 0x1AAF900 Offset: 0x1AADF00 VA: 0x181AAF900
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x163AD00 Offset: 0x1639300 VA: 0x18163AD00
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x163AC80 Offset: 0x1639280 VA: 0x18163AC80
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1AAF7C0 Offset: 0x1AADDC0 VA: 0x181AAF7C0
	public int LowestSetBit() { }

	// RVA: 0x1AAF5F0 Offset: 0x1AADBF0 VA: 0x181AAF5F0
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x163B9F0 Offset: 0x1639FF0 VA: 0x18163B9F0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x163BD60 Offset: 0x163A360 VA: 0x18163BD60
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1AB0550 Offset: 0x1AAEB50 VA: 0x181AB0550
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0710 Offset: 0x1AAED10 VA: 0x181AB0710
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BB80 Offset: 0x163A180 VA: 0x18163BB80
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE30 Offset: 0x163A430 VA: 0x18163BE30
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BB60 Offset: 0x163A160 VA: 0x18163BB60
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x163BE10 Offset: 0x163A410 VA: 0x18163BE10
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1AAF9B0 Offset: 0x1AADFB0 VA: 0x181AAF9B0
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1AAFA40 Offset: 0x1AAE040 VA: 0x181AAFA40
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x163A930 Offset: 0x1638F30 VA: 0x18163A930
	private void Normalize() { }

	// RVA: 0x163A370 Offset: 0x1638970 VA: 0x18163A370 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AAFA00 Offset: 0x1AAE000 VA: 0x181AAFA00 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AAEEC0 Offset: 0x1AAD4C0 VA: 0x181AAEEC0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1AAF8F0 Offset: 0x1AADEF0 VA: 0x181AAF8F0
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1AAF220 Offset: 0x1AAD820 VA: 0x181AAF220
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x163A3C0 Offset: 0x16389C0 VA: 0x18163A3C0
	public void Incr2() { }

	// RVA: 0x1AAFD90 Offset: 0x1AAE390 VA: 0x181AAFD90
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

	// RVA: 0x1AB9320 Offset: 0x1AB7920 VA: 0x181AB9320
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1AB8650 Offset: 0x1AB6C50 VA: 0x181AB8650
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1AB8DC0 Offset: 0x1AB73C0 VA: 0x181AB8DC0
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB8B70 Offset: 0x1AB7170 VA: 0x181AB8B70
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB90D0 Offset: 0x1AB76D0 VA: 0x181AB90D0
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x1AB92A0 Offset: 0x1AB78A0 VA: 0x181AB92A0
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 1766
{	// Methods

	// RVA: 0x1AB5D50 Offset: 0x1AB4350 VA: 0x181AB5D50
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

	// RVA: 0x1AB54A0 Offset: 0x1AB3AA0 VA: 0x181AB54A0
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1AB6C00 Offset: 0x1AB5200 VA: 0x181AB6C00
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB57C0 Offset: 0x1AB3DC0 VA: 0x181AB57C0
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1AB5AE0 Offset: 0x1AB40E0 VA: 0x181AB5AE0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x163DD30 Offset: 0x163C330 VA: 0x18163DD30
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x163DC10 Offset: 0x163C210 VA: 0x18163DC10
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1AB6010 Offset: 0x1AB4610 VA: 0x181AB6010
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1AB6140 Offset: 0x1AB4740 VA: 0x181AB6140
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

	// RVA: 0x237C60 Offset: 0x237060 VA: 0x180237C60
	public void .ctor(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x237C70 Offset: 0x237070 VA: 0x180237C70
	public void .ctor(uint value) { }

	// RVA: 0x237C40 Offset: 0x237040 VA: 0x180237C40
	public void .ctor(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x237C50 Offset: 0x237050 VA: 0x180237C50
	public void .ctor(ulong value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x237B80 Offset: 0x236F80 VA: 0x180237B80
	public void .ctor(byte[] value) { }

	// RVA: 0x237C90 Offset: 0x237090 VA: 0x180237C90
	public void .ctor(ReadOnlySpan<byte> value) { }

	// RVA: 0xFCB60 Offset: 0xFBF60 VA: 0x1800FCB60
	internal void .ctor(int n, uint[] rgu) { }

	// RVA: 0x237C80 Offset: 0x237080 VA: 0x180237C80
	internal void .ctor(uint[] value, bool negative) { }

	// RVA: 0x2230370 Offset: 0x222E970 VA: 0x182230370
	public static BigInteger get_Zero() { }

	// RVA: 0x237CC0 Offset: 0x2370C0 VA: 0x180237CC0
	public bool get_IsZero() { }

	// RVA: 0x222EC90 Offset: 0x222D290 VA: 0x18222EC90
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x222ED30 Offset: 0x222D330 VA: 0x18222ED30
	public static BigInteger Parse(string value, NumberStyles style, IFormatProvider provider) { }

	// RVA: 0x237A10 Offset: 0x236E10 VA: 0x180237A10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x237970 Offset: 0x236D70 VA: 0x180237970 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x237960 Offset: 0x236D60 VA: 0x180237960
	public bool Equals(long other) { }

	// RVA: 0x237940 Offset: 0x236D40 VA: 0x180237940 Slot: 7
	public bool Equals(BigInteger other) { }

	// RVA: 0x237930 Offset: 0x236D30 VA: 0x180237930
	public int CompareTo(long other) { }

	// RVA: 0x237910 Offset: 0x236D10 VA: 0x180237910 Slot: 6
	public int CompareTo(BigInteger other) { }

	// RVA: 0x237840 Offset: 0x236C40 VA: 0x180237840 Slot: 5
	public int CompareTo(object obj) { }

	// RVA: 0x237A70 Offset: 0x236E70 VA: 0x180237A70
	public byte[] ToByteArray() { }

	// RVA: 0x237B40 Offset: 0x236F40 VA: 0x180237B40
	private byte[] TryGetBytes(BigInteger.GetBytesMode mode, Span<byte> destination, ref int bytesWritten) { }

	// RVA: 0x237AC0 Offset: 0x236EC0 VA: 0x180237AC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x237B00 Offset: 0x236F00 VA: 0x180237B00 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x222E500 Offset: 0x222CB00 VA: 0x18222E500
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x2231800 Offset: 0x222FE00 VA: 0x182231800
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x222ED90 Offset: 0x222D390 VA: 0x18222ED90
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x2231310 Offset: 0x222F910 VA: 0x182231310
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2231240 Offset: 0x222F840 VA: 0x182231240
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x2231290 Offset: 0x222F890 VA: 0x182231290
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x22312C0 Offset: 0x222F8C0 VA: 0x1822312C0
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x2231340 Offset: 0x222F940 VA: 0x182231340
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2231220 Offset: 0x222F820 VA: 0x182231220
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x2231270 Offset: 0x222F870 VA: 0x182231270
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x22312F0 Offset: 0x222F8F0 VA: 0x1822312F0
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x2231050 Offset: 0x222F650 VA: 0x182231050
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2230B40 Offset: 0x222F140 VA: 0x182230B40
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x2230D40 Offset: 0x222F340 VA: 0x182230D40
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2230AC0 Offset: 0x222F0C0 VA: 0x182230AC0
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x2230940 Offset: 0x222EF40 VA: 0x182230940
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2230DC0 Offset: 0x222F3C0 VA: 0x182230DC0
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x2230670 Offset: 0x222EC70 VA: 0x182230670
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: 0x2230800 Offset: 0x222EE00 VA: 0x182230800
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x2230BC0 Offset: 0x222F1C0 VA: 0x182230BC0
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x22310D0 Offset: 0x222F6D0 VA: 0x1822310D0
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x2230E90 Offset: 0x222F490 VA: 0x182230E90
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x2231A70 Offset: 0x2230070 VA: 0x182231A70
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x22303E0 Offset: 0x222E9E0 VA: 0x1822303E0
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x2231460 Offset: 0x222FA60 VA: 0x182231460
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x22313B0 Offset: 0x222F9B0 VA: 0x1822313B0
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x2231380 Offset: 0x222F980 VA: 0x182231380
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x2231420 Offset: 0x222FA20 VA: 0x182231420
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x22313E0 Offset: 0x222F9E0 VA: 0x1822313E0
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x2230650 Offset: 0x222EC50 VA: 0x182230650
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x2231360 Offset: 0x222F960 VA: 0x182231360
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x2231440 Offset: 0x222FA40 VA: 0x182231440
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x2231400 Offset: 0x222FA00 VA: 0x182231400
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x222EC20 Offset: 0x222D220 VA: 0x18222EC20
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x222F540 Offset: 0x222DB40 VA: 0x18222F540
	private static void .cctor() { }

}

private enum BigInteger.GetBytesMode // TypeDefIndex: 3964
{	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;

}

