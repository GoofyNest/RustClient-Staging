public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2563
{	// Fields
	internal static SafeProcessHandle InvalidHandle; // 0x2B101A8

	// Methods

	// RVA: 0x121BB80 Offset: 0x121A180 VA: 0x18121BB80
	internal void .ctor(IntPtr handle) { }

	// RVA: 0x121BB50 Offset: 0x121A150 VA: 0x18121BB50
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x121BAD0 Offset: 0x121A0D0 VA: 0x18121BAD0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x121BAE0 Offset: 0x121A0E0 VA: 0x18121BAE0
	private static void .cctor() { }

}

