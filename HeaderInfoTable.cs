internal class HeaderInfoTable // TypeDefIndex: 2916
{	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x13390D0 Offset: 0x13376D0 VA: 0x1813390D0
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x1338EE0 Offset: 0x13374E0 VA: 0x181338EE0
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1339180 Offset: 0x1337780 VA: 0x181339180
	private static void .cctor() { }

	// RVA: 0x133B720 Offset: 0x1339D20 VA: 0x18133B720
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

