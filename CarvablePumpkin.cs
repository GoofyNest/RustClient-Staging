public class CarvablePumpkin : BaseOven, ILOD, ISignage, IUGCBrowserEntity // TypeDefIndex: 8371
{	private Option __menuOption_Menu_ChangeText; // 0x4E8
	private Option __menuOption_Menu_LockSign; // 0x540
	private Option __menuOption_Menu_UnLockSign; // 0x598
	private const float TextureRequestTimeout = 15;
	public GameObjectRef changeTextDialog; // 0x5F0
	public MeshPaintableSource[] paintableSources; // 0x5F8
	public uint[] textureIDs; // 0x600
	internal RealTimeSince[] timeSinceRequest; // 0x608
	internal uint[] loadedTextures; // 0x610
	[ClientVar] // RVA: 0x712A0 Offset: 0x706A0 VA: 0x1800712A0
	public static float textureRequestDistance; // 0x0
	private bool textureRequestSent; // 0x618
	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool <withinTextureRange>k__BackingField; // 0x619
	private LODCell cell; // 0x620

	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	public FileStorage.Type FileType { get; }
	public uint NetworkID { get; }
	protected bool withinTextureRange { get; set; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Vector2i get_TextureSize() { }

	public int get_TextureCount() { }

	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	private void FreeTexture() { }

	protected void RequestTextureUpdate() { }

	private void LoadTexture(int frame, uint id, byte[] data) { }

	[BaseEntity.Menu] // RVA: 0xD1A50 Offset: 0xD0E50 VA: 0x1800D1A50
	[BaseEntity.Menu.Icon] // RVA: 0xD1A50 Offset: 0xD0E50 VA: 0x1800D1A50
	[BaseEntity.Menu.Description] // RVA: 0xD1A50 Offset: 0xD0E50 VA: 0x1800D1A50
	[BaseEntity.Menu.ShowIf] // RVA: 0xD1A50 Offset: 0xD0E50 VA: 0x1800D1A50
	public void Menu_ChangeText(BasePlayer player) { }

	public virtual void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void RecieveTexture(BaseEntity.RPCMessage msg) { }

	private void EnsureInitialized() { }

	[ConditionalAttribute] // RVA: 0x83EF0 Offset: 0x832F0 VA: 0x180083EF0
	private static void SignDebugLog(string str) { }

	public FileStorage.Type get_FileType() { }

	public uint[] GetTextureCRCs() { }

	public uint get_NetworkID() { }

	public virtual bool CanUpdateSign(BasePlayer player) { }

	public bool CanUnlockSign(BasePlayer player) { }

	public bool CanLockSign(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	protected bool get_withinTextureRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_withinTextureRange(bool value) { }

	protected override void ClientInit(Entity info) { }

	protected override void DoClientDestroy() { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	protected virtual void OnEnterTextureRange() { }

	protected virtual void OnExitTextureRange() { }

	[BaseEntity.Menu] // RVA: 0x7C580 Offset: 0x7B980 VA: 0x18007C580
	[BaseEntity.Menu.Icon] // RVA: 0x7C580 Offset: 0x7B980 VA: 0x18007C580
	[BaseEntity.Menu.Description] // RVA: 0x7C580 Offset: 0x7B980 VA: 0x18007C580
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C580 Offset: 0x7B980 VA: 0x18007C580
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C830 Offset: 0x7BC30 VA: 0x18007C830
	[BaseEntity.Menu.Icon] // RVA: 0x7C830 Offset: 0x7BC30 VA: 0x18007C830
	[BaseEntity.Menu.Description] // RVA: 0x7C830 Offset: 0x7BC30 VA: 0x18007C830
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C830 Offset: 0x7BC30 VA: 0x18007C830
	public void Menu_UnLockSign(BasePlayer player) { }

	public static void RebuildAll() { }

	public override string Categorize() { }

	public void .ctor() { }

	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void <Menu_ChangeText>b__21_0(int i, Texture2D x) { }

}

