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

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_damping() { }

	// RVA: 0x228F700 Offset: 0x228DD00 VA: 0x18228F700
	public void set_damping(float value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AnimationCurve get_dampingCurve() { }

	// RVA: 0x862A20 Offset: 0x861020 VA: 0x180862A20
	public float get_stiffness() { }

	// RVA: 0x228F850 Offset: 0x228DE50 VA: 0x18228F850
	public void set_stiffness(float value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public AnimationCurve get_stiffnessCurve() { }

	// RVA: 0x10B7E20 Offset: 0x10B6420 VA: 0x1810B7E20
	public float get_resistance() { }

	// RVA: 0x228F770 Offset: 0x228DD70 VA: 0x18228F770
	public void set_resistance(float value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public AnimationCurve get_resistanceCurve() { }

	// RVA: 0x6F0650 Offset: 0x6EEC50 VA: 0x1806F0650
	public float get_slackness() { }

	// RVA: 0x228F7E0 Offset: 0x228DDE0 VA: 0x18228F7E0
	public void set_slackness(float value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public AnimationCurve get_slacknessCurve() { }

	// RVA: 0x228F630 Offset: 0x228DC30 VA: 0x18228F630
	public static EZSoftBoneMaterial get_defaultMaterial() { }

	// RVA: 0x2238D90 Offset: 0x2237390 VA: 0x182238D90
	public float GetDamping(float t) { }

	// RVA: 0x2238E50 Offset: 0x2237450 VA: 0x182238E50
	public float GetStiffness(float t) { }

	// RVA: 0x2238DD0 Offset: 0x22373D0 VA: 0x182238DD0
	public float GetResistance(float t) { }

	// RVA: 0x2238E10 Offset: 0x2237410 VA: 0x182238E10
	public float GetSlackness(float t) { }

	// RVA: 0x2238E90 Offset: 0x2237490 VA: 0x182238E90
	public void .ctor() { }

}

