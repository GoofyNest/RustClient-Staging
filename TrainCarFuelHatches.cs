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

	// RVA: 0xA0C500 Offset: 0xA0AB00 VA: 0x180A0C500
	public void LinedUpStateChanged(bool linedUp) { }

	// RVA: 0xA0C770 Offset: 0xA0AD70 VA: 0x180A0C770
	private void MoveTick() { }

	// RVA: 0xA0C470 Offset: 0xA0AA70 VA: 0x180A0C470
	private void EndMove() { }

	// RVA: 0xA0CA30 Offset: 0xA0B030 VA: 0x180A0CA30
	private void SetAngleOnAll(float lerpT, bool closing) { }

	// RVA: 0xA0CD10 Offset: 0xA0B310 VA: 0x180A0CD10
	private void SetAngle(Transform transform, float angle) { }

	// RVA: 0xA0C920 Offset: 0xA0AF20 VA: 0x180A0C920
	private void PlayOpenSounds() { }

	// RVA: 0xA0C810 Offset: 0xA0AE10 VA: 0x180A0C810
	private void PlayCloseSounds() { }

	// RVA: 0xA0CD50 Offset: 0xA0B350 VA: 0x180A0CD50
	public void .ctor() { }

}

