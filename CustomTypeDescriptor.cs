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

	// RVA: 0x15BEE60 Offset: 0x15BD460 VA: 0x1815BEE60 Slot: 9
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x15BEF50 Offset: 0x15BD550 VA: 0x1815BEF50 Slot: 10
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x15BF020 Offset: 0x15BD620 VA: 0x1815BF020 Slot: 11
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x15BF110 Offset: 0x15BD710 VA: 0x1815BF110 Slot: 12
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x15BF200 Offset: 0x15BD800 VA: 0x1815BF200 Slot: 13
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }

}

