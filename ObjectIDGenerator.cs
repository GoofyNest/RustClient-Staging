public class ObjectIDGenerator // TypeDefIndex: 1036
{	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x1295510 Offset: 0x1293B10 VA: 0x181295510
	public void .ctor() { }

	// RVA: 0x1294DB0 Offset: 0x12933B0 VA: 0x181294DB0
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x1294E70 Offset: 0x1293470 VA: 0x181294E70 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x1295050 Offset: 0x1293650 VA: 0x181295050 Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x1295140 Offset: 0x1293740 VA: 0x181295140
	private void Rehash() { }

	// RVA: 0x12954A0 Offset: 0x1293AA0 VA: 0x1812954A0
	private static void .cctor() { }

}

