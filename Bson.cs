public class BinaryReader : IDisposable // TypeDefIndex: 616
{	// Fields
	private const int MaxCharBytesSize = 128;
	private Stream m_stream; // 0x10
	private byte[] m_buffer; // 0x18
	private Decoder m_decoder; // 0x20
	private byte[] m_charBytes; // 0x28
	private char[] m_singleChar; // 0x30
	private char[] m_charBuffer; // 0x38
	private int m_maxCharsSize; // 0x40
	private bool m_2BytesPerChar; // 0x44
	private bool m_isMemoryStream; // 0x45
	private bool m_leaveOpen; // 0x46

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x1377340 Offset: 0x1375940 VA: 0x181377340
	public void .ctor(Stream input) { }

	// RVA: 0x13770C0 Offset: 0x13756C0 VA: 0x1813770C0
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x13770E0 Offset: 0x13756E0 VA: 0x1813770E0
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1375990 Offset: 0x1373F90 VA: 0x181375990 Slot: 6
	public virtual void Close() { }

	// RVA: 0x13759B0 Offset: 0x1373FB0 VA: 0x1813759B0 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1375990 Offset: 0x1373F90 VA: 0x181375990 Slot: 4
	public void Dispose() { }

	// RVA: 0x1377090 Offset: 0x1375690 VA: 0x181377090 Slot: 8
	public virtual int Read() { }

	// RVA: 0x1376250 Offset: 0x1374850 VA: 0x181376250 Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x13762A0 Offset: 0x13748A0 VA: 0x1813762A0 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376A80 Offset: 0x1375080 VA: 0x181376A80 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x1376480 Offset: 0x1374A80 VA: 0x181376480 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x1376730 Offset: 0x1374D30 VA: 0x181376730 Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376730 Offset: 0x1374D30 VA: 0x181376730 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x13767A0 Offset: 0x1374DA0 VA: 0x1813767A0 Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376E20 Offset: 0x1375420 VA: 0x181376E20 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x1376910 Offset: 0x1374F10 VA: 0x181376910 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376910 Offset: 0x1374F10 VA: 0x181376910 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x1376AD0 Offset: 0x13750D0 VA: 0x181376AD0 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x13766F0 Offset: 0x1374CF0 VA: 0x1813766F0 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x1376600 Offset: 0x1374C00 VA: 0x181376600 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x1376B10 Offset: 0x1375110 VA: 0x181376B10 Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x1375BB0 Offset: 0x13741B0 VA: 0x181375BB0
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x1375EE0 Offset: 0x13744E0 VA: 0x181375EE0
	private int InternalReadOneChar() { }

	// RVA: 0x13764B0 Offset: 0x1374AB0 VA: 0x1813764B0 Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x1376ED0 Offset: 0x13754D0 VA: 0x181376ED0 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x13762F0 Offset: 0x13748F0 VA: 0x1813762F0 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x1375A60 Offset: 0x1374060 VA: 0x181375A60 Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x13761A0 Offset: 0x13747A0 VA: 0x1813761A0
	protected internal int Read7BitEncodedInt() { }

}

public class BinaryWriter : IDisposable // TypeDefIndex: 617
{	// Fields
	public static readonly BinaryWriter Null; // 0x0
	protected Stream OutStream; // 0x10
	private byte[] _buffer; // 0x18
	private Encoding _encoding; // 0x20
	private Encoder _encoder; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private bool _leaveOpen; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B570 Offset: 0x7A970 VA: 0x18007B570
	private char[] _tmpOneCharBuffer; // 0x38
	private byte[] _largeByteBuffer; // 0x40
	private int _maxChars; // 0x48
	private const int LargeByteBufferSize = 256;

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x13785D0 Offset: 0x1376BD0 VA: 0x1813785D0
	protected void .ctor() { }

	// RVA: 0x1378550 Offset: 0x1376B50 VA: 0x181378550
	public void .ctor(Stream output) { }

	// RVA: 0x1378530 Offset: 0x1376B30 VA: 0x181378530
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x1378390 Offset: 0x1376990 VA: 0x181378390
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0xFE4C10 Offset: 0xFE3210 VA: 0x180FE4C10 Slot: 5
	public virtual void Close() { }

	// RVA: 0x13773C0 Offset: 0x13759C0 VA: 0x1813773C0 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xFE4C10 Offset: 0xFE3210 VA: 0x180FE4C10 Slot: 4
	public void Dispose() { }

	// RVA: 0x13786E0 Offset: 0x1376CE0 VA: 0x1813786E0 Slot: 7
	public virtual Stream get_BaseStream() { }

	// RVA: 0xBC8C50 Offset: 0xBC7250 VA: 0x180BC8C50 Slot: 8
	public virtual void Flush() { }

	// RVA: 0x13778E0 Offset: 0x1375EE0 VA: 0x1813778E0 Slot: 9
	public virtual void Write(bool value) { }

	// RVA: 0x1318750 Offset: 0x1316D50 VA: 0x181318750 Slot: 10
	public virtual void Write(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1318750 Offset: 0x1316D50 VA: 0x181318750 Slot: 11
	public virtual void Write(sbyte value) { }

	// RVA: 0x13781A0 Offset: 0x13767A0 VA: 0x1813781A0 Slot: 12
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x1378170 Offset: 0x1376770 VA: 0x181378170 Slot: 13
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x1378030 Offset: 0x1376630 VA: 0x181378030 Slot: 14
	public virtual void Write(char ch) { }

	// RVA: 0x1377770 Offset: 0x1375D70 VA: 0x181377770 Slot: 15
	public virtual void Write(char[] chars) { }

	// RVA: 0x1377890 Offset: 0x1375E90 VA: 0x181377890 Slot: 16
	public virtual void Write(double value) { }

	// RVA: 0x1377520 Offset: 0x1375B20 VA: 0x181377520 Slot: 17
	public virtual void Write(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1377490 Offset: 0x1375A90 VA: 0x181377490 Slot: 18
	public virtual void Write(ushort value) { }

	// RVA: 0x1377950 Offset: 0x1375F50 VA: 0x181377950 Slot: 19
	public virtual void Write(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1377C00 Offset: 0x1376200 VA: 0x181377C00 Slot: 20
	public virtual void Write(uint value) { }

	// RVA: 0x13775B0 Offset: 0x1375BB0 VA: 0x1813775B0 Slot: 21
	public virtual void Write(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1377A40 Offset: 0x1376040 VA: 0x181377A40 Slot: 22
	public virtual void Write(ulong value) { }

	// RVA: 0x1377840 Offset: 0x1375E40 VA: 0x181377840 Slot: 23
	public virtual void Write(float value) { }

	// RVA: 0x1377CF0 Offset: 0x13762F0 VA: 0x181377CF0 Slot: 24
	public virtual void Write(string value) { }

	// RVA: 0x1377420 Offset: 0x1375A20 VA: 0x181377420
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x1378240 Offset: 0x1376840 VA: 0x181378240
	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1022
{	// Fields
	public static readonly bool TargetsAtLeast_Desktop_V4_5; // 0x0
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; // 0x1

	// Methods

	// RVA: 0x1292470 Offset: 0x1290A70 VA: 0x181292470
	private static void .cctor() { }

}

internal static class BinaryConverter // TypeDefIndex: 1068
{	// Methods

	// RVA: 0x11EC930 Offset: 0x11EAF30 VA: 0x1811EC930
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x11ECCB0 Offset: 0x11EB2B0 VA: 0x1811ECCB0
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x11ED630 Offset: 0x11EBC30 VA: 0x1811ED630
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x11ECF50 Offset: 0x11EB550 VA: 0x1811ECF50
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x11ED150 Offset: 0x11EB750 VA: 0x1811ED150
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }

}

internal sealed class BinaryAssemblyInfo // TypeDefIndex: 1070
{	// Fields
	internal string assemblyString; // 0x10
	private Assembly assembly; // 0x18

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	internal void .ctor(string assemblyString) { }

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(string assemblyString, Assembly assembly) { }

	// RVA: 0x11EC720 Offset: 0x11EAD20 VA: 0x1811EC720
	internal Assembly GetAssembly() { }

}

internal sealed class BinaryAssembly // TypeDefIndex: 1072
{	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11EC8C0 Offset: 0x11EAEC0 VA: 0x1811EC8C0
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x11EC8E0 Offset: 0x11EAEE0 VA: 0x1811EC8E0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EC850 Offset: 0x11EAE50 VA: 0x1811EC850 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainAssembly // TypeDefIndex: 1073
{	// Fields
	internal int assemId; // 0x10
	internal int assemblyIndex; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11ED830 Offset: 0x11EBE30 VA: 0x1811ED830 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

internal sealed class BinaryObject // TypeDefIndex: 1074
{	// Fields
	internal int objectId; // 0x10
	internal int mapId; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11EF3C0 Offset: 0x11ED9C0 VA: 0x1811EF3C0
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x11EF3D0 Offset: 0x11ED9D0 VA: 0x1811EF3D0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11ED830 Offset: 0x11EBE30 VA: 0x1811ED830 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

internal sealed class BinaryMethodCall // TypeDefIndex: 1075
{	// Fields
	private string methodName; // 0x10
	private string typeName; // 0x18
	private object[] args; // 0x20
	private object callContext; // 0x28
	private Type[] argTypes; // 0x30
	private bool bArgsPrimitive; // 0x38
	private MessageEnum messageEnum; // 0x3C

	// Methods

	// RVA: 0x11EE3A0 Offset: 0x11EC9A0 VA: 0x1811EE3A0
	internal void Write(__BinaryWriter sout) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void Dump() { }

	// RVA: 0x11EE670 Offset: 0x11ECC70 VA: 0x1811EE670
	public void .ctor() { }

}

internal sealed class BinaryMethodReturn // TypeDefIndex: 1076
{	// Fields
	private object returnValue; // 0x10
	private object[] args; // 0x18
	private object callContext; // 0x20
	private Type[] argTypes; // 0x28
	private bool bArgsPrimitive; // 0x30
	private MessageEnum messageEnum; // 0x34
	private Type returnType; // 0x38
	private static object instanceOfVoid; // 0x0

	// Methods

	// RVA: 0x11EE9F0 Offset: 0x11ECFF0 VA: 0x1811EE9F0
	private static void .cctor() { }

	// RVA: 0x11EEA90 Offset: 0x11ED090 VA: 0x1811EEA90
	internal void .ctor() { }

	// RVA: 0x11EE680 Offset: 0x11ECC80 VA: 0x1811EE680 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

internal sealed class BinaryObjectString // TypeDefIndex: 1077
{	// Fields
	internal int objectId; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11EC8C0 Offset: 0x11EAEC0 VA: 0x1811EC8C0
	internal void Set(int objectId, string value) { }

	// RVA: 0x11EEAA0 Offset: 0x11ED0A0 VA: 0x1811EEAA0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EC850 Offset: 0x11EAE50 VA: 0x1811EC850 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainString // TypeDefIndex: 1078
{	// Fields
	internal int objectId; // 0x10
	internal int value; // 0x14

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11ED830 Offset: 0x11EBE30 VA: 0x1811ED830 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

internal sealed class BinaryCrossAppDomainMap // TypeDefIndex: 1079
{	// Fields
	internal int crossAppDomainArrayIndex; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11ED890 Offset: 0x11EBE90 VA: 0x1811ED890 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

internal sealed class BinaryObjectWithMap // TypeDefIndex: 1081
{	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x11EF2A0 Offset: 0x11ED8A0 VA: 0x1811EF2A0
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x11EF300 Offset: 0x11ED900 VA: 0x1811EF300 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EF0F0 Offset: 0x11ED6F0 VA: 0x1811EF0F0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void Dump() { }

}

internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 1082
{	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x11EEE90 Offset: 0x11ED490 VA: 0x1811EEE90
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x11EEF30 Offset: 0x11ED530 VA: 0x1811EEF30 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EEAF0 Offset: 0x11ED0F0 VA: 0x1811EEAF0 Slot: 5
	public void Read(__BinaryParser input) { }

}

internal sealed class BinaryArray // TypeDefIndex: 1083
{	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11EC6F0 Offset: 0x11EACF0 VA: 0x1811EC6F0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x11EC370 Offset: 0x11EA970 VA: 0x1811EC370
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x11EC430 Offset: 0x11EAA30 VA: 0x1811EC430 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EBE90 Offset: 0x11EA490 VA: 0x1811EBE90 Slot: 5
	public void Read(__BinaryParser input) { }

}

internal enum BinaryHeaderEnum // TypeDefIndex: 1091
{	// Fields
	public int value__; // 0x0
	public const BinaryHeaderEnum SerializedStreamHeader = 0;
	public const BinaryHeaderEnum Object = 1;
	public const BinaryHeaderEnum ObjectWithMap = 2;
	public const BinaryHeaderEnum ObjectWithMapAssemId = 3;
	public const BinaryHeaderEnum ObjectWithMapTyped = 4;
	public const BinaryHeaderEnum ObjectWithMapTypedAssemId = 5;
	public const BinaryHeaderEnum ObjectString = 6;
	public const BinaryHeaderEnum Array = 7;
	public const BinaryHeaderEnum MemberPrimitiveTyped = 8;
	public const BinaryHeaderEnum MemberReference = 9;
	public const BinaryHeaderEnum ObjectNull = 10;
	public const BinaryHeaderEnum MessageEnd = 11;
	public const BinaryHeaderEnum Assembly = 12;
	public const BinaryHeaderEnum ObjectNullMultiple256 = 13;
	public const BinaryHeaderEnum ObjectNullMultiple = 14;
	public const BinaryHeaderEnum ArraySinglePrimitive = 15;
	public const BinaryHeaderEnum ArraySingleObject = 16;
	public const BinaryHeaderEnum ArraySingleString = 17;
	public const BinaryHeaderEnum CrossAppDomainMap = 18;
	public const BinaryHeaderEnum CrossAppDomainString = 19;
	public const BinaryHeaderEnum CrossAppDomainAssembly = 20;
	public const BinaryHeaderEnum MethodCall = 21;
	public const BinaryHeaderEnum MethodReturn = 22;

}

internal enum BinaryTypeEnum // TypeDefIndex: 1092
{	// Fields
	public int value__; // 0x0
	public const BinaryTypeEnum Primitive = 0;
	public const BinaryTypeEnum String = 1;
	public const BinaryTypeEnum Object = 2;
	public const BinaryTypeEnum ObjectUrt = 3;
	public const BinaryTypeEnum ObjectUser = 4;
	public const BinaryTypeEnum ObjectArray = 5;
	public const BinaryTypeEnum StringArray = 6;
	public const BinaryTypeEnum PrimitiveArray = 7;

}

internal enum BinaryArrayTypeEnum // TypeDefIndex: 1093
{	// Fields
	public int value__; // 0x0
	public const BinaryArrayTypeEnum Single = 0;
	public const BinaryArrayTypeEnum Jagged = 1;
	public const BinaryArrayTypeEnum Rectangular = 2;
	public const BinaryArrayTypeEnum SingleOffset = 3;
	public const BinaryArrayTypeEnum JaggedOffset = 4;
	public const BinaryArrayTypeEnum RectangularOffset = 5;

}

public sealed class BinaryFormatter // TypeDefIndex: 1104
{	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0xD73D10 Offset: 0xD72310 VA: 0x180D73D10
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x11EE330 Offset: 0x11EC930 VA: 0x1811EE330
	public void .ctor() { }

	// RVA: 0x11EE2D0 Offset: 0x11EC8D0 VA: 0x1811EE2D0
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x11ED8D0 Offset: 0x11EBED0 VA: 0x1811ED8D0 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x11ED8F0 Offset: 0x11EBEF0 VA: 0x1811ED8F0
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x11EDC90 Offset: 0x11EC290 VA: 0x1811EDC90 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x11EE250 Offset: 0x11EC850 VA: 0x1811EE250 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x11EDF90 Offset: 0x11EC590 VA: 0x1811EDF90 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x11EDFB0 Offset: 0x11EC5B0 VA: 0x1811EDFB0
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x11EDCB0 Offset: 0x11EC2B0 VA: 0x1811EDCB0
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x11EE270 Offset: 0x11EC870 VA: 0x1811EE270
	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1833
{	// Fields
	private static bool _targetsAtLeast_Desktop_V4_5_2; // 0x14160

	// Properties
	internal static bool TargetsAtLeast_Desktop_V4_5_2 { get; }

	// Methods

	// RVA: 0x12E2790 Offset: 0x12E0D90 VA: 0x1812E2790
	internal static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

	// RVA: 0x12E25B0 Offset: 0x12E0BB0 VA: 0x1812E25B0
	private static bool RunningOnCheck(string propertyName) { }

	// RVA: 0x12E2740 Offset: 0x12E0D40 VA: 0x1812E2740
	private static void .cctor() { }

}

internal class BinaryFacetsChecker : FacetsChecker // TypeDefIndex: 2255
{	// Methods

	// RVA: 0xF46440 Offset: 0xF44A40 VA: 0x180F46440 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xF464E0 Offset: 0xF44AE0 VA: 0x180F464E0 Slot: 14
	internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0xF46690 Offset: 0xF44C90 VA: 0x180F46690 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xF467E0 Offset: 0xF44DE0 VA: 0x180F467E0
	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x79B550 Offset: 0x799B50 VA: 0x18079B550
	public void .ctor() { }

}

internal class BinaryNode : ExpressionNode // TypeDefIndex: 4243
{	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x1270BF0 Offset: 0x126F1F0 VA: 0x181270BF0
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x126AC20 Offset: 0x1269220 VA: 0x18126AC20 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCD4E0 Offset: 0xCCBAE0 VA: 0x180CCD4E0 Slot: 6
	internal override object Eval() { }

	// RVA: 0x126FAE0 Offset: 0x126E0E0 VA: 0x18126FAE0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x126FA60 Offset: 0x126E060 VA: 0x18126FA60 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x126FED0 Offset: 0x126E4D0 VA: 0x18126FED0 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1270010 Offset: 0x126E610 VA: 0x181270010 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x126FE10 Offset: 0x126E410 VA: 0x18126FE10 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x126FE70 Offset: 0x126E470 VA: 0x18126FE70 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x126ACA0 Offset: 0x12692A0 VA: 0x18126ACA0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1270070 Offset: 0x126E670 VA: 0x181270070 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1270AA0 Offset: 0x126F0A0 VA: 0x181270AA0
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x126FAA0 Offset: 0x126E0A0 VA: 0x18126FAA0
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x1269EB0 Offset: 0x12684B0 VA: 0x181269EB0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x1269EE0 Offset: 0x12684E0 VA: 0x181269EE0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x126AD10 Offset: 0x1269310 VA: 0x18126AD10
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x126FC80 Offset: 0x126E280 VA: 0x18126FC80
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x126FB10 Offset: 0x126E110 VA: 0x18126FB10
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x126FFA0 Offset: 0x126E5A0 VA: 0x18126FFA0
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x126FF30 Offset: 0x126E530 VA: 0x18126FF30
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x1270780 Offset: 0x126ED80 VA: 0x181270780
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1270360 Offset: 0x126E960 VA: 0x181270360
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1270B00 Offset: 0x126F100 VA: 0x181270B00
	private int SqlResultType(int typeCode) { }

}

private enum BinaryNode.DataTypePrecedence // TypeDefIndex: 4244
{	// Fields
	public int value__; // 0x0
	public const BinaryNode.DataTypePrecedence SqlDateTime = 25;
	public const BinaryNode.DataTypePrecedence DateTimeOffset = 24;
	public const BinaryNode.DataTypePrecedence DateTime = 23;
	public const BinaryNode.DataTypePrecedence TimeSpan = 20;
	public const BinaryNode.DataTypePrecedence SqlDouble = 19;
	public const BinaryNode.DataTypePrecedence Double = 18;
	public const BinaryNode.DataTypePrecedence SqlSingle = 17;
	public const BinaryNode.DataTypePrecedence Single = 16;
	public const BinaryNode.DataTypePrecedence SqlDecimal = 15;
	public const BinaryNode.DataTypePrecedence Decimal = 14;
	public const BinaryNode.DataTypePrecedence SqlMoney = 13;
	public const BinaryNode.DataTypePrecedence UInt64 = 12;
	public const BinaryNode.DataTypePrecedence SqlInt64 = 11;
	public const BinaryNode.DataTypePrecedence Int64 = 10;
	public const BinaryNode.DataTypePrecedence UInt32 = 9;
	public const BinaryNode.DataTypePrecedence SqlInt32 = 8;
	public const BinaryNode.DataTypePrecedence Int32 = 7;
	public const BinaryNode.DataTypePrecedence UInt16 = 6;
	public const BinaryNode.DataTypePrecedence SqlInt16 = 5;
	public const BinaryNode.DataTypePrecedence Int16 = 4;
	public const BinaryNode.DataTypePrecedence Byte = 3;
	public const BinaryNode.DataTypePrecedence SqlByte = 2;
	public const BinaryNode.DataTypePrecedence SByte = 1;
	public const BinaryNode.DataTypePrecedence Error = 0;
	public const BinaryNode.DataTypePrecedence SqlBoolean = -1;
	public const BinaryNode.DataTypePrecedence Boolean = -2;
	public const BinaryNode.DataTypePrecedence SqlGuid = -3;
	public const BinaryNode.DataTypePrecedence SqlString = -4;
	public const BinaryNode.DataTypePrecedence String = -5;
	public const BinaryNode.DataTypePrecedence SqlXml = -6;
	public const BinaryNode.DataTypePrecedence SqlChars = -7;
	public const BinaryNode.DataTypePrecedence Char = -8;
	public const BinaryNode.DataTypePrecedence SqlBytes = -9;
	public const BinaryNode.DataTypePrecedence SqlBinary = -10;

}

public class BinaryConverter : JsonConverter // TypeDefIndex: 6099
{
// Namespace: Newtonsoft.Json.Converters
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
public class BinaryConverter : JsonConverter // TypeDefIndex: 6099
	// Fields
	private ReflectionObject _reflectionObject; // 0x10

	// Methods

	// RVA: 0xF84F50 Offset: 0xF83550 VA: 0x180F84F50 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF84870 Offset: 0xF82E70 VA: 0x180F84870
	private byte[] GetByteArray(object value) { }

	// RVA: 0xF846B0 Offset: 0xF82CB0 VA: 0x180F846B0
	private void EnsureReflectionObject(Type t) { }

	// RVA: 0xF84BC0 Offset: 0xF831C0 VA: 0x180F84BC0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF849C0 Offset: 0xF82FC0 VA: 0x180F849C0
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xF84660 Offset: 0xF82C60 VA: 0x180F84660 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 6104
{	// Methods

	// RVA: 0xF85530 Offset: 0xF83B30 VA: 0x180F85530 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF85340 Offset: 0xF83940 VA: 0x180F85340 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF852D0 Offset: 0xF838D0 VA: 0x180F852D0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal enum BsonBinaryType // TypeDefIndex: 6132
{	// Fields
	public byte value__; // 0x0
	public const BsonBinaryType Binary = 0;
	public const BsonBinaryType Function = 1;
	[ObsoleteAttribute] // RVA: 0x97070 Offset: 0x96470 VA: 0x180097070
	public const BsonBinaryType BinaryOld = 2;
	[ObsoleteAttribute] // RVA: 0x97160 Offset: 0x96560 VA: 0x180097160
	public const BsonBinaryType UuidOld = 3;
	public const BsonBinaryType Uuid = 4;
	public const BsonBinaryType Md5 = 5;
	public const BsonBinaryType UserDefined = 128;

}

internal class BsonBinaryWriter // TypeDefIndex: 6133
{	// Fields
	private static readonly Encoding Encoding; // 0x3648

	// Methods

	// RVA: 0xF85270 Offset: 0xF83870 VA: 0x180F85270
	private static void .cctor() { }

}

public class BsonReader : JsonReader // TypeDefIndex: 6134
{	// Fields
	private static readonly byte[] SeqRange1; // 0x0
	private static readonly byte[] SeqRange2; // 0x8
	private static readonly byte[] SeqRange3; // 0x10
	private static readonly byte[] SeqRange4; // 0x18
	private readonly BinaryReader _reader; // 0x78
	private readonly List<BsonReader.ContainerContext> _stack; // 0x80
	private byte[] _byteBuffer; // 0x88
	private char[] _charBuffer; // 0x90
	private BsonType _currentElementType; // 0x98
	private BsonReader.BsonReaderState _bsonReaderState; // 0x9C
	private BsonReader.ContainerContext _currentContext; // 0xA0
	private bool _readRootValueAsArray; // 0xA8
	private bool _jsonNet35BinaryCompatibility; // 0xA9
	private DateTimeKind _dateTimeKindHandling; // 0xAC

	// Properties
	public DateTimeKind DateTimeKindHandling { get; }

	// Methods

	// RVA: 0xA4D020 Offset: 0xA4B620 VA: 0x180A4D020
	public DateTimeKind get_DateTimeKindHandling() { }

	// RVA: 0xF867A0 Offset: 0xF84DA0 VA: 0x180F867A0
	private string ReadElement() { }

	// RVA: 0xF87B70 Offset: 0xF86170 VA: 0x180F87B70 Slot: 10
	public override bool Read() { }

	// RVA: 0xF86390 Offset: 0xF84990 VA: 0x180F86390
	private bool ReadCodeWScope() { }

	// RVA: 0xF86C30 Offset: 0xF85230 VA: 0x180F86C30
	private bool ReadReference() { }

	// RVA: 0xF86900 Offset: 0xF84F00 VA: 0x180F86900
	private bool ReadNormal() { }

	// RVA: 0xF860F0 Offset: 0xF846F0 VA: 0x180F860F0
	private void PopContext() { }

	// RVA: 0xF861A0 Offset: 0xF847A0 VA: 0x180F861A0
	private void PushContext(BsonReader.ContainerContext newContext) { }

	// RVA: 0xF86310 Offset: 0xF84910 VA: 0x180F86310
	private byte ReadByte() { }

	// RVA: 0xF87340 Offset: 0xF85940 VA: 0x180F87340
	private void ReadType(BsonType type) { }

	// RVA: 0xF86210 Offset: 0xF84810 VA: 0x180F86210
	private byte[] ReadBinary(out BsonBinaryType binaryType) { }

	// RVA: 0xF87010 Offset: 0xF85610 VA: 0x180F87010
	private string ReadString() { }

	// RVA: 0xF86870 Offset: 0xF84E70 VA: 0x180F86870
	private string ReadLengthString() { }

	// RVA: 0xF85DD0 Offset: 0xF843D0 VA: 0x180F85DD0
	private string GetString(int length) { }

	// RVA: 0xF85D40 Offset: 0xF84340 VA: 0x180F85D40
	private int GetLastFullCharStop(int start) { }

	// RVA: 0xF859E0 Offset: 0xF83FE0 VA: 0x180F859E0
	private int BytesInSequence(byte b) { }

	// RVA: 0xF85C80 Offset: 0xF84280 VA: 0x180F85C80
	private void EnsureBuffers() { }

	// RVA: 0xF86760 Offset: 0xF84D60 VA: 0x180F86760
	private double ReadDouble() { }

	// RVA: 0xF867F0 Offset: 0xF84DF0 VA: 0x180F867F0
	private int ReadInt32() { }

	// RVA: 0xF86830 Offset: 0xF84E30 VA: 0x180F86830
	private long ReadInt64() { }

	// RVA: 0xF87300 Offset: 0xF85900 VA: 0x180F87300
	private BsonType ReadType() { }

	// RVA: 0xF860D0 Offset: 0xF846D0 VA: 0x180F860D0
	private void MovePosition(int count) { }

	// RVA: 0xF86350 Offset: 0xF84950 VA: 0x180F86350
	private byte[] ReadBytes(int count) { }

	// RVA: 0xF87D10 Offset: 0xF86310 VA: 0x180F87D10
	private static void .cctor() { }

}

private enum BsonReader.BsonReaderState // TypeDefIndex: 6135
{	// Fields
	public int value__; // 0x0
	public const BsonReader.BsonReaderState Normal = 0;
	public const BsonReader.BsonReaderState ReferenceStart = 1;
	public const BsonReader.BsonReaderState ReferenceRef = 2;
	public const BsonReader.BsonReaderState ReferenceId = 3;
	public const BsonReader.BsonReaderState CodeWScopeStart = 4;
	public const BsonReader.BsonReaderState CodeWScopeCode = 5;
	public const BsonReader.BsonReaderState CodeWScopeScope = 6;
	public const BsonReader.BsonReaderState CodeWScopeScopeObject = 7;
	public const BsonReader.BsonReaderState CodeWScopeScopeEnd = 8;

}

private class BsonReader.ContainerContext // TypeDefIndex: 6136
{	// Fields
	public readonly BsonType Type; // 0x10
	public int Length; // 0x14
	public int Position; // 0x18

	// Methods

	// RVA: 0xF88700 Offset: 0xF86D00 VA: 0x180F88700
	public void .ctor(BsonType type) { }

}

internal abstract class BsonToken // TypeDefIndex: 6137
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BsonToken <Parent>k__BackingField; // 0x10

	// Properties
	public abstract BsonType Type { get; }
	public BsonToken Parent { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BsonType get_Type();

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Parent(BsonToken value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

}

internal class BsonObject : BsonToken, IEnumerable<BsonProperty>, IEnumerable // TypeDefIndex: 6138
{	// Fields
	private readonly List<BsonProperty> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF857E0 Offset: 0xF83DE0 VA: 0x180F857E0
	public void Add(string name, BsonToken token) { }

	// RVA: 0xF859D0 Offset: 0xF83FD0 VA: 0x180F859D0 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0xF858E0 Offset: 0xF83EE0 VA: 0x180F858E0 Slot: 5
	public IEnumerator<BsonProperty> GetEnumerator() { }

	// RVA: 0xF858E0 Offset: 0xF83EE0 VA: 0x180F858E0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF85960 Offset: 0xF83F60 VA: 0x180F85960
	public void .ctor() { }

}

internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable // TypeDefIndex: 6139
{	// Fields
	private readonly List<BsonToken> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF85100 Offset: 0xF83700 VA: 0x180F85100
	public void Add(BsonToken token) { }

	// RVA: 0xF85260 Offset: 0xF83860 VA: 0x180F85260 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0xF85170 Offset: 0xF83770 VA: 0x180F85170 Slot: 5
	public IEnumerator<BsonToken> GetEnumerator() { }

	// RVA: 0xF85170 Offset: 0xF83770 VA: 0x180F85170 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF851F0 Offset: 0xF837F0 VA: 0x180F851F0
	public void .ctor() { }

}

internal class BsonValue : BsonToken // TypeDefIndex: 6140
{	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF88020 Offset: 0xF86620 VA: 0x180F88020
	public void .ctor(object value, BsonType type) { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0 Slot: 4
	public override BsonType get_Type() { }

}

internal class BsonString : BsonValue // TypeDefIndex: 6141
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <IncludeLength>k__BackingField; // 0x28

	// Properties
	public bool IncludeLength { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x9974F0 Offset: 0x995AF0 VA: 0x1809974F0
	public void set_IncludeLength(bool value) { }

	// RVA: 0xF87FD0 Offset: 0xF865D0 VA: 0x180F87FD0
	public void .ctor(object value, bool includeLength) { }

}

internal class BsonRegex : BsonToken // TypeDefIndex: 6143
{
// Namespace: Newtonsoft.Json.Bson
[PreserveAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal class BsonRegex : BsonToken // TypeDefIndex: 6143
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BsonString <Pattern>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BsonString <Options>k__BackingField; // 0x20

	// Properties
	public BsonString Pattern { set; }
	public BsonString Options { set; }
	public override BsonType Type { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Pattern(BsonString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Options(BsonString value) { }

	// RVA: 0xF87EE0 Offset: 0xF864E0 VA: 0x180F87EE0
	public void .ctor(string pattern, string options) { }

	// RVA: 0xF87FC0 Offset: 0xF865C0 VA: 0x180F87FC0 Slot: 4
	public override BsonType get_Type() { }

}

internal class BsonProperty // TypeDefIndex: 6144
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BsonString <Name>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private BsonToken <Value>k__BackingField; // 0x18

	// Properties
	public BsonString Name { set; }
	public BsonToken Value { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_Name(BsonString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_Value(BsonToken value) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

internal enum BsonType // TypeDefIndex: 6145
{	// Fields
	public sbyte value__; // 0x0
	public const BsonType Number = 1;
	public const BsonType String = 2;
	public const BsonType Object = 3;
	public const BsonType Array = 4;
	public const BsonType Binary = 5;
	public const BsonType Undefined = 6;
	public const BsonType Oid = 7;
	public const BsonType Boolean = 8;
	public const BsonType Date = 9;
	public const BsonType Null = 10;
	public const BsonType Regex = 11;
	public const BsonType Reference = 12;
	public const BsonType Code = 13;
	public const BsonType Symbol = 14;
	public const BsonType CodeWScope = 15;
	public const BsonType Integer = 16;
	public const BsonType TimeStamp = 17;
	public const BsonType Long = 18;
	public const BsonType MinKey = -1;
	public const BsonType MaxKey = 127;

}

public class BsonWriter : JsonWriter // TypeDefIndex: 6146
{	// Fields
	private BsonToken _root; // 0x60
	private BsonToken _parent; // 0x68
	private string _propertyName; // 0x70

	// Methods

	// RVA: 0xF88420 Offset: 0xF86A20 VA: 0x180F88420
	private void AddValue(object value, BsonType type) { }

	// RVA: 0xF88070 Offset: 0xF86670 VA: 0x180F88070
	internal void AddToken(BsonToken token) { }

	// RVA: 0xF884B0 Offset: 0xF86AB0 VA: 0x180F884B0
	public void WriteObjectId(byte[] value) { }

	// RVA: 0xF885B0 Offset: 0xF86BB0 VA: 0x180F885B0
	public void WriteRegex(string pattern, string options) { }

}

public class BsonObjectId // TypeDefIndex: 6147
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private byte[] <Value>k__BackingField; // 0x10

	// Properties
	public byte[] Value { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public byte[] get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Value(byte[] value) { }

	// RVA: 0xF85730 Offset: 0xF83D30 VA: 0x180F85730
	public void .ctor(byte[] value) { }

}

public static class BinaryReaderExtensions // TypeDefIndex: 6221
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14AA8B0 Offset: 0x14A8EB0 VA: 0x1814AA8B0
	public static Vector3 ReadVector3(BinaryReader o) { }

}

public static class BinaryWriterExtensions // TypeDefIndex: 6222
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14AA950 Offset: 0x14A8F50 VA: 0x1814AA950
	public static void Write(BinaryWriter o, Vector3 vec) { }

}

public sealed class BinaryDataHandler : MulticastDelegate // TypeDefIndex: 6911
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A42F10 Offset: 0x1A41510 VA: 0x181A42F10 Slot: 12
	public virtual void Invoke(Span<byte> data) { }

	// RVA: 0x2205320 Offset: 0x2203920 VA: 0x182205320 Slot: 13
	public virtual IAsyncResult BeginInvoke(Span<byte> data, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class BinaryWriterEx : BinaryWriter // TypeDefIndex: 7297
{	// Methods

	// RVA: 0xB79FA0 Offset: 0xB785A0 VA: 0x180B79FA0
	public void .ctor() { }

	// RVA: 0xB79F40 Offset: 0xB78540 VA: 0x180B79F40
	public void .ctor(string fileName) { }

	// RVA: 0xB799C0 Offset: 0xB77FC0 VA: 0x180B799C0
	public long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xB79A30 Offset: 0xB78030 VA: 0x180B79A30
	public void WriteStruct(object theStruct) { }

	// RVA: 0xB79D30 Offset: 0xB78330 VA: 0x180B79D30
	public void Write(int[] array) { }

	// RVA: 0xB79B20 Offset: 0xB78120 VA: 0x180B79B20
	public void Write(float[] array) { }

}

