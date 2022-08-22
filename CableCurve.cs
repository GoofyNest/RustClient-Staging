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

	// RVA: 0x997AE0 Offset: 0x9960E0 VA: 0x180997AE0
	public bool get_regenPoints() { }

	// RVA: 0x997AF0 Offset: 0x9960F0 VA: 0x180997AF0
	public void set_regenPoints(bool value) { }

	// RVA: 0x11D5AF0 Offset: 0x11D40F0 VA: 0x1811D5AF0
	public Vector2 get_start() { }

	// RVA: 0x11D5C20 Offset: 0x11D4220 VA: 0x1811D5C20
	public void set_start(Vector2 value) { }

	// RVA: 0x11D5870 Offset: 0x11D3E70 VA: 0x1811D5870
	public Vector2 get_end() { }

	// RVA: 0x11D5B10 Offset: 0x11D4110 VA: 0x1811D5B10
	public void set_end(Vector2 value) { }

	// RVA: 0x774700 Offset: 0x772D00 VA: 0x180774700
	public float get_slack() { }

	// RVA: 0x11D5BA0 Offset: 0x11D41A0 VA: 0x1811D5BA0
	public void set_slack(float value) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630
	public int get_steps() { }

	// RVA: 0x11D5CB0 Offset: 0x11D42B0 VA: 0x1811D5CB0
	public void set_steps(int value) { }

	// RVA: 0x11D5890 Offset: 0x11D3E90 VA: 0x1811D5890
	public Vector2 get_midPoint() { }

	// RVA: 0x11D56B0 Offset: 0x11D3CB0 VA: 0x1811D56B0
	public void .ctor() { }

	// RVA: 0x11D57C0 Offset: 0x11D3DC0 VA: 0x1811D57C0
	public void .ctor(Vector2[] inputPoints) { }

	// RVA: 0x11D5550 Offset: 0x11D3B50 VA: 0x1811D5550
	public void .ctor(List<Vector2> inputPoints) { }

	// RVA: 0x11D5620 Offset: 0x11D3C20 VA: 0x1811D5620
	public void .ctor(CableCurve v) { }

	// RVA: 0x11D4E80 Offset: 0x11D3480 VA: 0x1811D4E80
	public Vector2[] Points() { }

	// RVA: 0x11D5460 Offset: 0x11D3A60 VA: 0x1811D5460
	private static void .cctor() { }

}

