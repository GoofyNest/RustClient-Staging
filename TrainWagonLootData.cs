public class TrainWagonLootData : ScriptableObject // TypeDefIndex: 9776
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainWagonLootData.LootOption[] oreOptions; // 0x18
	[SerializeField] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	[ReadOnlyAttribute] // RVA: 0x934F0 Offset: 0x928F0 VA: 0x1800934F0
	private TrainWagonLootData.LootOption lootWagonContent; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainWagonLootData.LootOption fuelWagonContent; // 0x28
	public static TrainWagonLootData instance; // 0x0
	private const int LOOT_WAGON_INDEX = 1000;
	private const int FUEL_WAGON_INDEX = 1001;

	// Methods

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x98480 Offset: 0x97880 VA: 0x180098480
	// RVA: 0xA16D20 Offset: 0xA15320 VA: 0x180A16D20
	private static void Init() { }

	// RVA: 0xA16BC0 Offset: 0xA151C0 VA: 0x180A16BC0
	public TrainWagonLootData.LootOption GetLootOption(TrainCarUnloadable.WagonType wagonType, out int index) { }

	// RVA: 0xA16E10 Offset: 0xA15410 VA: 0x180A16E10
	public bool TryGetLootFromIndex(int index, out TrainWagonLootData.LootOption lootOption) { }

	// RVA: 0xA16D70 Offset: 0xA15370 VA: 0x180A16D70
	public bool TryGetIndexFromLoot(TrainWagonLootData.LootOption lootOption, out int index) { }

	// RVA: 0x4C3AE0 Offset: 0x4C20E0 VA: 0x1804C3AE0
	public void .ctor() { }

}

public class TrainWagonLootData.LootOption // TypeDefIndex: 9777
{	// Fields
	public bool showsFX; // 0x10
	public ItemDefinition lootItem; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0x98590 Offset: 0x97990 VA: 0x180098590
	public int maxLootAmount; // 0x20
	public int minLootAmount; // 0x24
	public Material lootMaterial; // 0x28
	public float spawnWeighting; // 0x30
	public Color fxTint; // 0x34
	[FormerlySerializedAsAttribute] // RVA: 0x98640 Offset: 0x97A40 VA: 0x180098640
	public Color particleFXTint; // 0x44

	// Methods

	// RVA: 0xA08550 Offset: 0xA06B50 VA: 0x180A08550
	public void .ctor() { }

}

