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

	// RVA: 0x10957A0 Offset: 0x1093DA0 VA: 0x1810957A0
	public void .ctor(ProductHeaderValue product) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_Comment() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Comment(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public ProductHeaderValue get_Product() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Product(ProductHeaderValue value) { }

	// RVA: 0xD71D90 Offset: 0xD70390 VA: 0x180D71D90 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1095260 Offset: 0x1093860 VA: 0x181095260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1095320 Offset: 0x1093920 VA: 0x181095320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1095650 Offset: 0x1093C50 VA: 0x181095650
	internal static bool TryParse(string input, int minimalCount, out List<ProductInfoHeaderValue> result) { }

	// RVA: 0x10953A0 Offset: 0x10939A0 VA: 0x1810953A0
	private static bool TryParseElement(Lexer lexer, out ProductInfoHeaderValue parsedValue) { }

	// RVA: 0x1095370 Offset: 0x1093970 VA: 0x181095370 Slot: 3
	public override string ToString() { }

}

