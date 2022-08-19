public static class ThreadPool // TypeDefIndex: 816
{	// Methods

	// RVA: 0x160C320 Offset: 0x160A920 VA: 0x18160C320
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x160C4E0 Offset: 0x160AAE0 VA: 0x18160C4E0
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x160C2F0 Offset: 0x160A8F0 VA: 0x18160C2F0
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x160C2C0 Offset: 0x160A8C0 VA: 0x18160C2C0
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x160C970 Offset: 0x160AF70 VA: 0x18160C970
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x160C140 Offset: 0x160A740 VA: 0x18160C140
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x160C890 Offset: 0x160AE90 VA: 0x18160C890
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x160C790 Offset: 0x160AD90 VA: 0x18160C790
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x160C780 Offset: 0x160AD80 VA: 0x18160C780
	internal static bool RequestWorkerThread() { }

	// RVA: 0x160C060 Offset: 0x160A660 VA: 0x18160C060
	private static void EnsureVMInitialized() { }

	// RVA: 0x160C120 Offset: 0x160A720 VA: 0x18160C120
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x160A940 Offset: 0x1608F40 VA: 0x18160A940
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x160C130 Offset: 0x160A730 VA: 0x18160C130
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700
	internal static bool IsThreadPoolHosted() { }

	// RVA: 0x160C110 Offset: 0x160A710 VA: 0x18160C110
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

}

