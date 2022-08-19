public class ObjectIDGenerator // TypeDefIndex: 1036
{	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x1294BB0 Offset: 0x12931B0 VA: 0x181294BB0
	public void .ctor() { }

	// RVA: 0x1294450 Offset: 0x1292A50 VA: 0x181294450
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x1294510 Offset: 0x1292B10 VA: 0x181294510 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x12946F0 Offset: 0x1292CF0 VA: 0x1812946F0 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x12947E0 Offset: 0x1292DE0 VA: 0x1812947E0
	private void Rehash() { }

	// RVA: 0x1294B40 Offset: 0x1293140 VA: 0x181294B40
	private static void .cctor() { }

}

