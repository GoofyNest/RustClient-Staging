public class LocomotiveExtraVisuals : MonoBehaviour // TypeDefIndex: 9765
{	// Fields
	[HeaderAttribute] // RVA: 0x94030 Offset: 0x93430 VA: 0x180094030
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

	// Methods

	// RVA: 0x4FFC80 Offset: 0x4FE280 VA: 0x1804FFC80
	public void UpdateTick() { }

	// RVA: 0x4FFAC0 Offset: 0x4FE0C0 VA: 0x1804FFAC0
	public void StopAll() { }

	// RVA: 0x4FFB70 Offset: 0x4FE170 VA: 0x1804FFB70
	private void UpdateNeedle(Transform needle, LocomotiveExtraVisuals.NeedleType type) { }

	// RVA: 0x4FF8B0 Offset: 0x4FDEB0 VA: 0x1804FF8B0
	private float GetTargetAngle(LocomotiveExtraVisuals.NeedleType type) { }

	// RVA: 0x4FFA80 Offset: 0x4FE080 VA: 0x1804FFA80
	private void SetAngle(Transform tr, float angle) { }

	// RVA: 0x5001B0 Offset: 0x4FE7B0 VA: 0x1805001B0
	public void .ctor() { }

}

private enum LocomotiveExtraVisuals.NeedleType // TypeDefIndex: 9766
{	// Fields
	public int value__; // 0x0
	public const LocomotiveExtraVisuals.NeedleType Speed = 0;
	public const LocomotiveExtraVisuals.NeedleType Pressure = 1;

}

