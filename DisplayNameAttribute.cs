public class DisplayNameAttribute : Attribute // TypeDefIndex: 2696
{	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string _displayName; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; }

	// Methods

	// RVA: 0x15C2160 Offset: 0x15C0760 VA: 0x1815C2160
	public void .ctor() { }

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string displayName) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 7
	public virtual string get_DisplayName() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	protected string get_DisplayNameValue() { }

	// RVA: 0x15C1F80 Offset: 0x15C0580 VA: 0x1815C1F80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C1120 Offset: 0x15BF720 VA: 0x1815C1120 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C2050 Offset: 0x15C0650 VA: 0x1815C2050 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C20C0 Offset: 0x15C06C0 VA: 0x1815C20C0
	private static void .cctor() { }

}

public sealed class DisplayNameAttribute : Attribute // TypeDefIndex: 11749
{	// Fields
	public readonly string displayName; // 0x10

	// Methods

	// RVA: 0x7EDDF0 Offset: 0x7EC3F0 VA: 0x1807EDDF0
	public void .ctor(string displayName) { }

}

