public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 2773
{	// Properties
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 16
	internal virtual bool get_AllowHex() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract object FromString(string value, int radix);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	// RVA: 0x15BD750 Offset: 0x15BBD50 VA: 0x1815BD750 Slot: 20
	internal virtual Exception FromStringError(string failedText, Exception innerException) { }

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x15BD0F0 Offset: 0x15BB6F0 VA: 0x1815BD0F0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x15BD1E0 Offset: 0x15BB7E0 VA: 0x1815BD1E0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x15BD4D0 Offset: 0x15BBAD0 VA: 0x1815BD4D0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x15BD1A0 Offset: 0x15BB7A0 VA: 0x1815BD1A0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type t) { }

	// RVA: 0x15BD920 Offset: 0x15BBF20 VA: 0x1815BD920
	protected void .ctor() { }

}

