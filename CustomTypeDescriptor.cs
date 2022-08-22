public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2681
{
// Namespace: System.ComponentModel
public class ComponentConverter : ReferenceConverter // TypeDefIndex: 2679

// Namespace: System.ComponentModel
public class CultureInfoConverter : TypeConverter // TypeDefIndex: 2680

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2681
	// Fields
	private ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x15BFD90 Offset: 0x15BE390 VA: 0x1815BFD90 Slot: 9
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x15BFE80 Offset: 0x15BE480 VA: 0x1815BFE80 Slot: 10
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x15BFF50 Offset: 0x15BE550 VA: 0x1815BFF50 Slot: 11
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x15C0040 Offset: 0x15BE640 VA: 0x1815C0040 Slot: 12
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x15C0130 Offset: 0x15BE730 VA: 0x1815C0130 Slot: 13
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }

}

