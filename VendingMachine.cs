public class VendingMachine : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6339
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public VendingMachine.SellOrderContainer sellOrderContainer; // 0x18
	public string shopName; // 0x20
	public int vmoIndex; // 0x28
	public uint networkID; // 0x2C

	// Methods

	// RVA: 0x1F006D0 Offset: 0x1EFECD0 VA: 0x181F006D0
	public static void ResetToPool(VendingMachine instance) { }

	// RVA: 0x1F005D0 Offset: 0x1EFEBD0 VA: 0x181F005D0
	public void ResetToPool() { }

	// RVA: 0x1F00210 Offset: 0x1EFE810 VA: 0x181F00210 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EFEEF0 Offset: 0x1EFD4F0 VA: 0x181EFEEF0
	public void CopyTo(VendingMachine instance) { }

	// RVA: 0x1EFEF90 Offset: 0x1EFD590 VA: 0x181EFEF90
	public VendingMachine Copy() { }

	// RVA: 0x1EFFA90 Offset: 0x1EFE090 VA: 0x181EFFA90
	public static VendingMachine Deserialize(Stream stream) { }

	// RVA: 0x1EFF380 Offset: 0x1EFD980 VA: 0x181EFF380
	public static VendingMachine DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EFF6E0 Offset: 0x1EFDCE0 VA: 0x181EFF6E0
	public static VendingMachine DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EFF770 Offset: 0x1EFDD70 VA: 0x181EFF770
	public static VendingMachine Deserialize(byte[] buffer) { }

	// RVA: 0x1F00380 Offset: 0x1EFE980 VA: 0x181F00380
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F00ED0 Offset: 0x1EFF4D0 VA: 0x181F00ED0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F00EF0 Offset: 0x1EFF4F0 VA: 0x181F00EF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine previous) { }

	// RVA: 0x1F005B0 Offset: 0x1EFEBB0 VA: 0x181F005B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EFFF20 Offset: 0x1EFE520 VA: 0x181EFFF20
	public static VendingMachine Deserialize(byte[] buffer, VendingMachine instance, bool isDelta = False) { }

	// RVA: 0x1EFFCF0 Offset: 0x1EFE2F0 VA: 0x181EFFCF0
	public static VendingMachine Deserialize(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFF070 Offset: 0x1EFD670 VA: 0x181EFF070
	public static VendingMachine DeserializeLengthDelimited(Stream stream, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1EFF400 Offset: 0x1EFDA00 VA: 0x181EFF400
	public static VendingMachine DeserializeLength(Stream stream, int length, VendingMachine instance, bool isDelta) { }

	// RVA: 0x1F007D0 Offset: 0x1EFEDD0 VA: 0x181F007D0
	public static void SerializeDelta(Stream stream, VendingMachine instance, VendingMachine previous) { }

	// RVA: 0x1F00C60 Offset: 0x1EFF260 VA: 0x181F00C60
	public static void Serialize(Stream stream, VendingMachine instance) { }

	// RVA: 0x1F00EC0 Offset: 0x1EFF4C0 VA: 0x181F00EC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F00ED0 Offset: 0x1EFF4D0 VA: 0x181F00ED0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F00B50 Offset: 0x1EFF150 VA: 0x181F00B50
	public static byte[] SerializeToBytes(VendingMachine instance) { }

	// RVA: 0x1F00AA0 Offset: 0x1EFF0A0 VA: 0x181F00AA0
	public static void SerializeLengthDelimited(Stream stream, VendingMachine instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x1EEBCE0 Offset: 0x1EEA2E0 VA: 0x181EEBCE0
	public static void ResetToPool(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEBDE0 Offset: 0x1EEA3E0 VA: 0x181EEBDE0
	public void ResetToPool() { }

	// RVA: 0x1EEB790 Offset: 0x1EE9D90 VA: 0x181EEB790 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1EE9BB0 Offset: 0x1EE81B0 VA: 0x181EE9BB0
	public void CopyTo(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EE9C10 Offset: 0x1EE8210 VA: 0x181EE9C10
	public VendingMachine.SellOrder Copy() { }

	// RVA: 0x1EEAB70 Offset: 0x1EE9170 VA: 0x181EEAB70
	public static VendingMachine.SellOrder Deserialize(Stream stream) { }

	// RVA: 0x1EEA140 Offset: 0x1EE8740 VA: 0x181EEA140
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1EEA1C0 Offset: 0x1EE87C0 VA: 0x181EEA1C0
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1EEA6B0 Offset: 0x1EE8CB0 VA: 0x181EEA6B0
	public static VendingMachine.SellOrder Deserialize(byte[] buffer) { }

	// RVA: 0x1EEB920 Offset: 0x1EE9F20 VA: 0x181EEB920
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1EEC6B0 Offset: 0x1EEACB0 VA: 0x181EEC6B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1EEC6D0 Offset: 0x1EEACD0 VA: 0x181EEC6D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EEBCC0 Offset: 0x1EEA2C0 VA: 0x181EEBCC0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1EEAF50 Offset: 0x1EE9550 VA: 0x181EEAF50
	public static VendingMachine.SellOrder Deserialize(byte[] buffer, VendingMachine.SellOrder instance, bool isDelta = False) { }

	// RVA: 0x1EEB3F0 Offset: 0x1EE99F0 VA: 0x181EEB3F0
	public static VendingMachine.SellOrder Deserialize(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EE9CC0 Offset: 0x1EE82C0 VA: 0x181EE9CC0
	public static VendingMachine.SellOrder DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EEA250 Offset: 0x1EE8850 VA: 0x181EEA250
	public static VendingMachine.SellOrder DeserializeLength(Stream stream, int length, VendingMachine.SellOrder instance, bool isDelta) { }

	// RVA: 0x1EEBEE0 Offset: 0x1EEA4E0 VA: 0x181EEBEE0
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrder instance, VendingMachine.SellOrder previous) { }

	// RVA: 0x1EEC480 Offset: 0x1EEAA80 VA: 0x181EEC480
	public static void Serialize(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEC6A0 Offset: 0x1EEACA0 VA: 0x181EEC6A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1EEC6B0 Offset: 0x1EEACB0 VA: 0x181EEC6B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1EEC370 Offset: 0x1EEA970 VA: 0x181EEC370
	public static byte[] SerializeToBytes(VendingMachine.SellOrder instance) { }

	// RVA: 0x1EEC2C0 Offset: 0x1EEA8C0 VA: 0x181EEC2C0
	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrder instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class VendingMachine.SellOrderContainer : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6341
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<VendingMachine.SellOrder> sellOrders; // 0x18

	// Methods

	// RVA: 0x1E4B790 Offset: 0x1E49D90 VA: 0x181E4B790
	public static void ResetToPool(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4B940 Offset: 0x1E49F40 VA: 0x181E4B940
	public void ResetToPool() { }

	// RVA: 0x1E4B510 Offset: 0x1E49B10 VA: 0x181E4B510 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E4A870 Offset: 0x1E48E70 VA: 0x181E4A870
	public void CopyTo(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4A9A0 Offset: 0x1E48FA0 VA: 0x181E4A9A0
	public VendingMachine.SellOrderContainer Copy() { }

	// RVA: 0x1E4B0E0 Offset: 0x1E496E0 VA: 0x181E4B0E0
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream) { }

	// RVA: 0x1E4AB10 Offset: 0x1E49110 VA: 0x181E4AB10
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E4B050 Offset: 0x1E49650 VA: 0x181E4B050
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E4B2F0 Offset: 0x1E498F0 VA: 0x181E4B2F0
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer) { }

	// RVA: 0x1E4B750 Offset: 0x1E49D50 VA: 0x181E4B750
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E4C160 Offset: 0x1E4A760 VA: 0x181E4C160 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E4C180 Offset: 0x1E4A780 VA: 0x181E4C180 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E4B770 Offset: 0x1E49D70 VA: 0x181E4B770 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E4B410 Offset: 0x1E49A10 VA: 0x181E4B410
	public static VendingMachine.SellOrderContainer Deserialize(byte[] buffer, VendingMachine.SellOrderContainer instance, bool isDelta = False) { }

	// RVA: 0x1E4B160 Offset: 0x1E49760 VA: 0x181E4B160
	public static VendingMachine.SellOrderContainer Deserialize(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4AB90 Offset: 0x1E49190 VA: 0x181E4AB90
	public static VendingMachine.SellOrderContainer DeserializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4AE00 Offset: 0x1E49400 VA: 0x181E4AE00
	public static VendingMachine.SellOrderContainer DeserializeLength(Stream stream, int length, VendingMachine.SellOrderContainer instance, bool isDelta) { }

	// RVA: 0x1E4BAF0 Offset: 0x1E4A0F0 VA: 0x181E4BAF0
	public static void SerializeDelta(Stream stream, VendingMachine.SellOrderContainer instance, VendingMachine.SellOrderContainer previous) { }

	// RVA: 0x1E4BF20 Offset: 0x1E4A520 VA: 0x181E4BF20
	public static void Serialize(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4C150 Offset: 0x1E4A750 VA: 0x181E4C150
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E4C160 Offset: 0x1E4A760 VA: 0x181E4C160
	public void ToProto(Stream stream) { }

	// RVA: 0x1E4BE10 Offset: 0x1E4A410 VA: 0x181E4BE10
	public static byte[] SerializeToBytes(VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x1E4BD20 Offset: 0x1E4A320 VA: 0x181E4BD20
	public static void SerializeLengthDelimited(Stream stream, VendingMachine.SellOrderContainer instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0xADA430 Offset: 0xAD8A30 VA: 0x180ADA430 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xADCF80 Offset: 0xADB580 VA: 0x180ADCF80 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xADB5F0 Offset: 0xAD9BF0 VA: 0x180ADB5F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xADB0B0 Offset: 0xAD96B0 VA: 0x180ADB0B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xADB000 Offset: 0xAD9600 VA: 0x180ADB000 Slot: 155
	public virtual void InstallDefaultSellOrders() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xADA0C0 Offset: 0xAD86C0 VA: 0x180ADA0C0
	public void CLIENT_StartVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD9D60 Offset: 0xAD8360 VA: 0x180AD9D60
	public void CLIENT_CancelVendingSounds(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD9F70 Offset: 0xAD8570 VA: 0x180AD9F70
	public void CLIENT_ReceiveSellOrders(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 156
	public virtual bool ShouldShowAdminPanel() { }

	// RVA: 0xADCCE0 Offset: 0xADB2E0 VA: 0x180ADCCE0 Slot: 153
	public override bool ShouldShowLootMenus() { }

	[BaseEntity.Menu] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.Description] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.Icon] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9ABD0 Offset: 0x99FD0 VA: 0x18009ABD0
	// RVA: 0xADB5B0 Offset: 0xAD9BB0 VA: 0x180ADB5B0
	public void Menu_Shop(BasePlayer player) { }

	// RVA: 0xADB3B0 Offset: 0xAD99B0 VA: 0x180ADB3B0
	public bool Menu_Shop_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.Description] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.Icon] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9ADD0 Offset: 0x9A1D0 VA: 0x18009ADD0
	// RVA: 0xADB2D0 Offset: 0xAD98D0 VA: 0x180ADB2D0
	public void Menu_OpenAdmin(BasePlayer player) { }

	// RVA: 0xADB290 Offset: 0xAD9890 VA: 0x180ADB290
	public bool Menu_OpenAdmin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.Description] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.Icon] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B070 Offset: 0x9A470 VA: 0x18009B070
	// RVA: 0xADB1A0 Offset: 0xAD97A0 VA: 0x180ADB1A0
	public void Menu_BroadcastOn(BasePlayer player) { }

	// RVA: 0xADB240 Offset: 0xAD9840 VA: 0x180ADB240
	public bool Menu_Broadcast_On_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.Description] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.Icon] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B330 Offset: 0x9A730 VA: 0x18009B330
	// RVA: 0xADB150 Offset: 0xAD9750 VA: 0x180ADB150
	public void Menu_BroadcastOff(BasePlayer player) { }

	// RVA: 0xADB1F0 Offset: 0xAD97F0 VA: 0x180ADB1F0
	public bool Menu_Broadcast_Off_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.Description] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.Icon] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x9B5E0 Offset: 0x9A9E0 VA: 0x18009B5E0
	// RVA: 0xADB370 Offset: 0xAD9970 VA: 0x180ADB370
	public void Menu_RotateVM(BasePlayer player) { }

	// RVA: 0xADB310 Offset: 0xAD9910 VA: 0x180ADB310 Slot: 157
	public virtual bool Menu_RotateVM_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xAD9E70 Offset: 0xAD8470 VA: 0x180AD9E70
	private void CLIENT_OpenAdminMenu(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xADC990 Offset: 0xADAF90 VA: 0x180ADC990 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 158
	protected virtual bool CanRotate() { }

	// RVA: 0x7381E0 Offset: 0x7367E0 VA: 0x1807381E0
	public bool IsBroadcasting() { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsInventoryEmpty() { }

	// RVA: 0x579950 Offset: 0x577F50 VA: 0x180579950
	public bool IsVending() { }

	// RVA: 0xADC610 Offset: 0xADAC10 VA: 0x180ADC610
	public bool PlayerBehind(BasePlayer player) { }

	// RVA: 0xADC7D0 Offset: 0xADADD0 VA: 0x180ADC7D0
	public bool PlayerInfront(BasePlayer player) { }

	// RVA: 0xADA3F0 Offset: 0xAD89F0 VA: 0x180ADA3F0 Slot: 159
	public virtual bool CanPlayerAdmin(BasePlayer player) { }

	// RVA: 0xADCEC0 Offset: 0xADB4C0 VA: 0x180ADCEC0
	public void .ctor() { }

	// RVA: 0xADCE50 Offset: 0xADB450 VA: 0x180ADCE50
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

