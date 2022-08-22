public class BurstClothMaterial : ScriptableObject // TypeDefIndex: 7312
{	// Fields
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float _damping; // 0x18
	[SerializeField] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	[BurstClothCurveRectAttribute] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	private AnimationCurve _dampingCurve; // 0x20
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float _stiffness; // 0x28
	[SerializeField] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	[BurstClothCurveRectAttribute] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	private AnimationCurve _stiffnessCurve; // 0x30
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float _resistance; // 0x38
	[SerializeField] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	[BurstClothCurveRectAttribute] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	private AnimationCurve _resistanceCurve; // 0x40
	[SerializeField] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	[RangeAttribute] // RVA: 0x76630 Offset: 0x75A30 VA: 0x180076630
	private float _slackness; // 0x48
	[SerializeField] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
	[BurstClothCurveRectAttribute] // RVA: 0x834C0 Offset: 0x828C0 VA: 0x1800834C0
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

	// RVA: 0x2239050 Offset: 0x2237650 VA: 0x182239050
	public void set_Damping(float value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AnimationCurve get_DampingCurve() { }

	// RVA: 0x862A20 Offset: 0x861020 VA: 0x180862A20
	public float get_Stiffness() { }

	// RVA: 0x22391A0 Offset: 0x22377A0 VA: 0x1822391A0
	public void set_Stiffness(float value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public AnimationCurve get_StiffnessCurve() { }

	// RVA: 0x10B7E20 Offset: 0x10B6420 VA: 0x1810B7E20
	public float get_Resistance() { }

	// RVA: 0x22390C0 Offset: 0x22376C0 VA: 0x1822390C0
	public void set_Resistance(float value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public AnimationCurve get_ResistanceCurve() { }

	// RVA: 0x6F0650 Offset: 0x6EEC50 VA: 0x1806F0650
	public float get_Slackness() { }

	// RVA: 0x2239130 Offset: 0x2237730 VA: 0x182239130
	public void set_Slackness(float value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public AnimationCurve get_SlacknessCurve() { }

	// RVA: 0x2238F80 Offset: 0x2237580 VA: 0x182238F80
	public static BurstClothMaterial get_DefaultMaterial() { }

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

