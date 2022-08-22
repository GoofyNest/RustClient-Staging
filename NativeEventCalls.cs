internal static class NativeEventCalls // TypeDefIndex: 827
{
// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 827
	// Methods

	// RVA: 0x1496A20 Offset: 0x1495020 VA: 0x181496A20
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x1496B30 Offset: 0x1495130 VA: 0x181496B30
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1496B20 Offset: 0x1495120 VA: 0x181496B20
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x1496A40 Offset: 0x1495040 VA: 0x181496A40
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1496A30 Offset: 0x1495030 VA: 0x181496A30
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x1496A10 Offset: 0x1495010 VA: 0x181496A10
	public static void CloseEvent_internal(IntPtr handle) { }

}

