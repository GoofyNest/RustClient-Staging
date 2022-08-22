public class DisplayNameAttribute : Attribute // TypeDefIndex: 2696
{	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	private string _displayName; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; }

	// Methods

	// RVA: 0x15C1230 Offset: 0x15BF830 VA: 0x1815C1230
	public void .ctor() { }

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string displayName) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 7
	public virtual string get_DisplayName() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	protected string get_DisplayNameValue() { }

	// RVA: 0x15C1050 Offset: 0x15BF650 VA: 0x1815C1050 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15C01F0 Offset: 0x15BE7F0 VA: 0x1815C01F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15C1120 Offset: 0x15BF720 VA: 0x1815C1120 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x15C1190 Offset: 0x15BF790 VA: 0x1815C1190
	private static void .cctor() { }

}

public sealed class DisplayNameAttribute : Attribute // TypeDefIndex: 11749
{	// Fields
	public readonly string displayName; // 0x10

	// Methods

	// RVA: 0x7B9710 Offset: 0x7B7D10 VA: 0x1807B9710
	public void .ctor(string displayName) { }

}

