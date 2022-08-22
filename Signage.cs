public class Signage : IOEntity, ILOD, ISignage, IUGCBrowserEntity // TypeDefIndex: 8445
{	// Fields
	private Option __menuOption_Menu_ChangeText; // 0x288
	private Option __menuOption_Menu_LockSign; // 0x2E0
	private Option __menuOption_Menu_UnLockSign; // 0x338
	private const float TextureRequestTimeout = 15;
	public GameObjectRef changeTextDialog; // 0x390
	public MeshPaintableSource[] paintableSources; // 0x398
	public uint[] textureIDs; // 0x3A0
	internal RealTimeSince[] timeSinceRequest; // 0x3A8
	internal uint[] loadedTextures; // 0x3B0
	public ItemDefinition RequiredHeldEntity; // 0x3B8
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float textureRequestDistance; // 0x0
	private bool textureRequestSent; // 0x3C0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <withinTextureRange>k__BackingField; // 0x3C1
	private LODCell cell; // 0x3C8

	// Properties
	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	protected bool withinTextureRange { get; set; }
	public uint NetworkID { get; }
	public FileStorage.Type FileType { get; }

	// Methods

	// RVA: 0x59B0D0 Offset: 0x5996D0 VA: 0x18059B0D0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x59D2D0 Offset: 0x59B8D0 VA: 0x18059D2D0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x59C0B0 Offset: 0x59A6B0 VA: 0x18059C0B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x59D4C0 Offset: 0x59BAC0 VA: 0x18059D4C0 Slot: 163
	public Vector2i get_TextureSize() { }

	// RVA: 0x59D4A0 Offset: 0x59BAA0 VA: 0x18059D4A0 Slot: 164
	public int get_TextureCount() { }

	// RVA: 0x59C8B0 Offset: 0x59AEB0 VA: 0x18059C8B0 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x59AFC0 Offset: 0x5995C0 VA: 0x18059AFC0
	private void FreeTexture() { }

	// RVA: 0x59CEA0 Offset: 0x59B4A0 VA: 0x18059CEA0
	protected void RequestTextureUpdate() { }

	// RVA: 0x59BA30 Offset: 0x59A030 VA: 0x18059BA30
	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Icon] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Description] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	// RVA: 0x59BF10 Offset: 0x59A510 VA: 0x18059BF10
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x59C500 Offset: 0x59AB00 VA: 0x18059C500 Slot: 169
	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59CC00 Offset: 0x59B200 VA: 0x18059CC00
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x59AEE0 Offset: 0x5994E0 VA: 0x18059AEE0
	private void EnsureInitialized() { }

	[ConditionalAttribute] // RVA: 0x83E20 Offset: 0x83220 VA: 0x180083E20
	// RVA: 0x59D1A0 Offset: 0x59B7A0 VA: 0x18059D1A0
	private static void SignDebugLog(string str) { }

	// RVA: 0x59AAB0 Offset: 0x5990B0 VA: 0x18059AAB0 Slot: 170
	public virtual bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x59AA50 Offset: 0x599050 VA: 0x18059AA50
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x59A9F0 Offset: 0x598FF0 VA: 0x18059A9F0
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x59BCD0 Offset: 0x59A2D0 VA: 0x18059BCD0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x59B8F0 Offset: 0x599EF0 VA: 0x18059B8F0
	private bool HeldEntityCheck(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59D580 Offset: 0x59BB80 VA: 0x18059D580
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59D590 Offset: 0x59BB90 VA: 0x18059D590
	private void set_withinTextureRange(bool value) { }

	// RVA: 0x59AC80 Offset: 0x599280 VA: 0x18059AC80 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x59AD10 Offset: 0x599310 VA: 0x18059AD10 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x59CE20 Offset: 0x59B420 VA: 0x18059CE20 Slot: 160
	public void RefreshLOD() { }

	// RVA: 0x59AB80 Offset: 0x599180 VA: 0x18059AB80 Slot: 159
	public void ChangeLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 171
	protected virtual void OnEnterTextureRange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 172
	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Description] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	// RVA: 0x59C030 Offset: 0x59A630 VA: 0x18059C030
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Icon] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Description] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	// RVA: 0x59C070 Offset: 0x59A670 VA: 0x18059C070
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x59C990 Offset: 0x59AF90 VA: 0x18059C990
	public static void RebuildAll() { }

	// RVA: 0x59B8E0 Offset: 0x599EE0 VA: 0x18059B8E0 Slot: 165
	public uint[] GetTextureCRCs() { }

	// RVA: 0x52EEF0 Offset: 0x52D4F0 VA: 0x18052EEF0 Slot: 166
	public uint get_NetworkID() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 167
	public FileStorage.Type get_FileType() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x59AB50 Offset: 0x599150 VA: 0x18059AB50 Slot: 122
	public override string Categorize() { }

	// RVA: 0x59D270 Offset: 0x59B870 VA: 0x18059D270
	public void .ctor() { }

	// RVA: 0x59D230 Offset: 0x59B830 VA: 0x18059D230
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59D200 Offset: 0x59B800 VA: 0x18059D200
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x) { }

}

