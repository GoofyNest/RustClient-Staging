public static class Threading // TypeDefIndex: 6229
{	// Fields
	private static int mainThread; // 0x0
	private static List<Action> actions; // 0x8

	// Properties
	public static bool IsMainThread { get; }

	// Methods

	// RVA: 0x14B8F10 Offset: 0x14B7510 VA: 0x1814B8F10
	public static bool get_IsMainThread() { }

	// RVA: 0x14B8A20 Offset: 0x14B7020 VA: 0x1814B8A20
	public static void QueueOnMainThread(Action action) { }

	// RVA: 0x14B8C00 Offset: 0x14B7200 VA: 0x1814B8C00
	internal static void RunQueuedFunctionsOnMainThread() { }

	// RVA: 0x14B8EA0 Offset: 0x14B74A0 VA: 0x1814B8EA0
	private static void .cctor() { }

}

