internal class GAEvents // TypeDefIndex: 5674
{	// Fields
	private static readonly GAEvents _instance; // 0x0
	private bool isRunning; // 0x10
	private bool keepRunning; // 0x11

	// Properties
	private static GAEvents Instance { get; }

	// Methods

	// RVA: 0x13B5750 Offset: 0x13B3D50 VA: 0x1813B5750
	private static GAEvents get_Instance() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13B5400 Offset: 0x13B3A00 VA: 0x1813B5400
	public static void StopEventQueue() { }

	// RVA: 0x13B3700 Offset: 0x13B1D00 VA: 0x1813B3700
	public static void EnsureEventQueueIsRunning() { }

	// RVA: 0x13B3460 Offset: 0x13B1A60 VA: 0x1813B3460
	public static void AddSessionStartEvent() { }

	// RVA: 0x13B3230 Offset: 0x13B1830 VA: 0x1813B3230
	public static void AddSessionEndEvent() { }

	// RVA: 0x13B1950 Offset: 0x13AFF50 VA: 0x1813B1950
	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, IDictionary<string, object> fields) { }

	// RVA: 0x13B21D0 Offset: 0x13B07D0 VA: 0x1813B21D0
	public static void AddDesignEvent(string eventId, double value, bool sendValue, IDictionary<string, object> fields) { }

	// RVA: 0x13B3DB0 Offset: 0x13B23B0 VA: 0x1813B3DB0
	private static void ProcessEventQueue() { }

	// RVA: 0x13B3F40 Offset: 0x13B2540 VA: 0x1813B3F40
	private static void ProcessEvents(string category, bool performCleanUp) { }

	// RVA: 0x13B4EB0 Offset: 0x13B34B0 VA: 0x1813B4EB0
	public static void ProcessEvents(EGAHTTPApiResponse responseEnum, JSONNode dataDict, string putbackSql, string deleteSql, int eventCount) { }

	// RVA: 0x13B36B0 Offset: 0x13B1CB0 VA: 0x1813B36B0
	private static void CleanupEvents() { }

	// RVA: 0x13B38F0 Offset: 0x13B1EF0 VA: 0x1813B38F0
	private static void FixMissingSessionEndEvents() { }

	// RVA: 0x13B2840 Offset: 0x13B0E40 VA: 0x1813B2840
	private static void AddEventToStore(JSONObject eventData) { }

	// RVA: 0x13B2650 Offset: 0x13B0C50 VA: 0x1813B2650
	private static void AddDimensionsToEvent(JSONObject eventData) { }

	// RVA: 0x13B3190 Offset: 0x13B1790 VA: 0x1813B3190
	private static void AddFieldsToEvent(JSONObject eventData, JSONObject fields) { }

	// RVA: 0x13B54B0 Offset: 0x13B3AB0 VA: 0x1813B54B0
	private static void UpdateSessionTime() { }

	// RVA: 0x13B56F0 Offset: 0x13B3CF0 VA: 0x1813B56F0
	private static void .cctor() { }

}

