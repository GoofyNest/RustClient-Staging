internal class LockQueue // TypeDefIndex: 825
{	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x14944F0 Offset: 0x1492AF0 VA: 0x1814944F0
	public bool Wait(int timeout) { }

	// RVA: 0x1494680 Offset: 0x1492C80 VA: 0x181494680
	public bool get_IsEmpty() { }

	// RVA: 0x1494370 Offset: 0x1492970 VA: 0x181494370
	public void Pulse() { }

}

