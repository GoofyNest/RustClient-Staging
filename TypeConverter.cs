public class TypeConverter // TypeDefIndex: 2751
{	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x14430

	// Properties
	private static bool UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0x1739A90 Offset: 0x1738090 VA: 0x181739A90
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x1738990 Offset: 0x1736F90 VA: 0x181738990
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x1738910 Offset: 0x1736F10 VA: 0x181738910 Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1738A20 Offset: 0x1737020 VA: 0x181738A20
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x17389B0 Offset: 0x1736FB0 VA: 0x1817389B0 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1738C10 Offset: 0x1737210 VA: 0x181738C10
	public object ConvertFrom(object value) { }

	// RVA: 0x1738C90 Offset: 0x1737290 VA: 0x181738C90 Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1738AD0 Offset: 0x17370D0 VA: 0x181738AD0
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x1738A40 Offset: 0x1737040 VA: 0x181738A40
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1738BE0 Offset: 0x17371E0 VA: 0x181738BE0
	public object ConvertFromString(string text) { }

	// RVA: 0x1738B50 Offset: 0x1737150 VA: 0x181738B50
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x139BE80 Offset: 0x139A480 VA: 0x18139BE80
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x17390E0 Offset: 0x17376E0 VA: 0x1817390E0
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x1739110 Offset: 0x1737710 VA: 0x181739110 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1738D90 Offset: 0x1737390 VA: 0x181738D90
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x1738D00 Offset: 0x1737300 VA: 0x181738D00
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1738EF0 Offset: 0x17374F0 VA: 0x181738EF0
	public string ConvertToString(object value) { }

	// RVA: 0x1738FE0 Offset: 0x17375E0 VA: 0x181738FE0
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1738E10 Offset: 0x1737410 VA: 0x181738E10
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1739310 Offset: 0x1737910 VA: 0x181739310
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 8
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x1739330 Offset: 0x1737930 VA: 0x181739330
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x1739470 Offset: 0x1737A70 VA: 0x181739470
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x17395F0 Offset: 0x1737BF0 VA: 0x1817395F0
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 9
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1739630 Offset: 0x1737C30 VA: 0x181739630
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x1739740 Offset: 0x1737D40 VA: 0x181739740
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 10
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1739610 Offset: 0x1737C10 VA: 0x181739610
	public bool GetPropertiesSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 11
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x17398A0 Offset: 0x1737EA0 VA: 0x1817398A0
	public ICollection GetStandardValues() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 12
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1739860 Offset: 0x1737E60 VA: 0x181739860
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 13
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1739880 Offset: 0x1737E80 VA: 0x181739880
	public bool GetStandardValuesSupported() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 14
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x17398C0 Offset: 0x1737EC0 VA: 0x1817398C0
	public bool IsValid(object value) { }

	// RVA: 0x17398E0 Offset: 0x1737EE0 VA: 0x1817398E0 Slot: 15
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1739A50 Offset: 0x1738050 VA: 0x181739A50
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

	// RVA: 0x17342E0 Offset: 0x17328E0 VA: 0x1817342E0
	public void .ctor(ICollection values) { }

	// RVA: 0x1734280 Offset: 0x1732880 VA: 0x181734280
	public int get_Count() { }

	// RVA: 0x17341C0 Offset: 0x17327C0 VA: 0x1817341C0
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1734230 Offset: 0x1732830 VA: 0x181734230
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1734280 Offset: 0x1732880 VA: 0x181734280 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x52ED10 Offset: 0x52D310 VA: 0x18052ED10 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x17341C0 Offset: 0x17327C0 VA: 0x1817341C0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1734230 Offset: 0x1732830 VA: 0x181734230 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

