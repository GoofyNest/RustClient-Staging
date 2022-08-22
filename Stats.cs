public class Stats // TypeDefIndex: 6704
{	// Fields
	public bool Enabled; // 0x10
	public Stats.Node Building; // 0x18
	public Stats.Node Previous; // 0x20

	// Methods

	// RVA: 0x22150F0 Offset: 0x22136F0 VA: 0x1822150F0
	public void .ctor() { }

	// RVA: 0x2215010 Offset: 0x2213610 VA: 0x182215010
	public void Add(string Category, string Object, long Bytes) { }

	// RVA: 0x2214FC0 Offset: 0x22135C0 VA: 0x182214FC0
	public void Add(string Category, long Bytes) { }

	// RVA: 0x2215080 Offset: 0x2213680 VA: 0x182215080
	public void Flip() { }

}

public class Stats.Node : Pool.IPooled // TypeDefIndex: 6705
{	// Fields
	public Dictionary<string, Stats.Node> Children; // 0x10
	public long Bytes; // 0x18
	public long Count; // 0x20

	// Methods

	// RVA: 0x2214190 Offset: 0x2212790 VA: 0x182214190
	internal Stats.Node Add(string category, long bytes) { }

	// RVA: 0x2214240 Offset: 0x2212840 VA: 0x182214240
	internal void Clear() { }

	// RVA: 0x22143B0 Offset: 0x22129B0 VA: 0x1822143B0 Slot: 4
	public void EnterPool() { }

	// RVA: 0x22143B0 Offset: 0x22129B0 VA: 0x1822143B0 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

