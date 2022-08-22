public class TypeConverter // TypeDefIndex: 2751
{	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x2B10380

	// Properties
	private static bool UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0x1737910 Offset: 0x1735F10 VA: 0x181737910
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x1736810 Offset: 0x1734E10 VA: 0x181736810
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x1736790 Offset: 0x1734D90 VA: 0x181736790 Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x17368A0 Offset: 0x1734EA0 VA: 0x1817368A0
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x1736830 Offset: 0x1734E30 VA: 0x181736830 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1736A90 Offset: 0x1735090 VA: 0x181736A90
	public object ConvertFrom(object value) { }

	// RVA: 0x1736B10 Offset: 0x1735110 VA: 0x181736B10 Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1736950 Offset: 0x1734F50 VA: 0x181736950
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x17368C0 Offset: 0x1734EC0 VA: 0x1817368C0
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1736A60 Offset: 0x1735060 VA: 0x181736A60
	public object ConvertFromString(string text) { }

	// RVA: 0x17369D0 Offset: 0x1734FD0 VA: 0x1817369D0
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x139B240 Offset: 0x1399840 VA: 0x18139B240
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x1736F60 Offset: 0x1735560 VA: 0x181736F60
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x1736F90 Offset: 0x1735590 VA: 0x181736F90 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1736C10 Offset: 0x1735210 VA: 0x181736C10
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x1736B80 Offset: 0x1735180 VA: 0x181736B80
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1736D70 Offset: 0x1735370 VA: 0x181736D70
	public string ConvertToString(object value) { }

	// RVA: 0x1736E60 Offset: 0x1735460 VA: 0x181736E60
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1736C90 Offset: 0x1735290 VA: 0x181736C90
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1737190 Offset: 0x1735790 VA: 0x181737190
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 8
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x17371B0 Offset: 0x17357B0 VA: 0x1817371B0
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x17372F0 Offset: 0x17358F0 VA: 0x1817372F0
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x1737470 Offset: 0x1735A70 VA: 0x181737470
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x17374B0 Offset: 0x1735AB0 VA: 0x1817374B0
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x17375C0 Offset: 0x1735BC0 VA: 0x1817375C0
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 10
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1737490 Offset: 0x1735A90 VA: 0x181737490
	public bool GetPropertiesSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1737720 Offset: 0x1735D20 VA: 0x181737720
	public ICollection GetStandardValues() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 12
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x17376E0 Offset: 0x1735CE0 VA: 0x1817376E0
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1737700 Offset: 0x1735D00 VA: 0x181737700
	public bool GetStandardValuesSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1737740 Offset: 0x1735D40 VA: 0x181737740
	public bool IsValid(object value) { }

	// RVA: 0x1737760 Offset: 0x1735D60 VA: 0x181737760 Slot: 15
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x17378D0 Offset: 0x1735ED0 VA: 0x1817378D0
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

	// RVA: 0x1732160 Offset: 0x1730760 VA: 0x181732160
	public void .ctor(ICollection values) { }

	// RVA: 0x1732100 Offset: 0x1730700 VA: 0x181732100
	public int get_Count() { }

	// RVA: 0x1732040 Offset: 0x1730640 VA: 0x181732040
	public void CopyTo(Array array, int index) { }

	// RVA: 0x17320B0 Offset: 0x17306B0 VA: 0x1817320B0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1732100 Offset: 0x1730700 VA: 0x181732100 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ECA0 Offset: 0x52D2A0 VA: 0x18052ECA0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1732040 Offset: 0x1730640 VA: 0x181732040 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x17320B0 Offset: 0x17306B0 VA: 0x1817320B0 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

