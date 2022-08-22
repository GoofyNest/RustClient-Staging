public sealed class NotEnoughBytesException : MidiException // TypeDefIndex: 7579
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <ExpectedCount>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <ActualCount>k__BackingField; // 0x90

	// Methods

	// RVA: 0x13A0AA0 Offset: 0x139F0A0 VA: 0x1813A0AA0
	internal void .ctor(string message, Exception innerException) { }

	// RVA: 0x13A3D80 Offset: 0x13A2380 VA: 0x1813A3D80
	internal void .ctor(string message, long expectedCount, long actualCount) { }

}

