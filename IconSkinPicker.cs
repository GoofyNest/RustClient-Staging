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

	// RVA: 0x809B90 Offset: 0x808190 VA: 0x180809B90
	public static bool HasRecentlyUsed(int skinId, out TimeSpan timeSince) { }

	// RVA: 0x80B160 Offset: 0x809760 VA: 0x18080B160
	public static void RegisterAsRecentlyUsedSkin(int skinId) { }

	// RVA: 0x809CE0 Offset: 0x8082E0 VA: 0x180809CE0
	private static void LoadSkinHistory() { }

	// RVA: 0x80B4F0 Offset: 0x809AF0 VA: 0x18080B4F0
	private static void SaveSkinHistory() { }

	// RVA: 0x80A040 Offset: 0x808640 VA: 0x18080A040
	private void OnEnable() { }

	// RVA: 0x80A160 Offset: 0x808760 VA: 0x18080A160
	private void OnSearchFilterChanged(string filter) { }

	// RVA: 0x809F30 Offset: 0x808530 VA: 0x180809F30
	private void OnDisable() { }

	// RVA: 0x809B70 Offset: 0x808170 VA: 0x180809B70
	internal void ForceNextRefresh() { }

	// RVA: 0x80A500 Offset: 0x808B00 VA: 0x18080A500
	internal bool Refresh(ItemBlueprint blueprint) { }

	// RVA: 0x80B3C0 Offset: 0x8099C0 VA: 0x18080B3C0
	private void ResetScroller() { }

	// RVA: 0x809A30 Offset: 0x808030 VA: 0x180809A30
	private int CompareSkinOption(IconSkinPicker.SkinButtonSetup a, IconSkinPicker.SkinButtonSetup b) { }

	// RVA: 0x809700 Offset: 0x807D00 VA: 0x180809700
	private void AddOption(ItemDefinition item, int skinid, string text, bool canUse) { }

	// RVA: 0x80A3E0 Offset: 0x8089E0 VA: 0x18080A3E0 Slot: 4
	public virtual void OnSkinChanged(int skinId) { }

	// RVA: 0x80B5C0 Offset: 0x809BC0 VA: 0x18080B5C0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

private class IconSkinPicker.SkinHistory // TypeDefIndex: 9194
{	// Fields
	public Dictionary<int, long> lastUsedSkins; // 0x10

	// Methods

	// RVA: 0x820990 Offset: 0x81EF90 VA: 0x180820990
	public void .ctor() { }

}

private struct IconSkinPicker.SkinButtonSetup // TypeDefIndex: 9195
{	// Fields
	public ItemDefinition item; // 0x0
	public int skinid; // 0x8
	public string text; // 0x10
	public bool canUse; // 0x18

}

