internal class BigInteger // TypeDefIndex: 80
{	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1628E30 Offset: 0x1627430 VA: 0x181628E30
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1628D70 Offset: 0x1627370 VA: 0x181628D70
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1628880 Offset: 0x1626E80 VA: 0x181628880
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x16289F0 Offset: 0x1626FF0 VA: 0x1816289F0
	public void .ctor(byte[] inData) { }

	// RVA: 0x1628960 Offset: 0x1626F60 VA: 0x181628960
	public void .ctor(uint ui) { }

	// RVA: 0x1629180 Offset: 0x1627780 VA: 0x181629180
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x16291E0 Offset: 0x16277E0 VA: 0x1816291E0
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x16298F0 Offset: 0x1627EF0 VA: 0x1816298F0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1629430 Offset: 0x1627A30 VA: 0x181629430
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x16294A0 Offset: 0x1627AA0 VA: 0x1816294A0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1628F90 Offset: 0x1627590 VA: 0x181628F90
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x16294E0 Offset: 0x1627AE0 VA: 0x1816294E0
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x16297C0 Offset: 0x1627DC0 VA: 0x1816297C0
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x16293E0 Offset: 0x16279E0 VA: 0x1816293E0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x16298E0 Offset: 0x1627EE0 VA: 0x1816298E0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1628EA0 Offset: 0x16274A0 VA: 0x181628EA0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x16274F0 Offset: 0x1625AF0 VA: 0x1816274F0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1627720 Offset: 0x1625D20 VA: 0x181627720
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1627F70 Offset: 0x1626570 VA: 0x181627F70
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x1628200 Offset: 0x1626800 VA: 0x181628200
	public void Randomize() { }

	// RVA: 0x1626FF0 Offset: 0x16255F0 VA: 0x181626FF0
	public int BitCount() { }

	// RVA: 0x1628330 Offset: 0x1626930 VA: 0x181628330
	public bool TestBit(uint bitNum) { }

	// RVA: 0x1628380 Offset: 0x1626980 VA: 0x181628380
	public bool TestBit(int bitNum) { }

	// RVA: 0x16282E0 Offset: 0x16268E0 VA: 0x1816282E0
	public void SetBit(uint bitNum) { }

	// RVA: 0x1628260 Offset: 0x1626860 VA: 0x181628260
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1627D40 Offset: 0x1626340 VA: 0x181627D40
	public int LowestSetBit() { }

	// RVA: 0x1627780 Offset: 0x1625D80 VA: 0x181627780
	public byte[] GetBytes() { }

	// RVA: 0x1628FD0 Offset: 0x16275D0 VA: 0x181628FD0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x1629340 Offset: 0x1627940 VA: 0x181629340
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1629070 Offset: 0x1627670 VA: 0x181629070
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1629270 Offset: 0x1627870 VA: 0x181629270
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1629160 Offset: 0x1627760 VA: 0x181629160
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1629410 Offset: 0x1627A10 VA: 0x181629410
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1629140 Offset: 0x1627740 VA: 0x181629140
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x16293F0 Offset: 0x16279F0 VA: 0x1816293F0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1628780 Offset: 0x1626D80 VA: 0x181628780
	public string ToString(uint radix) { }

	// RVA: 0x1628430 Offset: 0x1626A30 VA: 0x181628430
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1627F10 Offset: 0x1626510 VA: 0x181627F10
	private void Normalize() { }

	// RVA: 0x16270C0 Offset: 0x16256C0 VA: 0x1816270C0
	public void Clear() { }

	// RVA: 0x1627950 Offset: 0x1625F50 VA: 0x181627950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x16287D0 Offset: 0x1626DD0 VA: 0x1816287D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1627120 Offset: 0x1625720 VA: 0x181627120 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1627E70 Offset: 0x1626470 VA: 0x181627E70
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1627E80 Offset: 0x1626480 VA: 0x181627E80
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x1627AB0 Offset: 0x16260B0 VA: 0x181627AB0
	public bool IsProbablePrime() { }

	// RVA: 0x1627480 Offset: 0x1625A80 VA: 0x181627480
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x16279A0 Offset: 0x1625FA0 VA: 0x1816279A0
	public void Incr2() { }

	// RVA: 0x1628810 Offset: 0x1626E10 VA: 0x181628810
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

	// RVA: 0x1634730 Offset: 0x1632D30 VA: 0x181634730
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1633A60 Offset: 0x1632060 VA: 0x181633A60
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x16341D0 Offset: 0x16327D0 VA: 0x1816341D0
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1633F80 Offset: 0x1632580 VA: 0x181633F80
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1634560 Offset: 0x1632B60 VA: 0x181634560
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x16344E0 Offset: 0x1632AE0 VA: 0x1816344E0
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 83
{	// Methods

	// RVA: 0x162B9C0 Offset: 0x1629FC0 VA: 0x18162B9C0
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x162AEB0 Offset: 0x16294B0 VA: 0x18162AEB0
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x162B420 Offset: 0x1629A20 VA: 0x18162B420
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x162A6F0 Offset: 0x1628CF0 VA: 0x18162A6F0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x162B8F0 Offset: 0x1629EF0 VA: 0x18162B8F0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1629430 Offset: 0x1627A30 VA: 0x181629430
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x162A870 Offset: 0x1628E70 VA: 0x18162A870
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x162C870 Offset: 0x162AE70 VA: 0x18162C870
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x162AB90 Offset: 0x1629190 VA: 0x18162AB90
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x162B680 Offset: 0x1629C80 VA: 0x18162B680
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x162B040 Offset: 0x1629640 VA: 0x18162B040
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x162B310 Offset: 0x1629910 VA: 0x18162B310
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x162B1F0 Offset: 0x16297F0 VA: 0x18162B1F0
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x162BC80 Offset: 0x162A280 VA: 0x18162BC80
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x162BDB0 Offset: 0x162A3B0 VA: 0x18162BDB0
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
	// RVA: 0x1AB0CA0 Offset: 0x1AAF2A0 VA: 0x181AB0CA0
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1AB0B50 Offset: 0x1AAF150 VA: 0x181AB0B50
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0A70 Offset: 0x1AAF070 VA: 0x181AB0A70
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1AB06F0 Offset: 0x1AAECF0 VA: 0x181AB06F0
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0C10 Offset: 0x1AAF210 VA: 0x181AB0C10
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0F10 Offset: 0x1AAF510 VA: 0x181AB0F10
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1AB0F70 Offset: 0x1AAF570 VA: 0x181AB0F70
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1AB1410 Offset: 0x1AAFA10 VA: 0x181AB1410
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1629430 Offset: 0x1627A30 VA: 0x181629430
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1AB10E0 Offset: 0x1AAF6E0 VA: 0x181AB10E0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB0E00 Offset: 0x1AAF400 VA: 0x181AB0E00
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB1120 Offset: 0x1AAF720 VA: 0x181AB1120
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB10D0 Offset: 0x1AAF6D0 VA: 0x181AB10D0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AB1400 Offset: 0x1AAFA00 VA: 0x181AB1400
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1AB0D10 Offset: 0x1AAF310 VA: 0x181AB0D10
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1AAFCB0 Offset: 0x1AAE2B0 VA: 0x181AAFCB0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1AAFB80 Offset: 0x1AAE180 VA: 0x181AAFB80
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1626FF0 Offset: 0x16255F0 VA: 0x181626FF0
	public int BitCount() { }

	// RVA: 0x1AB01F0 Offset: 0x1AAE7F0 VA: 0x181AB01F0
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x16282E0 Offset: 0x16268E0 VA: 0x1816282E0
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1628260 Offset: 0x1626860 VA: 0x181628260
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1AB00B0 Offset: 0x1AAE6B0 VA: 0x181AB00B0
	public int LowestSetBit() { }

	// RVA: 0x1AAFEE0 Offset: 0x1AAE4E0 VA: 0x181AAFEE0
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1628FD0 Offset: 0x16275D0 VA: 0x181628FD0
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1629340 Offset: 0x1627940 VA: 0x181629340
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1AB0E40 Offset: 0x1AAF440 VA: 0x181AB0E40
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB1000 Offset: 0x1AAF600 VA: 0x181AB1000
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1629160 Offset: 0x1627760 VA: 0x181629160
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1629410 Offset: 0x1627A10 VA: 0x181629410
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1629140 Offset: 0x1627740 VA: 0x181629140
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x16293F0 Offset: 0x16279F0 VA: 0x1816293F0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB02A0 Offset: 0x1AAE8A0 VA: 0x181AB02A0
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB0330 Offset: 0x1AAE930 VA: 0x181AB0330
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1627F10 Offset: 0x1626510 VA: 0x181627F10
	private void Normalize() { }

	// RVA: 0x1627950 Offset: 0x1625F50 VA: 0x181627950 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AB02F0 Offset: 0x1AAE8F0 VA: 0x181AB02F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AAF7B0 Offset: 0x1AADDB0 VA: 0x181AAF7B0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1AB01E0 Offset: 0x1AAE7E0 VA: 0x181AB01E0
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1AAFB10 Offset: 0x1AAE110 VA: 0x181AAFB10
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x16279A0 Offset: 0x1625FA0 VA: 0x1816279A0
	public void Incr2() { }

	// RVA: 0x1AB0680 Offset: 0x1AAEC80 VA: 0x181AB0680
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

	// RVA: 0x1AB9C10 Offset: 0x1AB8210 VA: 0x181AB9C10
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1AB8F40 Offset: 0x1AB7540 VA: 0x181AB8F40
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1AB96B0 Offset: 0x1AB7CB0 VA: 0x181AB96B0
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB9460 Offset: 0x1AB7A60 VA: 0x181AB9460
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1AB99C0 Offset: 0x1AB7FC0 VA: 0x181AB99C0
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1AB9B90 Offset: 0x1AB8190 VA: 0x181AB9B90
	public BigInteger Pow(uint b, BigInteger exp) { }

}

private sealed class BigInteger.Kernel // TypeDefIndex: 1766
{	// Methods

	// RVA: 0x1AB6640 Offset: 0x1AB4C40 VA: 0x181AB6640
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x162AEB0 Offset: 0x16294B0 VA: 0x18162AEB0
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x162B420 Offset: 0x1629A20 VA: 0x18162B420
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x162A6F0 Offset: 0x1628CF0 VA: 0x18162A6F0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x162B8F0 Offset: 0x1629EF0 VA: 0x18162B8F0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1629430 Offset: 0x1627A30 VA: 0x181629430
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x1AB5D90 Offset: 0x1AB4390 VA: 0x181AB5D90
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1AB74F0 Offset: 0x1AB5AF0 VA: 0x181AB74F0
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1AB60B0 Offset: 0x1AB46B0 VA: 0x181AB60B0
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1AB63D0 Offset: 0x1AB49D0 VA: 0x181AB63D0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x162B310 Offset: 0x1629910 VA: 0x18162B310
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x162B1F0 Offset: 0x16297F0 VA: 0x18162B1F0
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1AB6900 Offset: 0x1AB4F00 VA: 0x181AB6900
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1AB6A30 Offset: 0x1AB5030 VA: 0x181AB6A30
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

	// RVA: 0x2230C90 Offset: 0x222F290 VA: 0x182230C90
	public static BigInteger get_Zero() { }

	// RVA: 0x237C40 Offset: 0x237040 VA: 0x180237C40
	public bool get_IsZero() { }

	// RVA: 0x222F5B0 Offset: 0x222DBB0 VA: 0x18222F5B0
	public static BigInteger Parse(string value, IFormatProvider provider) { }

	// RVA: 0x222F650 Offset: 0x222DC50 VA: 0x18222F650
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

	// RVA: 0x222EE20 Offset: 0x222D420 VA: 0x18222EE20
	private static BigInteger Add(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x2232120 Offset: 0x2230720 VA: 0x182232120
	public static BigInteger op_Subtraction(BigInteger left, BigInteger right) { }

	// RVA: 0x222F6B0 Offset: 0x222DCB0 VA: 0x18222F6B0
	private static BigInteger Subtract(uint[] leftBits, int leftSign, uint[] rightBits, int rightSign) { }

	// RVA: 0x2231C30 Offset: 0x2230230 VA: 0x182231C30
	public static BigInteger op_Implicit(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231B60 Offset: 0x2230160 VA: 0x182231B60
	public static BigInteger op_Implicit(sbyte value) { }

	// RVA: 0x2231BB0 Offset: 0x22301B0 VA: 0x182231BB0
	public static BigInteger op_Implicit(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231BE0 Offset: 0x22301E0 VA: 0x182231BE0
	public static BigInteger op_Implicit(ushort value) { }

	// RVA: 0x2231C60 Offset: 0x2230260 VA: 0x182231C60
	public static BigInteger op_Implicit(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231B40 Offset: 0x2230140 VA: 0x182231B40
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x2231B90 Offset: 0x2230190 VA: 0x182231B90
	public static BigInteger op_Implicit(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231C10 Offset: 0x2230210 VA: 0x182231C10
	public static BigInteger op_Implicit(ulong value) { }

	// RVA: 0x2231970 Offset: 0x222FF70 VA: 0x182231970
	public static byte op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231460 Offset: 0x222FA60 VA: 0x182231460
	public static sbyte op_Explicit(BigInteger value) { }

	// RVA: 0x2231660 Offset: 0x222FC60 VA: 0x182231660
	public static short op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x22313E0 Offset: 0x222F9E0 VA: 0x1822313E0
	public static ushort op_Explicit(BigInteger value) { }

	// RVA: 0x2231260 Offset: 0x222F860 VA: 0x182231260
	public static int op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x22316E0 Offset: 0x222FCE0 VA: 0x1822316E0
	public static uint op_Explicit(BigInteger value) { }

	// RVA: 0x2230F90 Offset: 0x222F590 VA: 0x182230F90
	public static long op_Explicit(BigInteger value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x2231120 Offset: 0x222F720 VA: 0x182231120
	public static ulong op_Explicit(BigInteger value) { }

	// RVA: 0x22314E0 Offset: 0x222FAE0 VA: 0x1822314E0
	public static float op_Explicit(BigInteger value) { }

	// RVA: 0x22319F0 Offset: 0x222FFF0 VA: 0x1822319F0
	public static double op_Explicit(BigInteger value) { }

	// RVA: 0x22317B0 Offset: 0x222FDB0 VA: 0x1822317B0
	public static Decimal op_Explicit(BigInteger value) { }

	// RVA: 0x2232390 Offset: 0x2230990 VA: 0x182232390
	public static BigInteger op_UnaryNegation(BigInteger value) { }

	// RVA: 0x2230D00 Offset: 0x222F300 VA: 0x182230D00
	public static BigInteger op_Addition(BigInteger left, BigInteger right) { }

	// RVA: 0x2231D80 Offset: 0x2230380 VA: 0x182231D80
	public static BigInteger op_Multiply(BigInteger left, BigInteger right) { }

	// RVA: 0x2231CD0 Offset: 0x22302D0 VA: 0x182231CD0
	public static bool op_LessThanOrEqual(BigInteger left, BigInteger right) { }

	// RVA: 0x2231CA0 Offset: 0x22302A0 VA: 0x182231CA0
	public static bool op_Inequality(BigInteger left, BigInteger right) { }

	// RVA: 0x2231D40 Offset: 0x2230340 VA: 0x182231D40
	public static bool op_LessThan(BigInteger left, long right) { }

	// RVA: 0x2231D00 Offset: 0x2230300 VA: 0x182231D00
	public static bool op_LessThanOrEqual(BigInteger left, long right) { }

	// RVA: 0x2230F70 Offset: 0x222F570 VA: 0x182230F70
	public static bool op_Equality(BigInteger left, long right) { }

	// RVA: 0x2231C80 Offset: 0x2230280 VA: 0x182231C80
	public static bool op_Inequality(BigInteger left, long right) { }

	// RVA: 0x2231D60 Offset: 0x2230360 VA: 0x182231D60
	public static bool op_LessThan(long left, BigInteger right) { }

	// RVA: 0x2231D20 Offset: 0x2230320 VA: 0x182231D20
	public static bool op_LessThanOrEqual(long left, BigInteger right) { }

	// RVA: 0x222F540 Offset: 0x222DB40 VA: 0x18222F540
	internal static int GetDiffLength(uint[] rgu1, uint[] rgu2, int cu) { }

	// RVA: 0x222FE60 Offset: 0x222E460 VA: 0x18222FE60
	private static void .cctor() { }

}

private enum BigInteger.GetBytesMode // TypeDefIndex: 3964
{	// Fields
	public int value__; // 0x0
	public const BigInteger.GetBytesMode AllocateArray = 0;
	public const BigInteger.GetBytesMode Count = 1;
	public const BigInteger.GetBytesMode Span = 2;

}

