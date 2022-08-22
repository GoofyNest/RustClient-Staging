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
	// RVA: 0x1A76B20 Offset: 0x1A75120 VA: 0x181A76B20
	public void .ctor() { }

	// RVA: 0x1A76670 Offset: 0x1A74C70 VA: 0x181A76670 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1A76710 Offset: 0x1A74D10 VA: 0x181A76710 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1A76520 Offset: 0x1A74B20 VA: 0x181A76520 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1A76880 Offset: 0x1A74E80 VA: 0x181A76880 Slot: 11
	public override void SetVertical(float y, float height) { }

}

