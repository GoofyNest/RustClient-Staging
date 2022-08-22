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

	// RVA: 0x13B0620 Offset: 0x13AEC20 VA: 0x1813B0620
	public void .ctor(int level, bool noZlibHeaderOrFooter) { }

	// RVA: 0x13B0030 Offset: 0x13AE630 VA: 0x1813B0030
	public void Reset() { }

	// RVA: 0x13B0980 Offset: 0x13AEF80 VA: 0x1813B0980
	public int get_TotalIn() { }

	// RVA: 0x13AFFC0 Offset: 0x13AE5C0 VA: 0x1813AFFC0
	public void Flush() { }

	// RVA: 0x13AFF50 Offset: 0x13AE550 VA: 0x1813AFF50
	public void Finish() { }

	// RVA: 0x13B08C0 Offset: 0x13AEEC0 VA: 0x1813B08C0
	public bool get_IsFinished() { }

	// RVA: 0x13B0950 Offset: 0x13AEF50 VA: 0x1813B0950
	public bool get_IsNeedingInput() { }

	// RVA: 0x13B01F0 Offset: 0x13AE7F0 VA: 0x1813B01F0
	public void SetInput(byte[] input, int off, int len) { }

	// RVA: 0x13B0380 Offset: 0x13AE980 VA: 0x1813B0380
	public void SetLevel(int lvl) { }

	// RVA: 0x13B04A0 Offset: 0x13AEAA0 VA: 0x1813B04A0
	public void SetStrategy(DeflateStrategy strategy) { }

	// RVA: 0x13AF9F0 Offset: 0x13ADFF0 VA: 0x1813AF9F0
	public int Deflate(byte[] output, int offset, int length) { }

	// RVA: 0x13B04C0 Offset: 0x13AEAC0 VA: 0x1813B04C0
	private static void .cctor() { }

}

