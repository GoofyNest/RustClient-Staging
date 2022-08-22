public struct InvokeAction : IEquatable<InvokeAction> // TypeDefIndex: 5568
{	// Fields
	public Behaviour sender; // 0x0
	public Action action; // 0x8
	public float initial; // 0x10
	public float repeat; // 0x14
	public float random; // 0x18

	// Methods

	// RVA: 0x221640 Offset: 0x220A40 VA: 0x180221640
	public void .ctor(Behaviour sender, Action action, float initial = 0, float repeat = -1, float random = 0) { }

	// RVA: 0x221590 Offset: 0x220990 VA: 0x180221590 Slot: 4
	public bool Equals(InvokeAction other) { }

	// RVA: 0x2214A0 Offset: 0x2208A0 VA: 0x1802214A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF2C90 Offset: 0xF2090 VA: 0x1800F2C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x198B740 Offset: 0x1989D40 VA: 0x18198B740
	public static bool op_Equality(InvokeAction x, InvokeAction y) { }

	// RVA: 0x198B7E0 Offset: 0x1989DE0 VA: 0x18198B7E0
	public static bool op_Inequality(InvokeAction x, InvokeAction y) { }

}

