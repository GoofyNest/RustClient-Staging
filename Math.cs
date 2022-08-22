public static class Math // TypeDefIndex: 266
{	// Fields
	private static double doubleRoundLimit; // 0x0
	private const int maxRoundingDigits = 15;
	private static double[] roundPower10Double; // 0x8
	public const double PI = 3,14159265358979;
	public const double E = 2,71828182845905;

	// Methods

	// RVA: 0x1674EB0 Offset: 0x16734B0 VA: 0x181674EB0
	public static double Acos(double d) { }

	// RVA: 0x1674EC0 Offset: 0x16734C0 VA: 0x181674EC0
	public static double Asin(double d) { }

	// RVA: 0x1674EE0 Offset: 0x16734E0 VA: 0x181674EE0
	public static double Atan(double d) { }

	// RVA: 0x1674ED0 Offset: 0x16734D0 VA: 0x181674ED0
	public static double Atan2(double y, double x) { }

	// RVA: 0x1674EF0 Offset: 0x16734F0 VA: 0x181674EF0
	public static double Ceiling(double a) { }

	// RVA: 0x1674F00 Offset: 0x1673500 VA: 0x181674F00
	public static double Cos(double d) { }

	// RVA: 0x1674F10 Offset: 0x1673510 VA: 0x181674F10
	public static double Cosh(double value) { }

	// RVA: 0x1674F40 Offset: 0x1673540 VA: 0x181674F40
	public static double Floor(double d) { }

	// RVA: 0x1674F50 Offset: 0x1673550 VA: 0x181674F50
	private static double InternalRound(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x16751B0 Offset: 0x16737B0 VA: 0x1816751B0
	private static double InternalTruncate(double d) { }

	// RVA: 0x1675C40 Offset: 0x1674240 VA: 0x181675C40
	public static double Sin(double a) { }

	// RVA: 0x1675C80 Offset: 0x1674280 VA: 0x181675C80
	public static double Tan(double a) { }

	// RVA: 0x1675C50 Offset: 0x1674250 VA: 0x181675C50
	public static double Sinh(double value) { }

	// RVA: 0x1675920 Offset: 0x1673F20 VA: 0x181675920
	public static double Round(double a) { }

	// RVA: 0x16757A0 Offset: 0x1673DA0 VA: 0x1816757A0
	public static double Round(double value, MidpointRounding mode) { }

	// RVA: 0x1675930 Offset: 0x1673F30 VA: 0x181675930
	public static double Round(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x1675AC0 Offset: 0x16740C0 VA: 0x181675AC0
	public static Decimal Round(Decimal d) { }

	// RVA: 0x1675C60 Offset: 0x1674260 VA: 0x181675C60
	private static double SplitFractionDouble(double* value) { }

	// RVA: 0x1675C90 Offset: 0x1674290 VA: 0x181675C90
	public static double Truncate(double d) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675C70 Offset: 0x1674270 VA: 0x181675C70
	public static double Sqrt(double d) { }

	// RVA: 0x1675380 Offset: 0x1673980 VA: 0x181675380
	public static double Log(double d) { }

	// RVA: 0x1675210 Offset: 0x1673810 VA: 0x181675210
	public static double Log10(double d) { }

	// RVA: 0x1674F30 Offset: 0x1673530 VA: 0x181674F30
	public static double Exp(double d) { }

	// RVA: 0x1675790 Offset: 0x1673D90 VA: 0x181675790
	public static double Pow(double x, double y) { }

	// RVA: 0x1674DE0 Offset: 0x16733E0 VA: 0x181674DE0
	public static int Abs(int value) { }

	// RVA: 0x1674C80 Offset: 0x1673280 VA: 0x181674C80
	private static int AbsHelper(int value) { }

	// RVA: 0x1674D00 Offset: 0x1673300 VA: 0x181674D00
	public static long Abs(long value) { }

	// RVA: 0x1674BF0 Offset: 0x16731F0 VA: 0x181674BF0
	private static long AbsHelper(long value) { }

	// RVA: 0x1674EA0 Offset: 0x16734A0 VA: 0x181674EA0
	public static float Abs(float value) { }

	// RVA: 0x1674DD0 Offset: 0x16733D0 VA: 0x181674DD0
	public static double Abs(double value) { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	// RVA: 0x1675430 Offset: 0x1673A30 VA: 0x181675430
	public static sbyte Max(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16753A0 Offset: 0x16739A0 VA: 0x1816753A0
	public static byte Max(byte val1, byte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675580 Offset: 0x1673B80 VA: 0x181675580
	public static short Max(short val1, short val2) { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	// RVA: 0x16753C0 Offset: 0x16739C0 VA: 0x1816753C0
	public static ushort Max(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16754E0 Offset: 0x1673AE0 VA: 0x1816754E0
	public static int Max(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x16753B0 Offset: 0x16739B0 VA: 0x1816753B0
	public static uint Max(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675390 Offset: 0x1673990 VA: 0x181675390
	public static long Max(long val1, long val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1675420 Offset: 0x1673A20 VA: 0x181675420
	public static ulong Max(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16753D0 Offset: 0x16739D0 VA: 0x1816753D0
	public static float Max(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16754F0 Offset: 0x1673AF0 VA: 0x1816754F0
	public static double Max(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675440 Offset: 0x1673A40 VA: 0x181675440
	public static Decimal Max(Decimal val1, Decimal val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1675780 Offset: 0x1673D80 VA: 0x181675780
	public static sbyte Min(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675640 Offset: 0x1673C40 VA: 0x181675640
	public static byte Min(byte val1, byte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675650 Offset: 0x1673C50 VA: 0x181675650
	public static short Min(short val1, short val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1675620 Offset: 0x1673C20 VA: 0x181675620
	public static ushort Min(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675750 Offset: 0x1673D50 VA: 0x181675750
	public static int Min(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1675770 Offset: 0x1673D70 VA: 0x181675770
	public static uint Min(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675630 Offset: 0x1673C30 VA: 0x181675630
	public static long Min(long val1, long val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1675760 Offset: 0x1673D60 VA: 0x181675760
	public static ulong Min(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675660 Offset: 0x1673C60 VA: 0x181675660
	public static float Min(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675590 Offset: 0x1673B90 VA: 0x181675590
	public static double Min(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16756B0 Offset: 0x1673CB0 VA: 0x1816756B0
	public static Decimal Min(Decimal val1, Decimal val2) { }

	// RVA: 0x1675220 Offset: 0x1673820 VA: 0x181675220
	public static double Log(double a, double newBase) { }

	// RVA: 0x1675C00 Offset: 0x1674200 VA: 0x181675C00
	public static int Sign(int value) { }

	// RVA: 0x1675C20 Offset: 0x1674220 VA: 0x181675C20
	public static int Sign(long value) { }

	// RVA: 0x1675B40 Offset: 0x1674140 VA: 0x181675B40
	public static int Sign(double value) { }

	// RVA: 0x1674F20 Offset: 0x1673520 VA: 0x181674F20
	public static long DivRem(long a, long b, out long result) { }

	// RVA: 0x1675D40 Offset: 0x1674340 VA: 0x181675D40
	private static void .cctor() { }

}

public static class math // TypeDefIndex: 7099
{
// Namespace: Unity.Mathematics
public static class math // TypeDefIndex: 7099
	// Methods

	// RVA: 0x22AED70 Offset: 0x22AD370 VA: 0x1822AED70
	public static float2 float2(float x, float y) { }

	// RVA: 0x22AEFE0 Offset: 0x22AD5E0 VA: 0x1822AEFE0
	public static uint hash(float2 v) { }

	// RVA: 0x22AF200 Offset: 0x22AD800 VA: 0x1822AF200
	public static uint hash(float3 v) { }

	// RVA: 0x22AEDC0 Offset: 0x22AD3C0 VA: 0x1822AEDC0
	public static float4 float4(float x, float y, float z, float w) { }

	// RVA: 0x22AED80 Offset: 0x22AD380 VA: 0x1822AED80
	public static float4 float4(float3 xyz, float w) { }

	// RVA: 0x22AEE20 Offset: 0x22AD420 VA: 0x1822AEE20
	public static uint hash(float4 v) { }

	// RVA: 0x22AEDE0 Offset: 0x22AD3E0 VA: 0x1822AEDE0
	public static uint hash(half2 v) { }

	// RVA: 0x22AF2A0 Offset: 0x22AD8A0 VA: 0x1822AF2A0
	public static int2 int2(int x, int y) { }

	// RVA: 0x22AEFB0 Offset: 0x22AD5B0 VA: 0x1822AEFB0
	public static uint hash(int2 v) { }

	// RVA: 0x22AE900 Offset: 0x22ACF00 VA: 0x1822AE900
	public static int asint(float x) { }

	// RVA: 0x2271D30 Offset: 0x2270330 VA: 0x182271D30
	public static uint2 asuint(int2 x) { }

	// RVA: 0x22AE900 Offset: 0x22ACF00 VA: 0x1822AE900
	public static uint asuint(float x) { }

	// RVA: 0x22AE9E0 Offset: 0x22ACFE0 VA: 0x1822AE9E0
	public static uint2 asuint(float2 x) { }

	// RVA: 0x22AE910 Offset: 0x22ACF10 VA: 0x1822AE910
	public static uint3 asuint(float3 x) { }

	// RVA: 0x22AE980 Offset: 0x22ACF80 VA: 0x1822AE980
	public static uint4 asuint(float4 x) { }

	// RVA: 0x22AE8F0 Offset: 0x22ACEF0 VA: 0x1822AE8F0
	public static float asfloat(int x) { }

	// RVA: 0x22AE8F0 Offset: 0x22ACEF0 VA: 0x1822AE8F0
	public static float asfloat(uint x) { }

	// RVA: 0x22AF5F0 Offset: 0x22ADBF0 VA: 0x1822AF5F0
	public static int min(int x, int y) { }

	// RVA: 0x22AF5C0 Offset: 0x22ADBC0 VA: 0x1822AF5C0
	public static int2 min(int2 x, int2 y) { }

	// RVA: 0x223EE30 Offset: 0x223D430 VA: 0x18223EE30
	public static float min(float x, float y) { }

	// RVA: 0x22AF5B0 Offset: 0x22ADBB0 VA: 0x1822AF5B0
	public static int max(int x, int y) { }

	// RVA: 0x22AF580 Offset: 0x22ADB80 VA: 0x1822AF580
	public static int2 max(int2 x, int2 y) { }

	// RVA: 0x223F570 Offset: 0x223DB70 VA: 0x18223F570
	public static float max(float x, float y) { }

	// RVA: 0x22AF4C0 Offset: 0x22ADAC0 VA: 0x1822AF4C0
	public static float3 lerp(float3 x, float3 y, float s) { }

	// RVA: 0x22AF400 Offset: 0x22ADA00 VA: 0x1822AF400
	public static float4 lerp(float4 x, float4 y, float s) { }

	// RVA: 0x22AEA20 Offset: 0x22AD020 VA: 0x1822AEA20
	public static int2 clamp(int2 x, int2 a, int2 b) { }

	// RVA: 0x22AEA60 Offset: 0x22AD060 VA: 0x1822AEA60
	public static float clamp(float x, float a, float b) { }

	// RVA: 0x22AEC70 Offset: 0x22AD270 VA: 0x1822AEC70
	public static float dot(float3 x, float3 y) { }

	// RVA: 0x22AEC20 Offset: 0x22AD220 VA: 0x1822AEC20
	public static float dot(float4 x, float4 y) { }

	// RVA: 0x22AEAD0 Offset: 0x22AD0D0 VA: 0x1822AEAD0
	public static float cos(float x) { }

	// RVA: 0x22AE860 Offset: 0x22ACE60 VA: 0x1822AE860
	public static float acos(float x) { }

	// RVA: 0x22AFEE0 Offset: 0x22AE4E0 VA: 0x1822AFEE0
	public static float sin(float x) { }

	// RVA: 0x22AFE20 Offset: 0x22AE420 VA: 0x1822AFE20
	public static float rcp(float x) { }

	// RVA: 0x22B0440 Offset: 0x22AEA40 VA: 0x1822B0440
	public static float sqrt(float x) { }

	// RVA: 0x22AFE30 Offset: 0x22AE430 VA: 0x1822AFE30
	public static float rsqrt(float x) { }

	// RVA: 0x22AFBB0 Offset: 0x22AE1B0 VA: 0x1822AFBB0
	public static float3 normalizesafe(float3 x, float3 defaultvalue) { }

	// RVA: 0x22AF360 Offset: 0x22AD960 VA: 0x1822AF360
	public static float length(float3 x) { }

	// RVA: 0x22AEB30 Offset: 0x22AD130 VA: 0x1822AEB30
	public static float3 cross(float3 x, float3 y) { }

	// RVA: 0x22AE8C0 Offset: 0x22ACEC0 VA: 0x1822AE8C0
	public static bool any(float2 x) { }

	// RVA: 0x22AFEA0 Offset: 0x22AE4A0 VA: 0x1822AFEA0
	public static uint select(uint a, uint b, bool c) { }

	// RVA: 0x22AFEB0 Offset: 0x22AE4B0 VA: 0x1822AFEB0
	public static float3 select(float3 a, float3 b, bool c) { }

	// RVA: 0x22AFCE0 Offset: 0x22AE2E0 VA: 0x1822AFCE0
	public static float3 project(float3 a, float3 b) { }

	// RVA: 0x22AFF40 Offset: 0x22AE540 VA: 0x1822AFF40
	public static void sincos(float x, out float s, out float c) { }

	// RVA: 0x22AEBC0 Offset: 0x22AD1C0 VA: 0x1822AEBC0
	public static uint csum(uint2 x) { }

	// RVA: 0x22AEBD0 Offset: 0x22AD1D0 VA: 0x1822AEBD0
	public static uint csum(uint3 x) { }

	// RVA: 0x22AEBF0 Offset: 0x22AD1F0 VA: 0x1822AEBF0
	public static uint csum(uint4 x) { }

	// RVA: 0x22AED00 Offset: 0x22AD300 VA: 0x1822AED00
	public static float f16tof32(uint x) { }

	// RVA: 0x22AFE10 Offset: 0x22AE410 VA: 0x1822AFE10
	public static quaternion quaternion(float4 value) { }

	// RVA: 0x22AF2B0 Offset: 0x22AD8B0 VA: 0x1822AF2B0
	public static quaternion inverse(quaternion q) { }

	// RVA: 0x22AECB0 Offset: 0x22AD2B0 VA: 0x1822AECB0
	public static float dot(quaternion a, quaternion b) { }

	// RVA: 0x22AFA80 Offset: 0x22AE080 VA: 0x1822AFA80
	public static quaternion normalize(quaternion q) { }

	// RVA: 0x223F740 Offset: 0x223DD40 VA: 0x18223F740
	public static quaternion mul(quaternion a, quaternion b) { }

	// RVA: 0x223F5C0 Offset: 0x223DBC0 VA: 0x18223F5C0
	public static float3 mul(quaternion q, float3 v) { }

	// RVA: 0x223F5C0 Offset: 0x223DBC0 VA: 0x18223F5C0
	public static float3 rotate(quaternion q, float3 v) { }

	// RVA: 0x22AF900 Offset: 0x22ADF00 VA: 0x1822AF900
	public static quaternion nlerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x22B0010 Offset: 0x22AE610 VA: 0x1822B0010
	public static quaternion slerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x22AEE20 Offset: 0x22AD420 VA: 0x1822AEE20
	public static uint hash(quaternion q) { }

	// RVA: 0x22AE840 Offset: 0x22ACE40 VA: 0x1822AE840
	public static RigidTransform RigidTransform(quaternion rot, float3 pos) { }

	// RVA: 0x223F2B0 Offset: 0x223D8B0 VA: 0x18223F2B0
	public static RigidTransform inverse(RigidTransform t) { }

	// RVA: 0x22AF600 Offset: 0x22ADC00 VA: 0x1822AF600
	public static RigidTransform mul(RigidTransform a, RigidTransform b) { }

	// RVA: 0x22AF0A0 Offset: 0x22AD6A0 VA: 0x1822AF0A0
	public static uint hash(RigidTransform t) { }

	// RVA: 0x22AF2A0 Offset: 0x22AD8A0 VA: 0x1822AF2A0
	public static uint2 uint2(uint x, uint y) { }

	// RVA: 0x22AEE00 Offset: 0x22AD400 VA: 0x1822AEE00
	public static uint hash(uint2 v) { }

	// RVA: 0x22B04A0 Offset: 0x22AEAA0 VA: 0x1822B04A0
	public static uint3 uint3(uint x, uint y, uint z) { }

	// RVA: 0x22AF030 Offset: 0x22AD630 VA: 0x1822AF030
	public static uint hash(uint3 v) { }

	// RVA: 0x22B04B0 Offset: 0x22AEAB0 VA: 0x1822B04B0
	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

	// RVA: 0x22AEF00 Offset: 0x22AD500 VA: 0x1822AEF00
	public static uint hash(uint4 v) { }

}

internal struct math.IntFloatUnion // TypeDefIndex: 7100
{	// Fields
	public int intValue; // 0x0
	public float floatValue; // 0x0

}

