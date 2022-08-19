public class Random // TypeDefIndex: 288
{	// Fields
	private const int MBIG = 2147483647;
	private const int MSEED = 161803398;
	private const int MZ = 0;
	private int inext; // 0x10
	private int inextp; // 0x14
	private int[] SeedArray; // 0x18

	// Methods

	// RVA: 0x18D4C70 Offset: 0x18D3270 VA: 0x1818D4C70
	public void .ctor() { }

	// RVA: 0x18D4CA0 Offset: 0x18D32A0 VA: 0x1818D4CA0
	public void .ctor(int Seed) { }

	// RVA: 0x18D4C50 Offset: 0x18D3250 VA: 0x1818D4C50 Slot: 4
	protected virtual double Sample() { }

	// RVA: 0x18D4910 Offset: 0x18D2F10 VA: 0x1818D4910
	private int InternalSample() { }

	// RVA: 0x18D49C0 Offset: 0x18D2FC0 VA: 0x1818D49C0 Slot: 5
	public virtual int Next() { }

	// RVA: 0x18D48B0 Offset: 0x18D2EB0 VA: 0x1818D48B0
	private double GetSampleForLargeRange() { }

	// RVA: 0x18D49D0 Offset: 0x18D2FD0 VA: 0x1818D49D0 Slot: 6
	public virtual int Next(int minValue, int maxValue) { }

	// RVA: 0x18D4B60 Offset: 0x18D3160 VA: 0x1818D4B60 Slot: 7
	public virtual int Next(int maxValue) { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0 Slot: 8
	public virtual double NextDouble() { }

}

public sealed class Random // TypeDefIndex: 3487
{	// Properties
	[StaticAccessorAttribute] // RVA: 0xB42B0 Offset: 0xB36B0 VA: 0x1800B42B0
	public static Random.State state { get; set; }
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }
	public static Vector2 insideUnitCircle { get; }
	public static Vector3 onUnitSphere { get; }
	public static Quaternion rotation { get; }

	// Methods

	[StaticAccessorAttribute] // RVA: 0xB3910 Offset: 0xB2D10 VA: 0x1800B3910
	[NativeMethodAttribute] // RVA: 0xB3910 Offset: 0xB2D10 VA: 0x1800B3910
	// RVA: 0x18FFCF0 Offset: 0x18FE2F0 VA: 0x1818FFCF0
	public static void InitState(int seed) { }

	// RVA: 0x18FFFC0 Offset: 0x18FE5C0 VA: 0x1818FFFC0
	public static Random.State get_state() { }

	// RVA: 0x1900070 Offset: 0x18FE670 VA: 0x181900070
	public static void set_state(Random.State value) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x18FFD70 Offset: 0x18FE370 VA: 0x1818FFD70
	public static float Range(float min, float max) { }

	// RVA: 0x18FFD30 Offset: 0x18FE330 VA: 0x1818FFD30
	public static int Range(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x18FFD30 Offset: 0x18FE330 VA: 0x1818FFD30
	private static int RandomRangeInt(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x1900000 Offset: 0x18FE600 VA: 0x181900000
	public static float get_value() { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x18FFE40 Offset: 0x18FE440 VA: 0x1818FFE40
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x18FFCB0 Offset: 0x18FE2B0 VA: 0x1818FFCB0
	private static void GetRandomUnitCircle(out Vector2 output) { }

	// RVA: 0x18FFDC0 Offset: 0x18FE3C0 VA: 0x1818FFDC0
	public static Vector2 get_insideUnitCircle() { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x18FFEC0 Offset: 0x18FE4C0 VA: 0x1818FFEC0
	public static Vector3 get_onUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A300 Offset: 0x79700 VA: 0x18007A300
	// RVA: 0x18FFF40 Offset: 0x18FE540 VA: 0x1818FFF40
	public static Quaternion get_rotation() { }

	[ObsoleteAttribute] // RVA: 0xB4160 Offset: 0xB3560 VA: 0x1800B4160
	// RVA: 0x18FFD30 Offset: 0x18FE330 VA: 0x1818FFD30
	public static int RandomRange(int min, int max) { }

	// RVA: 0x18FFAF0 Offset: 0x18FE0F0 VA: 0x1818FFAF0
	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	// RVA: 0x18FFF80 Offset: 0x18FE580 VA: 0x1818FFF80
	private static void get_state_Injected(out Random.State ret) { }

	// RVA: 0x1900030 Offset: 0x18FE630 VA: 0x181900030
	private static void set_state_Injected(ref Random.State value) { }

	// RVA: 0x18FFE00 Offset: 0x18FE400 VA: 0x1818FFE00
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x18FFE80 Offset: 0x18FE480 VA: 0x1818FFE80
	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x18FFF00 Offset: 0x18FE500 VA: 0x1818FFF00
	private static void get_rotation_Injected(out Quaternion ret) { }

}

public struct Random.State // TypeDefIndex: 3488
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int s0; // 0x0
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int s1; // 0x4
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int s2; // 0x8
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int s3; // 0xC

}

