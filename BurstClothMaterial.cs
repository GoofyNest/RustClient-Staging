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

	// RVA: 0x7747C0 Offset: 0x772DC0 VA: 0x1807747C0
	public float get_Damping() { }

	// RVA: 0x2239310 Offset: 0x2237910 VA: 0x182239310
	public void set_Damping(float value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AnimationCurve get_DampingCurve() { }

	// RVA: 0x862B30 Offset: 0x861130 VA: 0x180862B30
	public float get_Stiffness() { }

	// RVA: 0x2239460 Offset: 0x2237A60 VA: 0x182239460
	public void set_Stiffness(float value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public AnimationCurve get_StiffnessCurve() { }

	// RVA: 0x10B80E0 Offset: 0x10B66E0 VA: 0x1810B80E0
	public float get_Resistance() { }

	// RVA: 0x2239380 Offset: 0x2237980 VA: 0x182239380
	public void set_Resistance(float value) { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	public AnimationCurve get_ResistanceCurve() { }

	// RVA: 0x6F0760 Offset: 0x6EED60 VA: 0x1806F0760
	public float get_Slackness() { }

	// RVA: 0x22393F0 Offset: 0x22379F0 VA: 0x1822393F0
	public void set_Slackness(float value) { }

	// RVA: 0x4CF870 Offset: 0x4CDE70 VA: 0x1804CF870
	public AnimationCurve get_SlacknessCurve() { }

	// RVA: 0x2239240 Offset: 0x2237840 VA: 0x182239240
	public static BurstClothMaterial get_DefaultMaterial() { }

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

