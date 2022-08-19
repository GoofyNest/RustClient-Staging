public class BurstClothMaterial : ScriptableObject // TypeDefIndex: 7312
{	// Fields
	[SerializeField] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	[RangeAttribute] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	private float _damping; // 0x18
	[SerializeField] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	[BurstClothCurveRectAttribute] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	private AnimationCurve _dampingCurve; // 0x20
	[SerializeField] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	[RangeAttribute] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	private float _stiffness; // 0x28
	[SerializeField] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	[BurstClothCurveRectAttribute] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	private AnimationCurve _stiffnessCurve; // 0x30
	[SerializeField] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	[RangeAttribute] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	private float _resistance; // 0x38
	[SerializeField] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	[BurstClothCurveRectAttribute] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	private AnimationCurve _resistanceCurve; // 0x40
	[SerializeField] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	[RangeAttribute] // RVA: 0x764E0 Offset: 0x758E0 VA: 0x1800764E0
	private float _slackness; // 0x48
	[SerializeField] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	[BurstClothCurveRectAttribute] // RVA: 0x83450 Offset: 0x82850 VA: 0x180083450
	private AnimationCurve _slacknessCurve; // 0x50
	private static BurstClothMaterial _defaultMaterial; // 0x0

	// Properties
	public float Damping { get; set; }
	public AnimationCurve DampingCurve { get; }
	public float Stiffness { get; set; }
	public AnimationCurve StiffnessCurve { get; }
	public float Resistance { get; set; }
	public AnimationCurve ResistanceCurve { get; }
	public float Slackness { get; set; }
	public AnimationCurve SlacknessCurve { get; }
	public static BurstClothMaterial DefaultMaterial { get; }

	// Methods

	// RVA: 0x7746B0 Offset: 0x772CB0 VA: 0x1807746B0
	public float get_Damping() { }

	// RVA: 0x2239210 Offset: 0x2237810 VA: 0x182239210
	public void set_Damping(float value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AnimationCurve get_DampingCurve() { }

	// RVA: 0x862A20 Offset: 0x861020 VA: 0x180862A20
	public float get_Stiffness() { }

	// RVA: 0x2239360 Offset: 0x2237960 VA: 0x182239360
	public void set_Stiffness(float value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public AnimationCurve get_StiffnessCurve() { }

	// RVA: 0x10B7E20 Offset: 0x10B6420 VA: 0x1810B7E20
	public float get_Resistance() { }

	// RVA: 0x2239280 Offset: 0x2237880 VA: 0x182239280
	public void set_Resistance(float value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public AnimationCurve get_ResistanceCurve() { }

	// RVA: 0x6F0650 Offset: 0x6EEC50 VA: 0x1806F0650
	public float get_Slackness() { }

	// RVA: 0x22392F0 Offset: 0x22378F0 VA: 0x1822392F0
	public void set_Slackness(float value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public AnimationCurve get_SlacknessCurve() { }

	// RVA: 0x2239140 Offset: 0x2237740 VA: 0x182239140
	public static BurstClothMaterial get_DefaultMaterial() { }

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

