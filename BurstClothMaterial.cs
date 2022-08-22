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

	// RVA: 0x774710 Offset: 0x772D10 VA: 0x180774710
	public float get_Damping() { }

	// RVA: 0x2239B30 Offset: 0x2238130 VA: 0x182239B30
	public void set_Damping(float value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public AnimationCurve get_DampingCurve() { }

	// RVA: 0x87E290 Offset: 0x87C890 VA: 0x18087E290
	public float get_Stiffness() { }

	// RVA: 0x2239C80 Offset: 0x2238280 VA: 0x182239C80
	public void set_Stiffness(float value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public AnimationCurve get_StiffnessCurve() { }

	// RVA: 0x10B8B50 Offset: 0x10B7150 VA: 0x1810B8B50
	public float get_Resistance() { }

	// RVA: 0x2239BA0 Offset: 0x22381A0 VA: 0x182239BA0
	public void set_Resistance(float value) { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	public AnimationCurve get_ResistanceCurve() { }

	// RVA: 0x6F06F0 Offset: 0x6EECF0 VA: 0x1806F06F0
	public float get_Slackness() { }

	// RVA: 0x2239C10 Offset: 0x2238210 VA: 0x182239C10
	public void set_Slackness(float value) { }

	// RVA: 0x4CF800 Offset: 0x4CDE00 VA: 0x1804CF800
	public AnimationCurve get_SlacknessCurve() { }

	// RVA: 0x2239A60 Offset: 0x2238060 VA: 0x182239A60
	public static BurstClothMaterial get_DefaultMaterial() { }

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

