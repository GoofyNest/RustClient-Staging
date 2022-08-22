internal class GAEvents // TypeDefIndex: 5674
{	private static readonly GAEvents _instance; // 0x0
	private bool isRunning; // 0x10
	private bool keepRunning; // 0x11

	private static GAEvents Instance { get; }


	private static GAEvents get_Instance() { }

	private void .ctor() { }

	public static void StopEventQueue() { }

	public static void EnsureEventQueueIsRunning() { }

	public static void AddSessionStartEvent() { }

	public static void AddSessionEndEvent() { }

	public static void AddBusinessEvent(string currency, int amount, string itemType, string itemId, string cartType, IDictionary<string, object> fields) { }

	public static void AddDesignEvent(string eventId, double value, bool sendValue, IDictionary<string, object> fields) { }

	private static void ProcessEventQueue() { }

	private static void ProcessEvents(string category, bool performCleanUp) { }

	public static void ProcessEvents(EGAHTTPApiResponse responseEnum, JSONNode dataDict, string putbackSql, string deleteSql, int eventCount) { }

	private static void CleanupEvents() { }

	private static void FixMissingSessionEndEvents() { }

	private static void AddEventToStore(JSONObject eventData) { }

	private static void AddDimensionsToEvent(JSONObject eventData) { }

	private static void AddFieldsToEvent(JSONObject eventData, JSONObject fields) { }

	private static void UpdateSessionTime() { }

	private static void .cctor() { }

}

