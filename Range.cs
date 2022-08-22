internal struct Range // TypeDefIndex: 4283
{	// Fields
	private int _min; // 0x0
	private int _max; // 0x4
	private bool _isNotNull; // 0x8

	// Properties
	public int Count { get; }
	public bool IsNull { get; }
	public int Min { get; }

	// Methods

	// RVA: 0x137550 Offset: 0x136950 VA: 0x180137550
	public void .ctor(int min, int max) { }

	// RVA: 0x1375C0 Offset: 0x1369C0 VA: 0x1801375C0
	public int get_Count() { }

	// RVA: 0x1375E0 Offset: 0x1369E0 VA: 0x1801375E0
	public bool get_IsNull() { }

	// RVA: 0x1375F0 Offset: 0x1369F0 VA: 0x1801375F0
	public int get_Min() { }

	// RVA: 0x137500 Offset: 0x136900 VA: 0x180137500
	internal void CheckNull() { }

}

