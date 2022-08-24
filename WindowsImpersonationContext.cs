public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 933
{	private IntPtr _token; // 0x10
	private bool undo; // 0x18


	internal void .ctor(IntPtr token) { }

	[ComVisibleAttribute] // RVA: 0x75DF0 Offset: 0x751F0 VA: 0x180075DF0
	public void Dispose() { }

	public void Undo() { }

	private static bool CloseToken(IntPtr token) { }

	private static IntPtr DuplicateToken(IntPtr token) { }

	private static bool SetCurrentToken(IntPtr token) { }

	private static bool RevertToSelf() { }

}

