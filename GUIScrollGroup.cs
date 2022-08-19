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

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1A768A0 Offset: 0x1A74EA0 VA: 0x181A768A0
	public void .ctor() { }

	// RVA: 0x1A763F0 Offset: 0x1A749F0 VA: 0x181A763F0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1A76490 Offset: 0x1A74A90 VA: 0x181A76490 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1A762A0 Offset: 0x1A748A0 VA: 0x181A762A0 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1A76600 Offset: 0x1A74C00 VA: 0x181A76600 Slot: 11
	public override void SetVertical(float y, float height) { }

}

