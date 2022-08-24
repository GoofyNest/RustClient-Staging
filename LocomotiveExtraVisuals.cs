public class LocomotiveExtraVisuals : MonoBehaviour // TypeDefIndex: 9765
{	[HeaderAttribute] // RVA: 0x94110 Offset: 0x93510 VA: 0x180094110
	[SerializeField] // RVA: 0x94110 Offset: 0x93510 VA: 0x180094110
	private TrainEngine trainEngine; // 0x18
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform needleA; // 0x20
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform needleB; // 0x28
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private Transform needleC; // 0x30
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float maxAngle; // 0x38
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float speedoMoveSpeed; // 0x3C
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float pressureMoveSpeed; // 0x40
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float fanAcceleration; // 0x44
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float fanMaxSpeed; // 0x48
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private float speedoMax; // 0x4C
	[HeaderAttribute] // RVA: 0x947C0 Offset: 0x93BC0 VA: 0x1800947C0
	[SerializeField] // RVA: 0x947C0 Offset: 0x93BC0 VA: 0x1800947C0
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

