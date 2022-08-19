public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 2773
{	// Properties
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 16
	internal virtual bool get_AllowHex() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract object FromString(string value, int radix);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	// RVA: 0x15BE3C0 Offset: 0x15BC9C0 VA: 0x1815BE3C0 Slot: 20
	internal virtual Exception FromStringError(string failedText, Exception innerException) { }

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x15BDD60 Offset: 0x15BC360 VA: 0x1815BDD60 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x15BDE50 Offset: 0x15BC450 VA: 0x1815BDE50 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x15BE140 Offset: 0x15BC740 VA: 0x1815BE140 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x15BDE10 Offset: 0x15BC410 VA: 0x1815BDE10 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type t) { }

	// RVA: 0x15BE590 Offset: 0x15BCB90 VA: 0x1815BE590
	protected void .ctor() { }

}

