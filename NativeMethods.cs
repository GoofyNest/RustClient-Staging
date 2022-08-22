internal static class NativeMethods // TypeDefIndex: 2562
{	// Methods

	// RVA: 0x121B5B0 Offset: 0x1219BB0 VA: 0x18121B5B0
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x121B7B0 Offset: 0x1219DB0 VA: 0x18121B7B0
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x121B910 Offset: 0x1219F10 VA: 0x18121B910
	public static IntPtr GetCurrentProcess() { }

	// RVA: 0x121B920 Offset: 0x1219F20 VA: 0x18121B920
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	// RVA: 0x121B930 Offset: 0x1219F30 VA: 0x18121B930
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

	// RVA: 0x121B900 Offset: 0x1219F00 VA: 0x18121B900
	public static int GetCurrentProcessId() { }

	// RVA: 0x121B5A0 Offset: 0x1219BA0 VA: 0x18121B5A0
	public static bool CloseProcess(IntPtr handle) { }

}

