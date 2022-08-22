public class QuickCraft : SingletonComponent<QuickCraft>, IInventoryChanged // TypeDefIndex: 11045
{	public GameObjectRef craftButton; // 0x18
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


	protected override void Awake() { }

	private void LoadFavourites() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void OnInventoryChanged() { }

	private void Dirty() { }

	[IteratorStateMachineAttribute] // RVA: 0x90D90 Offset: 0x90190 VA: 0x180090D90
	private IEnumerator WatchForChanges() { }

	private void Rebuild() { }

	public bool RecentlyRebuilt() { }

	public void ForceRebuild() { }

	public void ToggleFavourite(ItemBlueprint bp) { }

	public static bool IsBluePrintFavourited(ItemBlueprint bp) { }

	public static void AddFavouriteBlueprint(ItemBlueprint bp) { }

	public static void RemoveFavouriteBlueprint(ItemBlueprint bp) { }

	private static string GetSaveString(ItemBlueprint bp) { }

	public void SetFavouriteIconState(bool favourited, Image image) { }

	public void SetFavouriteIconHoveredState(bool favourited, Image image) { }

	public void SetFavouriteIconUnhoveredState(bool favourited, Image image) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class QuickCraft.<WatchForChanges>d__16 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11046
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public QuickCraft <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private object System.Collections.IEnumerator.get_Current() { }

}

