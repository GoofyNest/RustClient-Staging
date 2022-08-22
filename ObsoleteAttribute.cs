public sealed class ObsoleteAttribute : Attribute // TypeDefIndex: 281
{	// Fields
	private string _message; // 0x10
	private bool _error; // 0x18

	// Properties
	public string Message { get; }

	// Methods

	// RVA: 0x1681690 Offset: 0x167FC90 VA: 0x181681690
	public void .ctor() { }

	// RVA: 0x1681650 Offset: 0x167FC50 VA: 0x181681650
	public void .ctor(string message) { }

	// RVA: 0x16816C0 Offset: 0x167FCC0 VA: 0x1816816C0
	public void .ctor(string message, bool error) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Message() { }

}

