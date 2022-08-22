public class Authorization // TypeDefIndex: 2870
{	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x151E5C0 Offset: 0x151CBC0 VA: 0x18151E5C0
	public void .ctor(string token) { }

	// RVA: 0x151E640 Offset: 0x151CC40 VA: 0x18151E640
	public void .ctor(string token, bool finished) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Message() { }

	// RVA: 0x95FFF0 Offset: 0x95E5F0 VA: 0x18095FFF0
	public bool get_Complete() { }

}

