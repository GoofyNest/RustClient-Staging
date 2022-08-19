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

	// RVA: 0x18D4380 Offset: 0x18D2980 VA: 0x1818D4380 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18D43D0 Offset: 0x18D29D0 VA: 0x1818D43D0 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18D4420 Offset: 0x18D2A20 VA: 0x1818D4420 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18D4470 Offset: 0x18D2A70 VA: 0x1818D4470 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18D44C0 Offset: 0x18D2AC0 VA: 0x1818D44C0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D4510 Offset: 0x18D2B10 VA: 0x1818D4510 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18D4270 Offset: 0x18D2870 VA: 0x1818D4270 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18D4560 Offset: 0x18D2B60 VA: 0x1818D4560 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18D41B0 Offset: 0x18D27B0 VA: 0x1818D41B0 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18D41E0 Offset: 0x18D27E0 VA: 0x1818D41E0 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D4210 Offset: 0x18D2810 VA: 0x1818D4210 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D4240 Offset: 0x18D2840 VA: 0x1818D4240 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18D42C0 Offset: 0x18D28C0 VA: 0x1818D42C0 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x18D42F0 Offset: 0x18D28F0 VA: 0x1818D42F0 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D4320 Offset: 0x18D2920 VA: 0x1818D4320 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D4350 Offset: 0x18D2950 VA: 0x1818D4350 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

}

