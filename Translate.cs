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

	// RVA: 0x2321570 Offset: 0x231FB70 VA: 0x182321570
	public static void Init() { }

	// RVA: 0x23215D0 Offset: 0x231FBD0 VA: 0x1823215D0
	public static void LoadLanguage(string lang) { }

	// RVA: 0x2320FD0 Offset: 0x231F5D0 VA: 0x182320FD0
	private static void AddLanguageFile(string fileName) { }

	// RVA: 0x23213D0 Offset: 0x231F9D0 VA: 0x1823213D0
	public static string Get(string key, string def) { }

	// RVA: 0x23212C0 Offset: 0x231F8C0 VA: 0x1823212C0
	public static string FormatTranslated(Translate.Phrase phrase, string b) { }

	// RVA: 0x2321370 Offset: 0x231F970 VA: 0x182321370
	public static string GetLanguage() { }

	// RVA: 0x2321720 Offset: 0x231FD20 VA: 0x182321720
	public static void SetLanguage(string str) { }

	// RVA: 0x2321830 Offset: 0x231FE30 VA: 0x182321830
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

	// RVA: 0x2320D50 Offset: 0x231F350 VA: 0x182320D50 Slot: 4
	public virtual string get_translated() { }

	// RVA: 0xD5C040 Offset: 0xD5A640 VA: 0x180D5C040
	public bool IsValid() { }

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	public void .ctor(string t = "", string eng = "") { }

	// RVA: 0x2320F50 Offset: 0x231F550 VA: 0x182320F50
	public static Translate.Phrase op_Implicit(string b) { }

}

