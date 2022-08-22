public class MLRSAudio : MonoBehaviour // TypeDefIndex: 9723
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private MLRS mlrs; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform pitchTransform; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform yawTransform; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float pitchDeltaSmoothRate; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float yawDeltaSmoothRate; // 0x34
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float pitchDeltaThreshold; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x5526B0 Offset: 0x550CB0 VA: 0x1805526B0
	private void Awake() { }

	// RVA: 0x552A90 Offset: 0x551090 VA: 0x180552A90
	private void Update() { }

	// RVA: 0x552700 Offset: 0x550D00 VA: 0x180552700
	private void UpdateTurretMovementSounds() { }

	// RVA: 0x552AA0 Offset: 0x5510A0 VA: 0x180552AA0
	public void .ctor() { }

}

