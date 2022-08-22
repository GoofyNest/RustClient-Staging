public class QuickCraft : SingletonComponent<QuickCraft>, IInventoryChanged // TypeDefIndex: 11045
{	// Fields
	public GameObjectRef craftButton; // 0x18
	public GameObject empty; // 0x20
	public Sprite FavouriteOnSprite; // 0x28
	public Sprite FavouriteOffSprite; // 0x30
	public Color FavouriteOnColor; // 0x38
	public Color FavouriteOffColor; // 0x48
	public static HashSet<ItemBlueprint> FavouriteBlueprints; // 0x0
	private float lastRebuildTime; // 0x58
	private bool forceRebuild; // 0x5C
	private bool isDirty; // 0x5D
	private int lastHash; // 0x60
	private const int buttonCount = 18;

	// Methods

	// RVA: 0x69C2A0 Offset: 0x69A8A0 VA: 0x18069C2A0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x69C3E0 Offset: 0x69A9E0 VA: 0x18069C3E0
	private void LoadFavourites() { }

	// RVA: 0x69C6A0 Offset: 0x69ACA0 VA: 0x18069C6A0
	private void OnEnable() { }

	// RVA: 0x69C5F0 Offset: 0x69ABF0 VA: 0x18069C5F0
	private void OnDisable() { }

	// RVA: 0x69C2E0 Offset: 0x69A8E0 VA: 0x18069C2E0 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x69C2E0 Offset: 0x69A8E0 VA: 0x18069C2E0
	private void Dirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x90D90 Offset: 0x90190 VA: 0x180090D90
	// RVA: 0x69D3E0 Offset: 0x69B9E0 VA: 0x18069D3E0
	private IEnumerator WatchForChanges() { }

	// RVA: 0x69C780 Offset: 0x69AD80 VA: 0x18069C780
	private void Rebuild() { }

	// RVA: 0x69CDC0 Offset: 0x69B3C0 VA: 0x18069CDC0
	public bool RecentlyRebuilt() { }

	// RVA: 0x69C2F0 Offset: 0x69A8F0 VA: 0x18069C2F0
	public void ForceRebuild() { }

	// RVA: 0x69D1D0 Offset: 0x69B7D0 VA: 0x18069D1D0
	public void ToggleFavourite(ItemBlueprint bp) { }

	// RVA: 0x69C360 Offset: 0x69A960 VA: 0x18069C360
	public static bool IsBluePrintFavourited(ItemBlueprint bp) { }

	// RVA: 0x69C1A0 Offset: 0x69A7A0 VA: 0x18069C1A0
	public static void AddFavouriteBlueprint(ItemBlueprint bp) { }

	// RVA: 0x69CE90 Offset: 0x69B490 VA: 0x18069CE90
	public static void RemoveFavouriteBlueprint(ItemBlueprint bp) { }

	// RVA: 0x69C300 Offset: 0x69A900 VA: 0x18069C300
	private static string GetSaveString(ItemBlueprint bp) { }

	// RVA: 0x69D090 Offset: 0x69B690 VA: 0x18069D090
	public void SetFavouriteIconState(bool favourited, Image image) { }

	// RVA: 0x69CF60 Offset: 0x69B560 VA: 0x18069CF60
	public void SetFavouriteIconHoveredState(bool favourited, Image image) { }

	// RVA: 0x69D0D0 Offset: 0x69B6D0 VA: 0x18069D0D0
	public void SetFavouriteIconUnhoveredState(bool favourited, Image image) { }

	// RVA: 0x69D4B0 Offset: 0x69BAB0 VA: 0x18069D4B0
	public void .ctor() { }

	// RVA: 0x69D450 Offset: 0x69BA50 VA: 0x18069D450
	private static void .cctor() { }

}

private sealed class QuickCraft.<WatchForChanges>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11046
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public QuickCraft <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6AD470 Offset: 0x6ABA70 VA: 0x1806AD470 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD630 Offset: 0x6ABC30 VA: 0x1806AD630 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

