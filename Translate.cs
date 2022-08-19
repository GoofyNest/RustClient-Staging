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

	// RVA: 0x2320C50 Offset: 0x231F250 VA: 0x182320C50
	public static void Init() { }

	// RVA: 0x2320CB0 Offset: 0x231F2B0 VA: 0x182320CB0
	public static void LoadLanguage(string lang) { }

	// RVA: 0x23206B0 Offset: 0x231ECB0 VA: 0x1823206B0
	private static void AddLanguageFile(string fileName) { }

	// RVA: 0x2320AB0 Offset: 0x231F0B0 VA: 0x182320AB0
	public static string Get(string key, string def) { }

	// RVA: 0x23209A0 Offset: 0x231EFA0 VA: 0x1823209A0
	public static string FormatTranslated(Translate.Phrase phrase, string b) { }

	// RVA: 0x2320A50 Offset: 0x231F050 VA: 0x182320A50
	public static string GetLanguage() { }

	// RVA: 0x2320E00 Offset: 0x231F400 VA: 0x182320E00
	public static void SetLanguage(string str) { }

	// RVA: 0x2320F10 Offset: 0x231F510 VA: 0x182320F10
	private static void .cctor() { }

}

public class Translate.Phrase // TypeDefIndex: 6719
{	// Fields
	public string token; // 0x10
	[TextAreaAttribute] // RVA: 0x72110 Offset: 0x71510 VA: 0x180072110
	public string english; // 0x18

	// Properties
	public virtual string translated { get; }

	// Methods

	// RVA: 0x2320430 Offset: 0x231EA30 VA: 0x182320430 Slot: 4
	public virtual string get_translated() { }

	// RVA: 0xD5B2D0 Offset: 0xD598D0 VA: 0x180D5B2D0
	public bool IsValid() { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	public void .ctor(string t = "", string eng = "") { }

	// RVA: 0x2320630 Offset: 0x231EC30 VA: 0x182320630
	public static Translate.Phrase op_Implicit(string b) { }

}

