public sealed class NotEnoughBytesException : MidiException // TypeDefIndex: 7579
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <ExpectedCount>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <ActualCount>k__BackingField; // 0x90

	// Methods

	// RVA: 0x139FBA0 Offset: 0x139E1A0 VA: 0x18139FBA0
	internal void .ctor(string message, Exception innerException) { }

	// RVA: 0x13A2E80 Offset: 0x13A1480 VA: 0x1813A2E80
	internal void .ctor(string message, long expectedCount, long actualCount) { }

}

