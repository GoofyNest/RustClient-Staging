internal static class NativeMethods // TypeDefIndex: 2562
{	// Methods

	// RVA: 0x121AC50 Offset: 0x1219250 VA: 0x18121AC50
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, SafeHandle hSourceHandle, HandleRef hTargetProcess, out SafeWaitHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x121AE50 Offset: 0x1219450 VA: 0x18121AE50
	public static bool DuplicateHandle(HandleRef hSourceProcessHandle, HandleRef hSourceHandle, HandleRef hTargetProcess, out SafeProcessHandle targetHandle, int dwDesiredAccess, bool bInheritHandle, int dwOptions) { }

	// RVA: 0x121AFB0 Offset: 0x12195B0 VA: 0x18121AFB0
	public static IntPtr GetCurrentProcess() { }

	// RVA: 0x121AFC0 Offset: 0x12195C0 VA: 0x18121AFC0
	public static bool GetExitCodeProcess(IntPtr processHandle, out int exitCode) { }

	// RVA: 0x121AFD0 Offset: 0x12195D0 VA: 0x18121AFD0
	public static bool GetExitCodeProcess(SafeProcessHandle processHandle, out int exitCode) { }

	// RVA: 0x121AFA0 Offset: 0x12195A0 VA: 0x18121AFA0
	public static int GetCurrentProcessId() { }

	// RVA: 0x121AC40 Offset: 0x1219240 VA: 0x18121AC40
	public static bool CloseProcess(IntPtr handle) { }

}

