internal class TabbedPanel // TypeDefIndex: 12026
{	private int selectedTabID; // 0x10
	private List<TabbedPanel.Tab> tabs; // 0x18

	public TabbedPanel.Tab selectedTab { get; }


	public TabbedPanel.Tab get_selectedTab() { }

	public void Add(TabbedPanel.Tab tab) { }

	internal void DrawVertical(float width) { }

	internal void DrawContents() { }

	public void .ctor() { }

}

public struct TabbedPanel.Tab // TypeDefIndex: 12027
{	public string name; // 0x0
	public Action drawFunc; // 0x8

}

