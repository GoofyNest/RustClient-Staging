public class PhotoFrame : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6384
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint photoEntityId; // 0x14
	public uint overlayImageCrc; // 0x18
	public List<ulong> editHistory; // 0x20

	// Methods

	// RVA: 0x1EA98E0 Offset: 0x1EA7EE0 VA: 0x181EA98E0
	public static void ResetToPool(PhotoFrame instance) { }

	// RVA: 0x1EA97E0 Offset: 0x1EA7DE0 VA: 0x181EA97E0
	public void ResetToPool() { }

	// RVA: 0x1EA9630 Offset: 0x1EA7C30 VA: 0x181EA9630 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EA8430 Offset: 0x1EA6A30 VA: 0x181EA8430
	public void CopyTo(PhotoFrame instance) { }

	// RVA: 0x1EA8550 Offset: 0x1EA6B50 VA: 0x181EA8550
	public PhotoFrame Copy() { }

	// RVA: 0x1EA92E0 Offset: 0x1EA78E0 VA: 0x181EA92E0
	public static PhotoFrame Deserialize(Stream stream) { }

	// RVA: 0x1EA86C0 Offset: 0x1EA6CC0 VA: 0x181EA86C0
	public static PhotoFrame DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EA8A40 Offset: 0x1EA7040 VA: 0x181EA8A40
	public static PhotoFrame DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EA8DC0 Offset: 0x1EA73C0 VA: 0x181EA8DC0
	public static PhotoFrame Deserialize(byte[] buffer) { }

	// RVA: 0x1EA97A0 Offset: 0x1EA7DA0 VA: 0x181EA97A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EA9F50 Offset: 0x1EA8550 VA: 0x181EA9F50 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EA9F70 Offset: 0x1EA8570 VA: 0x181EA9F70 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, PhotoFrame previous) { }

	// RVA: 0x1EA97C0 Offset: 0x1EA7DC0 VA: 0x181EA97C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EA9530 Offset: 0x1EA7B30 VA: 0x181EA9530
	public static PhotoFrame Deserialize(byte[] buffer, PhotoFrame instance, bool isDelta = False) { }

	// RVA: 0x1EA90B0 Offset: 0x1EA76B0 VA: 0x181EA90B0
	public static PhotoFrame Deserialize(Stream stream, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA8740 Offset: 0x1EA6D40 VA: 0x181EA8740
	public static PhotoFrame DeserializeLengthDelimited(Stream stream, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA8AD0 Offset: 0x1EA70D0 VA: 0x181EA8AD0
	public static PhotoFrame DeserializeLength(Stream stream, int length, PhotoFrame instance, bool isDelta) { }

	// RVA: 0x1EA99E0 Offset: 0x1EA7FE0 VA: 0x181EA99E0
	public static void SerializeDelta(Stream stream, PhotoFrame instance, PhotoFrame previous) { }

	// RVA: 0x1EA9D90 Offset: 0x1EA8390 VA: 0x181EA9D90
	public static void Serialize(Stream stream, PhotoFrame instance) { }

	// RVA: 0x1EA9F40 Offset: 0x1EA8540 VA: 0x181EA9F40
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EA9F50 Offset: 0x1EA8550 VA: 0x181EA9F50
	public void ToProto(Stream stream) { }

	// RVA: 0x1EA9C80 Offset: 0x1EA8280 VA: 0x181EA9C80
	public static byte[] SerializeToBytes(PhotoFrame instance) { }

	// RVA: 0x1EA9BD0 Offset: 0x1EA81D0 VA: 0x181EA9BD0
	public static void SerializeLengthDelimited(Stream stream, PhotoFrame instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x907BD0 Offset: 0x9061D0 VA: 0x180907BD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x909A40 Offset: 0x908040 VA: 0x180909A40 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x908980 Offset: 0x906F80 VA: 0x180908980 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x909C80 Offset: 0x908280 VA: 0x180909C80 Slot: 160
	public Vector2i get_TextureSize() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 161
	public int get_TextureCount() { }

	// RVA: 0x52C770 Offset: 0x52AD70 VA: 0x18052C770 Slot: 158
	public bool CanUpdateSign(BasePlayer player) { }

	// RVA: 0x907530 Offset: 0x905B30 VA: 0x180907530
	public bool CanUnlockSign(BasePlayer player) { }

	// RVA: 0x907450 Offset: 0x905A50 VA: 0x180907450
	public bool CanLockSign(BasePlayer player) { }

	// RVA: 0x909560 Offset: 0x907B60 VA: 0x180909560
	private void RequestOverlayTexture() { }

	// RVA: 0x908520 Offset: 0x906B20 VA: 0x180908520
	private void LoadOverlayTexture(uint crc, byte[] data) { }

	// RVA: 0x907670 Offset: 0x905C70 VA: 0x180907670
	private void ClearOverlayTexture() { }

	// RVA: 0x907960 Offset: 0x905F60 VA: 0x180907960
	private void FreeOverlayTexture() { }

	[BaseEntity.Menu] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Icon] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.Description] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C230 Offset: 0x7B630 VA: 0x18007C230
	// RVA: 0x908630 Offset: 0x906C30 VA: 0x180908630
	public void Menu_ChangeText(BasePlayer player) { }

	// RVA: 0x908F40 Offset: 0x907540 VA: 0x180908F40 Slot: 165
	public void OnTextureWasEdited(int frame, Texture2D texture, bool fromFile = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x909310 Offset: 0x907910 VA: 0x180909310
	public void RecieveOverlayTexture(BaseEntity.RPCMessage msg) { }

	[BaseEntity.Menu] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Icon] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.Description] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C4F0 Offset: 0x7B8F0 VA: 0x18007C4F0
	// RVA: 0x908820 Offset: 0x906E20 VA: 0x180908820
	public void Menu_LockSign(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Icon] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.Description] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7C7D0 Offset: 0x7BBD0 VA: 0x18007C7D0
	// RVA: 0x908860 Offset: 0x906E60 VA: 0x180908860
	public void Menu_UnLockSign(BasePlayer player) { }

	// RVA: 0x9075D0 Offset: 0x905BD0 VA: 0x1809075D0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x9085C0 Offset: 0x906BC0 VA: 0x1809085C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x908470 Offset: 0x906A70 VA: 0x180908470 Slot: 162
	public uint[] GetTextureCRCs() { }

	// RVA: 0x52EEF0 Offset: 0x52D4F0 VA: 0x18052EEF0 Slot: 163
	public uint get_NetworkID() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 164
	public FileStorage.Type get_FileType() { }

	// RVA: 0x907710 Offset: 0x905D10 VA: 0x180907710 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9077A0 Offset: 0x905DA0 VA: 0x1809077A0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x9077C0 Offset: 0x905DC0 VA: 0x1809077C0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x9090B0 Offset: 0x9076B0 VA: 0x1809090B0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x9084E0 Offset: 0x906AE0 VA: 0x1809084E0
	private bool IsWithinRenderDistance() { }

	// RVA: 0x9094E0 Offset: 0x907AE0 VA: 0x1809094E0 Slot: 156
	public void RefreshLOD() { }

	// RVA: 0x907600 Offset: 0x905C00 VA: 0x180907600 Slot: 155
	public void ChangeLOD() { }

	// RVA: 0x9096A0 Offset: 0x907CA0 VA: 0x1809096A0
	private void UpdateTextures() { }

	// RVA: 0x907B30 Offset: 0x906130 VA: 0x180907B30
	private void FreeTextures() { }

	// RVA: 0x9088A0 Offset: 0x906EA0 VA: 0x1809088A0 Slot: 157
	public void OnImageLoaded(Texture2D texture) { }

	// RVA: 0x9079F0 Offset: 0x905FF0 VA: 0x1809079F0
	private void FreePhotoTexture() { }

	// RVA: 0x9090D0 Offset: 0x9076D0 VA: 0x1809090D0
	public static void RebuildAll() { }

	// RVA: 0x9074F0 Offset: 0x905AF0 VA: 0x1809074F0 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x9099E0 Offset: 0x907FE0 VA: 0x1809099E0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x908F40 Offset: 0x907540 VA: 0x180908F40
	private void <Menu_ChangeText>b__20_0(int frame, Texture2D texture) { }

}

