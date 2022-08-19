internal class TermInfoReader // TypeDefIndex: 399
{	// Fields
	private short boolSize; // 0x10
	private short numSize; // 0x12
	private short strOffsets; // 0x14
	private byte[] buffer; // 0x18
	private int booleansOffset; // 0x20

	// Methods

	// RVA: 0x18C2870 Offset: 0x18C0E70 VA: 0x1818C2870
	public void .ctor(string term, string filename) { }

	// RVA: 0x18C27B0 Offset: 0x18C0DB0 VA: 0x1818C27B0
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x18C2400 Offset: 0x18C0A00 VA: 0x1818C2400
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x18C2700 Offset: 0x18C0D00 VA: 0x1818C2700
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x18C2330 Offset: 0x18C0930 VA: 0x1818C2330
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x18C21C0 Offset: 0x18C07C0 VA: 0x1818C21C0
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x18C1FA0 Offset: 0x18C05A0 VA: 0x1818C1FA0
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x18C1E60 Offset: 0x18C0460 VA: 0x1818C1E60
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x18C2130 Offset: 0x18C0730 VA: 0x1818C2130
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x18C1EE0 Offset: 0x18C04E0 VA: 0x1818C1EE0
	private byte[] GetStringBytes(byte[] buffer, int offset) { }

}

