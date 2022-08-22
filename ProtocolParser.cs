public static class ProtocolParser // TypeDefIndex: 6280
{	// Fields
	private static byte[] staticBuffer; // 0x36EE

	// Methods

	// RVA: 0x1E474D0 Offset: 0x1E45AD0 VA: 0x181E474D0
	public static float ReadSingle(Stream stream) { }

	// RVA: 0x1E48630 Offset: 0x1E46C30 VA: 0x181E48630
	public static void WriteSingle(Stream stream, float f) { }

	// RVA: 0x1E46FE0 Offset: 0x1E455E0 VA: 0x181E46FE0
	public static double ReadDouble(Stream stream) { }

	// RVA: 0x1E48100 Offset: 0x1E46700 VA: 0x181E48100
	public static void WriteDouble(Stream stream, double f) { }

	// RVA: 0x1E47620 Offset: 0x1E45C20 VA: 0x181E47620
	public static string ReadString(Stream stream) { }

	// RVA: 0x1E46F20 Offset: 0x1E45520 VA: 0x181E46F20
	public static byte[] ReadBytes(Stream stream) { }

	// RVA: 0x1E47300 Offset: 0x1E45900 VA: 0x181E47300
	public static ArraySegment<byte> ReadPooledBytes(Stream stream) { }

	// RVA: 0x1E46D70 Offset: 0x1E45370 VA: 0x181E46D70
	private static void ReadBytesInto(Stream stream, byte[] buffer, int length) { }

	// RVA: 0x1E47CA0 Offset: 0x1E462A0 VA: 0x181E47CA0
	public static void SkipBytes(Stream stream) { }

	// RVA: 0x1E486F0 Offset: 0x1E46CF0 VA: 0x181E486F0
	public static void WriteString(Stream stream, string val) { }

	// RVA: 0x1E48020 Offset: 0x1E46620 VA: 0x181E48020
	public static void WriteBytes(Stream stream, byte[] val) { }

	// RVA: 0x1E48490 Offset: 0x1E46A90 VA: 0x181E48490
	public static void WritePooledBytes(Stream stream, ArraySegment<byte> segment) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E470D0 Offset: 0x1E456D0 VA: 0x181E470D0
	public static ulong ReadFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E474A0 Offset: 0x1E45AA0 VA: 0x181E474A0
	public static long ReadSFixed64(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E470A0 Offset: 0x1E456A0 VA: 0x181E470A0
	public static uint ReadFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E47470 Offset: 0x1E45A70 VA: 0x181E47470
	public static int ReadSFixed32(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E48220 Offset: 0x1E46820 VA: 0x181E48220
	public static void WriteFixed64(BinaryWriter writer, ulong val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E48600 Offset: 0x1E46C00 VA: 0x181E48600
	public static void WriteSFixed64(BinaryWriter writer, long val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E481F0 Offset: 0x1E467F0 VA: 0x181E481F0
	public static void WriteFixed32(BinaryWriter writer, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E485D0 Offset: 0x1E46BD0 VA: 0x181E485D0
	public static void WriteSFixed32(BinaryWriter writer, int val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E47100 Offset: 0x1E45700 VA: 0x181E47100
	public static float ReadFloat(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E46FB0 Offset: 0x1E455B0 VA: 0x181E46FB0
	public static double ReadDouble(BinaryReader reader) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1DD2DD0 Offset: 0x1DD13D0 VA: 0x181DD2DD0
	public static void WriteFloat(BinaryWriter writer, float val) { }

	[ObsoleteAttribute] // RVA: 0xB07B0 Offset: 0xAFBB0 VA: 0x1800B07B0
	// RVA: 0x1E481C0 Offset: 0x1E467C0 VA: 0x181E481C0
	public static void WriteDouble(BinaryWriter writer, double val) { }

	// RVA: 0x1E47290 Offset: 0x1E45890 VA: 0x181E47290
	public static Key ReadKey(Stream stream) { }

	// RVA: 0x1E471F0 Offset: 0x1E457F0 VA: 0x181E471F0
	public static Key ReadKey(byte firstByte, Stream stream) { }

	// RVA: 0x1E483D0 Offset: 0x1E469D0 VA: 0x181E483D0
	public static void WriteKey(Stream stream, Key key) { }

	// RVA: 0x1E47DE0 Offset: 0x1E463E0 VA: 0x181E47DE0
	public static void SkipKey(Stream stream, Key key) { }

	// RVA: 0x1E47A30 Offset: 0x1E46030 VA: 0x181E47A30
	public static byte[] ReadValueBytes(Stream stream, Key key) { }

	// RVA: 0x1E47590 Offset: 0x1E45B90 VA: 0x181E47590
	public static void ReadSkipVarInt(Stream stream) { }

	// RVA: 0x1E47A90 Offset: 0x1E46090 VA: 0x181E47A90
	public static byte[] ReadVarIntBytes(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2010 Offset: 0xB1410 VA: 0x1800B2010
	// RVA: 0x1E47130 Offset: 0x1E45730 VA: 0x181E47130
	public static int ReadInt32(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2240 Offset: 0xB1640 VA: 0x1800B2240
	// RVA: 0x1E48250 Offset: 0x1E46850 VA: 0x181E48250
	public static void WriteInt32(Stream stream, int val) { }

	// RVA: 0x1E47BD0 Offset: 0x1E461D0 VA: 0x181E47BD0
	public static int ReadZInt32(Stream stream) { }

	// RVA: 0x1E48950 Offset: 0x1E46F50 VA: 0x181E48950
	public static void WriteZInt32(Stream stream, int val) { }

	// RVA: 0x1E477D0 Offset: 0x1E45DD0 VA: 0x181E477D0
	public static uint ReadUInt32(Stream stream) { }

	// RVA: 0x1E48850 Offset: 0x1E46E50 VA: 0x181E48850
	public static void WriteUInt32(Stream stream, uint val) { }

	[ObsoleteAttribute] // RVA: 0xB2360 Offset: 0xB1760 VA: 0x1800B2360
	// RVA: 0x1E47190 Offset: 0x1E45790 VA: 0x181E47190
	public static int ReadInt64(Stream stream) { }

	[ObsoleteAttribute] // RVA: 0xB2460 Offset: 0xB1860 VA: 0x1800B2460
	// RVA: 0x1E48310 Offset: 0x1E46910 VA: 0x181E48310
	public static void WriteInt64(Stream stream, int val) { }

	// RVA: 0x1E47C30 Offset: 0x1E46230 VA: 0x181E47C30
	public static long ReadZInt64(Stream stream) { }

	// RVA: 0x1E48A10 Offset: 0x1E47010 VA: 0x181E48A10
	public static void WriteZInt64(Stream stream, long val) { }

	// RVA: 0x1E47900 Offset: 0x1E45F00 VA: 0x181E47900
	public static ulong ReadUInt64(Stream stream) { }

	// RVA: 0x1E488D0 Offset: 0x1E46ED0 VA: 0x181E488D0
	public static void WriteUInt64(Stream stream, ulong val) { }

	// RVA: 0x1E46CB0 Offset: 0x1E452B0 VA: 0x181E46CB0
	public static bool ReadBool(Stream stream) { }

	// RVA: 0x1E47FF0 Offset: 0x1E465F0 VA: 0x181E47FF0
	public static void WriteBool(Stream stream, bool val) { }

	// RVA: 0x1E48AE0 Offset: 0x1E470E0 VA: 0x181E48AE0
	private static void .cctor() { }

}

