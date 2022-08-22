public class DescriptionAttribute : Attribute // TypeDefIndex: 2689
{	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string description; // 0x10

	// Properties
	public virtual string Description { get; }
	protected string DescriptionValue { get; set; }

	// Methods

	// RVA: 0x15C0340 Offset: 0x15BE940 VA: 0x1815C0340
	public void .ctor() { }

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string description) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 7
	public virtual string get_Description() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	protected string get_DescriptionValue() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x15C0120 Offset: 0x15BE720 VA: 0x1815C0120 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C01F0 Offset: 0x15BE7F0 VA: 0x1815C01F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C0230 Offset: 0x15BE830 VA: 0x1815C0230 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C02A0 Offset: 0x15BE8A0 VA: 0x1815C02A0
	private static void .cctor() { }

}

