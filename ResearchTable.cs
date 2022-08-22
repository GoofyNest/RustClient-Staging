public class ResearchTable : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6321
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public float researchTimeLeft; // 0x14

	// Methods

	// RVA: 0x1E03760 Offset: 0x1E01D60 VA: 0x181E03760
	public static void ResetToPool(ResearchTable instance) { }

	// RVA: 0x1E036E0 Offset: 0x1E01CE0 VA: 0x181E036E0
	public void ResetToPool() { }

	// RVA: 0x1E035B0 Offset: 0x1E01BB0 VA: 0x181E035B0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A6830 Offset: 0x10A4E30 VA: 0x1810A6830 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A6860 Offset: 0x10A4E60 VA: 0x1810A6860 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BFEF80 Offset: 0x1BFD580 VA: 0x181BFEF80
	public void CopyTo(ResearchTable instance) { }

	// RVA: 0x1E02C20 Offset: 0x1E01220 VA: 0x181E02C20
	public ResearchTable Copy() { }

	// RVA: 0x1E03430 Offset: 0x1E01A30 VA: 0x181E03430
	public static ResearchTable Deserialize(Stream stream) { }

	// RVA: 0x1E02C90 Offset: 0x1E01290 VA: 0x181E02C90
	public static ResearchTable DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E03130 Offset: 0x1E01730 VA: 0x181E03130
	public static ResearchTable DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E031C0 Offset: 0x1E017C0 VA: 0x181E031C0
	public static ResearchTable Deserialize(byte[] buffer) { }

	// RVA: 0x1E036A0 Offset: 0x1E01CA0 VA: 0x181E036A0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E03BB0 Offset: 0x1E021B0 VA: 0x181E03BB0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E03BD0 Offset: 0x1E021D0 VA: 0x181E03BD0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, ResearchTable previous) { }

	// RVA: 0x1E036C0 Offset: 0x1E01CC0 VA: 0x181E036C0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E034B0 Offset: 0x1E01AB0 VA: 0x181E034B0
	public static ResearchTable Deserialize(byte[] buffer, ResearchTable instance, bool isDelta = False) { }

	// RVA: 0x1E032E0 Offset: 0x1E018E0 VA: 0x181E032E0
	public static ResearchTable Deserialize(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02D10 Offset: 0x1E01310 VA: 0x181E02D10
	public static ResearchTable DeserializeLengthDelimited(Stream stream, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E02F30 Offset: 0x1E01530 VA: 0x181E02F30
	public static ResearchTable DeserializeLength(Stream stream, int length, ResearchTable instance, bool isDelta) { }

	// RVA: 0x1E037E0 Offset: 0x1E01DE0 VA: 0x181E037E0
	public static void SerializeDelta(Stream stream, ResearchTable instance, ResearchTable previous) { }

	// RVA: 0x1E03AC0 Offset: 0x1E020C0 VA: 0x181E03AC0
	public static void Serialize(Stream stream, ResearchTable instance) { }

	// RVA: 0x1E03BA0 Offset: 0x1E021A0 VA: 0x181E03BA0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E03BB0 Offset: 0x1E021B0 VA: 0x181E03BB0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E039B0 Offset: 0x1E01FB0 VA: 0x181E039B0
	public static byte[] SerializeToBytes(ResearchTable instance) { }

	// RVA: 0x1E03900 Offset: 0x1E01F00 VA: 0x181E03900
	public static void SerializeLengthDelimited(Stream stream, ResearchTable instance) { }

	// RVA: 0x10217E0 Offset: 0x101FDE0 VA: 0x1810217E0
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

	// RVA: 0x9558E0 Offset: 0x953EE0 VA: 0x1809558E0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x955A00 Offset: 0x954000 VA: 0x180955A00 Slot: 27
	public override void ResetState() { }

	// RVA: 0x955AD0 Offset: 0x9540D0 VA: 0x180955AD0
	public void TryResearch() { }

	// RVA: 0x955600 Offset: 0x953C00 VA: 0x180955600 Slot: 152
	public override int GetMoveToSlotIndex(BasePlayer player, Item item) { }

	// RVA: 0x4F62A0 Offset: 0x4F48A0 VA: 0x1804F62A0
	public bool IsResearching() { }

	// RVA: 0x9559D0 Offset: 0x953FD0 VA: 0x1809559D0
	public int RarityMultiplier(Rarity rarity) { }

	// RVA: 0x955530 Offset: 0x953B30 VA: 0x180955530
	public int GetBlueprintStacksize(Item sourceItem) { }

	// RVA: 0x955A20 Offset: 0x954020 VA: 0x180955A20
	public int ScrapForResearch(Item item) { }

	// RVA: 0x955A80 Offset: 0x954080 VA: 0x180955A80
	public static int ScrapForResearch(ItemDefinition info) { }

	// RVA: 0x955780 Offset: 0x953D80 VA: 0x180955780
	public bool IsItemResearchable(Item item) { }

	// RVA: 0x955870 Offset: 0x953E70 VA: 0x180955870 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x955B10 Offset: 0x954110 VA: 0x180955B10
	public void .ctor() { }

}

