internal class GZipOutputStream : DeflaterOutputStream // TypeDefIndex: 5655
{	// Fields
	protected Crc32 crc; // 0x50

	// Methods

	// RVA: 0x23032A0 Offset: 0x23018A0 VA: 0x1823032A0
	public void .ctor(Stream baseOutputStream) { }

	// RVA: 0x2303070 Offset: 0x2301670 VA: 0x182303070
	public void .ctor(Stream baseOutputStream, int size) { }

	// RVA: 0x2302DA0 Offset: 0x23013A0 VA: 0x182302DA0
	private void WriteHeader() { }

	// RVA: 0x2302FF0 Offset: 0x23015F0 VA: 0x182302FF0 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x2302B80 Offset: 0x2301180 VA: 0x182302B80 Slot: 16
	public override void Close() { }

	// RVA: 0x2302BD0 Offset: 0x23011D0 VA: 0x182302BD0 Slot: 31
	public override void Finish() { }

}

