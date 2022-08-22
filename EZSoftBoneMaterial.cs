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

	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
	public float get_damping() { }

	// RVA: 0x22901E0 Offset: 0x228E7E0 VA: 0x1822901E0
	public void set_damping(float value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AnimationCurve get_dampingCurve() { }

	// RVA: 0x87E290 Offset: 0x87C890 VA: 0x18087E290
	public float get_stiffness() { }

	// RVA: 0x2290330 Offset: 0x228E930 VA: 0x182290330
	public void set_stiffness(float value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public AnimationCurve get_stiffnessCurve() { }

	// RVA: 0x10B8B50 Offset: 0x10B7150 VA: 0x1810B8B50
	public float get_resistance() { }

	// RVA: 0x2290250 Offset: 0x228E850 VA: 0x182290250
	public void set_resistance(float value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public AnimationCurve get_resistanceCurve() { }

	// RVA: 0x6F06F0 Offset: 0x6EECF0 VA: 0x1806F06F0
	public float get_slackness() { }

	// RVA: 0x22902C0 Offset: 0x228E8C0 VA: 0x1822902C0
	public void set_slackness(float value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public AnimationCurve get_slacknessCurve() { }

	// RVA: 0x2290110 Offset: 0x228E710 VA: 0x182290110
	public static EZSoftBoneMaterial get_defaultMaterial() { }

	// RVA: 0x2239870 Offset: 0x2237E70 VA: 0x182239870
	public float GetDamping(float t) { }

	// RVA: 0x2239930 Offset: 0x2237F30 VA: 0x182239930
	public float GetStiffness(float t) { }

	// RVA: 0x22398B0 Offset: 0x2237EB0 VA: 0x1822398B0
	public float GetResistance(float t) { }

	// RVA: 0x22398F0 Offset: 0x2237EF0 VA: 0x1822398F0
	public float GetSlackness(float t) { }

	// RVA: 0x2239970 Offset: 0x2237F70 VA: 0x182239970
	public void .ctor() { }

}

