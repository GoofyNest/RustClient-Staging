public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 933
{	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x17CAB00 Offset: 0x17C9100 VA: 0x1817CAB00
	internal void .ctor(IntPtr token) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x17CA960 Offset: 0x17C8F60 VA: 0x1817CA960 Slot: 4
	public void Dispose() { }

	// RVA: 0x17CAA50 Offset: 0x17C9050 VA: 0x1817CAA50
	public void Undo() { }

	// RVA: 0x17CA950 Offset: 0x17C8F50 VA: 0x1817CA950
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x17CAA20 Offset: 0x17C9020 VA: 0x1817CAA20
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x17CAA40 Offset: 0x17C9040 VA: 0x1817CAA40
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x17CAA30 Offset: 0x17C9030 VA: 0x1817CAA30
	private static bool RevertToSelf() { }

}

