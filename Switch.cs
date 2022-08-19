public abstract class Switch // TypeDefIndex: 2635
{	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x1734F50 Offset: 0x1733550 VA: 0x181734F50
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x1734D40 Offset: 0x1733340 VA: 0x181734D40
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x1734FC0 Offset: 0x17335C0 VA: 0x181734FC0
	private static void _pruneCachedSwitches() { }

	// RVA: 0x1734CE0 Offset: 0x17332E0 VA: 0x181734CE0
	private static void .cctor() { }

}

