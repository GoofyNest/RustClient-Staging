public class Stats // TypeDefIndex: 6704
{	// Fields
	public bool Enabled; // 0x10
	public Stats.Node Building; // 0x18
	public Stats.Node Previous; // 0x20

	// Methods

	// RVA: 0x22147D0 Offset: 0x2212DD0 VA: 0x1822147D0
	public void .ctor() { }

	// RVA: 0x22146F0 Offset: 0x2212CF0 VA: 0x1822146F0
	public void Add(string Category, string Object, long Bytes) { }

	// RVA: 0x22146A0 Offset: 0x2212CA0 VA: 0x1822146A0
	public void Add(string Category, long Bytes) { }

	// RVA: 0x2214760 Offset: 0x2212D60 VA: 0x182214760
	public void Flip() { }

}

public class Stats.Node : Pool.IPooled // TypeDefIndex: 6705
{	// Fields
	public Dictionary<string, Stats.Node> Children; // 0x10
	public long Bytes; // 0x18
	public long Count; // 0x20

	// Methods

	// RVA: 0x2213870 Offset: 0x2211E70 VA: 0x182213870
	internal Stats.Node Add(string category, long bytes) { }

	// RVA: 0x2213920 Offset: 0x2211F20 VA: 0x182213920
	internal void Clear() { }

	// RVA: 0x2213A90 Offset: 0x2212090 VA: 0x182213A90 Slot: 4
	public void EnterPool() { }

	// RVA: 0x2213A90 Offset: 0x2212090 VA: 0x182213A90 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

