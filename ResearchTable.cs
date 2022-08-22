public class ResearchTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6321
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float researchTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E02F40 Offset: 0x1E01540 VA: 0x181E02F40
	public static void ResetToPool(ResearchTable instance) { }

	// RVA: 0x1E02EC0 Offset: 0x1E014C0 VA: 0x181E02EC0
	public void ResetToPool() { }

	// RVA: 0x1E02D90 Offset: 0x1E01390 VA: 0x181E02D90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5DC0 Offset: 0x10A43C0 VA: 0x1810A5DC0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5DF0 Offset: 0x10A43F0 VA: 0x1810A5DF0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE790 Offset: 0x1BFCD90 VA: 0x181BFE790
	public void CopyTo(ResearchTable instance) { }

	// RVA: 0x1E02400 Offset: 0x1E00A00 VA: 0x181E02400
	public ResearchTable Copy() { }

	// RVA: 0x1E02C10 Offset: 0x1E01210 VA: 0x181E02C10
	public static ResearchTable Deserialize(Stream stream) { }

	// RVA: 0x1E02470 Offset: 0x1E00A70 VA: 0x181E02470
	public static ResearchTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E02910 Offset: 0x1E00F10 VA: 0x181E02910
	public static ResearchTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E029A0 Offset: 0x1E00FA0 VA: 0x181E029A0
	public static ResearchTable Deserialize(byte[] buffer) { }

	// RVA: 0x1E02E80 Offset: 0x1E01480 VA: 0x181E02E80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E03390 Offset: 0x1E01990 VA: 0x181E03390 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E033B0 Offset: 0x1E019B0 VA: 0x181E033B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResearchTable previous) { }

	// RVA: 0x1E02EA0 Offset: 0x1E014A0 VA: 0x181E02EA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E02C90 Offset: 0x1E01290 VA: 0x181E02C90
	public static ResearchTable Deserialize(byte[] buffer, ResearchTable instance, bool isDelta = False) { }

	// RVA: 0x1E02AC0 Offset: 0x1E010C0 VA: 0x181E02AC0
	public static ResearchTable Deserialize(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E024F0 Offset: 0x1E00AF0 VA: 0x181E024F0
	public static ResearchTable DeserializeLengthDelimited(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02710 Offset: 0x1E00D10 VA: 0x181E02710
	public static ResearchTable DeserializeLength(Stream stream, int length, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02FC0 Offset: 0x1E015C0 VA: 0x181E02FC0
	public static void SerializeDelta(Stream stream, ResearchTable instance, ResearchTable previous) { }

	// RVA: 0x1E032A0 Offset: 0x1E018A0 VA: 0x181E032A0
	public static void Serialize(Stream stream, ResearchTable instance) { }

	// RVA: 0x1E03380 Offset: 0x1E01980 VA: 0x181E03380
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E03390 Offset: 0x1E01990 VA: 0x181E03390
	public void ToProto(Stream stream) { }

	// RVA: 0x1E03190 Offset: 0x1E01790 VA: 0x181E03190
	public static byte[] SerializeToBytes(ResearchTable instance) { }

	// RVA: 0x1E030E0 Offset: 0x1E016E0 VA: 0x181E030E0
	public static void SerializeLengthDelimited(Stream stream, ResearchTable instance) { }

	// RVA: 0x1020D40 Offset: 0x101F340 VA: 0x181020D40
	public void .ctor() { }

}

public class ResearchTable : StorageContainer // TypeDefIndex: 8634
{	// Fields
	public float researchFinishedTime; // 0x3D0
	public float researchCostFraction; // 0x3D4
	public float researchDuration; // 0x3D8
	public int requiredPaper; // 0x3DC
	public GameObjectRef researchStartEffect; // 0x3E0
	public GameObjectRef researchFailEffect; // 0x3E8
	public GameObjectRef researchSuccessEffect; // 0x3F0
	public ItemDefinition researchResource; // 0x3F8

	// Methods

	// RVA: 0x9553E0 Offset: 0x9539E0 VA: 0x1809553E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x955500 Offset: 0x953B00 VA: 0x180955500 Slot: 27
	public override void ResetState() { }

	// RVA: 0x9555D0 Offset: 0x953BD0 VA: 0x1809555D0
	public void TryResearch() { }

	// RVA: 0x955100 Offset: 0x953700 VA: 0x180955100 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool IsResearching() { }

	// RVA: 0x9554D0 Offset: 0x953AD0 VA: 0x1809554D0
	public int RarityMultiplier(Rarity rarity) { }

	// RVA: 0x955030 Offset: 0x953630 VA: 0x180955030
	public int GetBlueprintStacksize(Item sourceItem) { }

	// RVA: 0x955520 Offset: 0x953B20 VA: 0x180955520
	public int ScrapForResearch(Item item) { }

	// RVA: 0x955580 Offset: 0x953B80 VA: 0x180955580
	public static int ScrapForResearch(ItemDefinition info) { }

	// RVA: 0x955280 Offset: 0x953880 VA: 0x180955280
	public bool IsItemResearchable(Item item) { }

	// RVA: 0x955370 Offset: 0x953970 VA: 0x180955370 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x955610 Offset: 0x953C10 VA: 0x180955610
	public void .ctor() { }

}

