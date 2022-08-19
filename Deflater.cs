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

	// RVA: 0x13B0360 Offset: 0x13AE960 VA: 0x1813B0360
	public void .ctor(int level, bool noZlibHeaderOrFooter) { }

	// RVA: 0x13AFD70 Offset: 0x13AE370 VA: 0x1813AFD70
	public void Reset() { }

	// RVA: 0x13B06C0 Offset: 0x13AECC0 VA: 0x1813B06C0
	public int get_TotalIn() { }

	// RVA: 0x13AFD00 Offset: 0x13AE300 VA: 0x1813AFD00
	public void Flush() { }

	// RVA: 0x13AFC90 Offset: 0x13AE290 VA: 0x1813AFC90
	public void Finish() { }

	// RVA: 0x13B0600 Offset: 0x13AEC00 VA: 0x1813B0600
	public bool get_IsFinished() { }

	// RVA: 0x13B0690 Offset: 0x13AEC90 VA: 0x1813B0690
	public bool get_IsNeedingInput() { }

	// RVA: 0x13AFF30 Offset: 0x13AE530 VA: 0x1813AFF30
	public void SetInput(byte[] input, int off, int len) { }

	// RVA: 0x13B00C0 Offset: 0x13AE6C0 VA: 0x1813B00C0
	public void SetLevel(int lvl) { }

	// RVA: 0x13B01E0 Offset: 0x13AE7E0 VA: 0x1813B01E0
	public void SetStrategy(DeflateStrategy strategy) { }

	// RVA: 0x13AF730 Offset: 0x13ADD30 VA: 0x1813AF730
	public int Deflate(byte[] output, int offset, int length) { }

	// RVA: 0x13B0200 Offset: 0x13AE800 VA: 0x1813B0200
	private static void .cctor() { }

}

