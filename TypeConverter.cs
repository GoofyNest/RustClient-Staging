public class TypeConverter // TypeDefIndex: 2751
{	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x14430

	// Properties
	private static bool UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0x1739D50 Offset: 0x1738350 VA: 0x181739D50
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x1738C50 Offset: 0x1737250 VA: 0x181738C50
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x1738BD0 Offset: 0x17371D0 VA: 0x181738BD0 Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1738CE0 Offset: 0x17372E0 VA: 0x181738CE0
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x1738C70 Offset: 0x1737270 VA: 0x181738C70 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1738ED0 Offset: 0x17374D0 VA: 0x181738ED0
	public object ConvertFrom(object value) { }

	// RVA: 0x1738F50 Offset: 0x1737550 VA: 0x181738F50 Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1738D90 Offset: 0x1737390 VA: 0x181738D90
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x1738D00 Offset: 0x1737300 VA: 0x181738D00
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1738EA0 Offset: 0x17374A0 VA: 0x181738EA0
	public object ConvertFromString(string text) { }

	// RVA: 0x1738E10 Offset: 0x1737410 VA: 0x181738E10
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x139C140 Offset: 0x139A740 VA: 0x18139C140
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x17393A0 Offset: 0x17379A0 VA: 0x1817393A0
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x17393D0 Offset: 0x17379D0 VA: 0x1817393D0 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1739050 Offset: 0x1737650 VA: 0x181739050
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x1738FC0 Offset: 0x17375C0 VA: 0x181738FC0
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x17391B0 Offset: 0x17377B0 VA: 0x1817391B0
	public string ConvertToString(object value) { }

	// RVA: 0x17392A0 Offset: 0x17378A0 VA: 0x1817392A0
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x17390D0 Offset: 0x17376D0 VA: 0x1817390D0
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x17395D0 Offset: 0x1737BD0 VA: 0x1817395D0
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x17395F0 Offset: 0x1737BF0 VA: 0x1817395F0
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x1739730 Offset: 0x1737D30 VA: 0x181739730
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x17398B0 Offset: 0x1737EB0 VA: 0x1817398B0
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x17398F0 Offset: 0x1737EF0 VA: 0x1817398F0
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x1739A00 Offset: 0x1738000 VA: 0x181739A00
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x17398D0 Offset: 0x1737ED0 VA: 0x1817398D0
	public bool GetPropertiesSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1739B60 Offset: 0x1738160 VA: 0x181739B60
	public ICollection GetStandardValues() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1739B20 Offset: 0x1738120 VA: 0x181739B20
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1739B40 Offset: 0x1738140 VA: 0x181739B40
	public bool GetStandardValuesSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1739B80 Offset: 0x1738180 VA: 0x181739B80
	public bool IsValid(object value) { }

	// RVA: 0x1739BA0 Offset: 0x17381A0 VA: 0x181739BA0 Slot: 15
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1739D10 Offset: 0x1738310 VA: 0x181739D10
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

public class TypeConverter.StandardValuesCollection : ICollection, IEnumerable // TypeDefIndex: 2753
{	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Properties
	public int Count { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x17345A0 Offset: 0x1732BA0 VA: 0x1817345A0
	public void .ctor(ICollection values) { }

	// RVA: 0x1734540 Offset: 0x1732B40 VA: 0x181734540
	public int get_Count() { }

	// RVA: 0x1734480 Offset: 0x1732A80 VA: 0x181734480
	public void CopyTo(Array array, int index) { }

	// RVA: 0x17344F0 Offset: 0x1732AF0 VA: 0x1817344F0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1734540 Offset: 0x1732B40 VA: 0x181734540 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1734480 Offset: 0x1732A80 VA: 0x181734480 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x17344F0 Offset: 0x1732AF0 VA: 0x1817344F0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

