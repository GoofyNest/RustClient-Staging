public class CRC // TypeDefIndex: 6564
{	// Fields
	private static byte[] byteBuffer; // 0x0
	private static readonly uint[] crc32_tab; // 0x8
	private static readonly ulong[] crc64_tab; // 0x10

	// Methods

	// RVA: 0x1B9FA40 Offset: 0x1B9E040 VA: 0x181B9FA40
	public static uint Compute32(uint crc, int i) { }

	// RVA: 0x1B9EE20 Offset: 0x1B9D420 VA: 0x181B9EE20
	public static uint Compute32(uint crc, uint u) { }

	// RVA: 0x1B9E890 Offset: 0x1B9CE90 VA: 0x181B9E890
	public static uint Compute32(uint crc, float f) { }

	// RVA: 0x1B9F710 Offset: 0x1B9DD10 VA: 0x181B9F710
	public static uint Compute32(uint crc, long i) { }

	// RVA: 0x1B9EAF0 Offset: 0x1B9D0F0 VA: 0x181B9EAF0
	public static uint Compute32(uint crc, ulong u) { }

	// RVA: 0x1B9F050 Offset: 0x1B9D650 VA: 0x181B9F050
	public static uint Compute32(uint crc, double f) { }

	// RVA: 0x1B9F530 Offset: 0x1B9DB30 VA: 0x181B9F530
	public static uint Compute32(uint crc, string str) { }

	// RVA: 0x1B9F3A0 Offset: 0x1B9D9A0 VA: 0x181B9F3A0
	public static uint Compute32(string[] strs) { }

	// RVA: 0x1BA02F0 Offset: 0x1B9E8F0 VA: 0x181BA02F0
	public static ulong Compute64(ulong crc, int i) { }

	// RVA: 0x1BA0C50 Offset: 0x1B9F250 VA: 0x181BA0C50
	public static ulong Compute64(ulong crc, uint u) { }

	// RVA: 0x1BA0860 Offset: 0x1B9EE60 VA: 0x181BA0860
	public static ulong Compute64(ulong crc, float f) { }

	// RVA: 0x1BA0530 Offset: 0x1B9EB30 VA: 0x181BA0530
	public static ulong Compute64(ulong crc, long i) { }

	// RVA: 0x1B9FFC0 Offset: 0x1B9E5C0 VA: 0x181B9FFC0
	public static ulong Compute64(ulong crc, ulong u) { }

	// RVA: 0x1B9FC70 Offset: 0x1B9E270 VA: 0x181B9FC70
	public static ulong Compute64(ulong crc, double f) { }

	// RVA: 0x1BA0E90 Offset: 0x1B9F490 VA: 0x181BA0E90
	public static ulong Compute64(ulong crc, string str) { }

	// RVA: 0x1BA0AC0 Offset: 0x1B9F0C0 VA: 0x181BA0AC0
	public static ulong Compute64(string[] strs) { }

	// RVA: 0x1BA1080 Offset: 0x1B9F680 VA: 0x181BA1080
	private static int GrowByteBuffer(int count) { }

	// RVA: 0x1B9E670 Offset: 0x1B9CC70 VA: 0x181B9E670
	private static uint CRC32(uint value, byte[] buf, ulong size) { }

	// RVA: 0x1B9E780 Offset: 0x1B9CD80 VA: 0x181B9E780
	private static ulong CRC64(ulong value, byte[] buf, ulong size) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1BA1140 Offset: 0x1B9F740 VA: 0x181BA1140
	private static void .cctor() { }

}

