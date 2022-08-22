public static class Translate // TypeDefIndex: 6718
{
// Namespace: 
private struct <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=128 // TypeDefIndex: 6715

// Namespace: 
private struct <PrivateImplementationDetails>{A0874672-3A49-45D7-A8B0-51E6098CECDA}.__StaticArrayInitTypeSize=256 // TypeDefIndex: 6716

// Namespace: 
internal class <Module> // TypeDefIndex: 6717

// Namespace: 
public static class Translate // TypeDefIndex: 6718
	// Fields
	private static Dictionary<string, string> translations; // 0x0
	private static string language; // 0x8

	// Methods

	// RVA: 0x2320A90 Offset: 0x231F090 VA: 0x182320A90
	public static void Init() { }

	// RVA: 0x2320AF0 Offset: 0x231F0F0 VA: 0x182320AF0
	public static void LoadLanguage(string lang) { }

	// RVA: 0x23204F0 Offset: 0x231EAF0 VA: 0x1823204F0
	private static void AddLanguageFile(string fileName) { }

	// RVA: 0x23208F0 Offset: 0x231EEF0 VA: 0x1823208F0
	public static string Get(string key, string def) { }

	// RVA: 0x23207E0 Offset: 0x231EDE0 VA: 0x1823207E0
	public static string FormatTranslated(Translate.Phrase phrase, string b) { }

	// RVA: 0x2320890 Offset: 0x231EE90 VA: 0x182320890
	public static string GetLanguage() { }

	// RVA: 0x2320C40 Offset: 0x231F240 VA: 0x182320C40
	public static void SetLanguage(string str) { }

	// RVA: 0x2320D50 Offset: 0x231F350 VA: 0x182320D50
	private static void .cctor() { }

}

public class Translate.Phrase // TypeDefIndex: 6719
{	// Fields
	public string token; // 0x10
	[TextAreaAttribute] // RVA: 0x721B0 Offset: 0x715B0 VA: 0x1800721B0
	public string english; // 0x18

	// Properties
	public virtual string translated { get; }

	// Methods

	// RVA: 0x2320270 Offset: 0x231E870 VA: 0x182320270 Slot: 4
	public virtual string get_translated() { }

	// RVA: 0xD5B2D0 Offset: 0xD598D0 VA: 0x180D5B2D0
	public bool IsValid() { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string t = "", string eng = "") { }

	// RVA: 0x2320470 Offset: 0x231EA70 VA: 0x182320470
	public static Translate.Phrase op_Implicit(string b) { }

}

