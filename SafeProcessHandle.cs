public sealed class SafeProcessHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 2563
{	// Fields
	internal static SafeProcessHandle InvalidHandle; // 0x1413A

	// Methods

	// RVA: 0x121C4E0 Offset: 0x121AAE0 VA: 0x18121C4E0
	internal void .ctor(IntPtr handle) { }

	// RVA: 0x121C4B0 Offset: 0x121AAB0 VA: 0x18121C4B0
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x121C430 Offset: 0x121AA30 VA: 0x18121C430 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x121C440 Offset: 0x121AA40 VA: 0x18121C440
	private static void .cctor() { }

}

