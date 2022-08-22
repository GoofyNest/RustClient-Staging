public class VendingMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6339
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public VendingMachine.SellOrderContainer sellOrderContainer; // 0x18
	public string shopName; // 0x20
	public int vmoIndex; // 0x28
	public uint networkID; // 0x2C

	// Methods

	// RVA: 0x1EFFEB0 Offset: 0x1EFE4B0 VA: 0x181EFFEB0
	public static void ResetToPool(VendingMachine instance) { }

	// RVA: 0x1EFFDB0 Offset: 0x1EFE3B0 VA: 0x181EFFDB0
	public void ResetToPool() { }

	// RVA: 0x1EFF9F0 Offset: 0x1EFDFF0 VA: 0x181EFF9F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFE6D0 Offset: 0x1EFCCD0 VA: 0x181EFE6D0
	public void CopyTo(VendingMachine instance) { }

	// RVA: 0x1EFE770 Offset: 0x1EFCD70 VA: 0x181EFE770
	public VendingMachine Copy() { }

	// RVA: 0x1EFF270 Offset: 0x1EFD870 VA: 0x181EFF270
	public static VendingMachine Deserialize(Stream stream) { }

	// RVA: 0x1EFEB60 Offset: 0x1EFD160 VA: 0x181EFEB60
	public static VendingMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFEEC0 Offset: 0x1EFD4C0 VA: 0x181EFEEC0
	public static VendingMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFEF50 Offset: 0x1EFD550 VA: 0x181EFEF50
	public static VendingMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1EFFB60 Offset: 0x1EFE160 VA: 0x181EFFB60
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F006B0 Offset: 0x1EFECB0 VA: 0x181F006B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F006D0 Offset: 0x1EFECD0 VA: 0x181F006D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine previous) { }

	// RVA: 0x1EFFD90 Offset: 0x1EFE390 VA: 0x181EFFD90 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFF700 Offset: 0x1EFDD00 VA: 0x181EFF700
	public static VendingMachine Deserialize(byte[] buffer, VendingMachine instance, bool isDelta = False) { }

	// RVA: 0x1EFF4D0 Offset: 0x1EFDAD0 VA: 0x181EFF4D0
	public static VendingMachine Deserialize(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFE850 Offset: 0x1EFCE50 VA: 0x181EFE850
	public static VendingMachine DeserializeLengthDelimited(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFEBE0 Offset: 0x1EFD1E0 VA: 0x181EFEBE0
	public static VendingMachine DeserializeLength(Stream stream, int length, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFFFB0 Offset: 0x1EFE5B0 VA: 0x181EFFFB0
	public static void SerializeDelta(Stream stream, VendingMachine instance, VendingMachine previous) { }

	// RVA: 0x1F00440 Offset: 0x1EFEA40 VA: 0x181F00440
	public static void Serialize(Stream stream, VendingMachine instance) { }

	// RVA: 0x1F006A0 Offset: 0x1EFECA0 VA: 0x181F006A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F006B0 Offset: 0x1EFECB0 VA: 0x181F006B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F00330 Offset: 0x1EFE930 VA: 0x181F00330
	public static byte[] SerializeToBytes(VendingMachine instance) { }

	// RVA: 0x1F00280 Offset: 0x1EFE880 VA: 0x181F00280
	public static void SerializeLengthDelimited(Stream stream, VendingMachine instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0x1EEB4C0 Offset: 0x1EE9AC0 VA: 0x181EEB4C0
	public static void ResetToPool(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEB5C0 Offset: 0x1EE9BC0 VA: 0x181EEB5C0
	public void ResetToPool() { }

	// RVA: 0x1EEAF70 Offset: 0x1EE9570 VA: 0x181EEAF70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE9390 Offset: 0x1EE7990 VA: 0x181EE9390
	public void CopyTo(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EE93F0 Offset: 0x1EE79F0 VA: 0x181EE93F0
	public VendingMachine.SellOrder Copy() { }

	// RVA: 0x1EEA350 Offset: 0x1EE8950 VA: 0x181EEA350
	public static VendingMachine.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x1EE9920 Offset: 0x1EE7F20 VA: 0x181EE9920
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EE99A0 Offset: 0x1EE7FA0 VA: 0x181EE99A0
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EE9E90 Offset: 0x1EE8490 VA: 0x181EE9E90
	public static VendingMachine.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1EEB100 Offset: 0x1EE9700 VA: 0x181EEB100
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEBE90 Offset: 0x1EEA490 VA: 0x181EEBE90 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEBEB0 Offset: 0x1EEA4B0 VA: 0x181EEBEB0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EEB4A0 Offset: 0x1EE9AA0 VA: 0x181EEB4A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEA730 Offset: 0x1EE8D30 VA: 0x181EEA730
	public static VendingMachine.SellOrder Deserialize(byte[] buffer, VendingMachine.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x1EEABD0 Offset: 0x1EE91D0 VA: 0x181EEABD0
	public static VendingMachine.SellOrder Deserialize(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE94A0 Offset: 0x1EE7AA0 VA: 0x181EE94A0
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE9A30 Offset: 0x1EE8030 VA: 0x181EE9A30
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EEB6C0 Offset: 0x1EE9CC0 VA: 0x181EEB6C0
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrder instance, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EEBC60 Offset: 0x1EEA260 VA: 0x181EEBC60
	public static void Serialize(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEBE80 Offset: 0x1EEA480 VA: 0x181EEBE80
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEBE90 Offset: 0x1EEA490 VA: 0x181EEBE90
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEBB50 Offset: 0x1EEA150 VA: 0x181EEBB50
	public static byte[] SerializeToBytes(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEBAA0 Offset: 0x1EEA0A0 VA: 0x181EEBAA0
	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class VendingMachine.SellOrderContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6341
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VendingMachine.SellOrder> sellOrders; // 0x18

	// Methods

	// RVA: 0x1E4AF70 Offset: 0x1E49570 VA: 0x181E4AF70
	public static void ResetToPool(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B120 Offset: 0x1E49720 VA: 0x181E4B120
	public void ResetToPool() { }

	// RVA: 0x1E4ACF0 Offset: 0x1E492F0 VA: 0x181E4ACF0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E4A050 Offset: 0x1E48650 VA: 0x181E4A050
	public void CopyTo(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4A180 Offset: 0x1E48780 VA: 0x181E4A180
	public VendingMachine.SellOrderContainer Copy() { }

	// RVA: 0x1E4A8C0 Offset: 0x1E48EC0 VA: 0x181E4A8C0
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream) { }

	// RVA: 0x1E4A2F0 Offset: 0x1E488F0 VA: 0x181E4A2F0
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4A830 Offset: 0x1E48E30 VA: 0x181E4A830
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4AAD0 Offset: 0x1E490D0 VA: 0x181E4AAD0
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1E4AF30 Offset: 0x1E49530 VA: 0x181E4AF30
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E4B940 Offset: 0x1E49F40 VA: 0x181E4B940 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E4B960 Offset: 0x1E49F60 VA: 0x181E4B960 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E4AF50 Offset: 0x1E49550 VA: 0x181E4AF50 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4ABF0 Offset: 0x1E491F0 VA: 0x181E4ABF0
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer, VendingMachine.SellOrderContainer instance, bool isDelta = False) { }

	// RVA: 0x1E4A940 Offset: 0x1E48F40 VA: 0x181E4A940
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4A370 Offset: 0x1E48970 VA: 0x181E4A370
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4A5E0 Offset: 0x1E48BE0 VA: 0x181E4A5E0
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4B2D0 Offset: 0x1E498D0 VA: 0x181E4B2D0
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrderContainer instance, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E4B700 Offset: 0x1E49D00 VA: 0x181E4B700
	public static void Serialize(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B930 Offset: 0x1E49F30 VA: 0x181E4B930
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E4B940 Offset: 0x1E49F40 VA: 0x181E4B940
	public void ToProto(Stream stream) { }

	// RVA: 0x1E4B5F0 Offset: 0x1E49BF0 VA: 0x181E4B5F0
	public static byte[] SerializeToBytes(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B500 Offset: 0x1E49B00 VA: 0x181E4B500
	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
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

	// RVA: 0xAD9F60 Offset: 0xAD8560 VA: 0x180AD9F60 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xADCAB0 Offset: 0xADB0B0 VA: 0x180ADCAB0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xADB120 Offset: 0xAD9720 VA: 0x180ADB120 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xADABE0 Offset: 0xAD91E0 VA: 0x180ADABE0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xADAB30 Offset: 0xAD9130 VA: 0x180ADAB30 Slot: 155
	public virtual void InstallDefaultSellOrders() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD9BF0 Offset: 0xAD81F0 VA: 0x180AD9BF0
	public void CLIENT_StartVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD9890 Offset: 0xAD7E90 VA: 0x180AD9890
	public void CLIENT_CancelVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD9AA0 Offset: 0xAD80A0 VA: 0x180AD9AA0
	public void CLIENT_ReceiveSellOrders(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 156
	public virtual bool ShouldShowAdminPanel() { }

	// RVA: 0xADC810 Offset: 0xADAE10 VA: 0x180ADC810 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.Description] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.Icon] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	// RVA: 0xADB0E0 Offset: 0xAD96E0 VA: 0x180ADB0E0
	public void Menu_Shop(BasePlayer player) { }

	// RVA: 0xADAEE0 Offset: 0xAD94E0 VA: 0x180ADAEE0
	public bool Menu_Shop_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.Description] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.Icon] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	// RVA: 0xADAE00 Offset: 0xAD9400 VA: 0x180ADAE00
	public void Menu_OpenAdmin(BasePlayer player) { }

	// RVA: 0xADADC0 Offset: 0xAD93C0 VA: 0x180ADADC0
	public bool Menu_OpenAdmin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.Description] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.Icon] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	// RVA: 0xADACD0 Offset: 0xAD92D0 VA: 0x180ADACD0
	public void Menu_BroadcastOn(BasePlayer player) { }

	// RVA: 0xADAD70 Offset: 0xAD9370 VA: 0x180ADAD70
	public bool Menu_Broadcast_On_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.Description] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.Icon] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	// RVA: 0xADAC80 Offset: 0xAD9280 VA: 0x180ADAC80
	public void Menu_BroadcastOff(BasePlayer player) { }

	// RVA: 0xADAD20 Offset: 0xAD9320 VA: 0x180ADAD20
	public bool Menu_Broadcast_Off_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.Description] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.Icon] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	// RVA: 0xADAEA0 Offset: 0xAD94A0 VA: 0x180ADAEA0
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0xADAE40 Offset: 0xAD9440 VA: 0x180ADAE40 Slot: 157
	public virtual bool Menu_RotateVM_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD99A0 Offset: 0xAD7FA0 VA: 0x180AD99A0
	private void CLIENT_OpenAdminMenu(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xADC4C0 Offset: 0xADAAC0 VA: 0x180ADC4C0 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 158
	protected virtual bool CanRotate() { }

	// RVA: 0x738290 Offset: 0x736890 VA: 0x180738290
	public bool IsBroadcasting() { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsInventoryEmpty() { }

	// RVA: 0x5799C0 Offset: 0x577FC0 VA: 0x1805799C0
	public bool IsVending() { }

	// RVA: 0xADC140 Offset: 0xADA740 VA: 0x180ADC140
	public bool PlayerBehind(BasePlayer player) { }

	// RVA: 0xADC300 Offset: 0xADA900 VA: 0x180ADC300
	public bool PlayerInfront(BasePlayer player) { }

	// RVA: 0xAD9F20 Offset: 0xAD8520 VA: 0x180AD9F20 Slot: 159
	public virtual bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0xADC9F0 Offset: 0xADAFF0 VA: 0x180ADC9F0
	public void .ctor() { }

	// RVA: 0xADC980 Offset: 0xADAF80 VA: 0x180ADC980
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

