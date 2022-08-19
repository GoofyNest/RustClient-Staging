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

	// RVA: 0x15BFAD0 Offset: 0x15BE0D0 VA: 0x1815BFAD0 Slot: 9
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x15BFBC0 Offset: 0x15BE1C0 VA: 0x1815BFBC0 Slot: 10
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x15BFC90 Offset: 0x15BE290 VA: 0x1815BFC90 Slot: 11
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x15BFD80 Offset: 0x15BE380 VA: 0x1815BFD80 Slot: 12
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x15BFE70 Offset: 0x15BE470 VA: 0x1815BFE70 Slot: 13
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }

}

