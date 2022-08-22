public class LootableCorpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6300
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public LootableCorpse.Private privateData; // 0x18
	public ulong playerID; // 0x20
	public string playerName; // 0x28
	public uint underwearSkin; // 0x30

	// Methods

	// RVA: 0x1F25DC0 Offset: 0x1F243C0 VA: 0x181F25DC0
	public static void ResetToPool(LootableCorpse instance) { }

	// RVA: 0x1F25CC0 Offset: 0x1F242C0 VA: 0x181F25CC0
	public void ResetToPool() { }

	// RVA: 0x1F25B10 Offset: 0x1F24110 VA: 0x181F25B10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F24BE0 Offset: 0x1F231E0 VA: 0x181F24BE0
	public void CopyTo(LootableCorpse instance) { }

	// RVA: 0x1F24CE0 Offset: 0x1F232E0 VA: 0x181F24CE0
	public LootableCorpse Copy() { }

	// RVA: 0x1F256D0 Offset: 0x1F23CD0 VA: 0x181F256D0
	public static LootableCorpse Deserialize(Stream stream) { }

	// RVA: 0x1F24E30 Offset: 0x1F23430 VA: 0x181F24E30
	public static LootableCorpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F25540 Offset: 0x1F23B40 VA: 0x181F25540
	public static LootableCorpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F25750 Offset: 0x1F23D50 VA: 0x181F25750
	public static LootableCorpse Deserialize(byte[] buffer) { }

	// RVA: 0x1F25C80 Offset: 0x1F24280 VA: 0x181F25C80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F265D0 Offset: 0x1F24BD0 VA: 0x181F265D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F265F0 Offset: 0x1F24BF0 VA: 0x181F265F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse previous) { }

	// RVA: 0x1F25CA0 Offset: 0x1F242A0 VA: 0x181F25CA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F255D0 Offset: 0x1F23BD0 VA: 0x181F255D0
	public static LootableCorpse Deserialize(byte[] buffer, LootableCorpse instance, bool isDelta = False) { }

	// RVA: 0x1F25870 Offset: 0x1F23E70 VA: 0x181F25870
	public static LootableCorpse Deserialize(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F24EB0 Offset: 0x1F234B0 VA: 0x181F24EB0
	public static LootableCorpse DeserializeLengthDelimited(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F25210 Offset: 0x1F23810 VA: 0x181F25210
	public static LootableCorpse DeserializeLength(Stream stream, int length, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F25EC0 Offset: 0x1F244C0 VA: 0x181F25EC0
	public static void SerializeDelta(Stream stream, LootableCorpse instance, LootableCorpse previous) { }

	// RVA: 0x1F26350 Offset: 0x1F24950 VA: 0x181F26350
	public static void Serialize(Stream stream, LootableCorpse instance) { }

	// RVA: 0x1F265C0 Offset: 0x1F24BC0 VA: 0x181F265C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F265D0 Offset: 0x1F24BD0 VA: 0x181F265D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F26240 Offset: 0x1F24840 VA: 0x181F26240
	public static byte[] SerializeToBytes(LootableCorpse instance) { }

	// RVA: 0x1F26190 Offset: 0x1F24790 VA: 0x181F26190
	public static void SerializeLengthDelimited(Stream stream, LootableCorpse instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
	public void .ctor() { }

}

public class LootableCorpse.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6301
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1F2C3C0 Offset: 0x1F2A9C0 VA: 0x181F2C3C0
	public static void ResetToPool(LootableCorpse.Private instance) { }

	// RVA: 0x1F2C210 Offset: 0x1F2A810 VA: 0x181F2C210
	public void ResetToPool() { }

	// RVA: 0x1F2C150 Offset: 0x1F2A750 VA: 0x181F2C150 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F2B430 Offset: 0x1F29A30 VA: 0x181F2B430
	public void CopyTo(LootableCorpse.Private instance) { }

	// RVA: 0x1F2B5C0 Offset: 0x1F29BC0 VA: 0x181F2B5C0
	public LootableCorpse.Private Copy() { }

	// RVA: 0x1F2BFB0 Offset: 0x1F2A5B0 VA: 0x181F2BFB0
	public static LootableCorpse.Private Deserialize(Stream stream) { }

	// RVA: 0x1F2B640 Offset: 0x1F29C40 VA: 0x181F2B640
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2BC30 Offset: 0x1F2A230 VA: 0x181F2BC30
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2C030 Offset: 0x1F2A630 VA: 0x181F2C030
	public static LootableCorpse.Private Deserialize(byte[] buffer) { }

	// RVA: 0x1F2C1D0 Offset: 0x1F2A7D0 VA: 0x181F2C1D0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2CB00 Offset: 0x1F2B100 VA: 0x181F2CB00 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2CB20 Offset: 0x1F2B120 VA: 0x181F2CB20 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse.Private previous) { }

	// RVA: 0x1F2C1F0 Offset: 0x1F2A7F0 VA: 0x181F2C1F0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2BCC0 Offset: 0x1F2A2C0 VA: 0x181F2BCC0
	public static LootableCorpse.Private Deserialize(byte[] buffer, LootableCorpse.Private instance, bool isDelta = False) { }

	// RVA: 0x1F2BDC0 Offset: 0x1F2A3C0 VA: 0x181F2BDC0
	public static LootableCorpse.Private Deserialize(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2B6C0 Offset: 0x1F29CC0 VA: 0x181F2B6C0
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2B990 Offset: 0x1F29F90 VA: 0x181F2B990
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2C570 Offset: 0x1F2AB70 VA: 0x181F2C570
	public static void SerializeDelta(Stream stream, LootableCorpse.Private instance, LootableCorpse.Private previous) { }

	// RVA: 0x1F2C910 Offset: 0x1F2AF10 VA: 0x181F2C910
	public static void Serialize(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x1F2CAF0 Offset: 0x1F2B0F0 VA: 0x181F2CAF0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2CB00 Offset: 0x1F2B100 VA: 0x181F2CB00
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2C800 Offset: 0x1F2AE00 VA: 0x181F2C800
	public static byte[] SerializeToBytes(LootableCorpse.Private instance) { }

	// RVA: 0x1F2C750 Offset: 0x1F2AD50 VA: 0x181F2C750
	public static void SerializeLengthDelimited(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

