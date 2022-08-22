public abstract class BaseMonoBehaviour : FacepunchBehaviour // TypeDefIndex: 11290
{	// Methods

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 4
	public virtual bool IsDebugging() { }

	// RVA: 0xA49E00 Offset: 0xA48400 VA: 0x180A49E00 Slot: 5
	public virtual string GetLogColor() { }

	// RVA: 0xA4A420 Offset: 0xA48A20 VA: 0x180A4A420
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1) { }

	// RVA: 0xA4A120 Offset: 0xA48720 VA: 0x180A4A120
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str, object arg1, object arg2) { }

	// RVA: 0xA49E30 Offset: 0xA48430 VA: 0x180A49E30
	public void LogEntry(BaseMonoBehaviour.LogEntryType log, int level, string str) { }

	// RVA: 0x4BAE40 Offset: 0x4B9440 VA: 0x1804BAE40
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

