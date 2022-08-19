public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 933
{	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x17CA840 Offset: 0x17C8E40 VA: 0x1817CA840
	internal void .ctor(IntPtr token) { }

	[ComVisibleAttribute] // RVA: 0x75D10 Offset: 0x75110 VA: 0x180075D10
	// RVA: 0x17CA6A0 Offset: 0x17C8CA0 VA: 0x1817CA6A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x17CA790 Offset: 0x17C8D90 VA: 0x1817CA790
	public void Undo() { }

	// RVA: 0x17CA690 Offset: 0x17C8C90 VA: 0x1817CA690
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x17CA760 Offset: 0x17C8D60 VA: 0x1817CA760
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x17CA780 Offset: 0x17C8D80 VA: 0x1817CA780
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x17CA770 Offset: 0x17C8D70 VA: 0x1817CA770
	private static bool RevertToSelf() { }

}

