public class LootableCorpse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6300
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public LootableCorpse.Private privateData; // 0x18
	public ulong playerID; // 0x20
	public string playerName; // 0x28
	public uint underwearSkin; // 0x30

	// Methods

	// RVA: 0x1F268A0 Offset: 0x1F24EA0 VA: 0x181F268A0
	public static void ResetToPool(LootableCorpse instance) { }

	// RVA: 0x1F267A0 Offset: 0x1F24DA0 VA: 0x181F267A0
	public void ResetToPool() { }

	// RVA: 0x1F265F0 Offset: 0x1F24BF0 VA: 0x181F265F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F256C0 Offset: 0x1F23CC0 VA: 0x181F256C0
	public void CopyTo(LootableCorpse instance) { }

	// RVA: 0x1F257C0 Offset: 0x1F23DC0 VA: 0x181F257C0
	public LootableCorpse Copy() { }

	// RVA: 0x1F261B0 Offset: 0x1F247B0 VA: 0x181F261B0
	public static LootableCorpse Deserialize(Stream stream) { }

	// RVA: 0x1F25910 Offset: 0x1F23F10 VA: 0x181F25910
	public static LootableCorpse DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F26020 Offset: 0x1F24620 VA: 0x181F26020
	public static LootableCorpse DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F26230 Offset: 0x1F24830 VA: 0x181F26230
	public static LootableCorpse Deserialize(byte[] buffer) { }

	// RVA: 0x1F26760 Offset: 0x1F24D60 VA: 0x181F26760
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F270B0 Offset: 0x1F256B0 VA: 0x181F270B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F270D0 Offset: 0x1F256D0 VA: 0x181F270D0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse previous) { }

	// RVA: 0x1F26780 Offset: 0x1F24D80 VA: 0x181F26780 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F260B0 Offset: 0x1F246B0 VA: 0x181F260B0
	public static LootableCorpse Deserialize(byte[] buffer, LootableCorpse instance, bool isDelta = False) { }

	// RVA: 0x1F26350 Offset: 0x1F24950 VA: 0x181F26350
	public static LootableCorpse Deserialize(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F25990 Offset: 0x1F23F90 VA: 0x181F25990
	public static LootableCorpse DeserializeLengthDelimited(Stream stream, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F25CF0 Offset: 0x1F242F0 VA: 0x181F25CF0
	public static LootableCorpse DeserializeLength(Stream stream, int length, LootableCorpse instance, bool isDelta) { }

	// RVA: 0x1F269A0 Offset: 0x1F24FA0 VA: 0x181F269A0
	public static void SerializeDelta(Stream stream, LootableCorpse instance, LootableCorpse previous) { }

	// RVA: 0x1F26E30 Offset: 0x1F25430 VA: 0x181F26E30
	public static void Serialize(Stream stream, LootableCorpse instance) { }

	// RVA: 0x1F270A0 Offset: 0x1F256A0 VA: 0x181F270A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F270B0 Offset: 0x1F256B0 VA: 0x181F270B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F26D20 Offset: 0x1F25320 VA: 0x181F26D20
	public static byte[] SerializeToBytes(LootableCorpse instance) { }

	// RVA: 0x1F26C70 Offset: 0x1F25270 VA: 0x181F26C70
	public static void SerializeLengthDelimited(Stream stream, LootableCorpse instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
	public void .ctor() { }

}

public class LootableCorpse.Private : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6301
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<ItemContainer> container; // 0x18

	// Methods

	// RVA: 0x1F2CEA0 Offset: 0x1F2B4A0 VA: 0x181F2CEA0
	public static void ResetToPool(LootableCorpse.Private instance) { }

	// RVA: 0x1F2CCF0 Offset: 0x1F2B2F0 VA: 0x181F2CCF0
	public void ResetToPool() { }

	// RVA: 0x1F2CC30 Offset: 0x1F2B230 VA: 0x181F2CC30 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F2BF10 Offset: 0x1F2A510 VA: 0x181F2BF10
	public void CopyTo(LootableCorpse.Private instance) { }

	// RVA: 0x1F2C0A0 Offset: 0x1F2A6A0 VA: 0x181F2C0A0
	public LootableCorpse.Private Copy() { }

	// RVA: 0x1F2CA90 Offset: 0x1F2B090 VA: 0x181F2CA90
	public static LootableCorpse.Private Deserialize(Stream stream) { }

	// RVA: 0x1F2C120 Offset: 0x1F2A720 VA: 0x181F2C120
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F2C710 Offset: 0x1F2AD10 VA: 0x181F2C710
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F2CB10 Offset: 0x1F2B110 VA: 0x181F2CB10
	public static LootableCorpse.Private Deserialize(byte[] buffer) { }

	// RVA: 0x1F2CCB0 Offset: 0x1F2B2B0 VA: 0x181F2CCB0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F2D5E0 Offset: 0x1F2BBE0 VA: 0x181F2D5E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F2D600 Offset: 0x1F2BC00 VA: 0x181F2D600 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, LootableCorpse.Private previous) { }

	// RVA: 0x1F2CCD0 Offset: 0x1F2B2D0 VA: 0x181F2CCD0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F2C7A0 Offset: 0x1F2ADA0 VA: 0x181F2C7A0
	public static LootableCorpse.Private Deserialize(byte[] buffer, LootableCorpse.Private instance, bool isDelta = False) { }

	// RVA: 0x1F2C8A0 Offset: 0x1F2AEA0 VA: 0x181F2C8A0
	public static LootableCorpse.Private Deserialize(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2C1A0 Offset: 0x1F2A7A0 VA: 0x181F2C1A0
	public static LootableCorpse.Private DeserializeLengthDelimited(Stream stream, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2C470 Offset: 0x1F2AA70 VA: 0x181F2C470
	public static LootableCorpse.Private DeserializeLength(Stream stream, int length, LootableCorpse.Private instance, bool isDelta) { }

	// RVA: 0x1F2D050 Offset: 0x1F2B650 VA: 0x181F2D050
	public static void SerializeDelta(Stream stream, LootableCorpse.Private instance, LootableCorpse.Private previous) { }

	// RVA: 0x1F2D3F0 Offset: 0x1F2B9F0 VA: 0x181F2D3F0
	public static void Serialize(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x1F2D5D0 Offset: 0x1F2BBD0 VA: 0x181F2D5D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F2D5E0 Offset: 0x1F2BBE0 VA: 0x181F2D5E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F2D2E0 Offset: 0x1F2B8E0 VA: 0x181F2D2E0
	public static byte[] SerializeToBytes(LootableCorpse.Private instance) { }

	// RVA: 0x1F2D230 Offset: 0x1F2B830 VA: 0x181F2D230
	public static void SerializeLengthDelimited(Stream stream, LootableCorpse.Private instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x551BE0 Offset: 0x5501E0 VA: 0x180551BE0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x551F20 Offset: 0x550520 VA: 0x180551F20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x552500 Offset: 0x550B00 VA: 0x180552500 Slot: 146
	public virtual string get_playerName() { }

	// RVA: 0x552520 Offset: 0x550B20 VA: 0x180552520 Slot: 147
	public virtual void set_playerName(string value) { }

	// RVA: 0x5524D0 Offset: 0x550AD0 VA: 0x1805524D0 Slot: 145
	public Translate.Phrase get_LootPanelTitle() { }

	// RVA: 0x552490 Offset: 0x550A90 VA: 0x180552490
	public Translate.Phrase get_LootPanelName() { }

	// RVA: 0x551E60 Offset: 0x550460 VA: 0x180551E60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x5523C0 Offset: 0x5509C0 VA: 0x1805523C0
	private void RPC_ClientLootCorpse(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.Menu] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Description] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	[BaseEntity.Menu.Icon] // RVA: 0xDA1C0 Offset: 0xD95C0 VA: 0x1800DA1C0
	// RVA: 0x551EE0 Offset: 0x5504E0 VA: 0x180551EE0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x552440 Offset: 0x550A40 VA: 0x180552440
	public void .ctor() { }

}

