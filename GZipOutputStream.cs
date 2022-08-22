internal class GZipOutputStream : DeflaterOutputStream // TypeDefIndex: 5655
{	// Fields
	protected Crc32 crc; // 0x50

	// Methods

	// RVA: 0x2303560 Offset: 0x2301B60 VA: 0x182303560
	public void .ctor(Stream baseOutputStream) { }

	// RVA: 0x2303330 Offset: 0x2301930 VA: 0x182303330
	public void .ctor(Stream baseOutputStream, int size) { }

	// RVA: 0x2303060 Offset: 0x2301660 VA: 0x182303060
	private void WriteHeader() { }

	// RVA: 0x23032B0 Offset: 0x23018B0 VA: 0x1823032B0 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x2302E40 Offset: 0x2301440 VA: 0x182302E40 Slot: 16
	public override void Close() { }

	// RVA: 0x2302E90 Offset: 0x2301490 VA: 0x182302E90 Slot: 31
	public override void Finish() { }

}

