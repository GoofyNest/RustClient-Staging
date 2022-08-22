public static class ProtocolParser // TypeDefIndex: 6280
{	// Fields
	private static byte[] staticBuffer; // 0x34A0

	// Methods

	// RVA: 0x1E47CF0 Offset: 0x1E462F0 VA: 0x181E47CF0
	public static float ReadSingle(Stream stream) { }

	// RVA: 0x1E48E50 Offset: 0x1E47450 VA: 0x181E48E50
	public static void WriteSingle(Stream stream, float f) { }

	// RVA: 0x1E47800 Offset: 0x1E45E00 VA: 0x181E47800
	public static double ReadDouble(Stream stream) { }

	// RVA: 0x1E48920 Offset: 0x1E46F20 VA: 0x181E48920
	public static void WriteDouble(Stream stream, double f) { }

	// RVA: 0x1E47E40 Offset: 0x1E46440 VA: 0x181E47E40
	public static string ReadString(Stream stream) { }

	// RVA: 0x1E47740 Offset: 0x1E45D40 VA: 0x181E47740
	public static byte[] ReadBytes(Stream stream) { }

	// RVA: 0x1E47B20 Offset: 0x1E46120 VA: 0x181E47B20
	public static ArraySegment<byte> ReadPooledBytes(Stream stream) { }

	// RVA: 0x1E47590 Offset: 0x1E45B90 VA: 0x181E47590
	private static void ReadBytesInto(Stream stream, byte[] buffer, int length) { }

	// RVA: 0x1E484C0 Offset: 0x1E46AC0 VA: 0x181E484C0
	public static void SkipBytes(Stream stream) { }

	// RVA: 0x1E48F10 Offset: 0x1E47510 VA: 0x181E48F10
	public static void WriteString(Stream stream, string val) { }

	// RVA: 0x1E48840 Offset: 0x1E46E40 VA: 0x181E48840
	public static void WriteBytes(Stream stream, byte[] val) { }

	// RVA: 0x1E48CB0 Offset: 0x1E472B0 VA: 0x181E48CB0
	public static void WritePooledBytes(Stream stream, ArraySegment<byte> segment) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E478F0 Offset: 0x1E45EF0 VA: 0x181E478F0
	public static ulong ReadFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E47CC0 Offset: 0x1E462C0 VA: 0x181E47CC0
	public static long ReadSFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E478C0 Offset: 0x1E45EC0 VA: 0x181E478C0
	public static uint ReadFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E47C90 Offset: 0x1E46290 VA: 0x181E47C90
	public static int ReadSFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E48A40 Offset: 0x1E47040 VA: 0x181E48A40
	public static void WriteFixed64(BinaryWriter writer, ulong val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E48E20 Offset: 0x1E47420 VA: 0x181E48E20
	public static void WriteSFixed64(BinaryWriter writer, long val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E48A10 Offset: 0x1E47010 VA: 0x181E48A10
	public static void WriteFixed32(BinaryWriter writer, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E48DF0 Offset: 0x1E473F0 VA: 0x181E48DF0
	public static void WriteSFixed32(BinaryWriter writer, int val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E47920 Offset: 0x1E45F20 VA: 0x181E47920
	public static float ReadFloat(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E477D0 Offset: 0x1E45DD0 VA: 0x181E477D0
	public static double ReadDouble(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1DD35C0 Offset: 0x1DD1BC0 VA: 0x181DD35C0
	public static void WriteFloat(BinaryWriter writer, float val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E489E0 Offset: 0x1E46FE0 VA: 0x181E489E0
	public static void WriteDouble(BinaryWriter writer, double val) { }

	// RVA: 0x1E47AB0 Offset: 0x1E460B0 VA: 0x181E47AB0
	public static Key ReadKey(Stream stream) { }

	// RVA: 0x1E47A10 Offset: 0x1E46010 VA: 0x181E47A10
	public static Key ReadKey(byte firstByte, Stream stream) { }

	// RVA: 0x1E48BF0 Offset: 0x1E471F0 VA: 0x181E48BF0
	public static void WriteKey(Stream stream, Key key) { }

	// RVA: 0x1E48600 Offset: 0x1E46C00 VA: 0x181E48600
	public static void SkipKey(Stream stream, Key key) { }

	// RVA: 0x1E48250 Offset: 0x1E46850 VA: 0x181E48250
	public static byte[] ReadValueBytes(Stream stream, Key key) { }

	// RVA: 0x1E47DB0 Offset: 0x1E463B0 VA: 0x181E47DB0
	public static void ReadSkipVarInt(Stream stream) { }

	// RVA: 0x1E482B0 Offset: 0x1E468B0 VA: 0x181E482B0
	public static byte[] ReadVarIntBytes(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2010 Offset: 0xB1410 VA: 0x1800B2010
	// RVA: 0x1E47950 Offset: 0x1E45F50 VA: 0x181E47950
	public static int ReadInt32(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2240 Offset: 0xB1640 VA: 0x1800B2240
	// RVA: 0x1E48A70 Offset: 0x1E47070 VA: 0x181E48A70
	public static void WriteInt32(Stream stream, int val) { }

	// RVA: 0x1E483F0 Offset: 0x1E469F0 VA: 0x181E483F0
	public static int ReadZInt32(Stream stream) { }

	// RVA: 0x1E49170 Offset: 0x1E47770 VA: 0x181E49170
	public static void WriteZInt32(Stream stream, int val) { }

	// RVA: 0x1E47FF0 Offset: 0x1E465F0 VA: 0x181E47FF0
	public static uint ReadUInt32(Stream stream) { }

	// RVA: 0x1E49070 Offset: 0x1E47670 VA: 0x181E49070
	public static void WriteUInt32(Stream stream, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB2360 Offset: 0xB1760 VA: 0x1800B2360
	// RVA: 0x1E479B0 Offset: 0x1E45FB0 VA: 0x181E479B0
	public static int ReadInt64(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2460 Offset: 0xB1860 VA: 0x1800B2460
	// RVA: 0x1E48B30 Offset: 0x1E47130 VA: 0x181E48B30
	public static void WriteInt64(Stream stream, int val) { }

	// RVA: 0x1E48450 Offset: 0x1E46A50 VA: 0x181E48450
	public static long ReadZInt64(Stream stream) { }

	// RVA: 0x1E49230 Offset: 0x1E47830 VA: 0x181E49230
	public static void WriteZInt64(Stream stream, long val) { }

	// RVA: 0x1E48120 Offset: 0x1E46720 VA: 0x181E48120
	public static ulong ReadUInt64(Stream stream) { }

	// RVA: 0x1E490F0 Offset: 0x1E476F0 VA: 0x181E490F0
	public static void WriteUInt64(Stream stream, ulong val) { }

	// RVA: 0x1E474D0 Offset: 0x1E45AD0 VA: 0x181E474D0
	public static bool ReadBool(Stream stream) { }

	// RVA: 0x1E48810 Offset: 0x1E46E10 VA: 0x181E48810
	public static void WriteBool(Stream stream, bool val) { }

	// RVA: 0x1E49300 Offset: 0x1E47900 VA: 0x181E49300
	private static void .cctor() { }

}

