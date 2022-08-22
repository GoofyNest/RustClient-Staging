internal class GAEvents // TypeDefIndex: 5674
{	// Fields
	private static readonly GAEvents _instance; // 0x0
	private bool isRunning; // 0x10
	private bool keepRunning; // 0x11

	// Properties
	private static GAEvents Instance { get; }

	// Methods

	// RVA: 0x13B4850 Offset: 0x13B2E50 VA: 0x1813B4850
	private static GAEvents get_Instance() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13B4500 Offset: 0x13B2B00 VA: 0x1813B4500
	public static void StopEventQueue() { }

	// RVA: 0x13B2800 Offset: 0x13B0E00 VA: 0x1813B2800
	public static void EnsureEventQueueIsRunning() { }

	// RVA: 0x13B2560 Offset: 0x13B0B60 VA: 0x1813B2560
	public static void AddSessionStartEvent() { }

	// RVA: 0x13B2330 Offset: 0x13B0930 VA: 0x1813B2330
	public static void AddSessionEndEvent() { }

	// RVA: 0x13B0A50 Offset: 0x13AF050 VA: 0x1813B0A50
	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, IDictionary<string, object> fields) { }

	// RVA: 0x13B12D0 Offset: 0x13AF8D0 VA: 0x1813B12D0
	public static void AddDesignEvent(string eventId, double value, bool sendValue, IDictionary<string, object> fields) { }

	// RVA: 0x13B2EB0 Offset: 0x13B14B0 VA: 0x1813B2EB0
	private static void ProcessEventQueue() { }

	// RVA: 0x13B3040 Offset: 0x13B1640 VA: 0x1813B3040
	private static void ProcessEvents(string category, bool performCleanUp) { }

	// RVA: 0x13B3FB0 Offset: 0x13B25B0 VA: 0x1813B3FB0
	public static void ProcessEvents(EGAHTTPApiResponse responseEnum, JSONNode dataDict, string putbackSql, string deleteSql, int eventCount) { }

	// RVA: 0x13B27B0 Offset: 0x13B0DB0 VA: 0x1813B27B0
	private static void CleanupEvents() { }

	// RVA: 0x13B29F0 Offset: 0x13B0FF0 VA: 0x1813B29F0
	private static void FixMissingSessionEndEvents() { }

	// RVA: 0x13B1940 Offset: 0x13AFF40 VA: 0x1813B1940
	private static void AddEventToStore(JSONObject eventData) { }

	// RVA: 0x13B1750 Offset: 0x13AFD50 VA: 0x1813B1750
	private static void AddDimensionsToEvent(JSONObject eventData) { }

	// RVA: 0x13B2290 Offset: 0x13B0890 VA: 0x1813B2290
	private static void AddFieldsToEvent(JSONObject eventData, JSONObject fields) { }

	// RVA: 0x13B45B0 Offset: 0x13B2BB0 VA: 0x1813B45B0
	private static void UpdateSessionTime() { }

	// RVA: 0x13B47F0 Offset: 0x13B2DF0 VA: 0x1813B47F0
	private static void .cctor() { }

}

