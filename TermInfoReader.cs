internal class TermInfoReader // TypeDefIndex: 399
{	// Fields
	private short boolSize; // 0x10
	private short numSize; // 0x12
	private short strOffsets; // 0x14
	private byte[] buffer; // 0x18
	private int booleansOffset; // 0x20

	// Methods

	// RVA: 0x18C2830 Offset: 0x18C0E30 VA: 0x1818C2830
	public void .ctor(string term, string filename) { }

	// RVA: 0x18C2770 Offset: 0x18C0D70 VA: 0x1818C2770
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x18C23C0 Offset: 0x18C09C0 VA: 0x1818C23C0
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x18C26C0 Offset: 0x18C0CC0 VA: 0x1818C26C0
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x18C22F0 Offset: 0x18C08F0 VA: 0x1818C22F0
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x18C2180 Offset: 0x18C0780 VA: 0x1818C2180
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x18C1F60 Offset: 0x18C0560 VA: 0x1818C1F60
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x18C1E20 Offset: 0x18C0420 VA: 0x1818C1E20
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x18C20F0 Offset: 0x18C06F0 VA: 0x1818C20F0
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x18C1EA0 Offset: 0x18C04A0 VA: 0x1818C1EA0
	private byte[] GetStringBytes(byte[] buffer, int offset) { }

}

