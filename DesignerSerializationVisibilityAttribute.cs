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

	// RVA: 0xB113D0 Offset: 0xB0F9D0 VA: 0x180B113D0
	public void .ctor(DesignerSerializationVisibility visibility) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x15C1D90 Offset: 0x15C0390 VA: 0x1815C1D90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0830 Offset: 0x15BEE30 VA: 0x1815C0830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C1E10 Offset: 0x15C0410 VA: 0x1815C1E10 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C1E80 Offset: 0x15C0480 VA: 0x1815C1E80
	private static void .cctor() { }

}

