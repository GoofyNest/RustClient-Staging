internal class TermInfoReader // TypeDefIndex: 399
{	// Fields
	private short boolSize; // 0x10
	private short numSize; // 0x12
	private short strOffsets; // 0x14
	private byte[] buffer; // 0x18
	private int booleansOffset; // 0x20

	// Methods

	// RVA: 0x18C2210 Offset: 0x18C0810 VA: 0x1818C2210
	public void .ctor(string term, string filename) { }

	// RVA: 0x18C2150 Offset: 0x18C0750 VA: 0x1818C2150
	public void .ctor(string term, byte[] buffer) { }

	// RVA: 0x18C1DA0 Offset: 0x18C03A0 VA: 0x1818C1DA0
	private void ReadHeader(byte[] buffer, ref int position) { }

	// RVA: 0x18C20A0 Offset: 0x18C06A0 VA: 0x1818C20A0
	private void ReadNames(byte[] buffer, ref int position) { }

	// RVA: 0x18C1CD0 Offset: 0x18C02D0 VA: 0x1818C1CD0
	public int Get(TermInfoNumbers number) { }

	// RVA: 0x18C1B60 Offset: 0x18C0160 VA: 0x1818C1B60
	public string Get(TermInfoStrings tstr) { }

	// RVA: 0x18C1940 Offset: 0x18BFF40 VA: 0x1818C1940
	public byte[] GetStringBytes(TermInfoStrings tstr) { }

	// RVA: 0x18C1800 Offset: 0x18BFE00 VA: 0x1818C1800
	private short GetInt16(byte[] buffer, int offset) { }

	// RVA: 0x18C1AD0 Offset: 0x18C00D0 VA: 0x1818C1AD0
	private string GetString(byte[] buffer, int offset) { }

	// RVA: 0x18C1880 Offset: 0x18BFE80 VA: 0x1818C1880
	private byte[] GetStringBytes(byte[] buffer, int offset) { }

}

