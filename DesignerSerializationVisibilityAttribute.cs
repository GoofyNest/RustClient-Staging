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

	// RVA: 0xB11110 Offset: 0xB0F710 VA: 0x180B11110
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x15C1AD0 Offset: 0x15C00D0 VA: 0x1815C1AD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0570 Offset: 0x15BEB70 VA: 0x1815C0570 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C1B50 Offset: 0x15C0150 VA: 0x1815C1B50 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C1BC0 Offset: 0x15C01C0 VA: 0x1815C1BC0
	private static void .cctor() { }

}

