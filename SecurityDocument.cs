internal sealed class SecurityDocument // TypeDefIndex: 897
{	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x17C37A0 Offset: 0x17C1DA0 VA: 0x1817C37A0
	public void .ctor(int numData) { }

	// RVA: 0x17C3460 Offset: 0x17C1A60 VA: 0x1817C3460
	public void GuaranteeSize(int size) { }

	// RVA: 0x17C2C40 Offset: 0x17C1240 VA: 0x1817C2C40
	public void AddString(string str, ref int position) { }

	// RVA: 0x17C2F20 Offset: 0x17C1520 VA: 0x1817C2F20
	public void AppendString(string str, ref int position) { }

	// RVA: 0x17C3010 Offset: 0x17C1610 VA: 0x1817C3010
	public static int EncodedStringSize(string str) { }

	// RVA: 0x17C3080 Offset: 0x17C1680 VA: 0x1817C3080
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x17C2E30 Offset: 0x17C1430 VA: 0x1817C2E30
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x17C3050 Offset: 0x17C1650 VA: 0x1817C3050
	public SecurityElement GetRootElement() { }

	// RVA: 0x17C3030 Offset: 0x17C1630 VA: 0x1817C3030
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x17C3500 Offset: 0x17C1B00 VA: 0x1817C3500
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }

}

