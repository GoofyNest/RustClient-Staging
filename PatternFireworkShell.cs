public class PatternFireworkShell : FireworkShell // TypeDefIndex: 8277
{	// Fields
	public GameObjectRef StarPrefab; // 0x58
	public AnimationCurve StarCurve; // 0x60
	public float Duration; // 0x68
	public float Scale; // 0x6C
	[HeaderAttribute] // RVA: 0xA4CD0 Offset: 0xA40D0 VA: 0x1800A4CD0
	[MinMaxAttribute] // RVA: 0xA4CD0 Offset: 0xA40D0 VA: 0x1800A4CD0
	public MinMax RandomSaturation; // 0x70
	[MinMaxAttribute] // RVA: 0xA4FC0 Offset: 0xA43C0 VA: 0x1800A4FC0
	public MinMax RandomValue; // 0x78
	public float FuseLength; // 0x80
	private List<PatternFireworkStar> _stars; // 0x88
	private TimeSince _timeSinceExploded; // 0x90
	private Quaternion _direction; // 0x94
	private bool _completed; // 0xA4
	private PatternFirework.Design _design; // 0xA8

	// Methods

	// RVA: 0x886540 Offset: 0x884B40 VA: 0x180886540 Slot: 6
	public override void Init(MortarFirework firework) { }

	// RVA: 0x886030 Offset: 0x884630 VA: 0x180886030 Slot: 8
	public override void Cleanup() { }

	// RVA: 0x885FA0 Offset: 0x8845A0 VA: 0x180885FA0 Slot: 10
	public override float CalculateFuseLength() { }

	// RVA: 0x886C40 Offset: 0x885240 VA: 0x180886C40 Slot: 7
	public override void Update() { }

	// RVA: 0x886090 Offset: 0x884690 VA: 0x180886090 Slot: 9
	public override void Explode() { }

	// RVA: 0x887140 Offset: 0x885740 VA: 0x180887140
	public void .ctor() { }

}

