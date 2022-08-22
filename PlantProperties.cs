public class PlantProperties : ScriptableObject // TypeDefIndex: 9640
{	// Fields
	public Translate.Phrase Description; // 0x18
	public GrowableGeneProperties Genes; // 0x20
	[ArrayIndexIsEnum] // RVA: 0x7CFC0 Offset: 0x7C3C0 VA: 0x18007CFC0
	public PlantProperties.Stage[] stages; // 0x28
	[HeaderAttribute] // RVA: 0x7D140 Offset: 0x7C540 VA: 0x18007D140
	public AnimationCurve timeOfDayHappiness; // 0x30
	public AnimationCurve temperatureHappiness; // 0x38
	public AnimationCurve temperatureWaterRequirementMultiplier; // 0x40
	public AnimationCurve fruitVisualScaleCurve; // 0x48
	public int MaxSeasons; // 0x50
	public float WaterIntake; // 0x54
	public float OptimalLightQuality; // 0x58
	public float OptimalWaterQuality; // 0x5C
	public float OptimalGroundQuality; // 0x60
	public float OptimalTemperatureQuality; // 0x64
	[HeaderAttribute] // RVA: 0x7D1B0 Offset: 0x7C5B0 VA: 0x18007D1B0
	public BaseEntity.Menu.Option pickOption; // 0x68
	public ItemDefinition pickupItem; // 0x88
	public BaseEntity.Menu.Option cloneOption; // 0x90
	public BaseEntity.Menu.Option removeDyingOption; // 0xB0
	public ItemDefinition removeDyingItem; // 0xD0
	public GameObjectRef removeDyingEffect; // 0xD8
	public int pickupMultiplier; // 0xE0
	public GameObjectRef pickEffect; // 0xE8
	public int maxHarvests; // 0xF0
	public bool disappearAfterHarvest; // 0xF4
	[HeaderAttribute] // RVA: 0x7D400 Offset: 0x7C800 VA: 0x18007D400
	public GameObjectRef CrossBreedEffect; // 0xF8
	public ItemDefinition SeedItem; // 0x100
	public ItemDefinition CloneItem; // 0x108
	public int BaseCloneCount; // 0x110
	[HeaderAttribute] // RVA: 0x7D640 Offset: 0x7CA40 VA: 0x18007D640
	public int BaseMarketValue; // 0x114

	// Methods

	// RVA: 0x91CF40 Offset: 0x91B540 VA: 0x18091CF40
	public void .ctor() { }

}

public enum PlantProperties.State // TypeDefIndex: 9641
{	// Fields
	public int value__; // 0x0
	public const PlantProperties.State Seed = 0;
	public const PlantProperties.State Seedling = 1;
	public const PlantProperties.State Sapling = 2;
	public const PlantProperties.State Crossbreed = 3;
	public const PlantProperties.State Mature = 4;
	public const PlantProperties.State Fruiting = 5;
	public const PlantProperties.State Ripe = 6;
	public const PlantProperties.State Dying = 7;

}

public struct PlantProperties.Stage // TypeDefIndex: 9642
{	// Fields
	public PlantProperties.State nextState; // 0x0
	public float lifeLength; // 0x4
	public float health; // 0x8
	public float resources; // 0xC
	public float yield; // 0x10
	public GameObjectRef skinObject; // 0x18
	public bool IgnoreConditions; // 0x20

	// Properties
	public float lifeLengthSeconds { get; }

	// Methods

	// RVA: 0xFA170 Offset: 0xF9570 VA: 0x1800FA170
	public float get_lifeLengthSeconds() { }

}

