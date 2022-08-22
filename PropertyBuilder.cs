public abstract class PropertyBuilder : PropertyInfo // TypeDefIndex: 611
{
// Namespace: System.Reflection.Emit
public class ParameterBuilder // TypeDefIndex: 610

// Namespace: System.Reflection.Emit
public abstract class PropertyBuilder : PropertyInfo // TypeDefIndex: 611
	// Properties
	public override PropertyAttributes Attributes { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x18D4600 Offset: 0x18D2C00 VA: 0x1818D4600 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18D4650 Offset: 0x18D2C50 VA: 0x1818D4650 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18D46A0 Offset: 0x18D2CA0 VA: 0x1818D46A0 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18D46F0 Offset: 0x18D2CF0 VA: 0x1818D46F0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18D4740 Offset: 0x18D2D40 VA: 0x1818D4740 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D4790 Offset: 0x18D2D90 VA: 0x1818D4790 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18D44F0 Offset: 0x18D2AF0 VA: 0x1818D44F0 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18D47E0 Offset: 0x18D2DE0 VA: 0x1818D47E0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18D4430 Offset: 0x18D2A30 VA: 0x1818D4430 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18D4460 Offset: 0x18D2A60 VA: 0x1818D4460 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D4490 Offset: 0x18D2A90 VA: 0x1818D4490 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D44C0 Offset: 0x18D2AC0 VA: 0x1818D44C0 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18D4540 Offset: 0x18D2B40 VA: 0x1818D4540 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x18D4570 Offset: 0x18D2B70 VA: 0x1818D4570 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D45A0 Offset: 0x18D2BA0 VA: 0x1818D45A0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D45D0 Offset: 0x18D2BD0 VA: 0x1818D45D0 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

}

