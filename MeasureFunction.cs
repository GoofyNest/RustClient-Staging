internal sealed class MeasureFunction : MulticastDelegate // TypeDefIndex: 4576
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22F6130 Offset: 0x22F4730 VA: 0x1822F6130 Slot: 12
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F6060 Offset: 0x22F4660 VA: 0x1822F6060 Slot: 13
	public virtual IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, object object) { }

	// RVA: 0x12213D0 Offset: 0x121F9D0 VA: 0x1812213D0 Slot: 14
	public virtual YogaSize EndInvoke(IAsyncResult result) { }

}

