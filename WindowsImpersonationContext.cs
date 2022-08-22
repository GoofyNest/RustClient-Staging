public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 933
{	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x17C8650 Offset: 0x17C6C50 VA: 0x1817C8650
	internal void .ctor(IntPtr token) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17C84B0 Offset: 0x17C6AB0 VA: 0x1817C84B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x17C85A0 Offset: 0x17C6BA0 VA: 0x1817C85A0
	public void Undo() { }

	// RVA: 0x17C84A0 Offset: 0x17C6AA0 VA: 0x1817C84A0
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x17C8570 Offset: 0x17C6B70 VA: 0x1817C8570
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x17C8590 Offset: 0x17C6B90 VA: 0x1817C8590
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x17C8580 Offset: 0x17C6B80 VA: 0x1817C8580
	private static bool RevertToSelf() { }

}

