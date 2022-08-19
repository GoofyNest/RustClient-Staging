public sealed class NotEnoughBytesException : MidiException // TypeDefIndex: 7579
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly long <ExpectedCount>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private readonly long <ActualCount>k__BackingField; // 0x90

	// Methods

	// RVA: 0x13A07E0 Offset: 0x139EDE0 VA: 0x1813A07E0
	internal void .ctor(string message, Exception innerException) { }

	// RVA: 0x13A3AC0 Offset: 0x13A20C0 VA: 0x1813A3AC0
	internal void .ctor(string message, long expectedCount, long actualCount) { }

}

