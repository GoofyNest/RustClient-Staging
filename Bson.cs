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

	// RVA: 0x1376700 Offset: 0x1374D00 VA: 0x181376700
	public void .ctor(Stream input) { }

	// RVA: 0x1376480 Offset: 0x1374A80 VA: 0x181376480
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x13764A0 Offset: 0x1374AA0 VA: 0x1813764A0
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1374D50 Offset: 0x1373350 VA: 0x181374D50 Slot: 6
	public virtual void Close() { }

	// RVA: 0x1374D70 Offset: 0x1373370 VA: 0x181374D70 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1374D50 Offset: 0x1373350 VA: 0x181374D50 Slot: 4
	public void Dispose() { }

	// RVA: 0x1376450 Offset: 0x1374A50 VA: 0x181376450 Slot: 8
	public virtual int Read() { }

	// RVA: 0x1375610 Offset: 0x1373C10 VA: 0x181375610 Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x1375660 Offset: 0x1373C60 VA: 0x181375660 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1375E40 Offset: 0x1374440 VA: 0x181375E40 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x1375840 Offset: 0x1373E40 VA: 0x181375840 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x1375AF0 Offset: 0x13740F0 VA: 0x181375AF0 Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1375AF0 Offset: 0x13740F0 VA: 0x181375AF0 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x1375B60 Offset: 0x1374160 VA: 0x181375B60 Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x13761E0 Offset: 0x13747E0 VA: 0x1813761E0 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x1375CD0 Offset: 0x13742D0 VA: 0x181375CD0 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1375CD0 Offset: 0x13742D0 VA: 0x181375CD0 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x1375E90 Offset: 0x1374490 VA: 0x181375E90 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x1375AB0 Offset: 0x13740B0 VA: 0x181375AB0 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x13759C0 Offset: 0x1373FC0 VA: 0x1813759C0 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x1375ED0 Offset: 0x13744D0 VA: 0x181375ED0 Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x1374F70 Offset: 0x1373570 VA: 0x181374F70
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x13752A0 Offset: 0x13738A0 VA: 0x1813752A0
	private int InternalReadOneChar() { }

	// RVA: 0x1375870 Offset: 0x1373E70 VA: 0x181375870 Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x1376290 Offset: 0x1374890 VA: 0x181376290 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x13756B0 Offset: 0x1373CB0 VA: 0x1813756B0 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x1374E20 Offset: 0x1373420 VA: 0x181374E20 Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x1375560 Offset: 0x1373B60 VA: 0x181375560
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

	// RVA: 0x1377990 Offset: 0x1375F90 VA: 0x181377990
	protected void .ctor() { }

	// RVA: 0x1377910 Offset: 0x1375F10 VA: 0x181377910
	public void .ctor(Stream output) { }

	// RVA: 0x13778F0 Offset: 0x1375EF0 VA: 0x1813778F0
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x1377750 Offset: 0x1375D50 VA: 0x181377750
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0xFE5970 Offset: 0xFE3F70 VA: 0x180FE5970 Slot: 5
	public virtual void Close() { }

	// RVA: 0x1376780 Offset: 0x1374D80 VA: 0x181376780 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xFE5970 Offset: 0xFE3F70 VA: 0x180FE5970 Slot: 4
	public void Dispose() { }

	// RVA: 0x1377AA0 Offset: 0x13760A0 VA: 0x181377AA0 Slot: 7
	public virtual Stream get_BaseStream() { }

	// RVA: 0xBC93E0 Offset: 0xBC79E0 VA: 0x180BC93E0 Slot: 8
	public virtual void Flush() { }

	// RVA: 0x1376CA0 Offset: 0x13752A0 VA: 0x181376CA0 Slot: 9
	public virtual void Write(bool value) { }

	// RVA: 0x1317B10 Offset: 0x1316110 VA: 0x181317B10 Slot: 10
	public virtual void Write(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1317B10 Offset: 0x1316110 VA: 0x181317B10 Slot: 11
	public virtual void Write(sbyte value) { }

	// RVA: 0x1377560 Offset: 0x1375B60 VA: 0x181377560 Slot: 12
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x1377530 Offset: 0x1375B30 VA: 0x181377530 Slot: 13
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x13773F0 Offset: 0x13759F0 VA: 0x1813773F0 Slot: 14
	public virtual void Write(char ch) { }

	// RVA: 0x1376B30 Offset: 0x1375130 VA: 0x181376B30 Slot: 15
	public virtual void Write(char[] chars) { }

	// RVA: 0x1376C50 Offset: 0x1375250 VA: 0x181376C50 Slot: 16
	public virtual void Write(double value) { }

	// RVA: 0x13768E0 Offset: 0x1374EE0 VA: 0x1813768E0 Slot: 17
	public virtual void Write(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376850 Offset: 0x1374E50 VA: 0x181376850 Slot: 18
	public virtual void Write(ushort value) { }

	// RVA: 0x1376D10 Offset: 0x1375310 VA: 0x181376D10 Slot: 19
	public virtual void Write(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376FC0 Offset: 0x13755C0 VA: 0x181376FC0 Slot: 20
	public virtual void Write(uint value) { }

	// RVA: 0x1376970 Offset: 0x1374F70 VA: 0x181376970 Slot: 21
	public virtual void Write(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376E00 Offset: 0x1375400 VA: 0x181376E00 Slot: 22
	public virtual void Write(ulong value) { }

	// RVA: 0x1376C00 Offset: 0x1375200 VA: 0x181376C00 Slot: 23
	public virtual void Write(float value) { }

	// RVA: 0x13770B0 Offset: 0x13756B0 VA: 0x1813770B0 Slot: 24
	public virtual void Write(string value) { }

	// RVA: 0x13767E0 Offset: 0x1374DE0 VA: 0x1813767E0
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x1377600 Offset: 0x1375C00 VA: 0x181377600
	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1022
{	// Fields
	public static readonly bool TargetsAtLeast_Desktop_V4_5; // 0x0
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; // 0x1

	// Methods

	// RVA: 0x1292DD0 Offset: 0x12913D0 VA: 0x181292DD0
	private static void .cctor() { }

}

internal static class BinaryConverter // TypeDefIndex: 1068
{	// Methods

	// RVA: 0x11ED290 Offset: 0x11EB890 VA: 0x1811ED290
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x11ED610 Offset: 0x11EBC10 VA: 0x1811ED610
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x11EDF90 Offset: 0x11EC590 VA: 0x1811EDF90
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x11ED8B0 Offset: 0x11EBEB0 VA: 0x1811ED8B0
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x11EDAB0 Offset: 0x11EC0B0 VA: 0x1811EDAB0
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }

}

internal sealed class BinaryAssemblyInfo // TypeDefIndex: 1070
{	// Fields
	internal string assemblyString; // 0x10
	private Assembly assembly; // 0x18

	// Methods

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	internal void .ctor(string assemblyString) { }

	// RVA: 0x522C40 Offset: 0x521240 VA: 0x180522C40
	internal void .ctor(string assemblyString, Assembly assembly) { }

	// RVA: 0x11ED080 Offset: 0x11EB680 VA: 0x1811ED080
	internal Assembly GetAssembly() { }

}

internal sealed class BinaryAssembly // TypeDefIndex: 1072
{	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11ED220 Offset: 0x11EB820 VA: 0x1811ED220
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x11ED240 Offset: 0x11EB840 VA: 0x1811ED240 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11ED1B0 Offset: 0x11EB7B0 VA: 0x1811ED1B0 Slot: 5
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

	// RVA: 0x11EE190 Offset: 0x11EC790 VA: 0x1811EE190 Slot: 4
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

	// RVA: 0x11EFD20 Offset: 0x11EE320 VA: 0x1811EFD20
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x11EFD30 Offset: 0x11EE330 VA: 0x1811EFD30 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EE190 Offset: 0x11EC790 VA: 0x1811EE190 Slot: 5
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

	// RVA: 0x11EED00 Offset: 0x11ED300 VA: 0x1811EED00
	internal void Write(__BinaryWriter sout) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void Dump() { }

	// RVA: 0x11EEFD0 Offset: 0x11ED5D0 VA: 0x1811EEFD0
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

	// RVA: 0x11EF350 Offset: 0x11ED950 VA: 0x1811EF350
	private static void .cctor() { }

	// RVA: 0x11EF3F0 Offset: 0x11ED9F0 VA: 0x1811EF3F0
	internal void .ctor() { }

	// RVA: 0x11EEFE0 Offset: 0x11ED5E0 VA: 0x1811EEFE0 Slot: 4
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

	// RVA: 0x11ED220 Offset: 0x11EB820 VA: 0x1811ED220
	internal void Set(int objectId, string value) { }

	// RVA: 0x11EF400 Offset: 0x11EDA00 VA: 0x1811EF400 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11ED1B0 Offset: 0x11EB7B0 VA: 0x1811ED1B0 Slot: 5
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

	// RVA: 0x11EE190 Offset: 0x11EC790 VA: 0x1811EE190 Slot: 4
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

	// RVA: 0x11EE1F0 Offset: 0x11EC7F0 VA: 0x1811EE1F0 Slot: 4
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

	// RVA: 0x11EFC00 Offset: 0x11EE200 VA: 0x1811EFC00
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x11EFC60 Offset: 0x11EE260 VA: 0x1811EFC60 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EFA50 Offset: 0x11EE050 VA: 0x1811EFA50 Slot: 5
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

	// RVA: 0x11EF7F0 Offset: 0x11EDDF0 VA: 0x1811EF7F0
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x11EF890 Offset: 0x11EDE90 VA: 0x1811EF890 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EF450 Offset: 0x11EDA50 VA: 0x1811EF450 Slot: 5
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

	// RVA: 0x11ED050 Offset: 0x11EB650 VA: 0x1811ED050
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x11ECCD0 Offset: 0x11EB2D0 VA: 0x1811ECCD0
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x11ECD90 Offset: 0x11EB390 VA: 0x1811ECD90 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EC7F0 Offset: 0x11EADF0 VA: 0x1811EC7F0 Slot: 5
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

	// RVA: 0xD74A80 Offset: 0xD73080 VA: 0x180D74A80
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x11EEC90 Offset: 0x11ED290 VA: 0x1811EEC90
	public void .ctor() { }

	// RVA: 0x11EEC30 Offset: 0x11ED230 VA: 0x1811EEC30
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x11EE230 Offset: 0x11EC830 VA: 0x1811EE230 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x11EE250 Offset: 0x11EC850 VA: 0x1811EE250
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x11EE5F0 Offset: 0x11ECBF0 VA: 0x1811EE5F0 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x11EEBB0 Offset: 0x11ED1B0 VA: 0x1811EEBB0 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x11EE8F0 Offset: 0x11ECEF0 VA: 0x1811EE8F0 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x11EE910 Offset: 0x11ECF10 VA: 0x1811EE910
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x11EE610 Offset: 0x11ECC10 VA: 0x1811EE610
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x11EEBD0 Offset: 0x11ED1D0 VA: 0x1811EEBD0
	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1833
{	// Fields
	private static bool _targetsAtLeast_Desktop_V4_5_2; // 0x2B1047C

	// Properties
	internal static bool TargetsAtLeast_Desktop_V4_5_2 { get; }

	// Methods

	// RVA: 0x12E8F00 Offset: 0x12E7500 VA: 0x1812E8F00
	internal static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

	// RVA: 0x12E8D20 Offset: 0x12E7320 VA: 0x1812E8D20
	private static bool RunningOnCheck(string propertyName) { }

	// RVA: 0x12E8EB0 Offset: 0x12E74B0 VA: 0x1812E8EB0
	private static void .cctor() { }

}

internal class BinaryFacetsChecker : FacetsChecker // TypeDefIndex: 2255
{	// Methods

	// RVA: 0xF471A0 Offset: 0xF457A0 VA: 0x180F471A0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xF47240 Offset: 0xF45840 VA: 0x180F47240 Slot: 14
	internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0xF473F0 Offset: 0xF459F0 VA: 0x180F473F0 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xF47540 Offset: 0xF45B40 VA: 0x180F47540
	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x7B9740 Offset: 0x7B7D40 VA: 0x1807B9740
	public void .ctor() { }

}

internal class BinaryNode : ExpressionNode // TypeDefIndex: 4243
{	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x1271550 Offset: 0x126FB50 VA: 0x181271550
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x126B580 Offset: 0x1269B80 VA: 0x18126B580 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCDC40 Offset: 0xCCC240 VA: 0x180CCDC40 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1270440 Offset: 0x126EA40 VA: 0x181270440 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x12703C0 Offset: 0x126E9C0 VA: 0x1812703C0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1270830 Offset: 0x126EE30 VA: 0x181270830 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1270970 Offset: 0x126EF70 VA: 0x181270970 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1270770 Offset: 0x126ED70 VA: 0x181270770 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x12707D0 Offset: 0x126EDD0 VA: 0x1812707D0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x126B600 Offset: 0x1269C00 VA: 0x18126B600 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x12709D0 Offset: 0x126EFD0 VA: 0x1812709D0 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1271400 Offset: 0x126FA00 VA: 0x181271400
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x1270400 Offset: 0x126EA00 VA: 0x181270400
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x126A810 Offset: 0x1268E10 VA: 0x18126A810
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x126A840 Offset: 0x1268E40 VA: 0x18126A840
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x126B670 Offset: 0x1269C70 VA: 0x18126B670
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x12705E0 Offset: 0x126EBE0 VA: 0x1812705E0
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x1270470 Offset: 0x126EA70 VA: 0x181270470
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x1270900 Offset: 0x126EF00 VA: 0x181270900
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x1270890 Offset: 0x126EE90 VA: 0x181270890
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x12710E0 Offset: 0x126F6E0 VA: 0x1812710E0
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1270CC0 Offset: 0x126F2C0 VA: 0x181270CC0
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1271460 Offset: 0x126FA60 VA: 0x181271460
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

	// RVA: 0xF85CB0 Offset: 0xF842B0 VA: 0x180F85CB0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF855D0 Offset: 0xF83BD0 VA: 0x180F855D0
	private byte[] GetByteArray(object value) { }

	// RVA: 0xF85410 Offset: 0xF83A10 VA: 0x180F85410
	private void EnsureReflectionObject(Type t) { }

	// RVA: 0xF85920 Offset: 0xF83F20 VA: 0x180F85920 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF85720 Offset: 0xF83D20 VA: 0x180F85720
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xF853C0 Offset: 0xF839C0 VA: 0x180F853C0 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 6104
{	// Methods

	// RVA: 0xF86290 Offset: 0xF84890 VA: 0x180F86290 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF860A0 Offset: 0xF846A0 VA: 0x180F860A0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF86030 Offset: 0xF84630 VA: 0x180F86030 Slot: 6
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
	private static readonly Encoding Encoding; // 0x33D0

	// Methods

	// RVA: 0xF85FD0 Offset: 0xF845D0 VA: 0x180F85FD0
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

	// RVA: 0xA4D7D0 Offset: 0xA4BDD0 VA: 0x180A4D7D0
	public DateTimeKind get_DateTimeKindHandling() { }

	// RVA: 0xF87500 Offset: 0xF85B00 VA: 0x180F87500
	private string ReadElement() { }

	// RVA: 0xF888D0 Offset: 0xF86ED0 VA: 0x180F888D0 Slot: 10
	public override bool Read() { }

	// RVA: 0xF870F0 Offset: 0xF856F0 VA: 0x180F870F0
	private bool ReadCodeWScope() { }

	// RVA: 0xF87990 Offset: 0xF85F90 VA: 0x180F87990
	private bool ReadReference() { }

	// RVA: 0xF87660 Offset: 0xF85C60 VA: 0x180F87660
	private bool ReadNormal() { }

	// RVA: 0xF86E50 Offset: 0xF85450 VA: 0x180F86E50
	private void PopContext() { }

	// RVA: 0xF86F00 Offset: 0xF85500 VA: 0x180F86F00
	private void PushContext(BsonReader.ContainerContext newContext) { }

	// RVA: 0xF87070 Offset: 0xF85670 VA: 0x180F87070
	private byte ReadByte() { }

	// RVA: 0xF880A0 Offset: 0xF866A0 VA: 0x180F880A0
	private void ReadType(BsonType type) { }

	// RVA: 0xF86F70 Offset: 0xF85570 VA: 0x180F86F70
	private byte[] ReadBinary(out BsonBinaryType binaryType) { }

	// RVA: 0xF87D70 Offset: 0xF86370 VA: 0x180F87D70
	private string ReadString() { }

	// RVA: 0xF875D0 Offset: 0xF85BD0 VA: 0x180F875D0
	private string ReadLengthString() { }

	// RVA: 0xF86B30 Offset: 0xF85130 VA: 0x180F86B30
	private string GetString(int length) { }

	// RVA: 0xF86AA0 Offset: 0xF850A0 VA: 0x180F86AA0
	private int GetLastFullCharStop(int start) { }

	// RVA: 0xF86740 Offset: 0xF84D40 VA: 0x180F86740
	private int BytesInSequence(byte b) { }

	// RVA: 0xF869E0 Offset: 0xF84FE0 VA: 0x180F869E0
	private void EnsureBuffers() { }

	// RVA: 0xF874C0 Offset: 0xF85AC0 VA: 0x180F874C0
	private double ReadDouble() { }

	// RVA: 0xF87550 Offset: 0xF85B50 VA: 0x180F87550
	private int ReadInt32() { }

	// RVA: 0xF87590 Offset: 0xF85B90 VA: 0x180F87590
	private long ReadInt64() { }

	// RVA: 0xF88060 Offset: 0xF86660 VA: 0x180F88060
	private BsonType ReadType() { }

	// RVA: 0xF86E30 Offset: 0xF85430 VA: 0x180F86E30
	private void MovePosition(int count) { }

	// RVA: 0xF870B0 Offset: 0xF856B0 VA: 0x180F870B0
	private byte[] ReadBytes(int count) { }

	// RVA: 0xF88A70 Offset: 0xF87070 VA: 0x180F88A70
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

	// RVA: 0xF89460 Offset: 0xF87A60 VA: 0x180F89460
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
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
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

	// RVA: 0xF86540 Offset: 0xF84B40 VA: 0x180F86540
	public void Add(string name, BsonToken token) { }

	// RVA: 0xF86730 Offset: 0xF84D30 VA: 0x180F86730 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0xF86640 Offset: 0xF84C40 VA: 0x180F86640 Slot: 5
	public IEnumerator<BsonProperty> GetEnumerator() { }

	// RVA: 0xF86640 Offset: 0xF84C40 VA: 0x180F86640 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF866C0 Offset: 0xF84CC0 VA: 0x180F866C0
	public void .ctor() { }

}

internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable // TypeDefIndex: 6139
{	// Fields
	private readonly List<BsonToken> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF85E60 Offset: 0xF84460 VA: 0x180F85E60
	public void Add(BsonToken token) { }

	// RVA: 0xF85FC0 Offset: 0xF845C0 VA: 0x180F85FC0 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0xF85ED0 Offset: 0xF844D0 VA: 0x180F85ED0 Slot: 5
	public IEnumerator<BsonToken> GetEnumerator() { }

	// RVA: 0xF85ED0 Offset: 0xF844D0 VA: 0x180F85ED0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF85F50 Offset: 0xF84550 VA: 0x180F85F50
	public void .ctor() { }

}

internal class BsonValue : BsonToken // TypeDefIndex: 6140
{	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF88D80 Offset: 0xF87380 VA: 0x180F88D80
	public void .ctor(object value, BsonType type) { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80 Slot: 4
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
	// RVA: 0x997AF0 Offset: 0x9960F0 VA: 0x180997AF0
	public void set_IncludeLength(bool value) { }

	// RVA: 0xF88D30 Offset: 0xF87330 VA: 0x180F88D30
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
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_Pattern(BsonString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	public void set_Options(BsonString value) { }

	// RVA: 0xF88C40 Offset: 0xF87240 VA: 0x180F88C40
	public void .ctor(string pattern, string options) { }

	// RVA: 0xF88D20 Offset: 0xF87320 VA: 0x180F88D20 Slot: 4
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
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_Name(BsonString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
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

	// RVA: 0xF89180 Offset: 0xF87780 VA: 0x180F89180
	private void AddValue(object value, BsonType type) { }

	// RVA: 0xF88DD0 Offset: 0xF873D0 VA: 0x180F88DD0
	internal void AddToken(BsonToken token) { }

	// RVA: 0xF89210 Offset: 0xF87810 VA: 0x180F89210
	public void WriteObjectId(byte[] value) { }

	// RVA: 0xF89310 Offset: 0xF87910 VA: 0x180F89310
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
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public byte[] get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Value(byte[] value) { }

	// RVA: 0xF86490 Offset: 0xF84A90 VA: 0x180F86490
	public void .ctor(byte[] value) { }

}

public static class BinaryReaderExtensions // TypeDefIndex: 6221
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A9C40 Offset: 0x14A8240 VA: 0x1814A9C40
	public static Vector3 ReadVector3(BinaryReader o) { }

}

public static class BinaryWriterExtensions // TypeDefIndex: 6222
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14A9CE0 Offset: 0x14A82E0 VA: 0x1814A9CE0
	public static void Write(BinaryWriter o, Vector3 vec) { }

}

public sealed class BinaryDataHandler : MulticastDelegate // TypeDefIndex: 6911
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A9BFD0 Offset: 0x1A9A5D0 VA: 0x181A9BFD0 Slot: 12
	public virtual void Invoke(Span<byte> data) { }

	// RVA: 0x2205E00 Offset: 0x2204400 VA: 0x182205E00 Slot: 13
	public virtual IAsyncResult BeginInvoke(Span<byte> data, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class BinaryWriterEx : BinaryWriter // TypeDefIndex: 7297
{	// Methods

	// RVA: 0xB7A730 Offset: 0xB78D30 VA: 0x180B7A730
	public void .ctor() { }

	// RVA: 0xB7A6D0 Offset: 0xB78CD0 VA: 0x180B7A6D0
	public void .ctor(string fileName) { }

	// RVA: 0xB7A150 Offset: 0xB78750 VA: 0x180B7A150
	public long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xB7A1C0 Offset: 0xB787C0 VA: 0x180B7A1C0
	public void WriteStruct(object theStruct) { }

	// RVA: 0xB7A4C0 Offset: 0xB78AC0 VA: 0x180B7A4C0
	public void Write(int[] array) { }

	// RVA: 0xB7A2B0 Offset: 0xB788B0 VA: 0x180B7A2B0
	public void Write(float[] array) { }

}

