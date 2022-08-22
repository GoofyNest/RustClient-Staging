internal sealed class MeasureFunction : MulticastDelegate // TypeDefIndex: 4576
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22F6A50 Offset: 0x22F5050 VA: 0x1822F6A50 Slot: 12
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F6980 Offset: 0x22F4F80 VA: 0x1822F6980 Slot: 13
	public virtual IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, object object) { }

	// RVA: 0x1221D30 Offset: 0x1220330 VA: 0x181221D30 Slot: 14
	public virtual YogaSize EndInvoke(IAsyncResult result) { }

}

