internal class TabbedPanel // TypeDefIndex: 12022
{	// Fields
	private int selectedTabID; // 0x10
	private List<TabbedPanel.Tab> tabs; // 0x18

	// Properties
	public TabbedPanel.Tab selectedTab { get; }

	// Methods

	// RVA: 0x7995F0 Offset: 0x797BF0 VA: 0x1807995F0
	public TabbedPanel.Tab get_selectedTab() { }

	// RVA: 0x798FF0 Offset: 0x7975F0 VA: 0x180798FF0
	public void Add(TabbedPanel.Tab tab) { }

	// RVA: 0x799240 Offset: 0x797840 VA: 0x180799240
	internal void DrawVertical(float width) { }

	// RVA: 0x799050 Offset: 0x797650 VA: 0x180799050
	internal void DrawContents() { }

	// RVA: 0x799580 Offset: 0x797B80 VA: 0x180799580
	public void .ctor() { }

}

public struct TabbedPanel.Tab // TypeDefIndex: 12023
{	// Fields
	public string name; // 0x0
	public Action drawFunc; // 0x8

}

