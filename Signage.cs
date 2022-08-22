public class Signage : IOEntity, ILOD, ISignage, IUGCBrowserEntity // TypeDefIndex: 8445
{	private Option __menuOption_Menu_ChangeText; // 0x288
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

	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	protected bool withinTextureRange { get; set; }
	public uint NetworkID { get; }
	public FileStorage.Type FileType { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Vector2i get_TextureSize() { }

	public int get_TextureCount() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	private void FreeTexture() { }

	protected void RequestTextureUpdate() { }

	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Icon] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Description] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	public void Menu_ChangeText(BasePlayer player) { }

	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	private void EnsureInitialized() { }

	[ConditionalAttribute] // RVA: 0x83E20 Offset: 0x83220 VA: 0x180083E20
	private static void SignDebugLog(string str) { }

	public virtual bool CanUpdateSign(BasePlayer player) { }

	public bool CanUnlockSign(BasePlayer player) { }

	public bool CanLockSign(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	private bool HeldEntityCheck(BasePlayer player) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_withinTextureRange(bool value) { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	protected virtual void OnEnterTextureRange() { }

	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Description] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Icon] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Description] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	public void Menu_UnLockSign(BasePlayer player) { }

	public static void RebuildAll() { }

	public uint[] GetTextureCRCs() { }

	public uint get_NetworkID() { }

	public FileStorage.Type get_FileType() { }

	public override int ConsumptionAmount() { }

	public override string Categorize() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x) { }

}

