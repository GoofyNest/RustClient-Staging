public class WorkshopItemEditor : SingletonComponent<WorkshopItemEditor> // TypeDefIndex: 7750
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject <Prefab>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private GameObject <ViewModel>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Skinnable <Skinnable>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Skin <Skin>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ulong <ItemId>k__BackingField; // 0x38
	public static Action<bool, string> OnLoading; // 0x0
	public Dropdown ItemTypeSelector; // 0x40
	public InputField ItemTitleLabel; // 0x48
	public WorkshopViewmodelControls ViewmodelControls; // 0x50
	public GameObject MaterialTabHolder; // 0x58
	public GameObject FileDialogObject; // 0x60
	public GameObject[] EditorElements; // 0x68
	public GameObject[] ClothOnlyElements; // 0x70
	public GameObject[] DetailOnlyElements; // 0x78
	public GameObject[] DirtOnlyElements; // 0x80
	public Toggle[] MaterialTabs; // 0x88
	public int EditingMaterial; // 0x90
	public GameObject item_position_a; // 0x98
	public GameObject item_position_b; // 0xA0
	private static readonly Regex ModelCleanup; // 0x8

	// Properties
	internal GameObject Prefab { get; set; }
	internal GameObject ViewModel { get; set; }
	internal Skinnable Skinnable { get; set; }
	internal Skin Skin { get; set; }
	internal ulong ItemId { get; set; }
	protected WorkshopInterface Interface { get; }
	internal Publisher Publisher { get; }
	public FileDialog FileDialog { get; }
	public string ItemTitle { get; set; }
	public string ChangeLog { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal GameObject get_Prefab() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	internal void set_Prefab(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal GameObject get_ViewModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_ViewModel(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	internal void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal Skin get_Skin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	internal void set_Skin(Skin value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C3340 Offset: 0x5C1940 VA: 0x1805C3340
	internal ulong get_ItemId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC157D0 Offset: 0xC13DD0 VA: 0x180C157D0
	internal void set_ItemId(ulong value) { }

	// RVA: 0xE84B90 Offset: 0xE83190 VA: 0x180E84B90
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE832B0 Offset: 0xE818B0 VA: 0x180E832B0
	internal static void Loading(bool v1, string v2, string v3, float v4) { }

	// RVA: 0xE84BF0 Offset: 0xE831F0 VA: 0x180E84BF0
	internal Publisher get_Publisher() { }

	// RVA: 0xE84B40 Offset: 0xE83140 VA: 0x180E84B40
	public FileDialog get_FileDialog() { }

	// RVA: 0xE84BD0 Offset: 0xE831D0 VA: 0x180E84BD0
	public string get_ItemTitle() { }

	// RVA: 0xE84CA0 Offset: 0xE832A0 VA: 0x180E84CA0
	public void set_ItemTitle(string value) { }

	// RVA: 0xE84AE0 Offset: 0xE830E0 VA: 0x180E84AE0
	public string get_ChangeLog() { }

	// RVA: 0xE84C30 Offset: 0xE83230 VA: 0x180E84C30
	public void set_ChangeLog(string value) { }

	// RVA: 0xE83440 Offset: 0xE81A40 VA: 0x180E83440
	private void OnEnable() { }

	// RVA: 0xE822A0 Offset: 0xE808A0 VA: 0x180E822A0
	private void ClearEditor() { }

	// RVA: 0xE84260 Offset: 0xE82860 VA: 0x180E84260
	public void StartNewItem(string type = "TShirt") { }

	[IteratorStateMachineAttribute] // RVA: 0xD2660 Offset: 0xD1A60 VA: 0x1800D2660
	// RVA: 0xE84300 Offset: 0xE82900 VA: 0x180E84300
	public IEnumerator StartViewingItem(IWorkshopContent item) { }

	[IteratorStateMachineAttribute] // RVA: 0xD2750 Offset: 0xD1B50 VA: 0x1800D2750
	// RVA: 0xE841D0 Offset: 0xE827D0 VA: 0x180E841D0
	public IEnumerator StartEditingItem(IWorkshopContent item) { }

	// RVA: 0xE825C0 Offset: 0xE80BC0 VA: 0x180E825C0
	private void HideEditor() { }

	// RVA: 0xE84170 Offset: 0xE82770 VA: 0x180E84170
	private void ShowEditor() { }

	[IteratorStateMachineAttribute] // RVA: 0xD2980 Offset: 0xD1D80 VA: 0x1800D2980
	// RVA: 0xE83860 Offset: 0xE81E60 VA: 0x180E83860
	internal IEnumerator OpenItem(IWorkshopContent item) { }

	// RVA: 0xE83740 Offset: 0xE81D40 VA: 0x180E83740
	private void OnImportFinished() { }

	// RVA: 0xE83F90 Offset: 0xE82590 VA: 0x180E83F90
	internal Texture2D SetTexture(string paramName, string fullName, bool isNormalMap) { }

	// RVA: 0xE83AC0 Offset: 0xE820C0 VA: 0x180E83AC0
	internal void SetFloat(string paramName, float value) { }

	// RVA: 0xE83A60 Offset: 0xE82060 VA: 0x180E83A60
	internal void SetColor(string paramName, Color val) { }

	// RVA: 0xE83E60 Offset: 0xE82460 VA: 0x180E83E60
	internal void SetTexture(string paramName, Texture tex) { }

	// RVA: 0xE83140 Offset: 0xE81740 VA: 0x180E83140
	private bool LoadItemType(IEnumerable<string> tags) { }

	// RVA: 0xE82E90 Offset: 0xE81490 VA: 0x180E82E90
	private bool LoadItemType(string v) { }

	// RVA: 0xE82C70 Offset: 0xE81270 VA: 0x180E82C70
	private GameObject LoadForPreview(string entityPrefabName, bool preprocess = True) { }

	// RVA: 0xE83330 Offset: 0xE81930 VA: 0x180E83330
	public void OnChangedItemType(int type) { }

	// RVA: 0xE843D0 Offset: 0xE829D0 VA: 0x180E843D0
	private void UpdateMaterialRows() { }

	// RVA: 0xE84780 Offset: 0xE82D80 VA: 0x180E84780
	private void UpdateMaterialTabs() { }

	// RVA: 0xE82790 Offset: 0xE80D90 VA: 0x180E82790
	private void InitScene() { }

	// RVA: 0xE82620 Offset: 0xE80C20 VA: 0x180E82620
	private void InitPlayerPreview(ulong playerid, bool focus) { }

	// RVA: 0xE838F0 Offset: 0xE81EF0 VA: 0x180E838F0
	public void RandomizePlayerPreview() { }

	// RVA: 0xE82550 Offset: 0xE80B50 VA: 0x180E82550
	public void DownloadModel() { }

	// RVA: 0xE82B20 Offset: 0xE81120 VA: 0x180E82B20
	public static bool IsLesserLOD(string name) { }

	// RVA: 0xE83920 Offset: 0xE81F20 VA: 0x180E83920
	public static void RemoveLODs(GameObject prefab) { }

	// RVA: -1 Offset: -1
	private static void RemoveComponents<T>(GameObject prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFFDC0 Offset: 0xCFE3C0 VA: 0x180CFFDC0
	|-WorkshopItemEditor.RemoveComponents<object>
	|-WorkshopItemEditor.RemoveComponents<Rigidbody>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD3E40 Offset: 0xD3240 VA: 0x1800D3E40
	// RVA: 0xE824E0 Offset: 0xE80AE0 VA: 0x180E824E0
	private IEnumerator DoDownloadModel() { }

	// RVA: 0xE849C0 Offset: 0xE82FC0 VA: 0x180E849C0
	private void Update() { }

	// RVA: 0xE82C40 Offset: 0xE81240 VA: 0x180E82C40
	private void LateUpdate() { }

	// RVA: 0xE84390 Offset: 0xE82990 VA: 0x180E84390
	public void SwitchMaterial(int i) { }

	// RVA: 0xE84A80 Offset: 0xE83080 VA: 0x180E84A80
	public void .ctor() { }

	// RVA: 0xE84A10 Offset: 0xE83010 VA: 0x180E84A10
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE843A0 Offset: 0xE829A0 VA: 0x180E843A0
	private bool <LoadItemType>b__61_0(Dropdown.OptionData x) { }

}

private sealed class WorkshopItemEditor.<>c // TypeDefIndex: 7751
{	// Fields
	public static readonly WorkshopItemEditor.<>c <>9; // 0x0
	public static Func<Skinnable, bool> <>9__47_0; // 0x8
	public static Func<Skinnable, string> <>9__47_1; // 0x10
	public static Func<string, string> <>9__47_2; // 0x18

	// Methods

	// RVA: 0xE81620 Offset: 0xE7FC20 VA: 0x180E81620
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE813B0 Offset: 0xE7F9B0 VA: 0x180E813B0
	internal bool <OnEnable>b__47_0(Skinnable x) { }

	// RVA: 0x9573C0 Offset: 0x9559C0 VA: 0x1809573C0
	internal string <OnEnable>b__47_1(Skinnable x) { }

	// RVA: 0x7D3380 Offset: 0x7D1980 VA: 0x1807D3380
	internal string <OnEnable>b__47_2(string x) { }

}

private sealed class WorkshopItemEditor.<StartViewingItem>d__50 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7752
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28

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

	// RVA: 0xE81250 Offset: 0xE7F850 VA: 0x180E81250 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE81360 Offset: 0xE7F960 VA: 0x180E81360 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<StartEditingItem>d__51 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7753
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28

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

	// RVA: 0xE810F0 Offset: 0xE7F6F0 VA: 0x180E810F0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE81200 Offset: 0xE7F800 VA: 0x180E81200 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<OpenItem>d__54 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7754
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20
	public IWorkshopContent item; // 0x28
	private Task<IPlayerInfo> <t>5__2; // 0x30

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

	// RVA: 0xE7EBD0 Offset: 0xE7D1D0 VA: 0x180E7EBD0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7F240 Offset: 0xE7D840 VA: 0x180E7F240 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopItemEditor.<DoDownloadModel>d__74 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7755
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public WorkshopItemEditor <>4__this; // 0x20

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

	// RVA: 0xE77A10 Offset: 0xE76010 VA: 0x180E77A10 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE77DE0 Offset: 0xE763E0 VA: 0x180E77DE0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

