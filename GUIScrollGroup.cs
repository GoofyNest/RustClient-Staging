internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 4056
{	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1A76860 Offset: 0x1A74E60 VA: 0x181A76860
	public void .ctor() { }

	// RVA: 0x1A763B0 Offset: 0x1A749B0 VA: 0x181A763B0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1A76450 Offset: 0x1A74A50 VA: 0x181A76450 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1A76260 Offset: 0x1A74860 VA: 0x181A76260 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1A765C0 Offset: 0x1A74BC0 VA: 0x181A765C0 Slot: 11
	public override void SetVertical(float y, float height) { }

}

