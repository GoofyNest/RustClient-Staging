public static class Math // TypeDefIndex: 266
{	// Fields
	private static double doubleRoundLimit; // 0x0
	private const int maxRoundingDigits = 15;
	private static double[] roundPower10Double; // 0x8
	public const double PI = 3,14159265358979;
	public const double E = 2,71828182845905;

	// Methods

	// RVA: 0x1672AA0 Offset: 0x16710A0 VA: 0x181672AA0
	public static double Acos(double d) { }

	// RVA: 0x1672AB0 Offset: 0x16710B0 VA: 0x181672AB0
	public static double Asin(double d) { }

	// RVA: 0x1672AD0 Offset: 0x16710D0 VA: 0x181672AD0
	public static double Atan(double d) { }

	// RVA: 0x1672AC0 Offset: 0x16710C0 VA: 0x181672AC0
	public static double Atan2(double y, double x) { }

	// RVA: 0x1672AE0 Offset: 0x16710E0 VA: 0x181672AE0
	public static double Ceiling(double a) { }

	// RVA: 0x1672AF0 Offset: 0x16710F0 VA: 0x181672AF0
	public static double Cos(double d) { }

	// RVA: 0x1672B00 Offset: 0x1671100 VA: 0x181672B00
	public static double Cosh(double value) { }

	// RVA: 0x1672B30 Offset: 0x1671130 VA: 0x181672B30
	public static double Floor(double d) { }

	// RVA: 0x1672B40 Offset: 0x1671140 VA: 0x181672B40
	private static double InternalRound(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x1672DA0 Offset: 0x16713A0 VA: 0x181672DA0
	private static double InternalTruncate(double d) { }

	// RVA: 0x1673830 Offset: 0x1671E30 VA: 0x181673830
	public static double Sin(double a) { }

	// RVA: 0x1673870 Offset: 0x1671E70 VA: 0x181673870
	public static double Tan(double a) { }

	// RVA: 0x1673840 Offset: 0x1671E40 VA: 0x181673840
	public static double Sinh(double value) { }

	// RVA: 0x1673510 Offset: 0x1671B10 VA: 0x181673510
	public static double Round(double a) { }

	// RVA: 0x1673390 Offset: 0x1671990 VA: 0x181673390
	public static double Round(double value, MidpointRounding mode) { }

	// RVA: 0x1673520 Offset: 0x1671B20 VA: 0x181673520
	public static double Round(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x16736B0 Offset: 0x1671CB0 VA: 0x1816736B0
	public static Decimal Round(Decimal d) { }

	// RVA: 0x1673850 Offset: 0x1671E50 VA: 0x181673850
	private static double SplitFractionDouble(double* value) { }

	// RVA: 0x1673880 Offset: 0x1671E80 VA: 0x181673880
	public static double Truncate(double d) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673860 Offset: 0x1671E60 VA: 0x181673860
	public static double Sqrt(double d) { }

	// RVA: 0x1672F70 Offset: 0x1671570 VA: 0x181672F70
	public static double Log(double d) { }

	// RVA: 0x1672E00 Offset: 0x1671400 VA: 0x181672E00
	public static double Log10(double d) { }

	// RVA: 0x1672B20 Offset: 0x1671120 VA: 0x181672B20
	public static double Exp(double d) { }

	// RVA: 0x1673380 Offset: 0x1671980 VA: 0x181673380
	public static double Pow(double x, double y) { }

	// RVA: 0x16729D0 Offset: 0x1670FD0 VA: 0x1816729D0
	public static int Abs(int value) { }

	// RVA: 0x1672870 Offset: 0x1670E70 VA: 0x181672870
	private static int AbsHelper(int value) { }

	// RVA: 0x16728F0 Offset: 0x1670EF0 VA: 0x1816728F0
	public static long Abs(long value) { }

	// RVA: 0x16727E0 Offset: 0x1670DE0 VA: 0x1816727E0
	private static long AbsHelper(long value) { }

	// RVA: 0x1672A90 Offset: 0x1671090 VA: 0x181672A90
	public static float Abs(float value) { }

	// RVA: 0x16729C0 Offset: 0x1670FC0 VA: 0x1816729C0
	public static double Abs(double value) { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	// RVA: 0x1673020 Offset: 0x1671620 VA: 0x181673020
	public static sbyte Max(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1672F90 Offset: 0x1671590 VA: 0x181672F90
	public static byte Max(byte val1, byte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673170 Offset: 0x1671770 VA: 0x181673170
	public static short Max(short val1, short val2) { }

	[ReliabilityContractAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	[CLSCompliantAttribute] // RVA: 0x7D860 Offset: 0x7CC60 VA: 0x18007D860
	// RVA: 0x1672FB0 Offset: 0x16715B0 VA: 0x181672FB0
	public static ushort Max(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16730D0 Offset: 0x16716D0 VA: 0x1816730D0
	public static int Max(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1672FA0 Offset: 0x16715A0 VA: 0x181672FA0
	public static uint Max(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1672F80 Offset: 0x1671580 VA: 0x181672F80
	public static long Max(long val1, long val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1673010 Offset: 0x1671610 VA: 0x181673010
	public static ulong Max(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1672FC0 Offset: 0x16715C0 VA: 0x181672FC0
	public static float Max(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16730E0 Offset: 0x16716E0 VA: 0x1816730E0
	public static double Max(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673030 Offset: 0x1671630 VA: 0x181673030
	public static Decimal Max(Decimal val1, Decimal val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1673370 Offset: 0x1671970 VA: 0x181673370
	public static sbyte Min(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673230 Offset: 0x1671830 VA: 0x181673230
	public static byte Min(byte val1, byte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673240 Offset: 0x1671840 VA: 0x181673240
	public static short Min(short val1, short val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1673210 Offset: 0x1671810 VA: 0x181673210
	public static ushort Min(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673340 Offset: 0x1671940 VA: 0x181673340
	public static int Min(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1673360 Offset: 0x1671960 VA: 0x181673360
	public static uint Min(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673220 Offset: 0x1671820 VA: 0x181673220
	public static long Min(long val1, long val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	[ReliabilityContractAttribute] // RVA: 0x7DCF0 Offset: 0x7D0F0 VA: 0x18007DCF0
	// RVA: 0x1673350 Offset: 0x1671950 VA: 0x181673350
	public static ulong Min(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673250 Offset: 0x1671850 VA: 0x181673250
	public static float Min(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1673180 Offset: 0x1671780 VA: 0x181673180
	public static double Min(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x16732A0 Offset: 0x16718A0 VA: 0x1816732A0
	public static Decimal Min(Decimal val1, Decimal val2) { }

	// RVA: 0x1672E10 Offset: 0x1671410 VA: 0x181672E10
	public static double Log(double a, double newBase) { }

	// RVA: 0x16737F0 Offset: 0x1671DF0 VA: 0x1816737F0
	public static int Sign(int value) { }

	// RVA: 0x1673810 Offset: 0x1671E10 VA: 0x181673810
	public static int Sign(long value) { }

	// RVA: 0x1673730 Offset: 0x1671D30 VA: 0x181673730
	public static int Sign(double value) { }

	// RVA: 0x1672B10 Offset: 0x1671110 VA: 0x181672B10
	public static long DivRem(long a, long b, out long result) { }

	// RVA: 0x1673930 Offset: 0x1671F30 VA: 0x181673930
	private static void .cctor() { }

}

public static class math // TypeDefIndex: 7099
{
// Namespace: Unity.Mathematics
public static class math // TypeDefIndex: 7099
	// Methods

	// RVA: 0x22AF590 Offset: 0x22ADB90 VA: 0x1822AF590
	public static float2 float2(float x, float y) { }

	// RVA: 0x22AF800 Offset: 0x22ADE00 VA: 0x1822AF800
	public static uint hash(float2 v) { }

	// RVA: 0x22AFA20 Offset: 0x22AE020 VA: 0x1822AFA20
	public static uint hash(float3 v) { }

	// RVA: 0x22AF5E0 Offset: 0x22ADBE0 VA: 0x1822AF5E0
	public static float4 float4(float x, float y, float z, float w) { }

	// RVA: 0x22AF5A0 Offset: 0x22ADBA0 VA: 0x1822AF5A0
	public static float4 float4(float3 xyz, float w) { }

	// RVA: 0x22AF640 Offset: 0x22ADC40 VA: 0x1822AF640
	public static uint hash(float4 v) { }

	// RVA: 0x22AF600 Offset: 0x22ADC00 VA: 0x1822AF600
	public static uint hash(half2 v) { }

	// RVA: 0x22AFAC0 Offset: 0x22AE0C0 VA: 0x1822AFAC0
	public static int2 int2(int x, int y) { }

	// RVA: 0x22AF7D0 Offset: 0x22ADDD0 VA: 0x1822AF7D0
	public static uint hash(int2 v) { }

	// RVA: 0x22AF120 Offset: 0x22AD720 VA: 0x1822AF120
	public static int asint(float x) { }

	// RVA: 0x2272550 Offset: 0x2270B50 VA: 0x182272550
	public static uint2 asuint(int2 x) { }

	// RVA: 0x22AF120 Offset: 0x22AD720 VA: 0x1822AF120
	public static uint asuint(float x) { }

	// RVA: 0x22AF200 Offset: 0x22AD800 VA: 0x1822AF200
	public static uint2 asuint(float2 x) { }

	// RVA: 0x22AF130 Offset: 0x22AD730 VA: 0x1822AF130
	public static uint3 asuint(float3 x) { }

	// RVA: 0x22AF1A0 Offset: 0x22AD7A0 VA: 0x1822AF1A0
	public static uint4 asuint(float4 x) { }

	// RVA: 0x22AF110 Offset: 0x22AD710 VA: 0x1822AF110
	public static float asfloat(int x) { }

	// RVA: 0x22AF110 Offset: 0x22AD710 VA: 0x1822AF110
	public static float asfloat(uint x) { }

	// RVA: 0x22AFE10 Offset: 0x22AE410 VA: 0x1822AFE10
	public static int min(int x, int y) { }

	// RVA: 0x22AFDE0 Offset: 0x22AE3E0 VA: 0x1822AFDE0
	public static int2 min(int2 x, int2 y) { }

	// RVA: 0x223F650 Offset: 0x223DC50 VA: 0x18223F650
	public static float min(float x, float y) { }

	// RVA: 0x22AFDD0 Offset: 0x22AE3D0 VA: 0x1822AFDD0
	public static int max(int x, int y) { }

	// RVA: 0x22AFDA0 Offset: 0x22AE3A0 VA: 0x1822AFDA0
	public static int2 max(int2 x, int2 y) { }

	// RVA: 0x223FD90 Offset: 0x223E390 VA: 0x18223FD90
	public static float max(float x, float y) { }

	// RVA: 0x22AFCE0 Offset: 0x22AE2E0 VA: 0x1822AFCE0
	public static float3 lerp(float3 x, float3 y, float s) { }

	// RVA: 0x22AFC20 Offset: 0x22AE220 VA: 0x1822AFC20
	public static float4 lerp(float4 x, float4 y, float s) { }

	// RVA: 0x22AF240 Offset: 0x22AD840 VA: 0x1822AF240
	public static int2 clamp(int2 x, int2 a, int2 b) { }

	// RVA: 0x22AF280 Offset: 0x22AD880 VA: 0x1822AF280
	public static float clamp(float x, float a, float b) { }

	// RVA: 0x22AF490 Offset: 0x22ADA90 VA: 0x1822AF490
	public static float dot(float3 x, float3 y) { }

	// RVA: 0x22AF440 Offset: 0x22ADA40 VA: 0x1822AF440
	public static float dot(float4 x, float4 y) { }

	// RVA: 0x22AF2F0 Offset: 0x22AD8F0 VA: 0x1822AF2F0
	public static float cos(float x) { }

	// RVA: 0x22AF080 Offset: 0x22AD680 VA: 0x1822AF080
	public static float acos(float x) { }

	// RVA: 0x22B0700 Offset: 0x22AED00 VA: 0x1822B0700
	public static float sin(float x) { }

	// RVA: 0x22B0640 Offset: 0x22AEC40 VA: 0x1822B0640
	public static float rcp(float x) { }

	// RVA: 0x22B0C60 Offset: 0x22AF260 VA: 0x1822B0C60
	public static float sqrt(float x) { }

	// RVA: 0x22B0650 Offset: 0x22AEC50 VA: 0x1822B0650
	public static float rsqrt(float x) { }

	// RVA: 0x22B03D0 Offset: 0x22AE9D0 VA: 0x1822B03D0
	public static float3 normalizesafe(float3 x, float3 defaultvalue) { }

	// RVA: 0x22AFB80 Offset: 0x22AE180 VA: 0x1822AFB80
	public static float length(float3 x) { }

	// RVA: 0x22AF350 Offset: 0x22AD950 VA: 0x1822AF350
	public static float3 cross(float3 x, float3 y) { }

	// RVA: 0x22AF0E0 Offset: 0x22AD6E0 VA: 0x1822AF0E0
	public static bool any(float2 x) { }

	// RVA: 0x22B06C0 Offset: 0x22AECC0 VA: 0x1822B06C0
	public static uint select(uint a, uint b, bool c) { }

	// RVA: 0x22B06D0 Offset: 0x22AECD0 VA: 0x1822B06D0
	public static float3 select(float3 a, float3 b, bool c) { }

	// RVA: 0x22B0500 Offset: 0x22AEB00 VA: 0x1822B0500
	public static float3 project(float3 a, float3 b) { }

	// RVA: 0x22B0760 Offset: 0x22AED60 VA: 0x1822B0760
	public static void sincos(float x, out float s, out float c) { }

	// RVA: 0x22AF3E0 Offset: 0x22AD9E0 VA: 0x1822AF3E0
	public static uint csum(uint2 x) { }

	// RVA: 0x22AF3F0 Offset: 0x22AD9F0 VA: 0x1822AF3F0
	public static uint csum(uint3 x) { }

	// RVA: 0x22AF410 Offset: 0x22ADA10 VA: 0x1822AF410
	public static uint csum(uint4 x) { }

	// RVA: 0x22AF520 Offset: 0x22ADB20 VA: 0x1822AF520
	public static float f16tof32(uint x) { }

	// RVA: 0x22B0630 Offset: 0x22AEC30 VA: 0x1822B0630
	public static quaternion quaternion(float4 value) { }

	// RVA: 0x22AFAD0 Offset: 0x22AE0D0 VA: 0x1822AFAD0
	public static quaternion inverse(quaternion q) { }

	// RVA: 0x22AF4D0 Offset: 0x22ADAD0 VA: 0x1822AF4D0
	public static float dot(quaternion a, quaternion b) { }

	// RVA: 0x22B02A0 Offset: 0x22AE8A0 VA: 0x1822B02A0
	public static quaternion normalize(quaternion q) { }

	// RVA: 0x223FF60 Offset: 0x223E560 VA: 0x18223FF60
	public static quaternion mul(quaternion a, quaternion b) { }

	// RVA: 0x223FDE0 Offset: 0x223E3E0 VA: 0x18223FDE0
	public static float3 mul(quaternion q, float3 v) { }

	// RVA: 0x223FDE0 Offset: 0x223E3E0 VA: 0x18223FDE0
	public static float3 rotate(quaternion q, float3 v) { }

	// RVA: 0x22B0120 Offset: 0x22AE720 VA: 0x1822B0120
	public static quaternion nlerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x22B0830 Offset: 0x22AEE30 VA: 0x1822B0830
	public static quaternion slerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x22AF640 Offset: 0x22ADC40 VA: 0x1822AF640
	public static uint hash(quaternion q) { }

	// RVA: 0x22AF060 Offset: 0x22AD660 VA: 0x1822AF060
	public static RigidTransform RigidTransform(quaternion rot, float3 pos) { }

	// RVA: 0x223FAD0 Offset: 0x223E0D0 VA: 0x18223FAD0
	public static RigidTransform inverse(RigidTransform t) { }

	// RVA: 0x22AFE20 Offset: 0x22AE420 VA: 0x1822AFE20
	public static RigidTransform mul(RigidTransform a, RigidTransform b) { }

	// RVA: 0x22AF8C0 Offset: 0x22ADEC0 VA: 0x1822AF8C0
	public static uint hash(RigidTransform t) { }

	// RVA: 0x22AFAC0 Offset: 0x22AE0C0 VA: 0x1822AFAC0
	public static uint2 uint2(uint x, uint y) { }

	// RVA: 0x22AF620 Offset: 0x22ADC20 VA: 0x1822AF620
	public static uint hash(uint2 v) { }

	// RVA: 0x22B0CC0 Offset: 0x22AF2C0 VA: 0x1822B0CC0
	public static uint3 uint3(uint x, uint y, uint z) { }

	// RVA: 0x22AF850 Offset: 0x22ADE50 VA: 0x1822AF850
	public static uint hash(uint3 v) { }

	// RVA: 0x22B0CD0 Offset: 0x22AF2D0 VA: 0x1822B0CD0
	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

	// RVA: 0x22AF720 Offset: 0x22ADD20 VA: 0x1822AF720
	public static uint hash(uint4 v) { }

}

internal struct math.IntFloatUnion // TypeDefIndex: 7100
{	// Fields
	public int intValue; // 0x0
	public float floatValue; // 0x0

}

