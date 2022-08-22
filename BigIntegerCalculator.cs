internal static class BigIntegerCalculator // TypeDefIndex: 3965
{	// Fields
	private static int ReducerThreshold; // 0x0
	private static int SquareThreshold; // 0x4
	private static int AllocationThreshold; // 0x8
	private static int MultiplyThreshold; // 0xC

	// Methods

	// RVA: 0x222D310 Offset: 0x222B910 VA: 0x18222D310
	public static uint[] Add(uint[] left, uint right) { }

	// RVA: 0x222D150 Offset: 0x222B750 VA: 0x18222D150
	public static uint[] Add(uint[] left, uint[] right) { }

	// RVA: 0x222D260 Offset: 0x222B860 VA: 0x18222D260
	private static void Add(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222D0E0 Offset: 0x222B6E0 VA: 0x18222D0E0
	private static void AddSelf(uint* left, int leftLength, uint* right, int rightLength) { }

	// RVA: 0x222E330 Offset: 0x222C930 VA: 0x18222E330
	public static uint[] Subtract(uint[] left, uint right) { }

	// RVA: 0x222E420 Offset: 0x222CA20 VA: 0x18222E420
	public static uint[] Subtract(uint[] left, uint[] right) { }

	// RVA: 0x222E280 Offset: 0x222C880 VA: 0x18222E280
	private static void Subtract(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222D420 Offset: 0x222BA20 VA: 0x18222D420
	public static int Compare(uint[] left, uint[] right) { }

	// RVA: 0x222E0B0 Offset: 0x222C6B0 VA: 0x18222E0B0
	public static uint[] Square(uint[] value) { }

	// RVA: 0x222DC30 Offset: 0x222C230 VA: 0x18222DC30
	private static void Square(uint* value, int valueLength, uint* bits, int bitsLength) { }

	// RVA: 0x222DA30 Offset: 0x222C030 VA: 0x18222DA30
	public static uint[] Multiply(uint[] left, uint right) { }

	// RVA: 0x222DB20 Offset: 0x222C120 VA: 0x18222DB20
	public static uint[] Multiply(uint[] left, uint[] right) { }

	// RVA: 0x222D4B0 Offset: 0x222BAB0 VA: 0x18222D4B0
	private static void Multiply(uint* left, int leftLength, uint* right, int rightLength, uint* bits, int bitsLength) { }

	// RVA: 0x222E180 Offset: 0x222C780 VA: 0x18222E180
	private static void SubtractCore(uint* left, int leftLength, uint* right, int rightLength, uint* core, int coreLength) { }

	// RVA: 0x222E580 Offset: 0x222CB80 VA: 0x18222E580
	private static void .cctor() { }

}

