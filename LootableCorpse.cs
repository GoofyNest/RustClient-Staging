public class LootableCorpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6300
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public LootableCorpse.Private privateData; // 0x18
	public ulong playerID; // 0x20
	public string playerName; // 0x28
	public uint underwearSkin; // 0x30

	// Methods

	// RVA: 0x1F25F80 Offset: 0x1F24580 VA: 0x181F25F80
	public static void ResetToPool(LootableCorpse instance) { }

	// RVA: 0x1F25E80 Offset: 0x1F24480 VA: 0x181F25E80
	public void ResetToPool() { }

	// RVA: 0x1F25CD0 Offset: 0x1F242D0 VA: 0x181F25CD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F24DA0 Offset: 0x1F233A0 VA: 0x181F24DA0
	public void CopyTo(LootableCorpse instance) { }

	// RVA: 0x1F24EA0 Offset: 0x1F234A0 VA: 0x181F24EA0
	public LootableCorpse Copy() { }

	// RVA: 0x1F25890 Offset: 0x1F23E90 VA: 0x181F25890
	public static LootableCorpse Deserialize(Stream stream) { }

	// RVA: 0x1F24FF0 Offset: 0x1F235F0 VA: 0x181F24FF0
	public static LootableCorpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F25700 Offset: 0x1F23D00 VA: 0x181F25700
	public static LootableCorpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F25910 Offset: 0x1F23F10 VA: 0x181F25910
	public static LootableCorpse Deserialize(byte[] buffer) { }

	// RVA: 0x1F25E40 Offset: 0x1F24440 VA: 0x181F25E40
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F26790 Offset: 0x1F24D90 VA: 0x181F26790 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F267B0 Offset: 0x1F24DB0 VA: 0x181F267B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse previous) { }

	// RVA: 0x1F25E60 Offset: 0x1F24460 VA: 0x181F25E60 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F25790 Offset: 0x1F23D90 VA: 0x181F25790
	public static LootableCorpse Deserialize(byte[] buffer, LootableCorpse instance, bool isDelta = False) { }

	// RVA: 0x1F25A30 Offset: 0x1F24030 VA: 0x181F25A30
	public static LootableCorpse Deserialize(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F25070 Offset: 0x1F23670 VA: 0x181F25070
	public static LootableCorpse DeserializeLengthDelimited(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F253D0 Offset: 0x1F239D0 VA: 0x181F253D0
	public static LootableCorpse DeserializeLength(Stream stream, int length, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F26080 Offset: 0x1F24680 VA: 0x181F26080
	public static void SerializeDelta(Stream stream, LootableCorpse instance, LootableCorpse previous) { }

	// RVA: 0x1F26510 Offset: 0x1F24B10 VA: 0x181F26510
	public static void Serialize(Stream stream, LootableCorpse instance) { }

	// RVA: 0x1F26780 Offset: 0x1F24D80 VA: 0x181F26780
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F26790 Offset: 0x1F24D90 VA: 0x181F26790
	public void ToProto(Stream stream) { }

	// RVA: 0x1F26400 Offset: 0x1F24A00 VA: 0x181F26400
	public static byte[] SerializeToBytes(LootableCorpse instance) { }

	// RVA: 0x1F26350 Offset: 0x1F24950 VA: 0x181F26350
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

	// RVA: 0x1F2C580 Offset: 0x1F2AB80 VA: 0x181F2C580
	public static void ResetToPool(LootableCorpse.Private instance) { }

	// RVA: 0x1F2C3D0 Offset: 0x1F2A9D0 VA: 0x181F2C3D0
	public void ResetToPool() { }

	// RVA: 0x1F2C310 Offset: 0x1F2A910 VA: 0x181F2C310 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F2B5F0 Offset: 0x1F29BF0 VA: 0x181F2B5F0
	public void CopyTo(LootableCorpse.Private instance) { }

	// RVA: 0x1F2B780 Offset: 0x1F29D80 VA: 0x181F2B780
	public LootableCorpse.Private Copy() { }

	// RVA: 0x1F2C170 Offset: 0x1F2A770 VA: 0x181F2C170
	public static LootableCorpse.Private Deserialize(Stream stream) { }

	// RVA: 0x1F2B800 Offset: 0x1F29E00 VA: 0x181F2B800
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2BDF0 Offset: 0x1F2A3F0 VA: 0x181F2BDF0
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2C1F0 Offset: 0x1F2A7F0 VA: 0x181F2C1F0
	public static LootableCorpse.Private Deserialize(byte[] buffer) { }

	// RVA: 0x1F2C390 Offset: 0x1F2A990 VA: 0x181F2C390
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2CCC0 Offset: 0x1F2B2C0 VA: 0x181F2CCC0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2CCE0 Offset: 0x1F2B2E0 VA: 0x181F2CCE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse.Private previous) { }

	// RVA: 0x1F2C3B0 Offset: 0x1F2A9B0 VA: 0x181F2C3B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2BE80 Offset: 0x1F2A480 VA: 0x181F2BE80
	public static LootableCorpse.Private Deserialize(byte[] buffer, LootableCorpse.Private instance, bool isDelta = False) { }

	// RVA: 0x1F2BF80 Offset: 0x1F2A580 VA: 0x181F2BF80
	public static LootableCorpse.Private Deserialize(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2B880 Offset: 0x1F29E80 VA: 0x181F2B880
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2BB50 Offset: 0x1F2A150 VA: 0x181F2BB50
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2C730 Offset: 0x1F2AD30 VA: 0x181F2C730
	public static void SerializeDelta(Stream stream, LootableCorpse.Private instance, LootableCorpse.Private previous) { }

	// RVA: 0x1F2CAD0 Offset: 0x1F2B0D0 VA: 0x181F2CAD0
	public static void Serialize(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x1F2CCB0 Offset: 0x1F2B2B0 VA: 0x181F2CCB0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2CCC0 Offset: 0x1F2B2C0 VA: 0x181F2CCC0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2C9C0 Offset: 0x1F2AFC0 VA: 0x181F2C9C0
	public static byte[] SerializeToBytes(LootableCorpse.Private instance) { }

	// RVA: 0x1F2C910 Offset: 0x1F2AF10 VA: 0x181F2C910
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

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x552430 Offset: 0x550A30 VA: 0x180552430
	private void RPC_ClientLootCorpse(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xDA190 Offset: 0xD9590 VA: 0x1800DA190
	[BaseEntity.Menu.Description] // RVA: 0xDA190 Offset: 0xD9590 VA: 0x1800DA190
	[BaseEntity.Menu.Icon] // RVA: 0xDA190 Offset: 0xD9590 VA: 0x1800DA190
	// RVA: 0x551F50 Offset: 0x550550 VA: 0x180551F50
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x5524B0 Offset: 0x550AB0 VA: 0x1805524B0
	public void .ctor() { }

}

