public sealed class Oid // TypeDefIndex: 2792
{	// Fields
	private string m_value; // 0x10
	private string m_friendlyName; // 0x18
	private OidGroup m_group; // 0x20

	// Properties
	public string Value { get; set; }
	public string FriendlyName { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x117C750 Offset: 0x117AD50 VA: 0x18117C750
	public void .ctor(string oid) { }

	// RVA: 0x117C7B0 Offset: 0x117ADB0 VA: 0x18117C7B0
	internal void .ctor(string oid, OidGroup group, bool lookupFriendlyName) { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x117C820 Offset: 0x117AE20 VA: 0x18117C820
	public void .ctor(Oid oid) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Value() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Value(string value) { }

	// RVA: 0x117C8C0 Offset: 0x117AEC0 VA: 0x18117C8C0
	public string get_FriendlyName() { }

}

