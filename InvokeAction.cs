public struct InvokeAction : IEquatable<InvokeAction> // TypeDefIndex: 5568
{	// Fields
	public Behaviour sender; // 0x0
	public Action action; // 0x8
	public float initial; // 0x10
	public float repeat; // 0x14
	public float random; // 0x18

	// Methods

	// RVA: 0x2216C0 Offset: 0x220AC0 VA: 0x1802216C0
	public void .ctor(Behaviour sender, Action action, float initial = 0, float repeat = -1, float random = 0) { }

	// RVA: 0x221610 Offset: 0x220A10 VA: 0x180221610 Slot: 4
	public bool Equals(InvokeAction other) { }

	// RVA: 0x221520 Offset: 0x220920 VA: 0x180221520 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF2D10 Offset: 0xF2110 VA: 0x1800F2D10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x198B780 Offset: 0x1989D80 VA: 0x18198B780
	public static bool op_Equality(InvokeAction x, InvokeAction y) { }

	// RVA: 0x198B820 Offset: 0x1989E20 VA: 0x18198B820
	public static bool op_Inequality(InvokeAction x, InvokeAction y) { }

}

