internal class ActivityTracker // TypeDefIndex: 1592
{	// Fields
	private AsyncLocal<ActivityTracker.ActivityInfo> m_current; // 0x10
	private bool m_checkedForEnable; // 0x18
	private static ActivityTracker s_activityTrackerInstance; // 0x0
	private static long m_nextId; // 0x8

	// Properties
	public static ActivityTracker Instance { get; }

	// Methods

	// RVA: 0xD67900 Offset: 0xD65F00 VA: 0x180D67900
	public void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options) { }

	// RVA: 0xD67EA0 Offset: 0xD664A0 VA: 0x180D67EA0
	public void OnStop(string providerName, string activityName, int task, ref Guid activityId) { }

	// RVA: 0xD67720 Offset: 0xD65D20 VA: 0x180D67720
	public void Enable() { }

	// RVA: 0xD68270 Offset: 0xD66870 VA: 0x180D68270
	public static ActivityTracker get_Instance() { }

	// RVA: 0xD677C0 Offset: 0xD65DC0 VA: 0x180D677C0
	private ActivityTracker.ActivityInfo FindActiveActivity(string name, ActivityTracker.ActivityInfo startLocation) { }

	// RVA: 0xD67820 Offset: 0xD65E20 VA: 0x180D67820
	private string NormalizeActivityName(string providerName, string activityName, int task) { }

	// RVA: 0xD67610 Offset: 0xD65C10 VA: 0x180D67610
	private void ActivityChanging(AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo> args) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD68200 Offset: 0xD66800 VA: 0x180D68200
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

	// RVA: 0xD674D0 Offset: 0xD65AD0 VA: 0x180D674D0
	public void .ctor(string name, long uniqueId, ActivityTracker.ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options) { }

	// RVA: 0xD67600 Offset: 0xD65C00 VA: 0x180D67600
	public Guid get_ActivityId() { }

	// RVA: 0xD67170 Offset: 0xD65770 VA: 0x180D67170
	public static string Path(ActivityTracker.ActivityInfo activityInfo) { }

	// RVA: 0xD67200 Offset: 0xD65800 VA: 0x180D67200 Slot: 3
	public override string ToString() { }

	// RVA: 0xD670F0 Offset: 0xD656F0 VA: 0x180D670F0
	public static string LiveActivities(ActivityTracker.ActivityInfo list) { }

	// RVA: 0xD66FA0 Offset: 0xD655A0 VA: 0x180D66FA0
	public bool CanBeOrphan() { }

	// RVA: 0xD66FB0 Offset: 0xD655B0 VA: 0x180D66FB0
	private void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset) { }

	// RVA: 0xD67080 Offset: 0xD65680 VA: 0x180D67080
	private void CreateOverflowGuid(Guid* outPtr) { }

	// RVA: 0xD66E70 Offset: 0xD65470 VA: 0x180D66E70
	private static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = False) { }

	// RVA: 0xD674B0 Offset: 0xD65AB0 VA: 0x180D674B0
	private static void WriteNibble(ref byte* ptr, byte* endPtr, uint value) { }

}

