public class LocomotiveExtraVisuals : MonoBehaviour // TypeDefIndex: 9765
{	// Fields
	[HeaderAttribute] // RVA: 0x93FB0 Offset: 0x933B0 VA: 0x180093FB0
	[SerializeField] // RVA: 0x93FB0 Offset: 0x933B0 VA: 0x180093FB0
	private TrainEngine trainEngine; // 0x18
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform needleA; // 0x20
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform needleB; // 0x28
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private Transform needleC; // 0x30
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float maxAngle; // 0x38
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float speedoMoveSpeed; // 0x3C
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float pressureMoveSpeed; // 0x40
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float fanAcceleration; // 0x44
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float fanMaxSpeed; // 0x48
	[SerializeField] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private float speedoMax; // 0x4C
	[HeaderAttribute] // RVA: 0x945F0 Offset: 0x939F0 VA: 0x1800945F0
	[SerializeField] // RVA: 0x945F0 Offset: 0x939F0 VA: 0x1800945F0
	private Transform[] engineFans; // 0x50
	private Vector3 _v3; // 0x58
	private float fanPrevSpeed; // 0x64
	private float[] fanSpeedVariation; // 0x68

	// Methods

	// RVA: 0x4FFCF0 Offset: 0x4FE2F0 VA: 0x1804FFCF0
	public void UpdateTick() { }

	// RVA: 0x4FFB30 Offset: 0x4FE130 VA: 0x1804FFB30
	public void StopAll() { }

	// RVA: 0x4FFBE0 Offset: 0x4FE1E0 VA: 0x1804FFBE0
	private void UpdateNeedle(Transform needle, LocomotiveExtraVisuals.NeedleType type) { }

	// RVA: 0x4FF920 Offset: 0x4FDF20 VA: 0x1804FF920
	private float GetTargetAngle(LocomotiveExtraVisuals.NeedleType type) { }

	// RVA: 0x4FFAF0 Offset: 0x4FE0F0 VA: 0x1804FFAF0
	private void SetAngle(Transform tr, float angle) { }

	// RVA: 0x500220 Offset: 0x4FE820 VA: 0x180500220
	public void .ctor() { }

}

private enum LocomotiveExtraVisuals.NeedleType // TypeDefIndex: 9766
{	// Fields
	public int value__; // 0x0
	public const LocomotiveExtraVisuals.NeedleType Speed = 0;
	public const LocomotiveExtraVisuals.NeedleType Pressure = 1;

}

