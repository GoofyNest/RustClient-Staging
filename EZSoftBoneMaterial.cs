public class EZSoftBoneMaterial : ScriptableObject // TypeDefIndex: 7136
{	// Fields
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float m_Damping; // 0x18
	[SerializeField] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	[EZCurveRectAttribute] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	private AnimationCurve m_DampingCurve; // 0x20
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float m_Stiffness; // 0x28
	[SerializeField] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	[EZCurveRectAttribute] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	private AnimationCurve m_StiffnessCurve; // 0x30
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float m_Resistance; // 0x38
	[SerializeField] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	[EZCurveRectAttribute] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	private AnimationCurve m_ResistanceCurve; // 0x40
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float m_Slackness; // 0x48
	[SerializeField] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	[EZCurveRectAttribute] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	private AnimationCurve m_SlacknessCurve; // 0x50
	private static EZSoftBoneMaterial m_DefaultMaterial; // 0x0

	// Properties
	public float damping { get; set; }
	public AnimationCurve dampingCurve { get; }
	public float stiffness { get; set; }
	public AnimationCurve stiffnessCurve { get; }
	public float resistance { get; set; }
	public AnimationCurve resistanceCurve { get; }
	public float slackness { get; set; }
	public AnimationCurve slacknessCurve { get; }
	public static EZSoftBoneMaterial defaultMaterial { get; }

	// Methods

	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0
	public float get_damping() { }

	// RVA: 0x228F9C0 Offset: 0x228DFC0 VA: 0x18228F9C0
	public void set_damping(float value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AnimationCurve get_dampingCurve() { }

	// RVA: 0x862B30 Offset: 0x861130 VA: 0x180862B30
	public float get_stiffness() { }

	// RVA: 0x228FB10 Offset: 0x228E110 VA: 0x18228FB10
	public void set_stiffness(float value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public AnimationCurve get_stiffnessCurve() { }

	// RVA: 0x10B80E0 Offset: 0x10B66E0 VA: 0x1810B80E0
	public float get_resistance() { }

	// RVA: 0x228FA30 Offset: 0x228E030 VA: 0x18228FA30
	public void set_resistance(float value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public AnimationCurve get_resistanceCurve() { }

	// RVA: 0x6F0760 Offset: 0x6EED60 VA: 0x1806F0760
	public float get_slackness() { }

	// RVA: 0x228FAA0 Offset: 0x228E0A0 VA: 0x18228FAA0
	public void set_slackness(float value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public AnimationCurve get_slacknessCurve() { }

	// RVA: 0x228F8F0 Offset: 0x228DEF0 VA: 0x18228F8F0
	public static EZSoftBoneMaterial get_defaultMaterial() { }

	// RVA: 0x2239050 Offset: 0x2237650 VA: 0x182239050
	public float GetDamping(float t) { }

	// RVA: 0x2239110 Offset: 0x2237710 VA: 0x182239110
	public float GetStiffness(float t) { }

	// RVA: 0x2239090 Offset: 0x2237690 VA: 0x182239090
	public float GetResistance(float t) { }

	// RVA: 0x22390D0 Offset: 0x22376D0 VA: 0x1822390D0
	public float GetSlackness(float t) { }

	// RVA: 0x2239150 Offset: 0x2237750 VA: 0x182239150
	public void .ctor() { }

}

