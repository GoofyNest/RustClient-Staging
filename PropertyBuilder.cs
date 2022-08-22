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

	// RVA: 0x18D4340 Offset: 0x18D2940 VA: 0x1818D4340 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18D4390 Offset: 0x18D2990 VA: 0x1818D4390 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18D43E0 Offset: 0x18D29E0 VA: 0x1818D43E0 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18D4430 Offset: 0x18D2A30 VA: 0x1818D4430 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18D4480 Offset: 0x18D2A80 VA: 0x1818D4480 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D44D0 Offset: 0x18D2AD0 VA: 0x1818D44D0 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18D4230 Offset: 0x18D2830 VA: 0x1818D4230 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18D4520 Offset: 0x18D2B20 VA: 0x1818D4520 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18D4170 Offset: 0x18D2770 VA: 0x1818D4170 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18D41A0 Offset: 0x18D27A0 VA: 0x1818D41A0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D41D0 Offset: 0x18D27D0 VA: 0x1818D41D0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D4200 Offset: 0x18D2800 VA: 0x1818D4200 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18D4280 Offset: 0x18D2880 VA: 0x1818D4280 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x18D42B0 Offset: 0x18D28B0 VA: 0x1818D42B0 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D42E0 Offset: 0x18D28E0 VA: 0x1818D42E0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D4310 Offset: 0x18D2910 VA: 0x1818D4310 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

}

