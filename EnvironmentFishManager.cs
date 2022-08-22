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

	// RVA: 0x8C71B0 Offset: 0x8C57B0 VA: 0x1808C71B0
	public int GetMaxFish() { }

	// RVA: 0x8C6D40 Offset: 0x8C5340 VA: 0x1808C6D40
	public void Init() { }

	// RVA: 0x8C6E50 Offset: 0x8C5450 VA: 0x1808C6E50
	public void GenerateFish() { }

	// RVA: 0x8C6D50 Offset: 0x8C5350 VA: 0x1808C6D50
	public void Cleanup() { }

	// RVA: 0x8C6D40 Offset: 0x8C5340 VA: 0x1808C6D40
	public void Awake() { }

	// RVA: 0x8C7240 Offset: 0x8C5840 VA: 0x1808C7240
	public void OnDestroy() { }

	// RVA: 0x8C7DF0 Offset: 0x8C63F0 VA: 0x1808C7DF0
	public void Update() { }

	// RVA: 0x8C7250 Offset: 0x8C5850 VA: 0x1808C7250
	public void UpdateFish() { }

	// RVA: 0x8C7F90 Offset: 0x8C6590 VA: 0x1808C7F90
	public void .ctor() { }

	// RVA: 0x8C7ED0 Offset: 0x8C64D0 VA: 0x1808C7ED0
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

	// RVA: 0x8D6430 Offset: 0x8D4A30 VA: 0x1808D6430
	public float GetPopulationScaleForPoint(Vector3 point) { }

	// RVA: 0x8D65A0 Offset: 0x8D4BA0 VA: 0x1808D65A0
	public EnvironmentFish GetSleeping() { }

	// RVA: 0x8D6650 Offset: 0x8D4C50 VA: 0x1808D6650
	public void Sleep(EnvironmentFish toSleep) { }

	// RVA: 0x8D6770 Offset: 0x8D4D70 VA: 0x1808D6770
	public void .ctor() { }

}

public class EnvironmentFishManager.EnvironmentFishWorkQueue : ObjectWorkQueue<EnvironmentFish> // TypeDefIndex: 8951
{	// Methods

	// RVA: 0x8C8000 Offset: 0x8C6600 VA: 0x1808C8000 Slot: 6
	protected override void RunJob(EnvironmentFish entity) { }

	// RVA: 0x8C8050 Offset: 0x8C6650 VA: 0x1808C8050 Slot: 5
	protected override bool ShouldAdd(EnvironmentFish entity) { }

	// RVA: 0x8C80F0 Offset: 0x8C66F0 VA: 0x1808C80F0
	public void .ctor() { }

}

