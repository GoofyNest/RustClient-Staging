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

	// RVA: 0x2320D50 Offset: 0x231F350 VA: 0x182320D50
	public static void Init() { }

	// RVA: 0x2320DB0 Offset: 0x231F3B0 VA: 0x182320DB0
	public static void LoadLanguage(string lang) { }

	// RVA: 0x23207B0 Offset: 0x231EDB0 VA: 0x1823207B0
	private static void AddLanguageFile(string fileName) { }

	// RVA: 0x2320BB0 Offset: 0x231F1B0 VA: 0x182320BB0
	public static string Get(string key, string def) { }

	// RVA: 0x2320AA0 Offset: 0x231F0A0 VA: 0x182320AA0
	public static string FormatTranslated(Translate.Phrase phrase, string b) { }

	// RVA: 0x2320B50 Offset: 0x231F150 VA: 0x182320B50
	public static string GetLanguage() { }

	// RVA: 0x2320F00 Offset: 0x231F500 VA: 0x182320F00
	public static void SetLanguage(string str) { }

	// RVA: 0x2321010 Offset: 0x231F610 VA: 0x182321010
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

	// RVA: 0x2320530 Offset: 0x231EB30 VA: 0x182320530 Slot: 4
	public virtual string get_translated() { }

	// RVA: 0xD5B590 Offset: 0xD59B90 VA: 0x180D5B590
	public bool IsValid() { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string t = "", string eng = "") { }

	// RVA: 0x2320730 Offset: 0x231ED30 VA: 0x182320730
	public static Translate.Phrase op_Implicit(string b) { }

}

