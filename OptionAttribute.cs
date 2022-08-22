public class OptionAttribute : Attribute // TypeDefIndex: 7028
{	// Fields
	public Icons Icon; // 0x10
	public Translate.Phrase Label; // 0x18
	public string Value; // 0x20
	public bool Default; // 0x28

	// Methods

	// RVA: 0xFC76A0 Offset: 0xFC5CA0 VA: 0x180FC76A0
	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	// RVA: 0xFC75F0 Offset: 0xFC5BF0 VA: 0x180FC75F0
	public void .ctor(Icons icon, string value, bool isdefault = False) { }

	// RVA: 0xFC7580 Offset: 0xFC5B80 VA: 0x180FC7580
	public Option GetOption() { }

}

