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

	// RVA: 0x9974E0 Offset: 0x995AE0 VA: 0x1809974E0
	public bool get_regenPoints() { }

	// RVA: 0x9974F0 Offset: 0x995AF0 VA: 0x1809974F0
	public void set_regenPoints(bool value) { }

	// RVA: 0x11D5190 Offset: 0x11D3790 VA: 0x1811D5190
	public Vector2 get_start() { }

	// RVA: 0x11D52C0 Offset: 0x11D38C0 VA: 0x1811D52C0
	public void set_start(Vector2 value) { }

	// RVA: 0x11D4F10 Offset: 0x11D3510 VA: 0x1811D4F10
	public Vector2 get_end() { }

	// RVA: 0x11D51B0 Offset: 0x11D37B0 VA: 0x1811D51B0
	public void set_end(Vector2 value) { }

	// RVA: 0x7746A0 Offset: 0x772CA0 VA: 0x1807746A0
	public float get_slack() { }

	// RVA: 0x11D5240 Offset: 0x11D3840 VA: 0x1811D5240
	public void set_slack(float value) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00
	public int get_steps() { }

	// RVA: 0x11D5350 Offset: 0x11D3950 VA: 0x1811D5350
	public void set_steps(int value) { }

	// RVA: 0x11D4F30 Offset: 0x11D3530 VA: 0x1811D4F30
	public Vector2 get_midPoint() { }

	// RVA: 0x11D4D50 Offset: 0x11D3350 VA: 0x1811D4D50
	public void .ctor() { }

	// RVA: 0x11D4E60 Offset: 0x11D3460 VA: 0x1811D4E60
	public void .ctor(Vector2[] inputPoints) { }

	// RVA: 0x11D4BF0 Offset: 0x11D31F0 VA: 0x1811D4BF0
	public void .ctor(List<Vector2> inputPoints) { }

	// RVA: 0x11D4CC0 Offset: 0x11D32C0 VA: 0x1811D4CC0
	public void .ctor(CableCurve v) { }

	// RVA: 0x11D4520 Offset: 0x11D2B20 VA: 0x1811D4520
	public Vector2[] Points() { }

	// RVA: 0x11D4B00 Offset: 0x11D3100 VA: 0x1811D4B00
	private static void .cctor() { }

}

