private struct ThreadLocal.LinkedSlotVolatile<T> // TypeDefIndex: 768
{	internal ThreadLocal.LinkedSlot<T> Value; // 0x0

}

private sealed class ThreadLocal.LinkedSlot<T> // TypeDefIndex: 769
{	internal ThreadLocal.LinkedSlot<T> Next; // 0x0
	internal ThreadLocal.LinkedSlot<T> Previous; // 0x0
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	internal T Value; // 0x0


	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A400D0 Offset: 0x1A3E6D0 VA: 0x181A400D0
	|-ThreadLocal.LinkedSlot<object>..ctor
	*/

}

private class ThreadLocal.IdManager<T> // TypeDefIndex: 770
{	private int m_nextIdToTry; // 0x0
	private List<bool> m_freeIds; // 0x0


	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FE10 Offset: 0x1A3E410 VA: 0x181A3FE10
	|-ThreadLocal.IdManager<object>.GetId
	*/

	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FF60 Offset: 0x1A3E560 VA: 0x181A3FF60
	|-ThreadLocal.IdManager<object>.ReturnId
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A40060 Offset: 0x1A3E660 VA: 0x181A40060
	|-ThreadLocal.IdManager<object>..ctor
	*/

}

private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 771
{	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	private bool m_trackAllValues; // 0x0


	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FDC0 Offset: 0x1A3E3C0 VA: 0x181A3FDC0
	|-ThreadLocal.FinalizationHelper<object>..ctor
	*/

	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FAA0 Offset: 0x1A3E0A0 VA: 0x181A3FAA0
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	*/

}

