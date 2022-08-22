public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 116
{
	[ReliabilityContractAttribute] // RVA: 0x83C90 Offset: 0x83090 VA: 0x180083C90
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	protected override bool ReleaseHandle() { }

}

