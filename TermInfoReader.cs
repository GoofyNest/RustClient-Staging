internal class TermInfoReader // TypeDefIndex: 399
{	// Fields
	private short boolSize; // 0x10
	private short numSize; // 0x12
	private short strOffsets; // 0x14
	private byte[] buffer; // 0x18
	private int booleansOffset; // 0x20

	// Methods

	// RVA: 0x18C2AF0 Offset: 0x18C10F0 VA: 0x1818C2AF0
	public void .ctor(string term, string filename) { }

	// RVA: 0x18C2A30 Offset: 0x18C1030 VA: 0x1818C2A30
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x18C2680 Offset: 0x18C0C80 VA: 0x1818C2680
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x18C2980 Offset: 0x18C0F80 VA: 0x1818C2980
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x18C25B0 Offset: 0x18C0BB0 VA: 0x1818C25B0
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x18C2440 Offset: 0x18C0A40 VA: 0x1818C2440
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x18C2220 Offset: 0x18C0820 VA: 0x1818C2220
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x18C20E0 Offset: 0x18C06E0 VA: 0x1818C20E0
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x18C23B0 Offset: 0x18C09B0 VA: 0x1818C23B0
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x18C2160 Offset: 0x18C0760 VA: 0x1818C2160
	private byte[] GetStringBytes(byte[] buffer, int offset) { }

}

