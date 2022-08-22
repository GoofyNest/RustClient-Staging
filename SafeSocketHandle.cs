internal sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 3062
{	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0xFFD4C0 Offset: 0xFFBAC0 VA: 0x180FFD4C0
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0xFFCDE0 Offset: 0xFFB3E0 VA: 0x180FFCDE0 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0xFFCB70 Offset: 0xFFB170 VA: 0x180FFCB70
	public void RegisterForBlockingSyscall() { }

	// RVA: 0xFFD2D0 Offset: 0xFFB8D0 VA: 0x180FFD2D0
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0xFFD460 Offset: 0xFFBA60 VA: 0x180FFD460
	private static void .cctor() { }

}

