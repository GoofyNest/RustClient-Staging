public sealed class NotEnoughBytesException : MidiException // TypeDefIndex: 7579
{	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <ExpectedCount>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private readonly long <ActualCount>k__BackingField; // 0x90


	internal void .ctor(string message, Exception innerException) { }

	internal void .ctor(string message, long expectedCount, long actualCount) { }

}

