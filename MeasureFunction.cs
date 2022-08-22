internal sealed class MeasureFunction : MulticastDelegate // TypeDefIndex: 4576
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22F5F70 Offset: 0x22F4570 VA: 0x1822F5F70 Slot: 12
	public virtual YogaSize Invoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x22F5EA0 Offset: 0x22F44A0 VA: 0x1822F5EA0 Slot: 13
	public virtual IAsyncResult BeginInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, AsyncCallback callback, object object) { }

	// RVA: 0x12213D0 Offset: 0x121F9D0 VA: 0x1812213D0 Slot: 14
	public virtual YogaSize EndInvoke(IAsyncResult result) { }

}

