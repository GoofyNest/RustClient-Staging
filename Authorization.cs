public class Authorization // TypeDefIndex: 2870
{	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x151F4F0 Offset: 0x151DAF0 VA: 0x18151F4F0
	public void .ctor(string token) { }

	// RVA: 0x151F570 Offset: 0x151DB70 VA: 0x18151F570
	public void .ctor(string token, bool finished) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Message() { }

	// RVA: 0x95FAF0 Offset: 0x95E0F0 VA: 0x18095FAF0
	public bool get_Complete() { }

}

