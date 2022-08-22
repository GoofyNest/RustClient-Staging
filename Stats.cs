public class Stats // TypeDefIndex: 6704
{	// Fields
	public bool Enabled; // 0x10
	public Stats.Node Building; // 0x18
	public Stats.Node Previous; // 0x20

	// Methods

	// RVA: 0x2214610 Offset: 0x2212C10 VA: 0x182214610
	public void .ctor() { }

	// RVA: 0x2214530 Offset: 0x2212B30 VA: 0x182214530
	public void Add(string Category, string Object, long Bytes) { }

	// RVA: 0x22144E0 Offset: 0x2212AE0 VA: 0x1822144E0
	public void Add(string Category, long Bytes) { }

	// RVA: 0x22145A0 Offset: 0x2212BA0 VA: 0x1822145A0
	public void Flip() { }

}

public class Stats.Node : Pool.IPooled // TypeDefIndex: 6705
{	// Fields
	public Dictionary<string, Stats.Node> Children; // 0x10
	public long Bytes; // 0x18
	public long Count; // 0x20

	// Methods

	// RVA: 0x22136B0 Offset: 0x2211CB0 VA: 0x1822136B0
	internal Stats.Node Add(string category, long bytes) { }

	// RVA: 0x2213760 Offset: 0x2211D60 VA: 0x182213760
	internal void Clear() { }

	// RVA: 0x22138D0 Offset: 0x2211ED0 VA: 0x1822138D0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x22138D0 Offset: 0x2211ED0 VA: 0x1822138D0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

