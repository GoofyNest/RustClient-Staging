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

	// RVA: 0x1377B0 Offset: 0x136BB0 VA: 0x1801377B0
	public void .ctor(int min, int max) { }

	// RVA: 0x137820 Offset: 0x136C20 VA: 0x180137820
	public int get_Count() { }

	// RVA: 0x137840 Offset: 0x136C40 VA: 0x180137840
	public bool get_IsNull() { }

	// RVA: 0x137850 Offset: 0x136C50 VA: 0x180137850
	public int get_Min() { }

	// RVA: 0x137760 Offset: 0x136B60 VA: 0x180137760
	internal void CheckNull() { }

}

