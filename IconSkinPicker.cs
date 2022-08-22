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

	// RVA: 0x809600 Offset: 0x807C00 VA: 0x180809600
	public static bool HasRecentlyUsed(int skinId, out TimeSpan timeSince) { }

	// RVA: 0x80ABD0 Offset: 0x8091D0 VA: 0x18080ABD0
	public static void RegisterAsRecentlyUsedSkin(int skinId) { }

	// RVA: 0x809750 Offset: 0x807D50 VA: 0x180809750
	private static void LoadSkinHistory() { }

	// RVA: 0x80AF60 Offset: 0x809560 VA: 0x18080AF60
	private static void SaveSkinHistory() { }

	// RVA: 0x809AB0 Offset: 0x8080B0 VA: 0x180809AB0
	private void OnEnable() { }

	// RVA: 0x809BD0 Offset: 0x8081D0 VA: 0x180809BD0
	private void OnSearchFilterChanged(string filter) { }

	// RVA: 0x8099A0 Offset: 0x807FA0 VA: 0x1808099A0
	private void OnDisable() { }

	// RVA: 0x8095E0 Offset: 0x807BE0 VA: 0x1808095E0
	internal void ForceNextRefresh() { }

	// RVA: 0x809F70 Offset: 0x808570 VA: 0x180809F70
	internal bool Refresh(ItemBlueprint blueprint) { }

	// RVA: 0x80AE30 Offset: 0x809430 VA: 0x18080AE30
	private void ResetScroller() { }

	// RVA: 0x8094A0 Offset: 0x807AA0 VA: 0x1808094A0
	private int CompareSkinOption(IconSkinPicker.SkinButtonSetup a, IconSkinPicker.SkinButtonSetup b) { }

	// RVA: 0x809170 Offset: 0x807770 VA: 0x180809170
	private void AddOption(ItemDefinition item, int skinid, string text, bool canUse) { }

	// RVA: 0x809E50 Offset: 0x808450 VA: 0x180809E50 Slot: 4
	public virtual void OnSkinChanged(int skinId) { }

	// RVA: 0x80B030 Offset: 0x809630 VA: 0x18080B030
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private class IconSkinPicker.SkinHistory // TypeDefIndex: 9194
{	// Fields
	public Dictionary<int, long> lastUsedSkins; // 0x10

	// Methods

	// RVA: 0x820400 Offset: 0x81EA00 VA: 0x180820400
	public void .ctor() { }

}

private struct IconSkinPicker.SkinButtonSetup // TypeDefIndex: 9195
{	// Fields
	public ItemDefinition item; // 0x0
	public int skinid; // 0x8
	public string text; // 0x10
	public bool canUse; // 0x18

}

