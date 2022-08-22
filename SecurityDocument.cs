internal sealed class SecurityDocument // TypeDefIndex: 897
{	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x17C3A60 Offset: 0x17C2060 VA: 0x1817C3A60
	public void .ctor(int numData) { }

	// RVA: 0x17C3720 Offset: 0x17C1D20 VA: 0x1817C3720
	public void GuaranteeSize(int size) { }

	// RVA: 0x17C2F00 Offset: 0x17C1500 VA: 0x1817C2F00
	public void AddString(string str, ref int position) { }

	// RVA: 0x17C31E0 Offset: 0x17C17E0 VA: 0x1817C31E0
	public void AppendString(string str, ref int position) { }

	// RVA: 0x17C32D0 Offset: 0x17C18D0 VA: 0x1817C32D0
	public static int EncodedStringSize(string str) { }

	// RVA: 0x17C3340 Offset: 0x17C1940 VA: 0x1817C3340
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x17C30F0 Offset: 0x17C16F0 VA: 0x1817C30F0
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x17C3310 Offset: 0x17C1910 VA: 0x1817C3310
	public SecurityElement GetRootElement() { }

	// RVA: 0x17C32F0 Offset: 0x17C18F0 VA: 0x1817C32F0
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x17C37C0 Offset: 0x17C1DC0 VA: 0x1817C37C0
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }

}

