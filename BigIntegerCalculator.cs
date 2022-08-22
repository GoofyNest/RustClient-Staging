internal static class BigIntegerCalculator // TypeDefIndex: 3965
{	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x222D050 Offset: 0x222B650 VA: 0x18222D050
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x222CE90 Offset: 0x222B490 VA: 0x18222CE90
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x222CFA0 Offset: 0x222B5A0 VA: 0x18222CFA0
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222CE20 Offset: 0x222B420 VA: 0x18222CE20
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x222E070 Offset: 0x222C670 VA: 0x18222E070
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x222E160 Offset: 0x222C760 VA: 0x18222E160
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x222DFC0 Offset: 0x222C5C0 VA: 0x18222DFC0
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222D160 Offset: 0x222B760 VA: 0x18222D160
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x222DDF0 Offset: 0x222C3F0 VA: 0x18222DDF0
	public static uint[] Square(uint[] value) { }

	// RVA: 0x222D970 Offset: 0x222BF70 VA: 0x18222D970
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x222D770 Offset: 0x222BD70 VA: 0x18222D770
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x222D860 Offset: 0x222BE60 VA: 0x18222D860
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x222D1F0 Offset: 0x222B7F0 VA: 0x18222D1F0
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222DEC0 Offset: 0x222C4C0 VA: 0x18222DEC0
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x222E2C0 Offset: 0x222C8C0 VA: 0x18222E2C0
	private static void .cctor() { }

}

