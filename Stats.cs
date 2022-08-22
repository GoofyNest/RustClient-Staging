public class Stats // TypeDefIndex: 6704
{	// Fields
	public bool Enabled; // 0x10
	public Stats.Node Building; // 0x18
	public Stats.Node Previous; // 0x20

	// Methods

	// RVA: 0x22148D0 Offset: 0x2212ED0 VA: 0x1822148D0
	public void .ctor() { }

	// RVA: 0x22147F0 Offset: 0x2212DF0 VA: 0x1822147F0
	public void Add(string Category, string Object, long Bytes) { }

	// RVA: 0x22147A0 Offset: 0x2212DA0 VA: 0x1822147A0
	public void Add(string Category, long Bytes) { }

	// RVA: 0x2214860 Offset: 0x2212E60 VA: 0x182214860
	public void Flip() { }

}

public class Stats.Node : Pool.IPooled // TypeDefIndex: 6705
{	// Fields
	public Dictionary<string, Stats.Node> Children; // 0x10
	public long Bytes; // 0x18
	public long Count; // 0x20

	// Methods

	// RVA: 0x2213970 Offset: 0x2211F70 VA: 0x182213970
	internal Stats.Node Add(string category, long bytes) { }

	// RVA: 0x2213A20 Offset: 0x2212020 VA: 0x182213A20
	internal void Clear() { }

	// RVA: 0x2213B90 Offset: 0x2212190 VA: 0x182213B90 Slot: 4
	public void EnterPool() { }

	// RVA: 0x2213B90 Offset: 0x2212190 VA: 0x182213B90 Slot: 5
	public void LeavePool() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

