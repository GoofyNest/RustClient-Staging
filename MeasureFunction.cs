internal sealed class MeasureFunction : MulticastDelegate // TypeDefIndex: 4576
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22F6230 Offset: 0x22F4830 VA: 0x1822F6230 Slot: 12
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F6160 Offset: 0x22F4760 VA: 0x1822F6160 Slot: 13
	public virtual IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, object object) { }

	// RVA: 0x1221690 Offset: 0x121FC90 VA: 0x181221690 Slot: 14
	public virtual YogaSize EndInvoke(IAsyncResult result) { }

}

