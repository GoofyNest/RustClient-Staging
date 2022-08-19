public class ResourceDepositManager : BaseEntity // TypeDefIndex: 9571
{	// Fields
	public static ResourceDepositManager _manager; // 0x0
	private const int resolution = 20;
	public Dictionary<Vector2i, ResourceDepositManager.ResourceDeposit> _deposits; // 0x168

	// Methods

	// RVA: 0x955CB0 Offset: 0x9542B0 VA: 0x180955CB0
	public void .ctor() { }

}

public class ResourceDepositManager.ResourceDeposit // TypeDefIndex: 9572
{	// Fields
	public float lastSurveyTime; // 0x10
	public Vector3 origin; // 0x14
	public List<ResourceDepositManager.ResourceDeposit.ResourceDepositEntry> _resources; // 0x20

	// Methods

	// RVA: 0x955DF0 Offset: 0x9543F0 VA: 0x180955DF0
	public void .ctor() { }

	// RVA: 0x955D10 Offset: 0x954310 VA: 0x180955D10
	public void Add(ItemDefinition type, float efficiency, int amount, float workNeeded, ResourceDepositManager.ResourceDeposit.surveySpawnType spawnType, bool liquid = False) { }

}

public enum ResourceDepositManager.ResourceDeposit.surveySpawnType // TypeDefIndex: 9573
{	// Fields
	public int value__; // 0x0
	public const ResourceDepositManager.ResourceDeposit.surveySpawnType ITEM = 0;
	public const ResourceDepositManager.ResourceDeposit.surveySpawnType OIL = 1;
	public const ResourceDepositManager.ResourceDeposit.surveySpawnType WATER = 2;

}

public class ResourceDepositManager.ResourceDeposit.ResourceDepositEntry // TypeDefIndex: 9574
{	// Fields
	public ItemDefinition type; // 0x10
	public float efficiency; // 0x18
	public int amount; // 0x1C
	public int startAmount; // 0x20
	public float workNeeded; // 0x24
	public float workDone; // 0x28
	public ResourceDepositManager.ResourceDeposit.surveySpawnType spawnType; // 0x2C
	public bool isLiquid; // 0x30

	// Methods

	// RVA: 0x955C70 Offset: 0x954270 VA: 0x180955C70
	public void Subtract(int subamount) { }

	// RVA: 0x955C90 Offset: 0x954290 VA: 0x180955C90
	public void .ctor() { }

}

