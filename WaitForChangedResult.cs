public struct WaitForChangedResult // TypeDefIndex: 2858
{	// Fields
	private WatcherChangeTypes changeType; // 0x0
	private string name; // 0x8
	private string oldName; // 0x10
	private bool timedOut; // 0x18

	// Properties
	public WatcherChangeTypes ChangeType { set; }
	public string Name { set; }
	public string OldName { set; }

	// Methods

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	public void set_ChangeType(WatcherChangeTypes value) { }

	// RVA: 0xF1520 Offset: 0xF0920 VA: 0x1800F1520
	public void set_Name(string value) { }

	// RVA: 0xF14F0 Offset: 0xF08F0 VA: 0x1800F14F0
	public void set_OldName(string value) { }

}

