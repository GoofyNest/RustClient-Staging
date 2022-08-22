public class EnvironmentFish : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8948
{	// Fields
	public Animator animator; // 0x18
	public float minSpeed; // 0x20
	public float maxSpeed; // 0x24
	public float idealDepth; // 0x28
	public float minTurnSpeed; // 0x2C
	public float maxTurnSpeed; // 0x30
	public Vector3 destination; // 0x34
	public Vector3 spawnPos; // 0x40
	public Vector3 idealLocalScale; // 0x4C
	private float lastStartleTime; // 0x58
	private float startleDuration; // 0x5C
	private float currentSpeed; // 0x60
	private static BasePlayer[] playerQueryResults; // 0x0
	private float nextPlayerFleeTime; // 0x64
	public bool inQueue; // 0x68
	private float nextInvalidCheckTime; // 0x6C
	private bool cachedPositionInvalid; // 0x70
	private float nextDestinationTime; // 0x74

	// Methods

	// RVA: 0x8C89C0 Offset: 0x8C6FC0 VA: 0x1808C89C0
	public void Startle() { }

	// RVA: 0x8C8920 Offset: 0x8C6F20 VA: 0x1808C8920
	public bool IsStartled() { }

	// RVA: 0x8C8960 Offset: 0x8C6F60 VA: 0x1808C8960
	public void Start() { }

	// RVA: 0x8C8720 Offset: 0x8C6D20 VA: 0x1808C8720
	private float GetDesiredSpeed() { }

	// RVA: 0x8C8770 Offset: 0x8C6D70 VA: 0x1808C8770
	public float GetTurnSpeed() { }

	// RVA: 0x6C0B50 Offset: 0x6BF150 VA: 0x1806C0B50
	private float GetCurrentSpeed() { }

	// RVA: 0x8C8B60 Offset: 0x8C7160 VA: 0x1808C8B60
	private void UpdateDirection(float delta) { }

	// RVA: 0x8C8950 Offset: 0x8C6F50 VA: 0x1808C8950
	public void QueuedUpdate() { }

	// RVA: 0x8C8130 Offset: 0x8C6730 VA: 0x1808C8130
	public void CheckForCollisions() { }

	// RVA: 0x8C8D50 Offset: 0x8C7350 VA: 0x1808C8D50
	private void UpdatePosition(float delta) { }

	// RVA: 0x8C8F90 Offset: 0x8C7590 VA: 0x1808C8F90
	private void UpdateSpeed(float delta) { }

	// RVA: 0x8C87C0 Offset: 0x8C6DC0 VA: 0x1808C87C0
	public bool InvalidPosition() { }

	// RVA: 0x8C9050 Offset: 0x8C7650 VA: 0x1808C9050
	private void Update() { }

	// RVA: 0x8C89E0 Offset: 0x8C6FE0 VA: 0x1808C89E0
	private void UpdateDestination() { }

	// RVA: 0x8C97F0 Offset: 0x8C7DF0 VA: 0x1808C97F0
	public void .ctor() { }

	// RVA: 0x8C97A0 Offset: 0x8C7DA0 VA: 0x1808C97A0
	private static void .cctor() { }

}

