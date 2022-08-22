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
	// RVA: 0x1A63050 Offset: 0x1A61650 VA: 0x181A63050
	public void .ctor() { }

	// RVA: 0x1A62BA0 Offset: 0x1A611A0 VA: 0x181A62BA0 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1A62C40 Offset: 0x1A61240 VA: 0x181A62C40 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1A62A50 Offset: 0x1A61050 VA: 0x181A62A50 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1A62DB0 Offset: 0x1A613B0 VA: 0x181A62DB0 Slot: 11
	public override void SetVertical(float y, float height) { }

}

