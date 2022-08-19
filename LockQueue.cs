internal class LockQueue // TypeDefIndex: 825
{	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x1495160 Offset: 0x1493760 VA: 0x181495160
	public bool Wait(int timeout) { }

	// RVA: 0x14952F0 Offset: 0x14938F0 VA: 0x1814952F0
	public bool get_IsEmpty() { }

	// RVA: 0x1494FE0 Offset: 0x14935E0 VA: 0x181494FE0
	public void Pulse() { }

}

