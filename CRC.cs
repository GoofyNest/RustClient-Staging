public class CRC // TypeDefIndex: 6564
{	// Fields
	private static byte[] byteBuffer; // 0x0
	private static readonly uint[] crc32_tab; // 0x8
	private static readonly ulong[] crc64_tab; // 0x10

	// Methods

	// RVA: 0x1BA0230 Offset: 0x1B9E830 VA: 0x181BA0230
	public static uint Compute32(uint crc, int i) { }

	// RVA: 0x1B9F610 Offset: 0x1B9DC10 VA: 0x181B9F610
	public static uint Compute32(uint crc, uint u) { }

	// RVA: 0x1B9F080 Offset: 0x1B9D680 VA: 0x181B9F080
	public static uint Compute32(uint crc, float f) { }

	// RVA: 0x1B9FF00 Offset: 0x1B9E500 VA: 0x181B9FF00
	public static uint Compute32(uint crc, long i) { }

	// RVA: 0x1B9F2E0 Offset: 0x1B9D8E0 VA: 0x181B9F2E0
	public static uint Compute32(uint crc, ulong u) { }

	// RVA: 0x1B9F840 Offset: 0x1B9DE40 VA: 0x181B9F840
	public static uint Compute32(uint crc, double f) { }

	// RVA: 0x1B9FD20 Offset: 0x1B9E320 VA: 0x181B9FD20
	public static uint Compute32(uint crc, string str) { }

	// RVA: 0x1B9FB90 Offset: 0x1B9E190 VA: 0x181B9FB90
	public static uint Compute32(string[] strs) { }

	// RVA: 0x1BA0AE0 Offset: 0x1B9F0E0 VA: 0x181BA0AE0
	public static ulong Compute64(ulong crc, int i) { }

	// RVA: 0x1BA1440 Offset: 0x1B9FA40 VA: 0x181BA1440
	public static ulong Compute64(ulong crc, uint u) { }

	// RVA: 0x1BA1050 Offset: 0x1B9F650 VA: 0x181BA1050
	public static ulong Compute64(ulong crc, float f) { }

	// RVA: 0x1BA0D20 Offset: 0x1B9F320 VA: 0x181BA0D20
	public static ulong Compute64(ulong crc, long i) { }

	// RVA: 0x1BA07B0 Offset: 0x1B9EDB0 VA: 0x181BA07B0
	public static ulong Compute64(ulong crc, ulong u) { }

	// RVA: 0x1BA0460 Offset: 0x1B9EA60 VA: 0x181BA0460
	public static ulong Compute64(ulong crc, double f) { }

	// RVA: 0x1BA1680 Offset: 0x1B9FC80 VA: 0x181BA1680
	public static ulong Compute64(ulong crc, string str) { }

	// RVA: 0x1BA12B0 Offset: 0x1B9F8B0 VA: 0x181BA12B0
	public static ulong Compute64(string[] strs) { }

	// RVA: 0x1BA1870 Offset: 0x1B9FE70 VA: 0x181BA1870
	private static int GrowByteBuffer(int count) { }

	// RVA: 0x1B9EE60 Offset: 0x1B9D460 VA: 0x181B9EE60
	private static uint CRC32(uint value, byte[] buf, ulong size) { }

	// RVA: 0x1B9EF70 Offset: 0x1B9D570 VA: 0x181B9EF70
	private static ulong CRC64(ulong value, byte[] buf, ulong size) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1BA1930 Offset: 0x1B9FF30 VA: 0x181BA1930
	private static void .cctor() { }

}

