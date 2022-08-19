internal sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 3062
{	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0xFFC760 Offset: 0xFFAD60 VA: 0x180FFC760
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0xFFC080 Offset: 0xFFA680 VA: 0x180FFC080 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0xFFBE10 Offset: 0xFFA410 VA: 0x180FFBE10
	public void RegisterForBlockingSyscall() { }

	// RVA: 0xFFC570 Offset: 0xFFAB70 VA: 0x180FFC570
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0xFFC700 Offset: 0xFFAD00 VA: 0x180FFC700
	private static void .cctor() { }

}

