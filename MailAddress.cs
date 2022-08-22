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

	// RVA: 0x1345A60 Offset: 0x1344060 VA: 0x181345A60
	public void .ctor(string address) { }

	// RVA: 0x1345970 Offset: 0x1343F70 VA: 0x181345970
	public void .ctor(string address, string displayName) { }

	[MonoTODOAttribute] // RVA: 0xB98C0 Offset: 0xB8CC0 VA: 0x1800B98C0
	// RVA: 0x1345880 Offset: 0x1343E80 VA: 0x181345880
	public void .ctor(string address, string displayName, Encoding displayNameEncoding) { }

	// RVA: 0x1345470 Offset: 0x1343A70 VA: 0x181345470
	private void ParseAddress(string address) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Address() { }

	// RVA: 0x1345B30 Offset: 0x1344130 VA: 0x181345B30
	public string get_DisplayName() { }

	// RVA: 0x13453C0 Offset: 0x13439C0 VA: 0x1813453C0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1345430 Offset: 0x1343A30 VA: 0x181345430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x13457D0 Offset: 0x1343DD0 VA: 0x1813457D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1345370 Offset: 0x1343970 VA: 0x181345370
	private static FormatException CreateFormatException() { }

}

