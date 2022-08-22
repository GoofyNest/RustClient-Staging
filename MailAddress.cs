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

	// RVA: 0x1346960 Offset: 0x1344F60 VA: 0x181346960
	public void .ctor(string address) { }

	// RVA: 0x1346870 Offset: 0x1344E70 VA: 0x181346870
	public void .ctor(string address, string displayName) { }

	[MonoTODOAttribute] // RVA: 0xB98C0 Offset: 0xB8CC0 VA: 0x1800B98C0
	// RVA: 0x1346780 Offset: 0x1344D80 VA: 0x181346780
	public void .ctor(string address, string displayName, Encoding displayNameEncoding) { }

	// RVA: 0x1346370 Offset: 0x1344970 VA: 0x181346370
	private void ParseAddress(string address) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Address() { }

	// RVA: 0x1346A30 Offset: 0x1345030 VA: 0x181346A30
	public string get_DisplayName() { }

	// RVA: 0x13462C0 Offset: 0x13448C0 VA: 0x1813462C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1346330 Offset: 0x1344930 VA: 0x181346330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13466D0 Offset: 0x1344CD0 VA: 0x1813466D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1346270 Offset: 0x1344870 VA: 0x181346270
	private static FormatException CreateFormatException() { }

}

