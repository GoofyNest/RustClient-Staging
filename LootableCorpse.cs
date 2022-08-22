public class LootableCorpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6300
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public LootableCorpse.Private privateData; // 0x18
	public ulong playerID; // 0x20
	public string playerName; // 0x28
	public uint underwearSkin; // 0x30

	// Methods

	// RVA: 0x1F26080 Offset: 0x1F24680 VA: 0x181F26080
	public static void ResetToPool(LootableCorpse instance) { }

	// RVA: 0x1F25F80 Offset: 0x1F24580 VA: 0x181F25F80
	public void ResetToPool() { }

	// RVA: 0x1F25DD0 Offset: 0x1F243D0 VA: 0x181F25DD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F24EA0 Offset: 0x1F234A0 VA: 0x181F24EA0
	public void CopyTo(LootableCorpse instance) { }

	// RVA: 0x1F24FA0 Offset: 0x1F235A0 VA: 0x181F24FA0
	public LootableCorpse Copy() { }

	// RVA: 0x1F25990 Offset: 0x1F23F90 VA: 0x181F25990
	public static LootableCorpse Deserialize(Stream stream) { }

	// RVA: 0x1F250F0 Offset: 0x1F236F0 VA: 0x181F250F0
	public static LootableCorpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F25800 Offset: 0x1F23E00 VA: 0x181F25800
	public static LootableCorpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F25A10 Offset: 0x1F24010 VA: 0x181F25A10
	public static LootableCorpse Deserialize(byte[] buffer) { }

	// RVA: 0x1F25F40 Offset: 0x1F24540 VA: 0x181F25F40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F26890 Offset: 0x1F24E90 VA: 0x181F26890 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F268B0 Offset: 0x1F24EB0 VA: 0x181F268B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse previous) { }

	// RVA: 0x1F25F60 Offset: 0x1F24560 VA: 0x181F25F60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F25890 Offset: 0x1F23E90 VA: 0x181F25890
	public static LootableCorpse Deserialize(byte[] buffer, LootableCorpse instance, bool isDelta = False) { }

	// RVA: 0x1F25B30 Offset: 0x1F24130 VA: 0x181F25B30
	public static LootableCorpse Deserialize(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F25170 Offset: 0x1F23770 VA: 0x181F25170
	public static LootableCorpse DeserializeLengthDelimited(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F254D0 Offset: 0x1F23AD0 VA: 0x181F254D0
	public static LootableCorpse DeserializeLength(Stream stream, int length, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F26180 Offset: 0x1F24780 VA: 0x181F26180
	public static void SerializeDelta(Stream stream, LootableCorpse instance, LootableCorpse previous) { }

	// RVA: 0x1F26610 Offset: 0x1F24C10 VA: 0x181F26610
	public static void Serialize(Stream stream, LootableCorpse instance) { }

	// RVA: 0x1F26880 Offset: 0x1F24E80 VA: 0x181F26880
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F26890 Offset: 0x1F24E90 VA: 0x181F26890
	public void ToProto(Stream stream) { }

	// RVA: 0x1F26500 Offset: 0x1F24B00 VA: 0x181F26500
	public static byte[] SerializeToBytes(LootableCorpse instance) { }

	// RVA: 0x1F26450 Offset: 0x1F24A50 VA: 0x181F26450
	public static void SerializeLengthDelimited(Stream stream, LootableCorpse instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class LootableCorpse.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6301
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1F2C680 Offset: 0x1F2AC80 VA: 0x181F2C680
	public static void ResetToPool(LootableCorpse.Private instance) { }

	// RVA: 0x1F2C4D0 Offset: 0x1F2AAD0 VA: 0x181F2C4D0
	public void ResetToPool() { }

	// RVA: 0x1F2C410 Offset: 0x1F2AA10 VA: 0x181F2C410 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F2B6F0 Offset: 0x1F29CF0 VA: 0x181F2B6F0
	public void CopyTo(LootableCorpse.Private instance) { }

	// RVA: 0x1F2B880 Offset: 0x1F29E80 VA: 0x181F2B880
	public LootableCorpse.Private Copy() { }

	// RVA: 0x1F2C270 Offset: 0x1F2A870 VA: 0x181F2C270
	public static LootableCorpse.Private Deserialize(Stream stream) { }

	// RVA: 0x1F2B900 Offset: 0x1F29F00 VA: 0x181F2B900
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2BEF0 Offset: 0x1F2A4F0 VA: 0x181F2BEF0
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2C2F0 Offset: 0x1F2A8F0 VA: 0x181F2C2F0
	public static LootableCorpse.Private Deserialize(byte[] buffer) { }

	// RVA: 0x1F2C490 Offset: 0x1F2AA90 VA: 0x181F2C490
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2CDC0 Offset: 0x1F2B3C0 VA: 0x181F2CDC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2CDE0 Offset: 0x1F2B3E0 VA: 0x181F2CDE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse.Private previous) { }

	// RVA: 0x1F2C4B0 Offset: 0x1F2AAB0 VA: 0x181F2C4B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2BF80 Offset: 0x1F2A580 VA: 0x181F2BF80
	public static LootableCorpse.Private Deserialize(byte[] buffer, LootableCorpse.Private instance, bool isDelta = False) { }

	// RVA: 0x1F2C080 Offset: 0x1F2A680 VA: 0x181F2C080
	public static LootableCorpse.Private Deserialize(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2B980 Offset: 0x1F29F80 VA: 0x181F2B980
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2BC50 Offset: 0x1F2A250 VA: 0x181F2BC50
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2C830 Offset: 0x1F2AE30 VA: 0x181F2C830
	public static void SerializeDelta(Stream stream, LootableCorpse.Private instance, LootableCorpse.Private previous) { }

	// RVA: 0x1F2CBD0 Offset: 0x1F2B1D0 VA: 0x181F2CBD0
	public static void Serialize(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x1F2CDB0 Offset: 0x1F2B3B0 VA: 0x181F2CDB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2CDC0 Offset: 0x1F2B3C0 VA: 0x181F2CDC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2CAC0 Offset: 0x1F2B0C0 VA: 0x181F2CAC0
	public static byte[] SerializeToBytes(LootableCorpse.Private instance) { }

	// RVA: 0x1F2CA10 Offset: 0x1F2B010 VA: 0x181F2CA10
	public static void SerializeLengthDelimited(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class LootableCorpse : BaseCorpse, LootPanel.IHasLootPanel // TypeDefIndex: 8405
{	// Fields
	private Option __menuOption_Menu_Open; // 0x260
	public string lootPanelName; // 0x2B8
	public ulong playerSteamID; // 0x2C0
	public string _playerName; // 0x2C8

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual string playerName { get; set; }
	public Translate.Phrase LootPanelTitle { get; }
	public Translate.Phrase LootPanelName { get; }

	// Methods

	// RVA: 0x551C50 Offset: 0x550250 VA: 0x180551C50 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x551F90 Offset: 0x550590 VA: 0x180551F90 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x552570 Offset: 0x550B70 VA: 0x180552570 Slot: 146
	public virtual string get_playerName() { }

	// RVA: 0x552590 Offset: 0x550B90 VA: 0x180552590 Slot: 147
	public virtual void set_playerName(string value) { }

	// RVA: 0x552540 Offset: 0x550B40 VA: 0x180552540 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x552500 Offset: 0x550B00 VA: 0x180552500
	public Translate.Phrase get_LootPanelName() { }

	// RVA: 0x551ED0 Offset: 0x5504D0 VA: 0x180551ED0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x552430 Offset: 0x550A30 VA: 0x180552430
	private void RPC_ClientLootCorpse(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Description] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Icon] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	// RVA: 0x551F50 Offset: 0x550550 VA: 0x180551F50
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x5524B0 Offset: 0x550AB0 VA: 0x1805524B0
	public void .ctor() { }

}

