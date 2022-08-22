public class PhotoFrame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6384
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint photoEntityId; // 0x14
	public uint overlayImageCrc; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1EA9BA0 Offset: 0x1EA81A0 VA: 0x181EA9BA0
	public static void ResetToPool(PhotoFrame instance) { }

	// RVA: 0x1EA9AA0 Offset: 0x1EA80A0 VA: 0x181EA9AA0
	public void ResetToPool() { }

	// RVA: 0x1EA98F0 Offset: 0x1EA7EF0 VA: 0x181EA98F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA86F0 Offset: 0x1EA6CF0 VA: 0x181EA86F0
	public void CopyTo(PhotoFrame instance) { }

	// RVA: 0x1EA8810 Offset: 0x1EA6E10 VA: 0x181EA8810
	public PhotoFrame Copy() { }

	// RVA: 0x1EA95A0 Offset: 0x1EA7BA0 VA: 0x181EA95A0
	public static PhotoFrame Deserialize(Stream stream) { }

	// RVA: 0x1EA8980 Offset: 0x1EA6F80 VA: 0x181EA8980
	public static PhotoFrame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA8D00 Offset: 0x1EA7300 VA: 0x181EA8D00
	public static PhotoFrame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA9080 Offset: 0x1EA7680 VA: 0x181EA9080
	public static PhotoFrame Deserialize(byte[] buffer) { }

	// RVA: 0x1EA9A60 Offset: 0x1EA8060 VA: 0x181EA9A60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EAA210 Offset: 0x1EA8810 VA: 0x181EAA210 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EAA230 Offset: 0x1EA8830 VA: 0x181EAA230 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhotoFrame previous) { }

	// RVA: 0x1EA9A80 Offset: 0x1EA8080 VA: 0x181EA9A80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA97F0 Offset: 0x1EA7DF0 VA: 0x181EA97F0
	public static PhotoFrame Deserialize(byte[] buffer, PhotoFrame instance, bool isDelta = False) { }

	// RVA: 0x1EA9370 Offset: 0x1EA7970 VA: 0x181EA9370
	public static PhotoFrame Deserialize(Stream stream, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA8A00 Offset: 0x1EA7000 VA: 0x181EA8A00
	public static PhotoFrame DeserializeLengthDelimited(Stream stream, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA8D90 Offset: 0x1EA7390 VA: 0x181EA8D90
	public static PhotoFrame DeserializeLength(Stream stream, int length, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA9CA0 Offset: 0x1EA82A0 VA: 0x181EA9CA0
	public static void SerializeDelta(Stream stream, PhotoFrame instance, PhotoFrame previous) { }

	// RVA: 0x1EAA050 Offset: 0x1EA8650 VA: 0x181EAA050
	public static void Serialize(Stream stream, PhotoFrame instance) { }

	// RVA: 0x1EAA200 Offset: 0x1EA8800 VA: 0x181EAA200
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EAA210 Offset: 0x1EA8810 VA: 0x181EAA210
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA9F40 Offset: 0x1EA8540 VA: 0x181EA9F40
	public static byte[] SerializeToBytes(PhotoFrame instance) { }

	// RVA: 0x1EA9E90 Offset: 0x1EA8490 VA: 0x181EA9E90
	public static void SerializeLengthDelimited(Stream stream, PhotoFrame instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x907CE0 Offset: 0x9062E0 VA: 0x180907CE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x909B50 Offset: 0x908150 VA: 0x180909B50 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x908A90 Offset: 0x907090 VA: 0x180908A90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x909D90 Offset: 0x908390 VA: 0x180909D90 Slot: 160
	public Vector2i get_TextureSize() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 161
	public int get_TextureCount() { }

	// RVA: 0x52C770 Offset: 0x52AD70 VA: 0x18052C770 Slot: 158
	public bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x907640 Offset: 0x905C40 VA: 0x180907640
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x907560 Offset: 0x905B60 VA: 0x180907560
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x909670 Offset: 0x907C70 VA: 0x180909670
	private void RequestOverlayTexture() { }

	// RVA: 0x908630 Offset: 0x906C30 VA: 0x180908630
	private void LoadOverlayTexture(uint crc, byte[] data) { }

	// RVA: 0x907780 Offset: 0x905D80 VA: 0x180907780
	private void ClearOverlayTexture() { }

	// RVA: 0x907A70 Offset: 0x906070 VA: 0x180907A70
	private void FreeOverlayTexture() { }

	[BaseEntity.Menu] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Icon] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Description] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	// RVA: 0x908740 Offset: 0x906D40 VA: 0x180908740
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x909050 Offset: 0x907650 VA: 0x180909050 Slot: 165
	public void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x909420 Offset: 0x907A20 VA: 0x180909420
	public void RecieveOverlayTexture(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Description] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	// RVA: 0x908930 Offset: 0x906F30 VA: 0x180908930
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Icon] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Description] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	// RVA: 0x908970 Offset: 0x906F70 VA: 0x180908970
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x9076E0 Offset: 0x905CE0 VA: 0x1809076E0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x9086D0 Offset: 0x906CD0 VA: 0x1809086D0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x908580 Offset: 0x906B80 VA: 0x180908580 Slot: 162
	public uint[] GetTextureCRCs() { }

	// RVA: 0x52EEF0 Offset: 0x52D4F0 VA: 0x18052EEF0 Slot: 163
	public uint get_NetworkID() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 164
	public FileStorage.Type get_FileType() { }

	// RVA: 0x907820 Offset: 0x905E20 VA: 0x180907820 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9078B0 Offset: 0x905EB0 VA: 0x1809078B0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x9078D0 Offset: 0x905ED0 VA: 0x1809078D0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x9091C0 Offset: 0x9077C0 VA: 0x1809091C0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x9085F0 Offset: 0x906BF0 VA: 0x1809085F0
	private bool IsWithinRenderDistance() { }

	// RVA: 0x9095F0 Offset: 0x907BF0 VA: 0x1809095F0 Slot: 156
	public void RefreshLOD() { }

	// RVA: 0x907710 Offset: 0x905D10 VA: 0x180907710 Slot: 155
	public void ChangeLOD() { }

	// RVA: 0x9097B0 Offset: 0x907DB0 VA: 0x1809097B0
	private void UpdateTextures() { }

	// RVA: 0x907C40 Offset: 0x906240 VA: 0x180907C40
	private void FreeTextures() { }

	// RVA: 0x9089B0 Offset: 0x906FB0 VA: 0x1809089B0 Slot: 157
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x907B00 Offset: 0x906100 VA: 0x180907B00
	private void FreePhotoTexture() { }

	// RVA: 0x9091E0 Offset: 0x9077E0 VA: 0x1809091E0
	public static void RebuildAll() { }

	// RVA: 0x907600 Offset: 0x905C00 VA: 0x180907600 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x909AF0 Offset: 0x9080F0 VA: 0x180909AF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x909050 Offset: 0x907650 VA: 0x180909050
	private void <Menu_ChangeText>b__20_0(int frame, Texture2D texture) { }

}

