internal static class BigIntegerCalculator // TypeDefIndex: 3965
{	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x222D210 Offset: 0x222B810 VA: 0x18222D210
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x222D050 Offset: 0x222B650 VA: 0x18222D050
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x222D160 Offset: 0x222B760 VA: 0x18222D160
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222CFE0 Offset: 0x222B5E0 VA: 0x18222CFE0
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x222E230 Offset: 0x222C830 VA: 0x18222E230
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x222E320 Offset: 0x222C920 VA: 0x18222E320
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x222E180 Offset: 0x222C780 VA: 0x18222E180
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222D320 Offset: 0x222B920 VA: 0x18222D320
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x222DFB0 Offset: 0x222C5B0 VA: 0x18222DFB0
	public static uint[] Square(uint[] value) { }

	// RVA: 0x222DB30 Offset: 0x222C130 VA: 0x18222DB30
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x222D930 Offset: 0x222BF30 VA: 0x18222D930
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x222DA20 Offset: 0x222C020 VA: 0x18222DA20
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x222D3B0 Offset: 0x222B9B0 VA: 0x18222D3B0
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222E080 Offset: 0x222C680 VA: 0x18222E080
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x222E480 Offset: 0x222CA80 VA: 0x18222E480
	private static void .cctor() { }

}

