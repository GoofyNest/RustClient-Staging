public class EnvironmentFishManager : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8949
{	// Fields
	public EnvironmentFishManager.FishTypeInstance[] fishTypes; // 0x18
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static int maxFishPerType; // 0x0
	[ClientVar] // RVA: 0x71100 Offset: 0x70500 VA: 0x180071100
	public static float maxFishDistance; // 0x4
	[ClientVar] // RVA: 0xC6D90 Offset: 0xC6190 VA: 0x1800C6D90
	[HelpAttribute] // RVA: 0xC6D90 Offset: 0xC6190 VA: 0x1800C6D90
	public static float framebudgetms; // 0x8
	public static EnvironmentFishManager.EnvironmentFishWorkQueue workQueue; // 0x10
	private GameObject fishContainer; // 0x20
	private int lastMaxFish; // 0x28
	private Vector3 lastFishUpdatePosition; // 0x2C
	private float nextFishUpdateTime; // 0x38

	// Methods

	// RVA: 0x8C70A0 Offset: 0x8C56A0 VA: 0x1808C70A0
	public int GetMaxFish() { }

	// RVA: 0x8C6C30 Offset: 0x8C5230 VA: 0x1808C6C30
	public void Init() { }

	// RVA: 0x8C6D40 Offset: 0x8C5340 VA: 0x1808C6D40
	public void GenerateFish() { }

	// RVA: 0x8C6C40 Offset: 0x8C5240 VA: 0x1808C6C40
	public void Cleanup() { }

	// RVA: 0x8C6C30 Offset: 0x8C5230 VA: 0x1808C6C30
	public void Awake() { }

	// RVA: 0x8C7130 Offset: 0x8C5730 VA: 0x1808C7130
	public void OnDestroy() { }

	// RVA: 0x8C7CE0 Offset: 0x8C62E0 VA: 0x1808C7CE0
	public void Update() { }

	// RVA: 0x8C7140 Offset: 0x8C5740 VA: 0x1808C7140
	public void UpdateFish() { }

	// RVA: 0x8C7E80 Offset: 0x8C6480 VA: 0x1808C7E80
	public void .ctor() { }

	// RVA: 0x8C7DC0 Offset: 0x8C63C0 VA: 0x1808C7DC0
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

	// RVA: 0x8D6320 Offset: 0x8D4920 VA: 0x1808D6320
	public float GetPopulationScaleForPoint(Vector3 point) { }

	// RVA: 0x8D6490 Offset: 0x8D4A90 VA: 0x1808D6490
	public EnvironmentFish GetSleeping() { }

	// RVA: 0x8D6540 Offset: 0x8D4B40 VA: 0x1808D6540
	public void Sleep(EnvironmentFish toSleep) { }

	// RVA: 0x8D6660 Offset: 0x8D4C60 VA: 0x1808D6660
	public void .ctor() { }

}

public class EnvironmentFishManager.EnvironmentFishWorkQueue : ObjectWorkQueue<EnvironmentFish> // TypeDefIndex: 8951
{	// Methods

	// RVA: 0x8C7EF0 Offset: 0x8C64F0 VA: 0x1808C7EF0 Slot: 6
	protected override void RunJob(EnvironmentFish entity) { }

	// RVA: 0x8C7F40 Offset: 0x8C6540 VA: 0x1808C7F40 Slot: 5
	protected override bool ShouldAdd(EnvironmentFish entity) { }

	// RVA: 0x8C7FE0 Offset: 0x8C65E0 VA: 0x1808C7FE0
	public void .ctor() { }

}

