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

	// RVA: 0x1181070 Offset: 0x117F670 VA: 0x181181070
	public void .ctor(string oid) { }

	// RVA: 0x11810D0 Offset: 0x117F6D0 VA: 0x1811810D0
	internal void .ctor(string oid, OidGroup group, bool lookupFriendlyName) { }

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x1181140 Offset: 0x117F740 VA: 0x181181140
	public void .ctor(Oid oid) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Value() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Value(string value) { }

	// RVA: 0x11811E0 Offset: 0x117F7E0 VA: 0x1811811E0
	public string get_FriendlyName() { }

}

