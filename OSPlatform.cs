public struct OSPlatform : IEquatable<OSPlatform> // TypeDefIndex: 1319
{	// Fields
	private readonly string _osPlatform; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static readonly OSPlatform <Linux>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static readonly OSPlatform <OSX>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static readonly OSPlatform <Windows>k__BackingField; // 0x10

	// Properties
	public static OSPlatform Linux { get; }
	public static OSPlatform OSX { get; }
	public static OSPlatform Windows { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFEB530 Offset: 0xFE9B30 VA: 0x180FEB530
	public static OSPlatform get_Linux() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFEB590 Offset: 0xFE9B90 VA: 0x180FEB590
	public static OSPlatform get_OSX() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFEB5F0 Offset: 0xFE9BF0 VA: 0x180FEB5F0
	public static OSPlatform get_Windows() { }

	// RVA: 0x14C7E0 Offset: 0x14BBE0 VA: 0x18014C7E0
	private void .ctor(string osPlatform) { }

	// RVA: 0x14C6D0 Offset: 0x14BAD0 VA: 0x18014C6D0 Slot: 4
	public bool Equals(OSPlatform other) { }

	// RVA: 0x14C6D0 Offset: 0x14BAD0 VA: 0x18014C6D0
	internal bool Equals(string other) { }

	// RVA: 0x14C6E0 Offset: 0x14BAE0 VA: 0x18014C6E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C770 Offset: 0x14BB70 VA: 0x18014C770 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x14C790 Offset: 0x14BB90 VA: 0x18014C790 Slot: 3
	public override string ToString() { }

	// RVA: 0xFEB650 Offset: 0xFE9C50 VA: 0x180FEB650
	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	// RVA: 0xFEB290 Offset: 0xFE9890 VA: 0x180FEB290
	private static void .cctor() { }

}

