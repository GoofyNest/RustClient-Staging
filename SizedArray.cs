internal sealed class SizedArray : ICloneable // TypeDefIndex: 1119
{
internal object[] objects;
internal object[] negObjects;

	internal object Item { get; set; }


	internal void .ctor() { }

	internal void .ctor(int length) { }

	private void .ctor(SizedArray sizedArray) { }

	public object Clone() { }

	internal object get_Item(int index) { }

	internal void set_Item(int index, object value) { }

	internal void IncreaseCapacity(int index) { }

}

