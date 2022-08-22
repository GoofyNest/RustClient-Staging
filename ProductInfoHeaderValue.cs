public class ProductInfoHeaderValue : ICloneable // TypeDefIndex: 5802
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <Comment>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private ProductHeaderValue <Product>k__BackingField; // 0x18

	// Properties
	public string Comment { get; set; }
	public ProductHeaderValue Product { get; set; }

	// Methods

	// RVA: 0x1094D30 Offset: 0x1093330 VA: 0x181094D30
	public void .ctor(ProductHeaderValue product) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ProductHeaderValue get_Product() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Product(ProductHeaderValue value) { }

	// RVA: 0xD712E0 Offset: 0xD6F8E0 VA: 0x180D712E0 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10947F0 Offset: 0x1092DF0 VA: 0x1810947F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10948B0 Offset: 0x1092EB0 VA: 0x1810948B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1094BE0 Offset: 0x10931E0 VA: 0x181094BE0
	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) { }

	// RVA: 0x1094930 Offset: 0x1092F30 VA: 0x181094930
	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

	// RVA: 0x1094900 Offset: 0x1092F00 VA: 0x181094900 Slot: 3
	public override string ToString() { }

}

