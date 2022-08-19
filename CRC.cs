public class CRC // TypeDefIndex: 6564
{	// Fields
	private static byte[] byteBuffer; // 0x0
	private static readonly uint[] crc32_tab; // 0x8
	private static readonly ulong[] crc64_tab; // 0x10

	// Methods

	// RVA: 0x1B9F940 Offset: 0x1B9DF40 VA: 0x181B9F940
	public static uint Compute32(uint crc, int i) { }

	// RVA: 0x1B9ED20 Offset: 0x1B9D320 VA: 0x181B9ED20
	public static uint Compute32(uint crc, uint u) { }

	// RVA: 0x1B9E790 Offset: 0x1B9CD90 VA: 0x181B9E790
	public static uint Compute32(uint crc, float f) { }

	// RVA: 0x1B9F610 Offset: 0x1B9DC10 VA: 0x181B9F610
	public static uint Compute32(uint crc, long i) { }

	// RVA: 0x1B9E9F0 Offset: 0x1B9CFF0 VA: 0x181B9E9F0
	public static uint Compute32(uint crc, ulong u) { }

	// RVA: 0x1B9EF50 Offset: 0x1B9D550 VA: 0x181B9EF50
	public static uint Compute32(uint crc, double f) { }

	// RVA: 0x1B9F430 Offset: 0x1B9DA30 VA: 0x181B9F430
	public static uint Compute32(uint crc, string str) { }

	// RVA: 0x1B9F2A0 Offset: 0x1B9D8A0 VA: 0x181B9F2A0
	public static uint Compute32(string[] strs) { }

	// RVA: 0x1BA01F0 Offset: 0x1B9E7F0 VA: 0x181BA01F0
	public static ulong Compute64(ulong crc, int i) { }

	// RVA: 0x1BA0B50 Offset: 0x1B9F150 VA: 0x181BA0B50
	public static ulong Compute64(ulong crc, uint u) { }

	// RVA: 0x1BA0760 Offset: 0x1B9ED60 VA: 0x181BA0760
	public static ulong Compute64(ulong crc, float f) { }

	// RVA: 0x1BA0430 Offset: 0x1B9EA30 VA: 0x181BA0430
	public static ulong Compute64(ulong crc, long i) { }

	// RVA: 0x1B9FEC0 Offset: 0x1B9E4C0 VA: 0x181B9FEC0
	public static ulong Compute64(ulong crc, ulong u) { }

	// RVA: 0x1B9FB70 Offset: 0x1B9E170 VA: 0x181B9FB70
	public static ulong Compute64(ulong crc, double f) { }

	// RVA: 0x1BA0D90 Offset: 0x1B9F390 VA: 0x181BA0D90
	public static ulong Compute64(ulong crc, string str) { }

	// RVA: 0x1BA09C0 Offset: 0x1B9EFC0 VA: 0x181BA09C0
	public static ulong Compute64(string[] strs) { }

	// RVA: 0x1BA0F80 Offset: 0x1B9F580 VA: 0x181BA0F80
	private static int GrowByteBuffer(int count) { }

	// RVA: 0x1B9E570 Offset: 0x1B9CB70 VA: 0x181B9E570
	private static uint CRC32(uint value, byte[] buf, ulong size) { }

	// RVA: 0x1B9E680 Offset: 0x1B9CC80 VA: 0x181B9E680
	private static ulong CRC64(ulong value, byte[] buf, ulong size) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1BA1040 Offset: 0x1B9F640 VA: 0x181BA1040
	private static void .cctor() { }

}

