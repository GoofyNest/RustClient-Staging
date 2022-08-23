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
	|-RVA: 0x1A40210 Offset: 0x1A3E810 VA: 0x181A40210
	|-ThreadLocal.LinkedSlot<object>..ctor
	*/

}

private class ThreadLocal.IdManager<T> // TypeDefIndex: 770
{	private int m_nextIdToTry; // 0x0
	private List<bool> m_freeIds; // 0x0


	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FF50 Offset: 0x1A3E550 VA: 0x181A3FF50
	|-ThreadLocal.IdManager<object>.GetId
	*/

	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A400A0 Offset: 0x1A3E6A0 VA: 0x181A400A0
	|-ThreadLocal.IdManager<object>.ReturnId
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A401A0 Offset: 0x1A3E7A0 VA: 0x181A401A0
	|-ThreadLocal.IdManager<object>..ctor
	*/

}

private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 771
{	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	private bool m_trackAllValues; // 0x0


	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FF00 Offset: 0x1A3E500 VA: 0x181A3FF00
	|-ThreadLocal.FinalizationHelper<object>..ctor
	*/

	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1A3FBE0 Offset: 0x1A3E1E0 VA: 0x181A3FBE0
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	*/

}

