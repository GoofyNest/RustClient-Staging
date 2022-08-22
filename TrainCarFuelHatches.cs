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

	// RVA: 0xA0BD50 Offset: 0xA0A350 VA: 0x180A0BD50
	public void LinedUpStateChanged(bool linedUp) { }

	// RVA: 0xA0BFC0 Offset: 0xA0A5C0 VA: 0x180A0BFC0
	private void MoveTick() { }

	// RVA: 0xA0BCC0 Offset: 0xA0A2C0 VA: 0x180A0BCC0
	private void EndMove() { }

	// RVA: 0xA0C280 Offset: 0xA0A880 VA: 0x180A0C280
	private void SetAngleOnAll(float lerpT, bool closing) { }

	// RVA: 0xA0C560 Offset: 0xA0AB60 VA: 0x180A0C560
	private void SetAngle(Transform transform, float angle) { }

	// RVA: 0xA0C170 Offset: 0xA0A770 VA: 0x180A0C170
	private void PlayOpenSounds() { }

	// RVA: 0xA0C060 Offset: 0xA0A660 VA: 0x180A0C060
	private void PlayCloseSounds() { }

	// RVA: 0xA0C5A0 Offset: 0xA0ABA0 VA: 0x180A0C5A0
	public void .ctor() { }

}

