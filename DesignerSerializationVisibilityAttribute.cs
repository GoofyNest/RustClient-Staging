public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 2695
{	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	private DesignerSerializationVisibility visibility; // 0x10

	// Properties
	public DesignerSerializationVisibility Visibility { get; }

	// Methods

	// RVA: 0xB118A0 Offset: 0xB0FEA0 VA: 0x180B118A0
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x15C0E60 Offset: 0x15BF460 VA: 0x1815C0E60 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15BF900 Offset: 0x15BDF00 VA: 0x1815BF900 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C0EE0 Offset: 0x15BF4E0 VA: 0x1815C0EE0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C0F50 Offset: 0x15BF550 VA: 0x1815C0F50
	private static void .cctor() { }

}

