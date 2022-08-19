public class EZSoftBoneMaterial : ScriptableObject // TypeDefIndex: 7136
{	// Fields
	[SerializeField] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	[RangeAttribute] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	private float m_Damping; // 0x18
	[SerializeField] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	[EZCurveRectAttribute] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	private AnimationCurve m_DampingCurve; // 0x20
	[SerializeField] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	[RangeAttribute] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	private float m_Stiffness; // 0x28
	[SerializeField] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	[EZCurveRectAttribute] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	private AnimationCurve m_StiffnessCurve; // 0x30
	[SerializeField] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	[RangeAttribute] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	private float m_Resistance; // 0x38
	[SerializeField] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	[EZCurveRectAttribute] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	private AnimationCurve m_ResistanceCurve; // 0x40
	[SerializeField] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	[RangeAttribute] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	private float m_Slackness; // 0x48
	[SerializeField] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	[EZCurveRectAttribute] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
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

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_damping() { }

	// RVA: 0x228F8C0 Offset: 0x228DEC0 VA: 0x18228F8C0
	public void set_damping(float value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AnimationCurve get_dampingCurve() { }

	// RVA: 0x862A20 Offset: 0x861020 VA: 0x180862A20
	public float get_stiffness() { }

	// RVA: 0x228FA10 Offset: 0x228E010 VA: 0x18228FA10
	public void set_stiffness(float value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public AnimationCurve get_stiffnessCurve() { }

	// RVA: 0x10B7E20 Offset: 0x10B6420 VA: 0x1810B7E20
	public float get_resistance() { }

	// RVA: 0x228F930 Offset: 0x228DF30 VA: 0x18228F930
	public void set_resistance(float value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public AnimationCurve get_resistanceCurve() { }

	// RVA: 0x6F0650 Offset: 0x6EEC50 VA: 0x1806F0650
	public float get_slackness() { }

	// RVA: 0x228F9A0 Offset: 0x228DFA0 VA: 0x18228F9A0
	public void set_slackness(float value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public AnimationCurve get_slacknessCurve() { }

	// RVA: 0x228F7F0 Offset: 0x228DDF0 VA: 0x18228F7F0
	public static EZSoftBoneMaterial get_defaultMaterial() { }

	// RVA: 0x2238F50 Offset: 0x2237550 VA: 0x182238F50
	public float GetDamping(float t) { }

	// RVA: 0x2239010 Offset: 0x2237610 VA: 0x182239010
	public float GetStiffness(float t) { }

	// RVA: 0x2238F90 Offset: 0x2237590 VA: 0x182238F90
	public float GetResistance(float t) { }

	// RVA: 0x2238FD0 Offset: 0x22375D0 VA: 0x182238FD0
	public float GetSlackness(float t) { }

	// RVA: 0x2239050 Offset: 0x2237650 VA: 0x182239050
	public void .ctor() { }

}

