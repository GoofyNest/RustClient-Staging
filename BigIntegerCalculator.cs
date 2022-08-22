internal static class BigIntegerCalculator // TypeDefIndex: 3965
{	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x222DB30 Offset: 0x222C130 VA: 0x18222DB30
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x222D970 Offset: 0x222BF70 VA: 0x18222D970
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x222DA80 Offset: 0x222C080 VA: 0x18222DA80
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222D900 Offset: 0x222BF00 VA: 0x18222D900
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x222EB50 Offset: 0x222D150 VA: 0x18222EB50
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x222EC40 Offset: 0x222D240 VA: 0x18222EC40
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x222EAA0 Offset: 0x222D0A0 VA: 0x18222EAA0
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222DC40 Offset: 0x222C240 VA: 0x18222DC40
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x222E8D0 Offset: 0x222CED0 VA: 0x18222E8D0
	public static uint[] Square(uint[] value) { }

	// RVA: 0x222E450 Offset: 0x222CA50 VA: 0x18222E450
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x222E250 Offset: 0x222C850 VA: 0x18222E250
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x222E340 Offset: 0x222C940 VA: 0x18222E340
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x222DCD0 Offset: 0x222C2D0 VA: 0x18222DCD0
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222E9A0 Offset: 0x222CFA0 VA: 0x18222E9A0
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x222EDA0 Offset: 0x222D3A0 VA: 0x18222EDA0
	private static void .cctor() { }

}

