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

	// RVA: 0x10D4800 Offset: 0x10D2E00 VA: 0x1810D4800
	internal void .ctor(int dataIndex) { }

	// RVA: 0x10D46B0 Offset: 0x10D2CB0 VA: 0x1810D46B0
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x10D4AC0 Offset: 0x10D30C0 VA: 0x1810D4AC0
	public string get_WebName() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960 Slot: 4
	public virtual int get_UIFamilyCodePage() { }

	// RVA: 0x10D49D0 Offset: 0x10D2FD0 VA: 0x1810D49D0
	public string get_HeaderName() { }

	// RVA: 0x10D48E0 Offset: 0x10D2EE0 VA: 0x1810D48E0
	public string get_BodyName() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public uint get_Flags() { }

	// RVA: 0x10D4780 Offset: 0x10D2D80 VA: 0x1810D4780
	private static void .cctor() { }

}

