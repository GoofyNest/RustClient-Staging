public abstract class Switch // TypeDefIndex: 2635
{	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x1732DD0 Offset: 0x17313D0 VA: 0x181732DD0
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x1732BC0 Offset: 0x17311C0 VA: 0x181732BC0
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x1732E40 Offset: 0x1731440 VA: 0x181732E40
	private static void _pruneCachedSwitches() { }

	// RVA: 0x1732B60 Offset: 0x1731160 VA: 0x181732B60
	private static void .cctor() { }

}

