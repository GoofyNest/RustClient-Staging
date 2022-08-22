internal static class NativeEventCalls // TypeDefIndex: 827
{
// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 827
	// Methods

	// RVA: 0x1497950 Offset: 0x1495F50 VA: 0x181497950
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x1497A60 Offset: 0x1496060 VA: 0x181497A60
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1497A50 Offset: 0x1496050 VA: 0x181497A50
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x1497970 Offset: 0x1495F70 VA: 0x181497970
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1497960 Offset: 0x1495F60 VA: 0x181497960
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x1497940 Offset: 0x1495F40 VA: 0x181497940
	public static void CloseEvent_internal(IntPtr handle) { }

}

