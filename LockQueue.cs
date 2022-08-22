internal class LockQueue // TypeDefIndex: 825
{	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x1495420 Offset: 0x1493A20 VA: 0x181495420
	public bool Wait(int timeout) { }

	// RVA: 0x14955B0 Offset: 0x1493BB0 VA: 0x1814955B0
	public bool get_IsEmpty() { }

	// RVA: 0x14952A0 Offset: 0x14938A0 VA: 0x1814952A0
	public void Pulse() { }

}

