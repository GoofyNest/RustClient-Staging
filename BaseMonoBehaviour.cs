public abstract class BaseMonoBehaviour : FacepunchBehaviour // TypeDefIndex: 11290
{	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 4
	public virtual bool IsDebugging() { }

	// RVA: 0xA49650 Offset: 0xA47C50 VA: 0x180A49650 Slot: 5
	public virtual string GetLogColor() { }

	// RVA: 0xA49C70 Offset: 0xA48270 VA: 0x180A49C70
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1) { }

	// RVA: 0xA49970 Offset: 0xA47F70 VA: 0x180A49970
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1, object arg2) { }

	// RVA: 0xA49680 Offset: 0xA47C80 VA: 0x180A49680
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str) { }

	// RVA: 0x4BAEB0 Offset: 0x4B94B0 VA: 0x1804BAEB0
	protected void .ctor() { }

}

public enum BaseMonoBehaviour.LogEntryType // TypeDefIndex: 11291
{	// Fields
	public int value__; // 0x0
	public const BaseMonoBehaviour.LogEntryType General = 0;
	public const BaseMonoBehaviour.LogEntryType Network = 1;
	public const BaseMonoBehaviour.LogEntryType Hierarchy = 2;
	public const BaseMonoBehaviour.LogEntryType Serialization = 3;

}

