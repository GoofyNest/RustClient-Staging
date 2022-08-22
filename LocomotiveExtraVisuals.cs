public class LocomotiveExtraVisuals : MonoBehaviour // TypeDefIndex: 9765
{	[HeaderAttribute] // RVA: 0x94030 Offset: 0x93430 VA: 0x180094030
	[SerializeField] // RVA: 0x94030 Offset: 0x93430 VA: 0x180094030
	private TrainEngine trainEngine; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform needleA; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform needleB; // 0x28
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Transform needleC; // 0x30
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float maxAngle; // 0x38
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float speedoMoveSpeed; // 0x3C
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float pressureMoveSpeed; // 0x40
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float fanAcceleration; // 0x44
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float fanMaxSpeed; // 0x48
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float speedoMax; // 0x4C
	[HeaderAttribute] // RVA: 0x94670 Offset: 0x93A70 VA: 0x180094670
	[SerializeField] // RVA: 0x94670 Offset: 0x93A70 VA: 0x180094670
	private Transform[] engineFans; // 0x50
	private Vector3 _v3; // 0x58
	private float fanPrevSpeed; // 0x64
	private float[] fanSpeedVariation; // 0x68


	public void UpdateTick() { }

	public void StopAll() { }

	private void UpdateNeedle(Transform needle, LocomotiveExtraVisuals.NeedleType type) { }

	private float GetTargetAngle(LocomotiveExtraVisuals.NeedleType type) { }

	private void SetAngle(Transform tr, float angle) { }

	public void .ctor() { }

}

private enum LocomotiveExtraVisuals.NeedleType // TypeDefIndex: 9766
{	public int value__; // 0x0
	public const LocomotiveExtraVisuals.NeedleType Speed = 0;
	public const LocomotiveExtraVisuals.NeedleType Pressure = 1;

}

