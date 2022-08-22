public static class ThreadPool // TypeDefIndex: 816
{	// Methods

	// RVA: 0x160C5E0 Offset: 0x160ABE0 VA: 0x18160C5E0
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x160C7A0 Offset: 0x160ADA0 VA: 0x18160C7A0
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x160C5B0 Offset: 0x160ABB0 VA: 0x18160C5B0
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x160C580 Offset: 0x160AB80 VA: 0x18160C580
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x160CC30 Offset: 0x160B230 VA: 0x18160CC30
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x160C400 Offset: 0x160AA00 VA: 0x18160C400
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x160CB50 Offset: 0x160B150 VA: 0x18160CB50
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x160CA50 Offset: 0x160B050 VA: 0x18160CA50
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x160CA40 Offset: 0x160B040 VA: 0x18160CA40
	internal static bool RequestWorkerThread() { }

	// RVA: 0x160C320 Offset: 0x160A920 VA: 0x18160C320
	private static void EnsureVMInitialized() { }

	// RVA: 0x160C3E0 Offset: 0x160A9E0 VA: 0x18160C3E0
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x160AC00 Offset: 0x1609200 VA: 0x18160AC00
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x160C3F0 Offset: 0x160A9F0 VA: 0x18160C3F0
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0
	internal static bool IsThreadPoolHosted() { }

	// RVA: 0x160C3D0 Offset: 0x160A9D0 VA: 0x18160C3D0
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

}

