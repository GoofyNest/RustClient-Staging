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

	// RVA: 0x69C230 Offset: 0x69A830 VA: 0x18069C230 Slot: 6
	protected override void Awake() { }

	// RVA: 0x69C370 Offset: 0x69A970 VA: 0x18069C370
	private void LoadFavourites() { }

	// RVA: 0x69C630 Offset: 0x69AC30 VA: 0x18069C630
	private void OnEnable() { }

	// RVA: 0x69C580 Offset: 0x69AB80 VA: 0x18069C580
	private void OnDisable() { }

	// RVA: 0x69C270 Offset: 0x69A870 VA: 0x18069C270 Slot: 8
	public void OnInventoryChanged() { }

	// RVA: 0x69C270 Offset: 0x69A870 VA: 0x18069C270
	private void Dirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x90D90 Offset: 0x90190 VA: 0x180090D90
	// RVA: 0x69D370 Offset: 0x69B970 VA: 0x18069D370
	private IEnumerator WatchForChanges() { }

	// RVA: 0x69C710 Offset: 0x69AD10 VA: 0x18069C710
	private void Rebuild() { }

	// RVA: 0x69CD50 Offset: 0x69B350 VA: 0x18069CD50
	public bool RecentlyRebuilt() { }

	// RVA: 0x69C280 Offset: 0x69A880 VA: 0x18069C280
	public void ForceRebuild() { }

	// RVA: 0x69D160 Offset: 0x69B760 VA: 0x18069D160
	public void ToggleFavourite(ItemBlueprint bp) { }

	// RVA: 0x69C2F0 Offset: 0x69A8F0 VA: 0x18069C2F0
	public static bool IsBluePrintFavourited(ItemBlueprint bp) { }

	// RVA: 0x69C130 Offset: 0x69A730 VA: 0x18069C130
	public static void AddFavouriteBlueprint(ItemBlueprint bp) { }

	// RVA: 0x69CE20 Offset: 0x69B420 VA: 0x18069CE20
	public static void RemoveFavouriteBlueprint(ItemBlueprint bp) { }

	// RVA: 0x69C290 Offset: 0x69A890 VA: 0x18069C290
	private static string GetSaveString(ItemBlueprint bp) { }

	// RVA: 0x69D020 Offset: 0x69B620 VA: 0x18069D020
	public void SetFavouriteIconState(bool favourited, Image image) { }

	// RVA: 0x69CEF0 Offset: 0x69B4F0 VA: 0x18069CEF0
	public void SetFavouriteIconHoveredState(bool favourited, Image image) { }

	// RVA: 0x69D060 Offset: 0x69B660 VA: 0x18069D060
	public void SetFavouriteIconUnhoveredState(bool favourited, Image image) { }

	// RVA: 0x69D440 Offset: 0x69BA40 VA: 0x18069D440
	public void .ctor() { }

	// RVA: 0x69D3E0 Offset: 0x69B9E0 VA: 0x18069D3E0
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

	// RVA: 0x6AD400 Offset: 0x6ABA00 VA: 0x1806AD400 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x6AD5C0 Offset: 0x6ABBC0 VA: 0x1806AD5C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

