private struct ThreadLocal.LinkedSlotVolatile<T> // TypeDefIndex: 768
{	// Fields
	internal ThreadLocal.LinkedSlot<T> Value; // 0x0

}

private sealed class ThreadLocal.LinkedSlot<T> // TypeDefIndex: 769
{	// Fields
	internal ThreadLocal.LinkedSlot<T> Next; // 0x0
	internal ThreadLocal.LinkedSlot<T> Previous; // 0x0
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	internal T Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53BA0 Offset: 0x1A521A0 VA: 0x181A53BA0
	|-ThreadLocal.LinkedSlot<object>..ctor
	*/

}

private class ThreadLocal.IdManager<T> // TypeDefIndex: 770
{	// Fields
	private int m_nextIdToTry; // 0x0
	private List<bool> m_freeIds; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A538E0 Offset: 0x1A51EE0 VA: 0x181A538E0
	|-ThreadLocal.IdManager<object>.GetId
	*/

	// RVA: -1 Offset: -1
	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53A30 Offset: 0x1A52030 VA: 0x181A53A30
	|-ThreadLocal.IdManager<object>.ReturnId
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53B30 Offset: 0x1A52130 VA: 0x181A53B30
	|-ThreadLocal.IdManager<object>..ctor
	*/

}

private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 771
{	// Fields
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	private bool m_trackAllValues; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53890 Offset: 0x1A51E90 VA: 0x181A53890
	|-ThreadLocal.FinalizationHelper<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A53570 Offset: 0x1A51B70 VA: 0x181A53570
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	*/

}

