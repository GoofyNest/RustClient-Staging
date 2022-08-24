public static class ProtocolParser // TypeDefIndex: 6280
{	private static byte[] staticBuffer; // 0x2869


	public static float ReadSingle(Stream stream) { }

	public static void WriteSingle(Stream stream, float f) { }

	public static double ReadDouble(Stream stream) { }

	public static void WriteDouble(Stream stream, double f) { }

	public static string ReadString(Stream stream) { }

	public static byte[] ReadBytes(Stream stream) { }

	public static ArraySegment<byte> ReadPooledBytes(Stream stream) { }

	private static void ReadBytesInto(Stream stream, byte[] buffer, int length) { }

	public static void SkipBytes(Stream stream) { }

	public static void WriteString(Stream stream, string val) { }

	public static void WriteBytes(Stream stream, byte[] val) { }

	public static void WritePooledBytes(Stream stream, ArraySegment<byte> segment) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static ulong ReadFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static long ReadSFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static uint ReadFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static int ReadSFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static void WriteFixed64(BinaryWriter writer, ulong val) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static void WriteSFixed64(BinaryWriter writer, long val) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static void WriteFixed32(BinaryWriter writer, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static void WriteSFixed32(BinaryWriter writer, int val) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static float ReadFloat(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static double ReadDouble(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static void WriteFloat(BinaryWriter writer, float val) { }

	[ObsoleteAttribute] // RVA: 0xB0890 Offset: 0xAFC90 VA: 0x1800B0890
	public static void WriteDouble(BinaryWriter writer, double val) { }

	public static Key ReadKey(Stream stream) { }

	public static Key ReadKey(byte firstByte, Stream stream) { }

	public static void WriteKey(Stream stream, Key key) { }

	public static void SkipKey(Stream stream, Key key) { }

	public static byte[] ReadValueBytes(Stream stream, Key key) { }

	public static void ReadSkipVarInt(Stream stream) { }

	public static byte[] ReadVarIntBytes(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2120 Offset: 0xB1520 VA: 0x1800B2120
	public static int ReadInt32(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB22E0 Offset: 0xB16E0 VA: 0x1800B22E0
	public static void WriteInt32(Stream stream, int val) { }

	public static int ReadZInt32(Stream stream) { }

	public static void WriteZInt32(Stream stream, int val) { }

	public static uint ReadUInt32(Stream stream) { }

	public static void WriteUInt32(Stream stream, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB23D0 Offset: 0xB17D0 VA: 0x1800B23D0
	public static int ReadInt64(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB24A0 Offset: 0xB18A0 VA: 0x1800B24A0
	public static void WriteInt64(Stream stream, int val) { }

	public static long ReadZInt64(Stream stream) { }

	public static void WriteZInt64(Stream stream, long val) { }

	public static ulong ReadUInt64(Stream stream) { }

	public static void WriteUInt64(Stream stream, ulong val) { }

	public static bool ReadBool(Stream stream) { }

	public static void WriteBool(Stream stream, bool val) { }

	private static void .cctor() { }

}

