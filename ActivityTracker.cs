internal class ActivityTracker // TypeDefIndex: 1592
{	// Fields
	private AsyncLocal<ActivityTracker.ActivityInfo> m_current; // 0x10
	private bool m_checkedForEnable; // 0x18
	private static ActivityTracker s_activityTrackerInstance; // 0x0
	private static long m_nextId; // 0x8

	// Properties
	public static ActivityTracker Instance { get; }

	// Methods

	// RVA: 0xD67640 Offset: 0xD65C40 VA: 0x180D67640
	public void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options) { }

	// RVA: 0xD67BE0 Offset: 0xD661E0 VA: 0x180D67BE0
	public void OnStop(string providerName, string activityName, int task, ref Guid activityId) { }

	// RVA: 0xD67460 Offset: 0xD65A60 VA: 0x180D67460
	public void Enable() { }

	// RVA: 0xD67FB0 Offset: 0xD665B0 VA: 0x180D67FB0
	public static ActivityTracker get_Instance() { }

	// RVA: 0xD67500 Offset: 0xD65B00 VA: 0x180D67500
	private ActivityTracker.ActivityInfo FindActiveActivity(string name, ActivityTracker.ActivityInfo startLocation) { }

	// RVA: 0xD67560 Offset: 0xD65B60 VA: 0x180D67560
	private string NormalizeActivityName(string providerName, string activityName, int task) { }

	// RVA: 0xD67350 Offset: 0xD65950 VA: 0x180D67350
	private void ActivityChanging(AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo> args) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD67F40 Offset: 0xD66540 VA: 0x180D67F40
	private static void .cctor() { }

}

private class ActivityTracker.ActivityInfo // TypeDefIndex: 1593
{	// Fields
	internal readonly string m_name; // 0x10
	private readonly long m_uniqueId; // 0x18
	internal readonly Guid m_guid; // 0x20
	internal readonly int m_activityPathGuidOffset; // 0x30
	internal readonly int m_level; // 0x34
	internal readonly EventActivityOptions m_eventOptions; // 0x38
	internal long m_lastChildID; // 0x40
	internal int m_stopped; // 0x48
	internal readonly ActivityTracker.ActivityInfo m_creator; // 0x50
	internal readonly Guid m_activityIdToRestore; // 0x58

	// Properties
	public Guid ActivityId { get; }

	// Methods

	// RVA: 0xD67210 Offset: 0xD65810 VA: 0x180D67210
	public void .ctor(string name, long uniqueId, ActivityTracker.ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options) { }

	// RVA: 0xD67340 Offset: 0xD65940 VA: 0x180D67340
	public Guid get_ActivityId() { }

	// RVA: 0xD66EB0 Offset: 0xD654B0 VA: 0x180D66EB0
	public static string Path(ActivityTracker.ActivityInfo activityInfo) { }

	// RVA: 0xD66F40 Offset: 0xD65540 VA: 0x180D66F40 Slot: 3
	public override string ToString() { }

	// RVA: 0xD66E30 Offset: 0xD65430 VA: 0x180D66E30
	public static string LiveActivities(ActivityTracker.ActivityInfo list) { }

	// RVA: 0xD66CE0 Offset: 0xD652E0 VA: 0x180D66CE0
	public bool CanBeOrphan() { }

	// RVA: 0xD66CF0 Offset: 0xD652F0 VA: 0x180D66CF0
	private void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset) { }

	// RVA: 0xD66DC0 Offset: 0xD653C0 VA: 0x180D66DC0
	private void CreateOverflowGuid(Guid* outPtr) { }

	// RVA: 0xD66BB0 Offset: 0xD651B0 VA: 0x180D66BB0
	private static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = False) { }

	// RVA: 0xD671F0 Offset: 0xD657F0 VA: 0x180D671F0
	private static void WriteNibble(ref byte* ptr, byte* endPtr, uint value) { }

}

