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

	// RVA: 0x2156C0 Offset: 0x214AC0 VA: 0x1802156C0
	public void .ctor(object arg0) { }

	// RVA: 0x215840 Offset: 0x214C40 VA: 0x180215840
	public void .ctor(object arg0, object arg1) { }

	// RVA: 0x215600 Offset: 0x214A00 VA: 0x180215600
	public void .ctor(object arg0, object arg1, object arg2) { }

	// RVA: 0x215760 Offset: 0x214B60 VA: 0x180215760
	public void .ctor(object[] args) { }

	// RVA: 0x215960 Offset: 0x214D60 VA: 0x180215960
	public int get_Length() { }

	// RVA: 0x215900 Offset: 0x214D00 VA: 0x180215900
	public object get_Item(int index) { }

	// RVA: 0x2155A0 Offset: 0x2149A0 VA: 0x1802155A0
	private object GetAtSlow(int index) { }

	// RVA: 0x18D2450 Offset: 0x18D0A50 VA: 0x1818D2450
	private static void .cctor() { }

}

