public class TrainWagonLootData : ScriptableObject // TypeDefIndex: 9776
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TrainWagonLootData.LootOption[] oreOptions; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TrainWagonLootData.LootOption lootWagonContent; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TrainWagonLootData.LootOption fuelWagonContent; // 0x28
	public static TrainWagonLootData instance; // 0x0
	private const int LOOT_WAGON_INDEX = 1000;
	private const int FUEL_WAGON_INDEX = 1001;

	// Methods

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x983F0 Offset: 0x977F0 VA: 0x1800983F0
	// RVA: 0xA16A60 Offset: 0xA15060 VA: 0x180A16A60
	private static void Init() { }

	// RVA: 0xA16900 Offset: 0xA14F00 VA: 0x180A16900
	public TrainWagonLootData.LootOption GetLootOption(TrainCarUnloadable.WagonType wagonType, out int index) { }

	// RVA: 0xA16B50 Offset: 0xA15150 VA: 0x180A16B50
	public bool TryGetLootFromIndex(int index, out TrainWagonLootData.LootOption lootOption) { }

	// RVA: 0xA16AB0 Offset: 0xA150B0 VA: 0x180A16AB0
	public bool TryGetIndexFromLoot(TrainWagonLootData.LootOption lootOption, out int index) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class TrainWagonLootData.LootOption // TypeDefIndex: 9777
{	// Fields
	public bool showsFX; // 0x10
	public ItemDefinition lootItem; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x98490 Offset: 0x97890 VA: 0x180098490
	public int maxLootAmount; // 0x20
	public int minLootAmount; // 0x24
	public Material lootMaterial; // 0x28
	public float spawnWeighting; // 0x30
	public Color fxTint; // 0x34
	[FormerlySerializedAsAttribute] // RVA: 0x985B0 Offset: 0x979B0 VA: 0x1800985B0
	public Color particleFXTint; // 0x44

	// Methods

	// RVA: 0xA08290 Offset: 0xA06890 VA: 0x180A08290
	public void .ctor() { }

}

