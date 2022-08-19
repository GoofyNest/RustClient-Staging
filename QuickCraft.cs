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

	// RVA: 0x69C190 Offset: 0x69A790 VA: 0x18069C190 Slot: 6
	protected override void Awake() { }

	// RVA: 0x69C2D0 Offset: 0x69A8D0 VA: 0x18069C2D0
	private void LoadFavourites() { }

	// RVA: 0x69C590 Offset: 0x69AB90 VA: 0x18069C590
	private void OnEnable() { }

	// RVA: 0x69C4E0 Offset: 0x69AAE0 VA: 0x18069C4E0
	private void OnDisable() { }

	// RVA: 0x69C1D0 Offset: 0x69A7D0 VA: 0x18069C1D0 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x69C1D0 Offset: 0x69A7D0 VA: 0x18069C1D0
	private void Dirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x90BD0 Offset: 0x8FFD0 VA: 0x180090BD0
	// RVA: 0x69D2D0 Offset: 0x69B8D0 VA: 0x18069D2D0
	private IEnumerator WatchForChanges() { }

	// RVA: 0x69C670 Offset: 0x69AC70 VA: 0x18069C670
	private void Rebuild() { }

	// RVA: 0x69CCB0 Offset: 0x69B2B0 VA: 0x18069CCB0
	public bool RecentlyRebuilt() { }

	// RVA: 0x69C1E0 Offset: 0x69A7E0 VA: 0x18069C1E0
	public void ForceRebuild() { }

	// RVA: 0x69D0C0 Offset: 0x69B6C0 VA: 0x18069D0C0
	public void ToggleFavourite(ItemBlueprint bp) { }

	// RVA: 0x69C250 Offset: 0x69A850 VA: 0x18069C250
	public static bool IsBluePrintFavourited(ItemBlueprint bp) { }

	// RVA: 0x69C090 Offset: 0x69A690 VA: 0x18069C090
	public static void AddFavouriteBlueprint(ItemBlueprint bp) { }

	// RVA: 0x69CD80 Offset: 0x69B380 VA: 0x18069CD80
	public static void RemoveFavouriteBlueprint(ItemBlueprint bp) { }

	// RVA: 0x69C1F0 Offset: 0x69A7F0 VA: 0x18069C1F0
	private static string GetSaveString(ItemBlueprint bp) { }

	// RVA: 0x69CF80 Offset: 0x69B580 VA: 0x18069CF80
	public void SetFavouriteIconState(bool favourited, Image image) { }

	// RVA: 0x69CE50 Offset: 0x69B450 VA: 0x18069CE50
	public void SetFavouriteIconHoveredState(bool favourited, Image image) { }

	// RVA: 0x69CFC0 Offset: 0x69B5C0 VA: 0x18069CFC0
	public void SetFavouriteIconUnhoveredState(bool favourited, Image image) { }

	// RVA: 0x69D3A0 Offset: 0x69B9A0 VA: 0x18069D3A0
	public void .ctor() { }

	// RVA: 0x69D340 Offset: 0x69B940 VA: 0x18069D340
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

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x6AD360 Offset: 0x6AB960 VA: 0x1806AD360 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x6AD520 Offset: 0x6ABB20 VA: 0x1806AD520 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

