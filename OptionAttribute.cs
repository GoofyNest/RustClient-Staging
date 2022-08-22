public class OptionAttribute : Attribute // TypeDefIndex: 7028
{	// Fields
	public Icons Icon; // 0x10
	public Translate.Phrase Label; // 0x18
	public string Value; // 0x20
	public bool Default; // 0x28

	// Methods

	// RVA: 0xFC6C00 Offset: 0xFC5200 VA: 0x180FC6C00
	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	// RVA: 0xFC6B50 Offset: 0xFC5150 VA: 0x180FC6B50
	public void .ctor(Icons icon, string value, bool isdefault = False) { }

	// RVA: 0xFC6AE0 Offset: 0xFC50E0 VA: 0x180FC6AE0
	public Option GetOption() { }

}

