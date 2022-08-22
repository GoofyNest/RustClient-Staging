public class ObjectIDGenerator // TypeDefIndex: 1036
{	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x1294E70 Offset: 0x1293470 VA: 0x181294E70
	public void .ctor() { }

	// RVA: 0x1294710 Offset: 0x1292D10 VA: 0x181294710
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x12947D0 Offset: 0x1292DD0 VA: 0x1812947D0 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x12949B0 Offset: 0x1292FB0 VA: 0x1812949B0 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x1294AA0 Offset: 0x12930A0 VA: 0x181294AA0
	private void Rehash() { }

	// RVA: 0x1294E00 Offset: 0x1293400 VA: 0x181294E00
	private static void .cctor() { }

}

