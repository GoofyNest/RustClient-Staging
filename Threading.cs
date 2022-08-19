public static class Threading // TypeDefIndex: 6229
{	// Fields
	private static int mainThread; // 0x0
	private static List<Action> actions; // 0x8

	// Properties
	public static bool IsMainThread { get; }

	// Methods

	// RVA: 0x14B9B80 Offset: 0x14B8180 VA: 0x1814B9B80
	public static bool get_IsMainThread() { }

	// RVA: 0x14B9690 Offset: 0x14B7C90 VA: 0x1814B9690
	public static void QueueOnMainThread(Action action) { }

	// RVA: 0x14B9870 Offset: 0x14B7E70 VA: 0x1814B9870
	internal static void RunQueuedFunctionsOnMainThread() { }

	// RVA: 0x14B9B10 Offset: 0x14B8110 VA: 0x1814B9B10
	private static void .cctor() { }

}

