public abstract class Switch // TypeDefIndex: 2635
{	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x1735210 Offset: 0x1733810 VA: 0x181735210
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x1735000 Offset: 0x1733600 VA: 0x181735000
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x1735280 Offset: 0x1733880 VA: 0x181735280
	private static void _pruneCachedSwitches() { }

	// RVA: 0x1734FA0 Offset: 0x17335A0 VA: 0x181734FA0
	private static void .cctor() { }

}

