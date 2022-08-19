public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 3853
{	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x0

	// Properties
	internal int id { get; set; }
	public string name { get; }

	// Methods

	// RVA: 0x222E20 Offset: 0x222220 VA: 0x180222E20
	public void .ctor(string name) { }

	// RVA: 0x13A620 Offset: 0x139A20 VA: 0x18013A620
	internal int get_id() { }

	// RVA: 0xF38D0 Offset: 0xF2CD0 VA: 0x1800F38D0
	internal void set_id(int value) { }

	// RVA: 0x222E70 Offset: 0x222270 VA: 0x180222E70
	public string get_name() { }

	// RVA: 0x222D70 Offset: 0x222170 VA: 0x180222D70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x217790 Offset: 0x216B90 VA: 0x180217790 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x222E00 Offset: 0x222200 VA: 0x180222E00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19B5060 Offset: 0x19B3660 VA: 0x1819B5060
	private static void .cctor() { }

}

