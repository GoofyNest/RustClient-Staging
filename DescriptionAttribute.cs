public class DescriptionAttribute : Attribute // TypeDefIndex: 2689
{	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string description; // 0x10

	// Properties
	public virtual string Description { get; }
	protected string DescriptionValue { get; set; }

	// Methods

	// RVA: 0x15C1270 Offset: 0x15BF870 VA: 0x1815C1270
	public void .ctor() { }

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string description) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public virtual string get_Description() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected string get_DescriptionValue() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x15C1050 Offset: 0x15BF650 VA: 0x1815C1050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C1120 Offset: 0x15BF720 VA: 0x1815C1120 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C1160 Offset: 0x15BF760 VA: 0x1815C1160 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C11D0 Offset: 0x15BF7D0 VA: 0x1815C11D0
	private static void .cctor() { }

}

