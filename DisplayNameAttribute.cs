public class DisplayNameAttribute : Attribute // TypeDefIndex: 2696
{	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string _displayName; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; }

	// Methods

	// RVA: 0x15C1EA0 Offset: 0x15C04A0 VA: 0x1815C1EA0
	public void .ctor() { }

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string displayName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public virtual string get_DisplayName() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected string get_DisplayNameValue() { }

	// RVA: 0x15C1CC0 Offset: 0x15C02C0 VA: 0x1815C1CC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C0E60 Offset: 0x15BF460 VA: 0x1815C0E60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C1D90 Offset: 0x15C0390 VA: 0x1815C1D90 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C1E00 Offset: 0x15C0400 VA: 0x1815C1E00
	private static void .cctor() { }

}

public sealed class DisplayNameAttribute : Attribute // TypeDefIndex: 11749
{	// Fields
	public readonly string displayName; // 0x10

	// Methods

	// RVA: 0x7EDCE0 Offset: 0x7EC2E0 VA: 0x1807EDCE0
	public void .ctor(string displayName) { }

}

