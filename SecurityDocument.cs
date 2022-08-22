internal sealed class SecurityDocument // TypeDefIndex: 897
{	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x17C15B0 Offset: 0x17BFBB0 VA: 0x1817C15B0
	public void .ctor(int numData) { }

	// RVA: 0x17C1270 Offset: 0x17BF870 VA: 0x1817C1270
	public void GuaranteeSize(int size) { }

	// RVA: 0x17C0A50 Offset: 0x17BF050 VA: 0x1817C0A50
	public void AddString(string str, ref int position) { }

	// RVA: 0x17C0D30 Offset: 0x17BF330 VA: 0x1817C0D30
	public void AppendString(string str, ref int position) { }

	// RVA: 0x17C0E20 Offset: 0x17BF420 VA: 0x1817C0E20
	public static int EncodedStringSize(string str) { }

	// RVA: 0x17C0E90 Offset: 0x17BF490 VA: 0x1817C0E90
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x17C0C40 Offset: 0x17BF240 VA: 0x1817C0C40
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x17C0E60 Offset: 0x17BF460 VA: 0x1817C0E60
	public SecurityElement GetRootElement() { }

	// RVA: 0x17C0E40 Offset: 0x17BF440 VA: 0x1817C0E40
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x17C1310 Offset: 0x17BF910 VA: 0x1817C1310
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }

}

