public class RecoilProperties : ScriptableObject // TypeDefIndex: 10760
{	public float recoilYawMin; // 0x18
	public float recoilYawMax; // 0x1C
	public float recoilPitchMin; // 0x20
	public float recoilPitchMax; // 0x24
	public float timeToTakeMin; // 0x28
	public float timeToTakeMax; // 0x2C
	public float ADSScale; // 0x30
	public float movementPenalty; // 0x34
	public float clampPitch; // 0x38
	public AnimationCurve pitchCurve; // 0x40
	public AnimationCurve yawCurve; // 0x48
	public bool useCurves; // 0x50
	public bool curvesAsScalar; // 0x51
	public int shotsUntilMax; // 0x54
	public float maxRecoilRadius; // 0x58
	[HeaderAttribute] // RVA: 0x783C0 Offset: 0x777C0 VA: 0x1800783C0
	public bool overrideAimconeWithCurve; // 0x5C
	public float aimconeCurveScale; // 0x60
	[TooltipAttribute] // RVA: 0x78540 Offset: 0x77940 VA: 0x180078540
	public AnimationCurve aimconeCurve; // 0x68
	[TooltipAttribute] // RVA: 0x78640 Offset: 0x77A40 VA: 0x180078640
	public AnimationCurve aimconeProbabilityCurve; // 0x70
	public RecoilProperties newRecoilOverride; // 0x78


	public RecoilProperties GetRecoil() { }

	public void .ctor() { }

}

