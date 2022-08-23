internal class HeaderInfo // TypeDefIndex: 2915
{	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28


	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }

}

internal abstract class HeaderInfo // TypeDefIndex: 5769
{	public bool AllowsMany; // 0x10
	public readonly HttpHeaderKind HeaderKind; // 0x14
	public readonly string Name; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private Func<object, string> <CustomToString>k__BackingField; // 0x20

	public Func<object, string> CustomToString { get; set; }
	public virtual string Separator { get; }


	protected void .ctor(string name, HttpHeaderKind headerKind) { }

	public static HeaderInfo CreateSingle<T>(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind, Func<object, string> toString) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED5380 Offset: 0xED3980 VA: 0x180ED5380
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

	public static HeaderInfo CreateMulti<T>(string name, TryParseListDelegate<T> elementParser, HttpHeaderKind headerKind, int minimalCount = 1, string separator = ", ") { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED52E0 Offset: 0xED38E0 VA: 0x180ED52E0
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

	public object CreateCollection(HttpHeaders headers) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public Func<object, string> get_CustomToString() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_CustomToString(Func<object, string> value) { }

	public virtual string get_Separator() { }

	public abstract void AddToCollection(object collection, object value);

	protected abstract object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo);

	public abstract List<string> ToStringCollection(object collection);

	public abstract bool TryParse(string value, out object result);

}

private class HeaderInfo.HeaderTypeInfo<T, U> : HeaderInfo // TypeDefIndex: 5770
{	private readonly TryParseDelegate<T> parser; // 0x0


	public void .ctor(string name, TryParseDelegate<T> parser, HttpHeaderKind headerKind) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761E20 Offset: 0x1760420 VA: 0x181761E20
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<int, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<long, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<object, object>..ctor
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>..ctor
	*/

	public override void AddToCollection(object collection, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17609D0 Offset: 0x175EFD0 VA: 0x1817609D0
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.AddToCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.AddToCollection
	*/

	protected override object CreateCollection(HttpHeaders headers, HeaderInfo headerInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1760B00 Offset: 0x175F100 VA: 0x181760B00
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<int, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<long, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<object, object>.CreateCollection
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.CreateCollection
	*/

	public override List<string> ToStringCollection(object collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761880 Offset: 0x175FE80 VA: 0x181761880
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.ToStringCollection
	|
	|-RVA: 0x1761200 Offset: 0x175F800 VA: 0x181761200
	|-HeaderInfo.HeaderTypeInfo<int, object>.ToStringCollection
	|
	|-RVA: 0x1761540 Offset: 0x175FB40 VA: 0x181761540
	|-HeaderInfo.HeaderTypeInfo<long, object>.ToStringCollection
	|
	|-RVA: 0x1760EC0 Offset: 0x175F4C0 VA: 0x181760EC0
	|-HeaderInfo.HeaderTypeInfo<object, object>.ToStringCollection
	|
	|-RVA: 0x1760B80 Offset: 0x175F180 VA: 0x181760B80
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.ToStringCollection
	*/

	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1761C60 Offset: 0x1760260 VA: 0x181761C60
	|-HeaderInfo.HeaderTypeInfo<DateTimeOffset, object>.TryParse
	|
	|-RVA: 0x1761BC0 Offset: 0x17601C0 VA: 0x181761BC0
	|-HeaderInfo.HeaderTypeInfo<int, object>.TryParse
	|
	|-RVA: 0x1761D10 Offset: 0x1760310 VA: 0x181761D10
	|-HeaderInfo.HeaderTypeInfo<long, object>.TryParse
	|-HeaderInfo.HeaderTypeInfo<TimeSpan, object>.TryParse
	|
	|-RVA: 0x1761DC0 Offset: 0x17603C0 VA: 0x181761DC0
	|-HeaderInfo.HeaderTypeInfo<object, object>.TryParse
	*/

}

private class HeaderInfo.CollectionHeaderTypeInfo<T, U> : HeaderInfo.HeaderTypeInfo<T, U> // TypeDefIndex: 5771
{	private readonly int minimalCount; // 0x0
	private readonly string separator; // 0x0
	private readonly TryParseListDelegate<T> parser; // 0x0

	public override string Separator { get; }


	public void .ctor(string name, TryParseListDelegate<T> parser, HttpHeaderKind headerKind, int minimalCount, string separator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175CEC0 Offset: 0x175B4C0 VA: 0x18175CEC0
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>..ctor
	*/

	public override string get_Separator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5C3410 Offset: 0x5C1A10 VA: 0x1805C3410
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.get_Separator
	*/

	public override bool TryParse(string value, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x175CE40 Offset: 0x175B440 VA: 0x18175CE40
	|-HeaderInfo.CollectionHeaderTypeInfo<object, object>.TryParse
	*/

}

