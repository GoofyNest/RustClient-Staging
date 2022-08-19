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

	// RVA: 0x8C88B0 Offset: 0x8C6EB0 VA: 0x1808C88B0
	public void Startle() { }

	// RVA: 0x8C8810 Offset: 0x8C6E10 VA: 0x1808C8810
	public bool IsStartled() { }

	// RVA: 0x8C8850 Offset: 0x8C6E50 VA: 0x1808C8850
	public void Start() { }

	// RVA: 0x8C8610 Offset: 0x8C6C10 VA: 0x1808C8610
	private float GetDesiredSpeed() { }

	// RVA: 0x8C8660 Offset: 0x8C6C60 VA: 0x1808C8660
	public float GetTurnSpeed() { }

	// RVA: 0x6C0A40 Offset: 0x6BF040 VA: 0x1806C0A40
	private float GetCurrentSpeed() { }

	// RVA: 0x8C8A50 Offset: 0x8C7050 VA: 0x1808C8A50
	private void UpdateDirection(float delta) { }

	// RVA: 0x8C8840 Offset: 0x8C6E40 VA: 0x1808C8840
	public void QueuedUpdate() { }

	// RVA: 0x8C8020 Offset: 0x8C6620 VA: 0x1808C8020
	public void CheckForCollisions() { }

	// RVA: 0x8C8C40 Offset: 0x8C7240 VA: 0x1808C8C40
	private void UpdatePosition(float delta) { }

	// RVA: 0x8C8E80 Offset: 0x8C7480 VA: 0x1808C8E80
	private void UpdateSpeed(float delta) { }

	// RVA: 0x8C86B0 Offset: 0x8C6CB0 VA: 0x1808C86B0
	public bool InvalidPosition() { }

	// RVA: 0x8C8F40 Offset: 0x8C7540 VA: 0x1808C8F40
	private void Update() { }

	// RVA: 0x8C88D0 Offset: 0x8C6ED0 VA: 0x1808C88D0
	private void UpdateDestination() { }

	// RVA: 0x8C96E0 Offset: 0x8C7CE0 VA: 0x1808C96E0
	public void .ctor() { }

	// RVA: 0x8C9690 Offset: 0x8C7C90 VA: 0x1808C9690
	private static void .cctor() { }

}

