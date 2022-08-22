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

	// RVA: 0x18D3D20 Offset: 0x18D2320 VA: 0x1818D3D20 Slot: 17
	public override PropertyAttributes get_Attributes() { }

	// RVA: 0x18D3D70 Offset: 0x18D2370 VA: 0x1818D3D70 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x18D3DC0 Offset: 0x18D23C0 VA: 0x1818D3DC0 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x18D3E10 Offset: 0x18D2410 VA: 0x1818D3E10 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x18D3E60 Offset: 0x18D2460 VA: 0x1818D3E60 Slot: 8
	public override string get_Name() { }

	// RVA: 0x18D3EB0 Offset: 0x18D24B0 VA: 0x1818D3EB0 Slot: 20
	public override Type get_PropertyType() { }

	// RVA: 0x18D3C10 Offset: 0x18D2210 VA: 0x1818D3C10 Slot: 24
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x18D3F00 Offset: 0x18D2500 VA: 0x1818D3F00 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x18D3B50 Offset: 0x18D2150 VA: 0x1818D3B50 Slot: 21
	public override MethodInfo[] GetAccessors(bool nonPublic) { }

	// RVA: 0x18D3B80 Offset: 0x18D2180 VA: 0x1818D3B80 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D3BB0 Offset: 0x18D21B0 VA: 0x1818D3BB0 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D3BE0 Offset: 0x18D21E0 VA: 0x1818D3BE0 Slot: 23
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x18D3C60 Offset: 0x18D2260 VA: 0x1818D3C60 Slot: 26
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x18D3C90 Offset: 0x18D2290 VA: 0x1818D3C90 Slot: 28
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x18D3CC0 Offset: 0x18D22C0 VA: 0x1818D3CC0 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D3CF0 Offset: 0x18D22F0 VA: 0x1818D3CF0 Slot: 30
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

}

