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

	// RVA: 0x59B060 Offset: 0x599660 VA: 0x18059B060 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x59D260 Offset: 0x59B860 VA: 0x18059D260 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x59C040 Offset: 0x59A640 VA: 0x18059C040 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x59D450 Offset: 0x59BA50 VA: 0x18059D450 Slot: 163
	public Vector2i get_TextureSize() { }

	// RVA: 0x59D430 Offset: 0x59BA30 VA: 0x18059D430 Slot: 164
	public int get_TextureCount() { }

	// RVA: 0x59C840 Offset: 0x59AE40 VA: 0x18059C840 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x59AF50 Offset: 0x599550 VA: 0x18059AF50
	private void FreeTexture() { }

	// RVA: 0x59CE30 Offset: 0x59B430 VA: 0x18059CE30
	protected void RequestTextureUpdate() { }

	// RVA: 0x59B9C0 Offset: 0x599FC0 VA: 0x18059B9C0
	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Icon] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Description] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	// RVA: 0x59BEA0 Offset: 0x59A4A0 VA: 0x18059BEA0
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x59C490 Offset: 0x59AA90 VA: 0x18059C490 Slot: 169
	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59CB90 Offset: 0x59B190 VA: 0x18059CB90
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x59AE70 Offset: 0x599470 VA: 0x18059AE70
	private void EnsureInitialized() { }

	[ConditionalAttribute] // RVA: 0x83E20 Offset: 0x83220 VA: 0x180083E20
	// RVA: 0x59D130 Offset: 0x59B730 VA: 0x18059D130
	private static void SignDebugLog(string str) { }

	// RVA: 0x59AA40 Offset: 0x599040 VA: 0x18059AA40 Slot: 170
	public virtual bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x59A9E0 Offset: 0x598FE0 VA: 0x18059A9E0
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x59A980 Offset: 0x598F80 VA: 0x18059A980
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x59BC60 Offset: 0x59A260 VA: 0x18059BC60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x59B880 Offset: 0x599E80 VA: 0x18059B880
	private bool HeldEntityCheck(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59D510 Offset: 0x59BB10 VA: 0x18059D510
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59D520 Offset: 0x59BB20 VA: 0x18059D520
	private void set_withinTextureRange(bool value) { }

	// RVA: 0x59AC10 Offset: 0x599210 VA: 0x18059AC10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x59ACA0 Offset: 0x5992A0 VA: 0x18059ACA0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x59CDB0 Offset: 0x59B3B0 VA: 0x18059CDB0 Slot: 160
	public void RefreshLOD() { }

	// RVA: 0x59AB10 Offset: 0x599110 VA: 0x18059AB10 Slot: 159
	public void ChangeLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 171
	protected virtual void OnEnterTextureRange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 172
	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Description] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	// RVA: 0x59BFC0 Offset: 0x59A5C0 VA: 0x18059BFC0
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Icon] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Description] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	// RVA: 0x59C000 Offset: 0x59A600 VA: 0x18059C000
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x59C920 Offset: 0x59AF20 VA: 0x18059C920
	public static void RebuildAll() { }

	// RVA: 0x59B870 Offset: 0x599E70 VA: 0x18059B870 Slot: 165
	public uint[] GetTextureCRCs() { }

	// RVA: 0x52EE80 Offset: 0x52D480 VA: 0x18052EE80 Slot: 166
	public uint get_NetworkID() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 167
	public FileStorage.Type get_FileType() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 150
	public override int ConsumptionAmount() { }

	// RVA: 0x59AAE0 Offset: 0x5990E0 VA: 0x18059AAE0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x59D200 Offset: 0x59B800 VA: 0x18059D200
	public void .ctor() { }

	// RVA: 0x59D1C0 Offset: 0x59B7C0 VA: 0x18059D1C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x59D190 Offset: 0x59B790 VA: 0x18059D190
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x) { }

}

