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

	// RVA: 0x15BE680 Offset: 0x15BCC80 VA: 0x1815BE680 Slot: 20
	internal virtual Exception FromStringError(string failedText, Exception innerException) { }

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x15BE020 Offset: 0x15BC620 VA: 0x1815BE020 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x15BE110 Offset: 0x15BC710 VA: 0x1815BE110 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x15BE400 Offset: 0x15BCA00 VA: 0x1815BE400 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x15BE0D0 Offset: 0x15BC6D0 VA: 0x1815BE0D0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type t) { }

	// RVA: 0x15BE850 Offset: 0x15BCE50 VA: 0x1815BE850
	protected void .ctor() { }

}

