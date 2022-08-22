public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 3853
{	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x0

	// Properties
	internal int id { get; set; }
	public string name { get; }

	// Methods

	// RVA: 0x222DA0 Offset: 0x2221A0 VA: 0x180222DA0
	public void .ctor(string name) { }

	// RVA: 0x13A5A0 Offset: 0x1399A0 VA: 0x18013A5A0
	internal int get_id() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	internal void set_id(int value) { }

	// RVA: 0x222DF0 Offset: 0x2221F0 VA: 0x180222DF0
	public string get_name() { }

	// RVA: 0x222CF0 Offset: 0x2220F0 VA: 0x180222CF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x217710 Offset: 0x216B10 VA: 0x180217710 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x222D80 Offset: 0x222180 VA: 0x180222D80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19B52E0 Offset: 0x19B38E0 VA: 0x1819B52E0
	private static void .cctor() { }

}

