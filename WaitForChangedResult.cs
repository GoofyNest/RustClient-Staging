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

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	public void set_ChangeType(WatcherChangeTypes value) { }

	// RVA: 0xF14A0 Offset: 0xF08A0 VA: 0x1800F14A0
	public void set_Name(string value) { }

	// RVA: 0xF1470 Offset: 0xF0870 VA: 0x1800F1470
	public void set_OldName(string value) { }

}

