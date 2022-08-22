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

	// RVA: 0x8C8ED0 Offset: 0x8C74D0 VA: 0x1808C8ED0
	public void Startle() { }

	// RVA: 0x8C8E30 Offset: 0x8C7430 VA: 0x1808C8E30
	public bool IsStartled() { }

	// RVA: 0x8C8E70 Offset: 0x8C7470 VA: 0x1808C8E70
	public void Start() { }

	// RVA: 0x8C8C30 Offset: 0x8C7230 VA: 0x1808C8C30
	private float GetDesiredSpeed() { }

	// RVA: 0x8C8C80 Offset: 0x8C7280 VA: 0x1808C8C80
	public float GetTurnSpeed() { }

	// RVA: 0x6C0AE0 Offset: 0x6BF0E0 VA: 0x1806C0AE0
	private float GetCurrentSpeed() { }

	// RVA: 0x8C9070 Offset: 0x8C7670 VA: 0x1808C9070
	private void UpdateDirection(float delta) { }

	// RVA: 0x8C8E60 Offset: 0x8C7460 VA: 0x1808C8E60
	public void QueuedUpdate() { }

	// RVA: 0x8C8640 Offset: 0x8C6C40 VA: 0x1808C8640
	public void CheckForCollisions() { }

	// RVA: 0x8C9260 Offset: 0x8C7860 VA: 0x1808C9260
	private void UpdatePosition(float delta) { }

	// RVA: 0x8C94A0 Offset: 0x8C7AA0 VA: 0x1808C94A0
	private void UpdateSpeed(float delta) { }

	// RVA: 0x8C8CD0 Offset: 0x8C72D0 VA: 0x1808C8CD0
	public bool InvalidPosition() { }

	// RVA: 0x8C9560 Offset: 0x8C7B60 VA: 0x1808C9560
	private void Update() { }

	// RVA: 0x8C8EF0 Offset: 0x8C74F0 VA: 0x1808C8EF0
	private void UpdateDestination() { }

	// RVA: 0x8C9D00 Offset: 0x8C8300 VA: 0x1808C9D00
	public void .ctor() { }

	// RVA: 0x8C9CB0 Offset: 0x8C82B0 VA: 0x1808C9CB0
	private static void .cctor() { }

}

