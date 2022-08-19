public class PatternFireworkShell : FireworkShell // TypeDefIndex: 8277
{	// Fields
	public GameObjectRef StarPrefab; // 0x58
	public AnimationCurve StarCurve; // 0x60
	public float Duration; // 0x68
	public float Scale; // 0x6C
	[HeaderAttribute] // RVA: 0xA4C40 Offset: 0xA4040 VA: 0x1800A4C40
	[MinMaxAttribute] // RVA: 0xA4C40 Offset: 0xA4040 VA: 0x1800A4C40
	public MinMax RandomSaturation; // 0x70
	[MinMaxAttribute] // RVA: 0xA4F30 Offset: 0xA4330 VA: 0x1800A4F30
	public MinMax RandomValue; // 0x78
	public float FuseLength; // 0x80
	private List<PatternFireworkStar> _stars; // 0x88
	private TimeSince _timeSinceExploded; // 0x90
	private Quaternion _direction; // 0x94
	private bool _completed; // 0xA4
	private PatternFirework.Design _design; // 0xA8

	// Methods

	// RVA: 0x86ACD0 Offset: 0x8692D0 VA: 0x18086ACD0 Slot: 6
	public override void Init(MortarFirework firework) { }

	// RVA: 0x86A7C0 Offset: 0x868DC0 VA: 0x18086A7C0 Slot: 8
	public override void Cleanup() { }

	// RVA: 0x86A730 Offset: 0x868D30 VA: 0x18086A730 Slot: 10
	public override float CalculateFuseLength() { }

	// RVA: 0x86B3D0 Offset: 0x8699D0 VA: 0x18086B3D0 Slot: 7
	public override void Update() { }

	// RVA: 0x86A820 Offset: 0x868E20 VA: 0x18086A820 Slot: 9
	public override void Explode() { }

	// RVA: 0x86B8D0 Offset: 0x869ED0 VA: 0x18086B8D0
	public void .ctor() { }

}

