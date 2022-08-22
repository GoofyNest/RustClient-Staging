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
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	internal void set_Prefab(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	internal GameObject get_ViewModel() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	internal void set_ViewModel(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	internal void set_Skinnable(Skinnable value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal Skin get_Skin() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	internal void set_Skin(Skin value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	internal ulong get_ItemId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xC15300 Offset: 0xC13900 VA: 0x180C15300
	internal void set_ItemId(ulong value) { }

	// RVA: 0xE840E0 Offset: 0xE826E0 VA: 0x180E840E0
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE82800 Offset: 0xE80E00 VA: 0x180E82800
	internal static void Loading(bool v1, string v2, string v3, float v4) { }

	// RVA: 0xE84140 Offset: 0xE82740 VA: 0x180E84140
	internal Publisher get_Publisher() { }

	// RVA: 0xE84090 Offset: 0xE82690 VA: 0x180E84090
	public FileDialog get_FileDialog() { }

	// RVA: 0xE84120 Offset: 0xE82720 VA: 0x180E84120
	public string get_ItemTitle() { }

	// RVA: 0xE841F0 Offset: 0xE827F0 VA: 0x180E841F0
	public void set_ItemTitle(string value) { }

	// RVA: 0xE84030 Offset: 0xE82630 VA: 0x180E84030
	public string get_ChangeLog() { }

	// RVA: 0xE84180 Offset: 0xE82780 VA: 0x180E84180
	public void set_ChangeLog(string value) { }

	// RVA: 0xE82990 Offset: 0xE80F90 VA: 0x180E82990
	private void OnEnable() { }

	// RVA: 0xE817F0 Offset: 0xE7FDF0 VA: 0x180E817F0
	private void ClearEditor() { }

	// RVA: 0xE837B0 Offset: 0xE81DB0 VA: 0x180E837B0
	public void StartNewItem(string type = "TShirt") { }

	[IteratorStateMachineAttribute] // RVA: 0xD2660 Offset: 0xD1A60 VA: 0x1800D2660
	// RVA: 0xE83850 Offset: 0xE81E50 VA: 0x180E83850
	public IEnumerator StartViewingItem(IWorkshopContent item) { }

	[IteratorStateMachineAttribute] // RVA: 0xD2750 Offset: 0xD1B50 VA: 0x1800D2750
	// RVA: 0xE83720 Offset: 0xE81D20 VA: 0x180E83720
	public IEnumerator StartEditingItem(IWorkshopContent item) { }

	// RVA: 0xE81B10 Offset: 0xE80110 VA: 0x180E81B10
	private void HideEditor() { }

	// RVA: 0xE836C0 Offset: 0xE81CC0 VA: 0x180E836C0
	private void ShowEditor() { }

	[IteratorStateMachineAttribute] // RVA: 0xD2980 Offset: 0xD1D80 VA: 0x1800D2980
	// RVA: 0xE82DB0 Offset: 0xE813B0 VA: 0x180E82DB0
	internal IEnumerator OpenItem(IWorkshopContent item) { }

	// RVA: 0xE82C90 Offset: 0xE81290 VA: 0x180E82C90
	private void OnImportFinished() { }

	// RVA: 0xE834E0 Offset: 0xE81AE0 VA: 0x180E834E0
	internal Texture2D SetTexture(string paramName, string fullName, bool isNormalMap) { }

	// RVA: 0xE83010 Offset: 0xE81610 VA: 0x180E83010
	internal void SetFloat(string paramName, float value) { }

	// RVA: 0xE82FB0 Offset: 0xE815B0 VA: 0x180E82FB0
	internal void SetColor(string paramName, Color val) { }

	// RVA: 0xE833B0 Offset: 0xE819B0 VA: 0x180E833B0
	internal void SetTexture(string paramName, Texture tex) { }

	// RVA: 0xE82690 Offset: 0xE80C90 VA: 0x180E82690
	private bool LoadItemType(IEnumerable<string> tags) { }

	// RVA: 0xE823E0 Offset: 0xE809E0 VA: 0x180E823E0
	private bool LoadItemType(string v) { }

	// RVA: 0xE821C0 Offset: 0xE807C0 VA: 0x180E821C0
	private GameObject LoadForPreview(string entityPrefabName, bool preprocess = True) { }

	// RVA: 0xE82880 Offset: 0xE80E80 VA: 0x180E82880
	public void OnChangedItemType(int type) { }

	// RVA: 0xE83920 Offset: 0xE81F20 VA: 0x180E83920
	private void UpdateMaterialRows() { }

	// RVA: 0xE83CD0 Offset: 0xE822D0 VA: 0x180E83CD0
	private void UpdateMaterialTabs() { }

	// RVA: 0xE81CE0 Offset: 0xE802E0 VA: 0x180E81CE0
	private void InitScene() { }

	// RVA: 0xE81B70 Offset: 0xE80170 VA: 0x180E81B70
	private void InitPlayerPreview(ulong playerid, bool focus) { }

	// RVA: 0xE82E40 Offset: 0xE81440 VA: 0x180E82E40
	public void RandomizePlayerPreview() { }

	// RVA: 0xE81AA0 Offset: 0xE800A0 VA: 0x180E81AA0
	public void DownloadModel() { }

	// RVA: 0xE82070 Offset: 0xE80670 VA: 0x180E82070
	public static bool IsLesserLOD(string name) { }

	// RVA: 0xE82E70 Offset: 0xE81470 VA: 0x180E82E70
	public static void RemoveLODs(GameObject prefab) { }

	// RVA: -1 Offset: -1
	private static void RemoveComponents<T>(GameObject prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFF920 Offset: 0xCFDF20 VA: 0x180CFF920
	|-WorkshopItemEditor.RemoveComponents<object>
	|-WorkshopItemEditor.RemoveComponents<Rigidbody>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD3E40 Offset: 0xD3240 VA: 0x1800D3E40
	// RVA: 0xE81A30 Offset: 0xE80030 VA: 0x180E81A30
	private IEnumerator DoDownloadModel() { }

	// RVA: 0xE83F10 Offset: 0xE82510 VA: 0x180E83F10
	private void Update() { }

	// RVA: 0xE82190 Offset: 0xE80790 VA: 0x180E82190
	private void LateUpdate() { }

	// RVA: 0xE838E0 Offset: 0xE81EE0 VA: 0x180E838E0
	public void SwitchMaterial(int i) { }

	// RVA: 0xE83FD0 Offset: 0xE825D0 VA: 0x180E83FD0
	public void .ctor() { }

	// RVA: 0xE83F60 Offset: 0xE82560 VA: 0x180E83F60
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE838F0 Offset: 0xE81EF0 VA: 0x180E838F0
	private bool <LoadItemType>b__61_0(Dropdown.OptionData x) { }

}

private sealed class WorkshopItemEditor.<>c // TypeDefIndex: 7751
{	// Fields
	public static readonly WorkshopItemEditor.<>c <>9; // 0x0
	public static Func<Skinnable, bool> <>9__47_0; // 0x8
	public static Func<Skinnable, string> <>9__47_1; // 0x10
	public static Func<string, string> <>9__47_2; // 0x18

	// Methods

	// RVA: 0xE80B70 Offset: 0xE7F170 VA: 0x180E80B70
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80900 Offset: 0xE7EF00 VA: 0x180E80900
	internal bool <OnEnable>b__47_0(Skinnable x) { }

	// RVA: 0x956EC0 Offset: 0x9554C0 VA: 0x180956EC0
	internal string <OnEnable>b__47_1(Skinnable x) { }

	// RVA: 0x7B4F90 Offset: 0x7B3590 VA: 0x1807B4F90
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

	// RVA: 0xE807A0 Offset: 0xE7EDA0 VA: 0x180E807A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE808B0 Offset: 0xE7EEB0 VA: 0x180E808B0 Slot: 8
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

	// RVA: 0xE80640 Offset: 0xE7EC40 VA: 0x180E80640 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE80750 Offset: 0xE7ED50 VA: 0x180E80750 Slot: 8
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

	// RVA: 0xE7E120 Offset: 0xE7C720 VA: 0x180E7E120 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7E790 Offset: 0xE7CD90 VA: 0x180E7E790 Slot: 8
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

	// RVA: 0xE76F60 Offset: 0xE75560 VA: 0x180E76F60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE77330 Offset: 0xE75930 VA: 0x180E77330 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

