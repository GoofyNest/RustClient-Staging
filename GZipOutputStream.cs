internal class GZipOutputStream : DeflaterOutputStream // TypeDefIndex: 5655
{	// Fields
	protected Crc32 crc; // 0x50

	// Methods

	// RVA: 0x2303460 Offset: 0x2301A60 VA: 0x182303460
	public void .ctor(Stream baseOutputStream) { }

	// RVA: 0x2303230 Offset: 0x2301830 VA: 0x182303230
	public void .ctor(Stream baseOutputStream, int size) { }

	// RVA: 0x2302F60 Offset: 0x2301560 VA: 0x182302F60
	private void WriteHeader() { }

	// RVA: 0x23031B0 Offset: 0x23017B0 VA: 0x1823031B0 Slot: 29
	public override void Write(byte[] buf, int off, int len) { }

	// RVA: 0x2302D40 Offset: 0x2301340 VA: 0x182302D40 Slot: 16
	public override void Close() { }

	// RVA: 0x2302D90 Offset: 0x2301390 VA: 0x182302D90 Slot: 31
	public override void Finish() { }

}

