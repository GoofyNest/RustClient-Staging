public class TrainCarFuelHatches : MonoBehaviour // TypeDefIndex: 9769
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private TrainCar owner; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float animSpeed; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform hatch1Col; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform hatch1Vis; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform hatch2Col; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform hatch2Vis; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform hatch3Col; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform hatch3Vis; // 0x50
	private const float closedXAngle = 0;
	private const float openXAngle = -145;
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition hatchOpenSoundDef; // 0x58
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SoundDefinition hatchCloseSoundDef; // 0x60
	private Vector3 _angles; // 0x68
	private float _hatchLerp; // 0x74
	private bool opening; // 0x78
	private bool openingQueued; // 0x79
	private bool isMoving; // 0x7A

	// Methods

	// RVA: 0xA0C010 Offset: 0xA0A610 VA: 0x180A0C010
	public void LinedUpStateChanged(bool linedUp) { }

	// RVA: 0xA0C280 Offset: 0xA0A880 VA: 0x180A0C280
	private void MoveTick() { }

	// RVA: 0xA0BF80 Offset: 0xA0A580 VA: 0x180A0BF80
	private void EndMove() { }

	// RVA: 0xA0C540 Offset: 0xA0AB40 VA: 0x180A0C540
	private void SetAngleOnAll(float lerpT, bool closing) { }

	// RVA: 0xA0C820 Offset: 0xA0AE20 VA: 0x180A0C820
	private void SetAngle(Transform transform, float angle) { }

	// RVA: 0xA0C430 Offset: 0xA0AA30 VA: 0x180A0C430
	private void PlayOpenSounds() { }

	// RVA: 0xA0C320 Offset: 0xA0A920 VA: 0x180A0C320
	private void PlayCloseSounds() { }

	// RVA: 0xA0C860 Offset: 0xA0AE60 VA: 0x180A0C860
	public void .ctor() { }

}

