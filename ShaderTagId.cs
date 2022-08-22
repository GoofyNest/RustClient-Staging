public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 3853
{	// Fields
	public static readonly ShaderTagId none; // 0x0
	private int m_Id; // 0x0

	// Properties
	internal int id { get; set; }
	public string name { get; }

	// Methods

	// RVA: 0x21E320 Offset: 0x21D720 VA: 0x18021E320
	public void .ctor(string name) { }

	// RVA: 0x13A3C0 Offset: 0x1397C0 VA: 0x18013A3C0
	internal int get_id() { }

	// RVA: 0xF3850 Offset: 0xF2C50 VA: 0x1800F3850
	internal void set_id(int value) { }

	// RVA: 0x21E370 Offset: 0x21D770 VA: 0x18021E370
	public string get_name() { }

	// RVA: 0x21E270 Offset: 0x21D670 VA: 0x18021E270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x217DE0 Offset: 0x2171E0 VA: 0x180217DE0 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x21E300 Offset: 0x21D700 VA: 0x18021E300 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19A26E0 Offset: 0x19A0CE0 VA: 0x1819A26E0
	private static void .cctor() { }

}

