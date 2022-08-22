internal sealed class SafeSocketHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 3062
{	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0xFFCA20 Offset: 0xFFB020 VA: 0x180FFCA20
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0xFFC340 Offset: 0xFFA940 VA: 0x180FFC340 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0xFFC0D0 Offset: 0xFFA6D0 VA: 0x180FFC0D0
	public void RegisterForBlockingSyscall() { }

	// RVA: 0xFFC830 Offset: 0xFFAE30 VA: 0x180FFC830
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0xFFC9C0 Offset: 0xFFAFC0 VA: 0x180FFC9C0
	private static void .cctor() { }

}

