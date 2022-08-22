public static class Math // TypeDefIndex: 266
{	// Fields
	private static double doubleRoundLimit; // 0x0
	private const int maxRoundingDigits = 15;
	private static double[] roundPower10Double; // 0x8
	public const double PI = 3,14159265358979;
	public const double E = 2,71828182845905;

	// Methods

	// RVA: 0x1674BF0 Offset: 0x16731F0 VA: 0x181674BF0
	public static double Acos(double d) { }

	// RVA: 0x1674C00 Offset: 0x1673200 VA: 0x181674C00
	public static double Asin(double d) { }

	// RVA: 0x1674C20 Offset: 0x1673220 VA: 0x181674C20
	public static double Atan(double d) { }

	// RVA: 0x1674C10 Offset: 0x1673210 VA: 0x181674C10
	public static double Atan2(double y, double x) { }

	// RVA: 0x1674C30 Offset: 0x1673230 VA: 0x181674C30
	public static double Ceiling(double a) { }

	// RVA: 0x1674C40 Offset: 0x1673240 VA: 0x181674C40
	public static double Cos(double d) { }

	// RVA: 0x1674C50 Offset: 0x1673250 VA: 0x181674C50
	public static double Cosh(double value) { }

	// RVA: 0x1674C80 Offset: 0x1673280 VA: 0x181674C80
	public static double Floor(double d) { }

	// RVA: 0x1674C90 Offset: 0x1673290 VA: 0x181674C90
	private static double InternalRound(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x1674EF0 Offset: 0x16734F0 VA: 0x181674EF0
	private static double InternalTruncate(double d) { }

	// RVA: 0x1675980 Offset: 0x1673F80 VA: 0x181675980
	public static double Sin(double a) { }

	// RVA: 0x16759C0 Offset: 0x1673FC0 VA: 0x1816759C0
	public static double Tan(double a) { }

	// RVA: 0x1675990 Offset: 0x1673F90 VA: 0x181675990
	public static double Sinh(double value) { }

	// RVA: 0x1675660 Offset: 0x1673C60 VA: 0x181675660
	public static double Round(double a) { }

	// RVA: 0x16754E0 Offset: 0x1673AE0 VA: 0x1816754E0
	public static double Round(double value, MidpointRounding mode) { }

	// RVA: 0x1675670 Offset: 0x1673C70 VA: 0x181675670
	public static double Round(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x1675800 Offset: 0x1673E00 VA: 0x181675800
	public static Decimal Round(Decimal d) { }

	// RVA: 0x16759A0 Offset: 0x1673FA0 VA: 0x1816759A0
	private static double SplitFractionDouble(double* value) { }

	// RVA: 0x16759D0 Offset: 0x1673FD0 VA: 0x1816759D0
	public static double Truncate(double d) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16759B0 Offset: 0x1673FB0 VA: 0x1816759B0
	public static double Sqrt(double d) { }

	// RVA: 0x16750C0 Offset: 0x16736C0 VA: 0x1816750C0
	public static double Log(double d) { }

	// RVA: 0x1674F50 Offset: 0x1673550 VA: 0x181674F50
	public static double Log10(double d) { }

	// RVA: 0x1674C70 Offset: 0x1673270 VA: 0x181674C70
	public static double Exp(double d) { }

	// RVA: 0x16754D0 Offset: 0x1673AD0 VA: 0x1816754D0
	public static double Pow(double x, double y) { }

	// RVA: 0x1674B20 Offset: 0x1673120 VA: 0x181674B20
	public static int Abs(int value) { }

	// RVA: 0x16749C0 Offset: 0x1672FC0 VA: 0x1816749C0
	private static int AbsHelper(int value) { }

	// RVA: 0x1674A40 Offset: 0x1673040 VA: 0x181674A40
	public static long Abs(long value) { }

	// RVA: 0x1674930 Offset: 0x1672F30 VA: 0x181674930
	private static long AbsHelper(long value) { }

	// RVA: 0x1674BE0 Offset: 0x16731E0 VA: 0x181674BE0
	public static float Abs(float value) { }

	// RVA: 0x1674B10 Offset: 0x1673110 VA: 0x181674B10
	public static double Abs(double value) { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	// RVA: 0x1675170 Offset: 0x1673770 VA: 0x181675170
	public static sbyte Max(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16750E0 Offset: 0x16736E0 VA: 0x1816750E0
	public static byte Max(byte val1, byte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16752C0 Offset: 0x16738C0 VA: 0x1816752C0
	public static short Max(short val1, short val2) { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	// RVA: 0x1675100 Offset: 0x1673700 VA: 0x181675100
	public static ushort Max(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675220 Offset: 0x1673820 VA: 0x181675220
	public static int Max(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x16750F0 Offset: 0x16736F0 VA: 0x1816750F0
	public static uint Max(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16750D0 Offset: 0x16736D0 VA: 0x1816750D0
	public static long Max(long val1, long val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1675160 Offset: 0x1673760 VA: 0x181675160
	public static ulong Max(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675110 Offset: 0x1673710 VA: 0x181675110
	public static float Max(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675230 Offset: 0x1673830 VA: 0x181675230
	public static double Max(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675180 Offset: 0x1673780 VA: 0x181675180
	public static Decimal Max(Decimal val1, Decimal val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x16754C0 Offset: 0x1673AC0 VA: 0x1816754C0
	public static sbyte Min(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675380 Offset: 0x1673980 VA: 0x181675380
	public static byte Min(byte val1, byte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675390 Offset: 0x1673990 VA: 0x181675390
	public static short Min(short val1, short val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1675360 Offset: 0x1673960 VA: 0x181675360
	public static ushort Min(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675490 Offset: 0x1673A90 VA: 0x181675490
	public static int Min(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x16754B0 Offset: 0x1673AB0 VA: 0x1816754B0
	public static uint Min(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1675370 Offset: 0x1673970 VA: 0x181675370
	public static long Min(long val1, long val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x16754A0 Offset: 0x1673AA0 VA: 0x1816754A0
	public static ulong Min(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16753A0 Offset: 0x16739A0 VA: 0x1816753A0
	public static float Min(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16752D0 Offset: 0x16738D0 VA: 0x1816752D0
	public static double Min(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16753F0 Offset: 0x16739F0 VA: 0x1816753F0
	public static Decimal Min(Decimal val1, Decimal val2) { }

	// RVA: 0x1674F60 Offset: 0x1673560 VA: 0x181674F60
	public static double Log(double a, double newBase) { }

	// RVA: 0x1675940 Offset: 0x1673F40 VA: 0x181675940
	public static int Sign(int value) { }

	// RVA: 0x1675960 Offset: 0x1673F60 VA: 0x181675960
	public static int Sign(long value) { }

	// RVA: 0x1675880 Offset: 0x1673E80 VA: 0x181675880
	public static int Sign(double value) { }

	// RVA: 0x1674C60 Offset: 0x1673260 VA: 0x181674C60
	public static long DivRem(long a, long b, out long result) { }

	// RVA: 0x1675A80 Offset: 0x1674080 VA: 0x181675A80
	private static void .cctor() { }

}

public static class math // TypeDefIndex: 7099
{
// Namespace: Unity.Mathematics
public static class math // TypeDefIndex: 7099
	// Methods

	// RVA: 0x22AEAB0 Offset: 0x22AD0B0 VA: 0x1822AEAB0
	public static float2 float2(float x, float y) { }

	// RVA: 0x22AED20 Offset: 0x22AD320 VA: 0x1822AED20
	public static uint hash(float2 v) { }

	// RVA: 0x22AEF40 Offset: 0x22AD540 VA: 0x1822AEF40
	public static uint hash(float3 v) { }

	// RVA: 0x22AEB00 Offset: 0x22AD100 VA: 0x1822AEB00
	public static float4 float4(float x, float y, float z, float w) { }

	// RVA: 0x22AEAC0 Offset: 0x22AD0C0 VA: 0x1822AEAC0
	public static float4 float4(float3 xyz, float w) { }

	// RVA: 0x22AEB60 Offset: 0x22AD160 VA: 0x1822AEB60
	public static uint hash(float4 v) { }

	// RVA: 0x22AEB20 Offset: 0x22AD120 VA: 0x1822AEB20
	public static uint hash(half2 v) { }

	// RVA: 0x22AEFE0 Offset: 0x22AD5E0 VA: 0x1822AEFE0
	public static int2 int2(int x, int y) { }

	// RVA: 0x22AECF0 Offset: 0x22AD2F0 VA: 0x1822AECF0
	public static uint hash(int2 v) { }

	// RVA: 0x22AE640 Offset: 0x22ACC40 VA: 0x1822AE640
	public static int asint(float x) { }

	// RVA: 0x2271A70 Offset: 0x2270070 VA: 0x182271A70
	public static uint2 asuint(int2 x) { }

	// RVA: 0x22AE640 Offset: 0x22ACC40 VA: 0x1822AE640
	public static uint asuint(float x) { }

	// RVA: 0x22AE720 Offset: 0x22ACD20 VA: 0x1822AE720
	public static uint2 asuint(float2 x) { }

	// RVA: 0x22AE650 Offset: 0x22ACC50 VA: 0x1822AE650
	public static uint3 asuint(float3 x) { }

	// RVA: 0x22AE6C0 Offset: 0x22ACCC0 VA: 0x1822AE6C0
	public static uint4 asuint(float4 x) { }

	// RVA: 0x22AE630 Offset: 0x22ACC30 VA: 0x1822AE630
	public static float asfloat(int x) { }

	// RVA: 0x22AE630 Offset: 0x22ACC30 VA: 0x1822AE630
	public static float asfloat(uint x) { }

	// RVA: 0x22AF330 Offset: 0x22AD930 VA: 0x1822AF330
	public static int min(int x, int y) { }

	// RVA: 0x22AF300 Offset: 0x22AD900 VA: 0x1822AF300
	public static int2 min(int2 x, int2 y) { }

	// RVA: 0x223EB70 Offset: 0x223D170 VA: 0x18223EB70
	public static float min(float x, float y) { }

	// RVA: 0x22AF2F0 Offset: 0x22AD8F0 VA: 0x1822AF2F0
	public static int max(int x, int y) { }

	// RVA: 0x22AF2C0 Offset: 0x22AD8C0 VA: 0x1822AF2C0
	public static int2 max(int2 x, int2 y) { }

	// RVA: 0x223F2B0 Offset: 0x223D8B0 VA: 0x18223F2B0
	public static float max(float x, float y) { }

	// RVA: 0x22AF200 Offset: 0x22AD800 VA: 0x1822AF200
	public static float3 lerp(float3 x, float3 y, float s) { }

	// RVA: 0x22AF140 Offset: 0x22AD740 VA: 0x1822AF140
	public static float4 lerp(float4 x, float4 y, float s) { }

	// RVA: 0x22AE760 Offset: 0x22ACD60 VA: 0x1822AE760
	public static int2 clamp(int2 x, int2 a, int2 b) { }

	// RVA: 0x22AE7A0 Offset: 0x22ACDA0 VA: 0x1822AE7A0
	public static float clamp(float x, float a, float b) { }

	// RVA: 0x22AE9B0 Offset: 0x22ACFB0 VA: 0x1822AE9B0
	public static float dot(float3 x, float3 y) { }

	// RVA: 0x22AE960 Offset: 0x22ACF60 VA: 0x1822AE960
	public static float dot(float4 x, float4 y) { }

	// RVA: 0x22AE810 Offset: 0x22ACE10 VA: 0x1822AE810
	public static float cos(float x) { }

	// RVA: 0x22AE5A0 Offset: 0x22ACBA0 VA: 0x1822AE5A0
	public static float acos(float x) { }

	// RVA: 0x22AFC20 Offset: 0x22AE220 VA: 0x1822AFC20
	public static float sin(float x) { }

	// RVA: 0x22AFB60 Offset: 0x22AE160 VA: 0x1822AFB60
	public static float rcp(float x) { }

	// RVA: 0x22B0180 Offset: 0x22AE780 VA: 0x1822B0180
	public static float sqrt(float x) { }

	// RVA: 0x22AFB70 Offset: 0x22AE170 VA: 0x1822AFB70
	public static float rsqrt(float x) { }

	// RVA: 0x22AF8F0 Offset: 0x22ADEF0 VA: 0x1822AF8F0
	public static float3 normalizesafe(float3 x, float3 defaultvalue) { }

	// RVA: 0x22AF0A0 Offset: 0x22AD6A0 VA: 0x1822AF0A0
	public static float length(float3 x) { }

	// RVA: 0x22AE870 Offset: 0x22ACE70 VA: 0x1822AE870
	public static float3 cross(float3 x, float3 y) { }

	// RVA: 0x22AE600 Offset: 0x22ACC00 VA: 0x1822AE600
	public static bool any(float2 x) { }

	// RVA: 0x22AFBE0 Offset: 0x22AE1E0 VA: 0x1822AFBE0
	public static uint select(uint a, uint b, bool c) { }

	// RVA: 0x22AFBF0 Offset: 0x22AE1F0 VA: 0x1822AFBF0
	public static float3 select(float3 a, float3 b, bool c) { }

	// RVA: 0x22AFA20 Offset: 0x22AE020 VA: 0x1822AFA20
	public static float3 project(float3 a, float3 b) { }

	// RVA: 0x22AFC80 Offset: 0x22AE280 VA: 0x1822AFC80
	public static void sincos(float x, out float s, out float c) { }

	// RVA: 0x22AE900 Offset: 0x22ACF00 VA: 0x1822AE900
	public static uint csum(uint2 x) { }

	// RVA: 0x22AE910 Offset: 0x22ACF10 VA: 0x1822AE910
	public static uint csum(uint3 x) { }

	// RVA: 0x22AE930 Offset: 0x22ACF30 VA: 0x1822AE930
	public static uint csum(uint4 x) { }

	// RVA: 0x22AEA40 Offset: 0x22AD040 VA: 0x1822AEA40
	public static float f16tof32(uint x) { }

	// RVA: 0x22AFB50 Offset: 0x22AE150 VA: 0x1822AFB50
	public static quaternion quaternion(float4 value) { }

	// RVA: 0x22AEFF0 Offset: 0x22AD5F0 VA: 0x1822AEFF0
	public static quaternion inverse(quaternion q) { }

	// RVA: 0x22AE9F0 Offset: 0x22ACFF0 VA: 0x1822AE9F0
	public static float dot(quaternion a, quaternion b) { }

	// RVA: 0x22AF7C0 Offset: 0x22ADDC0 VA: 0x1822AF7C0
	public static quaternion normalize(quaternion q) { }

	// RVA: 0x223F480 Offset: 0x223DA80 VA: 0x18223F480
	public static quaternion mul(quaternion a, quaternion b) { }

	// RVA: 0x223F300 Offset: 0x223D900 VA: 0x18223F300
	public static float3 mul(quaternion q, float3 v) { }

	// RVA: 0x223F300 Offset: 0x223D900 VA: 0x18223F300
	public static float3 rotate(quaternion q, float3 v) { }

	// RVA: 0x22AF640 Offset: 0x22ADC40 VA: 0x1822AF640
	public static quaternion nlerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x22AFD50 Offset: 0x22AE350 VA: 0x1822AFD50
	public static quaternion slerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x22AEB60 Offset: 0x22AD160 VA: 0x1822AEB60
	public static uint hash(quaternion q) { }

	// RVA: 0x22AE580 Offset: 0x22ACB80 VA: 0x1822AE580
	public static RigidTransform RigidTransform(quaternion rot, float3 pos) { }

	// RVA: 0x223EFF0 Offset: 0x223D5F0 VA: 0x18223EFF0
	public static RigidTransform inverse(RigidTransform t) { }

	// RVA: 0x22AF340 Offset: 0x22AD940 VA: 0x1822AF340
	public static RigidTransform mul(RigidTransform a, RigidTransform b) { }

	// RVA: 0x22AEDE0 Offset: 0x22AD3E0 VA: 0x1822AEDE0
	public static uint hash(RigidTransform t) { }

	// RVA: 0x22AEFE0 Offset: 0x22AD5E0 VA: 0x1822AEFE0
	public static uint2 uint2(uint x, uint y) { }

	// RVA: 0x22AEB40 Offset: 0x22AD140 VA: 0x1822AEB40
	public static uint hash(uint2 v) { }

	// RVA: 0x22B01E0 Offset: 0x22AE7E0 VA: 0x1822B01E0
	public static uint3 uint3(uint x, uint y, uint z) { }

	// RVA: 0x22AED70 Offset: 0x22AD370 VA: 0x1822AED70
	public static uint hash(uint3 v) { }

	// RVA: 0x22B01F0 Offset: 0x22AE7F0 VA: 0x1822B01F0
	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

	// RVA: 0x22AEC40 Offset: 0x22AD240 VA: 0x1822AEC40
	public static uint hash(uint4 v) { }

}

internal struct math.IntFloatUnion // TypeDefIndex: 7100
{	// Fields
	public int intValue; // 0x0
	public float floatValue; // 0x0

}

