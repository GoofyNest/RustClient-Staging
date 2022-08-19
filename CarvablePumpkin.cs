public class CarvablePumpkin : BaseOven, ILOD, ISignage, IUGCBrowserEntity // TypeDefIndex: 8371
{	// Fields
	private Option __menuOption_Menu_ChangeText; // 0x4E8
	private Option __menuOption_Menu_LockSign; // 0x540
	private Option __menuOption_Menu_UnLockSign; // 0x598
	private const float TextureRequestTimeout = 15;
	public GameObjectRef changeTextDialog; // 0x5F0
	public MeshPaintableSource[] paintableSources; // 0x5F8
	public uint[] textureIDs; // 0x600
	internal RealTimeSince[] timeSinceRequest; // 0x608
	internal uint[] loadedTextures; // 0x610
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static float textureRequestDistance; // 0x0
	private bool textureRequestSent; // 0x618
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private bool <withinTextureRange>k__BackingField; // 0x619
	private LODCell cell; // 0x620

	// Properties
	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	public FileStorage.Type FileType { get; }
	public uint NetworkID { get; }
	protected bool withinTextureRange { get; set; }

	// Methods

	// RVA: 0x52CD80 Offset: 0x52B380 VA: 0x18052CD80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x52ED20 Offset: 0x52D320 VA: 0x18052ED20 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x52DBF0 Offset: 0x52C1F0 VA: 0x18052DBF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x52EF30 Offset: 0x52D530 VA: 0x18052EF30 Slot: 161
	public Vector2i get_TextureSize() { }

	// RVA: 0x52EF10 Offset: 0x52D510 VA: 0x18052EF10 Slot: 162
	public int get_TextureCount() { }

	// RVA: 0x52E3F0 Offset: 0x52C9F0 VA: 0x18052E3F0 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x52CC70 Offset: 0x52B270 VA: 0x18052CC70
	private void FreeTexture() { }

	// RVA: 0x52E930 Offset: 0x52CF30 VA: 0x18052E930
	protected void RequestTextureUpdate() { }

	// RVA: 0x52D570 Offset: 0x52BB70 VA: 0x18052D570
	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu] // RVA: 0xD1890 Offset: 0xD0C90 VA: 0x1800D1890
	[BaseEntity.Menu.Icon] // RVA: 0xD1890 Offset: 0xD0C90 VA: 0x1800D1890
	[BaseEntity.Menu.Description] // RVA: 0xD1890 Offset: 0xD0C90 VA: 0x1800D1890
	[BaseEntity.Menu.ShowIf] // RVA: 0xD1890 Offset: 0xD0C90 VA: 0x1800D1890
	// RVA: 0x52DA50 Offset: 0x52C050 VA: 0x18052DA50
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x52E040 Offset: 0x52C640 VA: 0x18052E040 Slot: 167
	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x52E690 Offset: 0x52CC90 VA: 0x18052E690
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x52CB90 Offset: 0x52B190 VA: 0x18052CB90
	private void EnsureInitialized() { }

	[ConditionalAttribute] // RVA: 0x83DB0 Offset: 0x831B0 VA: 0x180083DB0
	// RVA: 0x52EC30 Offset: 0x52D230 VA: 0x18052EC30
	private static void SignDebugLog(string str) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 165
	public FileStorage.Type get_FileType() { }

	// RVA: 0x52D560 Offset: 0x52BB60 VA: 0x18052D560 Slot: 163
	public uint[] GetTextureCRCs() { }

	// RVA: 0x52EEF0 Offset: 0x52D4F0 VA: 0x18052EEF0 Slot: 164
	public uint get_NetworkID() { }

	// RVA: 0x52C770 Offset: 0x52AD70 VA: 0x18052C770 Slot: 168
	public virtual bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x52C720 Offset: 0x52AD20 VA: 0x18052C720
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x52C6D0 Offset: 0x52ACD0 VA: 0x18052C6D0
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x52D810 Offset: 0x52BE10 VA: 0x18052D810 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x52EFF0 Offset: 0x52D5F0 VA: 0x18052EFF0
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x52F000 Offset: 0x52D600 VA: 0x18052F000
	private void set_withinTextureRange(bool value) { }

	// RVA: 0x52C930 Offset: 0x52AF30 VA: 0x18052C930 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x52C9C0 Offset: 0x52AFC0 VA: 0x18052C9C0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x52E8B0 Offset: 0x52CEB0 VA: 0x18052E8B0 Slot: 158
	public void RefreshLOD() { }

	// RVA: 0x52C830 Offset: 0x52AE30 VA: 0x18052C830 Slot: 157
	public void ChangeLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 169
	protected virtual void OnEnterTextureRange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 170
	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu] // RVA: 0x7C470 Offset: 0x7B870 VA: 0x18007C470
	[BaseEntity.Menu.Icon] // RVA: 0x7C470 Offset: 0x7B870 VA: 0x18007C470
	[BaseEntity.Menu.Description] // RVA: 0x7C470 Offset: 0x7B870 VA: 0x18007C470
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C470 Offset: 0x7B870 VA: 0x18007C470
	// RVA: 0x52DB70 Offset: 0x52C170 VA: 0x18052DB70
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C700 Offset: 0x7BB00 VA: 0x18007C700
	[BaseEntity.Menu.Icon] // RVA: 0x7C700 Offset: 0x7BB00 VA: 0x18007C700
	[BaseEntity.Menu.Description] // RVA: 0x7C700 Offset: 0x7BB00 VA: 0x18007C700
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C700 Offset: 0x7BB00 VA: 0x18007C700
	// RVA: 0x52DBB0 Offset: 0x52C1B0 VA: 0x18052DBB0
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x52E4D0 Offset: 0x52CAD0 VA: 0x18052E4D0
	public static void RebuildAll() { }

	// RVA: 0x52C800 Offset: 0x52AE00 VA: 0x18052C800 Slot: 122
	public override string Categorize() { }

	// RVA: 0x52ED00 Offset: 0x52D300 VA: 0x18052ED00
	public void .ctor() { }

	// RVA: 0x52ECC0 Offset: 0x52D2C0 VA: 0x18052ECC0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x52EC90 Offset: 0x52D290 VA: 0x18052EC90
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x) { }

}

