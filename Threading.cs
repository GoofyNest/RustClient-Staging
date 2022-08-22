public static class Threading // TypeDefIndex: 6229
{	// Fields
	private static int mainThread; // 0x0
	private static List<Action> actions; // 0x8

	// Properties
	public static bool IsMainThread { get; }

	// Methods

	// RVA: 0x14B9E40 Offset: 0x14B8440 VA: 0x1814B9E40
	public static bool get_IsMainThread() { }

	// RVA: 0x14B9950 Offset: 0x14B7F50 VA: 0x1814B9950
	public static void QueueOnMainThread(Action action) { }

	// RVA: 0x14B9B30 Offset: 0x14B8130 VA: 0x1814B9B30
	internal static void RunQueuedFunctionsOnMainThread() { }

	// RVA: 0x14B9DD0 Offset: 0x14B83D0 VA: 0x1814B9DD0
	private static void .cctor() { }

}

