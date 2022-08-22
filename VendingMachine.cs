public class VendingMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6339
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public VendingMachine.SellOrderContainer sellOrderContainer; // 0x18
	public string shopName; // 0x20
	public int vmoIndex; // 0x28
	public uint networkID; // 0x2C

	// Methods

	// RVA: 0x1EFFBF0 Offset: 0x1EFE1F0 VA: 0x181EFFBF0
	public static void ResetToPool(VendingMachine instance) { }

	// RVA: 0x1EFFAF0 Offset: 0x1EFE0F0 VA: 0x181EFFAF0
	public void ResetToPool() { }

	// RVA: 0x1EFF730 Offset: 0x1EFDD30 VA: 0x181EFF730 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFE410 Offset: 0x1EFCA10 VA: 0x181EFE410
	public void CopyTo(VendingMachine instance) { }

	// RVA: 0x1EFE4B0 Offset: 0x1EFCAB0 VA: 0x181EFE4B0
	public VendingMachine Copy() { }

	// RVA: 0x1EFEFB0 Offset: 0x1EFD5B0 VA: 0x181EFEFB0
	public static VendingMachine Deserialize(Stream stream) { }

	// RVA: 0x1EFE8A0 Offset: 0x1EFCEA0 VA: 0x181EFE8A0
	public static VendingMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFEC00 Offset: 0x1EFD200 VA: 0x181EFEC00
	public static VendingMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFEC90 Offset: 0x1EFD290 VA: 0x181EFEC90
	public static VendingMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1EFF8A0 Offset: 0x1EFDEA0 VA: 0x181EFF8A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F003F0 Offset: 0x1EFE9F0 VA: 0x181F003F0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F00410 Offset: 0x1EFEA10 VA: 0x181F00410 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine previous) { }

	// RVA: 0x1EFFAD0 Offset: 0x1EFE0D0 VA: 0x181EFFAD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFF440 Offset: 0x1EFDA40 VA: 0x181EFF440
	public static VendingMachine Deserialize(byte[] buffer, VendingMachine instance, bool isDelta = False) { }

	// RVA: 0x1EFF210 Offset: 0x1EFD810 VA: 0x181EFF210
	public static VendingMachine Deserialize(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFE590 Offset: 0x1EFCB90 VA: 0x181EFE590
	public static VendingMachine DeserializeLengthDelimited(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFE920 Offset: 0x1EFCF20 VA: 0x181EFE920
	public static VendingMachine DeserializeLength(Stream stream, int length, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFFCF0 Offset: 0x1EFE2F0 VA: 0x181EFFCF0
	public static void SerializeDelta(Stream stream, VendingMachine instance, VendingMachine previous) { }

	// RVA: 0x1F00180 Offset: 0x1EFE780 VA: 0x181F00180
	public static void Serialize(Stream stream, VendingMachine instance) { }

	// RVA: 0x1F003E0 Offset: 0x1EFE9E0 VA: 0x181F003E0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F003F0 Offset: 0x1EFE9F0 VA: 0x181F003F0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F00070 Offset: 0x1EFE670 VA: 0x181F00070
	public static byte[] SerializeToBytes(VendingMachine instance) { }

	// RVA: 0x1EFFFC0 Offset: 0x1EFE5C0 VA: 0x181EFFFC0
	public static void SerializeLengthDelimited(Stream stream, VendingMachine instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class VendingMachine.SellOrder : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6340
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int itemToSellID; // 0x14
	public int itemToSellAmount; // 0x18
	public int currencyID; // 0x1C
	public int currencyAmountPerItem; // 0x20
	public int inStock; // 0x24
	public bool currencyIsBP; // 0x28
	public bool itemToSellIsBP; // 0x29
	public float itemCondition; // 0x2C
	public float itemConditionMax; // 0x30
	public int instanceData; // 0x34

	// Methods

	// RVA: 0x1EEB200 Offset: 0x1EE9800 VA: 0x181EEB200
	public static void ResetToPool(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEB300 Offset: 0x1EE9900 VA: 0x181EEB300
	public void ResetToPool() { }

	// RVA: 0x1EEACB0 Offset: 0x1EE92B0 VA: 0x181EEACB0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE90D0 Offset: 0x1EE76D0 VA: 0x181EE90D0
	public void CopyTo(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EE9130 Offset: 0x1EE7730 VA: 0x181EE9130
	public VendingMachine.SellOrder Copy() { }

	// RVA: 0x1EEA090 Offset: 0x1EE8690 VA: 0x181EEA090
	public static VendingMachine.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x1EE9660 Offset: 0x1EE7C60 VA: 0x181EE9660
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE96E0 Offset: 0x1EE7CE0 VA: 0x181EE96E0
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE9BD0 Offset: 0x1EE81D0 VA: 0x181EE9BD0
	public static VendingMachine.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1EEAE40 Offset: 0x1EE9440 VA: 0x181EEAE40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEBBD0 Offset: 0x1EEA1D0 VA: 0x181EEBBD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEBBF0 Offset: 0x1EEA1F0 VA: 0x181EEBBF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EEB1E0 Offset: 0x1EE97E0 VA: 0x181EEB1E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEA470 Offset: 0x1EE8A70 VA: 0x181EEA470
	public static VendingMachine.SellOrder Deserialize(byte[] buffer, VendingMachine.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x1EEA910 Offset: 0x1EE8F10 VA: 0x181EEA910
	public static VendingMachine.SellOrder Deserialize(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE91E0 Offset: 0x1EE77E0 VA: 0x181EE91E0
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE9770 Offset: 0x1EE7D70 VA: 0x181EE9770
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EEB400 Offset: 0x1EE9A00 VA: 0x181EEB400
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrder instance, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EEB9A0 Offset: 0x1EE9FA0 VA: 0x181EEB9A0
	public static void Serialize(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEBBC0 Offset: 0x1EEA1C0 VA: 0x181EEBBC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEBBD0 Offset: 0x1EEA1D0 VA: 0x181EEBBD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEB890 Offset: 0x1EE9E90 VA: 0x181EEB890
	public static byte[] SerializeToBytes(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEB7E0 Offset: 0x1EE9DE0 VA: 0x181EEB7E0
	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class VendingMachine.SellOrderContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6341
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VendingMachine.SellOrder> sellOrders; // 0x18

	// Methods

	// RVA: 0x1E4ACB0 Offset: 0x1E492B0 VA: 0x181E4ACB0
	public static void ResetToPool(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4AE60 Offset: 0x1E49460 VA: 0x181E4AE60
	public void ResetToPool() { }

	// RVA: 0x1E4AA30 Offset: 0x1E49030 VA: 0x181E4AA30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E49D90 Offset: 0x1E48390 VA: 0x181E49D90
	public void CopyTo(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E49EC0 Offset: 0x1E484C0 VA: 0x181E49EC0
	public VendingMachine.SellOrderContainer Copy() { }

	// RVA: 0x1E4A600 Offset: 0x1E48C00 VA: 0x181E4A600
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream) { }

	// RVA: 0x1E4A030 Offset: 0x1E48630 VA: 0x181E4A030
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4A570 Offset: 0x1E48B70 VA: 0x181E4A570
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4A810 Offset: 0x1E48E10 VA: 0x181E4A810
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1E4AC70 Offset: 0x1E49270 VA: 0x181E4AC70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E4B680 Offset: 0x1E49C80 VA: 0x181E4B680 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E4B6A0 Offset: 0x1E49CA0 VA: 0x181E4B6A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E4AC90 Offset: 0x1E49290 VA: 0x181E4AC90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4A930 Offset: 0x1E48F30 VA: 0x181E4A930
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer, VendingMachine.SellOrderContainer instance, bool isDelta = False) { }

	// RVA: 0x1E4A680 Offset: 0x1E48C80 VA: 0x181E4A680
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4A0B0 Offset: 0x1E486B0 VA: 0x181E4A0B0
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4A320 Offset: 0x1E48920 VA: 0x181E4A320
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4B010 Offset: 0x1E49610 VA: 0x181E4B010
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrderContainer instance, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E4B440 Offset: 0x1E49A40 VA: 0x181E4B440
	public static void Serialize(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B670 Offset: 0x1E49C70 VA: 0x181E4B670
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E4B680 Offset: 0x1E49C80 VA: 0x181E4B680
	public void ToProto(Stream stream) { }

	// RVA: 0x1E4B330 Offset: 0x1E49930 VA: 0x181E4B330
	public static byte[] SerializeToBytes(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B240 Offset: 0x1E49840 VA: 0x181E4B240
	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class VendingMachine : StorageContainer // TypeDefIndex: 8484
{	// Fields
	private Option __menuOption_Menu_BroadcastOff; // 0x3D0
	private Option __menuOption_Menu_BroadcastOn; // 0x428
	private Option __menuOption_Menu_OpenAdmin; // 0x480
	private Option __menuOption_Menu_RotateVM; // 0x4D8
	private Option __menuOption_Menu_Shop; // 0x530
	[HeaderAttribute] // RVA: 0x9A8D0 Offset: 0x99CD0 VA: 0x18009A8D0
	public static readonly Translate.Phrase WaitForVendingMessage; // 0x0
	public GameObjectRef adminMenuPrefab; // 0x588
	public string customerPanel; // 0x590
	public VendingMachine.SellOrderContainer sellOrders; // 0x598
	public SoundPlayer buySound; // 0x5A0
	public string shopName; // 0x5A8
	public GameObjectRef mapMarkerPrefab; // 0x5B0
	public ItemDefinition blueprintBaseDef; // 0x5B8
	private List<SoundManager.ScheduledSound> scheduledPhysSounds; // 0x5C0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xAD9CA0 Offset: 0xAD82A0 VA: 0x180AD9CA0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xADC7F0 Offset: 0xADADF0 VA: 0x180ADC7F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xADAE60 Offset: 0xAD9460 VA: 0x180ADAE60 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xADA920 Offset: 0xAD8F20 VA: 0x180ADA920 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xADA870 Offset: 0xAD8E70 VA: 0x180ADA870 Slot: 155
	public virtual void InstallDefaultSellOrders() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD9930 Offset: 0xAD7F30 VA: 0x180AD9930
	public void CLIENT_StartVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD95D0 Offset: 0xAD7BD0 VA: 0x180AD95D0
	public void CLIENT_CancelVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD97E0 Offset: 0xAD7DE0 VA: 0x180AD97E0
	public void CLIENT_ReceiveSellOrders(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 156
	public virtual bool ShouldShowAdminPanel() { }

	// RVA: 0xADC550 Offset: 0xADAB50 VA: 0x180ADC550 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.Description] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.Icon] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	// RVA: 0xADAE20 Offset: 0xAD9420 VA: 0x180ADAE20
	public void Menu_Shop(BasePlayer player) { }

	// RVA: 0xADAC20 Offset: 0xAD9220 VA: 0x180ADAC20
	public bool Menu_Shop_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.Description] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.Icon] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	// RVA: 0xADAB40 Offset: 0xAD9140 VA: 0x180ADAB40
	public void Menu_OpenAdmin(BasePlayer player) { }

	// RVA: 0xADAB00 Offset: 0xAD9100 VA: 0x180ADAB00
	public bool Menu_OpenAdmin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.Description] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.Icon] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	// RVA: 0xADAA10 Offset: 0xAD9010 VA: 0x180ADAA10
	public void Menu_BroadcastOn(BasePlayer player) { }

	// RVA: 0xADAAB0 Offset: 0xAD90B0 VA: 0x180ADAAB0
	public bool Menu_Broadcast_On_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.Description] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.Icon] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	// RVA: 0xADA9C0 Offset: 0xAD8FC0 VA: 0x180ADA9C0
	public void Menu_BroadcastOff(BasePlayer player) { }

	// RVA: 0xADAA60 Offset: 0xAD9060 VA: 0x180ADAA60
	public bool Menu_Broadcast_Off_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.Description] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.Icon] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	// RVA: 0xADABE0 Offset: 0xAD91E0 VA: 0x180ADABE0
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0xADAB80 Offset: 0xAD9180 VA: 0x180ADAB80 Slot: 157
	public virtual bool Menu_RotateVM_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD96E0 Offset: 0xAD7CE0 VA: 0x180AD96E0
	private void CLIENT_OpenAdminMenu(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xADC200 Offset: 0xADA800 VA: 0x180ADC200 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 158
	protected virtual bool CanRotate() { }

	// RVA: 0x738180 Offset: 0x736780 VA: 0x180738180
	public bool IsBroadcasting() { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsInventoryEmpty() { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool IsVending() { }

	// RVA: 0xADBE80 Offset: 0xADA480 VA: 0x180ADBE80
	public bool PlayerBehind(BasePlayer player) { }

	// RVA: 0xADC040 Offset: 0xADA640 VA: 0x180ADC040
	public bool PlayerInfront(BasePlayer player) { }

	// RVA: 0xAD9C60 Offset: 0xAD8260 VA: 0x180AD9C60 Slot: 159
	public virtual bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0xADC730 Offset: 0xADAD30 VA: 0x180ADC730
	public void .ctor() { }

	// RVA: 0xADC6C0 Offset: 0xADACC0 VA: 0x180ADC6C0
	private static void .cctor() { }

}

public static class VendingMachine.VendingMachineFlags // TypeDefIndex: 8485
{	// Fields
	public const BaseEntity.Flags EmptyInv = 128;
	public const BaseEntity.Flags IsVending = 256;
	public const BaseEntity.Flags Broadcasting = 1024;
	public const BaseEntity.Flags OutOfStock = 2048;
	public const BaseEntity.Flags NoDirectAccess = 16384;

}

