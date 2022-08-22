public sealed class StringBuilder : ISerializable // TypeDefIndex: 463
{	// Fields
	internal char[] m_ChunkChars; // 0x10
	internal StringBuilder m_ChunkPrevious; // 0x18
	internal int m_ChunkLength; // 0x20
	internal int m_ChunkOffset; // 0x24
	internal int m_MaxCapacity; // 0x28
	internal const int DefaultCapacity = 16;
	private const string CapacityField = "Capacity";
	private const string MaxCapacityField = "m_MaxCapacity";
	private const string StringValueField = "m_StringValue";
	private const string ThreadIDField = "m_currentThread";
	internal const int MaxChunkSize = 8000;

	// Properties
	public int Capacity { get; set; }
	public int MaxCapacity { get; }
	public int Length { get; set; }
	public char Chars { get; set; }

	// Methods

	// RVA: 0x19243D0 Offset: 0x19229D0 VA: 0x1819243D0
	public void .ctor() { }

	// RVA: 0x1923F10 Offset: 0x1922510 VA: 0x181923F10
	public void .ctor(int capacity) { }

	// RVA: 0x19242B0 Offset: 0x19228B0 VA: 0x1819242B0
	public void .ctor(string value) { }

	// RVA: 0x19242F0 Offset: 0x19228F0 VA: 0x1819242F0
	public void .ctor(string value, int capacity) { }

	// RVA: 0x1923C60 Offset: 0x1922260 VA: 0x181923C60
	public void .ctor(string value, int startIndex, int length, int capacity) { }

	// RVA: 0x1923FF0 Offset: 0x19225F0 VA: 0x181923FF0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19235B0 Offset: 0x1921BB0 VA: 0x1819235B0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1924440 Offset: 0x1922A40 VA: 0x181924440
	public int get_Capacity() { }

	// RVA: 0x1924540 Offset: 0x1922B40 VA: 0x181924540
	public void set_Capacity(int value) { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	public int get_MaxCapacity() { }

	// RVA: 0x1923B20 Offset: 0x1922120 VA: 0x181923B20 Slot: 3
	public override string ToString() { }

	// RVA: 0x1923870 Offset: 0x1921E70 VA: 0x181923870
	public string ToString(int startIndex, int length) { }

	// RVA: 0x19211D0 Offset: 0x191F7D0 VA: 0x1819211D0
	public StringBuilder Clear() { }

	// RVA: 0x1294680 Offset: 0x1292C80 VA: 0x181294680
	public int get_Length() { }

	// RVA: 0x19247E0 Offset: 0x1922DE0 VA: 0x1819247E0
	public void set_Length(int value) { }

	// RVA: 0x1924460 Offset: 0x1922A60 VA: 0x181924460
	public char get_Chars(int index) { }

	// RVA: 0x19246C0 Offset: 0x1922CC0 VA: 0x1819246C0
	public void set_Chars(int index, char value) { }

	// RVA: 0x1920C60 Offset: 0x191F260 VA: 0x181920C60
	public StringBuilder Append(char value, int repeatCount) { }

	// RVA: 0x1920990 Offset: 0x191EF90 VA: 0x181920990
	public StringBuilder Append(char[] value, int startIndex, int charCount) { }

	// RVA: 0x1921030 Offset: 0x191F630 VA: 0x181921030
	public StringBuilder Append(string value) { }

	// RVA: 0x1920640 Offset: 0x191EC40 VA: 0x181920640
	private void AppendHelper(string value) { }

	// RVA: 0x1920D60 Offset: 0x191F360 VA: 0x181920D60
	public StringBuilder Append(string value, int startIndex, int count) { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x19206C0 Offset: 0x191ECC0 VA: 0x1819206C0
	public StringBuilder AppendLine() { }

	[ComVisibleAttribute] // RVA: 0x75CF0 Offset: 0x750F0 VA: 0x180075CF0
	// RVA: 0x1920690 Offset: 0x191EC90 VA: 0x181920690
	public StringBuilder AppendLine(string value) { }

	// RVA: 0x1921AB0 Offset: 0x19200B0 VA: 0x181921AB0
	public StringBuilder Insert(int index, string value, int count) { }

	// RVA: 0x1922790 Offset: 0x1920D90 VA: 0x181922790
	public StringBuilder Remove(int startIndex, int length) { }

	// RVA: 0x1920920 Offset: 0x191EF20 VA: 0x181920920
	public StringBuilder Append(byte value) { }

	// RVA: 0x19206F0 Offset: 0x191ECF0 VA: 0x1819206F0
	public StringBuilder Append(char value) { }

	// RVA: 0x1920B70 Offset: 0x191F170 VA: 0x181920B70
	public StringBuilder Append(int value) { }

	// RVA: 0x1920FB0 Offset: 0x191F5B0 VA: 0x181920FB0
	public StringBuilder Append(long value) { }

	// RVA: 0x1920BE0 Offset: 0x191F1E0 VA: 0x181920BE0
	public StringBuilder Append(float value) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x1921160 Offset: 0x191F760 VA: 0x181921160
	public StringBuilder Append(uint value) { }

	// RVA: 0x1920F20 Offset: 0x191F520 VA: 0x181920F20
	public StringBuilder Append(object value) { }

	// RVA: 0x1920F60 Offset: 0x191F560 VA: 0x181920F60
	public StringBuilder Append(char[] value) { }

	// RVA: 0x19219C0 Offset: 0x191FFC0 VA: 0x1819219C0
	public StringBuilder Insert(int index, string value) { }

	// RVA: 0x1921A80 Offset: 0x1920080 VA: 0x181921A80
	public StringBuilder Insert(int index, char value) { }

	// RVA: 0x19205D0 Offset: 0x191EBD0 VA: 0x1819205D0
	public StringBuilder AppendFormat(string format, object arg0) { }

	// RVA: 0x1920550 Offset: 0x191EB50 VA: 0x181920550
	public StringBuilder AppendFormat(string format, object arg0, object arg1) { }

	// RVA: 0x1920430 Offset: 0x191EA30 VA: 0x181920430
	public StringBuilder AppendFormat(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1920350 Offset: 0x191E950 VA: 0x181920350
	public StringBuilder AppendFormat(string format, object[] args) { }

	// RVA: 0x19202D0 Offset: 0x191E8D0 VA: 0x1819202D0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x19204C0 Offset: 0x191EAC0 VA: 0x1819204C0
	public StringBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x19213E0 Offset: 0x191F9E0 VA: 0x1819213E0
	private static void FormatError() { }

	// RVA: 0x191FCA0 Offset: 0x191E2A0 VA: 0x18191FCA0
	internal StringBuilder AppendFormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x19234A0 Offset: 0x1921AA0 VA: 0x1819234A0
	public StringBuilder Replace(string oldValue, string newValue) { }

	// RVA: 0x1923030 Offset: 0x1921630 VA: 0x181923030
	public StringBuilder Replace(string oldValue, string newValue, int startIndex, int count) { }

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: 0x19207F0 Offset: 0x191EDF0 VA: 0x1819207F0
	public StringBuilder Append(char* value, int valueCount) { }

	// RVA: 0x1921450 Offset: 0x191FA50 VA: 0x181921450
	private void Insert(int index, char* value, int valueCount) { }

	// RVA: 0x1922B00 Offset: 0x1921100 VA: 0x181922B00
	private void ReplaceAllInChunk(int[] replacements, int replacementsCount, StringBuilder sourceChunk, int removeCount, string value) { }

	// RVA: 0x19234D0 Offset: 0x1921AD0 VA: 0x1819234D0
	private bool StartsWith(StringBuilder chunk, int indexInChunk, int count, string value) { }

	// RVA: 0x1922EF0 Offset: 0x19214F0 VA: 0x181922EF0
	private void ReplaceInPlaceAtChunk(ref StringBuilder chunk, ref int indexInChunk, char* value, int count) { }

	// RVA: 0x1923790 Offset: 0x1921D90 VA: 0x181923790
	private static void ThreadSafeCopy(char* sourcePtr, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x19236A0 Offset: 0x1921CA0 VA: 0x1819236A0
	private static void ThreadSafeCopy(char[] source, int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x19213A0 Offset: 0x191F9A0 VA: 0x1819213A0
	private StringBuilder FindChunkForIndex(int index) { }

	// RVA: 0x1922510 Offset: 0x1920B10 VA: 0x181922510
	private StringBuilder Next(StringBuilder chunk) { }

	// RVA: 0x19211F0 Offset: 0x191F7F0 VA: 0x1819211F0
	private void ExpandByABlock(int minBlockCharCount) { }

	// RVA: 0x1923F90 Offset: 0x1922590 VA: 0x181923F90
	private void .ctor(StringBuilder from) { }

	// RVA: 0x1922110 Offset: 0x1920710 VA: 0x181922110
	private void MakeRoom(int index, int count, out StringBuilder chunk, out int indexInChunk, bool doneMoveFollowingChars) { }

	// RVA: 0x1924330 Offset: 0x1922930 VA: 0x181924330
	private void .ctor(int size, int maxCapacity, StringBuilder previousBlock) { }

	// RVA: 0x1922560 Offset: 0x1920B60 VA: 0x181922560
	private void Remove(int startIndex, int count, out StringBuilder chunk, out int indexInChunk) { }

}

