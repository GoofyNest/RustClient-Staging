internal class CodePageDataItem // TypeDefIndex: 735
{	// Fields
	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal string m_headerName; // 0x20
	internal string m_bodyName; // 0x28
	internal uint m_flags; // 0x30
	private static readonly char[] sep; // 0x0

	// Properties
	public string WebName { get; }
	public virtual int UIFamilyCodePage { get; }
	public string HeaderName { get; }
	public string BodyName { get; }
	public uint Flags { get; }

	// Methods

	// RVA: 0x10D3AD0 Offset: 0x10D20D0 VA: 0x1810D3AD0
	internal void .ctor(int dataIndex) { }

	// RVA: 0x10D3980 Offset: 0x10D1F80 VA: 0x1810D3980
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x10D3D90 Offset: 0x10D2390 VA: 0x1810D3D90
	public string get_WebName() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 4
	public virtual int get_UIFamilyCodePage() { }

	// RVA: 0x10D3CA0 Offset: 0x10D22A0 VA: 0x1810D3CA0
	public string get_HeaderName() { }

	// RVA: 0x10D3BB0 Offset: 0x10D21B0 VA: 0x1810D3BB0
	public string get_BodyName() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	public uint get_Flags() { }

	// RVA: 0x10D3A50 Offset: 0x10D2050 VA: 0x1810D3A50
	private static void .cctor() { }

}

