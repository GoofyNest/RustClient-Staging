public class MailAddress // TypeDefIndex: 3037
{	// Fields
	private string address; // 0x10
	private string displayName; // 0x18
	private string host; // 0x20
	private string user; // 0x28
	private string to_string; // 0x30

	// Properties
	public string Address { get; }
	public string DisplayName { get; }

	// Methods

	// RVA: 0x13466A0 Offset: 0x1344CA0 VA: 0x1813466A0
	public void .ctor(string address) { }

	// RVA: 0x13465B0 Offset: 0x1344BB0 VA: 0x1813465B0
	public void .ctor(string address, string displayName) { }

	[MonoTODOAttribute] // RVA: 0xB98C0 Offset: 0xB8CC0 VA: 0x1800B98C0
	// RVA: 0x13464C0 Offset: 0x1344AC0 VA: 0x1813464C0
	public void .ctor(string address, string displayName, Encoding displayNameEncoding) { }

	// RVA: 0x13460B0 Offset: 0x13446B0 VA: 0x1813460B0
	private void ParseAddress(string address) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Address() { }

	// RVA: 0x1346770 Offset: 0x1344D70 VA: 0x181346770
	public string get_DisplayName() { }

	// RVA: 0x1346000 Offset: 0x1344600 VA: 0x181346000 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1346070 Offset: 0x1344670 VA: 0x181346070 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1346410 Offset: 0x1344A10 VA: 0x181346410 Slot: 3
	public override string ToString() { }

	// RVA: 0x1345FB0 Offset: 0x13445B0 VA: 0x181345FB0
	private static FormatException CreateFormatException() { }

}

