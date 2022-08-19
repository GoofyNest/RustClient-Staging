public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 281
{	// Fields
	private string _message; // 0x10
	private bool _error; // 0x18

	// Properties
	public string Message { get; }

	// Methods

	// RVA: 0x16837E0 Offset: 0x1681DE0 VA: 0x1816837E0
	public void .ctor() { }

	// RVA: 0x16837A0 Offset: 0x1681DA0 VA: 0x1816837A0
	public void .ctor(string message) { }

	// RVA: 0x1683810 Offset: 0x1681E10 VA: 0x181683810
	public void .ctor(string message, bool error) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Message() { }

}

