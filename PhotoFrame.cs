public class PhotoFrame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6384
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint photoEntityId; // 0x14
	public uint overlayImageCrc; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1EAA3C0 Offset: 0x1EA89C0 VA: 0x181EAA3C0
	public static void ResetToPool(PhotoFrame instance) { }

	// RVA: 0x1EAA2C0 Offset: 0x1EA88C0 VA: 0x181EAA2C0
	public void ResetToPool() { }

	// RVA: 0x1EAA110 Offset: 0x1EA8710 VA: 0x181EAA110 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA8F10 Offset: 0x1EA7510 VA: 0x181EA8F10
	public void CopyTo(PhotoFrame instance) { }

	// RVA: 0x1EA9030 Offset: 0x1EA7630 VA: 0x181EA9030
	public PhotoFrame Copy() { }

	// RVA: 0x1EA9DC0 Offset: 0x1EA83C0 VA: 0x181EA9DC0
	public static PhotoFrame Deserialize(Stream stream) { }

	// RVA: 0x1EA91A0 Offset: 0x1EA77A0 VA: 0x181EA91A0
	public static PhotoFrame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA9520 Offset: 0x1EA7B20 VA: 0x181EA9520
	public static PhotoFrame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA98A0 Offset: 0x1EA7EA0 VA: 0x181EA98A0
	public static PhotoFrame Deserialize(byte[] buffer) { }

	// RVA: 0x1EAA280 Offset: 0x1EA8880 VA: 0x181EAA280
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAAA30 Offset: 0x1EA9030 VA: 0x181EAAA30 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAAA50 Offset: 0x1EA9050 VA: 0x181EAAA50 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhotoFrame previous) { }

	// RVA: 0x1EAA2A0 Offset: 0x1EA88A0 VA: 0x181EAA2A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EAA010 Offset: 0x1EA8610 VA: 0x181EAA010
	public static PhotoFrame Deserialize(byte[] buffer, PhotoFrame instance, bool isDelta = False) { }

	// RVA: 0x1EA9B90 Offset: 0x1EA8190 VA: 0x181EA9B90
	public static PhotoFrame Deserialize(Stream stream, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA9220 Offset: 0x1EA7820 VA: 0x181EA9220
	public static PhotoFrame DeserializeLengthDelimited(Stream stream, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA95B0 Offset: 0x1EA7BB0 VA: 0x181EA95B0
	public static PhotoFrame DeserializeLength(Stream stream, int length, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EAA4C0 Offset: 0x1EA8AC0 VA: 0x181EAA4C0
	public static void SerializeDelta(Stream stream, PhotoFrame instance, PhotoFrame previous) { }

	// RVA: 0x1EAA870 Offset: 0x1EA8E70 VA: 0x181EAA870
	public static void Serialize(Stream stream, PhotoFrame instance) { }

	// RVA: 0x1EAAA20 Offset: 0x1EA9020 VA: 0x181EAAA20
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAAA30 Offset: 0x1EA9030 VA: 0x181EAAA30
	public void ToProto(Stream stream) { }

	// RVA: 0x1EAA760 Offset: 0x1EA8D60 VA: 0x181EAA760
	public static byte[] SerializeToBytes(PhotoFrame instance) { }

	// RVA: 0x1EAA6B0 Offset: 0x1EA8CB0 VA: 0x181EAA6B0
	public static void SerializeLengthDelimited(Stream stream, PhotoFrame instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class PhotoFrame : StorageContainer, ILOD, IImageReceiver, ISignage, IUGCBrowserEntity // TypeDefIndex: 8427
{	// Fields
	private Option __menuOption_Menu_ChangeText; // 0x3D0
	private Option __menuOption_Menu_LockSign; // 0x428
	private Option __menuOption_Menu_UnLockSign; // 0x480
	public GameObjectRef SignEditorDialog; // 0x4D8
	public OverlayMeshPaintableSource PaintableSource; // 0x4E0
	private const float TextureRequestDistance = 100;
	private EntityRef _photoEntity; // 0x4E8
	private uint _overlayTextureCrc; // 0x4F8
	private LODCell _cell; // 0x500
	private Texture2D _photoTexture; // 0x508
	private uint _loadedPhotoEntityId; // 0x510
	private uint _loadedOverlayCrc; // 0x514

	// Properties
	public override bool HasMenuOptions { get; }
	public Vector2i TextureSize { get; }
	public int TextureCount { get; }
	public uint NetworkID { get; }
	public FileStorage.Type FileType { get; }

	// Methods

	// RVA: 0x9081F0 Offset: 0x9067F0 VA: 0x1809081F0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x90A060 Offset: 0x908660 VA: 0x18090A060 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x908FA0 Offset: 0x9075A0 VA: 0x180908FA0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x90A2A0 Offset: 0x9088A0 VA: 0x18090A2A0 Slot: 160
	public Vector2i get_TextureSize() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 161
	public int get_TextureCount() { }

	// RVA: 0x52C700 Offset: 0x52AD00 VA: 0x18052C700 Slot: 158
	public bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x907B50 Offset: 0x906150 VA: 0x180907B50
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x907A70 Offset: 0x906070 VA: 0x180907A70
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x909B80 Offset: 0x908180 VA: 0x180909B80
	private void RequestOverlayTexture() { }

	// RVA: 0x908B40 Offset: 0x907140 VA: 0x180908B40
	private void LoadOverlayTexture(uint crc, byte[] data) { }

	// RVA: 0x907C90 Offset: 0x906290 VA: 0x180907C90
	private void ClearOverlayTexture() { }

	// RVA: 0x907F80 Offset: 0x906580 VA: 0x180907F80
	private void FreeOverlayTexture() { }

	[BaseEntity.Menu] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Icon] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Description] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	// RVA: 0x908C50 Offset: 0x907250 VA: 0x180908C50
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x909560 Offset: 0x907B60 VA: 0x180909560 Slot: 165
	public void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x909930 Offset: 0x907F30 VA: 0x180909930
	public void RecieveOverlayTexture(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Description] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	// RVA: 0x908E40 Offset: 0x907440 VA: 0x180908E40
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Icon] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Description] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	// RVA: 0x908E80 Offset: 0x907480 VA: 0x180908E80
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x907BF0 Offset: 0x9061F0 VA: 0x180907BF0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x908BE0 Offset: 0x9071E0 VA: 0x180908BE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x908A90 Offset: 0x907090 VA: 0x180908A90 Slot: 162
	public uint[] GetTextureCRCs() { }

	// RVA: 0x52EE80 Offset: 0x52D480 VA: 0x18052EE80 Slot: 163
	public uint get_NetworkID() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 164
	public FileStorage.Type get_FileType() { }

	// RVA: 0x907D30 Offset: 0x906330 VA: 0x180907D30 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x907DC0 Offset: 0x9063C0 VA: 0x180907DC0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x907DE0 Offset: 0x9063E0 VA: 0x180907DE0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x9096D0 Offset: 0x907CD0 VA: 0x1809096D0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x908B00 Offset: 0x907100 VA: 0x180908B00
	private bool IsWithinRenderDistance() { }

	// RVA: 0x909B00 Offset: 0x908100 VA: 0x180909B00 Slot: 156
	public void RefreshLOD() { }

	// RVA: 0x907C20 Offset: 0x906220 VA: 0x180907C20 Slot: 155
	public void ChangeLOD() { }

	// RVA: 0x909CC0 Offset: 0x9082C0 VA: 0x180909CC0
	private void UpdateTextures() { }

	// RVA: 0x908150 Offset: 0x906750 VA: 0x180908150
	private void FreeTextures() { }

	// RVA: 0x908EC0 Offset: 0x9074C0 VA: 0x180908EC0 Slot: 157
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x908010 Offset: 0x906610 VA: 0x180908010
	private void FreePhotoTexture() { }

	// RVA: 0x9096F0 Offset: 0x907CF0 VA: 0x1809096F0
	public static void RebuildAll() { }

	// RVA: 0x907B10 Offset: 0x906110 VA: 0x180907B10 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x90A000 Offset: 0x908600 VA: 0x18090A000
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x909560 Offset: 0x907B60 VA: 0x180909560
	private void <Menu_ChangeText>b__20_0(int frame, Texture2D texture) { }

}

