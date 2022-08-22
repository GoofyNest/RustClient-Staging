public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2563
{	// Fields
	internal static SafeProcessHandle InvalidHandle; // 0x2B111E8

	// Methods

	// RVA: 0x121BE40 Offset: 0x121A440 VA: 0x18121BE40
	internal void .ctor(IntPtr handle) { }

	// RVA: 0x121BE10 Offset: 0x121A410 VA: 0x18121BE10
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x121BD90 Offset: 0x121A390 VA: 0x18121BD90 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x121BDA0 Offset: 0x121A3A0 VA: 0x18121BDA0
	private static void .cctor() { }

}

