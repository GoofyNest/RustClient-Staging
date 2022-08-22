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
	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal Skinnable get_Skinnable() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
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
	// RVA: 0xC15040 Offset: 0xC13640 VA: 0x180C15040
	internal void set_ItemId(ulong value) { }

	// RVA: 0xE83E20 Offset: 0xE82420 VA: 0x180E83E20
	protected WorkshopInterface get_Interface() { }

	// RVA: 0xE82540 Offset: 0xE80B40 VA: 0x180E82540
	internal static void Loading(bool v1, string v2, string v3, float v4) { }

	// RVA: 0xE83E80 Offset: 0xE82480 VA: 0x180E83E80
	internal Publisher get_Publisher() { }

	// RVA: 0xE83DD0 Offset: 0xE823D0 VA: 0x180E83DD0
	public FileDialog get_FileDialog() { }

	// RVA: 0xE83E60 Offset: 0xE82460 VA: 0x180E83E60
	public string get_ItemTitle() { }

	// RVA: 0xE83F30 Offset: 0xE82530 VA: 0x180E83F30
	public void set_ItemTitle(string value) { }

	// RVA: 0xE83D70 Offset: 0xE82370 VA: 0x180E83D70
	public string get_ChangeLog() { }

	// RVA: 0xE83EC0 Offset: 0xE824C0 VA: 0x180E83EC0
	public void set_ChangeLog(string value) { }

	// RVA: 0xE826D0 Offset: 0xE80CD0 VA: 0x180E826D0
	private void OnEnable() { }

	// RVA: 0xE81530 Offset: 0xE7FB30 VA: 0x180E81530
	private void ClearEditor() { }

	// RVA: 0xE834F0 Offset: 0xE81AF0 VA: 0x180E834F0
	public void StartNewItem(string type = "TShirt") { }

	[IteratorStateMachineAttribute] // RVA: 0xD2660 Offset: 0xD1A60 VA: 0x1800D2660
	// RVA: 0xE83590 Offset: 0xE81B90 VA: 0x180E83590
	public IEnumerator StartViewingItem(IWorkshopContent item) { }

	[IteratorStateMachineAttribute] // RVA: 0xD2750 Offset: 0xD1B50 VA: 0x1800D2750
	// RVA: 0xE83460 Offset: 0xE81A60 VA: 0x180E83460
	public IEnumerator StartEditingItem(IWorkshopContent item) { }

	// RVA: 0xE81850 Offset: 0xE7FE50 VA: 0x180E81850
	private void HideEditor() { }

	// RVA: 0xE83400 Offset: 0xE81A00 VA: 0x180E83400
	private void ShowEditor() { }

	[IteratorStateMachineAttribute] // RVA: 0xD2980 Offset: 0xD1D80 VA: 0x1800D2980
	// RVA: 0xE82AF0 Offset: 0xE810F0 VA: 0x180E82AF0
	internal IEnumerator OpenItem(IWorkshopContent item) { }

	// RVA: 0xE829D0 Offset: 0xE80FD0 VA: 0x180E829D0
	private void OnImportFinished() { }

	// RVA: 0xE83220 Offset: 0xE81820 VA: 0x180E83220
	internal Texture2D SetTexture(string paramName, string fullName, bool isNormalMap) { }

	// RVA: 0xE82D50 Offset: 0xE81350 VA: 0x180E82D50
	internal void SetFloat(string paramName, float value) { }

	// RVA: 0xE82CF0 Offset: 0xE812F0 VA: 0x180E82CF0
	internal void SetColor(string paramName, Color val) { }

	// RVA: 0xE830F0 Offset: 0xE816F0 VA: 0x180E830F0
	internal void SetTexture(string paramName, Texture tex) { }

	// RVA: 0xE823D0 Offset: 0xE809D0 VA: 0x180E823D0
	private bool LoadItemType(IEnumerable<string> tags) { }

	// RVA: 0xE82120 Offset: 0xE80720 VA: 0x180E82120
	private bool LoadItemType(string v) { }

	// RVA: 0xE81F00 Offset: 0xE80500 VA: 0x180E81F00
	private GameObject LoadForPreview(string entityPrefabName, bool preprocess = True) { }

	// RVA: 0xE825C0 Offset: 0xE80BC0 VA: 0x180E825C0
	public void OnChangedItemType(int type) { }

	// RVA: 0xE83660 Offset: 0xE81C60 VA: 0x180E83660
	private void UpdateMaterialRows() { }

	// RVA: 0xE83A10 Offset: 0xE82010 VA: 0x180E83A10
	private void UpdateMaterialTabs() { }

	// RVA: 0xE81A20 Offset: 0xE80020 VA: 0x180E81A20
	private void InitScene() { }

	// RVA: 0xE818B0 Offset: 0xE7FEB0 VA: 0x180E818B0
	private void InitPlayerPreview(ulong playerid, bool focus) { }

	// RVA: 0xE82B80 Offset: 0xE81180 VA: 0x180E82B80
	public void RandomizePlayerPreview() { }

	// RVA: 0xE817E0 Offset: 0xE7FDE0 VA: 0x180E817E0
	public void DownloadModel() { }

	// RVA: 0xE81DB0 Offset: 0xE803B0 VA: 0x180E81DB0
	public static bool IsLesserLOD(string name) { }

	// RVA: 0xE82BB0 Offset: 0xE811B0 VA: 0x180E82BB0
	public static void RemoveLODs(GameObject prefab) { }

	// RVA: -1 Offset: -1
	private static void RemoveComponents<T>(GameObject prefab) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCFF660 Offset: 0xCFDC60 VA: 0x180CFF660
	|-WorkshopItemEditor.RemoveComponents<object>
	|-WorkshopItemEditor.RemoveComponents<Rigidbody>
	*/

	[IteratorStateMachineAttribute] // RVA: 0xD3E40 Offset: 0xD3240 VA: 0x1800D3E40
	// RVA: 0xE81770 Offset: 0xE7FD70 VA: 0x180E81770
	private IEnumerator DoDownloadModel() { }

	// RVA: 0xE83C50 Offset: 0xE82250 VA: 0x180E83C50
	private void Update() { }

	// RVA: 0xE81ED0 Offset: 0xE804D0 VA: 0x180E81ED0
	private void LateUpdate() { }

	// RVA: 0xE83620 Offset: 0xE81C20 VA: 0x180E83620
	public void SwitchMaterial(int i) { }

	// RVA: 0xE83D10 Offset: 0xE82310 VA: 0x180E83D10
	public void .ctor() { }

	// RVA: 0xE83CA0 Offset: 0xE822A0 VA: 0x180E83CA0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE83630 Offset: 0xE81C30 VA: 0x180E83630
	private bool <LoadItemType>b__61_0(Dropdown.OptionData x) { }

}

private sealed class WorkshopItemEditor.<>c // TypeDefIndex: 7751
{	// Fields
	public static readonly WorkshopItemEditor.<>c <>9; // 0x0
	public static Func<Skinnable, bool> <>9__47_0; // 0x8
	public static Func<Skinnable, string> <>9__47_1; // 0x10
	public static Func<string, string> <>9__47_2; // 0x18

	// Methods

	// RVA: 0xE808B0 Offset: 0xE7EEB0 VA: 0x180E808B0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xE80640 Offset: 0xE7EC40 VA: 0x180E80640
	internal bool <OnEnable>b__47_0(Skinnable x) { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0
	internal string <OnEnable>b__47_1(Skinnable x) { }

	// RVA: 0x7B4E80 Offset: 0x7B3480 VA: 0x1807B4E80
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

	// RVA: 0xE804E0 Offset: 0xE7EAE0 VA: 0x180E804E0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE805F0 Offset: 0xE7EBF0 VA: 0x180E805F0 Slot: 8
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

	// RVA: 0xE80380 Offset: 0xE7E980 VA: 0x180E80380 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE80490 Offset: 0xE7EA90 VA: 0x180E80490 Slot: 8
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

	// RVA: 0xE7DE60 Offset: 0xE7C460 VA: 0x180E7DE60 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE7E4D0 Offset: 0xE7CAD0 VA: 0x180E7E4D0 Slot: 8
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

	// RVA: 0xE76CA0 Offset: 0xE752A0 VA: 0x180E76CA0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xE77070 Offset: 0xE75670 VA: 0x180E77070 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

