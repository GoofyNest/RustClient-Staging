internal class DigestHeaderParser // TypeDefIndex: 2992
{
// Namespace: System.Net
internal class DigestHeaderParser // TypeDefIndex: 2992
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x152DEE0 Offset: 0x152C4E0 VA: 0x18152DEE0
	public void .ctor(string header) { }

	// RVA: 0x152E0A0 Offset: 0x152C6A0 VA: 0x18152E0A0
	public string get_Realm() { }

	// RVA: 0x152E020 Offset: 0x152C620 VA: 0x18152E020
	public string get_Opaque() { }

	// RVA: 0x152DFE0 Offset: 0x152C5E0 VA: 0x18152DFE0
	public string get_Nonce() { }

	// RVA: 0x152DFA0 Offset: 0x152C5A0 VA: 0x18152DFA0
	public string get_Algorithm() { }

	// RVA: 0x152E060 Offset: 0x152C660 VA: 0x18152E060
	public string get_QOP() { }

	// RVA: 0x152D9D0 Offset: 0x152BFD0 VA: 0x18152D9D0
	public bool Parse() { }

	// RVA: 0x152DC10 Offset: 0x152C210 VA: 0x18152DC10
	private void SkipWhitespace() { }

	// RVA: 0x152D6E0 Offset: 0x152BCE0 VA: 0x18152D6E0
	private string GetKey() { }

	// RVA: 0x152D770 Offset: 0x152BD70 VA: 0x18152D770
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x152DC80 Offset: 0x152C280 VA: 0x18152DC80
	private static void .cctor() { }

}

