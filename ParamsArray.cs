internal struct ParamsArray // TypeDefIndex: 286
{	// Fields
	private static readonly object[] oneArgArray; // 0x0
	private static readonly object[] twoArgArray; // 0x8
	private static readonly object[] threeArgArray; // 0x10
	private readonly object arg0; // 0x0
	private readonly object arg1; // 0x8
	private readonly object arg2; // 0x10
	private readonly object[] args; // 0x18

	// Properties
	public int Length { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x215D10 Offset: 0x215110 VA: 0x180215D10
	public void .ctor(object arg0) { }

	// RVA: 0x215E90 Offset: 0x215290 VA: 0x180215E90
	public void .ctor(object arg0, object arg1) { }

	// RVA: 0x215C50 Offset: 0x215050 VA: 0x180215C50
	public void .ctor(object arg0, object arg1, object arg2) { }

	// RVA: 0x215DB0 Offset: 0x2151B0 VA: 0x180215DB0
	public void .ctor(object[] args) { }

	// RVA: 0x215FB0 Offset: 0x2153B0 VA: 0x180215FB0
	public int get_Length() { }

	// RVA: 0x215F50 Offset: 0x215350 VA: 0x180215F50
	public object get_Item(int index) { }

	// RVA: 0x215BF0 Offset: 0x214FF0 VA: 0x180215BF0
	private object GetAtSlow(int index) { }

	// RVA: 0x18D1DF0 Offset: 0x18D03F0 VA: 0x1818D1DF0
	private static void .cctor() { }

}

