public class OptionAttribute : Attribute // TypeDefIndex: 7028
{	// Fields
	public Icons Icon; // 0x10
	public Translate.Phrase Label; // 0x18
	public string Value; // 0x20
	public bool Default; // 0x28

	// Methods

	// RVA: 0xFC6940 Offset: 0xFC4F40 VA: 0x180FC6940
	public void .ctor(string token, string english, string value, bool isdefault = False, Icons icon = 0) { }

	// RVA: 0xFC6890 Offset: 0xFC4E90 VA: 0x180FC6890
	public void .ctor(Icons icon, string value, bool isdefault = False) { }

	// RVA: 0xFC6820 Offset: 0xFC4E20 VA: 0x180FC6820
	public Option GetOption() { }

}

