internal static class NativeEventCalls // TypeDefIndex: 827
{
// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 827
	// Methods

	// RVA: 0x1497690 Offset: 0x1495C90 VA: 0x181497690
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x14977A0 Offset: 0x1495DA0 VA: 0x1814977A0
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x1497790 Offset: 0x1495D90 VA: 0x181497790
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x14976B0 Offset: 0x1495CB0 VA: 0x1814976B0
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x14976A0 Offset: 0x1495CA0 VA: 0x1814976A0
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x1497680 Offset: 0x1495C80 VA: 0x181497680
	public static void CloseEvent_internal(IntPtr handle) { }

}

