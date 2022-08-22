public class CRC // TypeDefIndex: 6564
{	// Fields
	private static byte[] byteBuffer; // 0x0
	private static readonly uint[] crc32_tab; // 0x8
	private static readonly ulong[] crc64_tab; // 0x10

	// Methods

	// RVA: 0x1B9F780 Offset: 0x1B9DD80 VA: 0x181B9F780
	public static uint Compute32(uint crc, int i) { }

	// RVA: 0x1B9EB60 Offset: 0x1B9D160 VA: 0x181B9EB60
	public static uint Compute32(uint crc, uint u) { }

	// RVA: 0x1B9E5D0 Offset: 0x1B9CBD0 VA: 0x181B9E5D0
	public static uint Compute32(uint crc, float f) { }

	// RVA: 0x1B9F450 Offset: 0x1B9DA50 VA: 0x181B9F450
	public static uint Compute32(uint crc, long i) { }

	// RVA: 0x1B9E830 Offset: 0x1B9CE30 VA: 0x181B9E830
	public static uint Compute32(uint crc, ulong u) { }

	// RVA: 0x1B9ED90 Offset: 0x1B9D390 VA: 0x181B9ED90
	public static uint Compute32(uint crc, double f) { }

	// RVA: 0x1B9F270 Offset: 0x1B9D870 VA: 0x181B9F270
	public static uint Compute32(uint crc, string str) { }

	// RVA: 0x1B9F0E0 Offset: 0x1B9D6E0 VA: 0x181B9F0E0
	public static uint Compute32(string[] strs) { }

	// RVA: 0x1BA0030 Offset: 0x1B9E630 VA: 0x181BA0030
	public static ulong Compute64(ulong crc, int i) { }

	// RVA: 0x1BA0990 Offset: 0x1B9EF90 VA: 0x181BA0990
	public static ulong Compute64(ulong crc, uint u) { }

	// RVA: 0x1BA05A0 Offset: 0x1B9EBA0 VA: 0x181BA05A0
	public static ulong Compute64(ulong crc, float f) { }

	// RVA: 0x1BA0270 Offset: 0x1B9E870 VA: 0x181BA0270
	public static ulong Compute64(ulong crc, long i) { }

	// RVA: 0x1B9FD00 Offset: 0x1B9E300 VA: 0x181B9FD00
	public static ulong Compute64(ulong crc, ulong u) { }

	// RVA: 0x1B9F9B0 Offset: 0x1B9DFB0 VA: 0x181B9F9B0
	public static ulong Compute64(ulong crc, double f) { }

	// RVA: 0x1BA0BD0 Offset: 0x1B9F1D0 VA: 0x181BA0BD0
	public static ulong Compute64(ulong crc, string str) { }

	// RVA: 0x1BA0800 Offset: 0x1B9EE00 VA: 0x181BA0800
	public static ulong Compute64(string[] strs) { }

	// RVA: 0x1BA0DC0 Offset: 0x1B9F3C0 VA: 0x181BA0DC0
	private static int GrowByteBuffer(int count) { }

	// RVA: 0x1B9E3B0 Offset: 0x1B9C9B0 VA: 0x181B9E3B0
	private static uint CRC32(uint value, byte[] buf, ulong size) { }

	// RVA: 0x1B9E4C0 Offset: 0x1B9CAC0 VA: 0x181B9E4C0
	private static ulong CRC64(ulong value, byte[] buf, ulong size) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1BA0E80 Offset: 0x1B9F480 VA: 0x181BA0E80
	private static void .cctor() { }

}

