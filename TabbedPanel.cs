internal class TabbedPanel // TypeDefIndex: 12022
{	// Fields
	private int selectedTabID; // 0x10
	private List<TabbedPanel.Tab> tabs; // 0x18

	// Properties
	public TabbedPanel.Tab selectedTab { get; }

	// Methods

	// RVA: 0x799610 Offset: 0x797C10 VA: 0x180799610
	public TabbedPanel.Tab get_selectedTab() { }

	// RVA: 0x799010 Offset: 0x797610 VA: 0x180799010
	public void Add(TabbedPanel.Tab tab) { }

	// RVA: 0x799260 Offset: 0x797860 VA: 0x180799260
	internal void DrawVertical(float width) { }

	// RVA: 0x799070 Offset: 0x797670 VA: 0x180799070
	internal void DrawContents() { }

	// RVA: 0x7995A0 Offset: 0x797BA0 VA: 0x1807995A0
	public void .ctor() { }

}

public struct TabbedPanel.Tab // TypeDefIndex: 12023
{	// Fields
	public string name; // 0x0
	public Action drawFunc; // 0x8

}

