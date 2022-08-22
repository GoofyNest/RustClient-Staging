internal class Deflater // TypeDefIndex: 5656
{	// Fields
	public static int BEST_COMPRESSION; // 0x0
	public static int BEST_SPEED; // 0x4
	public static int DEFAULT_COMPRESSION; // 0x8
	public static int NO_COMPRESSION; // 0xC
	public static int DEFLATED; // 0x10
	private static int IS_SETDICT; // 0x14
	private static int IS_FLUSHING; // 0x18
	private static int IS_FINISHING; // 0x1C
	private static int INIT_STATE; // 0x20
	private static int SETDICT_STATE; // 0x24
	private static int BUSY_STATE; // 0x28
	private static int FLUSHING_STATE; // 0x2C
	private static int FINISHING_STATE; // 0x30
	private static int FINISHED_STATE; // 0x34
	private static int CLOSED_STATE; // 0x38
	private int level; // 0x10
	private bool noZlibHeaderOrFooter; // 0x14
	private int state; // 0x18
	private long totalOut; // 0x20
	private DeflaterPending pending; // 0x28
	private DeflaterEngine engine; // 0x30

	// Properties
	public int TotalIn { get; }
	public bool IsFinished { get; }
	public bool IsNeedingInput { get; }

	// Methods

	// RVA: 0x13AF720 Offset: 0x13ADD20 VA: 0x1813AF720
	public void .ctor(int level, bool noZlibHeaderOrFooter) { }

	// RVA: 0x13AF130 Offset: 0x13AD730 VA: 0x1813AF130
	public void Reset() { }

	// RVA: 0x13AFA80 Offset: 0x13AE080 VA: 0x1813AFA80
	public int get_TotalIn() { }

	// RVA: 0x13AF0C0 Offset: 0x13AD6C0 VA: 0x1813AF0C0
	public void Flush() { }

	// RVA: 0x13AF050 Offset: 0x13AD650 VA: 0x1813AF050
	public void Finish() { }

	// RVA: 0x13AF9C0 Offset: 0x13ADFC0 VA: 0x1813AF9C0
	public bool get_IsFinished() { }

	// RVA: 0x13AFA50 Offset: 0x13AE050 VA: 0x1813AFA50
	public bool get_IsNeedingInput() { }

	// RVA: 0x13AF2F0 Offset: 0x13AD8F0 VA: 0x1813AF2F0
	public void SetInput(byte[] input, int off, int len) { }

	// RVA: 0x13AF480 Offset: 0x13ADA80 VA: 0x1813AF480
	public void SetLevel(int lvl) { }

	// RVA: 0x13AF5A0 Offset: 0x13ADBA0 VA: 0x1813AF5A0
	public void SetStrategy(DeflateStrategy strategy) { }

	// RVA: 0x13AEAF0 Offset: 0x13AD0F0 VA: 0x1813AEAF0
	public int Deflate(byte[] output, int offset, int length) { }

	// RVA: 0x13AF5C0 Offset: 0x13ADBC0 VA: 0x1813AF5C0
	private static void .cctor() { }

}

