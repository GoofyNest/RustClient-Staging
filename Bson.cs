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

	// RVA: 0x1377600 Offset: 0x1375C00 VA: 0x181377600
	public void .ctor(Stream input) { }

	// RVA: 0x1377380 Offset: 0x1375980 VA: 0x181377380
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x13773A0 Offset: 0x13759A0 VA: 0x1813773A0
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1375C50 Offset: 0x1374250 VA: 0x181375C50 Slot: 6
	public virtual void Close() { }

	// RVA: 0x1375C70 Offset: 0x1374270 VA: 0x181375C70 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1375C50 Offset: 0x1374250 VA: 0x181375C50 Slot: 4
	public void Dispose() { }

	// RVA: 0x1377350 Offset: 0x1375950 VA: 0x181377350 Slot: 8
	public virtual int Read() { }

	// RVA: 0x1376510 Offset: 0x1374B10 VA: 0x181376510 Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x1376560 Offset: 0x1374B60 VA: 0x181376560 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376D40 Offset: 0x1375340 VA: 0x181376D40 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x1376740 Offset: 0x1374D40 VA: 0x181376740 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x13769F0 Offset: 0x1374FF0 VA: 0x1813769F0 Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x13769F0 Offset: 0x1374FF0 VA: 0x1813769F0 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x1376A60 Offset: 0x1375060 VA: 0x181376A60 Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x13770E0 Offset: 0x13756E0 VA: 0x1813770E0 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x1376BD0 Offset: 0x13751D0 VA: 0x181376BD0 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1376BD0 Offset: 0x13751D0 VA: 0x181376BD0 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x1376D90 Offset: 0x1375390 VA: 0x181376D90 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x13769B0 Offset: 0x1374FB0 VA: 0x1813769B0 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x13768C0 Offset: 0x1374EC0 VA: 0x1813768C0 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x1376DD0 Offset: 0x13753D0 VA: 0x181376DD0 Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x1375E70 Offset: 0x1374470 VA: 0x181375E70
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x13761A0 Offset: 0x13747A0 VA: 0x1813761A0
	private int InternalReadOneChar() { }

	// RVA: 0x1376770 Offset: 0x1374D70 VA: 0x181376770 Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x1377190 Offset: 0x1375790 VA: 0x181377190 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x13765B0 Offset: 0x1374BB0 VA: 0x1813765B0 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x1375D20 Offset: 0x1374320 VA: 0x181375D20 Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x1376460 Offset: 0x1374A60 VA: 0x181376460
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

	// RVA: 0x1378890 Offset: 0x1376E90 VA: 0x181378890
	protected void .ctor() { }

	// RVA: 0x1378810 Offset: 0x1376E10 VA: 0x181378810
	public void .ctor(Stream output) { }

	// RVA: 0x13787F0 Offset: 0x1376DF0 VA: 0x1813787F0
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x1378650 Offset: 0x1376C50 VA: 0x181378650
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0xFE4ED0 Offset: 0xFE34D0 VA: 0x180FE4ED0 Slot: 5
	public virtual void Close() { }

	// RVA: 0x1377680 Offset: 0x1375C80 VA: 0x181377680 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xFE4ED0 Offset: 0xFE34D0 VA: 0x180FE4ED0 Slot: 4
	public void Dispose() { }

	// RVA: 0x13789A0 Offset: 0x1376FA0 VA: 0x1813789A0 Slot: 7
	public virtual Stream get_BaseStream() { }

	// RVA: 0xBC8F10 Offset: 0xBC7510 VA: 0x180BC8F10 Slot: 8
	public virtual void Flush() { }

	// RVA: 0x1377BA0 Offset: 0x13761A0 VA: 0x181377BA0 Slot: 9
	public virtual void Write(bool value) { }

	// RVA: 0x1318A10 Offset: 0x1317010 VA: 0x181318A10 Slot: 10
	public virtual void Write(byte value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1318A10 Offset: 0x1317010 VA: 0x181318A10 Slot: 11
	public virtual void Write(sbyte value) { }

	// RVA: 0x1378460 Offset: 0x1376A60 VA: 0x181378460 Slot: 12
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x1378430 Offset: 0x1376A30 VA: 0x181378430 Slot: 13
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x13782F0 Offset: 0x13768F0 VA: 0x1813782F0 Slot: 14
	public virtual void Write(char ch) { }

	// RVA: 0x1377A30 Offset: 0x1376030 VA: 0x181377A30 Slot: 15
	public virtual void Write(char[] chars) { }

	// RVA: 0x1377B50 Offset: 0x1376150 VA: 0x181377B50 Slot: 16
	public virtual void Write(double value) { }

	// RVA: 0x13777E0 Offset: 0x1375DE0 VA: 0x1813777E0 Slot: 17
	public virtual void Write(short value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1377750 Offset: 0x1375D50 VA: 0x181377750 Slot: 18
	public virtual void Write(ushort value) { }

	// RVA: 0x1377C10 Offset: 0x1376210 VA: 0x181377C10 Slot: 19
	public virtual void Write(int value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1377EC0 Offset: 0x13764C0 VA: 0x181377EC0 Slot: 20
	public virtual void Write(uint value) { }

	// RVA: 0x1377870 Offset: 0x1375E70 VA: 0x181377870 Slot: 21
	public virtual void Write(long value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1377D00 Offset: 0x1376300 VA: 0x181377D00 Slot: 22
	public virtual void Write(ulong value) { }

	// RVA: 0x1377B00 Offset: 0x1376100 VA: 0x181377B00 Slot: 23
	public virtual void Write(float value) { }

	// RVA: 0x1377FB0 Offset: 0x13765B0 VA: 0x181377FB0 Slot: 24
	public virtual void Write(string value) { }

	// RVA: 0x13776E0 Offset: 0x1375CE0 VA: 0x1813776E0
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x1378500 Offset: 0x1376B00 VA: 0x181378500
	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1022
{	// Fields
	public static readonly bool TargetsAtLeast_Desktop_V4_5; // 0x0
	public static readonly bool TargetsAtLeast_Desktop_V4_5_1; // 0x1

	// Methods

	// RVA: 0x1292730 Offset: 0x1290D30 VA: 0x181292730
	private static void .cctor() { }

}

internal static class BinaryConverter // TypeDefIndex: 1068
{	// Methods

	// RVA: 0x11ECBF0 Offset: 0x11EB1F0 VA: 0x1811ECBF0
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x11ECF70 Offset: 0x11EB570 VA: 0x1811ECF70
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x11ED8F0 Offset: 0x11EBEF0 VA: 0x1811ED8F0
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x11ED210 Offset: 0x11EB810 VA: 0x1811ED210
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x11ED410 Offset: 0x11EBA10 VA: 0x1811ED410
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

	// RVA: 0x11EC9E0 Offset: 0x11EAFE0 VA: 0x1811EC9E0
	internal Assembly GetAssembly() { }

}

internal sealed class BinaryAssembly // TypeDefIndex: 1072
{	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x11ECB80 Offset: 0x11EB180 VA: 0x1811ECB80
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x11ECBA0 Offset: 0x11EB1A0 VA: 0x1811ECBA0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11ECB10 Offset: 0x11EB110 VA: 0x1811ECB10 Slot: 5
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

	// RVA: 0x11EDAF0 Offset: 0x11EC0F0 VA: 0x1811EDAF0 Slot: 4
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

	// RVA: 0x11EF680 Offset: 0x11EDC80 VA: 0x1811EF680
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x11EF690 Offset: 0x11EDC90 VA: 0x1811EF690 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EDAF0 Offset: 0x11EC0F0 VA: 0x1811EDAF0 Slot: 5
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

	// RVA: 0x11EE660 Offset: 0x11ECC60 VA: 0x1811EE660
	internal void Write(__BinaryWriter sout) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	internal void Dump() { }

	// RVA: 0x11EE930 Offset: 0x11ECF30 VA: 0x1811EE930
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

	// RVA: 0x11EECB0 Offset: 0x11ED2B0 VA: 0x1811EECB0
	private static void .cctor() { }

	// RVA: 0x11EED50 Offset: 0x11ED350 VA: 0x1811EED50
	internal void .ctor() { }

	// RVA: 0x11EE940 Offset: 0x11ECF40 VA: 0x1811EE940 Slot: 4
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

	// RVA: 0x11ECB80 Offset: 0x11EB180 VA: 0x1811ECB80
	internal void Set(int objectId, string value) { }

	// RVA: 0x11EED60 Offset: 0x11ED360 VA: 0x1811EED60 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11ECB10 Offset: 0x11EB110 VA: 0x1811ECB10 Slot: 5
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

	// RVA: 0x11EDAF0 Offset: 0x11EC0F0 VA: 0x1811EDAF0 Slot: 4
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

	// RVA: 0x11EDB50 Offset: 0x11EC150 VA: 0x1811EDB50 Slot: 4
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

	// RVA: 0x11EF560 Offset: 0x11EDB60 VA: 0x1811EF560
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x11EF5C0 Offset: 0x11EDBC0 VA: 0x1811EF5C0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EF3B0 Offset: 0x11ED9B0 VA: 0x1811EF3B0 Slot: 5
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

	// RVA: 0x11EF150 Offset: 0x11ED750 VA: 0x1811EF150
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x11EF1F0 Offset: 0x11ED7F0 VA: 0x1811EF1F0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EEDB0 Offset: 0x11ED3B0 VA: 0x1811EEDB0 Slot: 5
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

	// RVA: 0x11EC9B0 Offset: 0x11EAFB0 VA: 0x1811EC9B0
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x11EC630 Offset: 0x11EAC30 VA: 0x1811EC630
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x11EC6F0 Offset: 0x11EACF0 VA: 0x1811EC6F0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x11EC150 Offset: 0x11EA750 VA: 0x1811EC150 Slot: 5
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

	// RVA: 0xD73FD0 Offset: 0xD725D0 VA: 0x180D73FD0
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x11EE5F0 Offset: 0x11ECBF0 VA: 0x1811EE5F0
	public void .ctor() { }

	// RVA: 0x11EE590 Offset: 0x11ECB90 VA: 0x1811EE590
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x11EDB90 Offset: 0x11EC190 VA: 0x1811EDB90 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x11EDBB0 Offset: 0x11EC1B0 VA: 0x1811EDBB0
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x11EDF50 Offset: 0x11EC550 VA: 0x1811EDF50 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x11EE510 Offset: 0x11ECB10 VA: 0x1811EE510 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x11EE250 Offset: 0x11EC850 VA: 0x1811EE250 Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x11EE270 Offset: 0x11EC870 VA: 0x1811EE270
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x11EDF70 Offset: 0x11EC570 VA: 0x1811EDF70
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x11EE530 Offset: 0x11ECB30 VA: 0x1811EE530
	private static void .cctor() { }

}

internal static class BinaryCompatibility // TypeDefIndex: 1833
{	// Fields
	private static bool _targetsAtLeast_Desktop_V4_5_2; // 0x14160

	// Properties
	internal static bool TargetsAtLeast_Desktop_V4_5_2 { get; }

	// Methods

	// RVA: 0x12E2A50 Offset: 0x12E1050 VA: 0x1812E2A50
	internal static bool get_TargetsAtLeast_Desktop_V4_5_2() { }

	// RVA: 0x12E2870 Offset: 0x12E0E70 VA: 0x1812E2870
	private static bool RunningOnCheck(string propertyName) { }

	// RVA: 0x12E2A00 Offset: 0x12E1000 VA: 0x1812E2A00
	private static void .cctor() { }

}

internal class BinaryFacetsChecker : FacetsChecker // TypeDefIndex: 2255
{	// Methods

	// RVA: 0xF46700 Offset: 0xF44D00 VA: 0x180F46700 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0xF467A0 Offset: 0xF44DA0 VA: 0x180F467A0 Slot: 14
	internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0xF46950 Offset: 0xF44F50 VA: 0x180F46950 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0xF46AA0 Offset: 0xF450A0 VA: 0x180F46AA0
	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x79B660 Offset: 0x799C60 VA: 0x18079B660
	public void .ctor() { }

}

internal class BinaryNode : ExpressionNode // TypeDefIndex: 4243
{	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x1270EB0 Offset: 0x126F4B0 VA: 0x181270EB0
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x126AEE0 Offset: 0x12694E0 VA: 0x18126AEE0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0xCCD7A0 Offset: 0xCCBDA0 VA: 0x180CCD7A0 Slot: 6
	internal override object Eval() { }

	// RVA: 0x126FDA0 Offset: 0x126E3A0 VA: 0x18126FDA0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x126FD20 Offset: 0x126E320 VA: 0x18126FD20 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1270190 Offset: 0x126E790 VA: 0x181270190 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x12702D0 Offset: 0x126E8D0 VA: 0x1812702D0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x12700D0 Offset: 0x126E6D0 VA: 0x1812700D0 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1270130 Offset: 0x126E730 VA: 0x181270130 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x126AF60 Offset: 0x1269560 VA: 0x18126AF60 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1270330 Offset: 0x126E930 VA: 0x181270330 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1270D60 Offset: 0x126F360 VA: 0x181270D60
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x126FD60 Offset: 0x126E360 VA: 0x18126FD60
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x126A170 Offset: 0x1268770 VA: 0x18126A170
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x126A1A0 Offset: 0x12687A0 VA: 0x18126A1A0
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x126AFD0 Offset: 0x12695D0 VA: 0x18126AFD0
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x126FF40 Offset: 0x126E540 VA: 0x18126FF40
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x126FDD0 Offset: 0x126E3D0 VA: 0x18126FDD0
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x1270260 Offset: 0x126E860 VA: 0x181270260
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x12701F0 Offset: 0x126E7F0 VA: 0x1812701F0
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x1270A40 Offset: 0x126F040 VA: 0x181270A40
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1270620 Offset: 0x126EC20 VA: 0x181270620
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1270DC0 Offset: 0x126F3C0 VA: 0x181270DC0
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

	// RVA: 0xF85210 Offset: 0xF83810 VA: 0x180F85210 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF84B30 Offset: 0xF83130 VA: 0x180F84B30
	private byte[] GetByteArray(object value) { }

	// RVA: 0xF84970 Offset: 0xF82F70 VA: 0x180F84970
	private void EnsureReflectionObject(Type t) { }

	// RVA: 0xF84E80 Offset: 0xF83480 VA: 0x180F84E80 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF84C80 Offset: 0xF83280 VA: 0x180F84C80
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0xF84920 Offset: 0xF82F20 VA: 0x180F84920 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 6104
{	// Methods

	// RVA: 0xF857F0 Offset: 0xF83DF0 VA: 0x180F857F0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0xF85600 Offset: 0xF83C00 VA: 0x180F85600 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xF85590 Offset: 0xF83B90 VA: 0x180F85590 Slot: 6
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

	// RVA: 0xF85530 Offset: 0xF83B30 VA: 0x180F85530
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

	// RVA: 0xA4D2E0 Offset: 0xA4B8E0 VA: 0x180A4D2E0
	public DateTimeKind get_DateTimeKindHandling() { }

	// RVA: 0xF86A60 Offset: 0xF85060 VA: 0x180F86A60
	private string ReadElement() { }

	// RVA: 0xF87E30 Offset: 0xF86430 VA: 0x180F87E30 Slot: 10
	public override bool Read() { }

	// RVA: 0xF86650 Offset: 0xF84C50 VA: 0x180F86650
	private bool ReadCodeWScope() { }

	// RVA: 0xF86EF0 Offset: 0xF854F0 VA: 0x180F86EF0
	private bool ReadReference() { }

	// RVA: 0xF86BC0 Offset: 0xF851C0 VA: 0x180F86BC0
	private bool ReadNormal() { }

	// RVA: 0xF863B0 Offset: 0xF849B0 VA: 0x180F863B0
	private void PopContext() { }

	// RVA: 0xF86460 Offset: 0xF84A60 VA: 0x180F86460
	private void PushContext(BsonReader.ContainerContext newContext) { }

	// RVA: 0xF865D0 Offset: 0xF84BD0 VA: 0x180F865D0
	private byte ReadByte() { }

	// RVA: 0xF87600 Offset: 0xF85C00 VA: 0x180F87600
	private void ReadType(BsonType type) { }

	// RVA: 0xF864D0 Offset: 0xF84AD0 VA: 0x180F864D0
	private byte[] ReadBinary(out BsonBinaryType binaryType) { }

	// RVA: 0xF872D0 Offset: 0xF858D0 VA: 0x180F872D0
	private string ReadString() { }

	// RVA: 0xF86B30 Offset: 0xF85130 VA: 0x180F86B30
	private string ReadLengthString() { }

	// RVA: 0xF86090 Offset: 0xF84690 VA: 0x180F86090
	private string GetString(int length) { }

	// RVA: 0xF86000 Offset: 0xF84600 VA: 0x180F86000
	private int GetLastFullCharStop(int start) { }

	// RVA: 0xF85CA0 Offset: 0xF842A0 VA: 0x180F85CA0
	private int BytesInSequence(byte b) { }

	// RVA: 0xF85F40 Offset: 0xF84540 VA: 0x180F85F40
	private void EnsureBuffers() { }

	// RVA: 0xF86A20 Offset: 0xF85020 VA: 0x180F86A20
	private double ReadDouble() { }

	// RVA: 0xF86AB0 Offset: 0xF850B0 VA: 0x180F86AB0
	private int ReadInt32() { }

	// RVA: 0xF86AF0 Offset: 0xF850F0 VA: 0x180F86AF0
	private long ReadInt64() { }

	// RVA: 0xF875C0 Offset: 0xF85BC0 VA: 0x180F875C0
	private BsonType ReadType() { }

	// RVA: 0xF86390 Offset: 0xF84990 VA: 0x180F86390
	private void MovePosition(int count) { }

	// RVA: 0xF86610 Offset: 0xF84C10 VA: 0x180F86610
	private byte[] ReadBytes(int count) { }

	// RVA: 0xF87FD0 Offset: 0xF865D0 VA: 0x180F87FD0
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

	// RVA: 0xF889C0 Offset: 0xF86FC0 VA: 0x180F889C0
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

	// RVA: 0xF85AA0 Offset: 0xF840A0 VA: 0x180F85AA0
	public void Add(string name, BsonToken token) { }

	// RVA: 0xF85C90 Offset: 0xF84290 VA: 0x180F85C90 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0xF85BA0 Offset: 0xF841A0 VA: 0x180F85BA0 Slot: 5
	public IEnumerator<BsonProperty> GetEnumerator() { }

	// RVA: 0xF85BA0 Offset: 0xF841A0 VA: 0x180F85BA0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF85C20 Offset: 0xF84220 VA: 0x180F85C20
	public void .ctor() { }

}

internal class BsonArray : BsonToken, IEnumerable<BsonToken>, IEnumerable // TypeDefIndex: 6139
{	// Fields
	private readonly List<BsonToken> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF853C0 Offset: 0xF839C0 VA: 0x180F853C0
	public void Add(BsonToken token) { }

	// RVA: 0xF85520 Offset: 0xF83B20 VA: 0x180F85520 Slot: 4
	public override BsonType get_Type() { }

	// RVA: 0xF85430 Offset: 0xF83A30 VA: 0x180F85430 Slot: 5
	public IEnumerator<BsonToken> GetEnumerator() { }

	// RVA: 0xF85430 Offset: 0xF83A30 VA: 0x180F85430 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xF854B0 Offset: 0xF83AB0 VA: 0x180F854B0
	public void .ctor() { }

}

internal class BsonValue : BsonToken // TypeDefIndex: 6140
{	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0xF882E0 Offset: 0xF868E0 VA: 0x180F882E0
	public void .ctor(object value, BsonType type) { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0 Slot: 4
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
	// RVA: 0x997600 Offset: 0x995C00 VA: 0x180997600
	public void set_IncludeLength(bool value) { }

	// RVA: 0xF88290 Offset: 0xF86890 VA: 0x180F88290
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

	// RVA: 0xF881A0 Offset: 0xF867A0 VA: 0x180F881A0
	public void .ctor(string pattern, string options) { }

	// RVA: 0xF88280 Offset: 0xF86880 VA: 0x180F88280 Slot: 4
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

	// RVA: 0xF886E0 Offset: 0xF86CE0 VA: 0x180F886E0
	private void AddValue(object value, BsonType type) { }

	// RVA: 0xF88330 Offset: 0xF86930 VA: 0x180F88330
	internal void AddToken(BsonToken token) { }

	// RVA: 0xF88770 Offset: 0xF86D70 VA: 0x180F88770
	public void WriteObjectId(byte[] value) { }

	// RVA: 0xF88870 Offset: 0xF86E70 VA: 0x180F88870
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

	// RVA: 0xF859F0 Offset: 0xF83FF0 VA: 0x180F859F0
	public void .ctor(byte[] value) { }

}

public static class BinaryReaderExtensions // TypeDefIndex: 6221
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14AAB70 Offset: 0x14A9170 VA: 0x1814AAB70
	public static Vector3 ReadVector3(BinaryReader o) { }

}

public static class BinaryWriterExtensions // TypeDefIndex: 6222
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x14AAC10 Offset: 0x14A9210 VA: 0x1814AAC10
	public static void Write(BinaryWriter o, Vector3 vec) { }

}

public sealed class BinaryDataHandler : MulticastDelegate // TypeDefIndex: 6911
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A431D0 Offset: 0x1A417D0 VA: 0x181A431D0 Slot: 12
	public virtual void Invoke(Span<byte> data) { }

	// RVA: 0x22055E0 Offset: 0x2203BE0 VA: 0x1822055E0 Slot: 13
	public virtual IAsyncResult BeginInvoke(Span<byte> data, AsyncCallback callback, object object) { }

	// RVA: 0x49A1C0 Offset: 0x4987C0 VA: 0x18049A1C0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class BinaryWriterEx : BinaryWriter // TypeDefIndex: 7297
{	// Methods

	// RVA: 0xB7A260 Offset: 0xB78860 VA: 0x180B7A260
	public void .ctor() { }

	// RVA: 0xB7A200 Offset: 0xB78800 VA: 0x180B7A200
	public void .ctor(string fileName) { }

	// RVA: 0xB79C80 Offset: 0xB78280 VA: 0x180B79C80
	public long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0xB79CF0 Offset: 0xB782F0 VA: 0x180B79CF0
	public void WriteStruct(object theStruct) { }

	// RVA: 0xB79FF0 Offset: 0xB785F0 VA: 0x180B79FF0
	public void Write(int[] array) { }

	// RVA: 0xB79DE0 Offset: 0xB783E0 VA: 0x180B79DE0
	public void Write(float[] array) { }

}

