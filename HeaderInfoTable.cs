internal class HeaderInfoTable // TypeDefIndex: 2916
{	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x13381D0 Offset: 0x13367D0 VA: 0x1813381D0
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x1337FE0 Offset: 0x13365E0 VA: 0x181337FE0
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1338280 Offset: 0x1336880 VA: 0x181338280
	private static void .cctor() { }

	// RVA: 0x133A820 Offset: 0x1338E20 VA: 0x18133A820
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

