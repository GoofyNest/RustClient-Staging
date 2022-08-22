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

	// RVA: 0x215640 Offset: 0x214A40 VA: 0x180215640
	public void .ctor(object arg0) { }

	// RVA: 0x2157C0 Offset: 0x214BC0 VA: 0x1802157C0
	public void .ctor(object arg0, object arg1) { }

	// RVA: 0x215580 Offset: 0x214980 VA: 0x180215580
	public void .ctor(object arg0, object arg1, object arg2) { }

	// RVA: 0x2156E0 Offset: 0x214AE0 VA: 0x1802156E0
	public void .ctor(object[] args) { }

	// RVA: 0x2158E0 Offset: 0x214CE0 VA: 0x1802158E0
	public int get_Length() { }

	// RVA: 0x215880 Offset: 0x214C80 VA: 0x180215880
	public object get_Item(int index) { }

	// RVA: 0x215520 Offset: 0x214920 VA: 0x180215520
	private object GetAtSlow(int index) { }

	// RVA: 0x18D26D0 Offset: 0x18D0CD0 VA: 0x1818D26D0
	private static void .cctor() { }

}

