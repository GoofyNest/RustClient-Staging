public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 116
{
	[ReliabilityContractAttribute] // RVA: 0x83D60 Offset: 0x83160 VA: 0x180083D60
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

}

