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
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float textureRequestDistance; // 0x0
	private bool textureRequestSent; // 0x618
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x52CD10 Offset: 0x52B310 VA: 0x18052CD10 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x52ECB0 Offset: 0x52D2B0 VA: 0x18052ECB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x52DB80 Offset: 0x52C180 VA: 0x18052DB80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x52EEC0 Offset: 0x52D4C0 VA: 0x18052EEC0 Slot: 161
	public Vector2i get_TextureSize() { }

	// RVA: 0x52EEA0 Offset: 0x52D4A0 VA: 0x18052EEA0 Slot: 162
	public int get_TextureCount() { }

	// RVA: 0x52E380 Offset: 0x52C980 VA: 0x18052E380 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x52CC00 Offset: 0x52B200 VA: 0x18052CC00
	private void FreeTexture() { }

	// RVA: 0x52E8C0 Offset: 0x52CEC0 VA: 0x18052E8C0
	protected void RequestTextureUpdate() { }

	// RVA: 0x52D500 Offset: 0x52BB00 VA: 0x18052D500
	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu] // RVA: 0xD1920 Offset: 0xD0D20 VA: 0x1800D1920
	[BaseEntity.Menu.Icon] // RVA: 0xD1920 Offset: 0xD0D20 VA: 0x1800D1920
	[BaseEntity.Menu.Description] // RVA: 0xD1920 Offset: 0xD0D20 VA: 0x1800D1920
	[BaseEntity.Menu.ShowIf] // RVA: 0xD1920 Offset: 0xD0D20 VA: 0x1800D1920
	// RVA: 0x52D9E0 Offset: 0x52BFE0 VA: 0x18052D9E0
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x52DFD0 Offset: 0x52C5D0 VA: 0x18052DFD0 Slot: 167
	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52E620 Offset: 0x52CC20 VA: 0x18052E620
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	// RVA: 0x52CB20 Offset: 0x52B120 VA: 0x18052CB20
	private void EnsureInitialized() { }

	[ConditionalAttribute] // RVA: 0x83E20 Offset: 0x83220 VA: 0x180083E20
	// RVA: 0x52EBC0 Offset: 0x52D1C0 VA: 0x18052EBC0
	private static void SignDebugLog(string str) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 165
	public FileStorage.Type get_FileType() { }

	// RVA: 0x52D4F0 Offset: 0x52BAF0 VA: 0x18052D4F0 Slot: 163
	public uint[] GetTextureCRCs() { }

	// RVA: 0x52EE80 Offset: 0x52D480 VA: 0x18052EE80 Slot: 164
	public uint get_NetworkID() { }

	// RVA: 0x52C700 Offset: 0x52AD00 VA: 0x18052C700 Slot: 168
	public virtual bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x52C6B0 Offset: 0x52ACB0 VA: 0x18052C6B0
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x52C660 Offset: 0x52AC60 VA: 0x18052C660
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x52D7A0 Offset: 0x52BDA0 VA: 0x18052D7A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52EF80 Offset: 0x52D580 VA: 0x18052EF80
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52EF90 Offset: 0x52D590 VA: 0x18052EF90
	private void set_withinTextureRange(bool value) { }

	// RVA: 0x52C8C0 Offset: 0x52AEC0 VA: 0x18052C8C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x52C950 Offset: 0x52AF50 VA: 0x18052C950 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x52E840 Offset: 0x52CE40 VA: 0x18052E840 Slot: 158
	public void RefreshLOD() { }

	// RVA: 0x52C7C0 Offset: 0x52ADC0 VA: 0x18052C7C0 Slot: 157
	public void ChangeLOD() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 169
	protected virtual void OnEnterTextureRange() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 170
	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Description] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	// RVA: 0x52DB00 Offset: 0x52C100 VA: 0x18052DB00
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Icon] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Description] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	// RVA: 0x52DB40 Offset: 0x52C140 VA: 0x18052DB40
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x52E460 Offset: 0x52CA60 VA: 0x18052E460
	public static void RebuildAll() { }

	// RVA: 0x52C790 Offset: 0x52AD90 VA: 0x18052C790 Slot: 122
	public override string Categorize() { }

	// RVA: 0x52EC90 Offset: 0x52D290 VA: 0x18052EC90
	public void .ctor() { }

	// RVA: 0x52EC50 Offset: 0x52D250 VA: 0x18052EC50
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x52EC20 Offset: 0x52D220 VA: 0x18052EC20
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x) { }

}

