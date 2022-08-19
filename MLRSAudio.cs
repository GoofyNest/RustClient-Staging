public class MLRSAudio : MonoBehaviour // TypeDefIndex: 9723
{	// Fields
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private MLRS mlrs; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform pitchTransform; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform yawTransform; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float pitchDeltaSmoothRate; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float yawDeltaSmoothRate; // 0x34
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float pitchDeltaThreshold; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float yawDeltaThreshold; // 0x3C
	private float lastPitch; // 0x40
	private float lastYaw; // 0x44
	private float pitchDelta; // 0x48
	private float yawDelta; // 0x4C
	public SoundDefinition turretMovementStartDef; // 0x50
	public SoundDefinition turretMovementLoopDef; // 0x58
	public SoundDefinition turretMovementStopDef; // 0x60
	private Sound turretMovementLoop; // 0x68

	// Methods

	// RVA: 0x552720 Offset: 0x550D20 VA: 0x180552720
	private void Awake() { }

	// RVA: 0x552B00 Offset: 0x551100 VA: 0x180552B00
	private void Update() { }

	// RVA: 0x552770 Offset: 0x550D70 VA: 0x180552770
	private void UpdateTurretMovementSounds() { }

	// RVA: 0x552B10 Offset: 0x551110 VA: 0x180552B10
	public void .ctor() { }

}

