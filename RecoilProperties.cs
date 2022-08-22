public class RecoilProperties : ScriptableObject // TypeDefIndex: 10756
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
	[HeaderAttribute] // RVA: 0x79F10 Offset: 0x79310 VA: 0x180079F10
	public bool overrideAimconeWithCurve; // 0x5C
	public float aimconeCurveScale; // 0x60
	[TooltipAttribute] // RVA: 0x7A010 Offset: 0x79410 VA: 0x18007A010
	public AnimationCurve aimconeCurve; // 0x68
	[TooltipAttribute] // RVA: 0x7A2F0 Offset: 0x796F0 VA: 0x18007A2F0
	public AnimationCurve aimconeProbabilityCurve; // 0x70
	public RecoilProperties newRecoilOverride; // 0x78


	public RecoilProperties GetRecoil() { }

	public void .ctor() { }

}

