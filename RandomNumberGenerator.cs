public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 972
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x17B7560 Offset: 0x17B5B60 VA: 0x1817B7560
	public static RandomNumberGenerator Create() { }

	// RVA: 0x17B75B0 Offset: 0x17B5BB0 VA: 0x1817B75B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data);

}

