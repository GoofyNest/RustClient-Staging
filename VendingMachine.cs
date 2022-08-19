public class VendingMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6339
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public VendingMachine.SellOrderContainer sellOrderContainer; // 0x18
	public string shopName; // 0x20
	public int vmoIndex; // 0x28
	public uint networkID; // 0x2C

	// Methods

	// RVA: 0x1EFFDB0 Offset: 0x1EFE3B0 VA: 0x181EFFDB0
	public static void ResetToPool(VendingMachine instance) { }

	// RVA: 0x1EFFCB0 Offset: 0x1EFE2B0 VA: 0x181EFFCB0
	public void ResetToPool() { }

	// RVA: 0x1EFF8F0 Offset: 0x1EFDEF0 VA: 0x181EFF8F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFE5D0 Offset: 0x1EFCBD0 VA: 0x181EFE5D0
	public void CopyTo(VendingMachine instance) { }

	// RVA: 0x1EFE670 Offset: 0x1EFCC70 VA: 0x181EFE670
	public VendingMachine Copy() { }

	// RVA: 0x1EFF170 Offset: 0x1EFD770 VA: 0x181EFF170
	public static VendingMachine Deserialize(Stream stream) { }

	// RVA: 0x1EFEA60 Offset: 0x1EFD060 VA: 0x181EFEA60
	public static VendingMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFEDC0 Offset: 0x1EFD3C0 VA: 0x181EFEDC0
	public static VendingMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFEE50 Offset: 0x1EFD450 VA: 0x181EFEE50
	public static VendingMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1EFFA60 Offset: 0x1EFE060 VA: 0x181EFFA60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F005B0 Offset: 0x1EFEBB0 VA: 0x181F005B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F005D0 Offset: 0x1EFEBD0 VA: 0x181F005D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine previous) { }

	// RVA: 0x1EFFC90 Offset: 0x1EFE290 VA: 0x181EFFC90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFF600 Offset: 0x1EFDC00 VA: 0x181EFF600
	public static VendingMachine Deserialize(byte[] buffer, VendingMachine instance, bool isDelta = False) { }

	// RVA: 0x1EFF3D0 Offset: 0x1EFD9D0 VA: 0x181EFF3D0
	public static VendingMachine Deserialize(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFE750 Offset: 0x1EFCD50 VA: 0x181EFE750
	public static VendingMachine DeserializeLengthDelimited(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFEAE0 Offset: 0x1EFD0E0 VA: 0x181EFEAE0
	public static VendingMachine DeserializeLength(Stream stream, int length, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFFEB0 Offset: 0x1EFE4B0 VA: 0x181EFFEB0
	public static void SerializeDelta(Stream stream, VendingMachine instance, VendingMachine previous) { }

	// RVA: 0x1F00340 Offset: 0x1EFE940 VA: 0x181F00340
	public static void Serialize(Stream stream, VendingMachine instance) { }

	// RVA: 0x1F005A0 Offset: 0x1EFEBA0 VA: 0x181F005A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F005B0 Offset: 0x1EFEBB0 VA: 0x181F005B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F00230 Offset: 0x1EFE830 VA: 0x181F00230
	public static byte[] SerializeToBytes(VendingMachine instance) { }

	// RVA: 0x1F00180 Offset: 0x1EFE780 VA: 0x181F00180
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

	// RVA: 0x1EEB3C0 Offset: 0x1EE99C0 VA: 0x181EEB3C0
	public static void ResetToPool(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEB4C0 Offset: 0x1EE9AC0 VA: 0x181EEB4C0
	public void ResetToPool() { }

	// RVA: 0x1EEAE70 Offset: 0x1EE9470 VA: 0x181EEAE70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE9290 Offset: 0x1EE7890 VA: 0x181EE9290
	public void CopyTo(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EE92F0 Offset: 0x1EE78F0 VA: 0x181EE92F0
	public VendingMachine.SellOrder Copy() { }

	// RVA: 0x1EEA250 Offset: 0x1EE8850 VA: 0x181EEA250
	public static VendingMachine.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x1EE9820 Offset: 0x1EE7E20 VA: 0x181EE9820
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE98A0 Offset: 0x1EE7EA0 VA: 0x181EE98A0
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE9D90 Offset: 0x1EE8390 VA: 0x181EE9D90
	public static VendingMachine.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1EEB000 Offset: 0x1EE9600 VA: 0x181EEB000
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEBD90 Offset: 0x1EEA390 VA: 0x181EEBD90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEBDB0 Offset: 0x1EEA3B0 VA: 0x181EEBDB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EEB3A0 Offset: 0x1EE99A0 VA: 0x181EEB3A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEA630 Offset: 0x1EE8C30 VA: 0x181EEA630
	public static VendingMachine.SellOrder Deserialize(byte[] buffer, VendingMachine.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x1EEAAD0 Offset: 0x1EE90D0 VA: 0x181EEAAD0
	public static VendingMachine.SellOrder Deserialize(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE93A0 Offset: 0x1EE79A0 VA: 0x181EE93A0
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE9930 Offset: 0x1EE7F30 VA: 0x181EE9930
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EEB5C0 Offset: 0x1EE9BC0 VA: 0x181EEB5C0
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrder instance, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EEBB60 Offset: 0x1EEA160 VA: 0x181EEBB60
	public static void Serialize(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEBD80 Offset: 0x1EEA380 VA: 0x181EEBD80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEBD90 Offset: 0x1EEA390 VA: 0x181EEBD90
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEBA50 Offset: 0x1EEA050 VA: 0x181EEBA50
	public static byte[] SerializeToBytes(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEB9A0 Offset: 0x1EE9FA0 VA: 0x181EEB9A0
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

	// RVA: 0x1E4AE70 Offset: 0x1E49470 VA: 0x181E4AE70
	public static void ResetToPool(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B020 Offset: 0x1E49620 VA: 0x181E4B020
	public void ResetToPool() { }

	// RVA: 0x1E4ABF0 Offset: 0x1E491F0 VA: 0x181E4ABF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E49F50 Offset: 0x1E48550 VA: 0x181E49F50
	public void CopyTo(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4A080 Offset: 0x1E48680 VA: 0x181E4A080
	public VendingMachine.SellOrderContainer Copy() { }

	// RVA: 0x1E4A7C0 Offset: 0x1E48DC0 VA: 0x181E4A7C0
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream) { }

	// RVA: 0x1E4A1F0 Offset: 0x1E487F0 VA: 0x181E4A1F0
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4A730 Offset: 0x1E48D30 VA: 0x181E4A730
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4A9D0 Offset: 0x1E48FD0 VA: 0x181E4A9D0
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1E4AE30 Offset: 0x1E49430 VA: 0x181E4AE30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E4B840 Offset: 0x1E49E40 VA: 0x181E4B840 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E4B860 Offset: 0x1E49E60 VA: 0x181E4B860 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E4AE50 Offset: 0x1E49450 VA: 0x181E4AE50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4AAF0 Offset: 0x1E490F0 VA: 0x181E4AAF0
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer, VendingMachine.SellOrderContainer instance, bool isDelta = False) { }

	// RVA: 0x1E4A840 Offset: 0x1E48E40 VA: 0x181E4A840
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4A270 Offset: 0x1E48870 VA: 0x181E4A270
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4A4E0 Offset: 0x1E48AE0 VA: 0x181E4A4E0
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4B1D0 Offset: 0x1E497D0 VA: 0x181E4B1D0
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrderContainer instance, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E4B600 Offset: 0x1E49C00 VA: 0x181E4B600
	public static void Serialize(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B830 Offset: 0x1E49E30 VA: 0x181E4B830
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E4B840 Offset: 0x1E49E40 VA: 0x181E4B840
	public void ToProto(Stream stream) { }

	// RVA: 0x1E4B4F0 Offset: 0x1E49AF0 VA: 0x181E4B4F0
	public static byte[] SerializeToBytes(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B400 Offset: 0x1E49A00 VA: 0x181E4B400
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
	[HeaderAttribute] // RVA: 0x9A840 Offset: 0x99C40 VA: 0x18009A840
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

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xAD9930 Offset: 0xAD7F30 VA: 0x180AD9930
	public void CLIENT_StartVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xAD95D0 Offset: 0xAD7BD0 VA: 0x180AD95D0
	public void CLIENT_CancelVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xAD97E0 Offset: 0xAD7DE0 VA: 0x180AD97E0
	public void CLIENT_ReceiveSellOrders(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 156
	public virtual bool ShouldShowAdminPanel() { }

	// RVA: 0xADC550 Offset: 0xADAB50 VA: 0x180ADC550 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9AAC0 Offset: 0x99EC0 VA: 0x18009AAC0
	[BaseEntity.Menu.Description] // RVA: 0x9AAC0 Offset: 0x99EC0 VA: 0x18009AAC0
	[BaseEntity.Menu.Icon] // RVA: 0x9AAC0 Offset: 0x99EC0 VA: 0x18009AAC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9AAC0 Offset: 0x99EC0 VA: 0x18009AAC0
	// RVA: 0xADAE20 Offset: 0xAD9420 VA: 0x180ADAE20
	public void Menu_Shop(BasePlayer player) { }

	// RVA: 0xADAC20 Offset: 0xAD9220 VA: 0x180ADAC20
	public bool Menu_Shop_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9AD40 Offset: 0x9A140 VA: 0x18009AD40
	[BaseEntity.Menu.Description] // RVA: 0x9AD40 Offset: 0x9A140 VA: 0x18009AD40
	[BaseEntity.Menu.Icon] // RVA: 0x9AD40 Offset: 0x9A140 VA: 0x18009AD40
	[BaseEntity.Menu.ShowIf] // RVA: 0x9AD40 Offset: 0x9A140 VA: 0x18009AD40
	// RVA: 0xADAB40 Offset: 0xAD9140 VA: 0x180ADAB40
	public void Menu_OpenAdmin(BasePlayer player) { }

	// RVA: 0xADAB00 Offset: 0xAD9100 VA: 0x180ADAB00
	public bool Menu_OpenAdmin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9AFE0 Offset: 0x9A3E0 VA: 0x18009AFE0
	[BaseEntity.Menu.Description] // RVA: 0x9AFE0 Offset: 0x9A3E0 VA: 0x18009AFE0
	[BaseEntity.Menu.Icon] // RVA: 0x9AFE0 Offset: 0x9A3E0 VA: 0x18009AFE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9AFE0 Offset: 0x9A3E0 VA: 0x18009AFE0
	// RVA: 0xADAA10 Offset: 0xAD9010 VA: 0x180ADAA10
	public void Menu_BroadcastOn(BasePlayer player) { }

	// RVA: 0xADAAB0 Offset: 0xAD90B0 VA: 0x180ADAAB0
	public bool Menu_Broadcast_On_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B2D0 Offset: 0x9A6D0 VA: 0x18009B2D0
	[BaseEntity.Menu.Description] // RVA: 0x9B2D0 Offset: 0x9A6D0 VA: 0x18009B2D0
	[BaseEntity.Menu.Icon] // RVA: 0x9B2D0 Offset: 0x9A6D0 VA: 0x18009B2D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B2D0 Offset: 0x9A6D0 VA: 0x18009B2D0
	// RVA: 0xADA9C0 Offset: 0xAD8FC0 VA: 0x180ADA9C0
	public void Menu_BroadcastOff(BasePlayer player) { }

	// RVA: 0xADAA60 Offset: 0xAD9060 VA: 0x180ADAA60
	public bool Menu_Broadcast_Off_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B550 Offset: 0x9A950 VA: 0x18009B550
	[BaseEntity.Menu.Description] // RVA: 0x9B550 Offset: 0x9A950 VA: 0x18009B550
	[BaseEntity.Menu.Icon] // RVA: 0x9B550 Offset: 0x9A950 VA: 0x18009B550
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B550 Offset: 0x9A950 VA: 0x18009B550
	// RVA: 0xADABE0 Offset: 0xAD91E0 VA: 0x180ADABE0
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0xADAB80 Offset: 0xAD9180 VA: 0x180ADAB80 Slot: 157
	public virtual bool Menu_RotateVM_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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

