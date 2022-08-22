internal class ActivityTracker // TypeDefIndex: 1592
{	// Fields
	private AsyncLocal<ActivityTracker.ActivityInfo> m_current; // 0x10
	private bool m_checkedForEnable; // 0x18
	private static ActivityTracker s_activityTrackerInstance; // 0x0
	private static long m_nextId; // 0x8

	// Properties
	public static ActivityTracker Instance { get; }

	// Methods

	// RVA: 0xD683B0 Offset: 0xD669B0 VA: 0x180D683B0
	public void OnStart(string providerName, string activityName, int task, ref Guid activityId, ref Guid relatedActivityId, EventActivityOptions options) { }

	// RVA: 0xD68950 Offset: 0xD66F50 VA: 0x180D68950
	public void OnStop(string providerName, string activityName, int task, ref Guid activityId) { }

	// RVA: 0xD681D0 Offset: 0xD667D0 VA: 0x180D681D0
	public void Enable() { }

	// RVA: 0xD68D20 Offset: 0xD67320 VA: 0x180D68D20
	public static ActivityTracker get_Instance() { }

	// RVA: 0xD68270 Offset: 0xD66870 VA: 0x180D68270
	private ActivityTracker.ActivityInfo FindActiveActivity(string name, ActivityTracker.ActivityInfo startLocation) { }

	// RVA: 0xD682D0 Offset: 0xD668D0 VA: 0x180D682D0
	private string NormalizeActivityName(string providerName, string activityName, int task) { }

	// RVA: 0xD680C0 Offset: 0xD666C0 VA: 0x180D680C0
	private void ActivityChanging(AsyncLocalValueChangedArgs<ActivityTracker.ActivityInfo> args) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD68CB0 Offset: 0xD672B0 VA: 0x180D68CB0
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

	// RVA: 0xD67F80 Offset: 0xD66580 VA: 0x180D67F80
	public void .ctor(string name, long uniqueId, ActivityTracker.ActivityInfo creator, Guid activityIDToRestore, EventActivityOptions options) { }

	// RVA: 0xD680B0 Offset: 0xD666B0 VA: 0x180D680B0
	public Guid get_ActivityId() { }

	// RVA: 0xD67C20 Offset: 0xD66220 VA: 0x180D67C20
	public static string Path(ActivityTracker.ActivityInfo activityInfo) { }

	// RVA: 0xD67CB0 Offset: 0xD662B0 VA: 0x180D67CB0 Slot: 3
	public override string ToString() { }

	// RVA: 0xD67BA0 Offset: 0xD661A0 VA: 0x180D67BA0
	public static string LiveActivities(ActivityTracker.ActivityInfo list) { }

	// RVA: 0xD67A50 Offset: 0xD66050 VA: 0x180D67A50
	public bool CanBeOrphan() { }

	// RVA: 0xD67A60 Offset: 0xD66060 VA: 0x180D67A60
	private void CreateActivityPathGuid(out Guid idRet, out int activityPathGuidOffset) { }

	// RVA: 0xD67B30 Offset: 0xD66130 VA: 0x180D67B30
	private void CreateOverflowGuid(Guid* outPtr) { }

	// RVA: 0xD67920 Offset: 0xD65F20 VA: 0x180D67920
	private static int AddIdToGuid(Guid* outPtr, int whereToAddId, uint id, bool overflow = False) { }

	// RVA: 0xD67F60 Offset: 0xD66560 VA: 0x180D67F60
	private static void WriteNibble(ref byte* ptr, byte* endPtr, uint value) { }

}

