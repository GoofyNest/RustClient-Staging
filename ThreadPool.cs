public static class ThreadPool // TypeDefIndex: 816
{	// Methods

	// RVA: 0x15F9900 Offset: 0x15F7F00 VA: 0x1815F9900
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x15F9AC0 Offset: 0x15F80C0 VA: 0x1815F9AC0
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x15F98D0 Offset: 0x15F7ED0 VA: 0x1815F98D0
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x15F98A0 Offset: 0x15F7EA0 VA: 0x1815F98A0
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x15F9F50 Offset: 0x15F8550 VA: 0x1815F9F50
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x15F9720 Offset: 0x15F7D20 VA: 0x1815F9720
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x15F9E70 Offset: 0x15F8470 VA: 0x1815F9E70
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x15F9D70 Offset: 0x15F8370 VA: 0x1815F9D70
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x15F9D60 Offset: 0x15F8360 VA: 0x1815F9D60
	internal static bool RequestWorkerThread() { }

	// RVA: 0x15F9640 Offset: 0x15F7C40 VA: 0x1815F9640
	private static void EnsureVMInitialized() { }

	// RVA: 0x15F9700 Offset: 0x15F7D00 VA: 0x1815F9700
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x15F7F20 Offset: 0x15F6520 VA: 0x1815F7F20
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x15F9710 Offset: 0x15F7D10 VA: 0x1815F9710
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470
	internal static bool IsThreadPoolHosted() { }

	// RVA: 0x15F96F0 Offset: 0x15F7CF0 VA: 0x1815F96F0
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

}

