public class LootContainer : StorageContainer // TypeDefIndex: 9590
{
// Namespace: 
public interface ISplashable // TypeDefIndex: 9589

// Namespace: 
public class LootContainer : StorageContainer // TypeDefIndex: 9590
	// Fields
	public bool destroyOnEmpty; // 0x3D0
	public LootSpawn lootDefinition; // 0x3D8
	public int maxDefinitionsToSpawn; // 0x3E0
	public float minSecondsBetweenRefresh; // 0x3E4
	public float maxSecondsBetweenRefresh; // 0x3E8
	public bool initialLootSpawn; // 0x3EC
	public float xpLootedScale; // 0x3F0
	public float xpDestroyedScale; // 0x3F4
	public bool BlockPlayerItemInput; // 0x3F8
	public int scrapAmount; // 0x3FC
	public string deathStat; // 0x400
	public LootContainer.LootSpawnSlot[] LootSpawnSlots; // 0x408
	public LootContainer.spawnType SpawnType; // 0x410
	private bool localPlayerInvolved; // 0x414

	// Properties
	public bool shouldRefreshContents { get; }

	// Methods

	// RVA: 0x5066B0 Offset: 0x504CB0 VA: 0x1805066B0
	public bool get_shouldRefreshContents() { }

	// RVA: 0x506480 Offset: 0x504A80 VA: 0x180506480 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x506490 Offset: 0x504A90 VA: 0x180506490 Slot: 61
	public override void DoDestroyEffects(BaseNetworkable.DestroyMode mode, Message msg) { }

	// RVA: 0x506570 Offset: 0x504B70 VA: 0x180506570 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x506550 Offset: 0x504B50 VA: 0x180506550 Slot: 28
	public override void InitShared() { }

	// RVA: 0x4FF480 Offset: 0x4FDA80 VA: 0x1804FF480
	public void .ctor() { }

}

public enum LootContainer.spawnType // TypeDefIndex: 9591
{	// Fields
	public int value__; // 0x0
	public const LootContainer.spawnType GENERIC = 0;
	public const LootContainer.spawnType PLAYER = 1;
	public const LootContainer.spawnType TOWN = 2;
	public const LootContainer.spawnType AIRDROP = 3;
	public const LootContainer.spawnType CRASHSITE = 4;
	public const LootContainer.spawnType ROADSIDE = 5;

}

public struct LootContainer.LootSpawnSlot // TypeDefIndex: 9592
{	// Fields
	public LootSpawn definition; // 0x0
	public int numberToSpawn; // 0x8
	public float probability; // 0xC

}

