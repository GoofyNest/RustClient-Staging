public struct OSPlatform : IEquatable<OSPlatform> // TypeDefIndex: 1319
{	// Fields
	private readonly string _osPlatform; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static readonly OSPlatform <Linux>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static readonly OSPlatform <OSX>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static readonly OSPlatform <Windows>k__BackingField; // 0x10

	// Properties
	public static OSPlatform Linux { get; }
	public static OSPlatform OSX { get; }
	public static OSPlatform Windows { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEC290 Offset: 0xFEA890 VA: 0x180FEC290
	public static OSPlatform get_Linux() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEC2F0 Offset: 0xFEA8F0 VA: 0x180FEC2F0
	public static OSPlatform get_OSX() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEC350 Offset: 0xFEA950 VA: 0x180FEC350
	public static OSPlatform get_Windows() { }

	// RVA: 0x14C580 Offset: 0x14B980 VA: 0x18014C580
	private void .ctor(string osPlatform) { }

	// RVA: 0x14C470 Offset: 0x14B870 VA: 0x18014C470 Slot: 4
	public bool Equals(OSPlatform other) { }

	// RVA: 0x14C470 Offset: 0x14B870 VA: 0x18014C470
	internal bool Equals(string other) { }

	// RVA: 0x14C480 Offset: 0x14B880 VA: 0x18014C480 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C510 Offset: 0x14B910 VA: 0x18014C510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14C530 Offset: 0x14B930 VA: 0x18014C530 Slot: 3
	public override string ToString() { }

	// RVA: 0xFEC3B0 Offset: 0xFEA9B0 VA: 0x180FEC3B0
	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	// RVA: 0xFEBFF0 Offset: 0xFEA5F0 VA: 0x180FEBFF0
	private static void .cctor() { }

}

