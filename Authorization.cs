public class Authorization // TypeDefIndex: 2870
{	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x151F230 Offset: 0x151D830 VA: 0x18151F230
	public void .ctor(string token) { }

	// RVA: 0x151F2B0 Offset: 0x151D8B0 VA: 0x18151F2B0
	public void .ctor(string token, bool finished) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Message() { }

	// RVA: 0x95F9E0 Offset: 0x95DFE0 VA: 0x18095F9E0
	public bool get_Complete() { }

}

