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

	// RVA: 0x137730 Offset: 0x136B30 VA: 0x180137730
	public void .ctor(int min, int max) { }

	// RVA: 0x1377A0 Offset: 0x136BA0 VA: 0x1801377A0
	public int get_Count() { }

	// RVA: 0x1377C0 Offset: 0x136BC0 VA: 0x1801377C0
	public bool get_IsNull() { }

	// RVA: 0x1377D0 Offset: 0x136BD0 VA: 0x1801377D0
	public int get_Min() { }

	// RVA: 0x1376E0 Offset: 0x136AE0 VA: 0x1801376E0
	internal void CheckNull() { }

}

