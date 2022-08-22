internal class TabbedPanel // TypeDefIndex: 12022
{	// Fields
	private int selectedTabID; // 0x10
	private List<TabbedPanel.Tab> tabs; // 0x18

	// Properties
	public TabbedPanel.Tab selectedTab { get; }

	// Methods

	// RVA: 0x799700 Offset: 0x797D00 VA: 0x180799700
	public TabbedPanel.Tab get_selectedTab() { }

	// RVA: 0x799100 Offset: 0x797700 VA: 0x180799100
	public void Add(TabbedPanel.Tab tab) { }

	// RVA: 0x799350 Offset: 0x797950 VA: 0x180799350
	internal void DrawVertical(float width) { }

	// RVA: 0x799160 Offset: 0x797760 VA: 0x180799160
	internal void DrawContents() { }

	// RVA: 0x799690 Offset: 0x797C90 VA: 0x180799690
	public void .ctor() { }

}

public struct TabbedPanel.Tab // TypeDefIndex: 12023
{	// Fields
	public string name; // 0x0
	public Action drawFunc; // 0x8

}

