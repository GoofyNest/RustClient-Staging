public class ResearchTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6321
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float researchTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E02E40 Offset: 0x1E01440 VA: 0x181E02E40
	public static void ResetToPool(ResearchTable instance) { }

	// RVA: 0x1E02DC0 Offset: 0x1E013C0 VA: 0x181E02DC0
	public void ResetToPool() { }

	// RVA: 0x1E02C90 Offset: 0x1E01290 VA: 0x181E02C90 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A5B00 Offset: 0x10A4100 VA: 0x1810A5B00 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A5B30 Offset: 0x10A4130 VA: 0x1810A5B30 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFE690 Offset: 0x1BFCC90 VA: 0x181BFE690
	public void CopyTo(ResearchTable instance) { }

	// RVA: 0x1E02300 Offset: 0x1E00900 VA: 0x181E02300
	public ResearchTable Copy() { }

	// RVA: 0x1E02B10 Offset: 0x1E01110 VA: 0x181E02B10
	public static ResearchTable Deserialize(Stream stream) { }

	// RVA: 0x1E02370 Offset: 0x1E00970 VA: 0x181E02370
	public static ResearchTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E02810 Offset: 0x1E00E10 VA: 0x181E02810
	public static ResearchTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E028A0 Offset: 0x1E00EA0 VA: 0x181E028A0
	public static ResearchTable Deserialize(byte[] buffer) { }

	// RVA: 0x1E02D80 Offset: 0x1E01380 VA: 0x181E02D80
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E03290 Offset: 0x1E01890 VA: 0x181E03290 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E032B0 Offset: 0x1E018B0 VA: 0x181E032B0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResearchTable previous) { }

	// RVA: 0x1E02DA0 Offset: 0x1E013A0 VA: 0x181E02DA0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E02B90 Offset: 0x1E01190 VA: 0x181E02B90
	public static ResearchTable Deserialize(byte[] buffer, ResearchTable instance, bool isDelta = False) { }

	// RVA: 0x1E029C0 Offset: 0x1E00FC0 VA: 0x181E029C0
	public static ResearchTable Deserialize(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E023F0 Offset: 0x1E009F0 VA: 0x181E023F0
	public static ResearchTable DeserializeLengthDelimited(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02610 Offset: 0x1E00C10 VA: 0x181E02610
	public static ResearchTable DeserializeLength(Stream stream, int length, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02EC0 Offset: 0x1E014C0 VA: 0x181E02EC0
	public static void SerializeDelta(Stream stream, ResearchTable instance, ResearchTable previous) { }

	// RVA: 0x1E031A0 Offset: 0x1E017A0 VA: 0x181E031A0
	public static void Serialize(Stream stream, ResearchTable instance) { }

	// RVA: 0x1E03280 Offset: 0x1E01880 VA: 0x181E03280
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E03290 Offset: 0x1E01890 VA: 0x181E03290
	public void ToProto(Stream stream) { }

	// RVA: 0x1E03090 Offset: 0x1E01690 VA: 0x181E03090
	public static byte[] SerializeToBytes(ResearchTable instance) { }

	// RVA: 0x1E02FE0 Offset: 0x1E015E0 VA: 0x181E02FE0
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

