public class DescriptionAttribute : Attribute // TypeDefIndex: 2689
{	// Fields
	public static readonly DescriptionAttribute Default; // 0x0
	private string description; // 0x10

	// Properties
	public virtual string Description { get; }
	protected string DescriptionValue { get; set; }

	// Methods

	// RVA: 0x15C0FB0 Offset: 0x15BF5B0 VA: 0x1815C0FB0
	public void .ctor() { }

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string description) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public virtual string get_Description() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected string get_DescriptionValue() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	protected void set_DescriptionValue(string value) { }

	// RVA: 0x15C0D90 Offset: 0x15BF390 VA: 0x1815C0D90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0E60 Offset: 0x15BF460 VA: 0x1815C0E60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C0EA0 Offset: 0x15BF4A0 VA: 0x1815C0EA0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C0F10 Offset: 0x15BF510 VA: 0x1815C0F10
	private static void .cctor() { }

}

