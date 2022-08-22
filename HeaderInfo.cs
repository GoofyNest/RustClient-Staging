internal class HeaderInfo // TypeDefIndex: 2915
{	// Fields
	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28

	// Methods

	// RVA: 0x133B570 Offset: 0x1339B70 VA: 0x18133B570
	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

internal abstract class HeaderInfo // TypeDefIndex: 5769
{	// Fields
	public bool AllowsMany; // 0x10
	public readonly HttpHeaderKind HeaderKind; // 0x14
	public readonly string Name; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Func<object, string> <CustomToString>k__BackingField; // 0x20

	// Properties
	public Func<object, string> CustomToString { get; set; }
	public virtual string Separator { get; }

	// Methods

	// RVA: 0x1088680 Offset: 0x1086C80 VA: 0x181088680
	protected void .ctor(string name, HttpHeaderKind headerKind) { }

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED44D0 Offset: 0xED2AD0 VA: 0x180ED44D0
	|-HeaderInfo.CreateSingle<byte[]>
	|-HeaderInfo.CreateSingle<DateTimeOffset>
	|-HeaderInfo.CreateSingle<int>
	|-HeaderInfo.CreateSingle<long>
	|-HeaderInfo.CreateSingle<AuthenticationHeaderValue>
	|-HeaderInfo.CreateSingle<CacheControlHeaderValue>
	|-HeaderInfo.CreateSingle<ContentDispositionHeaderValue>
	|-HeaderInfo.CreateSingle<ContentRangeHeaderValue>
	|-HeaderInfo.CreateSingle<EntityTagHeaderValue>
	|-HeaderInfo.CreateSingle<MediaTypeHeaderValue>
	|-HeaderInfo.CreateSingle<RangeConditionHeaderValue>
	|-HeaderInfo.CreateSingle<RangeHeaderValue>
	|-HeaderInfo.CreateSingle<RetryConditionHeaderValue>
	|-HeaderInfo.CreateSingle<object>
	|-HeaderInfo.CreateSingle<string>
	|-HeaderInfo.CreateSingle<TimeSpan>
	|-HeaderInfo.CreateSingle<Uri>
	*/

	// RVA: -1 Offset: -1
	public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED4430 Offset: 0xED2A30 VA: 0x180ED4430
	|-HeaderInfo.CreateMulti<AuthenticationHeaderValue>
	|-HeaderInfo.CreateMulti<EntityTagHeaderValue>
	|-HeaderInfo.CreateMulti<MediaTypeWithQualityHeaderValue>
	|-HeaderInfo.CreateMulti<NameValueHeaderValue>
	|-HeaderInfo.CreateMulti<NameValueWithParametersHeaderValue>
	|-HeaderInfo.CreateMulti<ProductHeaderValue>
	|-HeaderInfo.CreateMulti<ProductInfoHeaderValue>
	|-HeaderInfo.CreateMulti<StringWithQualityHeaderValue>
	|-HeaderInfo.CreateMulti<TransferCodingHeaderValue>
	|-HeaderInfo.CreateMulti<TransferCodingWithQualityHeaderValue>
	|-HeaderInfo.CreateMulti<ViaHeaderValue>
	|-HeaderInfo.CreateMulti<WarningHeaderValue>
	|-HeaderInfo.CreateMulti<object>
	|-HeaderInfo.CreateMulti<string>
	*/

	// RVA: 0x1088660 Offset: 0x1086C60 VA: 0x181088660
	public object CreateCollection(HttpHeaders headers) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Func<object, string> get_CustomToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0
	private void set_CustomToString(Func<object, string> value) { }

	// RVA: 0x10886D0 Offset: 0x1086CD0 VA: 0x1810886D0 Slot: 4
	public virtual string get_Separator() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddToCollection(object collection, object value);

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract List<string> ToStringCollection(object collection);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool TryParse(string value, out object result);

}

private class HeaderInfo.HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 5770
{	// Fields
	private readonly TryParseDelegate<T> parser; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1763E90 Offset: 0x1762490 VA: 0x181763E90
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<int, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<long, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<object, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void AddToCollection(object collection, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762A40 Offset: 0x1761040 VA: 0x181762A40
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.AddToCollection
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1762B70 Offset: 0x1761170 VA: 0x181762B70
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.CreateCollection
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override List<string> ToStringCollection(object collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17638F0 Offset: 0x1761EF0 VA: 0x1817638F0
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.ToStringCollection
	|
	|-RVA: 0x1763270 Offset: 0x1761870 VA: 0x181763270
	|-HeaderInfo.HeaderTypeInfo<int, object>.ToStringCollection
	|
	|-RVA: 0x17635B0 Offset: 0x1761BB0 VA: 0x1817635B0
	|-HeaderInfo.HeaderTypeInfo<long, object>.ToStringCollection
	|
	|-RVA: 0x1762F30 Offset: 0x1761530 VA: 0x181762F30
	|-HeaderInfo.HeaderTypeInfo<object, object>.ToStringCollection
	|
	|-RVA: 0x1762BF0 Offset: 0x17611F0 VA: 0x181762BF0
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.ToStringCollection
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1763CD0 Offset: 0x17622D0 VA: 0x181763CD0
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.TryParse
	|
	|-RVA: 0x1763C30 Offset: 0x1762230 VA: 0x181763C30
	|-HeaderInfo.HeaderTypeInfo<int, object>.TryParse
	|
	|-RVA: 0x1763D80 Offset: 0x1762380 VA: 0x181763D80
	|-HeaderInfo.HeaderTypeInfo<long, object>.TryParse
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.TryParse
	|
	|-RVA: 0x1763E30 Offset: 0x1762430 VA: 0x181763E30
	|-HeaderInfo.HeaderTypeInfo<object, object>.TryParse
	*/

}

private class HeaderInfo.CollectionHeaderTypeInfo<T, U> : HeaderInfo.HeaderTypeInfo<T, U> // TypeDefIndex: 5771
{	// Fields
	private readonly int minimalCount; // 0x0
	private readonly string separator; // 0x0
	private readonly TryParseListDelegate<T> parser; // 0x0

	// Properties
	public override string Separator { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175EF00 Offset: 0x175D500 VA: 0x18175EF00
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override string get_Separator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C33B0 Offset: 0x5C19B0 VA: 0x1805C33B0
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.get_Separator
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175EE80 Offset: 0x175D480 VA: 0x18175EE80
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.TryParse
	*/

}

