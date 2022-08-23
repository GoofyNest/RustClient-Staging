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
	|-RVA: 0x1A40110 Offset: 0x1A3E710 VA: 0x181A40110
	|-ThreadLocal.LinkedSlot<object>..ctor
	*/

}

private class ThreadLocal.IdManager<T> // TypeDefIndex: 770
{	private int m_nextIdToTry; // 0x0
	private List<bool> m_freeIds; // 0x0


	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FE50 Offset: 0x1A3E450 VA: 0x181A3FE50
	|-ThreadLocal.IdManager<object>.GetId
	*/

	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FFA0 Offset: 0x1A3E5A0 VA: 0x181A3FFA0
	|-ThreadLocal.IdManager<object>.ReturnId
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A400A0 Offset: 0x1A3E6A0 VA: 0x181A400A0
	|-ThreadLocal.IdManager<object>..ctor
	*/

}

private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 771
{	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	private bool m_trackAllValues; // 0x0


	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FE00 Offset: 0x1A3E400 VA: 0x181A3FE00
	|-ThreadLocal.FinalizationHelper<object>..ctor
	*/

	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FAE0 Offset: 0x1A3E0E0 VA: 0x181A3FAE0
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	*/

}

