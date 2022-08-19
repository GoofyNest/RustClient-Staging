public class IconSkinPicker : MonoBehaviour // TypeDefIndex: 9193
{	// Fields
	private static IconSkinPicker.SkinHistory loadedHistory; // 0x0
	private const string PrefsKey = "SkinHistory";
	public GameObjectRef pickerIcon; // 0x18
	public GameObject container; // 0x20
	public Action skinChangedEvent; // 0x28
	public ScrollRect scroller; // 0x30
	public SearchFilterInput searchFilter; // 0x38
	private ItemBlueprint lastBlueprintRefresh; // 0x40
	private List<IconSkin> spawnedSkinIcons; // 0x48

	// Methods

	// RVA: 0x8094F0 Offset: 0x807AF0 VA: 0x1808094F0
	public static bool HasRecentlyUsed(int skinId, out TimeSpan timeSince) { }

	// RVA: 0x80AAC0 Offset: 0x8090C0 VA: 0x18080AAC0
	public static void RegisterAsRecentlyUsedSkin(int skinId) { }

	// RVA: 0x809640 Offset: 0x807C40 VA: 0x180809640
	private static void LoadSkinHistory() { }

	// RVA: 0x80AE50 Offset: 0x809450 VA: 0x18080AE50
	private static void SaveSkinHistory() { }

	// RVA: 0x8099A0 Offset: 0x807FA0 VA: 0x1808099A0
	private void OnEnable() { }

	// RVA: 0x809AC0 Offset: 0x8080C0 VA: 0x180809AC0
	private void OnSearchFilterChanged(string filter) { }

	// RVA: 0x809890 Offset: 0x807E90 VA: 0x180809890
	private void OnDisable() { }

	// RVA: 0x8094D0 Offset: 0x807AD0 VA: 0x1808094D0
	internal void ForceNextRefresh() { }

	// RVA: 0x809E60 Offset: 0x808460 VA: 0x180809E60
	internal bool Refresh(ItemBlueprint blueprint) { }

	// RVA: 0x80AD20 Offset: 0x809320 VA: 0x18080AD20
	private void ResetScroller() { }

	// RVA: 0x809390 Offset: 0x807990 VA: 0x180809390
	private int CompareSkinOption(IconSkinPicker.SkinButtonSetup a, IconSkinPicker.SkinButtonSetup b) { }

	// RVA: 0x809060 Offset: 0x807660 VA: 0x180809060
	private void AddOption(ItemDefinition item, int skinid, string text, bool canUse) { }

	// RVA: 0x809D40 Offset: 0x808340 VA: 0x180809D40 Slot: 4
	public virtual void OnSkinChanged(int skinId) { }

	// RVA: 0x80AF20 Offset: 0x809520 VA: 0x18080AF20
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private class IconSkinPicker.SkinHistory // TypeDefIndex: 9194
{	// Fields
	public Dictionary<int, long> lastUsedSkins; // 0x10

	// Methods

	// RVA: 0x8202F0 Offset: 0x81E8F0 VA: 0x1808202F0
	public void .ctor() { }

}

private struct IconSkinPicker.SkinButtonSetup // TypeDefIndex: 9195
{	// Fields
	public ItemDefinition item; // 0x0
	public int skinid; // 0x8
	public string text; // 0x10
	public bool canUse; // 0x18

}

