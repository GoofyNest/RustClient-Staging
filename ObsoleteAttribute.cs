public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 281
{	// Fields
	private string _message; // 0x10
	private bool _error; // 0x18

	// Properties
	public string Message { get; }

	// Methods

	// RVA: 0x1683AA0 Offset: 0x16820A0 VA: 0x181683AA0
	public void .ctor() { }

	// RVA: 0x1683A60 Offset: 0x1682060 VA: 0x181683A60
	public void .ctor(string message) { }

	// RVA: 0x1683AD0 Offset: 0x16820D0 VA: 0x181683AD0
	public void .ctor(string message, bool error) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Message() { }

}

