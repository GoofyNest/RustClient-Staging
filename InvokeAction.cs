public struct InvokeAction : IEquatable<InvokeAction> // TypeDefIndex: 5568
{	// Fields
	public Behaviour sender; // 0x0
	public Action action; // 0x8
	public float initial; // 0x10
	public float repeat; // 0x14
	public float random; // 0x18

	// Methods

	// RVA: 0x21CBC0 Offset: 0x21BFC0 VA: 0x18021CBC0
	public void .ctor(Behaviour sender, Action action, float initial = 0, float repeat = -1, float random = 0) { }

	// RVA: 0x21CB10 Offset: 0x21BF10 VA: 0x18021CB10 Slot: 4
	public bool Equals(InvokeAction other) { }

	// RVA: 0x21CA20 Offset: 0x21BE20 VA: 0x18021CA20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xF2C90 Offset: 0xF2090 VA: 0x1800F2C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1978E00 Offset: 0x1977400 VA: 0x181978E00
	public static bool op_Equality(InvokeAction x, InvokeAction y) { }

	// RVA: 0x1978EA0 Offset: 0x19774A0 VA: 0x181978EA0
	public static bool op_Inequality(InvokeAction x, InvokeAction y) { }

}

