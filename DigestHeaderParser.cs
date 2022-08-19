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

	// RVA: 0x152DC20 Offset: 0x152C220 VA: 0x18152DC20
	public void .ctor(string header) { }

	// RVA: 0x152DDE0 Offset: 0x152C3E0 VA: 0x18152DDE0
	public string get_Realm() { }

	// RVA: 0x152DD60 Offset: 0x152C360 VA: 0x18152DD60
	public string get_Opaque() { }

	// RVA: 0x152DD20 Offset: 0x152C320 VA: 0x18152DD20
	public string get_Nonce() { }

	// RVA: 0x152DCE0 Offset: 0x152C2E0 VA: 0x18152DCE0
	public string get_Algorithm() { }

	// RVA: 0x152DDA0 Offset: 0x152C3A0 VA: 0x18152DDA0
	public string get_QOP() { }

	// RVA: 0x152D710 Offset: 0x152BD10 VA: 0x18152D710
	public bool Parse() { }

	// RVA: 0x152D950 Offset: 0x152BF50 VA: 0x18152D950
	private void SkipWhitespace() { }

	// RVA: 0x152D420 Offset: 0x152BA20 VA: 0x18152D420
	private string GetKey() { }

	// RVA: 0x152D4B0 Offset: 0x152BAB0 VA: 0x18152D4B0
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x152D9C0 Offset: 0x152BFC0 VA: 0x18152D9C0
	private static void .cctor() { }

}

