internal class GAEvents // TypeDefIndex: 5674
{	// Fields
	private static readonly GAEvents _instance; // 0x0
	private bool isRunning; // 0x10
	private bool keepRunning; // 0x11

	// Properties
	private static GAEvents Instance { get; }

	// Methods

	// RVA: 0x13B5490 Offset: 0x13B3A90 VA: 0x1813B5490
	private static GAEvents get_Instance() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x13B5140 Offset: 0x13B3740 VA: 0x1813B5140
	public static void StopEventQueue() { }

	// RVA: 0x13B3440 Offset: 0x13B1A40 VA: 0x1813B3440
	public static void EnsureEventQueueIsRunning() { }

	// RVA: 0x13B31A0 Offset: 0x13B17A0 VA: 0x1813B31A0
	public static void AddSessionStartEvent() { }

	// RVA: 0x13B2F70 Offset: 0x13B1570 VA: 0x1813B2F70
	public static void AddSessionEndEvent() { }

	// RVA: 0x13B1690 Offset: 0x13AFC90 VA: 0x1813B1690
	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, IDictionary<string, object> fields) { }

	// RVA: 0x13B1F10 Offset: 0x13B0510 VA: 0x1813B1F10
	public static void AddDesignEvent(string eventId, double value, bool sendValue, IDictionary<string, object> fields) { }

	// RVA: 0x13B3AF0 Offset: 0x13B20F0 VA: 0x1813B3AF0
	private static void ProcessEventQueue() { }

	// RVA: 0x13B3C80 Offset: 0x13B2280 VA: 0x1813B3C80
	private static void ProcessEvents(string category, bool performCleanUp) { }

	// RVA: 0x13B4BF0 Offset: 0x13B31F0 VA: 0x1813B4BF0
	public static void ProcessEvents(EGAHTTPApiResponse responseEnum, JSONNode dataDict, string putbackSql, string deleteSql, int eventCount) { }

	// RVA: 0x13B33F0 Offset: 0x13B19F0 VA: 0x1813B33F0
	private static void CleanupEvents() { }

	// RVA: 0x13B3630 Offset: 0x13B1C30 VA: 0x1813B3630
	private static void FixMissingSessionEndEvents() { }

	// RVA: 0x13B2580 Offset: 0x13B0B80 VA: 0x1813B2580
	private static void AddEventToStore(JSONObject eventData) { }

	// RVA: 0x13B2390 Offset: 0x13B0990 VA: 0x1813B2390
	private static void AddDimensionsToEvent(JSONObject eventData) { }

	// RVA: 0x13B2ED0 Offset: 0x13B14D0 VA: 0x1813B2ED0
	private static void AddFieldsToEvent(JSONObject eventData, JSONObject fields) { }

	// RVA: 0x13B51F0 Offset: 0x13B37F0 VA: 0x1813B51F0
	private static void UpdateSessionTime() { }

	// RVA: 0x13B5430 Offset: 0x13B3A30 VA: 0x1813B5430
	private static void .cctor() { }

}

