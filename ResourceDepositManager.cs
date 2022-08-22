public class ResourceDepositManager : BaseEntity // TypeDefIndex: 9571
{	// Fields
	public static ResourceDepositManager _manager; // 0x0
	private const int resolution = 20;
	public Dictionary<Vector2i, ResourceDepositManager.ResourceDeposit> _deposits; // 0x168

	// Methods

	// RVA: 0x9562C0 Offset: 0x9548C0 VA: 0x1809562C0
	public void .ctor() { }

}

public class ResourceDepositManager.ResourceDeposit // TypeDefIndex: 9572
{	// Fields
	public float lastSurveyTime; // 0x10
	public Vector3 origin; // 0x14
	public List<ResourceDepositManager.ResourceDeposit.ResourceDepositEntry> _resources; // 0x20

	// Methods

	// RVA: 0x956400 Offset: 0x954A00 VA: 0x180956400
	public void .ctor() { }

	// RVA: 0x956320 Offset: 0x954920 VA: 0x180956320
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

	// RVA: 0x956280 Offset: 0x954880 VA: 0x180956280
	public void Subtract(int subamount) { }

	// RVA: 0x9562A0 Offset: 0x9548A0 VA: 0x1809562A0
	public void .ctor() { }

}

