internal static class NativeMethods // TypeDefIndex: 2562
{	// Methods

	// RVA: 0x121AF10 Offset: 0x1219510 VA: 0x18121AF10
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x121B110 Offset: 0x1219710 VA: 0x18121B110
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x121B270 Offset: 0x1219870 VA: 0x18121B270
	public static IntPtr GetCurrentProcess() { }

	// RVA: 0x121B280 Offset: 0x1219880 VA: 0x18121B280
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	// RVA: 0x121B290 Offset: 0x1219890 VA: 0x18121B290
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

	// RVA: 0x121B260 Offset: 0x1219860 VA: 0x18121B260
	public static int GetCurrentProcessId() { }

	// RVA: 0x121AF00 Offset: 0x1219500 VA: 0x18121AF00
	public static bool CloseProcess(IntPtr handle) { }

}

