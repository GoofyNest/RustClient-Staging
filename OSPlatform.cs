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
	// RVA: 0xFEB530 Offset: 0xFE9B30 VA: 0x180FEB530
	public static OSPlatform get_Linux() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEB590 Offset: 0xFE9B90 VA: 0x180FEB590
	public static OSPlatform get_OSX() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFEB5F0 Offset: 0xFE9BF0 VA: 0x180FEB5F0
	public static OSPlatform get_Windows() { }

	// RVA: 0x14C760 Offset: 0x14BB60 VA: 0x18014C760
	private void .ctor(string osPlatform) { }

	// RVA: 0x14C650 Offset: 0x14BA50 VA: 0x18014C650 Slot: 4
	public bool Equals(OSPlatform other) { }

	// RVA: 0x14C650 Offset: 0x14BA50 VA: 0x18014C650
	internal bool Equals(string other) { }

	// RVA: 0x14C660 Offset: 0x14BA60 VA: 0x18014C660 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C6F0 Offset: 0x14BAF0 VA: 0x18014C6F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14C710 Offset: 0x14BB10 VA: 0x18014C710 Slot: 3
	public override string ToString() { }

	// RVA: 0xFEB650 Offset: 0xFE9C50 VA: 0x180FEB650
	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	// RVA: 0xFEB290 Offset: 0xFE9890 VA: 0x180FEB290
	private static void .cctor() { }

}

