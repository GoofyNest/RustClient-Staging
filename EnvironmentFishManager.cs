public class EnvironmentFishManager : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8949
{	// Fields
	public EnvironmentFishManager.FishTypeInstance[] fishTypes; // 0x18
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static int maxFishPerType; // 0x0
	[ClientVar] // RVA: 0x71220 Offset: 0x70620 VA: 0x180071220
	public static float maxFishDistance; // 0x4
	[ClientVar] // RVA: 0xC6E20 Offset: 0xC6220 VA: 0x1800C6E20
	[HelpAttribute] // RVA: 0xC6E20 Offset: 0xC6220 VA: 0x1800C6E20
	public static float framebudgetms; // 0x8
	public static EnvironmentFishManager.EnvironmentFishWorkQueue workQueue; // 0x10
	private GameObject fishContainer; // 0x20
	private int lastMaxFish; // 0x28
	private Vector3 lastFishUpdatePosition; // 0x2C
	private float nextFishUpdateTime; // 0x38

	// Methods

	// RVA: 0x8C76C0 Offset: 0x8C5CC0 VA: 0x1808C76C0
	public int GetMaxFish() { }

	// RVA: 0x8C7250 Offset: 0x8C5850 VA: 0x1808C7250
	public void Init() { }

	// RVA: 0x8C7360 Offset: 0x8C5960 VA: 0x1808C7360
	public void GenerateFish() { }

	// RVA: 0x8C7260 Offset: 0x8C5860 VA: 0x1808C7260
	public void Cleanup() { }

	// RVA: 0x8C7250 Offset: 0x8C5850 VA: 0x1808C7250
	public void Awake() { }

	// RVA: 0x8C7750 Offset: 0x8C5D50 VA: 0x1808C7750
	public void OnDestroy() { }

	// RVA: 0x8C8300 Offset: 0x8C6900 VA: 0x1808C8300
	public void Update() { }

	// RVA: 0x8C7760 Offset: 0x8C5D60 VA: 0x1808C7760
	public void UpdateFish() { }

	// RVA: 0x8C84A0 Offset: 0x8C6AA0 VA: 0x1808C84A0
	public void .ctor() { }

	// RVA: 0x8C83E0 Offset: 0x8C69E0 VA: 0x1808C83E0
	private static void .cctor() { }

}

public class EnvironmentFishManager.FishTypeInstance // TypeDefIndex: 8950
{	// Fields
	public GameObjectRef prefab; // 0x10
	public bool shouldSchool; // 0x18
	public float populationScale; // 0x1C
	public bool freshwater; // 0x20
	public bool seawater; // 0x21
	public float minDepth; // 0x24
	public float maxDepth; // 0x28
	public List<EnvironmentFish> activeFish; // 0x30
	public List<EnvironmentFish> sleeping; // 0x38

	// Methods

	// RVA: 0x8D6940 Offset: 0x8D4F40 VA: 0x1808D6940
	public float GetPopulationScaleForPoint(Vector3 point) { }

	// RVA: 0x8D6AB0 Offset: 0x8D50B0 VA: 0x1808D6AB0
	public EnvironmentFish GetSleeping() { }

	// RVA: 0x8D6B60 Offset: 0x8D5160 VA: 0x1808D6B60
	public void Sleep(EnvironmentFish toSleep) { }

	// RVA: 0x8D6C80 Offset: 0x8D5280 VA: 0x1808D6C80
	public void .ctor() { }

}

public class EnvironmentFishManager.EnvironmentFishWorkQueue : ObjectWorkQueue<EnvironmentFish> // TypeDefIndex: 8951
{	// Methods

	// RVA: 0x8C8510 Offset: 0x8C6B10 VA: 0x1808C8510 Slot: 6
	protected override void RunJob(EnvironmentFish entity) { }

	// RVA: 0x8C8560 Offset: 0x8C6B60 VA: 0x1808C8560 Slot: 5
	protected override bool ShouldAdd(EnvironmentFish entity) { }

	// RVA: 0x8C8600 Offset: 0x8C6C00 VA: 0x1808C8600
	public void .ctor() { }

}

