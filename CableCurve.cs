public class CableCurve // TypeDefIndex: 11737
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 m_start; // 0x10
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2 m_end; // 0x18
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private float m_slack; // 0x20
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int m_steps; // 0x24
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool m_regen; // 0x28
	private static Vector2[] emptyCurve; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Vector2[] points; // 0x30

	// Properties
	public bool regenPoints { get; set; }
	public Vector2 start { get; set; }
	public Vector2 end { get; set; }
	public float slack { get; set; }
	public int steps { get; set; }
	public Vector2 midPoint { get; }

	// Methods

	// RVA: 0x9975F0 Offset: 0x995BF0 VA: 0x1809975F0
	public bool get_regenPoints() { }

	// RVA: 0x997600 Offset: 0x995C00 VA: 0x180997600
	public void set_regenPoints(bool value) { }

	// RVA: 0x11D5450 Offset: 0x11D3A50 VA: 0x1811D5450
	public Vector2 get_start() { }

	// RVA: 0x11D5580 Offset: 0x11D3B80 VA: 0x1811D5580
	public void set_start(Vector2 value) { }

	// RVA: 0x11D51D0 Offset: 0x11D37D0 VA: 0x1811D51D0
	public Vector2 get_end() { }

	// RVA: 0x11D5470 Offset: 0x11D3A70 VA: 0x1811D5470
	public void set_end(Vector2 value) { }

	// RVA: 0x7747B0 Offset: 0x772DB0 VA: 0x1807747B0
	public float get_slack() { }

	// RVA: 0x11D5500 Offset: 0x11D3B00 VA: 0x1811D5500
	public void set_slack(float value) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10
	public int get_steps() { }

	// RVA: 0x11D5610 Offset: 0x11D3C10 VA: 0x1811D5610
	public void set_steps(int value) { }

	// RVA: 0x11D51F0 Offset: 0x11D37F0 VA: 0x1811D51F0
	public Vector2 get_midPoint() { }

	// RVA: 0x11D5010 Offset: 0x11D3610 VA: 0x1811D5010
	public void .ctor() { }

	// RVA: 0x11D5120 Offset: 0x11D3720 VA: 0x1811D5120
	public void .ctor(Vector2[] inputPoints) { }

	// RVA: 0x11D4EB0 Offset: 0x11D34B0 VA: 0x1811D4EB0
	public void .ctor(List<Vector2> inputPoints) { }

	// RVA: 0x11D4F80 Offset: 0x11D3580 VA: 0x1811D4F80
	public void .ctor(CableCurve v) { }

	// RVA: 0x11D47E0 Offset: 0x11D2DE0 VA: 0x1811D47E0
	public Vector2[] Points() { }

	// RVA: 0x11D4DC0 Offset: 0x11D33C0 VA: 0x1811D4DC0
	private static void .cctor() { }

}

