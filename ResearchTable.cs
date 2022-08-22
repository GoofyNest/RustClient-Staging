public class ResearchTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6321
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float researchTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E02C80 Offset: 0x1E01280 VA: 0x181E02C80
	public static void ResetToPool(ResearchTable instance) { }

	// RVA: 0x1E02C00 Offset: 0x1E01200 VA: 0x181E02C00
	public void ResetToPool() { }

	// RVA: 0x1E02AD0 Offset: 0x1E010D0 VA: 0x181E02AD0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE4D0 Offset: 0x1BFCAD0 VA: 0x181BFE4D0
	public void CopyTo(ResearchTable instance) { }

	// RVA: 0x1E02140 Offset: 0x1E00740 VA: 0x181E02140
	public ResearchTable Copy() { }

	// RVA: 0x1E02950 Offset: 0x1E00F50 VA: 0x181E02950
	public static ResearchTable Deserialize(Stream stream) { }

	// RVA: 0x1E021B0 Offset: 0x1E007B0 VA: 0x181E021B0
	public static ResearchTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E02650 Offset: 0x1E00C50 VA: 0x181E02650
	public static ResearchTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E026E0 Offset: 0x1E00CE0 VA: 0x181E026E0
	public static ResearchTable Deserialize(byte[] buffer) { }

	// RVA: 0x1E02BC0 Offset: 0x1E011C0 VA: 0x181E02BC0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E030D0 Offset: 0x1E016D0 VA: 0x181E030D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E030F0 Offset: 0x1E016F0 VA: 0x181E030F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResearchTable previous) { }

	// RVA: 0x1E02BE0 Offset: 0x1E011E0 VA: 0x181E02BE0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E029D0 Offset: 0x1E00FD0 VA: 0x181E029D0
	public static ResearchTable Deserialize(byte[] buffer, ResearchTable instance, bool isDelta = False) { }

	// RVA: 0x1E02800 Offset: 0x1E00E00 VA: 0x181E02800
	public static ResearchTable Deserialize(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02230 Offset: 0x1E00830 VA: 0x181E02230
	public static ResearchTable DeserializeLengthDelimited(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02450 Offset: 0x1E00A50 VA: 0x181E02450
	public static ResearchTable DeserializeLength(Stream stream, int length, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02D00 Offset: 0x1E01300 VA: 0x181E02D00
	public static void SerializeDelta(Stream stream, ResearchTable instance, ResearchTable previous) { }

	// RVA: 0x1E02FE0 Offset: 0x1E015E0 VA: 0x181E02FE0
	public static void Serialize(Stream stream, ResearchTable instance) { }

	// RVA: 0x1E030C0 Offset: 0x1E016C0 VA: 0x181E030C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E030D0 Offset: 0x1E016D0 VA: 0x181E030D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E02ED0 Offset: 0x1E014D0 VA: 0x181E02ED0
	public static byte[] SerializeToBytes(ResearchTable instance) { }

	// RVA: 0x1E02E20 Offset: 0x1E01420 VA: 0x181E02E20
	public static void SerializeLengthDelimited(Stream stream, ResearchTable instance) { }

	// RVA: 0x1020A80 Offset: 0x101F080 VA: 0x181020A80
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

	// RVA: 0x9552D0 Offset: 0x9538D0 VA: 0x1809552D0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9553F0 Offset: 0x9539F0 VA: 0x1809553F0 Slot: 27
	public override void ResetState() { }

	// RVA: 0x9554C0 Offset: 0x953AC0 VA: 0x1809554C0
	public void TryResearch() { }

	// RVA: 0x954FF0 Offset: 0x9535F0 VA: 0x180954FF0 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4F6310 Offset: 0x4F4910 VA: 0x1804F6310
	public bool IsResearching() { }

	// RVA: 0x9553C0 Offset: 0x9539C0 VA: 0x1809553C0
	public int RarityMultiplier(Rarity rarity) { }

	// RVA: 0x954F20 Offset: 0x953520 VA: 0x180954F20
	public int GetBlueprintStacksize(Item sourceItem) { }

	// RVA: 0x955410 Offset: 0x953A10 VA: 0x180955410
	public int ScrapForResearch(Item item) { }

	// RVA: 0x955470 Offset: 0x953A70 VA: 0x180955470
	public static int ScrapForResearch(ItemDefinition info) { }

	// RVA: 0x955170 Offset: 0x953770 VA: 0x180955170
	public bool IsItemResearchable(Item item) { }

	// RVA: 0x955260 Offset: 0x953860 VA: 0x180955260 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x955500 Offset: 0x953B00 VA: 0x180955500
	public void .ctor() { }

}

